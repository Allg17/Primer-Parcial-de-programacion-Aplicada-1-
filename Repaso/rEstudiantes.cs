using Repaso.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Repaso
{
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            PersonaIdtextBox.Clear();
            FechadateTimePicker.Value = DateTime.Now;
            NombrestextBox.Clear();
            MontonumericUpDown.Value = 0;
            txtObservacion.Clear();

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante = LlenaClase();

            if (BLL.EstudiantesBLL.Guardar(estudiante))
                MessageBox.Show("Estudiante Guardado");
        }

        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes();
            int a;
            int.TryParse(PersonaIdtextBox.Text, out a);
            estudiante.EstudianteID = a;
            estudiante.Nombre = NombrestextBox.Text;
            estudiante.Monto = (decimal)MontonumericUpDown.Value;
            estudiante.Observaciones = txtObservacion.Text;
            estudiante.Fecha = FechadateTimePicker.Value;
            return estudiante;
        }

        private void Consulta_Click(object sender, EventArgs e)
        {
            CEstudiantes Abrir= new CEstudiantes();
            Abrir.Show();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes eliminar = new Estudiantes();

            int ID;
            int.TryParse(PersonaIdtextBox.Text, out ID);

            if (BLL.EstudiantesBLL.Eliminar(ID))
            {
                MessageBox.Show("Eliminado");
            }
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            if (BLL.EstudiantesBLL.Modificar(LlenaClase()))
                MessageBox.Show("Modificado");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int ID;
            Estudiantes estudiante = new Estudiantes();
            int.TryParse(PersonaIdtextBox.Text, out ID);

            estudiante = BLL.EstudiantesBLL.Buscar(ID);

            if (estudiante != null)
            {
                NombrestextBox.Text = estudiante.Nombre;
                MontonumericUpDown.Value = Convert.ToDecimal(estudiante.Monto);
                txtObservacion.Text = estudiante.Observaciones;
                FechadateTimePicker.Value = estudiante.Fecha;

            }
            else
            {
                MessageBox.Show("Persona No encontada");
            }
        }

        private void NotasCrditobutton_Click(object sender, EventArgs e)
        {
            NotasCreditos_Form.nCreditos creditos = new NotasCreditos_Form.nCreditos();
            creditos.Show();
        }
    }
}
