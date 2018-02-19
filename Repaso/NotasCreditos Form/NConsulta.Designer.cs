namespace Repaso.NotasCreditos_Form
{
    partial class NConsulta
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.FiltrarcomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.PersonasdataGridView = new System.Windows.Forms.DataGridView();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.MontoExoneradobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PersonasdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Modo a buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = " Filtro";
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(149, 33);
            this.CriteriotextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(211, 20);
            this.CriteriotextBox.TabIndex = 37;
            // 
            // FiltrarcomboBox
            // 
            this.FiltrarcomboBox.FormattingEnabled = true;
            this.FiltrarcomboBox.Items.AddRange(new object[] {
            "Todos",
            "Nota ID"});
            this.FiltrarcomboBox.Location = new System.Drawing.Point(54, 33);
            this.FiltrarcomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.FiltrarcomboBox.Name = "FiltrarcomboBox";
            this.FiltrarcomboBox.Size = new System.Drawing.Size(92, 21);
            this.FiltrarcomboBox.TabIndex = 36;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(398, 20);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(97, 45);
            this.Buscarbutton.TabIndex = 35;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // PersonasdataGridView
            // 
            this.PersonasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonasdataGridView.Location = new System.Drawing.Point(11, 84);
            this.PersonasdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.PersonasdataGridView.Name = "PersonasdataGridView";
            this.PersonasdataGridView.RowTemplate.Height = 24;
            this.PersonasdataGridView.Size = new System.Drawing.Size(812, 346);
            this.PersonasdataGridView.TabIndex = 34;
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.Location = new System.Drawing.Point(511, 20);
            this.Imprimirbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(97, 45);
            this.Imprimirbutton.TabIndex = 40;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // MontoExoneradobutton
            // 
            this.MontoExoneradobutton.Location = new System.Drawing.Point(612, 20);
            this.MontoExoneradobutton.Margin = new System.Windows.Forms.Padding(2);
            this.MontoExoneradobutton.Name = "MontoExoneradobutton";
            this.MontoExoneradobutton.Size = new System.Drawing.Size(97, 45);
            this.MontoExoneradobutton.TabIndex = 41;
            this.MontoExoneradobutton.Text = "Monto Exonerado";
            this.MontoExoneradobutton.UseVisualStyleBackColor = true;
            this.MontoExoneradobutton.Click += new System.EventHandler(this.MontoExoneradobutton_Click);
            // 
            // NConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 468);
            this.Controls.Add(this.MontoExoneradobutton);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.FiltrarcomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.PersonasdataGridView);
            this.MaximizeBox = false;
            this.Name = "NConsulta";
            this.Text = "NConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.PersonasdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.ComboBox FiltrarcomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DataGridView PersonasdataGridView;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Button MontoExoneradobutton;
    }
}