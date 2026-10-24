using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_1
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient;
        private Thread receiveThread;
        private bool isRunning = false; // флаг подключения к симулятору
        private int commandCounter = 0; //номер команды

        private bool isAutoMode = false; //флаг вкл/выкл авто режима

        private int autoPhase = 0; // 0 - случайный поиск, 1 - разворот влево, 2 - движение по линии
        private int phaseTimer = 0; // счетчик для фазы
        private Random rnd = new Random(); // для случайных поворотов

        private int gapTimer = 0; // счетчик, сколько времени нет линии
        private const int MAX_GAP_TICKS = 100; // максимально время потери

        private bool turnRightNext = true; // флаг чередования

        private int lastBalance = 0;

        private double currentX = 0.75;      // Стартовая координата X 
        private double currentY = 0.75;      // Стартовая координата Y 
        private double currentTheta = 0;     // Курс 

        private int lastLe = 0;              // Предыдущее значение левого энкодера
        private int lastRe = 0;              // Предыдущее значение правого энкодера
        private const double WheelBaseM = 0.40;
        private const double TicksToMeters = (Math.PI * 0.1651) / 200.0; // Коэффициент перевода тиков в метры

        private int latestLe = 0; // последнее значение левого энкодера от симулятора
        private int latestRe = 0; // последнее значение правого энкодера от симулятора

        private Bitmap mapBitmap;
        private Graphics mapGraphics;
        private const double Scale = 35.0;

        private readonly double[] sensorAngles = {
            0, Math.PI / 4, Math.PI / 2, 3 * Math.PI / 4,
            Math.PI, -3 * Math.PI / 4, -Math.PI / 2, -Math.PI / 4
        };

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            InitializeMap();
        }

        private void InitializeMap()
        {
            mapBitmap = new Bitmap(pbMap.Width, pbMap.Height);
            mapGraphics = Graphics.FromImage(mapBitmap);
            mapGraphics.Clear(Color.White);
            pbMap.Image = mapBitmap;
        }

        private void StartUdpServer() // подключение к симулятору
        {
            try
            {
                int localPort = int.Parse(txtLocalPort.Text);
                udpClient = new UdpClient(localPort);
                isRunning = true;

                // запуск отдельного потока
                receiveThread = new Thread(new ThreadStart(ReceiveData));
                receiveThread.IsBackground = true;
                receiveThread.Start();

                lblStatus.Text = "Статус: Подключено";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}");
            }
        }

        private void ReceiveData() //получение пакетов от симулятора
        {
            IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);

            while (isRunning) // пока подключены
            {
                try
                {
                    byte[] data = udpClient.Receive(ref remoteEndPoint); // перевод полученной JSON строки в байты
                    string message = Encoding.UTF8.GetString(data); // перевод байтов в читаемую строку

                    // обновление интерфейса
                    this.Invoke((MethodInvoker)delegate {
                        UpdateUI(message);
                    });
                }
                catch (Exception ex)
                {
                    if (isRunning)
                    {
                        Console.WriteLine($"Ошибка приема: {ex.Message}");
                    }
                }
            }
        }

        private void UpdateUI(string message) //обработка полученного сообщения
        {
            message = message.Trim();

            if (string.IsNullOrEmpty(message) || message == "0" || message.Contains("0 0 0 0 0"))
            {
                return;
            }

            if (message.Contains("{") && message.Contains("}"))
            {

                txtRawData.AppendText(message + Environment.NewLine);
                txtRawData.AppendText(new string('-', 50) + Environment.NewLine);

                txtRawData.SelectionStart = txtRawData.Text.Length;
                txtRawData.ScrollToCaret();

                if (txtRawData.Text.Length > 10000)
                {
                    int cutOff = txtRawData.Text.IndexOf(Environment.NewLine);
                    if (cutOff > 0)
                    {
                        txtRawData.Text = txtRawData.Text.Substring(cutOff);
                    }
                }
                ParseAndDisplayData(message);
            }
        }

        private void ParseAndDisplayData(string jsonMessage) //разбиение сообщения по параметрам данных
        {
            try
            {
                int le = int.Parse(GetJsonValue(jsonMessage, "le"));
                int re = int.Parse(GetJsonValue(jsonMessage, "re"));

                latestLe = le;
                latestRe = re;

                txtLeftEncoder.Text = le.ToString();
                txtRightEncoder.Text = re.ToString();

                UpdateOdometry(le, re);

                txtX.Text = currentX.ToString("F2");
                txtY.Text = currentY.ToString("F2");

                double thetaDeg = (currentTheta * 180.0 / Math.PI) % 360;
                if (thetaDeg < 0) thetaDeg += 360;
                txtTheta.Text = thetaDeg.ToString("F1");


                txtCommandNum.Text = GetJsonValue(jsonMessage, "n");

                txtStatus.Text = GetJsonValue(jsonMessage, "s");
                txtCode.Text = GetJsonValue(jsonMessage, "c");

                txtLeftEncoder.Text = GetJsonValue(jsonMessage, "le");
                txtRightEncoder.Text = GetJsonValue(jsonMessage, "re");

                string bVal = GetJsonValue(jsonMessage, "b");
                txtBumper.Text = bVal;

                string simX = GetJsonValue(jsonMessage, "x");
                string simY = GetJsonValue(jsonMessage, "y");
                string simT = GetJsonValue(jsonMessage, "t");

                txtSimX.Text = simX;
                txtSimY.Text = simY;
                txtSimTheta.Text = simT;

                txtD0.Text = GetJsonValue(jsonMessage, "d0");
                txtD1.Text = GetJsonValue(jsonMessage, "d1");
                txtD2.Text = GetJsonValue(jsonMessage, "d2");
                txtD3.Text = GetJsonValue(jsonMessage, "d3");
                txtD4.Text = GetJsonValue(jsonMessage, "d4");
                txtD5.Text = GetJsonValue(jsonMessage, "d5");
                txtD6.Text = GetJsonValue(jsonMessage, "d6");
                txtD7.Text = GetJsonValue(jsonMessage, "d7");

                txtL0.Text = GetJsonValue(jsonMessage, "l0");
                txtL1.Text = GetJsonValue(jsonMessage, "l1");
                txtL2.Text = GetJsonValue(jsonMessage, "l2");
                txtL3.Text = GetJsonValue(jsonMessage, "l3");
                txtL4.Text = GetJsonValue(jsonMessage, "l4");

                txtAzimuth.Text = GetJsonValue(jsonMessage, "az");
                txtDistance.Text = GetJsonValue(jsonMessage, "ad");

                int[] d = new int[8];
                for (int i = 0; i < 8; i++)
                {
                    d[i] = int.Parse(GetJsonValue(jsonMessage, $"d{i}"));
                    this.Controls.Find($"txtD{i}", true)[0].Text = d[i].ToString();
                }

                for (int i = 0; i < 5; i++)
                {
                    this.Controls.Find($"txtL{i}", true)[0].Text = GetJsonValue(jsonMessage, $"l{i}");
                }

                txtAzimuth.Text = GetJsonValue(jsonMessage, "az");
                txtDistance.Text = GetJsonValue(jsonMessage, "ad");

                DrawMap(d);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка парсинга: {ex.Message}");
            }
        }

        private string GetJsonValue(string json, string key) //поиск символов в строке
        {
            string searchPattern = $"\"{key}\":";
            int keyIndex = json.IndexOf(searchPattern);

            if (keyIndex == -1)
                return "0";

            int valueStart = keyIndex + searchPattern.Length;

            while (valueStart < json.Length && (json[valueStart] == ' ' || json[valueStart] == '"'))
                valueStart++;

            int valueEnd = valueStart;
            while (valueEnd < json.Length && json[valueEnd] != ',' && json[valueEnd] != '}' && json[valueEnd] != '"')
                valueEnd++;

            if (valueStart >= valueEnd)
                return "0";

            string value = json.Substring(valueStart, valueEnd - valueStart).Trim();

            return string.IsNullOrEmpty(value) ? "0" : value;
        }

        private void SendCommand(int f, int b) //сборка и отправка команды в симулятор
        {
            if (!isRunning || udpClient == null) return;

            try
            {
                commandCounter++;

                string json = $"{{\"N\":{commandCounter},\"M\":0,\"F\":{f},\"B\":{b},\"T\":0}}\n";

                string remoteIp = txtRemoteIP.Text;
                int remotePort = int.Parse(txtRemotePort.Text);

                byte[] data = Encoding.UTF8.GetBytes(json);
                udpClient.Send(data, data.Length, remoteIp, remotePort);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка отправки: {ex.Message}");
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                StartUdpServer();
                btnConnect.Text = "Отключиться";
            }
            else
            {
                StopUdpServer();
                btnConnect.Text = "Подключиться";
            }
        }

        private void StopUdpServer() //завершение работы соединения
        {
            isRunning = false;

            if (udpClient != null)
            {
                udpClient.Close();
            }

            if (receiveThread != null && receiveThread.IsAlive)
            {
                receiveThread.Join(1000);
            }

            lblStatus.Text = "Статус: Отключено";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isRunning) StopUdpServer();

            mapGraphics?.Dispose();
            mapBitmap?.Dispose();
        }

        private void btnSendManual_Click(object sender, EventArgs e)
        {
            int f = int.Parse(txtForce.Text);
            int b = int.Parse(txtBalance.Text);
            SendCommand(f, b);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tbForce.Value = 0;
            tbBalance.Value = 0;
            txtForce.Text = "0";
            txtBalance.Text = "0";
            SendCommand(0, 0);
        }

        private void tbForce_Scroll(object sender, EventArgs e)
        {
            txtForce.Text = tbForce.Value.ToString();
        }

        private void tbBalance_Scroll(object sender, EventArgs e)
        {
            txtBalance.Text = tbBalance.Value.ToString();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            tbForce.Value = 50;
            tbBalance.Value = 0;
            txtForce.Text = "50";
            txtBalance.Text = "0";
            SendCommand(50, 0);
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            tbForce.Value = -50;
            tbBalance.Value = 0;
            txtForce.Text = "-50";
            txtBalance.Text = "0";
            SendCommand(-50, 0);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            tbForce.Value = 0;
            tbBalance.Value = 30;
            txtForce.Text = "0";
            txtBalance.Text = "30";
            SendCommand(0, 30);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            tbForce.Value = 0;
            tbBalance.Value = -30;
            txtForce.Text = "0";
            txtBalance.Text = "-30";
            SendCommand(0, -30);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.W:
                    btnForward_Click(sender, e);
                    break;

                case Keys.Down:
                case Keys.S:
                    btnBackward_Click(sender, e);
                    break;

                case Keys.Left:
                case Keys.A:
                    btnLeft_Click(sender, e);
                    break;

                case Keys.Right:
                case Keys.D:
                    btnRight_Click(sender, e);
                    break;

                case Keys.Space:
                    btnStop_Click(sender, e);
                    break;
            }
        }

        private void tmrAutoControl_Tick(object sender, EventArgs e) //отслеживает фазы авто режима
        {
            if (!isAutoMode) return;

            if (autoPhase != 2)
            {
                int b = int.Parse(txtBumper.Text);
                int d0 = int.Parse(txtD0.Text);
                int d1 = int.Parse(txtD1.Text);
                int d7 = int.Parse(txtD7.Text);

                if (b == 1 || d0 < 16 || d1 < 16 || d7 < 16)
                {
                    SendCommand(-40, -30);
                    lblAutoStatus.Text = "Статус: Объезд препятствия!";
                    return;
                }
            }

            switch (autoPhase)
            {
                case 0: // поворот к линии
                    phaseTimer++;
                    SendCommand(0, -30);
                    lblAutoStatus.Text = $"Статус: Поворот вправо ({phaseTimer}/15)";

                    if (phaseTimer >= 15)
                    {
                        autoPhase = 1;
                        phaseTimer = 0;
                    }
                    break;

                case 1: // движение к линии
                    SendCommand(40, 0);

                    if (txtCode.Text == "2" || int.Parse(txtL0.Text) < 50)
                    {
                        autoPhase = 2;
                        phaseTimer = 0;
                    }
                    else
                    {
                        lblAutoStatus.Text = "Статус: Движение к линии";
                    }
                    break;

                case 2: // поворот налево, чтобы ехать по часовой
                    phaseTimer++;
                    SendCommand(0, 40);
                    lblAutoStatus.Text = $"Статус: Выравнивание на линии ({phaseTimer}/15)";

                    if (phaseTimer > 15)
                    {
                        autoPhase = 3;
                        phaseTimer = 0;
                        gapTimer = 0;
                    }
                    break;

                case 3: // движение по линии
                    int l0 = int.Parse(txtL0.Text);
                    int l1 = int.Parse(txtL1.Text);
                    int l2 = int.Parse(txtL2.Text);
                    int l3 = int.Parse(txtL3.Text);
                    int l4 = int.Parse(txtL4.Text);

                    int d2 = int.Parse(txtD2.Text);
                    int d6 = int.Parse(txtD6.Text);
                    int d1 = int.Parse(txtD1.Text);
                    int d7 = int.Parse(txtD7.Text);
                    int d0 = int.Parse(txtD0.Text);
                    int d3 = int.Parse(txtD3.Text);
                    int d5 = int.Parse(txtD5.Text);

                    bool lineFound = false;
                    int balance = 0;
                    int force = 40;
                    int errorSum = 0;
                    int activeSensors = 0;

                    // избежание детекции стенки световым датчиком
                    bool wallOnRight = (d0 < 12) || (d1 < 10) || (d2 < 10) || (d3 < 10);
                    if (wallOnRight)
                    {
                        l4 = 100;
                    }
                    bool wallOnLeft = (d0 < 12) || (d7 < 10) || (d6 < 10) || (d5 < 10);
                    if (wallOnLeft)
                    {
                        l3 = 100;
                    }
                    //----------------------------------------------------------

                    // веса для датчиков света
                    if (l3 < 50) { errorSum += 30; activeSensors++; }
                    if (l1 < 50) { errorSum += 15; activeSensors++; }
                    if (l0 < 50) { errorSum += 0; activeSensors++; }
                    if (l2 < 50) { errorSum -= 15; activeSensors++; }
                    if (l4 < 50) { errorSum -= 30; activeSensors++; }

                    if (activeSensors > 0)
                    {
                        // средний баланс
                        balance = (errorSum / activeSensors) * 2;

                        // ограничение до 50
                        if (balance > 50) balance = 50;
                        if (balance < -50) balance = -50;

                        gapTimer = 0;
                        lastBalance = balance;
                        SendCommand(force, balance);
                        lineFound = true;
                        string wallInfo = "";
                        if (wallOnRight) wallInfo += " [Стенка справа]";
                        if (wallOnLeft) wallInfo += " [Стенка слева]";
                        lblAutoStatus.Text = $"Статус: Движение по линии (B={balance}){wallInfo}";
                    }
                    else
                    {
                        gapTimer++;
                        SendCommand(force, 0);
                        lblAutoStatus.Text = $"Статус: Пунктир/потеря ({gapTimer}/{MAX_GAP_TICKS})";

                        if (gapTimer > MAX_GAP_TICKS)
                        {
                            autoPhase = 0;
                            gapTimer = 0;
                            lastBalance = 0;
                            lblAutoStatus.Text = "Статус: Линия потеряна, поиск";
                        }
                    }
                    break;
            }
        }

        private void btnStartAuto_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                MessageBox.Show("Сначала подключитесь к симулятору!");
                return;
            }

            if (!isAutoMode)
            {
                isAutoMode = true;

                tmrAutoControl.Enabled = true;
                btnStartAuto.Text = "Стоп авто";
                lblAutoStatus.Text = "Статус: Выполнение";
                autoPhase = 0;
                phaseTimer = 0;
                gapTimer = 0;
            }
            else
            {
                StopAutoMode();
            }
        }

        private void StopAutoMode()
        {
            isAutoMode = false;
            tmrAutoControl.Enabled = false;
            SendCommand(0, 0);

            btnStartAuto.Text = "Старт авто";
            lblAutoStatus.Text = "Статус: Остановлен";

            autoPhase = 0;
            phaseTimer = 0;
            gapTimer = 0;
        }

        private void UpdateOdometry(int currentLe, int currentRe) // определение положения
        {
            double deltaL_ticks = currentLe - lastLe;
            double deltaR_ticks = currentRe - lastRe;

            double deltaL_m = deltaL_ticks * TicksToMeters;
            double deltaR_m = deltaR_ticks * TicksToMeters;

            double deltaS_m = (deltaL_m + deltaR_m) / 2.0;

            double deltaTheta = (deltaL_m - deltaR_m) / WheelBaseM;

            currentTheta += deltaTheta;

            currentX += deltaS_m * Math.Sin(currentTheta);
            currentY += deltaS_m * Math.Cos(currentTheta);

            lastLe = currentLe;
            lastRe = currentRe;
        }

        private void pbMap_Click(object sender, EventArgs e)
        {

        }

        private void btnResetMap_Click(object sender, EventArgs e)
        {
            currentX = 0.75;
            currentY = 0.75;
            currentTheta = 0;

            lastLe = latestLe;
            lastRe = latestRe;

            txtX.Text = "0.75";
            txtY.Text = "0.75";
            txtTheta.Text = "0.0";

            if (mapGraphics != null)
            {
                mapGraphics.Clear(Color.White);
                pbMap.Refresh();
            }
        }

        private void DrawMap(int[] d) // отрисовка карты
        {
            int screenX = (int)(currentX * Scale);
            int screenY = pbMap.Height - (int)(currentY * Scale);

            using (SolidBrush robotBrush = new SolidBrush(Color.Orange))
            {
                mapGraphics.FillEllipse(robotBrush, screenX - 2, screenY - 2, 4, 4);
            }

            using (SolidBrush obsBrush = new SolidBrush(Color.Blue))
            {
                for (int i = 0; i < 8; i++)
                {
                    if (d[i] > 0 && d[i] < 300)
                    {
                        double distM = (d[i] / 100.0) + 0.30;
                        double sensorAngle = sensorAngles[i];

                        double globalDirection = currentTheta + sensorAngle;

                        double globalX = currentX + distM * Math.Sin(globalDirection);
                        double globalY = currentY + distM * Math.Cos(globalDirection);

                        int obsScreenX = (int)(globalX * Scale);
                        int obsScreenY = pbMap.Height - (int)(globalY * Scale);

                        mapGraphics.FillRectangle(obsBrush, obsScreenX - 2, obsScreenY - 2, 4, 4);
                    }
                }
            }

            pbMap.Refresh();
        }
    }
}
