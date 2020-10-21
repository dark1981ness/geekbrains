namespace Less7Ex1
{
    partial class CsvToXml
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnOpenCsv = new System.Windows.Forms.Button();
            this.btnSaveXml = new System.Windows.Forms.Button();
            this.lblPathToCsv = new System.Windows.Forms.Label();
            this.lblPathToXml = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.lblPathToXml);
            this.panel1.Controls.Add(this.lblPathToCsv);
            this.panel1.Controls.Add(this.btnSaveXml);
            this.panel1.Controls.Add(this.btnOpenCsv);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 229);
            this.panel1.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeader.Location = new System.Drawing.Point(210, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(115, 20);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "«CSV to XML»";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenCsv
            // 
            this.btnOpenCsv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpenCsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnOpenCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpenCsv.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOpenCsv.Location = new System.Drawing.Point(12, 45);
            this.btnOpenCsv.Name = "btnOpenCsv";
            this.btnOpenCsv.Size = new System.Drawing.Size(77, 32);
            this.btnOpenCsv.TabIndex = 2;
            this.btnOpenCsv.Text = "CSV";
            this.btnOpenCsv.UseVisualStyleBackColor = false;
            this.btnOpenCsv.Click += new System.EventHandler(this.btnOpenCsv_Click);
            // 
            // btnSaveXml
            // 
            this.btnSaveXml.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveXml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnSaveXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveXml.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveXml.Location = new System.Drawing.Point(12, 83);
            this.btnSaveXml.Name = "btnSaveXml";
            this.btnSaveXml.Size = new System.Drawing.Size(77, 32);
            this.btnSaveXml.TabIndex = 3;
            this.btnSaveXml.Text = "Save";
            this.btnSaveXml.UseVisualStyleBackColor = false;
            this.btnSaveXml.Click += new System.EventHandler(this.btnSaveXml_Click);
            // 
            // lblPathToCsv
            // 
            this.lblPathToCsv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPathToCsv.AutoSize = true;
            this.lblPathToCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPathToCsv.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPathToCsv.Location = new System.Drawing.Point(95, 51);
            this.lblPathToCsv.Name = "lblPathToCsv";
            this.lblPathToCsv.Size = new System.Drawing.Size(107, 20);
            this.lblPathToCsv.TabIndex = 4;
            this.lblPathToCsv.Text = "«CSV файл»";
            this.lblPathToCsv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPathToXml
            // 
            this.lblPathToXml.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPathToXml.AutoSize = true;
            this.lblPathToXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPathToXml.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPathToXml.Location = new System.Drawing.Point(95, 89);
            this.lblPathToXml.Name = "lblPathToXml";
            this.lblPathToXml.Size = new System.Drawing.Size(107, 20);
            this.lblPathToXml.TabIndex = 5;
            this.lblPathToXml.Text = "«XML файл»";
            this.lblPathToXml.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResult.Location = new System.Drawing.Point(210, 166);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(106, 20);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "«результат»";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CsvToXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(545, 229);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CsvToXml";
            this.Text = "CsvToXml";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnSaveXml;
        private System.Windows.Forms.Button btnOpenCsv;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPathToXml;
        private System.Windows.Forms.Label lblPathToCsv;
    }
}