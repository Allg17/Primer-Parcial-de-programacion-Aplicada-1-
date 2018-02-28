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
        Estudiantes estudiante = new Estudiantes();
        public nCreditos()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProviderError();
            if (ErrorIDText() == false)
            {
                return;
            }
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
                PCTnumericUpDown.Value = Nota.PctBeca;
                ObservacionestextBox.Text = Nota.Observaciones;
                MontotextBox.Text = Nota.Monto.ToString();
               

                if (BLL.EstudiantesBLL.Buscar(Nota.EstudianteID)!=null)
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

        private bool ErrorIDText()
        {
            bool paso = false;
            if (BuscartextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe llenar los campos marcados!!");
                IDerrorProvider.SetError(BuscartextBox, "Llenar este campo");
                
            }
            else
            {
                paso = true;
            }
            return paso;
        }

        private void nCreditos_Load(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            FechadateTimePicker.Value = DateTime.Now; ;
            IDEstudiantetextBox.Clear();
            MontoAsignaturanumericUpDown.Value = 0;
            PCTnumericUpDown.Value=0;
            ObservacionestextBox.Clear();
            MontotextBox.Clear();
            BuscartextBox.Clear();
            NombretextBox.Clear();
          
            LimpiarProviderError();
        }

        private void LimpiarProviderError()
        {
            EstudianteIDerrorProvider.Clear();
            MontoAsignaturaserrorProvider.Clear();
            ObservacioneserrorProvider.Clear();
            PCTerrorProvider.Clear();
            IDerrorProvider.Clear();


        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
             NotasCredito Notas = LlenaClase();
            if(validar()==false)
            {
                return;
            }

            if (BuscartextBox.Text == string.Empty)
            {
                if (BLL.NotasCreditoBLL.Guardar(Notas))
                    MessageBox.Show("Guardado!!");
                else
                    MessageBox.Show("No se pudo Guardar!");
            }
            else
            {
                LimpiarProviderError();
                if (ErrorIDText() == false)
                {
                    return;
                }

                if (BLL.NotasCreditoBLL.Modificar(LlenaClase()))
                    MessageBox.Show("Modificado!!");
            }
        }
 
        private bool validar()
        {
            bool paso = false;
            int abrir = 0;

            LimpiarProviderError();

            if (IDEstudiantetextBox.Text == string.Empty )
            {
                EstudianteIDerrorProvider.SetError(IDEstudiantetextBox, "Llenar este campo");
                abrir = 1;
            }
            if(MontoAsignaturanumericUpDown.Value == 0)
            {
                MontoAsignaturaserrorProvider.SetError(MontoAsignaturanumericUpDown, "Llenar este campo");
                abrir = 1;
            }
            if(ObservacionestextBox.Text == string.Empty)
            {
                ObservacioneserrorProvider.SetError(ObservacionestextBox, "Llenar este campo");
                abrir = 1;
            }
            if (PCTnumericUpDown.Value == 0)
            {
                PCTerrorProvider.SetError(PCTnumericUpDown, "Llenar este campo");
                abrir = 1;
            }
            if(abrir ==1)
            {
                MessageBox.Show("Debe llenar los campos marcados");
            }
            else
            {
                paso = true;
            }
            return paso;
        }

        private NotasCredito LlenaClase()
        {
            NotasCredito Nota = new NotasCredito();
            int ID,IdEstudiante;

            decimal PCTBecaConvert = 0;
            int.TryParse(BuscartextBox.Text, out ID);
            int.TryParse(IDEstudiantetextBox.Text, out IdEstudiante);
            PCTBecaConvert = BLL.NotasCreditoBLL.CalcularPCT(PCTnumericUpDown.Value);
            Nota.NotasID = ID;
            Nota.Fecha = FechadateTimePicker.Value ;
            Nota.EstudianteID = IdEstudiante;
            Nota.MontoAsignatura = MontoAsignaturanumericUpDown.Value ;
            Nota.PctBeca = PCTBecaConvert;
            Nota.Observaciones = ObservacionestextBox.Text ;
            Nota.Monto = BLL.NotasCreditoBLL.CalcularMonto(PCTnumericUpDown.Value, MontoAsignaturanumericUpDown.Value);
           
            return Nota;
        }
       
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProviderError();
            int ID;
            int.TryParse(BuscartextBox.Text, out ID);

            if (ErrorIDText()==false)
            {
                return;
            }
            if (BLL.NotasCreditoBLL.Eliminar(ID))
            {
                MessageBox.Show("Eliminado!!");
            }
        }
        
        private void Consultabutton_Click(object sender, EventArgs e)
        {
            NotasCreditos_Form.NConsulta abrir = new NotasCreditos_Form.NConsulta();
            abrir.Show();
        }

        private void PCTnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MontotextBox.Text = BLL.NotasCreditoBLL.CalcularMonto(PCTnumericUpDown.Value, MontoAsignaturanumericUpDown.Value).ToString();
        }

        private void BuscarEstudiantebutton_Click_1(object sender, EventArgs e)
        {
            int ID;
            int.TryParse(IDEstudiantetextBox.Text, out ID);

            LimpiarProviderError();

            if (IDEstudiantetextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe llenar los campos marcados");
                IDerrorProvider.SetError(IDEstudiantetextBox, "Llenar este campo");
                return;

            }
          
            estudiante = BLL.EstudiantesBLL.Buscar(ID);
            if (estudiante != null)
            {
                NombretextBox.Text = estudiante.Nombre;
            }
            else
            {
                MessageBox.Show("Persona No encontada!!");
            }
        }

        private void MontoAsignaturanumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MontotextBox.Text = BLL.NotasCreditoBLL.CalcularMonto(PCTnumericUpDown.Value, MontoAsignaturanumericUpDown.Value).ToString();
        }

       
    }
}
