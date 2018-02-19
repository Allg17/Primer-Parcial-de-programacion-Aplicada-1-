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
    public partial class cMontoExonerado : Form
    {
        List<MontoExonerado> datos = new List<MontoExonerado>();
        public cMontoExonerado()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void cMontoExonerado_Load(object sender, EventArgs e)
        {
            FiltrarcomboBox.SelectedIndex = 0;
        }

        private void FiltrarcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void Imprimir()
        {
       

            if (FiltrarcomboBox.SelectedIndex == 0)
                datos = BLL.MontoExoneradoBLL.GetList();

            PersonasdataGridView.DataSource = datos;
        }
    }
}
