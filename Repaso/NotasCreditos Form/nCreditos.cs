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
            LimpiarProviderError();
            if (ErrorIDText() == false)
            {
                return;
            }
            int ID;
            NotasCredito Nota = new NotasCredito();
            Estudiantes estudiantes = new Estudiantes();
            int.TryParse(BuscartextBox.Text, out ID);
            MontoExonerado monto = new MontoExonerado();
            monto = BLL.MontoExoneradoBLL.Buscar(ID);

            Nota = BLL.NotasCreditoBLL.Buscar(ID);

            if (Nota != null)
            {
                FechadateTimePicker.Value = Nota.Fecha;
                IDEstudiantetextBox.Text = Nota.EstudianteID.ToString();
                MontoAsignaturanumericUpDown.Value = Convert.ToDecimal(Nota.MontoAsignatura);
                PCTnumericUpDown.Value = Nota.PctBeca;
                ObservacionestextBox.Text = Nota.Observaciones;
                MontotextBox.Text = Nota.Monto.ToString();
     
                if(BLL.EstudiantesBLL.Buscar(Nota.EstudianteID)!=null)
                {
                    estudiantes = BLL.EstudiantesBLL.Buscar(Nota.EstudianteID);
                    NombretextBox.Text = estudiantes.Nombre;
                }
                
                if(BLL.MontoExoneradoBLL.Buscar(Nota.EstudianteID) != null)
                {
                    monto = BLL.MontoExoneradoBLL.Buscar(Nota.EstudianteID);
                    MontoExoneradotextBox.Text = monto.MontoExonerados.ToString();
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
            MontoExoneradotextBox.Clear();
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


            if (BLL.NotasCreditoBLL.Guardar(Notas) && BLL.MontoExoneradoBLL.Guardar(LlenaClases()))
                MessageBox.Show("Guardado!!");
            else
                MessageBox.Show("No se pudo Guardar!");
        }
        private MontoExonerado LlenaClases()
        {
            int estudianteid, Monto=0,id;
            int.TryParse(IDEstudiantetextBox.Text, out estudianteid);
            int.TryParse(BuscartextBox.Text, out id);
            
            MontoExonerado monto = new MontoExonerado();
   
            monto.ID = id;
            monto.IdEstudiantes = estudianteid;
            monto.MontoAnterior = Convert.ToInt32(CalcularMonto());
            Monto =  monto.MontoExonerados =+ Convert.ToInt32(CalcularMonto());
            MontoExoneradotextBox.Text = Monto.ToString();

            return monto;

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
            int a,b;

            decimal PCTBecaConvert = 0;
            PCTBecaConvert = PCTnumericUpDown.Value / 100;
            int.TryParse(BuscartextBox.Text, out a);
            Nota.NotasID = a;
            Nota.Fecha = FechadateTimePicker.Value ;
            int.TryParse(IDEstudiantetextBox.Text, out b);
            Nota.EstudianteID = b;
            Nota.MontoAsignatura = MontoAsignaturanumericUpDown.Value ;
            Nota.PctBeca = PCTBecaConvert;
            Nota.Observaciones = ObservacionestextBox.Text ;
            Nota.Monto =Convert.ToDecimal(CalcularMonto());
            

            return Nota;

        }
       
        private float CalcularMonto()
        {
            NotasCredito Nota = new NotasCredito();
            float MontoFinal = 0;
            decimal pctbeca = 0;
             pctbeca = PCTnumericUpDown.Value / 100;

            MontoFinal = Convert.ToSingle(pctbeca )* Convert.ToSingle(MontoAsignaturanumericUpDown.Value);
            return MontoFinal;

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

            EliminarMontoExonerado();

            if (BLL.NotasCreditoBLL.Eliminar(ID))
            {
                MessageBox.Show("Eliminado!!");
            }
        }

        private int EliminarMontoExonerado()
        {
            int Monto,campo;
            int ID;
            int.TryParse(BuscartextBox.Text, out ID);

            NotasCredito Nota = new NotasCredito();
            MontoExonerado monto = new MontoExonerado();
            Nota = BLL.NotasCreditoBLL.Buscar(ID);
            campo = Nota.EstudianteID;
            monto = BLL.MontoExoneradoBLL.Buscar(campo);
            Monto = monto.MontoExonerados =- monto.MontoAnterior;
            MontoExoneradotextBox.Text = Monto.ToString();
            return Monto;
        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            NotasCreditos_Form.NConsulta abrir = new NotasCreditos_Form.NConsulta();
            abrir.Show();
        }

        private int ModificarCampoMontoExonerado()
        {
            int  Monto ,ID, campo;
           
            int.TryParse(BuscartextBox.Text, out ID);
            Convert.ToInt32(CalcularMonto());

            NotasCredito Nota = new NotasCredito();
            MontoExonerado monto = new MontoExonerado();
            Nota = BLL.NotasCreditoBLL.Buscar(ID);
            campo = Nota.EstudianteID;
            monto = BLL.MontoExoneradoBLL.Buscar(campo);
            Monto = monto.MontoExonerados =+ Convert.ToInt32(Nota.Monto);
            MontoExoneradotextBox.Text = Monto.ToString();
            return Monto;
        }
       

        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            LimpiarProviderError();
            if (ErrorIDText() == false)
            {
                return;
            }
            EliminarMontoExonerado();
            ModificarCampoMontoExonerado();

            if (BLL.NotasCreditoBLL.Modificar(LlenaClase()))
                MessageBox.Show("Modificado!!");
        }

       

        private void PCTnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MontotextBox.Text = CalcularMonto().ToString();
        }

        private void BuscarEstudiantebutton_Click_1(object sender, EventArgs e)
        {
            LimpiarProviderError();
            if (IDEstudiantetextBox.Text == string.Empty)
            {
                MessageBox.Show("Debe llenar los campos marcados");
                IDerrorProvider.SetError(IDEstudiantetextBox, "Llenar este campo");
                return;

            }
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
                MessageBox.Show("Persona No encontada!!");
            }
        }

        private void MontoAsignaturanumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            MontotextBox.Text = CalcularMonto().ToString();
        }

        private void MontotextBox_TextChanged(object sender, EventArgs e)
        {

          //  MontoExoneradotextBox.Text = ;
        }
    }
}
