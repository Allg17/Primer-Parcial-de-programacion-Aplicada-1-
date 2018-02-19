namespace Repaso
{
    partial class rEstudiantes
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
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.Observacioneslabel = new System.Windows.Forms.Label();
            this.MontonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Montolabel = new System.Windows.Forms.Label();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Consulta = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.PersonaIdtextBox = new System.Windows.Forms.TextBox();
            this.NotasCrditobutton = new System.Windows.Forms.Button();
            this.NombreerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MontoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ObservacioneserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.IDEstudianteserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObservacioneserrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDEstudianteserrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(360, 306);
            this.Modificarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(86, 37);
            this.Modificarbutton.TabIndex = 48;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(139, 194);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(217, 95);
            this.txtObservacion.TabIndex = 47;
            // 
            // Observacioneslabel
            // 
            this.Observacioneslabel.AutoSize = true;
            this.Observacioneslabel.Location = new System.Drawing.Point(71, 168);
            this.Observacioneslabel.Name = "Observacioneslabel";
            this.Observacioneslabel.Size = new System.Drawing.Size(78, 13);
            this.Observacioneslabel.TabIndex = 46;
            this.Observacioneslabel.Text = "Observaciones";
            // 
            // MontonumericUpDown
            // 
            this.MontonumericUpDown.DecimalPlaces = 2;
            this.MontonumericUpDown.Location = new System.Drawing.Point(139, 130);
            this.MontonumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MontonumericUpDown.Name = "MontonumericUpDown";
            this.MontonumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MontonumericUpDown.TabIndex = 45;
            // 
            // Montolabel
            // 
            this.Montolabel.AutoSize = true;
            this.Montolabel.Location = new System.Drawing.Point(67, 137);
            this.Montolabel.Name = "Montolabel";
            this.Montolabel.Size = new System.Drawing.Size(37, 13);
            this.Montolabel.TabIndex = 44;
            this.Montolabel.Text = "Monto";
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Location = new System.Drawing.Point(67, 86);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(37, 13);
            this.Fechalabel.TabIndex = 43;
            this.Fechalabel.Text = "Fecha";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Location = new System.Drawing.Point(139, 80);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(255, 20);
            this.FechadateTimePicker.TabIndex = 42;
            // 
            // Consulta
            // 
            this.Consulta.Location = new System.Drawing.Point(347, 44);
            this.Consulta.Margin = new System.Windows.Forms.Padding(2);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(64, 27);
            this.Consulta.TabIndex = 41;
            this.Consulta.Text = "Consulta";
            this.Consulta.UseVisualStyleBackColor = true;
            this.Consulta.Click += new System.EventHandler(this.Consulta_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(84, 306);
            this.NuevoButton.Margin = new System.Windows.Forms.Padding(2);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(86, 37);
            this.NuevoButton.TabIndex = 40;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(254, 44);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(64, 27);
            this.Buscarbutton.TabIndex = 39;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(270, 306);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(86, 37);
            this.Eliminarbutton.TabIndex = 38;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(177, 306);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(86, 37);
            this.Guardarbutton.TabIndex = 37;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "IDEstudiante";
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(139, 105);
            this.NombrestextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(272, 20);
            this.NombrestextBox.TabIndex = 34;
            // 
            // PersonaIdtextBox
            // 
            this.PersonaIdtextBox.Location = new System.Drawing.Point(139, 48);
            this.PersonaIdtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PersonaIdtextBox.Name = "PersonaIdtextBox";
            this.PersonaIdtextBox.Size = new System.Drawing.Size(101, 20);
            this.PersonaIdtextBox.TabIndex = 33;
            // 
            // NotasCrditobutton
            // 
            this.NotasCrditobutton.Location = new System.Drawing.Point(291, 132);
            this.NotasCrditobutton.Name = "NotasCrditobutton";
            this.NotasCrditobutton.Size = new System.Drawing.Size(120, 23);
            this.NotasCrditobutton.TabIndex = 49;
            this.NotasCrditobutton.Text = "Notas de credito";
            this.NotasCrditobutton.UseVisualStyleBackColor = true;
            this.NotasCrditobutton.Click += new System.EventHandler(this.NotasCrditobutton_Click);
            // 
            // NombreerrorProvider
            // 
            this.NombreerrorProvider.ContainerControl = this;
            // 
            // MontoerrorProvider
            // 
            this.MontoerrorProvider.ContainerControl = this;
            // 
            // ObservacioneserrorProvider
            // 
            this.ObservacioneserrorProvider.ContainerControl = this;
            // 
            // IDEstudianteserrorProvider
            // 
            this.IDEstudianteserrorProvider.ContainerControl = this;
            // 
            // rEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 387);
            this.Controls.Add(this.NotasCrditobutton);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.Observacioneslabel);
            this.Controls.Add(this.MontonumericUpDown);
            this.Controls.Add(this.Montolabel);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.Consulta);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombrestextBox);
            this.Controls.Add(this.PersonaIdtextBox);
            this.MaximizeBox = false;
            this.Name = "rEstudiantes";
            this.Text = "Registro de Incripcion";
            ((System.ComponentModel.ISupportInitialize)(this.MontonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObservacioneserrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDEstudianteserrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label Observacioneslabel;
        private System.Windows.Forms.NumericUpDown MontonumericUpDown;
        private System.Windows.Forms.Label Montolabel;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Button Consulta;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombrestextBox;
        private System.Windows.Forms.TextBox PersonaIdtextBox;
        private System.Windows.Forms.Button NotasCrditobutton;
        private System.Windows.Forms.ErrorProvider NombreerrorProvider;
        private System.Windows.Forms.ErrorProvider MontoerrorProvider;
        private System.Windows.Forms.ErrorProvider ObservacioneserrorProvider;
        private System.Windows.Forms.ErrorProvider IDEstudianteserrorProvider;
    }
}

