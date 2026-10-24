namespace Lab_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtLocalPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemotePort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRemoteIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtL4 = new System.Windows.Forms.TextBox();
            this.txtSimTheta = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtL2 = new System.Windows.Forms.TextBox();
            this.txtSimY = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtL0 = new System.Windows.Forms.TextBox();
            this.txtSimX = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtL1 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtL3 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtAzimuth = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtD7 = new System.Windows.Forms.TextBox();
            this.txtD6 = new System.Windows.Forms.TextBox();
            this.txtD5 = new System.Windows.Forms.TextBox();
            this.txtD4 = new System.Windows.Forms.TextBox();
            this.txtD3 = new System.Windows.Forms.TextBox();
            this.txtD2 = new System.Windows.Forms.TextBox();
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.txtD0 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBumper = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRightEncoder = new System.Windows.Forms.TextBox();
            this.txtLeftEncoder = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCommandNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRawData = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAutoStatus = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStartAuto = new System.Windows.Forms.Button();
            this.btnSendManual = new System.Windows.Forms.Button();
            this.tbBalance = new System.Windows.Forms.TrackBar();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbForce = new System.Windows.Forms.TrackBar();
            this.txtForce = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tmrAutoControl = new System.Windows.Forms.Timer(this.components);
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnResetMap = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.txtTheta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbConnection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbForce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.BackColor = System.Drawing.Color.Brown;
            this.gbConnection.Controls.Add(this.lblStatus);
            this.gbConnection.Controls.Add(this.btnConnect);
            this.gbConnection.Controls.Add(this.txtLocalPort);
            this.gbConnection.Controls.Add(this.label3);
            this.gbConnection.Controls.Add(this.txtRemotePort);
            this.gbConnection.Controls.Add(this.label2);
            this.gbConnection.Controls.Add(this.txtRemoteIP);
            this.gbConnection.Controls.Add(this.label1);
            this.gbConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbConnection.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbConnection.Location = new System.Drawing.Point(14, 13);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(881, 211);
            this.gbConnection.TabIndex = 0;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "UDP подключение";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(283, 157);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(257, 31);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Статус: Отключено";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(14, 106);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(240, 58);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Подключится";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtLocalPort
            // 
            this.txtLocalPort.Location = new System.Drawing.Point(677, 106);
            this.txtLocalPort.Name = "txtLocalPort";
            this.txtLocalPort.Size = new System.Drawing.Size(183, 38);
            this.txtLocalPort.TabIndex = 5;
            this.txtLocalPort.Text = "5001";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Локальный порт:";
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Location = new System.Drawing.Point(677, 51);
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.Size = new System.Drawing.Size(183, 38);
            this.txtRemotePort.TabIndex = 3;
            this.txtRemotePort.Text = "5000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Порт симулятора:";
            // 
            // txtRemoteIP
            // 
            this.txtRemoteIP.BackColor = System.Drawing.Color.White;
            this.txtRemoteIP.Location = new System.Drawing.Point(230, 51);
            this.txtRemoteIP.Name = "txtRemoteIP";
            this.txtRemoteIP.Size = new System.Drawing.Size(183, 38);
            this.txtRemoteIP.TabIndex = 1;
            this.txtRemoteIP.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP симулятора:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Bisque;
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.txtL4);
            this.groupBox1.Controls.Add(this.txtSimTheta);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.txtL2);
            this.groupBox1.Controls.Add(this.txtSimY);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.txtL0);
            this.groupBox1.Controls.Add(this.txtSimX);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.txtL1);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtL3);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtDistance);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txtAzimuth);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtD7);
            this.groupBox1.Controls.Add(this.txtD6);
            this.groupBox1.Controls.Add(this.txtD5);
            this.groupBox1.Controls.Add(this.txtD4);
            this.groupBox1.Controls.Add(this.txtD3);
            this.groupBox1.Controls.Add(this.txtD2);
            this.groupBox1.Controls.Add(this.txtD1);
            this.groupBox1.Controls.Add(this.txtD0);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtBumper);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtRightEncoder);
            this.groupBox1.Controls.Add(this.txtLeftEncoder);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCommandNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(14, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1096, 422);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Приёмные данные";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(367, 378);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(83, 31);
            this.label30.TabIndex = 17;
            this.label30.Text = "Курс:";
            // 
            // txtL4
            // 
            this.txtL4.Location = new System.Drawing.Point(587, 315);
            this.txtL4.Name = "txtL4";
            this.txtL4.ReadOnly = true;
            this.txtL4.Size = new System.Drawing.Size(72, 38);
            this.txtL4.TabIndex = 45;
            // 
            // txtSimTheta
            // 
            this.txtSimTheta.Location = new System.Drawing.Point(456, 378);
            this.txtSimTheta.Name = "txtSimTheta";
            this.txtSimTheta.ReadOnly = true;
            this.txtSimTheta.Size = new System.Drawing.Size(100, 38);
            this.txtSimTheta.TabIndex = 16;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(529, 315);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(52, 31);
            this.label28.TabIndex = 44;
            this.label28.Text = "L4:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(189, 378);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(40, 31);
            this.label31.TabIndex = 15;
            this.label31.Text = "Y:";
            // 
            // txtL2
            // 
            this.txtL2.Location = new System.Drawing.Point(443, 315);
            this.txtL2.Name = "txtL2";
            this.txtL2.ReadOnly = true;
            this.txtL2.Size = new System.Drawing.Size(76, 38);
            this.txtL2.TabIndex = 43;
            // 
            // txtSimY
            // 
            this.txtSimY.Location = new System.Drawing.Point(235, 378);
            this.txtSimY.Name = "txtSimY";
            this.txtSimY.ReadOnly = true;
            this.txtSimY.Size = new System.Drawing.Size(100, 38);
            this.txtSimY.TabIndex = 14;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(385, 318);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(52, 31);
            this.label27.TabIndex = 42;
            this.label27.Text = "L2:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(17, 378);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(40, 31);
            this.label32.TabIndex = 13;
            this.label32.Text = "X:";
            // 
            // txtL0
            // 
            this.txtL0.Location = new System.Drawing.Point(540, 264);
            this.txtL0.Name = "txtL0";
            this.txtL0.ReadOnly = true;
            this.txtL0.Size = new System.Drawing.Size(91, 38);
            this.txtL0.TabIndex = 41;
            // 
            // txtSimX
            // 
            this.txtSimX.Location = new System.Drawing.Point(63, 378);
            this.txtSimX.Name = "txtSimX";
            this.txtSimX.ReadOnly = true;
            this.txtSimX.Size = new System.Drawing.Size(100, 38);
            this.txtSimX.TabIndex = 12;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(482, 267);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 31);
            this.label26.TabIndex = 40;
            this.label26.Text = "L0:";
            // 
            // txtL1
            // 
            this.txtL1.Location = new System.Drawing.Point(581, 209);
            this.txtL1.Name = "txtL1";
            this.txtL1.ReadOnly = true;
            this.txtL1.Size = new System.Drawing.Size(90, 38);
            this.txtL1.TabIndex = 39;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(534, 212);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 31);
            this.label25.TabIndex = 38;
            this.label25.Text = "L1:";
            // 
            // txtL3
            // 
            this.txtL3.Location = new System.Drawing.Point(450, 209);
            this.txtL3.Name = "txtL3";
            this.txtL3.ReadOnly = true;
            this.txtL3.Size = new System.Drawing.Size(69, 38);
            this.txtL3.TabIndex = 37;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(389, 209);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(52, 31);
            this.label24.TabIndex = 36;
            this.label24.Text = "L3:";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(250, 268);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.ReadOnly = true;
            this.txtDistance.Size = new System.Drawing.Size(132, 38);
            this.txtDistance.TabIndex = 35;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 271);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(225, 31);
            this.label21.TabIndex = 34;
            this.label21.Text = "Расстояние (ad):";
            // 
            // txtAzimuth
            // 
            this.txtAzimuth.Location = new System.Drawing.Point(193, 211);
            this.txtAzimuth.Name = "txtAzimuth";
            this.txtAzimuth.ReadOnly = true;
            this.txtAzimuth.Size = new System.Drawing.Size(132, 38);
            this.txtAzimuth.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 214);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(168, 31);
            this.label20.TabIndex = 32;
            this.label20.Text = "Азимут (az):";
            // 
            // txtD7
            // 
            this.txtD7.Location = new System.Drawing.Point(952, 324);
            this.txtD7.Name = "txtD7";
            this.txtD7.ReadOnly = true;
            this.txtD7.Size = new System.Drawing.Size(132, 38);
            this.txtD7.TabIndex = 31;
            // 
            // txtD6
            // 
            this.txtD6.Location = new System.Drawing.Point(952, 268);
            this.txtD6.Name = "txtD6";
            this.txtD6.ReadOnly = true;
            this.txtD6.Size = new System.Drawing.Size(132, 38);
            this.txtD6.TabIndex = 30;
            // 
            // txtD5
            // 
            this.txtD5.Location = new System.Drawing.Point(952, 211);
            this.txtD5.Name = "txtD5";
            this.txtD5.ReadOnly = true;
            this.txtD5.Size = new System.Drawing.Size(132, 38);
            this.txtD5.TabIndex = 29;
            // 
            // txtD4
            // 
            this.txtD4.Location = new System.Drawing.Point(952, 163);
            this.txtD4.Name = "txtD4";
            this.txtD4.ReadOnly = true;
            this.txtD4.Size = new System.Drawing.Size(132, 38);
            this.txtD4.TabIndex = 28;
            // 
            // txtD3
            // 
            this.txtD3.Location = new System.Drawing.Point(749, 322);
            this.txtD3.Name = "txtD3";
            this.txtD3.ReadOnly = true;
            this.txtD3.Size = new System.Drawing.Size(132, 38);
            this.txtD3.TabIndex = 27;
            // 
            // txtD2
            // 
            this.txtD2.Location = new System.Drawing.Point(749, 265);
            this.txtD2.Name = "txtD2";
            this.txtD2.ReadOnly = true;
            this.txtD2.Size = new System.Drawing.Size(132, 38);
            this.txtD2.TabIndex = 26;
            // 
            // txtD1
            // 
            this.txtD1.Location = new System.Drawing.Point(749, 211);
            this.txtD1.Name = "txtD1";
            this.txtD1.ReadOnly = true;
            this.txtD1.Size = new System.Drawing.Size(132, 38);
            this.txtD1.TabIndex = 25;
            // 
            // txtD0
            // 
            this.txtD0.Location = new System.Drawing.Point(749, 162);
            this.txtD0.Name = "txtD0";
            this.txtD0.ReadOnly = true;
            this.txtD0.Size = new System.Drawing.Size(132, 38);
            this.txtD0.TabIndex = 24;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(889, 327);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 31);
            this.label19.TabIndex = 23;
            this.label19.Text = "D7:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(889, 268);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 31);
            this.label18.TabIndex = 22;
            this.label18.Text = "D6:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(889, 214);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 31);
            this.label17.TabIndex = 21;
            this.label17.Text = "D5:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(891, 166);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 31);
            this.label16.TabIndex = 20;
            this.label16.Text = "D4:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(688, 325);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 31);
            this.label15.TabIndex = 19;
            this.label15.Text = "D3:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(688, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 31);
            this.label14.TabIndex = 18;
            this.label14.Text = "D2:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(688, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 31);
            this.label13.TabIndex = 17;
            this.label13.Text = "D1:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(688, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 31);
            this.label12.TabIndex = 16;
            this.label12.Text = "D0:";
            // 
            // txtBumper
            // 
            this.txtBumper.Location = new System.Drawing.Point(546, 154);
            this.txtBumper.Name = "txtBumper";
            this.txtBumper.ReadOnly = true;
            this.txtBumper.Size = new System.Drawing.Size(132, 38);
            this.txtBumper.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(381, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 31);
            this.label11.TabIndex = 14;
            this.label11.Text = "Бампер (b):";
            // 
            // txtRightEncoder
            // 
            this.txtRightEncoder.Location = new System.Drawing.Point(657, 102);
            this.txtRightEncoder.Name = "txtRightEncoder";
            this.txtRightEncoder.ReadOnly = true;
            this.txtRightEncoder.Size = new System.Drawing.Size(132, 38);
            this.txtRightEncoder.TabIndex = 13;
            // 
            // txtLeftEncoder
            // 
            this.txtLeftEncoder.Location = new System.Drawing.Point(648, 48);
            this.txtLeftEncoder.Name = "txtLeftEncoder";
            this.txtLeftEncoder.ReadOnly = true;
            this.txtLeftEncoder.Size = new System.Drawing.Size(141, 38);
            this.txtLeftEncoder.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(280, 31);
            this.label10.TabIndex = 11;
            this.label10.Text = "Правый энкодер (re):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(381, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 31);
            this.label9.TabIndex = 10;
            this.label9.Text = "Левый энкодер (le):";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(131, 154);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(132, 38);
            this.txtCode.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Код (c):";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(169, 102);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(132, 38);
            this.txtStatus.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Статус (s):";
            // 
            // txtCommandNum
            // 
            this.txtCommandNum.Location = new System.Drawing.Point(244, 51);
            this.txtCommandNum.Name = "txtCommandNum";
            this.txtCommandNum.ReadOnly = true;
            this.txtCommandNum.Size = new System.Drawing.Size(132, 38);
            this.txtCommandNum.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "№ команды (n):";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Khaki;
            this.groupBox2.Controls.Add(this.txtRawData);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 1053);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(902, 389);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сырые данные";
            // 
            // txtRawData
            // 
            this.txtRawData.Location = new System.Drawing.Point(19, 49);
            this.txtRawData.Multiline = true;
            this.txtRawData.Name = "txtRawData";
            this.txtRawData.ReadOnly = true;
            this.txtRawData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRawData.Size = new System.Drawing.Size(859, 316);
            this.txtRawData.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Orange;
            this.groupBox3.Controls.Add(this.lblAutoStatus);
            this.groupBox3.Controls.Add(this.btnRight);
            this.groupBox3.Controls.Add(this.btnLeft);
            this.groupBox3.Controls.Add(this.btnBackward);
            this.groupBox3.Controls.Add(this.btnForward);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.btnStartAuto);
            this.groupBox3.Controls.Add(this.btnSendManual);
            this.groupBox3.Controls.Add(this.tbBalance);
            this.groupBox3.Controls.Add(this.txtBalance);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.tbForce);
            this.groupBox3.Controls.Add(this.txtForce);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(12, 670);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(922, 377);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ручное управление";
            // 
            // lblAutoStatus
            // 
            this.lblAutoStatus.AutoSize = true;
            this.lblAutoStatus.Location = new System.Drawing.Point(25, 315);
            this.lblAutoStatus.Name = "lblAutoStatus";
            this.lblAutoStatus.Size = new System.Drawing.Size(282, 31);
            this.lblAutoStatus.TabIndex = 12;
            this.lblAutoStatus.Text = "Данные авто режима";
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(780, 92);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(125, 49);
            this.btnRight.TabIndex = 11;
            this.btnRight.Text = "Право";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(519, 92);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(125, 49);
            this.btnLeft.TabIndex = 10;
            this.btnLeft.Text = "Лево";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(635, 171);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(159, 49);
            this.btnBackward.TabIndex = 9;
            this.btnBackward.Text = "Назад";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(635, 37);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(159, 49);
            this.btnForward.TabIndex = 8;
            this.btnForward.Text = "Вперед";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(277, 196);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(138, 62);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStartAuto
            // 
            this.btnStartAuto.Location = new System.Drawing.Point(489, 259);
            this.btnStartAuto.Name = "btnStartAuto";
            this.btnStartAuto.Size = new System.Drawing.Size(261, 47);
            this.btnStartAuto.TabIndex = 2;
            this.btnStartAuto.Text = "Старт авто";
            this.btnStartAuto.UseVisualStyleBackColor = true;
            this.btnStartAuto.Click += new System.EventHandler(this.btnStartAuto_Click);
            // 
            // btnSendManual
            // 
            this.btnSendManual.Location = new System.Drawing.Point(18, 186);
            this.btnSendManual.Name = "btnSendManual";
            this.btnSendManual.Size = new System.Drawing.Size(238, 84);
            this.btnSendManual.TabIndex = 6;
            this.btnSendManual.Text = "Отправить команду";
            this.btnSendManual.UseVisualStyleBackColor = true;
            this.btnSendManual.Click += new System.EventHandler(this.btnSendManual_Click);
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(277, 130);
            this.tbBalance.Maximum = 100;
            this.tbBalance.Minimum = -100;
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(198, 90);
            this.tbBalance.TabIndex = 5;
            this.tbBalance.Scroll += new System.EventHandler(this.tbBalance_Scroll);
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(181, 130);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(82, 38);
            this.txtBalance.TabIndex = 4;
            this.txtBalance.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 133);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(157, 31);
            this.label23.TabIndex = 3;
            this.label23.Text = "Баланс (B):";
            // 
            // tbForce
            // 
            this.tbForce.Location = new System.Drawing.Point(277, 62);
            this.tbForce.Maximum = 100;
            this.tbForce.Minimum = -100;
            this.tbForce.Name = "tbForce";
            this.tbForce.Size = new System.Drawing.Size(198, 90);
            this.tbForce.TabIndex = 2;
            this.tbForce.Scroll += new System.EventHandler(this.tbForce_Scroll);
            // 
            // txtForce
            // 
            this.txtForce.Location = new System.Drawing.Point(146, 62);
            this.txtForce.Name = "txtForce";
            this.txtForce.Size = new System.Drawing.Size(82, 38);
            this.txtForce.TabIndex = 1;
            this.txtForce.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(121, 31);
            this.label22.TabIndex = 0;
            this.label22.Text = "Тяга (F):";
            // 
            // tmrAutoControl
            // 
            this.tmrAutoControl.Interval = 200;
            this.tmrAutoControl.Tick += new System.EventHandler(this.tmrAutoControl_Tick);
            // 
            // pbMap
            // 
            this.pbMap.BackColor = System.Drawing.Color.White;
            this.pbMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMap.Location = new System.Drawing.Point(18, 217);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(1150, 750);
            this.pbMap.TabIndex = 4;
            this.pbMap.TabStop = false;
            this.pbMap.Click += new System.EventHandler(this.pbMap_Click);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(71, 173);
            this.txtX.Name = "txtX";
            this.txtX.ReadOnly = true;
            this.txtX.Size = new System.Drawing.Size(100, 38);
            this.txtX.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Pink;
            this.groupBox4.Controls.Add(this.btnResetMap);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.txtTheta);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtY);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.pbMap);
            this.groupBox4.Controls.Add(this.txtX);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(1116, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1203, 1003);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Визуализация";
            // 
            // btnResetMap
            // 
            this.btnResetMap.Location = new System.Drawing.Point(6, 33);
            this.btnResetMap.Name = "btnResetMap";
            this.btnResetMap.Size = new System.Drawing.Size(533, 66);
            this.btnResetMap.TabIndex = 11;
            this.btnResetMap.Text = "Сброс карты и координат";
            this.btnResetMap.UseVisualStyleBackColor = true;
            this.btnResetMap.Click += new System.EventHandler(this.btnResetMap_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(375, 173);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(83, 31);
            this.label29.TabIndex = 10;
            this.label29.Text = "Курс:";
            // 
            // txtTheta
            // 
            this.txtTheta.Location = new System.Drawing.Point(464, 173);
            this.txtTheta.Name = "txtTheta";
            this.txtTheta.ReadOnly = true;
            this.txtTheta.Size = new System.Drawing.Size(100, 38);
            this.txtTheta.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "Y:";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(243, 173);
            this.txtY.Name = "txtY";
            this.txtY.ReadOnly = true;
            this.txtY.Size = new System.Drawing.Size(100, 38);
            this.txtY.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "X:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2331, 1300);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbConnection);
            this.Name = "Form1";
            this.Text = "Murashkin Ivan 241-324 Lab 3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbForce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.TextBox txtRemoteIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtLocalPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRemotePort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCommandNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBumper;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRightEncoder;
        private System.Windows.Forms.TextBox txtLeftEncoder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtAzimuth;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtD7;
        private System.Windows.Forms.TextBox txtD6;
        private System.Windows.Forms.TextBox txtD5;
        private System.Windows.Forms.TextBox txtD4;
        private System.Windows.Forms.TextBox txtD3;
        private System.Windows.Forms.TextBox txtD2;
        private System.Windows.Forms.TextBox txtD1;
        private System.Windows.Forms.TextBox txtD0;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar tbForce;
        private System.Windows.Forms.TextBox txtForce;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnSendManual;
        private System.Windows.Forms.TrackBar tbBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Timer tmrAutoControl;
        private System.Windows.Forms.TextBox txtRawData;
        private System.Windows.Forms.Button btnStartAuto;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Label lblAutoStatus;
        private System.Windows.Forms.TextBox txtL3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtL4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtL2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtL0;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtL1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnResetMap;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtTheta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtSimTheta;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtSimY;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtSimX;
    }
}

