﻿namespace LED_Matrix_Control_2
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.connectToCOMPort = new System.Windows.Forms.Button();
            this.matrixContainer = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1Settings = new System.Windows.Forms.TabPage();
            this.clearButton1 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.resetPixelOrder = new System.Windows.Forms.Button();
            this.savePixelOrder = new System.Windows.Forms.Button();
            this.editPixelOrder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showMatrixPreview = new System.Windows.Forms.CheckBox();
            this.pixlsYUpDown = new System.Windows.Forms.NumericUpDown();
            this.pixlsXUpDown = new System.Windows.Forms.NumericUpDown();
            this.buildBoxes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.refreshCOMPorts = new System.Windows.Forms.Button();
            this.disconnectFromCOMPort = new System.Windows.Forms.Button();
            this.portsList = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.blueWB = new System.Windows.Forms.NumericUpDown();
            this.greenWB = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.redWB = new System.Windows.Forms.NumericUpDown();
            this.tab2Draw = new System.Windows.Forms.TabPage();
            this.tab3Image = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.InterpolationModeDropDown1 = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.stopScreenCap = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.screenSelection = new System.Windows.Forms.ComboBox();
            this.startScreenCap = new System.Windows.Forms.Button();
            this.animationGroup = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.animationPlayMode = new System.Windows.Forms.ComboBox();
            this.stopAnimation = new System.Windows.Forms.Button();
            this.startAnimation = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.scaleSettingGroup = new System.Windows.Forms.GroupBox();
            this.croppedAreaHLabel = new System.Windows.Forms.Label();
            this.croppedAreaWLabel = new System.Windows.Forms.Label();
            this.lockSizeToggle = new System.Windows.Forms.CheckBox();
            this.scaleEndYUD = new System.Windows.Forms.NumericUpDown();
            this.scaleEndXUD = new System.Windows.Forms.NumericUpDown();
            this.scaleStartYUD = new System.Windows.Forms.NumericUpDown();
            this.scaleStartXUD = new System.Windows.Forms.NumericUpDown();
            this.setScaleButton = new System.Windows.Forms.Button();
            this.scaleEndY = new System.Windows.Forms.TrackBar();
            this.scaleEndX = new System.Windows.Forms.TrackBar();
            this.scaleStartY = new System.Windows.Forms.TrackBar();
            this.scaleStartX = new System.Windows.Forms.TrackBar();
            this.resetScaleButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.imageSelectButton = new System.Windows.Forms.Button();
            this.tab4Audio = new System.Windows.Forms.TabPage();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.animTimer = new System.Windows.Forms.Timer(this.components);
            this.screenCapTimer = new System.Windows.Forms.Timer(this.components);
            this.statusBar = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tab1Settings.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixlsYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixlsXUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueWB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenWB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redWB)).BeginInit();
            this.tab3Image.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.animationGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.scaleSettingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleEndYUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleEndXUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleStartYUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleStartXUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleEndY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleEndX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleStartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleStartX)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tab4Audio.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectToCOMPort
            // 
            this.connectToCOMPort.Location = new System.Drawing.Point(6, 46);
            this.connectToCOMPort.Name = "connectToCOMPort";
            this.connectToCOMPort.Size = new System.Drawing.Size(128, 23);
            this.connectToCOMPort.TabIndex = 0;
            this.connectToCOMPort.Text = "Connect";
            this.connectToCOMPort.UseVisualStyleBackColor = true;
            this.connectToCOMPort.Click += new System.EventHandler(this.connectToCOMPort_Click);
            // 
            // matrixContainer
            // 
            this.matrixContainer.AutoSize = true;
            this.matrixContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.matrixContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matrixContainer.Location = new System.Drawing.Point(517, 6);
            this.matrixContainer.Margin = new System.Windows.Forms.Padding(0);
            this.matrixContainer.MinimumSize = new System.Drawing.Size(10, 646);
            this.matrixContainer.Name = "matrixContainer";
            this.matrixContainer.Size = new System.Drawing.Size(10, 646);
            this.matrixContainer.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1Settings);
            this.tabControl1.Controls.Add(this.tab2Draw);
            this.tabControl1.Controls.Add(this.tab3Image);
            this.tabControl1.Controls.Add(this.tab4Audio);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(3, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(512, 649);
            this.tabControl1.TabIndex = 5;
            // 
            // tab1Settings
            // 
            this.tab1Settings.Controls.Add(this.clearButton1);
            this.tab1Settings.Controls.Add(this.groupBox8);
            this.tab1Settings.Controls.Add(this.groupBox5);
            this.tab1Settings.Location = new System.Drawing.Point(4, 22);
            this.tab1Settings.Name = "tab1Settings";
            this.tab1Settings.Padding = new System.Windows.Forms.Padding(3);
            this.tab1Settings.Size = new System.Drawing.Size(504, 623);
            this.tab1Settings.TabIndex = 0;
            this.tab1Settings.Text = "Settings";
            this.tab1Settings.UseVisualStyleBackColor = true;
            // 
            // clearButton1
            // 
            this.clearButton1.Location = new System.Drawing.Point(255, 320);
            this.clearButton1.Name = "clearButton1";
            this.clearButton1.Size = new System.Drawing.Size(75, 23);
            this.clearButton1.TabIndex = 7;
            this.clearButton1.Text = "Clear Frame";
            this.clearButton1.UseVisualStyleBackColor = true;
            this.clearButton1.Click += new System.EventHandler(this.clearFrame_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.groupBox2);
            this.groupBox8.Controls.Add(this.groupBox1);
            this.groupBox8.Location = new System.Drawing.Point(7, 7);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(491, 188);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Setup";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.resetPixelOrder);
            this.groupBox9.Controls.Add(this.savePixelOrder);
            this.groupBox9.Controls.Add(this.editPixelOrder);
            this.groupBox9.Location = new System.Drawing.Point(282, 19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(203, 106);
            this.groupBox9.TabIndex = 7;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "3. Pixel Order";
            // 
            // resetPixelOrder
            // 
            this.resetPixelOrder.Enabled = false;
            this.resetPixelOrder.Location = new System.Drawing.Point(6, 77);
            this.resetPixelOrder.Name = "resetPixelOrder";
            this.resetPixelOrder.Size = new System.Drawing.Size(75, 23);
            this.resetPixelOrder.TabIndex = 2;
            this.resetPixelOrder.Text = "Reset";
            this.resetPixelOrder.UseVisualStyleBackColor = true;
            this.resetPixelOrder.Click += new System.EventHandler(this.resetPixelOrder_Click);
            // 
            // savePixelOrder
            // 
            this.savePixelOrder.Enabled = false;
            this.savePixelOrder.Location = new System.Drawing.Point(6, 48);
            this.savePixelOrder.Name = "savePixelOrder";
            this.savePixelOrder.Size = new System.Drawing.Size(75, 23);
            this.savePixelOrder.TabIndex = 1;
            this.savePixelOrder.Text = "Save";
            this.savePixelOrder.UseVisualStyleBackColor = true;
            this.savePixelOrder.Click += new System.EventHandler(this.savePixelOrder_Click);
            // 
            // editPixelOrder
            // 
            this.editPixelOrder.Location = new System.Drawing.Point(6, 19);
            this.editPixelOrder.Name = "editPixelOrder";
            this.editPixelOrder.Size = new System.Drawing.Size(75, 23);
            this.editPixelOrder.TabIndex = 0;
            this.editPixelOrder.Text = "Create New";
            this.editPixelOrder.UseVisualStyleBackColor = true;
            this.editPixelOrder.Click += new System.EventHandler(this.editPixelOrder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showMatrixPreview);
            this.groupBox2.Controls.Add(this.pixlsYUpDown);
            this.groupBox2.Controls.Add(this.pixlsXUpDown);
            this.groupBox2.Controls.Add(this.buildBoxes);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 127);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1. Matrix Dimensions";
            // 
            // showMatrixPreview
            // 
            this.showMatrixPreview.AutoSize = true;
            this.showMatrixPreview.Checked = true;
            this.showMatrixPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showMatrixPreview.Location = new System.Drawing.Point(7, 105);
            this.showMatrixPreview.Name = "showMatrixPreview";
            this.showMatrixPreview.Size = new System.Drawing.Size(94, 17);
            this.showMatrixPreview.TabIndex = 6;
            this.showMatrixPreview.Text = "Show Preview";
            this.showMatrixPreview.UseVisualStyleBackColor = true;
            this.showMatrixPreview.CheckedChanged += new System.EventHandler(this.showMatrixPreview_CheckedChanged);
            // 
            // pixlsYUpDown
            // 
            this.pixlsYUpDown.Location = new System.Drawing.Point(6, 45);
            this.pixlsYUpDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.pixlsYUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.pixlsYUpDown.Name = "pixlsYUpDown";
            this.pixlsYUpDown.Size = new System.Drawing.Size(109, 20);
            this.pixlsYUpDown.TabIndex = 5;
            this.pixlsYUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // pixlsXUpDown
            // 
            this.pixlsXUpDown.Location = new System.Drawing.Point(6, 19);
            this.pixlsXUpDown.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.pixlsXUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.pixlsXUpDown.Name = "pixlsXUpDown";
            this.pixlsXUpDown.Size = new System.Drawing.Size(109, 20);
            this.pixlsXUpDown.TabIndex = 4;
            this.pixlsXUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buildBoxes
            // 
            this.buildBoxes.Location = new System.Drawing.Point(6, 75);
            this.buildBoxes.Name = "buildBoxes";
            this.buildBoxes.Size = new System.Drawing.Size(109, 23);
            this.buildBoxes.TabIndex = 3;
            this.buildBoxes.Text = "Set Dimensions";
            this.buildBoxes.UseVisualStyleBackColor = true;
            this.buildBoxes.Click += new System.EventHandler(this.buildBoxes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.refreshCOMPorts);
            this.groupBox1.Controls.Add(this.disconnectFromCOMPort);
            this.groupBox1.Controls.Add(this.portsList);
            this.groupBox1.Controls.Add(this.connectToCOMPort);
            this.groupBox1.Location = new System.Drawing.Point(136, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 134);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2. Serial Connection";
            // 
            // refreshCOMPorts
            // 
            this.refreshCOMPorts.Location = new System.Drawing.Point(6, 104);
            this.refreshCOMPorts.Name = "refreshCOMPorts";
            this.refreshCOMPorts.Size = new System.Drawing.Size(128, 23);
            this.refreshCOMPorts.TabIndex = 6;
            this.refreshCOMPorts.Text = "Refresh";
            this.refreshCOMPorts.UseVisualStyleBackColor = true;
            this.refreshCOMPorts.Click += new System.EventHandler(this.refreshCOMPorts_Click);
            // 
            // disconnectFromCOMPort
            // 
            this.disconnectFromCOMPort.Location = new System.Drawing.Point(6, 75);
            this.disconnectFromCOMPort.Name = "disconnectFromCOMPort";
            this.disconnectFromCOMPort.Size = new System.Drawing.Size(128, 23);
            this.disconnectFromCOMPort.TabIndex = 5;
            this.disconnectFromCOMPort.Text = "Disconnect";
            this.disconnectFromCOMPort.UseVisualStyleBackColor = true;
            this.disconnectFromCOMPort.Click += new System.EventHandler(this.disconnectFromCOMPort_Click);
            // 
            // portsList
            // 
            this.portsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portsList.FormattingEnabled = true;
            this.portsList.Location = new System.Drawing.Point(6, 19);
            this.portsList.Name = "portsList";
            this.portsList.Size = new System.Drawing.Size(128, 21);
            this.portsList.TabIndex = 4;
            this.portsList.SelectedIndexChanged += new System.EventHandler(this.disconnectFromCOMPort_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.blueWB);
            this.groupBox5.Controls.Add(this.greenWB);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.redWB);
            this.groupBox5.Location = new System.Drawing.Point(7, 201);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(139, 131);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "White Balance";
            // 
            // blueWB
            // 
            this.blueWB.Location = new System.Drawing.Point(48, 71);
            this.blueWB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueWB.Name = "blueWB";
            this.blueWB.Size = new System.Drawing.Size(85, 20);
            this.blueWB.TabIndex = 5;
            this.blueWB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueWB.ValueChanged += new System.EventHandler(this.WBValueChanged);
            // 
            // greenWB
            // 
            this.greenWB.Location = new System.Drawing.Point(48, 45);
            this.greenWB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenWB.Name = "greenWB";
            this.greenWB.Size = new System.Drawing.Size(85, 20);
            this.greenWB.TabIndex = 4;
            this.greenWB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenWB.ValueChanged += new System.EventHandler(this.WBValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Blue";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Green";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Red";
            // 
            // redWB
            // 
            this.redWB.Location = new System.Drawing.Point(48, 19);
            this.redWB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redWB.Name = "redWB";
            this.redWB.Size = new System.Drawing.Size(85, 20);
            this.redWB.TabIndex = 0;
            this.redWB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redWB.ValueChanged += new System.EventHandler(this.WBValueChanged);
            // 
            // tab2Draw
            // 
            this.tab2Draw.Location = new System.Drawing.Point(4, 22);
            this.tab2Draw.Name = "tab2Draw";
            this.tab2Draw.Padding = new System.Windows.Forms.Padding(3);
            this.tab2Draw.Size = new System.Drawing.Size(504, 623);
            this.tab2Draw.TabIndex = 1;
            this.tab2Draw.Text = "Drawing";
            this.tab2Draw.UseVisualStyleBackColor = true;
            // 
            // tab3Image
            // 
            this.tab3Image.Controls.Add(this.groupBox7);
            this.tab3Image.Controls.Add(this.groupBox6);
            this.tab3Image.Controls.Add(this.animationGroup);
            this.tab3Image.Controls.Add(this.scaleSettingGroup);
            this.tab3Image.Controls.Add(this.groupBox4);
            this.tab3Image.Controls.Add(this.groupBox3);
            this.tab3Image.Location = new System.Drawing.Point(4, 22);
            this.tab3Image.Name = "tab3Image";
            this.tab3Image.Size = new System.Drawing.Size(504, 623);
            this.tab3Image.TabIndex = 2;
            this.tab3Image.Text = "Imaging";
            this.tab3Image.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.InterpolationModeDropDown1);
            this.groupBox7.Location = new System.Drawing.Point(3, 113);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(207, 48);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Interpolation Mode";
            // 
            // InterpolationModeDropDown1
            // 
            this.InterpolationModeDropDown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InterpolationModeDropDown1.FormattingEnabled = true;
            this.InterpolationModeDropDown1.ItemHeight = 13;
            this.InterpolationModeDropDown1.Items.AddRange(new object[] {
            "Nearest Neighbor",
            "Low",
            "Medium",
            "High"});
            this.InterpolationModeDropDown1.Location = new System.Drawing.Point(6, 16);
            this.InterpolationModeDropDown1.MaximumSize = new System.Drawing.Size(400, 0);
            this.InterpolationModeDropDown1.Name = "InterpolationModeDropDown1";
            this.InterpolationModeDropDown1.Size = new System.Drawing.Size(110, 21);
            this.InterpolationModeDropDown1.TabIndex = 2;
            this.InterpolationModeDropDown1.SelectedIndexChanged += new System.EventHandler(this.InterpolationModeDropDown1_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.stopScreenCap);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.screenSelection);
            this.groupBox6.Controls.Add(this.startScreenCap);
            this.groupBox6.Location = new System.Drawing.Point(360, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(133, 104);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Screen Capture";
            // 
            // stopScreenCap
            // 
            this.stopScreenCap.Location = new System.Drawing.Point(6, 48);
            this.stopScreenCap.Name = "stopScreenCap";
            this.stopScreenCap.Size = new System.Drawing.Size(121, 23);
            this.stopScreenCap.TabIndex = 9;
            this.stopScreenCap.Text = "Stop Capture";
            this.stopScreenCap.UseVisualStyleBackColor = true;
            this.stopScreenCap.Click += new System.EventHandler(this.stopScreenCap_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Source";
            // 
            // screenSelection
            // 
            this.screenSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.screenSelection.FormattingEnabled = true;
            this.screenSelection.ItemHeight = 13;
            this.screenSelection.Location = new System.Drawing.Point(53, 77);
            this.screenSelection.MaximumSize = new System.Drawing.Size(400, 0);
            this.screenSelection.Name = "screenSelection";
            this.screenSelection.Size = new System.Drawing.Size(74, 21);
            this.screenSelection.TabIndex = 8;
            // 
            // startScreenCap
            // 
            this.startScreenCap.Location = new System.Drawing.Point(6, 19);
            this.startScreenCap.Name = "startScreenCap";
            this.startScreenCap.Size = new System.Drawing.Size(121, 23);
            this.startScreenCap.TabIndex = 0;
            this.startScreenCap.Text = "Start Capture";
            this.startScreenCap.UseVisualStyleBackColor = true;
            this.startScreenCap.Click += new System.EventHandler(this.startScreenCap_Click);
            // 
            // animationGroup
            // 
            this.animationGroup.Controls.Add(this.label7);
            this.animationGroup.Controls.Add(this.numericUpDown1);
            this.animationGroup.Controls.Add(this.animationPlayMode);
            this.animationGroup.Controls.Add(this.stopAnimation);
            this.animationGroup.Controls.Add(this.startAnimation);
            this.animationGroup.Controls.Add(this.label6);
            this.animationGroup.Enabled = false;
            this.animationGroup.Location = new System.Drawing.Point(131, 3);
            this.animationGroup.Name = "animationGroup";
            this.animationGroup.Size = new System.Drawing.Size(218, 80);
            this.animationGroup.TabIndex = 9;
            this.animationGroup.TabStop = false;
            this.animationGroup.Text = "Animation Controls";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mode";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(145, 48);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // animationPlayMode
            // 
            this.animationPlayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animationPlayMode.FormattingEnabled = true;
            this.animationPlayMode.Items.AddRange(new object[] {
            "Loop",
            "Bounce",
            "Reverse"});
            this.animationPlayMode.Location = new System.Drawing.Point(46, 48);
            this.animationPlayMode.Name = "animationPlayMode";
            this.animationPlayMode.Size = new System.Drawing.Size(60, 21);
            this.animationPlayMode.TabIndex = 4;
            // 
            // stopAnimation
            // 
            this.stopAnimation.Location = new System.Drawing.Point(112, 19);
            this.stopAnimation.Name = "stopAnimation";
            this.stopAnimation.Size = new System.Drawing.Size(100, 23);
            this.stopAnimation.TabIndex = 2;
            this.stopAnimation.Text = "Stop";
            this.stopAnimation.UseVisualStyleBackColor = true;
            this.stopAnimation.Click += new System.EventHandler(this.stopAnimation_Click);
            // 
            // startAnimation
            // 
            this.startAnimation.Location = new System.Drawing.Point(6, 19);
            this.startAnimation.Name = "startAnimation";
            this.startAnimation.Size = new System.Drawing.Size(100, 23);
            this.startAnimation.TabIndex = 1;
            this.startAnimation.Text = "Start";
            this.startAnimation.UseVisualStyleBackColor = true;
            this.startAnimation.Click += new System.EventHandler(this.startAnimation_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "FPS";
            // 
            // scaleSettingGroup
            // 
            this.scaleSettingGroup.Controls.Add(this.croppedAreaHLabel);
            this.scaleSettingGroup.Controls.Add(this.croppedAreaWLabel);
            this.scaleSettingGroup.Controls.Add(this.lockSizeToggle);
            this.scaleSettingGroup.Controls.Add(this.scaleEndYUD);
            this.scaleSettingGroup.Controls.Add(this.scaleEndXUD);
            this.scaleSettingGroup.Controls.Add(this.scaleStartYUD);
            this.scaleSettingGroup.Controls.Add(this.scaleStartXUD);
            this.scaleSettingGroup.Controls.Add(this.setScaleButton);
            this.scaleSettingGroup.Controls.Add(this.scaleEndY);
            this.scaleSettingGroup.Controls.Add(this.scaleEndX);
            this.scaleSettingGroup.Controls.Add(this.scaleStartY);
            this.scaleSettingGroup.Controls.Add(this.scaleStartX);
            this.scaleSettingGroup.Controls.Add(this.resetScaleButton);
            this.scaleSettingGroup.Controls.Add(this.label5);
            this.scaleSettingGroup.Controls.Add(this.label4);
            this.scaleSettingGroup.Controls.Add(this.label3);
            this.scaleSettingGroup.Controls.Add(this.label2);
            this.scaleSettingGroup.Enabled = false;
            this.scaleSettingGroup.Location = new System.Drawing.Point(3, 163);
            this.scaleSettingGroup.Name = "scaleSettingGroup";
            this.scaleSettingGroup.Size = new System.Drawing.Size(498, 126);
            this.scaleSettingGroup.TabIndex = 8;
            this.scaleSettingGroup.TabStop = false;
            this.scaleSettingGroup.Text = "Scale Settings";
            // 
            // croppedAreaHLabel
            // 
            this.croppedAreaHLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.croppedAreaHLabel.AutoSize = true;
            this.croppedAreaHLabel.Location = new System.Drawing.Point(412, 105);
            this.croppedAreaHLabel.Name = "croppedAreaHLabel";
            this.croppedAreaHLabel.Size = new System.Drawing.Size(44, 13);
            this.croppedAreaHLabel.TabIndex = 25;
            this.croppedAreaHLabel.Text = "Height: ";
            // 
            // croppedAreaWLabel
            // 
            this.croppedAreaWLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.croppedAreaWLabel.AutoSize = true;
            this.croppedAreaWLabel.Location = new System.Drawing.Point(415, 92);
            this.croppedAreaWLabel.Name = "croppedAreaWLabel";
            this.croppedAreaWLabel.Size = new System.Drawing.Size(41, 13);
            this.croppedAreaWLabel.TabIndex = 24;
            this.croppedAreaWLabel.Text = "Width: ";
            // 
            // lockSizeToggle
            // 
            this.lockSizeToggle.AutoSize = true;
            this.lockSizeToggle.Location = new System.Drawing.Point(412, 73);
            this.lockSizeToggle.Name = "lockSizeToggle";
            this.lockSizeToggle.Size = new System.Drawing.Size(73, 17);
            this.lockSizeToggle.TabIndex = 22;
            this.lockSizeToggle.Text = "Lock Size";
            this.lockSizeToggle.UseVisualStyleBackColor = true;
            this.lockSizeToggle.CheckedChanged += new System.EventHandler(this.lockSizeToggle_CheckedChanged);
            // 
            // scaleEndYUD
            // 
            this.scaleEndYUD.Location = new System.Drawing.Point(346, 97);
            this.scaleEndYUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.scaleEndYUD.Name = "scaleEndYUD";
            this.scaleEndYUD.Size = new System.Drawing.Size(59, 20);
            this.scaleEndYUD.TabIndex = 21;
            this.scaleEndYUD.ValueChanged += new System.EventHandler(this.scaleStartXUpDown_ValueChanged);
            // 
            // scaleEndXUD
            // 
            this.scaleEndXUD.Location = new System.Drawing.Point(346, 71);
            this.scaleEndXUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.scaleEndXUD.Name = "scaleEndXUD";
            this.scaleEndXUD.Size = new System.Drawing.Size(59, 20);
            this.scaleEndXUD.TabIndex = 20;
            this.scaleEndXUD.ValueChanged += new System.EventHandler(this.scaleStartXUpDown_ValueChanged);
            // 
            // scaleStartYUD
            // 
            this.scaleStartYUD.Location = new System.Drawing.Point(346, 45);
            this.scaleStartYUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.scaleStartYUD.Name = "scaleStartYUD";
            this.scaleStartYUD.Size = new System.Drawing.Size(59, 20);
            this.scaleStartYUD.TabIndex = 19;
            this.scaleStartYUD.ValueChanged += new System.EventHandler(this.scaleStartXUpDown_ValueChanged);
            // 
            // scaleStartXUD
            // 
            this.scaleStartXUD.Location = new System.Drawing.Point(346, 19);
            this.scaleStartXUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.scaleStartXUD.Name = "scaleStartXUD";
            this.scaleStartXUD.Size = new System.Drawing.Size(59, 20);
            this.scaleStartXUD.TabIndex = 18;
            this.scaleStartXUD.ValueChanged += new System.EventHandler(this.scaleStartXUpDown_ValueChanged);
            // 
            // setScaleButton
            // 
            this.setScaleButton.Location = new System.Drawing.Point(411, 17);
            this.setScaleButton.Name = "setScaleButton";
            this.setScaleButton.Size = new System.Drawing.Size(74, 23);
            this.setScaleButton.TabIndex = 17;
            this.setScaleButton.Text = "Set";
            this.setScaleButton.UseVisualStyleBackColor = true;
            this.setScaleButton.Click += new System.EventHandler(this.setScaleButton_Click);
            // 
            // scaleEndY
            // 
            this.scaleEndY.AutoSize = false;
            this.scaleEndY.LargeChange = 8;
            this.scaleEndY.Location = new System.Drawing.Point(53, 98);
            this.scaleEndY.Maximum = 100000;
            this.scaleEndY.Name = "scaleEndY";
            this.scaleEndY.Size = new System.Drawing.Size(288, 20);
            this.scaleEndY.TabIndex = 12;
            this.scaleEndY.ValueChanged += new System.EventHandler(this.scaleStartXUpDown_ValueChanged);
            // 
            // scaleEndX
            // 
            this.scaleEndX.AutoSize = false;
            this.scaleEndX.LargeChange = 8;
            this.scaleEndX.Location = new System.Drawing.Point(53, 72);
            this.scaleEndX.Maximum = 100000;
            this.scaleEndX.Name = "scaleEndX";
            this.scaleEndX.Size = new System.Drawing.Size(288, 20);
            this.scaleEndX.TabIndex = 11;
            this.scaleEndX.ValueChanged += new System.EventHandler(this.scaleStartXUpDown_ValueChanged);
            // 
            // scaleStartY
            // 
            this.scaleStartY.AutoSize = false;
            this.scaleStartY.LargeChange = 8;
            this.scaleStartY.Location = new System.Drawing.Point(53, 45);
            this.scaleStartY.Maximum = 100000;
            this.scaleStartY.Name = "scaleStartY";
            this.scaleStartY.Size = new System.Drawing.Size(288, 20);
            this.scaleStartY.TabIndex = 10;
            this.scaleStartY.ValueChanged += new System.EventHandler(this.scaleStartXUpDown_ValueChanged);
            // 
            // scaleStartX
            // 
            this.scaleStartX.AutoSize = false;
            this.scaleStartX.LargeChange = 8;
            this.scaleStartX.Location = new System.Drawing.Point(53, 19);
            this.scaleStartX.Maximum = 100000;
            this.scaleStartX.Name = "scaleStartX";
            this.scaleStartX.Size = new System.Drawing.Size(288, 20);
            this.scaleStartX.TabIndex = 9;
            this.scaleStartX.ValueChanged += new System.EventHandler(this.scaleStartXUpDown_ValueChanged);
            // 
            // resetScaleButton
            // 
            this.resetScaleButton.Location = new System.Drawing.Point(411, 45);
            this.resetScaleButton.Name = "resetScaleButton";
            this.resetScaleButton.Size = new System.Drawing.Size(74, 23);
            this.resetScaleButton.TabIndex = 8;
            this.resetScaleButton.Text = "Reset";
            this.resetScaleButton.UseVisualStyleBackColor = true;
            this.resetScaleButton.Click += new System.EventHandler(this.resetScaleButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "End Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "End X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Start Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Start X";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.imagePictureBox);
            this.groupBox4.Location = new System.Drawing.Point(4, 295);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(497, 325);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Image Preview";
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.Location = new System.Drawing.Point(4, 19);
            this.imagePictureBox.Margin = new System.Windows.Forms.Padding(1, 3, 1, 1);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(489, 302);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePictureBox.TabIndex = 1;
            this.imagePictureBox.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.imageSelectButton);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(122, 49);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Import Image/Gif";
            // 
            // imageSelectButton
            // 
            this.imageSelectButton.Location = new System.Drawing.Point(6, 19);
            this.imageSelectButton.Name = "imageSelectButton";
            this.imageSelectButton.Size = new System.Drawing.Size(110, 23);
            this.imageSelectButton.TabIndex = 0;
            this.imageSelectButton.Text = "Select Image / Gif";
            this.imageSelectButton.UseVisualStyleBackColor = true;
            this.imageSelectButton.Click += new System.EventHandler(this.stillImageSelectButton_Click);
            // 
            // tab4Audio
            // 
            this.tab4Audio.Controls.Add(this.progressBar8);
            this.tab4Audio.Controls.Add(this.progressBar7);
            this.tab4Audio.Controls.Add(this.progressBar6);
            this.tab4Audio.Controls.Add(this.progressBar5);
            this.tab4Audio.Controls.Add(this.progressBar4);
            this.tab4Audio.Controls.Add(this.progressBar3);
            this.tab4Audio.Controls.Add(this.progressBar2);
            this.tab4Audio.Controls.Add(this.progressBar1);
            this.tab4Audio.Controls.Add(this.button1);
            this.tab4Audio.Location = new System.Drawing.Point(4, 22);
            this.tab4Audio.Name = "tab4Audio";
            this.tab4Audio.Size = new System.Drawing.Size(504, 623);
            this.tab4Audio.TabIndex = 3;
            this.tab4Audio.Text = "Audio";
            this.tab4Audio.UseVisualStyleBackColor = true;
            // 
            // progressBar8
            // 
            this.progressBar8.Location = new System.Drawing.Point(3, 206);
            this.progressBar8.MarqueeAnimationSpeed = 1;
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(238, 23);
            this.progressBar8.TabIndex = 8;
            // 
            // progressBar7
            // 
            this.progressBar7.Location = new System.Drawing.Point(3, 177);
            this.progressBar7.MarqueeAnimationSpeed = 1;
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(238, 23);
            this.progressBar7.TabIndex = 7;
            // 
            // progressBar6
            // 
            this.progressBar6.Location = new System.Drawing.Point(3, 148);
            this.progressBar6.MarqueeAnimationSpeed = 1;
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(238, 23);
            this.progressBar6.TabIndex = 6;
            // 
            // progressBar5
            // 
            this.progressBar5.Location = new System.Drawing.Point(2, 119);
            this.progressBar5.MarqueeAnimationSpeed = 1;
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(238, 23);
            this.progressBar5.TabIndex = 5;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(3, 90);
            this.progressBar4.MarqueeAnimationSpeed = 1;
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(238, 23);
            this.progressBar4.TabIndex = 4;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(3, 61);
            this.progressBar3.MarqueeAnimationSpeed = 1;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(238, 23);
            this.progressBar3.TabIndex = 3;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(3, 32);
            this.progressBar2.MarqueeAnimationSpeed = 1;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(238, 23);
            this.progressBar2.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.MarqueeAnimationSpeed = 1;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(238, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            this.OpenFile.Filter = "Image files (*.jpg,*.jpeg,*.png,*.bmp,*.gif) |*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            // 
            // animTimer
            // 
            this.animTimer.Interval = 33;
            this.animTimer.Tick += new System.EventHandler(this.animTimer_Tick);
            // 
            // screenCapTimer
            // 
            this.screenCapTimer.Interval = 1;
            this.screenCapTimer.Tick += new System.EventHandler(this.screenCapTimer_Tick);
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = true;
            this.statusBar.Location = new System.Drawing.Point(6, 652);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(169, 13);
            this.statusBar.TabIndex = 6;
            this.statusBar.Text = "Connected on: COM 6,  FPS: 30,  ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1284, 761);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.matrixContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "LED Matrix Control";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab1Settings.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixlsYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixlsXUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueWB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenWB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redWB)).EndInit();
            this.tab3Image.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.animationGroup.ResumeLayout(false);
            this.animationGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.scaleSettingGroup.ResumeLayout(false);
            this.scaleSettingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleEndYUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleEndXUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleStartYUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleStartXUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleEndY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleEndX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleStartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleStartX)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.tab4Audio.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectToCOMPort;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1Settings;
        private System.Windows.Forms.TabPage tab2Draw;
        private System.Windows.Forms.TabPage tab3Image;
        public System.Windows.Forms.Panel matrixContainer;
        private System.Windows.Forms.Button buildBoxes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button disconnectFromCOMPort;
        private System.Windows.Forms.ComboBox portsList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown pixlsXUpDown;
        private System.Windows.Forms.NumericUpDown pixlsYUpDown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button imageSelectButton;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.ComboBox InterpolationModeDropDown1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button clearButton1;
        private System.Windows.Forms.GroupBox scaleSettingGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetScaleButton;
        private System.Windows.Forms.TrackBar scaleStartX;
        private System.Windows.Forms.TrackBar scaleEndY;
        private System.Windows.Forms.TrackBar scaleEndX;
        private System.Windows.Forms.TrackBar scaleStartY;
        private System.Windows.Forms.Button setScaleButton;
        private System.Windows.Forms.NumericUpDown scaleStartXUD;
        private System.Windows.Forms.NumericUpDown scaleEndYUD;
        private System.Windows.Forms.NumericUpDown scaleEndXUD;
        private System.Windows.Forms.NumericUpDown scaleStartYUD;
        private System.Windows.Forms.CheckBox lockSizeToggle;
        private System.Windows.Forms.Label croppedAreaWLabel;
        private System.Windows.Forms.Label croppedAreaHLabel;
        private System.Windows.Forms.GroupBox animationGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox animationPlayMode;
        private System.Windows.Forms.Button stopAnimation;
        private System.Windows.Forms.Button startAnimation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer animTimer;
        private System.Windows.Forms.Button refreshCOMPorts;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown blueWB;
        private System.Windows.Forms.NumericUpDown greenWB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown redWB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Timer screenCapTimer;
        private System.Windows.Forms.Button startScreenCap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox screenSelection;
        public System.Windows.Forms.Label statusBar;
        private System.Windows.Forms.CheckBox showMatrixPreview;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TabPage tab4Audio;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ProgressBar progressBar8;
        public System.Windows.Forms.ProgressBar progressBar7;
        public System.Windows.Forms.ProgressBar progressBar6;
        public System.Windows.Forms.ProgressBar progressBar5;
        public System.Windows.Forms.ProgressBar progressBar4;
        public System.Windows.Forms.ProgressBar progressBar3;
        public System.Windows.Forms.ProgressBar progressBar2;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button editPixelOrder;
        private System.Windows.Forms.Button savePixelOrder;
        private System.Windows.Forms.Button resetPixelOrder;
        private System.Windows.Forms.Button stopScreenCap;
    }
}
