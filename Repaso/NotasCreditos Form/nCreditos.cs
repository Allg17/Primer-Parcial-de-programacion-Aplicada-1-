using Repaso.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Repaso.NotasCreditos_Form
{
    public partial class nCreditos : Form
    {
        public nCreditos()
        {
            InitializeComponent();
        }

       

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int ID;
            NotasCredito Nota = new NotasCredito();
            Estudiantes estudiantes = new Estudiantes();
            int.TryParse(BuscartextBox.Text, out ID);

            Nota = BLL.NotasCreditoBLL.Buscar(ID);

            if (Nota != null)
            {
                FechadateTimePicker.Value = Nota.Fecha;
                IDEstudiantetextBox.Text = Nota.EstudianteID.ToString();
                MontoAsignaturanumericUpDown.Value = Convert.ToDecimal(Nota.MontoAsignatura);
                PCTBECAtextBox.Text = Nota.PctBeca.ToString();
                ObservacionestextBox.Text = Nota.Observaciones;
                MontotextBox.Text = Nota.Monto.ToString();
     
                if(BLL.EstudiantesBLL.Buscar(Nota.EstudianteID)!=null)
                {
                    estudiantes = BLL.EstudiantesBLL.Buscar(Nota.EstudianteID);
                    NombretextBox.Text = estudiantes.Nombre;
                }
                




            }
            else
            {
                MessageBox.Show("Persona No encontada");
            }
        }

        private void nCreditos_Load(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            FechadateTimePicker.Value = DateTime.Now; ;
            IDEstudiantetextBox.Clear();
            MontoAsignaturanumericUpDown.Value = 0;
            PCTBECAtextBox.Clear();
            ObservacionestextBox.Clear();
            MontotextBox.Clear();
            BuscartextBox.Clear();
            NombretextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
             NotasCredito Notas = LlenaClase();

            if (BLL.NotasCreditoBLL.Guardar(Notas))
                MessageBox.Show("Estudiante Guardado");
        }


        private NotasCredito LlenaClase()
        {
            NotasCredito Nota = new NotasCredito();
            int a,b;
            float p = 0,MontoFinal;

            p = Convert.ToSingle(PCTBECAtextBox.Text) / 100;
            int.TryParse(BuscartextBox.Text, out a);
            Nota.NotasID = a;
            Nota.Fecha = FechadateTimePicker.Value ;
            int.TryParse(IDEstudiantetextBox.Text, out b);
            Nota.EstudianteID = b;
            Nota.MontoAsignatura = MontoAsignaturanumericUpDown.Value ;
            Nota.PctBeca = p;
            Nota.Observaciones = ObservacionestextBox.Text ;
            MontoFinal = Convert.ToSingle(Nota.MontoAsignatura);
            MontoFinal *= Nota.PctBeca;
            Nota.Monto =Convert.ToDecimal( MontoFinal);

            return Nota;

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            NotasCredito Nota = new NotasCredito();

            int ID;
            int.TryParse(BuscartextBox.Text, out ID);

            if (BLL.NotasCreditoBLL.Eliminar(ID))
            {
                MessageBox.Show("Eliminado");
            }
        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            NotasCreditos_Form.NConsulta abrir = new NotasCreditos_Form.NConsulta();
            abrir.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int ID;
            Estudiantes estudiante = new Estudiantes();
            int.TryParse(IDEstudiantetextBox.Text, out ID);

            estudiante = BLL.EstudiantesBLL.Buscar(ID);

            if (estudiante != null)
            {
                NombretextBox.Text = estudiante.Nombre;
              

            }
            else
            {
                MessageBox.Show("Persona No encontada");
            }
        }

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            if (BLL.NotasCreditoBLL.Modificar(LlenaClase()))
                MessageBox.Show("Modificado");
        }
    }
}
