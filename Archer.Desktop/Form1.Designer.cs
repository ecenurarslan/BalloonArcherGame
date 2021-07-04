namespace Archer.Desktop
{
    partial class Form1
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
            this.bilgiPanel = new System.Windows.Forms.Panel();
            this.kalanOkLabel = new System.Windows.Forms.Label();
            this.okSayisiLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.puanLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.balonPanel = new System.Windows.Forms.Panel();
            this.okcuPanel = new System.Windows.Forms.Panel();
            this.bilgiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.bilgiPanel.Controls.Add(this.kalanOkLabel);
            this.bilgiPanel.Controls.Add(this.okSayisiLabel);
            this.bilgiPanel.Controls.Add(this.label2);
            this.bilgiPanel.Controls.Add(this.puanLabel);
            this.bilgiPanel.Controls.Add(this.timeLabel);
            this.bilgiPanel.Controls.Add(this.infoLabel);
            this.bilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bilgiPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bilgiPanel.Location = new System.Drawing.Point(0, 0);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(1380, 104);
            this.bilgiPanel.TabIndex = 0;
            // 
            // kalanOkLabel
            // 
            this.kalanOkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kalanOkLabel.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kalanOkLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.kalanOkLabel.Location = new System.Drawing.Point(721, 54);
            this.kalanOkLabel.Name = "kalanOkLabel";
            this.kalanOkLabel.Size = new System.Drawing.Size(288, 42);
            this.kalanOkLabel.TabIndex = 6;
            this.kalanOkLabel.Text = "Kalan Ok:";
            this.kalanOkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // okSayisiLabel
            // 
            this.okSayisiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.okSayisiLabel.Font = new System.Drawing.Font("Cambria", 16.2F);
            this.okSayisiLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.okSayisiLabel.Location = new System.Drawing.Point(1026, 47);
            this.okSayisiLabel.Name = "okSayisiLabel";
            this.okSayisiLabel.Size = new System.Drawing.Size(107, 56);
            this.okSayisiLabel.TabIndex = 5;
            this.okSayisiLabel.Text = "Sınırsız";
            this.okSayisiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(765, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Puan:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // puanLabel
            // 
            this.puanLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.puanLabel.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puanLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.puanLabel.Location = new System.Drawing.Point(902, 0);
            this.puanLabel.Name = "puanLabel";
            this.puanLabel.Size = new System.Drawing.Size(231, 56);
            this.puanLabel.TabIndex = 3;
            this.puanLabel.Text = "0";
            this.puanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.timeLabel.Location = new System.Drawing.Point(1113, 22);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(231, 56);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "0:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infoLabel.ForeColor = System.Drawing.Color.GhostWhite;
            this.infoLabel.Location = new System.Drawing.Point(3, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(647, 168);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Oyunu başlatmak için Enter tuşuna basın\r\nOkçuyu hareket ettirmek için yukarı aşağ" +
    "ı yön yuşlarına basın\r\nOk atmak için Boşluk tuşuna basın\r\n\r\n\r\n\r\n";
            this.infoLabel.Click += new System.EventHandler(this.infoLabel_Click);
            // 
            // balonPanel
            // 
            this.balonPanel.BackColor = System.Drawing.Color.Transparent;
            this.balonPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.balonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.balonPanel.Location = new System.Drawing.Point(208, 104);
            this.balonPanel.Name = "balonPanel";
            this.balonPanel.Size = new System.Drawing.Size(1172, 558);
            this.balonPanel.TabIndex = 2;
            // 
            // okcuPanel
            // 
            this.okcuPanel.BackColor = System.Drawing.Color.Transparent;
            this.okcuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.okcuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.okcuPanel.Location = new System.Drawing.Point(0, 104);
            this.okcuPanel.Name = "okcuPanel";
            this.okcuPanel.Size = new System.Drawing.Size(208, 558);
            this.okcuPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1380, 662);
            this.Controls.Add(this.balonPanel);
            this.Controls.Add(this.okcuPanel);
            this.Controls.Add(this.bilgiPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Okçuluk Oyunu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.bilgiPanel.ResumeLayout(false);
            this.bilgiPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bilgiPanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Panel okcuPanel;
        private System.Windows.Forms.Panel balonPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label puanLabel;
        private System.Windows.Forms.Label okSayisiLabel;
        private System.Windows.Forms.Label kalanOkLabel;
    }
}

