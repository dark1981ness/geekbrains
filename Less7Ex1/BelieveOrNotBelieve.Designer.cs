namespace Less7Ex1
{
    partial class BelieveOrNotBelieve
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
            this.toolStripBnB = new System.Windows.Forms.ToolStrip();
            this.BnBdatabase = new System.Windows.Forms.ToolStripLabel();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAs = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.textBoxBnB = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboxTrue = new System.Windows.Forms.CheckBox();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSaveQuest = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStripBnB.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripBnB
            // 
            this.toolStripBnB.AutoSize = false;
            this.toolStripBnB.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripBnB.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStripBnB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BnBdatabase,
            this.btnNew,
            this.btnOpen,
            this.btnSave,
            this.btnSaveAs,
            this.btnExit});
            this.toolStripBnB.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripBnB.Location = new System.Drawing.Point(0, 0);
            this.toolStripBnB.Name = "toolStripBnB";
            this.toolStripBnB.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStripBnB.Size = new System.Drawing.Size(634, 45);
            this.toolStripBnB.TabIndex = 0;
            this.toolStripBnB.Text = "toolStrip1";
            // 
            // BnBdatabase
            // 
            this.BnBdatabase.ForeColor = System.Drawing.SystemColors.Control;
            this.BnBdatabase.Name = "BnBdatabase";
            this.BnBdatabase.Size = new System.Drawing.Size(0, 42);
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = global::Less7Ex1.Properties.Resources.Actions_file_new_icon;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(54, 42);
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = global::Less7Ex1.Properties.Resources.Filesystems_folder_open_icon;
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(54, 42);
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.btnSave.Image = global::Less7Ex1.Properties.Resources.Actions_floppy_save_icon;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 42);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAs.Image = global::Less7Ex1.Properties.Resources.Actions_file_save_as_icon;
            this.btnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(54, 42);
            this.btnSaveAs.Text = "Save As";
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = global::Less7Ex1.Properties.Resources.Remove_icon;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 42);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBoxBnB
            // 
            this.textBoxBnB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textBoxBnB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBnB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBnB.Font = new System.Drawing.Font("Script MT Bold", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxBnB.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxBnB.Location = new System.Drawing.Point(10, 10);
            this.textBoxBnB.Multiline = true;
            this.textBoxBnB.Name = "textBoxBnB";
            this.textBoxBnB.Size = new System.Drawing.Size(614, 169);
            this.textBoxBnB.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.cboxTrue);
            this.panel1.Controls.Add(this.nudNumber);
            this.panel1.Controls.Add(this.btnSaveQuest);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 49);
            this.panel1.TabIndex = 2;
            // 
            // cboxTrue
            // 
            this.cboxTrue.AutoSize = true;
            this.cboxTrue.ForeColor = System.Drawing.SystemColors.Control;
            this.cboxTrue.Location = new System.Drawing.Point(518, 18);
            this.cboxTrue.Name = "cboxTrue";
            this.cboxTrue.Size = new System.Drawing.Size(64, 17);
            this.cboxTrue.TabIndex = 4;
            this.cboxTrue.Text = "Правда";
            this.cboxTrue.UseVisualStyleBackColor = true;
            // 
            // nudNumber
            // 
            this.nudNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.nudNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.nudNumber.Location = new System.Drawing.Point(392, 17);
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(120, 20);
            this.nudNumber.TabIndex = 3;
            this.nudNumber.ValueChanged += new System.EventHandler(this.nudNumber_ValueChanged);
            // 
            // btnSaveQuest
            // 
            this.btnSaveQuest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSaveQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveQuest.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveQuest.Location = new System.Drawing.Point(216, 14);
            this.btnSaveQuest.Name = "btnSaveQuest";
            this.btnSaveQuest.Size = new System.Drawing.Size(75, 23);
            this.btnSaveQuest.TabIndex = 2;
            this.btnSaveQuest.Text = "Сохранить";
            this.btnSaveQuest.UseVisualStyleBackColor = false;
            this.btnSaveQuest.Click += new System.EventHandler(this.btnSaveQuest_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(135, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(12, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.textBoxBnB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(634, 189);
            this.panel2.TabIndex = 3;
            // 
            // BelieveOrNotBelieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 283);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStripBnB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BelieveOrNotBelieve";
            this.Text = "BelieveOrNotBelieve";
            this.Load += new System.EventHandler(this.BelieveOrNotBelieve_Load);
            this.toolStripBnB.ResumeLayout(false);
            this.toolStripBnB.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripBnB;
        private System.Windows.Forms.ToolStripLabel BnBdatabase;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnSaveAs;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.TextBox textBoxBnB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cboxTrue;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Button btnSaveQuest;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
    }
}