namespace CycleComputerProgram
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.lblTimeTitle = new System.Windows.Forms.Label();
            this.lblIntervalTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSmode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalDistanceTitle = new System.Windows.Forms.Label();
            this.lblAverageSpeedTitle = new System.Windows.Forms.Label();
            this.lblMaxSpeedTitle = new System.Windows.Forms.Label();
            this.lblAverageHeartRateTitle = new System.Windows.Forms.Label();
            this.lblAverageHeartRate = new System.Windows.Forms.Label();
            this.lblMaxHeartRateTitle = new System.Windows.Forms.Label();
            this.lblMinHeartRateTitle = new System.Windows.Forms.Label();
            this.lblMaxHeartRate = new System.Windows.Forms.Label();
            this.lblMinHeartRate = new System.Windows.Forms.Label();
            this.lblAveragePowerTitle = new System.Windows.Forms.Label();
            this.lblMaxPowerTitle = new System.Windows.Forms.Label();
            this.lblAverageAltitudeTitle = new System.Windows.Forms.Label();
            this.lblMaxAltitudeTitle = new System.Windows.Forms.Label();
            this.lblAveragePower = new System.Windows.Forms.Label();
            this.lblMaxPower = new System.Windows.Forms.Label();
            this.lblAverageAltitude = new System.Windows.Forms.Label();
            this.lblMaxAltitude = new System.Windows.Forms.Label();
            this.lblAverageSpeed = new System.Windows.Forms.Label();
            this.lblMaxSpeed = new System.Windows.Forms.Label();
            this.btnUpdateUnits = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxUS = new System.Windows.Forms.RadioButton();
            this.checkBoxEuro = new System.Windows.Forms.RadioButton();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.txtMaxHR = new System.Windows.Forms.TextBox();
            this.gropp = new System.Windows.Forms.GroupBox();
            this.checkBpm = new System.Windows.Forms.RadioButton();
            this.checkPer = new System.Windows.Forms.RadioButton();
            this.btnMaxHR = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gropp.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importFileToolStripMenuItem
            // 
            this.importFileToolStripMenuItem.Name = "importFileToolStripMenuItem";
            this.importFileToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.importFileToolStripMenuItem.Text = "Import File";
            this.importFileToolStripMenuItem.Click += new System.EventHandler(this.importFileToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.AutoSize = true;
            this.lblDateTitle.Location = new System.Drawing.Point(12, 57);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(33, 13);
            this.lblDateTitle.TabIndex = 2;
            this.lblDateTitle.Text = "Date:";
            // 
            // lblTimeTitle
            // 
            this.lblTimeTitle.AutoSize = true;
            this.lblTimeTitle.Location = new System.Drawing.Point(12, 82);
            this.lblTimeTitle.Name = "lblTimeTitle";
            this.lblTimeTitle.Size = new System.Drawing.Size(33, 13);
            this.lblTimeTitle.TabIndex = 3;
            this.lblTimeTitle.Text = "Time:";
            // 
            // lblIntervalTitle
            // 
            this.lblIntervalTitle.AutoSize = true;
            this.lblIntervalTitle.Location = new System.Drawing.Point(12, 108);
            this.lblIntervalTitle.Name = "lblIntervalTitle";
            this.lblIntervalTitle.Size = new System.Drawing.Size(45, 13);
            this.lblIntervalTitle.TabIndex = 4;
            this.lblIntervalTitle.Text = "Interval:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(67, 57);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 13);
            this.lblDate.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(66, 82);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 13);
            this.lblTime.TabIndex = 6;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(66, 108);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(0, 13);
            this.lblInterval.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(219, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 282);
            this.dataGridView1.TabIndex = 8;
            // 
            // lblSmode
            // 
            this.lblSmode.AutoSize = true;
            this.lblSmode.Location = new System.Drawing.Point(12, 137);
            this.lblSmode.Name = "lblSmode";
            this.lblSmode.Size = new System.Drawing.Size(35, 13);
            this.lblSmode.TabIndex = 9;
            this.lblSmode.Text = "label1";
            this.lblSmode.Click += new System.EventHandler(this.lblSmode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Summary Data";
            // 
            // lblTotalDistanceTitle
            // 
            this.lblTotalDistanceTitle.AutoSize = true;
            this.lblTotalDistanceTitle.Location = new System.Drawing.Point(14, 369);
            this.lblTotalDistanceTitle.Name = "lblTotalDistanceTitle";
            this.lblTotalDistanceTitle.Size = new System.Drawing.Size(76, 13);
            this.lblTotalDistanceTitle.TabIndex = 11;
            this.lblTotalDistanceTitle.Text = "Total Distance";
            // 
            // lblAverageSpeedTitle
            // 
            this.lblAverageSpeedTitle.AutoSize = true;
            this.lblAverageSpeedTitle.Location = new System.Drawing.Point(14, 385);
            this.lblAverageSpeedTitle.Name = "lblAverageSpeedTitle";
            this.lblAverageSpeedTitle.Size = new System.Drawing.Size(81, 13);
            this.lblAverageSpeedTitle.TabIndex = 14;
            this.lblAverageSpeedTitle.Text = "Average Speed";
            // 
            // lblMaxSpeedTitle
            // 
            this.lblMaxSpeedTitle.AutoSize = true;
            this.lblMaxSpeedTitle.Location = new System.Drawing.Point(14, 399);
            this.lblMaxSpeedTitle.Name = "lblMaxSpeedTitle";
            this.lblMaxSpeedTitle.Size = new System.Drawing.Size(61, 13);
            this.lblMaxSpeedTitle.TabIndex = 15;
            this.lblMaxSpeedTitle.Text = "Max Speed";
            // 
            // lblAverageHeartRateTitle
            // 
            this.lblAverageHeartRateTitle.AutoSize = true;
            this.lblAverageHeartRateTitle.Location = new System.Drawing.Point(14, 412);
            this.lblAverageHeartRateTitle.Name = "lblAverageHeartRateTitle";
            this.lblAverageHeartRateTitle.Size = new System.Drawing.Size(102, 13);
            this.lblAverageHeartRateTitle.TabIndex = 16;
            this.lblAverageHeartRateTitle.Text = "Average Heart Rate";
            this.lblAverageHeartRateTitle.Click += new System.EventHandler(this.lblAverageHeartRateTitle_Click);
            // 
            // lblAverageHeartRate
            // 
            this.lblAverageHeartRate.AutoSize = true;
            this.lblAverageHeartRate.Location = new System.Drawing.Point(127, 414);
            this.lblAverageHeartRate.Name = "lblAverageHeartRate";
            this.lblAverageHeartRate.Size = new System.Drawing.Size(0, 13);
            this.lblAverageHeartRate.TabIndex = 17;
            // 
            // lblMaxHeartRateTitle
            // 
            this.lblMaxHeartRateTitle.AutoSize = true;
            this.lblMaxHeartRateTitle.Location = new System.Drawing.Point(13, 425);
            this.lblMaxHeartRateTitle.Name = "lblMaxHeartRateTitle";
            this.lblMaxHeartRateTitle.Size = new System.Drawing.Size(82, 13);
            this.lblMaxHeartRateTitle.TabIndex = 18;
            this.lblMaxHeartRateTitle.Text = "Max Heart Rate";
            // 
            // lblMinHeartRateTitle
            // 
            this.lblMinHeartRateTitle.AutoSize = true;
            this.lblMinHeartRateTitle.Location = new System.Drawing.Point(13, 439);
            this.lblMinHeartRateTitle.Name = "lblMinHeartRateTitle";
            this.lblMinHeartRateTitle.Size = new System.Drawing.Size(79, 13);
            this.lblMinHeartRateTitle.TabIndex = 19;
            this.lblMinHeartRateTitle.Text = "Min Heart Rate";
            // 
            // lblMaxHeartRate
            // 
            this.lblMaxHeartRate.AutoSize = true;
            this.lblMaxHeartRate.Location = new System.Drawing.Point(121, 425);
            this.lblMaxHeartRate.Name = "lblMaxHeartRate";
            this.lblMaxHeartRate.Size = new System.Drawing.Size(0, 13);
            this.lblMaxHeartRate.TabIndex = 20;
            // 
            // lblMinHeartRate
            // 
            this.lblMinHeartRate.AutoSize = true;
            this.lblMinHeartRate.Location = new System.Drawing.Point(119, 441);
            this.lblMinHeartRate.Name = "lblMinHeartRate";
            this.lblMinHeartRate.Size = new System.Drawing.Size(0, 13);
            this.lblMinHeartRate.TabIndex = 21;
            // 
            // lblAveragePowerTitle
            // 
            this.lblAveragePowerTitle.AutoSize = true;
            this.lblAveragePowerTitle.Location = new System.Drawing.Point(14, 453);
            this.lblAveragePowerTitle.Name = "lblAveragePowerTitle";
            this.lblAveragePowerTitle.Size = new System.Drawing.Size(80, 13);
            this.lblAveragePowerTitle.TabIndex = 22;
            this.lblAveragePowerTitle.Text = "Average Power";
            // 
            // lblMaxPowerTitle
            // 
            this.lblMaxPowerTitle.AutoSize = true;
            this.lblMaxPowerTitle.Location = new System.Drawing.Point(14, 467);
            this.lblMaxPowerTitle.Name = "lblMaxPowerTitle";
            this.lblMaxPowerTitle.Size = new System.Drawing.Size(60, 13);
            this.lblMaxPowerTitle.TabIndex = 23;
            this.lblMaxPowerTitle.Text = "Max Power";
            // 
            // lblAverageAltitudeTitle
            // 
            this.lblAverageAltitudeTitle.AutoSize = true;
            this.lblAverageAltitudeTitle.Location = new System.Drawing.Point(14, 480);
            this.lblAverageAltitudeTitle.Name = "lblAverageAltitudeTitle";
            this.lblAverageAltitudeTitle.Size = new System.Drawing.Size(85, 13);
            this.lblAverageAltitudeTitle.TabIndex = 24;
            this.lblAverageAltitudeTitle.Text = "Average Altitude";
            // 
            // lblMaxAltitudeTitle
            // 
            this.lblMaxAltitudeTitle.AutoSize = true;
            this.lblMaxAltitudeTitle.Location = new System.Drawing.Point(14, 494);
            this.lblMaxAltitudeTitle.Name = "lblMaxAltitudeTitle";
            this.lblMaxAltitudeTitle.Size = new System.Drawing.Size(65, 13);
            this.lblMaxAltitudeTitle.TabIndex = 25;
            this.lblMaxAltitudeTitle.Text = "Max Altitude";
            // 
            // lblAveragePower
            // 
            this.lblAveragePower.AutoSize = true;
            this.lblAveragePower.Location = new System.Drawing.Point(124, 454);
            this.lblAveragePower.Name = "lblAveragePower";
            this.lblAveragePower.Size = new System.Drawing.Size(0, 13);
            this.lblAveragePower.TabIndex = 26;
            // 
            // lblMaxPower
            // 
            this.lblMaxPower.AutoSize = true;
            this.lblMaxPower.Location = new System.Drawing.Point(122, 468);
            this.lblMaxPower.Name = "lblMaxPower";
            this.lblMaxPower.Size = new System.Drawing.Size(0, 13);
            this.lblMaxPower.TabIndex = 27;
            // 
            // lblAverageAltitude
            // 
            this.lblAverageAltitude.AutoSize = true;
            this.lblAverageAltitude.Location = new System.Drawing.Point(122, 480);
            this.lblAverageAltitude.Name = "lblAverageAltitude";
            this.lblAverageAltitude.Size = new System.Drawing.Size(0, 13);
            this.lblAverageAltitude.TabIndex = 28;
            // 
            // lblMaxAltitude
            // 
            this.lblMaxAltitude.AutoSize = true;
            this.lblMaxAltitude.Location = new System.Drawing.Point(122, 491);
            this.lblMaxAltitude.Name = "lblMaxAltitude";
            this.lblMaxAltitude.Size = new System.Drawing.Size(0, 13);
            this.lblMaxAltitude.TabIndex = 29;
            // 
            // lblAverageSpeed
            // 
            this.lblAverageSpeed.AutoSize = true;
            this.lblAverageSpeed.Location = new System.Drawing.Point(125, 386);
            this.lblAverageSpeed.Name = "lblAverageSpeed";
            this.lblAverageSpeed.Size = new System.Drawing.Size(0, 13);
            this.lblAverageSpeed.TabIndex = 30;
            // 
            // lblMaxSpeed
            // 
            this.lblMaxSpeed.AutoSize = true;
            this.lblMaxSpeed.Location = new System.Drawing.Point(124, 398);
            this.lblMaxSpeed.Name = "lblMaxSpeed";
            this.lblMaxSpeed.Size = new System.Drawing.Size(0, 13);
            this.lblMaxSpeed.TabIndex = 31;
            // 
            // btnUpdateUnits
            // 
            this.btnUpdateUnits.Location = new System.Drawing.Point(512, 301);
            this.btnUpdateUnits.Name = "btnUpdateUnits";
            this.btnUpdateUnits.Size = new System.Drawing.Size(78, 20);
            this.btnUpdateUnits.TabIndex = 32;
            this.btnUpdateUnits.Text = "Update Units";
            this.btnUpdateUnits.UseVisualStyleBackColor = true;
            this.btnUpdateUnits.Click += new System.EventHandler(this.btnUpdateUnits_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxUS);
            this.panel1.Controls.Add(this.checkBoxEuro);
            this.panel1.Location = new System.Drawing.Point(223, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 23);
            this.panel1.TabIndex = 33;
            // 
            // checkBoxUS
            // 
            this.checkBoxUS.AutoSize = true;
            this.checkBoxUS.Location = new System.Drawing.Point(94, 2);
            this.checkBoxUS.Name = "checkBoxUS";
            this.checkBoxUS.Size = new System.Drawing.Size(65, 17);
            this.checkBoxUS.TabIndex = 35;
            this.checkBoxUS.TabStop = true;
            this.checkBoxUS.Text = "Us Units";
            this.checkBoxUS.UseVisualStyleBackColor = true;
            // 
            // checkBoxEuro
            // 
            this.checkBoxEuro.AutoSize = true;
            this.checkBoxEuro.Location = new System.Drawing.Point(1, 2);
            this.checkBoxEuro.Name = "checkBoxEuro";
            this.checkBoxEuro.Size = new System.Drawing.Size(74, 17);
            this.checkBoxEuro.TabIndex = 34;
            this.checkBoxEuro.TabStop = true;
            this.checkBoxEuro.Text = "Euro Units";
            this.checkBoxEuro.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.IsShowPointValues = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(296, 27);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.PointValueFormat = "G";
            this.zedGraphControl1.Size = new System.Drawing.Size(150, 150);
            this.zedGraphControl1.TabIndex = 34;
            // 
            // txtMaxHR
            // 
            this.txtMaxHR.Location = new System.Drawing.Point(19, 250);
            this.txtMaxHR.Name = "txtMaxHR";
            this.txtMaxHR.Size = new System.Drawing.Size(100, 20);
            this.txtMaxHR.TabIndex = 35;
            // 
            // gropp
            // 
            this.gropp.Controls.Add(this.checkPer);
            this.gropp.Controls.Add(this.checkBpm);
            this.gropp.Location = new System.Drawing.Point(400, 295);
            this.gropp.Name = "gropp";
            this.gropp.Size = new System.Drawing.Size(104, 29);
            this.gropp.TabIndex = 36;
            this.gropp.TabStop = false;
            // 
            // checkBpm
            // 
            this.checkBpm.AutoSize = true;
            this.checkBpm.Location = new System.Drawing.Point(7, 9);
            this.checkBpm.Name = "checkBpm";
            this.checkBpm.Size = new System.Drawing.Size(48, 17);
            this.checkBpm.TabIndex = 0;
            this.checkBpm.TabStop = true;
            this.checkBpm.Text = "BPM";
            this.checkBpm.UseVisualStyleBackColor = true;
            // 
            // checkPer
            // 
            this.checkPer.AutoSize = true;
            this.checkPer.Location = new System.Drawing.Point(58, 9);
            this.checkPer.Name = "checkPer";
            this.checkPer.Size = new System.Drawing.Size(48, 17);
            this.checkPer.TabIndex = 1;
            this.checkPer.TabStop = true;
            this.checkPer.Text = "% of ";
            this.checkPer.UseVisualStyleBackColor = true;
            this.checkPer.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnMaxHR
            // 
            this.btnMaxHR.Location = new System.Drawing.Point(130, 248);
            this.btnMaxHR.Name = "btnMaxHR";
            this.btnMaxHR.Size = new System.Drawing.Size(101, 23);
            this.btnMaxHR.TabIndex = 37;
            this.btnMaxHR.Text = "Update Max Hr";
            this.btnMaxHR.UseVisualStyleBackColor = true;
            this.btnMaxHR.Click += new System.EventHandler(this.btnMaxHR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.btnMaxHR);
            this.Controls.Add(this.gropp);
            this.Controls.Add(this.txtMaxHR);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdateUnits);
            this.Controls.Add(this.lblMaxSpeed);
            this.Controls.Add(this.lblAverageSpeed);
            this.Controls.Add(this.lblMaxAltitude);
            this.Controls.Add(this.lblAverageAltitude);
            this.Controls.Add(this.lblMaxPower);
            this.Controls.Add(this.lblAveragePower);
            this.Controls.Add(this.lblMaxAltitudeTitle);
            this.Controls.Add(this.lblAverageAltitudeTitle);
            this.Controls.Add(this.lblMaxPowerTitle);
            this.Controls.Add(this.lblAveragePowerTitle);
            this.Controls.Add(this.lblMinHeartRate);
            this.Controls.Add(this.lblMaxHeartRate);
            this.Controls.Add(this.lblMinHeartRateTitle);
            this.Controls.Add(this.lblMaxHeartRateTitle);
            this.Controls.Add(this.lblAverageHeartRate);
            this.Controls.Add(this.lblAverageHeartRateTitle);
            this.Controls.Add(this.lblMaxSpeedTitle);
            this.Controls.Add(this.lblAverageSpeedTitle);
            this.Controls.Add(this.lblTotalDistanceTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSmode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblIntervalTitle);
            this.Controls.Add(this.lblTimeTitle);
            this.Controls.Add(this.lblDateTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Cycle Computer Program";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gropp.ResumeLayout(false);
            this.gropp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblDateTitle;
        private System.Windows.Forms.Label lblTimeTitle;
        private System.Windows.Forms.Label lblIntervalTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSmode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalDistanceTitle;
        private System.Windows.Forms.Label lblAverageSpeedTitle;
        private System.Windows.Forms.Label lblMaxSpeedTitle;
        private System.Windows.Forms.Label lblAverageHeartRateTitle;
        private System.Windows.Forms.Label lblAverageHeartRate;
        private System.Windows.Forms.Label lblMaxHeartRateTitle;
        private System.Windows.Forms.Label lblMinHeartRateTitle;
        private System.Windows.Forms.Label lblMaxHeartRate;
        private System.Windows.Forms.Label lblMinHeartRate;
        private System.Windows.Forms.Label lblAveragePowerTitle;
        private System.Windows.Forms.Label lblMaxPowerTitle;
        private System.Windows.Forms.Label lblAverageAltitudeTitle;
        private System.Windows.Forms.Label lblMaxAltitudeTitle;
        private System.Windows.Forms.Label lblAveragePower;
        private System.Windows.Forms.Label lblMaxPower;
        private System.Windows.Forms.Label lblAverageAltitude;
        private System.Windows.Forms.Label lblMaxAltitude;
        private System.Windows.Forms.Label lblAverageSpeed;
        private System.Windows.Forms.Label lblMaxSpeed;
        private System.Windows.Forms.Button btnUpdateUnits;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton checkBoxUS;
        private System.Windows.Forms.RadioButton checkBoxEuro;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TextBox txtMaxHR;
        private System.Windows.Forms.GroupBox gropp;
        private System.Windows.Forms.RadioButton checkBpm;
        private System.Windows.Forms.RadioButton checkPer;
        private System.Windows.Forms.Button btnMaxHR;
    }
}

