﻿namespace Repaso.Reporte
{
    partial class cReporteNotasCreditos
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
            this.ReporteNotasCreditoscrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // ReporteNotasCreditoscrystalReportViewer
            // 
            this.ReporteNotasCreditoscrystalReportViewer.ActiveViewIndex = -1;
            this.ReporteNotasCreditoscrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReporteNotasCreditoscrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReporteNotasCreditoscrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReporteNotasCreditoscrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.ReporteNotasCreditoscrystalReportViewer.Name = "ReporteNotasCreditoscrystalReportViewer";
            this.ReporteNotasCreditoscrystalReportViewer.Size = new System.Drawing.Size(828, 522);
            this.ReporteNotasCreditoscrystalReportViewer.TabIndex = 0;
            this.ReporteNotasCreditoscrystalReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // cReporteNotasCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 522);
            this.Controls.Add(this.ReporteNotasCreditoscrystalReportViewer);
            this.Name = "cReporteNotasCreditos";
            this.Text = "cReporteNotasCreditos";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReporteNotasCreditoscrystalReportViewer;
    }
}