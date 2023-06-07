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
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
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
            this.mainMenu.Size = new System.Drawing.Size(739, 30);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 26);
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
            this.statusBar.Location = new System.Drawing.Point(0, 394);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(739, 22);
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
            this.speedMenu.Location = new System.Drawing.Point(0, 30);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(739, 31);
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
            this.selectButton.Size = new System.Drawing.Size(29, 28);
            this.selectButton.Text = "selectButton";
            // 
            // drawDotButton
            // 
            this.drawDotButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawDotButton.Image = ((System.Drawing.Image)(resources.GetObject("drawDotButton.Image")));
            this.drawDotButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawDotButton.Name = "drawDotButton";
            this.drawDotButton.Size = new System.Drawing.Size(29, 28);
            this.drawDotButton.Text = "drawDot";
            // 
            // drawLineButton
            // 
            this.drawLineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawLineButton.Image = ((System.Drawing.Image)(resources.GetObject("drawLineButton.Image")));
            this.drawLineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawLineButton.Name = "drawLineButton";
            this.drawLineButton.Size = new System.Drawing.Size(29, 28);
            this.drawLineButton.Text = "drawLine";
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(29, 28);
            this.drawRectangleSpeedButton.Text = "DrawRectangle";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // drawSquareButton
            // 
            this.drawSquareButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawSquareButton.Image = ((System.Drawing.Image)(resources.GetObject("drawSquareButton.Image")));
            this.drawSquareButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawSquareButton.Name = "drawSquareButton";
            this.drawSquareButton.Size = new System.Drawing.Size(29, 28);
            this.drawSquareButton.Text = "drawSquare";
            // 
            // drawTriangleButton
            // 
            this.drawTriangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawTriangleButton.Image = ((System.Drawing.Image)(resources.GetObject("drawTriangleButton.Image")));
            this.drawTriangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawTriangleButton.Name = "drawTriangleButton";
            this.drawTriangleButton.Size = new System.Drawing.Size(29, 28);
            this.drawTriangleButton.Text = "drawTriangle";
            // 
            // drawCircleButton
            // 
            this.drawCircleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawCircleButton.Image = ((System.Drawing.Image)(resources.GetObject("drawCircleButton.Image")));
            this.drawCircleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawCircleButton.Name = "drawCircleButton";
            this.drawCircleButton.Size = new System.Drawing.Size(29, 28);
            this.drawCircleButton.Text = "drawCircle";
            this.drawCircleButton.ToolTipText = "drawCircleButton";
            // 
            // drawEllipseButton
            // 
            this.drawEllipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawEllipseButton.Image = ((System.Drawing.Image)(resources.GetObject("drawEllipseButton.Image")));
            this.drawEllipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawEllipseButton.Name = "drawEllipseButton";
            this.drawEllipseButton.Size = new System.Drawing.Size(29, 28);
            this.drawEllipseButton.Text = "drawEllipse";
            this.drawEllipseButton.ToolTipText = "drawEllipse";
            // 
            // drawPentagonButton
            // 
            this.drawPentagonButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawPentagonButton.Image = ((System.Drawing.Image)(resources.GetObject("drawPentagonButton.Image")));
            this.drawPentagonButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawPentagonButton.Name = "drawPentagonButton";
            this.drawPentagonButton.Size = new System.Drawing.Size(29, 28);
            this.drawPentagonButton.Text = "drawPentagon";
            this.drawPentagonButton.ToolTipText = "drawPentagon";
            // 
            // drawHexagonButton
            // 
            this.drawHexagonButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawHexagonButton.Image = ((System.Drawing.Image)(resources.GetObject("drawHexagonButton.Image")));
            this.drawHexagonButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawHexagonButton.Name = "drawHexagonButton";
            this.drawHexagonButton.Size = new System.Drawing.Size(29, 28);
            this.drawHexagonButton.Text = "drawHexagon";
            // 
            // drawStarButton
            // 
            this.drawStarButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawStarButton.Image = ((System.Drawing.Image)(resources.GetObject("drawStarButton.Image")));
            this.drawStarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawStarButton.Name = "drawStarButton";
            this.drawStarButton.Size = new System.Drawing.Size(29, 28);
            this.drawStarButton.Text = "drawStar";
            // 
            // viewPort
            // 
            this.viewPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 61);
            this.viewPort.Margin = new System.Windows.Forms.Padding(5);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(739, 333);
            this.viewPort.TabIndex = 4;
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 416);
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
    }
}
