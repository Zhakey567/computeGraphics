namespace Render
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cubeButton = new System.Windows.Forms.Button();
            this.cuboidButton = new System.Windows.Forms.Button();
            this.frustumButton = new System.Windows.Forms.Button();
            this.coneButton = new System.Windows.Forms.Button();
            this.pyramid8Button = new System.Windows.Forms.Button();
            this.pyramid4Button = new System.Windows.Forms.Button();
            this.octahedronButton = new System.Windows.Forms.Button();
            this.cylinderButton = new System.Windows.Forms.Button();
            this.sphereButton = new System.Windows.Forms.Button();
            this.torusButton = new System.Windows.Forms.Button();
            this.helixButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.xLabel = new System.Windows.Forms.Label();
            this.yLabel = new System.Windows.Forms.Label();
            this.zLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.xRotationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yRotationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.zRotationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.xLocationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yLocationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.zLocationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.xScaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yScaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.zScaleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.resetLocationButton = new System.Windows.Forms.Button();
            this.resetRotationButton = new System.Windows.Forms.Button();
            this.resetScaleButton = new System.Windows.Forms.Button();
            this.previewGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xRotationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yRotationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zRotationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xLocationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yLocationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zLocationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xScaleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yScaleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zScaleNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.applyButton);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(362, 561);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 370);
            this.panel1.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cubeButton);
            this.flowLayoutPanel1.Controls.Add(this.cuboidButton);
            this.flowLayoutPanel1.Controls.Add(this.frustumButton);
            this.flowLayoutPanel1.Controls.Add(this.coneButton);
            this.flowLayoutPanel1.Controls.Add(this.pyramid8Button);
            this.flowLayoutPanel1.Controls.Add(this.pyramid4Button);
            this.flowLayoutPanel1.Controls.Add(this.octahedronButton);
            this.flowLayoutPanel1.Controls.Add(this.cylinderButton);
            this.flowLayoutPanel1.Controls.Add(this.sphereButton);
            this.flowLayoutPanel1.Controls.Add(this.torusButton);
            this.flowLayoutPanel1.Controls.Add(this.helixButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(358, 370);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // cubeButton
            // 
            this.cubeButton.Location = new System.Drawing.Point(3, 3);
            this.cubeButton.Name = "cubeButton";
            this.cubeButton.Size = new System.Drawing.Size(75, 23);
            this.cubeButton.TabIndex = 0;
            this.cubeButton.Text = "Cube";
            this.cubeButton.UseVisualStyleBackColor = true;
            this.cubeButton.Click += new System.EventHandler(this.cubeButton_Click);
            // 
            // cuboidButton
            // 
            this.cuboidButton.Location = new System.Drawing.Point(84, 3);
            this.cuboidButton.Name = "cuboidButton";
            this.cuboidButton.Size = new System.Drawing.Size(75, 23);
            this.cuboidButton.TabIndex = 1;
            this.cuboidButton.Text = "Cuboid";
            this.cuboidButton.UseVisualStyleBackColor = true;
            this.cuboidButton.Click += new System.EventHandler(this.cuboidButton_Click);
            // 
            // frustumButton
            // 
            this.frustumButton.AutoSize = true;
            this.frustumButton.Location = new System.Drawing.Point(165, 3);
            this.frustumButton.Name = "frustumButton";
            this.frustumButton.Size = new System.Drawing.Size(75, 23);
            this.frustumButton.TabIndex = 5;
            this.frustumButton.Text = "Frustum";
            this.frustumButton.UseVisualStyleBackColor = true;
            this.frustumButton.Click += new System.EventHandler(this.frustumButton_Click);
            // 
            // coneButton
            // 
            this.coneButton.Location = new System.Drawing.Point(246, 3);
            this.coneButton.Name = "coneButton";
            this.coneButton.Size = new System.Drawing.Size(75, 23);
            this.coneButton.TabIndex = 2;
            this.coneButton.Text = "Cone";
            this.coneButton.UseVisualStyleBackColor = true;
            this.coneButton.Click += new System.EventHandler(this.coneButton_Click);
            // 
            // pyramid8Button
            // 
            this.pyramid8Button.AutoSize = true;
            this.pyramid8Button.Location = new System.Drawing.Point(3, 32);
            this.pyramid8Button.Name = "pyramid8Button";
            this.pyramid8Button.Size = new System.Drawing.Size(83, 23);
            this.pyramid8Button.TabIndex = 4;
            this.pyramid8Button.Text = "8-gon pyramid";
            this.pyramid8Button.UseVisualStyleBackColor = true;
            this.pyramid8Button.Click += new System.EventHandler(this.pyramid8Button_Click);
            // 
            // pyramid4Button
            // 
            this.pyramid4Button.AutoSize = true;
            this.pyramid4Button.Location = new System.Drawing.Point(92, 32);
            this.pyramid4Button.Name = "pyramid4Button";
            this.pyramid4Button.Size = new System.Drawing.Size(92, 23);
            this.pyramid4Button.TabIndex = 3;
            this.pyramid4Button.Text = "4-gon pyramid";
            this.pyramid4Button.UseVisualStyleBackColor = true;
            this.pyramid4Button.Click += new System.EventHandler(this.pyramid4Button_Click);
            // 
            // octahedronButton
            // 
            this.octahedronButton.AutoSize = true;
            this.octahedronButton.Location = new System.Drawing.Point(190, 32);
            this.octahedronButton.Name = "octahedronButton";
            this.octahedronButton.Size = new System.Drawing.Size(75, 23);
            this.octahedronButton.TabIndex = 6;
            this.octahedronButton.Text = "Octahedron";
            this.octahedronButton.UseVisualStyleBackColor = true;
            this.octahedronButton.Click += new System.EventHandler(this.octahedronButton_Click);
            // 
            // cylinderButton
            // 
            this.cylinderButton.AutoSize = true;
            this.cylinderButton.Location = new System.Drawing.Point(271, 32);
            this.cylinderButton.Name = "cylinderButton";
            this.cylinderButton.Size = new System.Drawing.Size(75, 23);
            this.cylinderButton.TabIndex = 7;
            this.cylinderButton.Text = "Cylinder";
            this.cylinderButton.UseVisualStyleBackColor = true;
            this.cylinderButton.Click += new System.EventHandler(this.cylinderButton_Click);
            // 
            // sphereButton
            // 
            this.sphereButton.AutoSize = true;
            this.sphereButton.Location = new System.Drawing.Point(3, 61);
            this.sphereButton.Name = "sphereButton";
            this.sphereButton.Size = new System.Drawing.Size(75, 23);
            this.sphereButton.TabIndex = 8;
            this.sphereButton.Text = "Sphere";
            this.sphereButton.UseVisualStyleBackColor = true;
            this.sphereButton.Click += new System.EventHandler(this.sphereButton_Click);
            // 
            // torusButton
            // 
            this.torusButton.AutoSize = true;
            this.torusButton.Location = new System.Drawing.Point(84, 61);
            this.torusButton.Name = "torusButton";
            this.torusButton.Size = new System.Drawing.Size(75, 23);
            this.torusButton.TabIndex = 9;
            this.torusButton.Text = "Torus";
            this.torusButton.UseVisualStyleBackColor = true;
            this.torusButton.Click += new System.EventHandler(this.torusButton_Click);
            // 
            // helixButton
            // 
            this.helixButton.AutoSize = true;
            this.helixButton.Location = new System.Drawing.Point(165, 61);
            this.helixButton.Name = "helixButton";
            this.helixButton.Size = new System.Drawing.Size(75, 23);
            this.helixButton.TabIndex = 10;
            this.helixButton.Text = "Helix";
            this.helixButton.UseVisualStyleBackColor = true;
            this.helixButton.Click += new System.EventHandler(this.helixButton_Click);
            // 
            // applyButton
            // 
            this.applyButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.applyButton.Location = new System.Drawing.Point(2, 534);
            this.applyButton.Margin = new System.Windows.Forms.Padding(2);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(358, 25);
            this.applyButton.TabIndex = 6;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(2, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(358, 149);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transform";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.Controls.Add(this.xLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.yLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.zLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.xRotationNumericUpDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.yRotationNumericUpDown, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.zRotationNumericUpDown, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.xLocationNumericUpDown, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.yLocationNumericUpDown, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.zLocationNumericUpDown, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.xScaleNumericUpDown, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.yScaleNumericUpDown, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.zScaleNumericUpDown, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.resetLocationButton, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.resetRotationButton, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.resetScaleButton, 4, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 132);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // xLabel
            // 
            this.xLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xLabel.Location = new System.Drawing.Point(66, 0);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(71, 13);
            this.xLabel.TabIndex = 3;
            this.xLabel.Text = "X";
            this.xLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yLabel
            // 
            this.yLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yLabel.Location = new System.Drawing.Point(143, 0);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(71, 13);
            this.yLabel.TabIndex = 4;
            this.yLabel.Text = "Y";
            this.yLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zLabel
            // 
            this.zLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zLabel.Location = new System.Drawing.Point(220, 0);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(71, 13);
            this.zLabel.TabIndex = 5;
            this.zLabel.Text = "Z";
            this.zLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Location";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Rotation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 41);
            this.label4.TabIndex = 8;
            this.label4.Text = "Scale, %";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // xRotationNumericUpDown
            // 
            this.xRotationNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xRotationNumericUpDown.Location = new System.Drawing.Point(66, 61);
            this.xRotationNumericUpDown.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            this.xRotationNumericUpDown.Minimum = new decimal(new int[] { 360, 0, 0, -2147483648 });
            this.xRotationNumericUpDown.Name = "xRotationNumericUpDown";
            this.xRotationNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.xRotationNumericUpDown.TabIndex = 0;
            // 
            // yRotationNumericUpDown
            // 
            this.yRotationNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yRotationNumericUpDown.Location = new System.Drawing.Point(143, 61);
            this.yRotationNumericUpDown.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            this.yRotationNumericUpDown.Minimum = new decimal(new int[] { 360, 0, 0, -2147483648 });
            this.yRotationNumericUpDown.Name = "yRotationNumericUpDown";
            this.yRotationNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.yRotationNumericUpDown.TabIndex = 1;
            // 
            // zRotationNumericUpDown
            // 
            this.zRotationNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zRotationNumericUpDown.Location = new System.Drawing.Point(220, 61);
            this.zRotationNumericUpDown.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            this.zRotationNumericUpDown.Minimum = new decimal(new int[] { 360, 0, 0, -2147483648 });
            this.zRotationNumericUpDown.Name = "zRotationNumericUpDown";
            this.zRotationNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.zRotationNumericUpDown.TabIndex = 2;
            // 
            // xLocationNumericUpDown
            // 
            this.xLocationNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xLocationNumericUpDown.Location = new System.Drawing.Point(66, 22);
            this.xLocationNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, -2147483648 });
            this.xLocationNumericUpDown.Name = "xLocationNumericUpDown";
            this.xLocationNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.xLocationNumericUpDown.TabIndex = 9;
            // 
            // yLocationNumericUpDown
            // 
            this.yLocationNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yLocationNumericUpDown.Location = new System.Drawing.Point(143, 22);
            this.yLocationNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, -2147483648 });
            this.yLocationNumericUpDown.Name = "yLocationNumericUpDown";
            this.yLocationNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.yLocationNumericUpDown.TabIndex = 10;
            // 
            // zLocationNumericUpDown
            // 
            this.zLocationNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zLocationNumericUpDown.Location = new System.Drawing.Point(220, 22);
            this.zLocationNumericUpDown.Minimum = new decimal(new int[] { 100, 0, 0, -2147483648 });
            this.zLocationNumericUpDown.Name = "zLocationNumericUpDown";
            this.zLocationNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.zLocationNumericUpDown.TabIndex = 11;
            // 
            // xScaleNumericUpDown
            // 
            this.xScaleNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xScaleNumericUpDown.Location = new System.Drawing.Point(66, 101);
            this.xScaleNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.xScaleNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.xScaleNumericUpDown.Name = "xScaleNumericUpDown";
            this.xScaleNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.xScaleNumericUpDown.TabIndex = 12;
            this.xScaleNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // yScaleNumericUpDown
            // 
            this.yScaleNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yScaleNumericUpDown.Location = new System.Drawing.Point(143, 101);
            this.yScaleNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.yScaleNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.yScaleNumericUpDown.Name = "yScaleNumericUpDown";
            this.yScaleNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.yScaleNumericUpDown.TabIndex = 13;
            this.yScaleNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // zScaleNumericUpDown
            // 
            this.zScaleNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zScaleNumericUpDown.Location = new System.Drawing.Point(220, 101);
            this.zScaleNumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.zScaleNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.zScaleNumericUpDown.Name = "zScaleNumericUpDown";
            this.zScaleNumericUpDown.Size = new System.Drawing.Size(71, 20);
            this.zScaleNumericUpDown.TabIndex = 14;
            this.zScaleNumericUpDown.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // resetLocationButton
            // 
            this.resetLocationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetLocationButton.Location = new System.Drawing.Point(297, 16);
            this.resetLocationButton.Name = "resetLocationButton";
            this.resetLocationButton.Size = new System.Drawing.Size(54, 33);
            this.resetLocationButton.TabIndex = 16;
            this.resetLocationButton.Text = "Reset";
            this.resetLocationButton.UseVisualStyleBackColor = true;
            this.resetLocationButton.Click += new System.EventHandler(this.resetLocationButton_Click);
            // 
            // resetRotationButton
            // 
            this.resetRotationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetRotationButton.Location = new System.Drawing.Point(297, 55);
            this.resetRotationButton.Name = "resetRotationButton";
            this.resetRotationButton.Size = new System.Drawing.Size(54, 33);
            this.resetRotationButton.TabIndex = 17;
            this.resetRotationButton.Text = "Reset";
            this.resetRotationButton.UseVisualStyleBackColor = true;
            this.resetRotationButton.Click += new System.EventHandler(this.resetRotationButton_Click);
            // 
            // resetScaleButton
            // 
            this.resetScaleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetScaleButton.Location = new System.Drawing.Point(297, 94);
            this.resetScaleButton.Name = "resetScaleButton";
            this.resetScaleButton.Size = new System.Drawing.Size(54, 35);
            this.resetScaleButton.TabIndex = 18;
            this.resetScaleButton.Text = "Reset";
            this.resetScaleButton.UseVisualStyleBackColor = true;
            this.resetScaleButton.Click += new System.EventHandler(this.resetScaleButton_Click);
            // 
            // previewGroupBox
            // 
            this.previewGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewGroupBox.Location = new System.Drawing.Point(362, 0);
            this.previewGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.previewGroupBox.Name = "previewGroupBox";
            this.previewGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.previewGroupBox.Size = new System.Drawing.Size(646, 561);
            this.previewGroupBox.TabIndex = 1;
            this.previewGroupBox.TabStop = false;
            this.previewGroupBox.Text = "Preview";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.previewGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xRotationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yRotationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zRotationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xLocationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yLocationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zLocationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xScaleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yScaleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zScaleNumericUpDown)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button helixButton;

        private System.Windows.Forms.Button cuboidButton;
        private System.Windows.Forms.Button coneButton;
        private System.Windows.Forms.Button pyramid4Button;
        private System.Windows.Forms.Button pyramid8Button;
        private System.Windows.Forms.Button frustumButton;
        private System.Windows.Forms.Button octahedronButton;
        private System.Windows.Forms.Button cylinderButton;
        private System.Windows.Forms.Button sphereButton;
        private System.Windows.Forms.Button torusButton;

        private System.Windows.Forms.Button cubeButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button resetLocationButton;
        private System.Windows.Forms.Button resetRotationButton;
        private System.Windows.Forms.Button resetScaleButton;

        private System.Windows.Forms.NumericUpDown xLocationNumericUpDown;
        private System.Windows.Forms.NumericUpDown yLocationNumericUpDown;
        private System.Windows.Forms.NumericUpDown zLocationNumericUpDown;
        private System.Windows.Forms.NumericUpDown xScaleNumericUpDown;
        private System.Windows.Forms.NumericUpDown yScaleNumericUpDown;
        private System.Windows.Forms.NumericUpDown zScaleNumericUpDown;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label xLabel;

        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label zLabel;

        private System.Windows.Forms.NumericUpDown yRotationNumericUpDown;
        private System.Windows.Forms.NumericUpDown zRotationNumericUpDown;

        private System.Windows.Forms.NumericUpDown xRotationNumericUpDown;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox previewGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button applyButton;
    }
}

