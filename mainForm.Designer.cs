
namespace ColorSeparator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.optionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.greyscaleButton = new System.Windows.Forms.Button();
            this.labSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chromaticityLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.redXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blueLabel = new System.Windows.Forms.Label();
            this.whitePointLabel = new System.Windows.Forms.Label();
            this.gammaLabel = new System.Windows.Forms.Label();
            this.redYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.greenXumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.greenYumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blueXumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blueYumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.whitePointXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.whitePointYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gammaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.IlluminantcomboBox = new System.Windows.Forms.ComboBox();
            this.illuminantLabel = new System.Windows.Forms.Label();
            this.colorProfileLabel = new System.Windows.Forms.Label();
            this.colorProfileComboBox = new System.Windows.Forms.ComboBox();
            this.separateChannelsButton = new System.Windows.Forms.Button();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.mainTableLayoutPanel.SuspendLayout();
            this.optionsTableLayoutPanel.SuspendLayout();
            this.labSettingsGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenXumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenYumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueXumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueYumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitePointXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitePointYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNumericUpDown)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.20774F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.79226F));
            this.mainTableLayoutPanel.Controls.Add(this.optionsTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.mainPictureBox, 1, 0);
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(982, 559);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // optionsTableLayoutPanel
            // 
            this.optionsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsTableLayoutPanel.ColumnCount = 2;
            this.optionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optionsTableLayoutPanel.Controls.Add(this.greyscaleButton, 0, 0);
            this.optionsTableLayoutPanel.Controls.Add(this.labSettingsGroupBox, 0, 5);
            this.optionsTableLayoutPanel.Controls.Add(this.separateChannelsButton, 0, 4);
            this.optionsTableLayoutPanel.Controls.Add(this.loadImageButton, 0, 2);
            this.optionsTableLayoutPanel.Controls.Add(this.modelComboBox, 0, 3);
            this.optionsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.optionsTableLayoutPanel.Name = "optionsTableLayoutPanel";
            this.optionsTableLayoutPanel.RowCount = 6;
            this.optionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.048119F));
            this.optionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.97264F));
            this.optionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.048119F));
            this.optionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.048119F));
            this.optionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.048119F));
            this.optionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.83488F));
            this.optionsTableLayoutPanel.Size = new System.Drawing.Size(271, 553);
            this.optionsTableLayoutPanel.TabIndex = 0;
            // 
            // greyscaleButton
            // 
            this.greyscaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsTableLayoutPanel.SetColumnSpan(this.greyscaleButton, 2);
            this.greyscaleButton.Location = new System.Drawing.Point(3, 3);
            this.greyscaleButton.Name = "greyscaleButton";
            this.greyscaleButton.Size = new System.Drawing.Size(265, 27);
            this.greyscaleButton.TabIndex = 3;
            this.greyscaleButton.Text = "To Greyscale";
            this.greyscaleButton.UseVisualStyleBackColor = true;
            this.greyscaleButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.greyscaleButton_MouseDown);
            // 
            // labSettingsGroupBox
            // 
            this.labSettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsTableLayoutPanel.SetColumnSpan(this.labSettingsGroupBox, 2);
            this.labSettingsGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.labSettingsGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.labSettingsGroupBox.Location = new System.Drawing.Point(3, 273);
            this.labSettingsGroupBox.Name = "labSettingsGroupBox";
            this.labSettingsGroupBox.Size = new System.Drawing.Size(265, 277);
            this.labSettingsGroupBox.TabIndex = 0;
            this.labSettingsGroupBox.TabStop = false;
            this.labSettingsGroupBox.Text = "Lab Settings";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.chromaticityLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.xLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.yLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.redLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.greenLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.redXNumericUpDown, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.blueLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.whitePointLabel, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.gammaLabel, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.redYNumericUpDown, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.greenXumericUpDown, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.greenYumericUpDown, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.blueXumericUpDown, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.blueYumericUpDown, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.whitePointXNumericUpDown, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.whitePointYNumericUpDown, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.gammaNumericUpDown, 2, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 139);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(265, 141);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // chromaticityLabel
            // 
            this.chromaticityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromaticityLabel.AutoSize = true;
            this.chromaticityLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chromaticityLabel.Location = new System.Drawing.Point(3, 0);
            this.chromaticityLabel.Name = "chromaticityLabel";
            this.chromaticityLabel.Size = new System.Drawing.Size(82, 23);
            this.chromaticityLabel.TabIndex = 1;
            this.chromaticityLabel.Text = "Chromaticity";
            this.chromaticityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // xLabel
            // 
            this.xLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.xLabel.Location = new System.Drawing.Point(91, 0);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(82, 23);
            this.xLabel.TabIndex = 2;
            this.xLabel.Text = "x";
            this.xLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yLabel
            // 
            this.yLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yLabel.AutoSize = true;
            this.yLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yLabel.Location = new System.Drawing.Point(179, 0);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(83, 23);
            this.yLabel.TabIndex = 3;
            this.yLabel.Text = "y";
            this.yLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // redLabel
            // 
            this.redLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redLabel.AutoSize = true;
            this.redLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.redLabel.Location = new System.Drawing.Point(3, 23);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(82, 23);
            this.redLabel.TabIndex = 4;
            this.redLabel.Text = "Red primary";
            this.redLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // greenLabel
            // 
            this.greenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.greenLabel.AutoSize = true;
            this.greenLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.greenLabel.Location = new System.Drawing.Point(3, 46);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(82, 23);
            this.greenLabel.TabIndex = 5;
            this.greenLabel.Text = "Green primary";
            this.greenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // redXNumericUpDown
            // 
            this.redXNumericUpDown.DecimalPlaces = 5;
            this.redXNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.redXNumericUpDown.Location = new System.Drawing.Point(91, 26);
            this.redXNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.redXNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.redXNumericUpDown.Name = "redXNumericUpDown";
            this.redXNumericUpDown.Size = new System.Drawing.Size(82, 27);
            this.redXNumericUpDown.TabIndex = 6;
            this.redXNumericUpDown.ThousandsSeparator = true;
            this.redXNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // blueLabel
            // 
            this.blueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blueLabel.AutoSize = true;
            this.blueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.blueLabel.Location = new System.Drawing.Point(3, 69);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(82, 23);
            this.blueLabel.TabIndex = 7;
            this.blueLabel.Text = "Blue primary";
            this.blueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // whitePointLabel
            // 
            this.whitePointLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.whitePointLabel.AutoSize = true;
            this.whitePointLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whitePointLabel.Location = new System.Drawing.Point(3, 92);
            this.whitePointLabel.Name = "whitePointLabel";
            this.whitePointLabel.Size = new System.Drawing.Size(82, 23);
            this.whitePointLabel.TabIndex = 8;
            this.whitePointLabel.Text = "White point";
            this.whitePointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gammaLabel
            // 
            this.gammaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gammaLabel.AutoSize = true;
            this.gammaLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gammaLabel.Location = new System.Drawing.Point(91, 115);
            this.gammaLabel.Name = "gammaLabel";
            this.gammaLabel.Size = new System.Drawing.Size(82, 26);
            this.gammaLabel.TabIndex = 6;
            this.gammaLabel.Text = "Gamma";
            this.gammaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // redYNumericUpDown
            // 
            this.redYNumericUpDown.DecimalPlaces = 5;
            this.redYNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.redYNumericUpDown.Location = new System.Drawing.Point(179, 26);
            this.redYNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.redYNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.redYNumericUpDown.Name = "redYNumericUpDown";
            this.redYNumericUpDown.Size = new System.Drawing.Size(82, 27);
            this.redYNumericUpDown.TabIndex = 9;
            this.redYNumericUpDown.ThousandsSeparator = true;
            this.redYNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // greenXumericUpDown
            // 
            this.greenXumericUpDown.DecimalPlaces = 5;
            this.greenXumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.greenXumericUpDown.Location = new System.Drawing.Point(91, 49);
            this.greenXumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.greenXumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.greenXumericUpDown.Name = "greenXumericUpDown";
            this.greenXumericUpDown.Size = new System.Drawing.Size(82, 27);
            this.greenXumericUpDown.TabIndex = 10;
            this.greenXumericUpDown.ThousandsSeparator = true;
            this.greenXumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // greenYumericUpDown
            // 
            this.greenYumericUpDown.DecimalPlaces = 5;
            this.greenYumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.greenYumericUpDown.Location = new System.Drawing.Point(179, 49);
            this.greenYumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.greenYumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.greenYumericUpDown.Name = "greenYumericUpDown";
            this.greenYumericUpDown.Size = new System.Drawing.Size(82, 27);
            this.greenYumericUpDown.TabIndex = 11;
            this.greenYumericUpDown.ThousandsSeparator = true;
            this.greenYumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // blueXumericUpDown
            // 
            this.blueXumericUpDown.DecimalPlaces = 5;
            this.blueXumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.blueXumericUpDown.Location = new System.Drawing.Point(91, 72);
            this.blueXumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blueXumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.blueXumericUpDown.Name = "blueXumericUpDown";
            this.blueXumericUpDown.Size = new System.Drawing.Size(82, 27);
            this.blueXumericUpDown.TabIndex = 12;
            this.blueXumericUpDown.ThousandsSeparator = true;
            this.blueXumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // blueYumericUpDown
            // 
            this.blueYumericUpDown.DecimalPlaces = 5;
            this.blueYumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.blueYumericUpDown.Location = new System.Drawing.Point(179, 72);
            this.blueYumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blueYumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.blueYumericUpDown.Name = "blueYumericUpDown";
            this.blueYumericUpDown.Size = new System.Drawing.Size(82, 27);
            this.blueYumericUpDown.TabIndex = 13;
            this.blueYumericUpDown.ThousandsSeparator = true;
            this.blueYumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // whitePointXNumericUpDown
            // 
            this.whitePointXNumericUpDown.DecimalPlaces = 5;
            this.whitePointXNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.whitePointXNumericUpDown.Location = new System.Drawing.Point(91, 95);
            this.whitePointXNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.whitePointXNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.whitePointXNumericUpDown.Name = "whitePointXNumericUpDown";
            this.whitePointXNumericUpDown.Size = new System.Drawing.Size(82, 27);
            this.whitePointXNumericUpDown.TabIndex = 14;
            this.whitePointXNumericUpDown.ThousandsSeparator = true;
            this.whitePointXNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // whitePointYNumericUpDown
            // 
            this.whitePointYNumericUpDown.DecimalPlaces = 5;
            this.whitePointYNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.whitePointYNumericUpDown.Location = new System.Drawing.Point(179, 95);
            this.whitePointYNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.whitePointYNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.whitePointYNumericUpDown.Name = "whitePointYNumericUpDown";
            this.whitePointYNumericUpDown.Size = new System.Drawing.Size(82, 27);
            this.whitePointYNumericUpDown.TabIndex = 15;
            this.whitePointYNumericUpDown.ThousandsSeparator = true;
            this.whitePointYNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // gammaNumericUpDown
            // 
            this.gammaNumericUpDown.DecimalPlaces = 2;
            this.gammaNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.gammaNumericUpDown.Location = new System.Drawing.Point(179, 118);
            this.gammaNumericUpDown.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.gammaNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.gammaNumericUpDown.Name = "gammaNumericUpDown";
            this.gammaNumericUpDown.Size = new System.Drawing.Size(82, 27);
            this.gammaNumericUpDown.TabIndex = 16;
            this.gammaNumericUpDown.ThousandsSeparator = true;
            this.gammaNumericUpDown.Value = new decimal(new int[] {
            22,
            0,
            0,
            65536});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.IlluminantcomboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.illuminantLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.colorProfileLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.colorProfileComboBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(265, 118);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // IlluminantcomboBox
            // 
            this.IlluminantcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IlluminantcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IlluminantcomboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "D50",
            "D65",
            "E"});
            this.IlluminantcomboBox.Location = new System.Drawing.Point(135, 74);
            this.IlluminantcomboBox.Name = "IlluminantcomboBox";
            this.IlluminantcomboBox.Size = new System.Drawing.Size(127, 28);
            this.IlluminantcomboBox.TabIndex = 10;
            // 
            // illuminantLabel
            // 
            this.illuminantLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.illuminantLabel.AutoSize = true;
            this.illuminantLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.illuminantLabel.Location = new System.Drawing.Point(3, 59);
            this.illuminantLabel.Name = "illuminantLabel";
            this.illuminantLabel.Size = new System.Drawing.Size(126, 59);
            this.illuminantLabel.TabIndex = 1;
            this.illuminantLabel.Text = "Predefined illuminant";
            this.illuminantLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colorProfileLabel
            // 
            this.colorProfileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorProfileLabel.AutoSize = true;
            this.colorProfileLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorProfileLabel.Location = new System.Drawing.Point(3, 0);
            this.colorProfileLabel.Name = "colorProfileLabel";
            this.colorProfileLabel.Size = new System.Drawing.Size(126, 59);
            this.colorProfileLabel.TabIndex = 0;
            this.colorProfileLabel.Text = "Predefined color profile";
            this.colorProfileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colorProfileComboBox
            // 
            this.colorProfileComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.colorProfileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorProfileComboBox.Items.AddRange(new object[] {
            "sRGB",
            "AdobeRGB",
            "AppleRGB",
            "CIERGB",
            "WideGamut"});
            this.colorProfileComboBox.Location = new System.Drawing.Point(135, 15);
            this.colorProfileComboBox.Name = "colorProfileComboBox";
            this.colorProfileComboBox.Size = new System.Drawing.Size(127, 28);
            this.colorProfileComboBox.TabIndex = 9;
            // 
            // separateChannelsButton
            // 
            this.separateChannelsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsTableLayoutPanel.SetColumnSpan(this.separateChannelsButton, 2);
            this.separateChannelsButton.Location = new System.Drawing.Point(3, 240);
            this.separateChannelsButton.Name = "separateChannelsButton";
            this.separateChannelsButton.Size = new System.Drawing.Size(265, 27);
            this.separateChannelsButton.TabIndex = 2;
            this.separateChannelsButton.Text = "Separate Channels";
            this.separateChannelsButton.UseVisualStyleBackColor = true;
            this.separateChannelsButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.separateChannelsButton_MouseDown);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsTableLayoutPanel.SetColumnSpan(this.loadImageButton, 2);
            this.loadImageButton.Location = new System.Drawing.Point(3, 174);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(265, 27);
            this.loadImageButton.TabIndex = 4;
            this.loadImageButton.Text = "Load Image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loadImageButton_MouseDown);
            // 
            // modelComboBox
            // 
            this.modelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsTableLayoutPanel.SetColumnSpan(this.modelComboBox, 2);
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.Items.AddRange(new object[] {
            "YCbCr",
            "HSV",
            "Custom"});
            this.modelComboBox.Location = new System.Drawing.Point(3, 207);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(265, 28);
            this.modelComboBox.TabIndex = 5;
            this.modelComboBox.SelectedIndexChanged += new System.EventHandler(this.modelComboBox_SelectedIndexChanged);
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPictureBox.Location = new System.Drawing.Point(280, 3);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(699, 553);
            this.mainPictureBox.TabIndex = 0;
            this.mainPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.optionsTableLayoutPanel.ResumeLayout(false);
            this.labSettingsGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenXumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenYumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueXumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueYumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitePointXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitePointYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNumericUpDown)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.PictureBox mainPictureBox;
        private System.Windows.Forms.TableLayoutPanel optionsTableLayoutPanel;
        private System.Windows.Forms.Button greyscaleButton;
        private System.Windows.Forms.GroupBox labSettingsGroupBox;
        private System.Windows.Forms.Button separateChannelsButton;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label colorProfileLabel;
        private System.Windows.Forms.Label chromaticityLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label whitePointLabel;
        private System.Windows.Forms.Label gammaLabel;
        private System.Windows.Forms.Label illuminantLabel;
        private System.Windows.Forms.ComboBox IlluminantcomboBox;
        private System.Windows.Forms.ComboBox colorProfileComboBox;
        private System.Windows.Forms.NumericUpDown redXNumericUpDown;
        private System.Windows.Forms.NumericUpDown redYNumericUpDown;
        private System.Windows.Forms.NumericUpDown greenXumericUpDown;
        private System.Windows.Forms.NumericUpDown greenYumericUpDown;
        private System.Windows.Forms.NumericUpDown blueXumericUpDown;
        private System.Windows.Forms.NumericUpDown blueYumericUpDown;
        private System.Windows.Forms.NumericUpDown whitePointXNumericUpDown;
        private System.Windows.Forms.NumericUpDown whitePointYNumericUpDown;
        private System.Windows.Forms.NumericUpDown gammaNumericUpDown;
    }
}

