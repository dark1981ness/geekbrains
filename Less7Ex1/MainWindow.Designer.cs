namespace Less7Ex1
{
    partial class MainWindow
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Programms = new System.Windows.Forms.ToolStripMenuItem();
            this.Doubler = new System.Windows.Forms.ToolStripMenuItem();
            this.GuessNumber = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.mainMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Programms,
            this.About});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenu.Size = new System.Drawing.Size(490, 35);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "mainMenu";
            this.mainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainMenu_MouseDown);
            this.mainMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainMenu_MouseMove);
            this.mainMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainMenu_MouseUp);
            // 
            // File
            // 
            this.File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.File.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.File.ForeColor = System.Drawing.SystemColors.Control;
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(53, 31);
            this.File.Text = "Файл";
            // 
            // Exit
            // 
            this.Exit.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 24);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Programms
            // 
            this.Programms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Doubler,
            this.GuessNumber});
            this.Programms.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Programms.ForeColor = System.Drawing.SystemColors.Control;
            this.Programms.Name = "Programms";
            this.Programms.Size = new System.Drawing.Size(97, 31);
            this.Programms.Text = "Программы";
            // 
            // Doubler
            // 
            this.Doubler.ForeColor = System.Drawing.SystemColors.Control;
            this.Doubler.Name = "Doubler";
            this.Doubler.Size = new System.Drawing.Size(180, 24);
            this.Doubler.Text = "Удвоитель";
            this.Doubler.Click += new System.EventHandler(this.Doubler_Click);
            // 
            // GuessNumber
            // 
            this.GuessNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.GuessNumber.Name = "GuessNumber";
            this.GuessNumber.Size = new System.Drawing.Size(180, 24);
            this.GuessNumber.Text = "Угадай число";
            this.GuessNumber.Click += new System.EventHandler(this.GuessNumber_Click);
            // 
            // About
            // 
            this.About.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.About.ForeColor = System.Drawing.SystemColors.Control;
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(107, 31);
            this.About.Text = "О программе";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.mainPanel.Location = new System.Drawing.Point(0, 41);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(490, 489);
            this.mainPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.mainMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 35);
            this.panel1.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(446, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(490, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homework";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Programms;
        private System.Windows.Forms.ToolStripMenuItem Doubler;
        private System.Windows.Forms.ToolStripMenuItem GuessNumber;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
    }
}