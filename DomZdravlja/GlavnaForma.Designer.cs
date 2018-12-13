﻿namespace DomZdravlja
{
    partial class GlavnaForma
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelGlavniTab = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIzlaz = new Bunifu.Framework.UI.BunifuImageButton();
            this.panelTabControl1 = new DomZdravlja.PanelTabControl();
            this.panelTabControl2 = new DomZdravlja.PanelTabControl();
            this.panelTabControl3 = new DomZdravlja.PanelTabControl();
            this.panelTabControl4 = new DomZdravlja.PanelTabControl();
            this.panelTabControl5 = new DomZdravlja.PanelTabControl();
            this.panel1.SuspendLayout();
            this.panelGlavniTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIzlaz)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.panel1.Controls.Add(this.panelGlavniTab);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 800);
            this.panel1.TabIndex = 0;
            // 
            // panelGlavniTab
            // 
            this.panelGlavniTab.Controls.Add(this.panelTabControl1);
            this.panelGlavniTab.Controls.Add(this.panelTabControl2);
            this.panelGlavniTab.Controls.Add(this.panelTabControl3);
            this.panelGlavniTab.Controls.Add(this.panelTabControl4);
            this.panelGlavniTab.Controls.Add(this.panelTabControl5);
            this.panelGlavniTab.Location = new System.Drawing.Point(12, 135);
            this.panelGlavniTab.Name = "panelGlavniTab";
            this.panelGlavniTab.Size = new System.Drawing.Size(266, 653);
            this.panelGlavniTab.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "DomZdravlja";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.SystemColors.Control;
            this.btnIzlaz.Image = ((System.Drawing.Image)(resources.GetObject("btnIzlaz.Image")));
            this.btnIzlaz.ImageActive = null;
            this.btnIzlaz.Location = new System.Drawing.Point(1163, 12);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(25, 25);
            this.btnIzlaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnIzlaz.TabIndex = 1;
            this.btnIzlaz.TabStop = false;
            this.btnIzlaz.Zoom = 10;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // panelTabControl1
            // 
            this.panelTabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.panelTabControl1.Ikona = ((System.Drawing.Image)(resources.GetObject("panelTabControl1.Ikona")));
            this.panelTabControl1.Location = new System.Drawing.Point(3, 3);
            this.panelTabControl1.Name = "panelTabControl1";
            this.panelTabControl1.Naziv = "RECEPCIJA";
            this.panelTabControl1.Size = new System.Drawing.Size(266, 54);
            this.panelTabControl1.TabIndex = 0;
            // 
            // panelTabControl2
            // 
            this.panelTabControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.panelTabControl2.Ikona = ((System.Drawing.Image)(resources.GetObject("panelTabControl2.Ikona")));
            this.panelTabControl2.Location = new System.Drawing.Point(3, 63);
            this.panelTabControl2.Name = "panelTabControl2";
            this.panelTabControl2.Naziv = "RECEPCIJA";
            this.panelTabControl2.Size = new System.Drawing.Size(266, 54);
            this.panelTabControl2.TabIndex = 1;
            // 
            // panelTabControl3
            // 
            this.panelTabControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.panelTabControl3.Ikona = ((System.Drawing.Image)(resources.GetObject("panelTabControl3.Ikona")));
            this.panelTabControl3.Location = new System.Drawing.Point(3, 123);
            this.panelTabControl3.Name = "panelTabControl3";
            this.panelTabControl3.Naziv = "RECEPCIJA";
            this.panelTabControl3.Size = new System.Drawing.Size(266, 54);
            this.panelTabControl3.TabIndex = 2;
            // 
            // panelTabControl4
            // 
            this.panelTabControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.panelTabControl4.Ikona = ((System.Drawing.Image)(resources.GetObject("panelTabControl4.Ikona")));
            this.panelTabControl4.Location = new System.Drawing.Point(3, 183);
            this.panelTabControl4.Name = "panelTabControl4";
            this.panelTabControl4.Naziv = "RECEPCIJA";
            this.panelTabControl4.Size = new System.Drawing.Size(266, 54);
            this.panelTabControl4.TabIndex = 3;
            // 
            // panelTabControl5
            // 
            this.panelTabControl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(67)))), ((int)(((byte)(127)))));
            this.panelTabControl5.Ikona = ((System.Drawing.Image)(resources.GetObject("panelTabControl5.Ikona")));
            this.panelTabControl5.Location = new System.Drawing.Point(3, 243);
            this.panelTabControl5.Name = "panelTabControl5";
            this.panelTabControl5.Naziv = "RECEPCIJA";
            this.panelTabControl5.Size = new System.Drawing.Size(266, 54);
            this.panelTabControl5.TabIndex = 4;
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GlavnaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlavnaForma";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelGlavniTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnIzlaz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnIzlaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel panelGlavniTab;
        private PanelTabControl panelTabControl1;
        private PanelTabControl panelTabControl2;
        private PanelTabControl panelTabControl3;
        private PanelTabControl panelTabControl4;
        private PanelTabControl panelTabControl5;
    }
}