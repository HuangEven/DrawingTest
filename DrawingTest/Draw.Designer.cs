namespace DrawingTest
{
    partial class Draw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Draw));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具箱ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.绘图工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.调色板ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.线条ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.状态栏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图像PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除图像ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tsbtForeColor = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsW = new System.Windows.Forms.ToolStripButton();
            this.tsD = new System.Windows.Forms.ToolStripButton();
            this.tsR = new System.Windows.Forms.ToolStripButton();
            this.tsO = new System.Windows.Forms.ToolStripButton();
            this.tsY = new System.Windows.Forms.ToolStripButton();
            this.tsG = new System.Windows.Forms.ToolStripButton();
            this.tsC = new System.Windows.Forms.ToolStripButton();
            this.tsB = new System.Windows.Forms.ToolStripButton();
            this.tsP = new System.Windows.Forms.ToolStripButton();
            this.tspur = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CustomLine = new System.Windows.Forms.Button();
            this.line4 = new System.Windows.Forms.Button();
            this.line3 = new System.Windows.Forms.Button();
            this.line2 = new System.Windows.Forms.Button();
            this.line1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxTool = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pencil = new System.Windows.Forms.ToolStripButton();
            this.eraser = new System.Windows.Forms.ToolStripButton();
            this.ellipse = new System.Windows.Forms.ToolStripButton();
            this.circle = new System.Windows.Forms.ToolStripButton();
            this.bucket = new System.Windows.Forms.ToolStripButton();
            this.CurvedLine = new System.Windows.Forms.ToolStripButton();
            this.line = new System.Windows.Forms.ToolStripButton();
            this.Rect = new System.Windows.Forms.ToolStripButton();
            this.square = new System.Windows.Forms.ToolStripButton();
            this.FillRect = new System.Windows.Forms.ToolStripButton();
            this.FillCircle = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reSize = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.currentDrawType = new System.Windows.Forms.ToolStripStatusLabel();
            this.mouseposition = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxTool.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reSize)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.工具箱ToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.图像PToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.toolStripSeparator1,
            this.另存为ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(F)";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.新建ToolStripMenuItem.Text = "新建(N)";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.保存ToolStripMenuItem.Text = "保存(S)";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(115, 6);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // 工具箱ToolStripMenuItem
            // 
            this.工具箱ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.绘图工具ToolStripMenuItem,
            this.调色板ToolStripMenuItem1,
            this.线条ToolStripMenuItem});
            this.工具箱ToolStripMenuItem.Name = "工具箱ToolStripMenuItem";
            this.工具箱ToolStripMenuItem.Size = new System.Drawing.Size(71, 21);
            this.工具箱ToolStripMenuItem.Text = "工具箱(T)";
            this.工具箱ToolStripMenuItem.Click += new System.EventHandler(this.编辑ToolStripMenuItem_Click);
            // 
            // 绘图工具ToolStripMenuItem
            // 
            this.绘图工具ToolStripMenuItem.Checked = true;
            this.绘图工具ToolStripMenuItem.CheckOnClick = true;
            this.绘图工具ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.绘图工具ToolStripMenuItem.Name = "绘图工具ToolStripMenuItem";
            this.绘图工具ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.绘图工具ToolStripMenuItem.Text = "绘图工具";
            this.绘图工具ToolStripMenuItem.Click += new System.EventHandler(this.调色板ToolStripMenuItem_Click);
            // 
            // 调色板ToolStripMenuItem1
            // 
            this.调色板ToolStripMenuItem1.Checked = true;
            this.调色板ToolStripMenuItem1.CheckOnClick = true;
            this.调色板ToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.调色板ToolStripMenuItem1.Name = "调色板ToolStripMenuItem1";
            this.调色板ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.调色板ToolStripMenuItem1.Text = "调色板";
            this.调色板ToolStripMenuItem1.Click += new System.EventHandler(this.调色板ToolStripMenuItem1_Click);
            // 
            // 线条ToolStripMenuItem
            // 
            this.线条ToolStripMenuItem.Checked = true;
            this.线条ToolStripMenuItem.CheckOnClick = true;
            this.线条ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.线条ToolStripMenuItem.Name = "线条ToolStripMenuItem";
            this.线条ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.线条ToolStripMenuItem.Text = "线条";
            this.线条ToolStripMenuItem.Click += new System.EventHandler(this.线条ToolStripMenuItem_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Checked = true;
            this.查看ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.状态栏ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.查看ToolStripMenuItem.Text = "查看(V)";
            // 
            // 状态栏ToolStripMenuItem
            // 
            this.状态栏ToolStripMenuItem.Checked = true;
            this.状态栏ToolStripMenuItem.CheckOnClick = true;
            this.状态栏ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.状态栏ToolStripMenuItem.Name = "状态栏ToolStripMenuItem";
            this.状态栏ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.状态栏ToolStripMenuItem.Text = "状态栏";
            this.状态栏ToolStripMenuItem.Click += new System.EventHandler(this.状态栏ToolStripMenuItem_Click);
            // 
            // 图像PToolStripMenuItem
            // 
            this.图像PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清除图像ToolStripMenuItem});
            this.图像PToolStripMenuItem.Name = "图像PToolStripMenuItem";
            this.图像PToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.图像PToolStripMenuItem.Text = "图像(P)";
            // 
            // 清除图像ToolStripMenuItem
            // 
            this.清除图像ToolStripMenuItem.Name = "清除图像ToolStripMenuItem";
            this.清除图像ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清除图像ToolStripMenuItem.Text = "清除图像";
            this.清除图像ToolStripMenuItem.Click += new System.EventHandler(this.清除图像ToolStripMenuItem_Click);
            // 
            // pbImg
            // 
            this.pbImg.BackColor = System.Drawing.Color.White;
            this.pbImg.Location = new System.Drawing.Point(3, 0);
            this.pbImg.Margin = new System.Windows.Forms.Padding(2);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(320, 264);
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            this.pbImg.Click += new System.EventHandler(this.pbImg_Click);
            this.pbImg.Paint += new System.Windows.Forms.PaintEventHandler(this.pbImg_Paint);
            this.pbImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbImg_MouseDown);
            this.pbImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbImg_MouseMove);
            this.pbImg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbImg_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 330);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tsbtForeColor);
            this.panel5.Controls.Add(this.groupBox3);
            this.panel5.Location = new System.Drawing.Point(3, 210);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 117);
            this.panel5.TabIndex = 6;
            // 
            // tsbtForeColor
            // 
            this.tsbtForeColor.Location = new System.Drawing.Point(48, 91);
            this.tsbtForeColor.Name = "tsbtForeColor";
            this.tsbtForeColor.Size = new System.Drawing.Size(75, 23);
            this.tsbtForeColor.TabIndex = 2;
            this.tsbtForeColor.Text = "画具颜色";
            this.tsbtForeColor.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.toolStrip2);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 90);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "颜色";
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsW,
            this.tsD,
            this.tsR,
            this.tsO,
            this.tsY,
            this.tsG,
            this.tsC,
            this.tsB,
            this.tsP,
            this.tspur,
            this.toolStripLabel1});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip2.Location = new System.Drawing.Point(7, 12);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(162, 99);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsW
            // 
            this.tsW.AutoSize = false;
            this.tsW.BackColor = System.Drawing.Color.White;
            this.tsW.CheckOnClick = true;
            this.tsW.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsW.Image = ((System.Drawing.Image)(resources.GetObject("tsW.Image")));
            this.tsW.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsW.Margin = new System.Windows.Forms.Padding(6, 1, 6, 2);
            this.tsW.Name = "tsW";
            this.tsW.Size = new System.Drawing.Size(23, 24);
            this.tsW.Text = "白色";
            this.tsW.Click += new System.EventHandler(this.tsW_Click);
            // 
            // tsD
            // 
            this.tsD.AutoSize = false;
            this.tsD.BackColor = System.Drawing.Color.Black;
            this.tsD.CheckOnClick = true;
            this.tsD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsD.Name = "tsD";
            this.tsD.Size = new System.Drawing.Size(23, 24);
            this.tsD.Text = "黑色";
            this.tsD.Click += new System.EventHandler(this.tsD_Click);
            // 
            // tsR
            // 
            this.tsR.AutoSize = false;
            this.tsR.BackColor = System.Drawing.Color.Red;
            this.tsR.CheckOnClick = true;
            this.tsR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsR.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsR.Margin = new System.Windows.Forms.Padding(6, 1, 6, 2);
            this.tsR.Name = "tsR";
            this.tsR.Size = new System.Drawing.Size(23, 24);
            this.tsR.Text = "红色";
            this.tsR.Click += new System.EventHandler(this.tsR_Click);
            // 
            // tsO
            // 
            this.tsO.AutoSize = false;
            this.tsO.BackColor = System.Drawing.Color.Orange;
            this.tsO.CheckOnClick = true;
            this.tsO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsO.Name = "tsO";
            this.tsO.Size = new System.Drawing.Size(23, 24);
            this.tsO.Text = "橙色";
            this.tsO.Click += new System.EventHandler(this.tsO_Click);
            // 
            // tsY
            // 
            this.tsY.AutoSize = false;
            this.tsY.BackColor = System.Drawing.Color.Yellow;
            this.tsY.CheckOnClick = true;
            this.tsY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsY.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsY.Margin = new System.Windows.Forms.Padding(6, 1, 6, 2);
            this.tsY.Name = "tsY";
            this.tsY.Size = new System.Drawing.Size(23, 24);
            this.tsY.Text = "黄色";
            this.tsY.Click += new System.EventHandler(this.tsY_Click);
            // 
            // tsG
            // 
            this.tsG.AutoSize = false;
            this.tsG.BackColor = System.Drawing.Color.Green;
            this.tsG.CheckOnClick = true;
            this.tsG.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsG.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsG.Name = "tsG";
            this.tsG.Size = new System.Drawing.Size(23, 24);
            this.tsG.Text = "绿色";
            this.tsG.Click += new System.EventHandler(this.tsG_Click);
            // 
            // tsC
            // 
            this.tsC.AutoSize = false;
            this.tsC.BackColor = System.Drawing.Color.Cyan;
            this.tsC.CheckOnClick = true;
            this.tsC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsC.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsC.Margin = new System.Windows.Forms.Padding(6, 1, 6, 2);
            this.tsC.Name = "tsC";
            this.tsC.Size = new System.Drawing.Size(23, 24);
            this.tsC.Text = "靛青";
            this.tsC.Click += new System.EventHandler(this.tsG_Click);
            // 
            // tsB
            // 
            this.tsB.AutoSize = false;
            this.tsB.BackColor = System.Drawing.Color.Blue;
            this.tsB.CheckOnClick = true;
            this.tsB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsB.Name = "tsB";
            this.tsB.Size = new System.Drawing.Size(23, 24);
            this.tsB.Text = "蓝色";
            this.tsB.Click += new System.EventHandler(this.tsB_Click);
            // 
            // tsP
            // 
            this.tsP.AutoSize = false;
            this.tsP.BackColor = System.Drawing.Color.Pink;
            this.tsP.CheckOnClick = true;
            this.tsP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsP.Margin = new System.Windows.Forms.Padding(6, 1, 6, 2);
            this.tsP.Name = "tsP";
            this.tsP.Size = new System.Drawing.Size(23, 24);
            this.tsP.Text = "粉色";
            this.tsP.Click += new System.EventHandler(this.tsDp_Click);
            // 
            // tspur
            // 
            this.tspur.AutoSize = false;
            this.tspur.BackColor = System.Drawing.Color.Purple;
            this.tspur.CheckOnClick = true;
            this.tspur.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tspur.Image = ((System.Drawing.Image)(resources.GetObject("tspur.Image")));
            this.tspur.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspur.Name = "tspur";
            this.tspur.Size = new System.Drawing.Size(23, 24);
            this.tspur.Text = "紫色";
            this.tspur.Click += new System.EventHandler(this.tsM_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 17);
            this.toolStripLabel1.Text = "更多颜色";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Location = new System.Drawing.Point(95, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(83, 167);
            this.panel4.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CustomLine);
            this.groupBox2.Controls.Add(this.line4);
            this.groupBox2.Controls.Add(this.line3);
            this.groupBox2.Controls.Add(this.line2);
            this.groupBox2.Controls.Add(this.line1);
            this.groupBox2.Location = new System.Drawing.Point(3, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(79, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "线条设置";
            // 
            // CustomLine
            // 
            this.CustomLine.Font = new System.Drawing.Font("微软雅黑", 7F);
            this.CustomLine.Location = new System.Drawing.Point(17, 107);
            this.CustomLine.Margin = new System.Windows.Forms.Padding(2);
            this.CustomLine.Name = "CustomLine";
            this.CustomLine.Size = new System.Drawing.Size(51, 23);
            this.CustomLine.TabIndex = 6;
            this.CustomLine.Text = "自定义";
            this.CustomLine.UseVisualStyleBackColor = true;
            this.CustomLine.Click += new System.EventHandler(this.CustomLine_Click);
            // 
            // line4
            // 
            this.line4.Image = ((System.Drawing.Image)(resources.GetObject("line4.Image")));
            this.line4.Location = new System.Drawing.Point(17, 85);
            this.line4.Margin = new System.Windows.Forms.Padding(2);
            this.line4.Name = "line4";
            this.line4.Size = new System.Drawing.Size(51, 18);
            this.line4.TabIndex = 4;
            this.line4.UseVisualStyleBackColor = true;
            this.line4.Click += new System.EventHandler(this.line4_Click);
            // 
            // line3
            // 
            this.line3.Image = ((System.Drawing.Image)(resources.GetObject("line3.Image")));
            this.line3.Location = new System.Drawing.Point(16, 63);
            this.line3.Margin = new System.Windows.Forms.Padding(2);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(52, 18);
            this.line3.TabIndex = 3;
            this.line3.UseVisualStyleBackColor = true;
            this.line3.Click += new System.EventHandler(this.line3_Click);
            // 
            // line2
            // 
            this.line2.Image = ((System.Drawing.Image)(resources.GetObject("line2.Image")));
            this.line2.Location = new System.Drawing.Point(16, 41);
            this.line2.Margin = new System.Windows.Forms.Padding(2);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(51, 18);
            this.line2.TabIndex = 2;
            this.line2.UseVisualStyleBackColor = true;
            this.line2.Click += new System.EventHandler(this.line2_Click);
            // 
            // line1
            // 
            this.line1.Image = ((System.Drawing.Image)(resources.GetObject("line1.Image")));
            this.line1.Location = new System.Drawing.Point(16, 19);
            this.line1.Margin = new System.Windows.Forms.Padding(2);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(52, 18);
            this.line1.TabIndex = 1;
            this.line1.UseVisualStyleBackColor = true;
            this.line1.Click += new System.EventHandler(this.line1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxTool);
            this.panel1.Location = new System.Drawing.Point(5, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 167);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxTool
            // 
            this.groupBoxTool.Controls.Add(this.toolStrip1);
            this.groupBoxTool.Location = new System.Drawing.Point(3, 4);
            this.groupBoxTool.Name = "groupBoxTool";
            this.groupBoxTool.Size = new System.Drawing.Size(81, 152);
            this.groupBoxTool.TabIndex = 0;
            this.groupBoxTool.TabStop = false;
            this.groupBoxTool.Text = "工具栏";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pencil,
            this.eraser,
            this.ellipse,
            this.circle,
            this.bucket,
            this.CurvedLine,
            this.line,
            this.Rect,
            this.square,
            this.FillRect,
            this.FillCircle});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(3, 23);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(70, 115);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked_1);
            // 
            // pencil
            // 
            this.pencil.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pencil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pencil.Image = ((System.Drawing.Image)(resources.GetObject("pencil.Image")));
            this.pencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pencil.Name = "pencil";
            this.pencil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pencil.Size = new System.Drawing.Size(23, 20);
            this.pencil.Text = "铅笔";
            this.pencil.Click += new System.EventHandler(this.tool_Click);
            // 
            // eraser
            // 
            this.eraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            //this.eraser.ForeColor = System.Drawing.Color.White;
            this.eraser.Image = ((System.Drawing.Image)(resources.GetObject("eraser.Image")));
            this.eraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(23, 20);
            this.eraser.Text = "橡皮";
            this.eraser.Click += new System.EventHandler(this.tool_Click);
            // 
            // ellipse
            // 
            this.ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipse.Image = ((System.Drawing.Image)(resources.GetObject("ellipse.Image")));
            this.ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ellipse.Name = "ellipse";
            this.ellipse.Size = new System.Drawing.Size(23, 20);
            this.ellipse.Text = "椭圆";
            this.ellipse.Click += new System.EventHandler(this.tool_Click);
            // 
            // circle
            // 
            this.circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.circle.Image = ((System.Drawing.Image)(resources.GetObject("circle.Image")));
            this.circle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(23, 20);
            this.circle.Text = "圆";
            this.circle.Click += new System.EventHandler(this.tool_Click);
            // 
            // bucket
            // 
            this.bucket.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bucket.Image = ((System.Drawing.Image)(resources.GetObject("bucket.Image")));
            this.bucket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bucket.Name = "bucket";
            this.bucket.Size = new System.Drawing.Size(23, 20);
            this.bucket.Text = "油漆桶";
            // 
            // CurvedLine
            // 
            this.CurvedLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CurvedLine.Image = ((System.Drawing.Image)(resources.GetObject("CurvedLine.Image")));
            this.CurvedLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CurvedLine.Name = "CurvedLine";
            this.CurvedLine.Size = new System.Drawing.Size(23, 20);
            this.CurvedLine.Text = "曲线";
            // 
            // line
            // 
            this.line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.line.Image = ((System.Drawing.Image)(resources.GetObject("line.Image")));
            this.line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(23, 20);
            this.line.Text = "直线";
            this.line.Click += new System.EventHandler(this.tool_Click);
            // 
            // Rect
            // 
            this.Rect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rect.Image = ((System.Drawing.Image)(resources.GetObject("Rect.Image")));
            this.Rect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rect.Name = "Rect";
            this.Rect.Size = new System.Drawing.Size(23, 20);
            this.Rect.Text = "矩形";
            this.Rect.Click += new System.EventHandler(this.tool_Click);
            // 
            // square
            // 
            this.square.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.square.Image = ((System.Drawing.Image)(resources.GetObject("square.Image")));
            this.square.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(23, 20);
            this.square.Text = "正方形";
            this.square.Click += new System.EventHandler(this.tool_Click);
            // 
            // FillRect
            // 
            this.FillRect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillRect.Image = ((System.Drawing.Image)(resources.GetObject("FillRect.Image")));
            this.FillRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillRect.Name = "FillRect";
            this.FillRect.Size = new System.Drawing.Size(23, 20);
            this.FillRect.Text = "实心矩形";
            this.FillRect.Click += new System.EventHandler(this.tool_Click);
            // 
            // FillCircle
            // 
            this.FillCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillCircle.Image = ((System.Drawing.Image)(resources.GetObject("FillCircle.Image")));
            this.FillCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillCircle.Name = "FillCircle";
            this.FillCircle.Size = new System.Drawing.Size(23, 20);
            this.FillCircle.Text = "实心圆";
            this.FillCircle.Click += new System.EventHandler(this.tool_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.reSize);
            this.panel3.Controls.Add(this.pbImg);
            this.panel3.Location = new System.Drawing.Point(181, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 317);
            this.panel3.TabIndex = 4;
            // 
            // reSize
            // 
            this.reSize.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.reSize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.reSize.Location = new System.Drawing.Point(314, 252);
            this.reSize.Margin = new System.Windows.Forms.Padding(4);
            this.reSize.Name = "reSize";
            this.reSize.Size = new System.Drawing.Size(27, 21);
            this.reSize.TabIndex = 1;
            this.reSize.TabStop = false;
            this.reSize.Click += new System.EventHandler(this.reSize_Click);
            this.reSize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reSize_MouseDown);
            this.reSize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.reSize_MouseMove);
            this.reSize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.reSize_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentDrawType,
            this.mouseposition,
            this.toolStripStatusLabel3});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(631, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // currentDrawType
            // 
            this.currentDrawType.Name = "currentDrawType";
            this.currentDrawType.Size = new System.Drawing.Size(56, 21);
            this.currentDrawType.Text = "绘图工具";
            this.currentDrawType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mouseposition
            // 
            this.mouseposition.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.mouseposition.Name = "mouseposition";
            this.mouseposition.Size = new System.Drawing.Size(84, 21);
            this.mouseposition.Spring = true;
            this.mouseposition.Text = "当前鼠标位置";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(56, 21);
            this.toolStripStatusLabel3.Text = "画布大小";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 385);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Draw";
            this.Text = "Draw";
            this.Load += new System.EventHandler(this.Draw_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxTool.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reSize)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具箱ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 绘图工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 调色板ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 状态栏ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel currentDrawType;
        private System.Windows.Forms.ToolStripStatusLabel mouseposition;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 图像PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除图像ToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox reSize;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsW;
        private System.Windows.Forms.ToolStripButton tsD;
        private System.Windows.Forms.ToolStripButton tsR;
        private System.Windows.Forms.ToolStripButton tsO;
        private System.Windows.Forms.ToolStripButton tsY;
        private System.Windows.Forms.ToolStripButton tsG;
        private System.Windows.Forms.ToolStripButton tsC;
        private System.Windows.Forms.ToolStripButton tsB;
        private System.Windows.Forms.ToolStripButton tsP;
        private System.Windows.Forms.ToolStripButton tspur;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button CustomLine;
        private System.Windows.Forms.Button line4;
        private System.Windows.Forms.Button line3;
        private System.Windows.Forms.Button line2;
        private System.Windows.Forms.Button line1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxTool;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton pencil;
        private System.Windows.Forms.ToolStripButton eraser;
        private System.Windows.Forms.ToolStripButton ellipse;
        private System.Windows.Forms.ToolStripButton circle;
        private System.Windows.Forms.ToolStripButton bucket;
        private System.Windows.Forms.ToolStripButton CurvedLine;
        private System.Windows.Forms.ToolStripButton line;
        private System.Windows.Forms.ToolStripButton Rect;
        private System.Windows.Forms.ToolStripMenuItem 线条ToolStripMenuItem;
        private System.Windows.Forms.Button tsbtForeColor;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton square;
        private System.Windows.Forms.ToolStripButton FillRect;
        private System.Windows.Forms.ToolStripButton FillCircle;
    }
}