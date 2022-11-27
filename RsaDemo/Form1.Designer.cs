
namespace RsaDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKeys = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEncr = new System.Windows.Forms.TextBox();
            this.txtDecr = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtP0 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtG = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtKey1 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtGS1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtK1 = new System.Windows.Forms.TextBox();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtEnMsg1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtMsg1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtKey2 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtGS2 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtK2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtMsg2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKeys
            // 
            this.btnKeys.Location = new System.Drawing.Point(60, 231);
            this.btnKeys.Name = "btnKeys";
            this.btnKeys.Size = new System.Drawing.Size(75, 23);
            this.btnKeys.TabIndex = 0;
            this.btnKeys.Text = "Рассчитать";
            this.btnKeys.UseVisualStyleBackColor = true;
            this.btnKeys.Click += new System.EventHandler(this.btnKeys_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(24, 370);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(24, 437);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(60, 32);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(42, 20);
            this.txtP.TabIndex = 3;
            this.txtP.TextChanged += new System.EventHandler(this.txtP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Q";
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(146, 32);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(42, 20);
            this.txtQ.TabIndex = 5;
            this.txtQ.TextChanged += new System.EventHandler(this.txtQ_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "E";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(78, 191);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(42, 20);
            this.txtE.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "D";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(180, 233);
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(42, 20);
            this.txtD.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Исходное сообщение";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(146, 340);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(42, 20);
            this.txtMessage.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Зашифрованное сообщение";
            // 
            // txtEncr
            // 
            this.txtEncr.Location = new System.Drawing.Point(178, 400);
            this.txtEncr.Name = "txtEncr";
            this.txtEncr.ReadOnly = true;
            this.txtEncr.Size = new System.Drawing.Size(42, 20);
            this.txtEncr.TabIndex = 13;
            // 
            // txtDecr
            // 
            this.txtDecr.Location = new System.Drawing.Point(184, 469);
            this.txtDecr.Name = "txtDecr";
            this.txtDecr.ReadOnly = true;
            this.txtDecr.Size = new System.Drawing.Size(42, 20);
            this.txtDecr.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Восстановленное сообщение";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(316, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "M = P * Q (передается адресату вместе с открытым ключом)";
            // 
            // txtM
            // 
            this.txtM.Location = new System.Drawing.Point(43, 80);
            this.txtM.Name = "txtM";
            this.txtM.ReadOnly = true;
            this.txtM.Size = new System.Drawing.Size(76, 20);
            this.txtM.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 531);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtF);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnKeys);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnEncrypt);
            this.tabPage1.Controls.Add(this.txtM);
            this.tabPage1.Controls.Add(this.btnDecrypt);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtP);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtDecr);
            this.tabPage1.Controls.Add(this.txtQ);
            this.tabPage1.Controls.Add(this.txtEncr);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtE);
            this.tabPage1.Controls.Add(this.txtMessage);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtD);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 505);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RSA";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label14.Location = new System.Drawing.Point(21, 289);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(527, 48);
            this.label14.TabIndex = 23;
            label14.Text = "Сценарий передачи сообщения: Получатель сообщения подготавливает параметры и ключи,  пересылает отправителю произведение M и открытый ключ, получает от отправителя зашифрованное открытым ключом сообщение, раскодирует его закрытым ключом.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(316, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "F, функция Эйлера от M: (F=(P-1)*(Q-1)) , если P и Q - простые";
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(43, 123);
            this.txtF.Name = "txtF";
            this.txtF.ReadOnly = true;
            this.txtF.Size = new System.Drawing.Size(76, 20);
            this.txtF.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(310, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Другой - расчитывается  - обратное к первому по модулю F";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Один - подбираем (взаимопростое с F)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ключи:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Параметры алгоритма, простые числа:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.lblCheck);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txtP0);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txtG);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 505);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Обмен ключами Диффи-Хелмана";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label19.Location = new System.Drawing.Point(37, 132);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(644, 96);
            this.label19.TabIndex = 25;            
            label19.Text = "Сценарий передачи сообщения: Инициатор сеанса подготавливает параметры (P и G),"
                + " и заппрашивает готовность к сеансу у второго участника."
                + " В этом запросе пересылает ему параметры сеанса и G кодированное своим секретным числом K."
                + " Где K - случайное число в диапазоне  1...P."
                + " В ответ получает от 2-го участника G закодированное его секретным числом."
                + " В итоге, после этого обмена у обоих участников формируется известный только им одинаковый рабочий ключ для последующего обмена шифрованными сообщениями симметричным шифрованием,"
                + " например XOR."
                + " Рабочий ключ получается последовательным возведением G в степени K обоих участников (в разном порядке).";
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCheck.Location = new System.Drawing.Point(88, 108);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(0, 13);
            this.lblCheck.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(207, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Параметры алгоритма, простые числа:";
            // 
            // txtP0
            // 
            this.txtP0.Location = new System.Drawing.Point(40, 52);
            this.txtP0.Name = "txtP0";
            this.txtP0.Size = new System.Drawing.Size(42, 20);
            this.txtP0.TabIndex = 18;
            this.txtP0.TextChanged += new System.EventHandler(this.txtP0_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(37, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(400, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "P, общее простое число, большое, исп. в качестве модуля для всех расчетов";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(40, 94);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(42, 20);
            this.txtG.TabIndex = 20;
            this.txtG.TextChanged += new System.EventHandler(this.txtG_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(37, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(704, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "G, общее стартовое число - подбираемый первообразный корень для P (проверка произ" +
    "водится программой автоматически при вводе)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.txtKey1);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.txtGS1);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtK1);
            this.groupBox2.Controls.Add(this.btnRequest);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtEnMsg1);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtMsg1);
            this.groupBox2.Location = new System.Drawing.Point(22, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alice";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 109);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(148, 13);
            this.label25.TabIndex = 29;
            this.label25.Text = "Ключ обмена сообщениями";
            // 
            // txtKey1
            // 
            this.txtKey1.Location = new System.Drawing.Point(198, 106);
            this.txtKey1.Name = "txtKey1";
            this.txtKey1.ReadOnly = true;
            this.txtKey1.Size = new System.Drawing.Size(42, 20);
            this.txtKey1.TabIndex = 28;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 83);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(154, 13);
            this.label24.TabIndex = 27;
            this.label24.Text = "Свой вариант шифрования G";
            // 
            // txtGS1
            // 
            this.txtGS1.Location = new System.Drawing.Point(198, 80);
            this.txtGS1.Name = "txtGS1";
            this.txtGS1.ReadOnly = true;
            this.txtGS1.Size = new System.Drawing.Size(42, 20);
            this.txtGS1.TabIndex = 26;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 13);
            this.label18.TabIndex = 25;
            this.label18.Text = "Свое секретное число";
            // 
            // txtK1
            // 
            this.txtK1.Location = new System.Drawing.Point(198, 54);
            this.txtK1.Name = "txtK1";
            this.txtK1.ReadOnly = true;
            this.txtK1.Size = new System.Drawing.Size(42, 20);
            this.txtK1.TabIndex = 24;
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(7, 19);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 23;
            this.btnRequest.Text = "Request";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(6, 213);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 184);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(150, 13);
            this.label20.TabIndex = 22;
            this.label20.Text = "Зашифрованное сообщение";
            // 
            // txtEnMsg1
            // 
            this.txtEnMsg1.Location = new System.Drawing.Point(159, 181);
            this.txtEnMsg1.Name = "txtEnMsg1";
            this.txtEnMsg1.ReadOnly = true;
            this.txtEnMsg1.Size = new System.Drawing.Size(42, 20);
            this.txtEnMsg1.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 158);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(116, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "Исходное сообщение";
            // 
            // txtMsg1
            // 
            this.txtMsg1.Location = new System.Drawing.Point(159, 155);
            this.txtMsg1.Name = "txtMsg1";
            this.txtMsg1.Size = new System.Drawing.Size(42, 20);
            this.txtMsg1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.txtKey2);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.txtGS2);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.txtK2);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtMsg2);
            this.groupBox1.Location = new System.Drawing.Point(388, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bob";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 109);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(148, 13);
            this.label26.TabIndex = 35;
            this.label26.Text = "Ключ обмена сообщениями";
            // 
            // txtKey2
            // 
            this.txtKey2.Location = new System.Drawing.Point(198, 106);
            this.txtKey2.Name = "txtKey2";
            this.txtKey2.ReadOnly = true;
            this.txtKey2.Size = new System.Drawing.Size(42, 20);
            this.txtKey2.TabIndex = 34;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 83);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(154, 13);
            this.label27.TabIndex = 33;
            this.label27.Text = "Свой вариант шифрования G";
            // 
            // txtGS2
            // 
            this.txtGS2.Location = new System.Drawing.Point(198, 80);
            this.txtGS2.Name = "txtGS2";
            this.txtGS2.ReadOnly = true;
            this.txtGS2.Size = new System.Drawing.Size(42, 20);
            this.txtGS2.TabIndex = 32;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 57);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 13);
            this.label28.TabIndex = 31;
            this.label28.Text = "Свое секретное число";
            // 
            // txtK2
            // 
            this.txtK2.Location = new System.Drawing.Point(198, 54);
            this.txtK2.Name = "txtK2";
            this.txtK2.ReadOnly = true;
            this.txtK2.Size = new System.Drawing.Size(42, 20);
            this.txtK2.TabIndex = 30;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 184);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(157, 13);
            this.label22.TabIndex = 26;
            this.label22.Text = "Восстановленное сообщение";
            // 
            // txtMsg2
            // 
            this.txtMsg2.Location = new System.Drawing.Point(169, 181);
            this.txtMsg2.Name = "txtMsg2";
            this.txtMsg2.ReadOnly = true;
            this.txtMsg2.Size = new System.Drawing.Size(42, 20);
            this.txtMsg2.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKeys;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEncr;
        private System.Windows.Forms.TextBox txtDecr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtP0;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblCheck;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtEnMsg1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtMsg1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtMsg2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtKey1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtGS1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtK1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtKey2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtGS2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtK2;
    }
}

