
namespace MoonMiner
    {
    partial class Form2
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
        private void InitializeComponent( )
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.SpaceMarket = new System.Windows.Forms.PictureBox();
            this._BuyShipButton = new System.Windows.Forms.Button();
            this.SellAll = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SpaceFleetValue = new System.Windows.Forms.TextBox();
            this.MadtweedValue = new System.Windows.Forms.TextBox();
            this.EtheriumValue = new System.Windows.Forms.TextBox();
            this.EmeraldValue = new System.Windows.Forms.TextBox();
            this.PlatinumValue = new System.Windows.Forms.TextBox();
            this.GoldValue = new System.Windows.Forms.TextBox();
            this.SpaceFleetLabel = new System.Windows.Forms.Label();
            this.MadtweedLabel = new System.Windows.Forms.Label();
            this.EtheriumLabel = new System.Windows.Forms.Label();
            this.EmeraldLabel = new System.Windows.Forms.Label();
            this.platinumLabel = new System.Windows.Forms.Label();
            this.GoldLabel = new System.Windows.Forms.Label();
            this.IntroNaut = new System.Windows.Forms.PictureBox();
            this.MoonMinerTitle = new System.Windows.Forms.PictureBox();
            this.LabelMadtweed = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Button();
            this.Sell1GoldOre = new System.Windows.Forms.Button();
            this.Sell1PlatinumOre = new System.Windows.Forms.Button();
            this.SellAllPlatinumOre = new System.Windows.Forms.Button();
            this.Sell1EmeraldGem = new System.Windows.Forms.Button();
            this.SellAllEmeraldGems = new System.Windows.Forms.Button();
            this.Sell1Etherium = new System.Windows.Forms.Button();
            this.SellAllEtherium = new System.Windows.Forms.Button();
            this.Sell1Madtweed = new System.Windows.Forms.Button();
            this.SellAllMadtweed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceMarket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntroNaut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoonMinerTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SpaceMarket
            // 
            this.SpaceMarket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SpaceMarket.Image = ((System.Drawing.Image)(resources.GetObject("SpaceMarket.Image")));
            this.SpaceMarket.Location = new System.Drawing.Point(344, 128);
            this.SpaceMarket.Name = "SpaceMarket";
            this.SpaceMarket.Size = new System.Drawing.Size(368, 112);
            this.SpaceMarket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpaceMarket.TabIndex = 69;
            this.SpaceMarket.TabStop = false;
            // 
            // _BuyShipButton
            // 
            this._BuyShipButton.BackColor = System.Drawing.Color.DarkOrchid;
            this._BuyShipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BuyShipButton.Location = new System.Drawing.Point(400, 296);
            this._BuyShipButton.Name = "_BuyShipButton";
            this._BuyShipButton.Size = new System.Drawing.Size(168, 24);
            this._BuyShipButton.TabIndex = 90;
            this._BuyShipButton.Text = "BUY 1 SPACESHIP";
            this._BuyShipButton.UseVisualStyleBackColor = false;
            this._BuyShipButton.Click += new System.EventHandler(this._BuyShipButton_Click);
            // 
            // SellAll
            // 
            this.SellAll.BackColor = System.Drawing.Color.Beige;
            this.SellAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellAll.Location = new System.Drawing.Point(400, 256);
            this.SellAll.Name = "SellAll";
            this.SellAll.Size = new System.Drawing.Size(256, 24);
            this.SellAll.TabIndex = 91;
            this.SellAll.Text = "Convert All Resources to Earth Pennies";
            this.SellAll.UseVisualStyleBackColor = false;
            this.SellAll.Click += new System.EventHandler(this.SellAll_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(240, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 16);
            this.textBox1.TabIndex = 107;
            this.textBox1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.GhostWhite;
            this.label1.Location = new System.Drawing.Point(160, 64);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Earth Pennies";
            // 
            // SpaceFleetValue
            // 
            this.SpaceFleetValue.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.SpaceFleetValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SpaceFleetValue.ForeColor = System.Drawing.Color.DarkOrchid;
            this.SpaceFleetValue.Location = new System.Drawing.Point(240, 80);
            this.SpaceFleetValue.Name = "SpaceFleetValue";
            this.SpaceFleetValue.Size = new System.Drawing.Size(31, 13);
            this.SpaceFleetValue.TabIndex = 105;
            this.SpaceFleetValue.Text = "0";
            // 
            // MadtweedValue
            // 
            this.MadtweedValue.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MadtweedValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MadtweedValue.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MadtweedValue.Location = new System.Drawing.Point(240, 160);
            this.MadtweedValue.Multiline = true;
            this.MadtweedValue.Name = "MadtweedValue";
            this.MadtweedValue.Size = new System.Drawing.Size(43, 20);
            this.MadtweedValue.TabIndex = 104;
            this.MadtweedValue.Text = "0";
            // 
            // EtheriumValue
            // 
            this.EtheriumValue.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.EtheriumValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EtheriumValue.ForeColor = System.Drawing.Color.Red;
            this.EtheriumValue.Location = new System.Drawing.Point(240, 146);
            this.EtheriumValue.Multiline = true;
            this.EtheriumValue.Name = "EtheriumValue";
            this.EtheriumValue.Size = new System.Drawing.Size(43, 20);
            this.EtheriumValue.TabIndex = 103;
            this.EtheriumValue.Text = "0";
            // 
            // EmeraldValue
            // 
            this.EmeraldValue.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.EmeraldValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmeraldValue.ForeColor = System.Drawing.Color.Lime;
            this.EmeraldValue.Location = new System.Drawing.Point(240, 129);
            this.EmeraldValue.Multiline = true;
            this.EmeraldValue.Name = "EmeraldValue";
            this.EmeraldValue.Size = new System.Drawing.Size(43, 20);
            this.EmeraldValue.TabIndex = 102;
            this.EmeraldValue.Text = "0";
            // 
            // PlatinumValue
            // 
            this.PlatinumValue.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PlatinumValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlatinumValue.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PlatinumValue.Location = new System.Drawing.Point(240, 112);
            this.PlatinumValue.Multiline = true;
            this.PlatinumValue.Name = "PlatinumValue";
            this.PlatinumValue.Size = new System.Drawing.Size(43, 20);
            this.PlatinumValue.TabIndex = 101;
            this.PlatinumValue.Text = "0";
            // 
            // GoldValue
            // 
            this.GoldValue.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.GoldValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GoldValue.ForeColor = System.Drawing.Color.Gold;
            this.GoldValue.Location = new System.Drawing.Point(240, 96);
            this.GoldValue.Multiline = true;
            this.GoldValue.Name = "GoldValue";
            this.GoldValue.Size = new System.Drawing.Size(52, 20);
            this.GoldValue.TabIndex = 100;
            this.GoldValue.Text = "0";
            // 
            // SpaceFleetLabel
            // 
            this.SpaceFleetLabel.AutoSize = true;
            this.SpaceFleetLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SpaceFleetLabel.ForeColor = System.Drawing.Color.DarkViolet;
            this.SpaceFleetLabel.Location = new System.Drawing.Point(160, 80);
            this.SpaceFleetLabel.Name = "SpaceFleetLabel";
            this.SpaceFleetLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SpaceFleetLabel.Size = new System.Drawing.Size(64, 13);
            this.SpaceFleetLabel.TabIndex = 99;
            this.SpaceFleetLabel.Text = "Space Fleet";
            // 
            // MadtweedLabel
            // 
            this.MadtweedLabel.AutoSize = true;
            this.MadtweedLabel.BackColor = System.Drawing.Color.Black;
            this.MadtweedLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.MadtweedLabel.Location = new System.Drawing.Point(162, 161);
            this.MadtweedLabel.Name = "MadtweedLabel";
            this.MadtweedLabel.Size = new System.Drawing.Size(60, 13);
            this.MadtweedLabel.TabIndex = 98;
            this.MadtweedLabel.Text = "Madtweed ";
            // 
            // EtheriumLabel
            // 
            this.EtheriumLabel.AutoSize = true;
            this.EtheriumLabel.BackColor = System.Drawing.Color.Black;
            this.EtheriumLabel.ForeColor = System.Drawing.Color.Red;
            this.EtheriumLabel.Location = new System.Drawing.Point(161, 144);
            this.EtheriumLabel.Name = "EtheriumLabel";
            this.EtheriumLabel.Size = new System.Drawing.Size(48, 13);
            this.EtheriumLabel.TabIndex = 97;
            this.EtheriumLabel.Text = "Etherium";
            // 
            // EmeraldLabel
            // 
            this.EmeraldLabel.AutoSize = true;
            this.EmeraldLabel.BackColor = System.Drawing.Color.Black;
            this.EmeraldLabel.ForeColor = System.Drawing.Color.Lime;
            this.EmeraldLabel.Location = new System.Drawing.Point(160, 128);
            this.EmeraldLabel.Name = "EmeraldLabel";
            this.EmeraldLabel.Size = new System.Drawing.Size(75, 13);
            this.EmeraldLabel.TabIndex = 96;
            this.EmeraldLabel.Text = "Emerald Gems";
            // 
            // platinumLabel
            // 
            this.platinumLabel.AutoSize = true;
            this.platinumLabel.BackColor = System.Drawing.Color.Black;
            this.platinumLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.platinumLabel.Location = new System.Drawing.Point(160, 111);
            this.platinumLabel.Name = "platinumLabel";
            this.platinumLabel.Size = new System.Drawing.Size(67, 13);
            this.platinumLabel.TabIndex = 95;
            this.platinumLabel.Text = "Platinum Ore";
            // 
            // GoldLabel
            // 
            this.GoldLabel.AutoSize = true;
            this.GoldLabel.BackColor = System.Drawing.Color.Black;
            this.GoldLabel.ForeColor = System.Drawing.Color.Gold;
            this.GoldLabel.Location = new System.Drawing.Point(160, 96);
            this.GoldLabel.Name = "GoldLabel";
            this.GoldLabel.Size = new System.Drawing.Size(52, 13);
            this.GoldLabel.TabIndex = 94;
            this.GoldLabel.Text = " Gold Ore";
            // 
            // IntroNaut
            // 
            this.IntroNaut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IntroNaut.Image = ((System.Drawing.Image)(resources.GetObject("IntroNaut.Image")));
            this.IntroNaut.Location = new System.Drawing.Point(160, 0);
            this.IntroNaut.Name = "IntroNaut";
            this.IntroNaut.Size = new System.Drawing.Size(87, 62);
            this.IntroNaut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IntroNaut.TabIndex = 93;
            this.IntroNaut.TabStop = false;
            // 
            // MoonMinerTitle
            // 
            this.MoonMinerTitle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MoonMinerTitle.Image = ((System.Drawing.Image)(resources.GetObject("MoonMinerTitle.Image")));
            this.MoonMinerTitle.Location = new System.Drawing.Point(0, 0);
            this.MoonMinerTitle.Name = "MoonMinerTitle";
            this.MoonMinerTitle.Size = new System.Drawing.Size(162, 144);
            this.MoonMinerTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoonMinerTitle.TabIndex = 108;
            this.MoonMinerTitle.TabStop = false;
            // 
            // LabelMadtweed
            // 
            this.LabelMadtweed.AutoSize = true;
            this.LabelMadtweed.BackColor = System.Drawing.Color.Black;
            this.LabelMadtweed.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LabelMadtweed.Location = new System.Drawing.Point(458, 105);
            this.LabelMadtweed.Name = "LabelMadtweed";
            this.LabelMadtweed.Size = new System.Drawing.Size(60, 13);
            this.LabelMadtweed.TabIndex = 113;
            this.LabelMadtweed.Text = "Madtweed ";
            this.LabelMadtweed.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(457, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 112;
            this.label3.Text = "Etherium";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(456, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 111;
            this.label4.Text = "Emerald Gem";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(457, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 110;
            this.label5.Text = "Platinum Ore";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(455, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = " Gold Ore";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ForeColor = System.Drawing.Color.GhostWhite;
            this.label7.Location = new System.Drawing.Point(569, 39);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 114;
            this.label7.Text = "Earth Pennies";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.ForeColor = System.Drawing.Color.GhostWhite;
            this.label8.Location = new System.Drawing.Point(569, 55);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 115;
            this.label8.Text = "Earth Pennies";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.ForeColor = System.Drawing.Color.GhostWhite;
            this.label9.Location = new System.Drawing.Point(569, 71);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 116;
            this.label9.Text = "Earth Pennies";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.ForeColor = System.Drawing.Color.GhostWhite;
            this.label10.Location = new System.Drawing.Point(569, 87);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 117;
            this.label10.Text = "Earth Pennies";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.ForeColor = System.Drawing.Color.GhostWhite;
            this.label11.Location = new System.Drawing.Point(569, 103);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 118;
            this.label11.Text = "Earth Pennies";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(344, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 119;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12.Location = new System.Drawing.Point(448, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 13);
            this.label12.TabIndex = 120;
            this.label12.Text = "Miner Federation Exchange Rate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ControlText;
            this.label13.ForeColor = System.Drawing.Color.Gold;
            this.label13.Location = new System.Drawing.Point(536, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 121;
            this.label13.Text = "1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlText;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.Location = new System.Drawing.Point(536, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 13);
            this.label14.TabIndex = 122;
            this.label14.Text = "1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ControlText;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(536, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 124;
            this.label16.Text = "1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ControlText;
            this.label17.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label17.Location = new System.Drawing.Point(536, 104);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 125;
            this.label17.Text = "1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ControlText;
            this.label18.ForeColor = System.Drawing.Color.Gold;
            this.label18.Location = new System.Drawing.Point(552, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 126;
            this.label18.Text = "=";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ControlText;
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label19.Location = new System.Drawing.Point(552, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 127;
            this.label19.Text = "=";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ControlText;
            this.label15.ForeColor = System.Drawing.Color.Lime;
            this.label15.Location = new System.Drawing.Point(536, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 123;
            this.label15.Text = "1";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ControlText;
            this.label20.ForeColor = System.Drawing.Color.Lime;
            this.label20.Location = new System.Drawing.Point(552, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 128;
            this.label20.Text = "=";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.ControlText;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(552, 88);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 13);
            this.label21.TabIndex = 129;
            this.label21.Text = "=";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.ControlText;
            this.label22.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label22.Location = new System.Drawing.Point(552, 104);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 13);
            this.label22.TabIndex = 130;
            this.label22.Text = "=";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.ControlText;
            this.label23.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label23.Location = new System.Drawing.Point(648, 40);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 13);
            this.label23.TabIndex = 131;
            this.label23.Text = "SET VALUE";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.ControlText;
            this.label24.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label24.Location = new System.Drawing.Point(648, 56);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(66, 13);
            this.label24.TabIndex = 132;
            this.label24.Text = "SET VALUE";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.ControlText;
            this.label25.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label25.Location = new System.Drawing.Point(648, 88);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(66, 13);
            this.label25.TabIndex = 133;
            this.label25.Text = "SET VALUE";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.SystemColors.ControlText;
            this.label26.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label26.Location = new System.Drawing.Point(648, 72);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 13);
            this.label26.TabIndex = 134;
            this.label26.Text = "SET VALUE";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.ControlText;
            this.label27.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label27.Location = new System.Drawing.Point(648, 104);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(66, 13);
            this.label27.TabIndex = 135;
            this.label27.Text = "SET VALUE";
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.c.ForeColor = System.Drawing.Color.Gold;
            this.c.Location = new System.Drawing.Point(864, 40);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(104, 23);
            this.c.TabIndex = 136;
            this.c.Text = "Sell All Gold Ores";
            this.c.UseVisualStyleBackColor = false;
            // 
            // Sell1GoldOre
            // 
            this.Sell1GoldOre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sell1GoldOre.ForeColor = System.Drawing.Color.Gold;
            this.Sell1GoldOre.Location = new System.Drawing.Point(736, 40);
            this.Sell1GoldOre.Name = "Sell1GoldOre";
            this.Sell1GoldOre.Size = new System.Drawing.Size(112, 23);
            this.Sell1GoldOre.TabIndex = 137;
            this.Sell1GoldOre.Text = "Sell 1 Gold Ore";
            this.Sell1GoldOre.UseVisualStyleBackColor = false;
            // 
            // Sell1PlatinumOre
            // 
            this.Sell1PlatinumOre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sell1PlatinumOre.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sell1PlatinumOre.Location = new System.Drawing.Point(736, 72);
            this.Sell1PlatinumOre.Name = "Sell1PlatinumOre";
            this.Sell1PlatinumOre.Size = new System.Drawing.Size(112, 23);
            this.Sell1PlatinumOre.TabIndex = 138;
            this.Sell1PlatinumOre.Text = "Sell 1 Platinum Ore";
            this.Sell1PlatinumOre.UseVisualStyleBackColor = false;
            // 
            // SellAllPlatinumOre
            // 
            this.SellAllPlatinumOre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SellAllPlatinumOre.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.SellAllPlatinumOre.Location = new System.Drawing.Point(864, 72);
            this.SellAllPlatinumOre.Name = "SellAllPlatinumOre";
            this.SellAllPlatinumOre.Size = new System.Drawing.Size(104, 23);
            this.SellAllPlatinumOre.TabIndex = 139;
            this.SellAllPlatinumOre.Text = "Sell All Platinum Ore";
            this.SellAllPlatinumOre.UseVisualStyleBackColor = false;
            // 
            // Sell1EmeraldGem
            // 
            this.Sell1EmeraldGem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sell1EmeraldGem.ForeColor = System.Drawing.Color.Lime;
            this.Sell1EmeraldGem.Location = new System.Drawing.Point(736, 104);
            this.Sell1EmeraldGem.Name = "Sell1EmeraldGem";
            this.Sell1EmeraldGem.Size = new System.Drawing.Size(112, 23);
            this.Sell1EmeraldGem.TabIndex = 140;
            this.Sell1EmeraldGem.Text = "Sell 1 Emerald Gem";
            this.Sell1EmeraldGem.UseVisualStyleBackColor = false;
            // 
            // SellAllEmeraldGems
            // 
            this.SellAllEmeraldGems.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SellAllEmeraldGems.ForeColor = System.Drawing.Color.Lime;
            this.SellAllEmeraldGems.Location = new System.Drawing.Point(864, 104);
            this.SellAllEmeraldGems.Name = "SellAllEmeraldGems";
            this.SellAllEmeraldGems.Size = new System.Drawing.Size(104, 23);
            this.SellAllEmeraldGems.TabIndex = 141;
            this.SellAllEmeraldGems.Text = "Sell All Emerald Gems";
            this.SellAllEmeraldGems.UseVisualStyleBackColor = false;
            // 
            // Sell1Etherium
            // 
            this.Sell1Etherium.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sell1Etherium.ForeColor = System.Drawing.Color.Red;
            this.Sell1Etherium.Location = new System.Drawing.Point(736, 136);
            this.Sell1Etherium.Name = "Sell1Etherium";
            this.Sell1Etherium.Size = new System.Drawing.Size(112, 23);
            this.Sell1Etherium.TabIndex = 142;
            this.Sell1Etherium.Text = "Sell 1 Etherium";
            this.Sell1Etherium.UseVisualStyleBackColor = false;
            // 
            // SellAllEtherium
            // 
            this.SellAllEtherium.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SellAllEtherium.ForeColor = System.Drawing.Color.Red;
            this.SellAllEtherium.Location = new System.Drawing.Point(864, 136);
            this.SellAllEtherium.Name = "SellAllEtherium";
            this.SellAllEtherium.Size = new System.Drawing.Size(104, 23);
            this.SellAllEtherium.TabIndex = 143;
            this.SellAllEtherium.Text = "Sell All Etherium";
            this.SellAllEtherium.UseVisualStyleBackColor = false;
            this.SellAllEtherium.Click += new System.EventHandler(this.SellAllEtherium_Click);
            // 
            // Sell1Madtweed
            // 
            this.Sell1Madtweed.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sell1Madtweed.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Sell1Madtweed.Location = new System.Drawing.Point(736, 168);
            this.Sell1Madtweed.Name = "Sell1Madtweed";
            this.Sell1Madtweed.Size = new System.Drawing.Size(112, 23);
            this.Sell1Madtweed.TabIndex = 144;
            this.Sell1Madtweed.Text = "Sell 1 Madtweed";
            this.Sell1Madtweed.UseVisualStyleBackColor = false;
            // 
            // SellAllMadtweed
            // 
            this.SellAllMadtweed.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SellAllMadtweed.ForeColor = System.Drawing.Color.RoyalBlue;
            this.SellAllMadtweed.Location = new System.Drawing.Point(864, 168);
            this.SellAllMadtweed.Name = "SellAllMadtweed";
            this.SellAllMadtweed.Size = new System.Drawing.Size(104, 23);
            this.SellAllMadtweed.TabIndex = 145;
            this.SellAllMadtweed.Text = "Sell All Madtweed";
            this.SellAllMadtweed.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 577);
            this.Controls.Add(this.SellAllMadtweed);
            this.Controls.Add(this.Sell1Madtweed);
            this.Controls.Add(this.SellAllEtherium);
            this.Controls.Add(this.Sell1Etherium);
            this.Controls.Add(this.SellAllEmeraldGems);
            this.Controls.Add(this.Sell1EmeraldGem);
            this.Controls.Add(this.SellAllPlatinumOre);
            this.Controls.Add(this.Sell1PlatinumOre);
            this.Controls.Add(this.Sell1GoldOre);
            this.Controls.Add(this.c);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LabelMadtweed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MoonMinerTitle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SpaceFleetValue);
            this.Controls.Add(this.MadtweedValue);
            this.Controls.Add(this.EtheriumValue);
            this.Controls.Add(this.EmeraldValue);
            this.Controls.Add(this.PlatinumValue);
            this.Controls.Add(this.GoldValue);
            this.Controls.Add(this.SpaceFleetLabel);
            this.Controls.Add(this.MadtweedLabel);
            this.Controls.Add(this.EtheriumLabel);
            this.Controls.Add(this.EmeraldLabel);
            this.Controls.Add(this.platinumLabel);
            this.Controls.Add(this.GoldLabel);
            this.Controls.Add(this.IntroNaut);
            this.Controls.Add(this.SellAll);
            this.Controls.Add(this._BuyShipButton);
            this.Controls.Add(this.SpaceMarket);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.SpaceMarket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntroNaut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MoonMinerTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        internal System.Windows.Forms.PictureBox SpaceMarket;
        private System.Windows.Forms.Button _BuyShipButton;
        private System.Windows.Forms.Button SellAll;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox SpaceFleetValue;
        internal System.Windows.Forms.TextBox MadtweedValue;
        internal System.Windows.Forms.TextBox EtheriumValue;
        internal System.Windows.Forms.TextBox EmeraldValue;
        internal System.Windows.Forms.TextBox PlatinumValue;
        internal System.Windows.Forms.TextBox GoldValue;
        internal System.Windows.Forms.Label SpaceFleetLabel;
        internal System.Windows.Forms.Label MadtweedLabel;
        internal System.Windows.Forms.Label EtheriumLabel;
        internal System.Windows.Forms.Label EmeraldLabel;
        internal System.Windows.Forms.Label platinumLabel;
        internal System.Windows.Forms.Label GoldLabel;
        internal System.Windows.Forms.PictureBox IntroNaut;
        internal System.Windows.Forms.PictureBox MoonMinerTitle;
        internal System.Windows.Forms.Label LabelMadtweed;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.Button Sell1GoldOre;
        private System.Windows.Forms.Button Sell1PlatinumOre;
        private System.Windows.Forms.Button SellAllPlatinumOre;
        private System.Windows.Forms.Button Sell1EmeraldGem;
        private System.Windows.Forms.Button SellAllEmeraldGems;
        private System.Windows.Forms.Button Sell1Etherium;
        private System.Windows.Forms.Button SellAllEtherium;
        private System.Windows.Forms.Button Sell1Madtweed;
        private System.Windows.Forms.Button SellAllMadtweed;
        }
    }