﻿
namespace SafeHome360_View
{
    partial class Histories
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
            this.histList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // histList
            // 
            this.histList.FormattingEnabled = true;
            this.histList.ItemHeight = 16;
            this.histList.Location = new System.Drawing.Point(2, 11);
            this.histList.Name = "histList";
            this.histList.Size = new System.Drawing.Size(841, 212);
            this.histList.TabIndex = 0;
            // 
            // Histories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 239);
            this.Controls.Add(this.histList);
            this.Name = "Histories";
            this.Text = "Histories";
            this.Load += new System.EventHandler(this.Histories_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox histList;
    }
}