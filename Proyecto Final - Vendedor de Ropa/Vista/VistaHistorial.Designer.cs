
namespace Presenter
{
    partial class VerHistorial
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
            this.textBoxHistorial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxHistorial
            // 
            this.textBoxHistorial.Location = new System.Drawing.Point(56, 28);
            this.textBoxHistorial.Multiline = true;
            this.textBoxHistorial.Name = "textBoxHistorial";
            this.textBoxHistorial.ReadOnly = true;
            this.textBoxHistorial.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxHistorial.Size = new System.Drawing.Size(703, 374);
            this.textBoxHistorial.TabIndex = 1;
            // 
            // VerHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxHistorial);
            this.Name = "VerHistorial";
            this.Text = "HistorialCotizaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxHistorial;
    }
}