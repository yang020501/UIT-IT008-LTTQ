﻿
namespace household_management.View
{
    partial class AbsenceForm
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
            this.aViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // aViewer
            // 
            this.aViewer.ActiveViewIndex = -1;
            this.aViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.aViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aViewer.Location = new System.Drawing.Point(0, 0);
            this.aViewer.Name = "aViewer";
            this.aViewer.Size = new System.Drawing.Size(1113, 567);
            this.aViewer.TabIndex = 0;
            // 
            // AbsenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 567);
            this.Controls.Add(this.aViewer);
            this.Name = "AbsenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbsenceForm";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer aViewer;
    }
}