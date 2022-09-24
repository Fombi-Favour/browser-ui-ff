﻿namespace BrowserApp2
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMax = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.btnSettings = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel1.Controls.Add(this.btnMax);
            this.guna2Panel1.Controls.Add(this.btnMin);
            this.guna2Panel1.Controls.Add(this.btnClose);
            this.guna2Panel1.Controls.Add(this.btnSettings);
            this.guna2Panel1.Controls.Add(this.btnRefresh);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1206, 73);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnMax
            // 
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.Location = new System.Drawing.Point(42, 19);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(34, 28);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 6;
            this.btnMax.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.AutoSize = true;
            this.btnMin.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(12, 9);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(31, 39);
            this.btnMin.TabIndex = 7;
            this.btnMin.Text = "-";
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(81, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 34);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSettings.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSettings.ImageRotate = 0F;
            this.btnSettings.ImageSize = new System.Drawing.Size(34, 34);
            this.btnSettings.Location = new System.Drawing.Point(1131, 9);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnSettings.Size = new System.Drawing.Size(52, 49);
            this.btnSettings.TabIndex = 10;
            // 
            // btnRefresh
            // 
            this.btnRefresh.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRefresh.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRefresh.ImageRotate = 0F;
            this.btnRefresh.ImageSize = new System.Drawing.Size(34, 34);
            this.btnRefresh.Location = new System.Drawing.Point(525, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnRefresh.Size = new System.Drawing.Size(52, 49);
            this.btnRefresh.TabIndex = 9;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1206, 724);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Browser App";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox btnMax;
        private System.Windows.Forms.Label btnMin;
        private System.Windows.Forms.Label btnClose;
        private Guna.UI2.WinForms.Guna2ImageButton btnSettings;
        private Guna.UI2.WinForms.Guna2ImageButton btnRefresh;
    }
}

