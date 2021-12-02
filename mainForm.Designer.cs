
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
            this.chromaticityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chromaticityLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.redXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blueLabel = new System.Windows.Forms.Label();
            this.whitePointLabel = new System.Windows.Forms.Label();
            this.redYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.greenXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.greenYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blueXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.blueYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.whitePointXNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.whitePointYNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gammaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gammaLabel = new System.Windows.Forms.Label();
            this.predefinedTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
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
            this.chromaticityTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitePointXNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitePointYNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNumericUpDown)).BeginInit();
            this.predefinedTableLayoutPanel.SuspendLayout();
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
            this.optionsTableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.optionsTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.optionsTableLayoutPanel.ColumnCount = 2;
            this.optionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.optionsTableLayoutPanel.Controls.Add(this.greyscaleButton, 0, 0);
            this.optionsTableLayoutPanel.Controls.Add(this.labSettingsGroupBox, 0, 4);
            this.optionsTableLayoutPanel.Controls.Add(this.separateChannelsButton, 0, 3);
            this.optionsTableLayoutPanel.Controls.Add(this.loadImageButton, 0, 1);
            this.optionsTableLayoutPanel.Controls.Add(this.modelComboBox, 0, 2);
            this.optionsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.optionsTableLayoutPanel.Name = "optionsTableLayoutPanel";
            this.optionsTableLayoutPanel.RowCount = 5;
            this.optionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.24022F));
            this.optionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.000094F));
            this.optionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.000094F));
            this.optionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.000094F));
            this.optionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.7595F));
            this.optionsTableLayoutPanel.Size = new System.Drawing.Size(271, 553);
            this.optionsTableLayoutPanel.TabIndex = 0;
            // 
            // greyscaleButton
            // 
            this.greyscaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsTableLayoutPanel.SetColumnSpan(this.greyscaleButton, 2);
            this.greyscaleButton.Location = new System.Drawing.Point(5, 5);
            this.greyscaleButton.Name = "greyscaleButton";
            this.greyscaleButton.Size = new System.Drawing.Size(261, 27);
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
            this.labSettingsGroupBox.Controls.Add(this.chromaticityTableLayoutPanel);
            this.labSettingsGroupBox.Controls.Add(this.predefinedTableLayoutPanel);
            this.labSettingsGroupBox.Enabled = false;
            this.labSettingsGroupBox.Location = new System.Drawing.Point(5, 186);
            this.labSettingsGroupBox.Name = "labSettingsGroupBox";
            this.labSettingsGroupBox.Size = new System.Drawing.Size(261, 362);
            this.labSettingsGroupBox.TabIndex = 0;
            this.labSettingsGroupBox.TabStop = false;
            this.labSettingsGroupBox.Text = "Lab Settings";
            // 
            // chromaticityTableLayoutPanel
            // 
            this.chromaticityTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromaticityTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chromaticityTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.chromaticityTableLayoutPanel.ColumnCount = 3;
            this.chromaticityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.chromaticityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.chromaticityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.chromaticityTableLayoutPanel.Controls.Add(this.chromaticityLabel, 0, 0);
            this.chromaticityTableLayoutPanel.Controls.Add(this.xLabel, 1, 0);
            this.chromaticityTableLayoutPanel.Controls.Add(this.yLabel, 2, 0);
            this.chromaticityTableLayoutPanel.Controls.Add(this.redLabel, 0, 1);
            this.chromaticityTableLayoutPanel.Controls.Add(this.greenLabel, 0, 2);
            this.chromaticityTableLayoutPanel.Controls.Add(this.redXNumericUpDown, 1, 1);
            this.chromaticityTableLayoutPanel.Controls.Add(this.blueLabel, 0, 3);
            this.chromaticityTableLayoutPanel.Controls.Add(this.whitePointLabel, 0, 4);
            this.chromaticityTableLayoutPanel.Controls.Add(this.redYNumericUpDown, 2, 1);
            this.chromaticityTableLayoutPanel.Controls.Add(this.greenXNumericUpDown, 1, 2);
            this.chromaticityTableLayoutPanel.Controls.Add(this.greenYNumericUpDown, 2, 2);
            this.chromaticityTableLayoutPanel.Controls.Add(this.blueXNumericUpDown, 1, 3);
            this.chromaticityTableLayoutPanel.Controls.Add(this.blueYNumericUpDown, 2, 3);
            this.chromaticityTableLayoutPanel.Controls.Add(this.whitePointXNumericUpDown, 1, 4);
            this.chromaticityTableLayoutPanel.Controls.Add(this.whitePointYNumericUpDown, 2, 4);
            this.chromaticityTableLayoutPanel.Controls.Add(this.gammaNumericUpDown, 2, 5);
            this.chromaticityTableLayoutPanel.Controls.Add(this.gammaLabel, 1, 5);
            this.chromaticityTableLayoutPanel.Location = new System.Drawing.Point(0, 142);
            this.chromaticityTableLayoutPanel.Name = "chromaticityTableLayoutPanel";
            this.chromaticityTableLayoutPanel.RowCount = 6;
            this.chromaticityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.chromaticityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.chromaticityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.chromaticityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.chromaticityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.chromaticityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.chromaticityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.chromaticityTableLayoutPanel.Size = new System.Drawing.Size(261, 225);
            this.chromaticityTableLayoutPanel.TabIndex = 1;
            // 
            // chromaticityLabel
            // 
            this.chromaticityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromaticityLabel.AutoSize = true;
            this.chromaticityLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chromaticityLabel.Location = new System.Drawing.Point(4, 1);
            this.chromaticityLabel.Name = "chromaticityLabel";
            this.chromaticityLabel.Size = new System.Drawing.Size(79, 36);
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
            this.xLabel.Location = new System.Drawing.Point(90, 1);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(79, 36);
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
            this.yLabel.Location = new System.Drawing.Point(176, 1);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(81, 36);
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
            this.redLabel.Location = new System.Drawing.Point(4, 38);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(79, 36);
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
            this.greenLabel.Location = new System.Drawing.Point(4, 75);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(79, 36);
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
            this.redXNumericUpDown.Location = new System.Drawing.Point(90, 41);
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
            this.redXNumericUpDown.Size = new System.Drawing.Size(79, 27);
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
            this.blueLabel.Location = new System.Drawing.Point(4, 112);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(79, 36);
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
            this.whitePointLabel.Location = new System.Drawing.Point(4, 149);
            this.whitePointLabel.Name = "whitePointLabel";
            this.whitePointLabel.Size = new System.Drawing.Size(79, 36);
            this.whitePointLabel.TabIndex = 8;
            this.whitePointLabel.Text = "White point";
            this.whitePointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // redYNumericUpDown
            // 
            this.redYNumericUpDown.DecimalPlaces = 5;
            this.redYNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.redYNumericUpDown.Location = new System.Drawing.Point(176, 41);
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
            this.redYNumericUpDown.Size = new System.Drawing.Size(79, 27);
            this.redYNumericUpDown.TabIndex = 9;
            this.redYNumericUpDown.ThousandsSeparator = true;
            this.redYNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // greenXNumericUpDown
            // 
            this.greenXNumericUpDown.DecimalPlaces = 5;
            this.greenXNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.greenXNumericUpDown.Location = new System.Drawing.Point(90, 78);
            this.greenXNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.greenXNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.greenXNumericUpDown.Name = "greenXNumericUpDown";
            this.greenXNumericUpDown.Size = new System.Drawing.Size(79, 27);
            this.greenXNumericUpDown.TabIndex = 10;
            this.greenXNumericUpDown.ThousandsSeparator = true;
            this.greenXNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // greenYNumericUpDown
            // 
            this.greenYNumericUpDown.DecimalPlaces = 5;
            this.greenYNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.greenYNumericUpDown.Location = new System.Drawing.Point(176, 78);
            this.greenYNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.greenYNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.greenYNumericUpDown.Name = "greenYNumericUpDown";
            this.greenYNumericUpDown.Size = new System.Drawing.Size(79, 27);
            this.greenYNumericUpDown.TabIndex = 11;
            this.greenYNumericUpDown.ThousandsSeparator = true;
            this.greenYNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // blueXNumericUpDown
            // 
            this.blueXNumericUpDown.DecimalPlaces = 5;
            this.blueXNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.blueXNumericUpDown.Location = new System.Drawing.Point(90, 115);
            this.blueXNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blueXNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.blueXNumericUpDown.Name = "blueXNumericUpDown";
            this.blueXNumericUpDown.Size = new System.Drawing.Size(79, 27);
            this.blueXNumericUpDown.TabIndex = 12;
            this.blueXNumericUpDown.ThousandsSeparator = true;
            this.blueXNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // blueYNumericUpDown
            // 
            this.blueYNumericUpDown.DecimalPlaces = 5;
            this.blueYNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.blueYNumericUpDown.Location = new System.Drawing.Point(176, 115);
            this.blueYNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blueYNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.blueYNumericUpDown.Name = "blueYNumericUpDown";
            this.blueYNumericUpDown.Size = new System.Drawing.Size(79, 27);
            this.blueYNumericUpDown.TabIndex = 13;
            this.blueYNumericUpDown.ThousandsSeparator = true;
            this.blueYNumericUpDown.Value = new decimal(new int[] {
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
            this.whitePointXNumericUpDown.Location = new System.Drawing.Point(90, 152);
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
            this.whitePointXNumericUpDown.Size = new System.Drawing.Size(79, 27);
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
            this.whitePointYNumericUpDown.Location = new System.Drawing.Point(176, 152);
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
            this.whitePointYNumericUpDown.Size = new System.Drawing.Size(79, 27);
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
            this.gammaNumericUpDown.Location = new System.Drawing.Point(176, 189);
            this.gammaNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.gammaNumericUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            131072});
            this.gammaNumericUpDown.Name = "gammaNumericUpDown";
            this.gammaNumericUpDown.Size = new System.Drawing.Size(79, 27);
            this.gammaNumericUpDown.TabIndex = 16;
            this.gammaNumericUpDown.ThousandsSeparator = true;
            this.gammaNumericUpDown.Value = new decimal(new int[] {
            22,
            0,
            0,
            65536});
            // 
            // gammaLabel
            // 
            this.gammaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gammaLabel.AutoSize = true;
            this.gammaLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gammaLabel.Location = new System.Drawing.Point(90, 186);
            this.gammaLabel.Name = "gammaLabel";
            this.gammaLabel.Size = new System.Drawing.Size(79, 38);
            this.gammaLabel.TabIndex = 6;
            this.gammaLabel.Text = "Gamma";
            this.gammaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // predefinedTableLayoutPanel
            // 
            this.predefinedTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.predefinedTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.predefinedTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.predefinedTableLayoutPanel.ColumnCount = 2;
            this.predefinedTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.predefinedTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.predefinedTableLayoutPanel.Controls.Add(this.IlluminantcomboBox, 1, 1);
            this.predefinedTableLayoutPanel.Controls.Add(this.illuminantLabel, 0, 1);
            this.predefinedTableLayoutPanel.Controls.Add(this.colorProfileLabel, 0, 0);
            this.predefinedTableLayoutPanel.Controls.Add(this.colorProfileComboBox, 1, 0);
            this.predefinedTableLayoutPanel.Location = new System.Drawing.Point(0, 26);
            this.predefinedTableLayoutPanel.Name = "predefinedTableLayoutPanel";
            this.predefinedTableLayoutPanel.RowCount = 2;
            this.predefinedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.64865F));
            this.predefinedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.35135F));
            this.predefinedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.predefinedTableLayoutPanel.Size = new System.Drawing.Size(258, 103);
            this.predefinedTableLayoutPanel.TabIndex = 0;
            // 
            // IlluminantcomboBox
            // 
            this.IlluminantcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IlluminantcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IlluminantcomboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D50",
            "D65",
            "E"});
            this.IlluminantcomboBox.Location = new System.Drawing.Point(132, 62);
            this.IlluminantcomboBox.Name = "IlluminantcomboBox";
            this.IlluminantcomboBox.Size = new System.Drawing.Size(122, 28);
            this.IlluminantcomboBox.TabIndex = 10;
            this.IlluminantcomboBox.SelectedIndexChanged += new System.EventHandler(this.IlluminantcomboBox_SelectedIndexChanged);
            // 
            // illuminantLabel
            // 
            this.illuminantLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.illuminantLabel.AutoSize = true;
            this.illuminantLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.illuminantLabel.Location = new System.Drawing.Point(4, 50);
            this.illuminantLabel.Name = "illuminantLabel";
            this.illuminantLabel.Size = new System.Drawing.Size(121, 52);
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
            this.colorProfileLabel.Location = new System.Drawing.Point(4, 1);
            this.colorProfileLabel.Name = "colorProfileLabel";
            this.colorProfileLabel.Size = new System.Drawing.Size(121, 48);
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
            "WideGamut",
            "CIERGB"});
            this.colorProfileComboBox.Location = new System.Drawing.Point(132, 11);
            this.colorProfileComboBox.Name = "colorProfileComboBox";
            this.colorProfileComboBox.Size = new System.Drawing.Size(122, 28);
            this.colorProfileComboBox.TabIndex = 9;
            this.colorProfileComboBox.SelectedIndexChanged += new System.EventHandler(this.colorProfileComboBox_SelectedIndexChanged);
            // 
            // separateChannelsButton
            // 
            this.separateChannelsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsTableLayoutPanel.SetColumnSpan(this.separateChannelsButton, 2);
            this.separateChannelsButton.Location = new System.Drawing.Point(5, 152);
            this.separateChannelsButton.Name = "separateChannelsButton";
            this.separateChannelsButton.Size = new System.Drawing.Size(261, 26);
            this.separateChannelsButton.TabIndex = 2;
            this.separateChannelsButton.Text = "Separate Channels";
            this.separateChannelsButton.UseVisualStyleBackColor = true;
            this.separateChannelsButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.separateChannelsButton_MouseDown);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsTableLayoutPanel.SetColumnSpan(this.loadImageButton, 2);
            this.loadImageButton.Location = new System.Drawing.Point(5, 84);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(261, 26);
            this.loadImageButton.TabIndex = 4;
            this.loadImageButton.Text = "Load Image";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loadImageButton_MouseDown);
            // 
            // modelComboBox
            // 
            this.modelComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsTableLayoutPanel.SetColumnSpan(this.modelComboBox, 2);
            this.modelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelComboBox.Items.AddRange(new object[] {
            "YCbCr",
            "HSV",
            "Lab"});
            this.modelComboBox.Location = new System.Drawing.Point(5, 118);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(261, 28);
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
            this.chromaticityTableLayoutPanel.ResumeLayout(false);
            this.chromaticityTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitePointXNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whitePointYNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gammaNumericUpDown)).EndInit();
            this.predefinedTableLayoutPanel.ResumeLayout(false);
            this.predefinedTableLayoutPanel.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel chromaticityTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel predefinedTableLayoutPanel;
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
        private System.Windows.Forms.NumericUpDown greenXNumericUpDown;
        private System.Windows.Forms.NumericUpDown greenYNumericUpDown;
        private System.Windows.Forms.NumericUpDown blueXNumericUpDown;
        private System.Windows.Forms.NumericUpDown blueYNumericUpDown;
        private System.Windows.Forms.NumericUpDown whitePointXNumericUpDown;
        private System.Windows.Forms.NumericUpDown whitePointYNumericUpDown;
        private System.Windows.Forms.NumericUpDown gammaNumericUpDown;
    }
}

