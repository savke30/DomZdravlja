﻿namespace DomZdravlja
{
    partial class UCTekst
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 12);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(35, 13);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "label1";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(107, 8);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(200, 20);
            this.txtValue.TabIndex = 1;
            // 
            // UCTekst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.lblNaziv);
            this.Name = "UCTekst";
            this.Size = new System.Drawing.Size(317, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtValue;
    }
}
