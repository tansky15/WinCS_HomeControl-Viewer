
namespace SafeHome360_View
{
    partial class main
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
            this.statusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.pBarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.statusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.panHistories = new System.Windows.Forms.Panel();
            this.panImage = new System.Windows.Forms.Panel();
            this.btnF1 = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnF6 = new System.Windows.Forms.Button();
            this.btnF5 = new System.Windows.Forms.Button();
            this.btnF4 = new System.Windows.Forms.Button();
            this.btnF3 = new System.Windows.Forms.Button();
            this.btnF2 = new System.Windows.Forms.Button();
            this.btnP5 = new System.Windows.Forms.Button();
            this.btnP4 = new System.Windows.Forms.Button();
            this.btnP3 = new System.Windows.Forms.Button();
            this.btnP2 = new System.Windows.Forms.Button();
            this.btnP1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusMessage
            // 
            this.statusMessage.Name = "statusMessage";
            this.statusMessage.Size = new System.Drawing.Size(0, 20);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 20);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.statusMessage,
            this.statusText,
            this.pBarStatus,
            this.statusDate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 945);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(772, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusText
            // 
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(0, 20);
            this.statusText.Click += new System.EventHandler(this.statusText_Click);
            // 
            // pBarStatus
            // 
            this.pBarStatus.Name = "pBarStatus";
            this.pBarStatus.Size = new System.Drawing.Size(100, 18);
            // 
            // statusDate
            // 
            this.statusDate.Name = "statusDate";
            this.statusDate.Size = new System.Drawing.Size(41, 20);
            this.statusDate.Text = "Date";
            // 
            // panHistories
            // 
            this.panHistories.Location = new System.Drawing.Point(37, 735);
            this.panHistories.Name = "panHistories";
            this.panHistories.Size = new System.Drawing.Size(665, 198);
            this.panHistories.TabIndex = 8;
            // 
            // panImage
            // 
            this.panImage.BackgroundImage = global::SafeHome360_View.Properties.Resources.Katryne_web_2cc_2019;
            this.panImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panImage.Controls.Add(this.btnF1);
            this.panImage.Controls.Add(this.btnHistory);
            this.panImage.Controls.Add(this.button1);
            this.panImage.Controls.Add(this.btnF6);
            this.panImage.Controls.Add(this.btnF5);
            this.panImage.Controls.Add(this.btnF4);
            this.panImage.Controls.Add(this.btnF3);
            this.panImage.Controls.Add(this.btnF2);
            this.panImage.Controls.Add(this.btnP5);
            this.panImage.Controls.Add(this.btnP4);
            this.panImage.Controls.Add(this.btnP3);
            this.panImage.Controls.Add(this.btnP2);
            this.panImage.Controls.Add(this.btnP1);
            this.panImage.Location = new System.Drawing.Point(37, 12);
            this.panImage.Name = "panImage";
            this.panImage.Size = new System.Drawing.Size(668, 717);
            this.panImage.TabIndex = 7;
            // 
            // btnF1
            // 
            this.btnF1.AutoSize = true;
            this.btnF1.Location = new System.Drawing.Point(319, 656);
            this.btnF1.Name = "btnF1";
            this.btnF1.Size = new System.Drawing.Size(24, 17);
            this.btnF1.TabIndex = 13;
            this.btnF1.Text = "F1";
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHistory.Location = new System.Drawing.Point(522, 679);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(143, 38);
            this.btnHistory.TabIndex = 9;
            this.btnHistory.Text = "Historique";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(499, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "P6";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnF6
            // 
            this.btnF6.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnF6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF6.Location = new System.Drawing.Point(606, 513);
            this.btnF6.Name = "btnF6";
            this.btnF6.Size = new System.Drawing.Size(44, 33);
            this.btnF6.TabIndex = 10;
            this.btnF6.Text = "F6";
            this.btnF6.UseVisualStyleBackColor = false;
            // 
            // btnF5
            // 
            this.btnF5.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnF5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF5.Location = new System.Drawing.Point(74, 524);
            this.btnF5.Name = "btnF5";
            this.btnF5.Size = new System.Drawing.Size(44, 33);
            this.btnF5.TabIndex = 9;
            this.btnF5.Text = "F5";
            this.btnF5.UseVisualStyleBackColor = false;
            // 
            // btnF4
            // 
            this.btnF4.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF4.Location = new System.Drawing.Point(221, 183);
            this.btnF4.Name = "btnF4";
            this.btnF4.Size = new System.Drawing.Size(44, 33);
            this.btnF4.TabIndex = 8;
            this.btnF4.Text = "F4";
            this.btnF4.UseVisualStyleBackColor = false;
            // 
            // btnF3
            // 
            this.btnF3.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnF3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF3.Location = new System.Drawing.Point(14, 409);
            this.btnF3.Name = "btnF3";
            this.btnF3.Size = new System.Drawing.Size(44, 33);
            this.btnF3.TabIndex = 7;
            this.btnF3.Text = "F3";
            this.btnF3.UseVisualStyleBackColor = false;
            // 
            // btnF2
            // 
            this.btnF2.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF2.Location = new System.Drawing.Point(368, 183);
            this.btnF2.Name = "btnF2";
            this.btnF2.Size = new System.Drawing.Size(44, 33);
            this.btnF2.TabIndex = 6;
            this.btnF2.Text = "F2";
            this.btnF2.UseVisualStyleBackColor = false;
            // 
            // btnP5
            // 
            this.btnP5.BackColor = System.Drawing.Color.LightCyan;
            this.btnP5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP5.Location = new System.Drawing.Point(99, 183);
            this.btnP5.Name = "btnP5";
            this.btnP5.Size = new System.Drawing.Size(44, 33);
            this.btnP5.TabIndex = 4;
            this.btnP5.Text = "P5";
            this.btnP5.UseVisualStyleBackColor = false;
            // 
            // btnP4
            // 
            this.btnP4.BackColor = System.Drawing.Color.LightCyan;
            this.btnP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP4.Location = new System.Drawing.Point(246, 345);
            this.btnP4.Name = "btnP4";
            this.btnP4.Size = new System.Drawing.Size(44, 33);
            this.btnP4.TabIndex = 3;
            this.btnP4.Text = "P4";
            this.btnP4.UseVisualStyleBackColor = false;
            // 
            // btnP3
            // 
            this.btnP3.BackColor = System.Drawing.Color.LightCyan;
            this.btnP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP3.Location = new System.Drawing.Point(322, 365);
            this.btnP3.Name = "btnP3";
            this.btnP3.Size = new System.Drawing.Size(44, 33);
            this.btnP3.TabIndex = 2;
            this.btnP3.Text = "P3";
            this.btnP3.UseVisualStyleBackColor = false;
            this.btnP3.Click += new System.EventHandler(this.btnP3_Click);
            // 
            // btnP2
            // 
            this.btnP2.BackColor = System.Drawing.Color.LightCyan;
            this.btnP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP2.Location = new System.Drawing.Point(288, 435);
            this.btnP2.Name = "btnP2";
            this.btnP2.Size = new System.Drawing.Size(44, 33);
            this.btnP2.TabIndex = 1;
            this.btnP2.Text = "P2";
            this.btnP2.UseVisualStyleBackColor = false;
            // 
            // btnP1
            // 
            this.btnP1.BackColor = System.Drawing.Color.LightCyan;
            this.btnP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnP1.Location = new System.Drawing.Point(174, 641);
            this.btnP1.Name = "btnP1";
            this.btnP1.Size = new System.Drawing.Size(44, 33);
            this.btnP1.TabIndex = 0;
            this.btnP1.Text = "P1";
            this.btnP1.UseVisualStyleBackColor = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(772, 971);
            this.Controls.Add(this.panHistories);
            this.Controls.Add(this.panImage);
            this.Controls.Add(this.statusStrip1);
            this.MaximumSize = new System.Drawing.Size(850, 1018);
            this.MinimumSize = new System.Drawing.Size(790, 1018);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de securite";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.Load += new System.EventHandler(this.main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panImage.ResumeLayout(false);
            this.panImage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel statusMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnF6;
        private System.Windows.Forms.Button btnF5;
        private System.Windows.Forms.Button btnF4;
        private System.Windows.Forms.Button btnF3;
        private System.Windows.Forms.Button btnF2;
        private System.Windows.Forms.Button btnP5;
        private System.Windows.Forms.Button btnP4;
        private System.Windows.Forms.Button btnP3;
        private System.Windows.Forms.Button btnP2;
        private System.Windows.Forms.Button btnP1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Panel panImage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusText;
        private System.Windows.Forms.ToolStripProgressBar pBarStatus;
        private System.Windows.Forms.ToolStripStatusLabel statusDate;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Label btnF1;
        private System.Windows.Forms.Panel panHistories;
    }
}

