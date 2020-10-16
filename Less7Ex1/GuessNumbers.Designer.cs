namespace Less7Ex1
{
    partial class GuessNumbers
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblUserNumber = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblTryCount = new System.Windows.Forms.Label();
            this.lblTryHeader = new System.Windows.Forms.Label();
            this.lblHiddenNumber = new System.Windows.Forms.Label();
            this.lblCompareResult = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnUserTurn = new System.Windows.Forms.Button();
            this.lblTextBoxHeader = new System.Windows.Forms.Label();
            this.userNumberTextBox = new System.Windows.Forms.TextBox();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHeader.Location = new System.Drawing.Point(13, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(420, 60);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Компьютер выберет произвольное число от 0 до 100.\r\nПопробуйте отгадать его за отв" +
    "еденное количество\r\nпопыток.\r\n";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnStartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartGame.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStartGame.Location = new System.Drawing.Point(17, 82);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStartGame.Size = new System.Drawing.Size(155, 46);
            this.btnStartGame.TabIndex = 4;
            this.btnStartGame.Text = "Поехали!!!";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.lblUserNumber);
            this.mainPanel.Controls.Add(this.btnRestart);
            this.mainPanel.Controls.Add(this.lblTryCount);
            this.mainPanel.Controls.Add(this.lblTryHeader);
            this.mainPanel.Controls.Add(this.lblHiddenNumber);
            this.mainPanel.Controls.Add(this.lblCompareResult);
            this.mainPanel.Controls.Add(this.lblResult);
            this.mainPanel.Controls.Add(this.btnUserTurn);
            this.mainPanel.Controls.Add(this.lblTextBoxHeader);
            this.mainPanel.Controls.Add(this.userNumberTextBox);
            this.mainPanel.Controls.Add(this.btnStartGame);
            this.mainPanel.Controls.Add(this.lblHeader);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(465, 480);
            this.mainPanel.TabIndex = 5;
            // 
            // lblUserNumber
            // 
            this.lblUserNumber.AutoSize = true;
            this.lblUserNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserNumber.Location = new System.Drawing.Point(137, 209);
            this.lblUserNumber.Name = "lblUserNumber";
            this.lblUserNumber.Size = new System.Drawing.Size(0, 63);
            this.lblUserNumber.TabIndex = 16;
            this.lblUserNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestart
            // 
            this.btnRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnRestart.Enabled = false;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRestart.Location = new System.Drawing.Point(301, 82);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRestart.Size = new System.Drawing.Size(155, 46);
            this.btnRestart.TabIndex = 15;
            this.btnRestart.Text = "Сброс";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblTryCount
            // 
            this.lblTryCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTryCount.AutoSize = true;
            this.lblTryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTryCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTryCount.Location = new System.Drawing.Point(190, 384);
            this.lblTryCount.Name = "lblTryCount";
            this.lblTryCount.Size = new System.Drawing.Size(0, 69);
            this.lblTryCount.TabIndex = 14;
            // 
            // lblTryHeader
            // 
            this.lblTryHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTryHeader.AutoSize = true;
            this.lblTryHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTryHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTryHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTryHeader.Location = new System.Drawing.Point(156, 364);
            this.lblTryHeader.Name = "lblTryHeader";
            this.lblTryHeader.Size = new System.Drawing.Size(151, 20);
            this.lblTryHeader.TabIndex = 13;
            this.lblTryHeader.Text = "Осталось попыток";
            // 
            // lblHiddenNumber
            // 
            this.lblHiddenNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHiddenNumber.AutoSize = true;
            this.lblHiddenNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHiddenNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHiddenNumber.Location = new System.Drawing.Point(333, 209);
            this.lblHiddenNumber.Name = "lblHiddenNumber";
            this.lblHiddenNumber.Size = new System.Drawing.Size(0, 63);
            this.lblHiddenNumber.TabIndex = 12;
            this.lblHiddenNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompareResult
            // 
            this.lblCompareResult.AutoSize = true;
            this.lblCompareResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCompareResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCompareResult.Location = new System.Drawing.Point(255, 209);
            this.lblCompareResult.Name = "lblCompareResult";
            this.lblCompareResult.Size = new System.Drawing.Size(57, 63);
            this.lblCompareResult.TabIndex = 11;
            this.lblCompareResult.Text = "?";
            this.lblCompareResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResult.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResult.Location = new System.Drawing.Point(340, 187);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(93, 20);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Результат:";
            // 
            // btnUserTurn
            // 
            this.btnUserTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.btnUserTurn.Enabled = false;
            this.btnUserTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUserTurn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUserTurn.Location = new System.Drawing.Point(18, 290);
            this.btnUserTurn.Name = "btnUserTurn";
            this.btnUserTurn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUserTurn.Size = new System.Drawing.Size(113, 35);
            this.btnUserTurn.TabIndex = 7;
            this.btnUserTurn.Text = "Жмяк";
            this.btnUserTurn.UseVisualStyleBackColor = false;
            this.btnUserTurn.Click += new System.EventHandler(this.btnUserTurn_Click);
            // 
            // lblTextBoxHeader
            // 
            this.lblTextBoxHeader.AutoSize = true;
            this.lblTextBoxHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextBoxHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTextBoxHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTextBoxHeader.Location = new System.Drawing.Point(13, 187);
            this.lblTextBoxHeader.Name = "lblTextBoxHeader";
            this.lblTextBoxHeader.Size = new System.Drawing.Size(129, 20);
            this.lblTextBoxHeader.TabIndex = 6;
            this.lblTextBoxHeader.Text = "Введите число:";
            // 
            // userNumberTextBox
            // 
            this.userNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.userNumberTextBox.Enabled = false;
            this.userNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNumberTextBox.ForeColor = System.Drawing.SystemColors.Control;
            this.userNumberTextBox.Location = new System.Drawing.Point(17, 206);
            this.userNumberTextBox.MaxLength = 3;
            this.userNumberTextBox.Name = "userNumberTextBox";
            this.userNumberTextBox.Size = new System.Drawing.Size(114, 68);
            this.userNumberTextBox.TabIndex = 5;
            this.userNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userNumberTextBox.TextChanged += new System.EventHandler(this.userNumberTextBox_TextChanged);
            // 
            // GuessNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(465, 480);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuessNumbers";
            this.Text = "GuessNumbers";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblTextBoxHeader;
        private System.Windows.Forms.TextBox userNumberTextBox;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnUserTurn;
        private System.Windows.Forms.Label lblHiddenNumber;
        private System.Windows.Forms.Label lblCompareResult;
        private System.Windows.Forms.Label lblTryCount;
        private System.Windows.Forms.Label lblTryHeader;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblUserNumber;
    }
}