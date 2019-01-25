namespace BaseWindow
{
    partial class BaseWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseWindowForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.WindowTitle = new System.Windows.Forms.Label();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TopPanel.Controls.Add(this.ButtonMinimize);
            this.TopPanel.Controls.Add(this.ButtonExit);
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.WindowTitle);
            this.TopPanel.Controls.Add(this.ImagePanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(1, 1);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(598, 27);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.DoubleClick += new System.EventHandler(this.BaseWindowForm_Maximize);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonMinimize.FlatAppearance.BorderSize = 0;
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ButtonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMinimize.Image")));
            this.ButtonMinimize.Location = new System.Drawing.Point(508, 0);
            this.ButtonMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(30, 27);
            this.ButtonMinimize.TabIndex = 0;
            this.ButtonMinimize.UseVisualStyleBackColor = true;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonExit.FlatAppearance.BorderSize = 0;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.Location = new System.Drawing.Point(538, 0);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(30, 27);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.BaseWindowForm_Maximize);
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(568, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 27);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // WindowTitle
            // 
            this.WindowTitle.AutoSize = true;
            this.WindowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowTitle.ForeColor = System.Drawing.Color.Gray;
            this.WindowTitle.Location = new System.Drawing.Point(34, 8);
            this.WindowTitle.Name = "WindowTitle";
            this.WindowTitle.Size = new System.Drawing.Size(46, 13);
            this.WindowTitle.TabIndex = 1;
            this.WindowTitle.Text = "Window";
            // 
            // ImagePanel
            // 
            this.ImagePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ImagePanel.BackgroundImage")));
            this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ImagePanel.Location = new System.Drawing.Point(0, 0);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(27, 27);
            this.ImagePanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(1, 28);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(598, 371);
            this.MainPanel.TabIndex = 1;
            // 
            // BaseWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseWindowForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "BaseWindowForm";
            this.Activated += new System.EventHandler(this.BaseWindowForm_Activated);
            this.Deactivate += new System.EventHandler(this.BaseWindowForm_Deactivate);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Button ButtonExit;
        public System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.Label WindowTitle;
        public System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.Button CloseButton;
    }
}