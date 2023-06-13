namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.selectButton = new System.Windows.Forms.ToolStripButton();
            this.drawDotButton = new System.Windows.Forms.ToolStripButton();
            this.drawLineButton = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawSquareButton = new System.Windows.Forms.ToolStripButton();
            this.drawTriangleButton = new System.Windows.Forms.ToolStripButton();
            this.drawCircleButton = new System.Windows.Forms.ToolStripButton();
            this.drawEllipseButton = new System.Windows.Forms.ToolStripButton();
            this.drawPentagonButton = new System.Windows.Forms.ToolStripButton();
            this.drawHexagonButton = new System.Windows.Forms.ToolStripButton();
            this.drawStarButton = new System.Windows.Forms.ToolStripButton();
            this.addStringTextBox = new System.Windows.Forms.TextBox();
            this.addStringShapeButton = new System.Windows.Forms.Button();
            this.changeBackgroundColor = new System.Windows.Forms.Button();
            this.changeBorderColorButton = new System.Windows.Forms.Button();
            this.transparencyTrackBar = new System.Windows.Forms.TrackBar();
            this.transparencyLabel = new System.Windows.Forms.Label();
            this.rotateTrackBar = new System.Windows.Forms.TrackBar();
            this.rotateShapeLabel = new System.Windows.Forms.Label();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transparencyTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1447, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 475);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(1447, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // speedMenu
            // 
            this.speedMenu.AutoSize = false;
            this.speedMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectButton,
            this.drawDotButton,
            this.drawLineButton,
            this.drawRectangleSpeedButton,
            this.drawSquareButton,
            this.drawTriangleButton,
            this.drawCircleButton,
            this.drawEllipseButton,
            this.drawPentagonButton,
            this.drawHexagonButton,
            this.drawStarButton});
            this.speedMenu.Location = new System.Drawing.Point(0, 28);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(1447, 62);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            // 
            // selectButton
            // 
            this.selectButton.CheckOnClick = true;
            this.selectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectButton.Image = ((System.Drawing.Image)(resources.GetObject("selectButton.Image")));
            this.selectButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(29, 59);
            this.selectButton.Text = "selectButton";
            // 
            // drawDotButton
            // 
            this.drawDotButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawDotButton.Image = ((System.Drawing.Image)(resources.GetObject("drawDotButton.Image")));
            this.drawDotButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawDotButton.Name = "drawDotButton";
            this.drawDotButton.Size = new System.Drawing.Size(29, 59);
            this.drawDotButton.Text = "drawDot";
            this.drawDotButton.Click += new System.EventHandler(this.DrawDotButton_Click);
            // 
            // drawLineButton
            // 
            this.drawLineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawLineButton.Image = ((System.Drawing.Image)(resources.GetObject("drawLineButton.Image")));
            this.drawLineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawLineButton.Name = "drawLineButton";
            this.drawLineButton.Size = new System.Drawing.Size(29, 59);
            this.drawLineButton.Text = "drawLine";
            this.drawLineButton.Click += new System.EventHandler(this.DrawLineButton_Click);
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(29, 59);
            this.drawRectangleSpeedButton.Text = "DrawRectangle";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // drawSquareButton
            // 
            this.drawSquareButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawSquareButton.Image = ((System.Drawing.Image)(resources.GetObject("drawSquareButton.Image")));
            this.drawSquareButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawSquareButton.Name = "drawSquareButton";
            this.drawSquareButton.Size = new System.Drawing.Size(29, 59);
            this.drawSquareButton.Text = "drawSquare";
            this.drawSquareButton.Click += new System.EventHandler(this.DrawSquareButton_Click);
            // 
            // drawTriangleButton
            // 
            this.drawTriangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawTriangleButton.Image = ((System.Drawing.Image)(resources.GetObject("drawTriangleButton.Image")));
            this.drawTriangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawTriangleButton.Name = "drawTriangleButton";
            this.drawTriangleButton.Size = new System.Drawing.Size(29, 59);
            this.drawTriangleButton.Text = "drawTriangle";
            this.drawTriangleButton.Click += new System.EventHandler(this.DrawTriangleButton_Click);
            // 
            // drawCircleButton
            // 
            this.drawCircleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawCircleButton.Image = ((System.Drawing.Image)(resources.GetObject("drawCircleButton.Image")));
            this.drawCircleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawCircleButton.Name = "drawCircleButton";
            this.drawCircleButton.Size = new System.Drawing.Size(29, 59);
            this.drawCircleButton.Text = "drawCircle";
            this.drawCircleButton.ToolTipText = "drawCircleButton";
            this.drawCircleButton.Click += new System.EventHandler(this.DrawCircleButton_Click);
            // 
            // drawEllipseButton
            // 
            this.drawEllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawEllipseButton.Image = ((System.Drawing.Image)(resources.GetObject("drawEllipseButton.Image")));
            this.drawEllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawEllipseButton.Name = "drawEllipseButton";
            this.drawEllipseButton.Size = new System.Drawing.Size(29, 59);
            this.drawEllipseButton.Text = "drawEllipse";
            this.drawEllipseButton.ToolTipText = "drawEllipse";
            this.drawEllipseButton.Click += new System.EventHandler(this.DrawEllipseButton_Click);
            // 
            // drawPentagonButton
            // 
            this.drawPentagonButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawPentagonButton.Image = ((System.Drawing.Image)(resources.GetObject("drawPentagonButton.Image")));
            this.drawPentagonButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawPentagonButton.Name = "drawPentagonButton";
            this.drawPentagonButton.Size = new System.Drawing.Size(29, 59);
            this.drawPentagonButton.Text = "drawPentagon";
            this.drawPentagonButton.ToolTipText = "drawPentagon";
            this.drawPentagonButton.Click += new System.EventHandler(this.DrawPentagonButton_Click);
            // 
            // drawHexagonButton
            // 
            this.drawHexagonButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawHexagonButton.Image = ((System.Drawing.Image)(resources.GetObject("drawHexagonButton.Image")));
            this.drawHexagonButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawHexagonButton.Name = "drawHexagonButton";
            this.drawHexagonButton.Size = new System.Drawing.Size(29, 59);
            this.drawHexagonButton.Text = "drawHexagon";
            this.drawHexagonButton.Click += new System.EventHandler(this.DrawHexagonButton_Click);
            // 
            // drawStarButton
            // 
            this.drawStarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawStarButton.Image = ((System.Drawing.Image)(resources.GetObject("drawStarButton.Image")));
            this.drawStarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawStarButton.Name = "drawStarButton";
            this.drawStarButton.Size = new System.Drawing.Size(29, 59);
            this.drawStarButton.Text = "drawStar";
            this.drawStarButton.Click += new System.EventHandler(this.DrawStarButton_Click);
            // 
            // addStringTextBox
            // 
            this.addStringTextBox.Location = new System.Drawing.Point(377, 48);
            this.addStringTextBox.Name = "addStringTextBox";
            this.addStringTextBox.Size = new System.Drawing.Size(90, 22);
            this.addStringTextBox.TabIndex = 5;
            // 
            // addStringShapeButton
            // 
            this.addStringShapeButton.Location = new System.Drawing.Point(473, 45);
            this.addStringShapeButton.Name = "addStringShapeButton";
            this.addStringShapeButton.Size = new System.Drawing.Size(92, 25);
            this.addStringShapeButton.TabIndex = 6;
            this.addStringShapeButton.Text = "Draw Text";
            this.addStringShapeButton.UseVisualStyleBackColor = true;
            this.addStringShapeButton.Click += new System.EventHandler(this.addStringShapeButton_Click);
            // 
            // changeBackgroundColor
            // 
            this.changeBackgroundColor.Location = new System.Drawing.Point(571, 45);
            this.changeBackgroundColor.Name = "changeBackgroundColor";
            this.changeBackgroundColor.Size = new System.Drawing.Size(120, 25);
            this.changeBackgroundColor.TabIndex = 7;
            this.changeBackgroundColor.Text = "Set BG Color";
            this.changeBackgroundColor.UseCompatibleTextRendering = true;
            this.changeBackgroundColor.UseVisualStyleBackColor = true;
            this.changeBackgroundColor.Click += new System.EventHandler(this.setBackgroundColorButton_Click);
            // 
            // changeBorderColorButton
            // 
            this.changeBorderColorButton.Location = new System.Drawing.Point(697, 45);
            this.changeBorderColorButton.Name = "changeBorderColorButton";
            this.changeBorderColorButton.Size = new System.Drawing.Size(140, 25);
            this.changeBorderColorButton.TabIndex = 8;
            this.changeBorderColorButton.Text = "Set Border Color";
            this.changeBorderColorButton.UseCompatibleTextRendering = true;
            this.changeBorderColorButton.UseVisualStyleBackColor = true;
            this.changeBorderColorButton.Click += new System.EventHandler(this.setBorderColorButton_Click);
            // 
            // transparencyTrackBar
            // 
            this.transparencyTrackBar.AutoSize = false;
            this.transparencyTrackBar.Location = new System.Drawing.Point(857, 39);
            this.transparencyTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.transparencyTrackBar.Name = "transparencyTrackBar";
            this.transparencyTrackBar.Size = new System.Drawing.Size(166, 25);
            this.transparencyTrackBar.TabIndex = 12;
            this.transparencyTrackBar.Tag = "";
            this.transparencyTrackBar.Scroll += new System.EventHandler(this.transparencyTrackBar_Scroll);
            // 
            // transparencyLabel
            // 
            this.transparencyLabel.AutoSize = true;
            this.transparencyLabel.Location = new System.Drawing.Point(891, 68);
            this.transparencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.transparencyLabel.Name = "transparencyLabel";
            this.transparencyLabel.Size = new System.Drawing.Size(96, 17);
            this.transparencyLabel.TabIndex = 14;
            this.transparencyLabel.Text = "Transparency";
            // 
            // rotateTrackBar
            // 
            this.rotateTrackBar.AccessibleName = "";
            this.rotateTrackBar.AutoSize = false;
            this.rotateTrackBar.Location = new System.Drawing.Point(1031, 39);
            this.rotateTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.rotateTrackBar.Name = "rotateTrackBar";
            this.rotateTrackBar.Size = new System.Drawing.Size(166, 25);
            this.rotateTrackBar.TabIndex = 15;
            this.rotateTrackBar.Scroll += new System.EventHandler(this.rotationTrackBar_Scroll);
            // 
            // rotateShapeLabel
            // 
            this.rotateShapeLabel.AutoSize = true;
            this.rotateShapeLabel.Location = new System.Drawing.Point(1067, 68);
            this.rotateShapeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rotateShapeLabel.Name = "rotateShapeLabel";
            this.rotateShapeLabel.Size = new System.Drawing.Size(95, 17);
            this.rotateShapeLabel.TabIndex = 16;
            this.rotateShapeLabel.Text = "Rotate Shape";
            // 
            // viewPort
            // 
            this.viewPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 90);
            this.viewPort.Margin = new System.Windows.Forms.Padding(5);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(1447, 385);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(1204, 39);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(63, 25);
            this.copyButton.TabIndex = 17;
            this.copyButton.Text = "Copy";
            this.copyButton.UseCompatibleTextRendering = true;
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1273, 39);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(63, 25);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseCompatibleTextRendering = true;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 497);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.rotateShapeLabel);
            this.Controls.Add(this.rotateTrackBar);
            this.Controls.Add(this.transparencyLabel);
            this.Controls.Add(this.transparencyTrackBar);
            this.Controls.Add(this.changeBorderColorButton);
            this.Controls.Add(this.changeBackgroundColor);
            this.Controls.Add(this.addStringShapeButton);
            this.Controls.Add(this.addStringTextBox);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transparencyTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton selectButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripButton drawCircleButton;
        private System.Windows.Forms.ToolStripButton drawLineButton;
        private System.Windows.Forms.ToolStripButton drawDotButton;
        private System.Windows.Forms.ToolStripButton drawSquareButton;
        private System.Windows.Forms.ToolStripButton drawEllipseButton;
        private System.Windows.Forms.ToolStripButton drawPentagonButton;
        private System.Windows.Forms.ToolStripButton drawHexagonButton;
        private System.Windows.Forms.ToolStripButton drawStarButton;
        private System.Windows.Forms.ToolStripButton drawTriangleButton;
        private System.Windows.Forms.TextBox addStringTextBox;
        private System.Windows.Forms.Button addStringShapeButton;
        private System.Windows.Forms.Button changeBackgroundColor;
        private System.Windows.Forms.Button changeBorderColorButton;
        private System.Windows.Forms.TrackBar transparencyTrackBar;
        private System.Windows.Forms.Label transparencyLabel;
        private System.Windows.Forms.TrackBar rotateTrackBar;
        private System.Windows.Forms.Label rotateShapeLabel;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button deleteButton;
    }
}
