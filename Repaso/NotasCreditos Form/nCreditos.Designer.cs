namespace Repaso.NotasCreditos_Form
{
    partial class nCreditos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.IDEstudiantetextBox = new System.Windows.Forms.TextBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.BuscarEstudiantebutton = new System.Windows.Forms.Button();
            this.MontoAsignaturanumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ObservacionestextBox = new System.Windows.Forms.TextBox();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Consultabutton = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.PCTnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.IDerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EstudianteIDerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MontoAsignaturaserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ObservacioneserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PCTerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MontoExoneradotextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MontoAsignaturanumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCTnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIDerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoAsignaturaserrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObservacioneserrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCTerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estudiante ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto Asignatura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Observaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Monto";
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(151, 392);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 6;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(232, 392);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 7;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(314, 392);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 8;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(151, 30);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(100, 20);
            this.BuscartextBox.TabIndex = 9;
            // 
            // IDEstudiantetextBox
            // 
            this.IDEstudiantetextBox.Location = new System.Drawing.Point(151, 123);
            this.IDEstudiantetextBox.Name = "IDEstudiantetextBox";
            this.IDEstudiantetextBox.Size = new System.Drawing.Size(165, 20);
            this.IDEstudiantetextBox.TabIndex = 11;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Location = new System.Drawing.Point(151, 89);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.FechadateTimePicker.TabIndex = 12;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(421, 130);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(157, 20);
            this.NombretextBox.TabIndex = 13;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(322, 27);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 15;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // BuscarEstudiantebutton
            // 
            this.BuscarEstudiantebutton.Location = new System.Drawing.Point(322, 114);
            this.BuscarEstudiantebutton.Name = "BuscarEstudiantebutton";
            this.BuscarEstudiantebutton.Size = new System.Drawing.Size(75, 36);
            this.BuscarEstudiantebutton.TabIndex = 16;
            this.BuscarEstudiantebutton.Text = "Buscar";
            this.BuscarEstudiantebutton.UseVisualStyleBackColor = true;
            this.BuscarEstudiantebutton.Click += new System.EventHandler(this.BuscarEstudiantebutton_Click_1);
            // 
            // MontoAsignaturanumericUpDown
            // 
            this.MontoAsignaturanumericUpDown.Location = new System.Drawing.Point(151, 155);
            this.MontoAsignaturanumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.MontoAsignaturanumericUpDown.Name = "MontoAsignaturanumericUpDown";
            this.MontoAsignaturanumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MontoAsignaturanumericUpDown.TabIndex = 17;
            this.MontoAsignaturanumericUpDown.ValueChanged += new System.EventHandler(this.MontoAsignaturanumericUpDown_ValueChanged);
            // 
            // ObservacionestextBox
            // 
            this.ObservacionestextBox.Location = new System.Drawing.Point(151, 192);
            this.ObservacionestextBox.Multiline = true;
            this.ObservacionestextBox.Name = "ObservacionestextBox";
            this.ObservacionestextBox.Size = new System.Drawing.Size(281, 91);
            this.ObservacionestextBox.TabIndex = 18;
            // 
            // MontotextBox
            // 
            this.MontotextBox.Location = new System.Drawing.Point(151, 315);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.ReadOnly = true;
            this.MontotextBox.Size = new System.Drawing.Size(100, 20);
            this.MontotextBox.TabIndex = 19;
            this.MontotextBox.TextChanged += new System.EventHandler(this.MontotextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(418, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(58, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "PCT Beca";
            // 
            // Consultabutton
            // 
            this.Consultabutton.Location = new System.Drawing.Point(449, 26);
            this.Consultabutton.Name = "Consultabutton";
            this.Consultabutton.Size = new System.Drawing.Size(88, 24);
            this.Consultabutton.TabIndex = 20;
            this.Consultabutton.Text = "Consulta";
            this.Consultabutton.UseVisualStyleBackColor = true;
            this.Consultabutton.Click += new System.EventHandler(this.Consultabutton_Click);
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(396, 391);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(75, 23);
            this.Modificarbutton.TabIndex = 21;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // PCTnumericUpDown
            // 
            this.PCTnumericUpDown.Location = new System.Drawing.Point(151, 290);
            this.PCTnumericUpDown.Name = "PCTnumericUpDown";
            this.PCTnumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.PCTnumericUpDown.TabIndex = 22;
            this.PCTnumericUpDown.ValueChanged += new System.EventHandler(this.PCTnumericUpDown_ValueChanged);
            // 
            // IDerrorProvider
            // 
            this.IDerrorProvider.ContainerControl = this;
            // 
            // EstudianteIDerrorProvider
            // 
            this.EstudianteIDerrorProvider.ContainerControl = this;
            // 
            // MontoAsignaturaserrorProvider
            // 
            this.MontoAsignaturaserrorProvider.ContainerControl = this;
            // 
            // ObservacioneserrorProvider
            // 
            this.ObservacioneserrorProvider.ContainerControl = this;
            // 
            // PCTerrorProvider
            // 
            this.PCTerrorProvider.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // MontoExoneradotextBox
            // 
            this.MontoExoneradotextBox.Location = new System.Drawing.Point(151, 341);
            this.MontoExoneradotextBox.Name = "MontoExoneradotextBox";
            this.MontoExoneradotextBox.ReadOnly = true;
            this.MontoExoneradotextBox.Size = new System.Drawing.Size(100, 20);
            this.MontoExoneradotextBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Monto Exonerado";
            // 
            // nCreditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 440);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.MontoExoneradotextBox);
            this.Controls.Add(this.PCTnumericUpDown);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Consultabutton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MontotextBox);
            this.Controls.Add(this.ObservacionestextBox);
            this.Controls.Add(this.MontoAsignaturanumericUpDown);
            this.Controls.Add(this.BuscarEstudiantebutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.IDEstudiantetextBox);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "nCreditos";
            this.Text = "Notas de Credito";
            this.Load += new System.EventHandler(this.nCreditos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MontoAsignaturanumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCTnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIDerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MontoAsignaturaserrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObservacioneserrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCTerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.TextBox IDEstudiantetextBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button BuscarEstudiantebutton;
        private System.Windows.Forms.NumericUpDown MontoAsignaturanumericUpDown;
        private System.Windows.Forms.TextBox ObservacionestextBox;
        private System.Windows.Forms.TextBox MontotextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Consultabutton;
        private System.Windows.Forms.Button Modificarbutton;
        private System.Windows.Forms.NumericUpDown PCTnumericUpDown;
        private System.Windows.Forms.ErrorProvider IDerrorProvider;
        private System.Windows.Forms.ErrorProvider EstudianteIDerrorProvider;
        private System.Windows.Forms.ErrorProvider MontoAsignaturaserrorProvider;
        private System.Windows.Forms.ErrorProvider ObservacioneserrorProvider;
        private System.Windows.Forms.ErrorProvider PCTerrorProvider;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MontoExoneradotextBox;
    }
}