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
            MontoExoneradotextBox.Clear(); 
            txtObservacion.Clear();
            LimpiarProvider();
        }
        private void LimpiarProvider()
        {
            NombreerrorProvider.Clear();
            MontoerrorProvider.Clear();
            ObservacioneserrorProvider.Clear();
            IDEstudianteserrorProvider.Clear();
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante = LlenaClase();
            LimpiarProvider();
            if (PersonaIdtextBox.Text == string.Empty)
            {


                if (Validar() == false)
                {
                    return;
                }
                if (BLL.EstudiantesBLL.Guardar(estudiante))
                    MessageBox.Show("Estudiante Guardado");
            }
            else
            {
                LimpiarProvider();
                if (IdProvider() == false)
                {
                    return;
                }

                if (BLL.EstudiantesBLL.Modificar(LlenaClase()))
                    MessageBox.Show("Modificado");
            }
        }
        private bool Validar()
        {
            bool paso = false;
            int abrir = 0;
            if (NombrestextBox.Text == String.Empty)
            {
                
                NombreerrorProvider.SetError(NombrestextBox, "Debe llenar este campo");
                abrir = 1;
            }
            if(txtObservacion.Text == String.Empty)
            {
                ObservacioneserrorProvider.SetError(txtObservacion, "Debe llenar este campo");
                abrir = 1;
            }
            if(abrir ==1)
            {
                MessageBox.Show("Debe llenar los campos especificados");
            }
            else
            {
                paso = true;
            }
            return paso;
        }
        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes();
            int a;
            int.TryParse(PersonaIdtextBox.Text, out a);
            estudiante.EstudianteID = a;
            estudiante.Nombre = NombrestextBox.Text;
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
            LimpiarProvider();
            int ID;
            int.TryParse(PersonaIdtextBox.Text, out ID);
            if (IdProvider() == false)
            {
                return;
            }
            if (BLL.EstudiantesBLL.Eliminar(ID))
            {
                MessageBox.Show("Eliminado");
            }
        }

    
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int ID;
            LimpiarProvider();
            if(IdProvider()==false)
            {
                return;
            }
            Estudiantes estudiante = new Estudiantes();
            int.TryParse(PersonaIdtextBox.Text, out ID);

            estudiante = BLL.EstudiantesBLL.Buscar(ID);

            if (estudiante != null)
            {
                NombrestextBox.Text = estudiante.Nombre;
                MontoExoneradotextBox.Text = estudiante.Monto.ToString();
                txtObservacion.Text = estudiante.Observaciones;
                FechadateTimePicker.Value = estudiante.Fecha;

            }
            else
            {
                MessageBox.Show("Persona No encontada");
            }
        }
        private bool IdProvider()
        {
            bool paso = false;
            if (PersonaIdtextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe llenar el campo indicado!!");
                IDEstudianteserrorProvider.SetError(PersonaIdtextBox, "Debe llenar el campo");
                
            }
            else
            {
                paso = true;
            }
            return paso;

        }

        private void NotasCrditobutton_Click(object sender, EventArgs e)
        {
            NotasCreditos_Form.nCreditos creditos = new NotasCreditos_Form.nCreditos();
            creditos.Show();
        }
    }
}
