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
    public partial class NConsulta : Form
    {
        public NConsulta()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            String a;
            a = CriteriotextBox.Text;
            int ID;
            int.TryParse(CriteriotextBox.Text, out ID);

            if (FiltrarcomboBox.SelectedIndex == 0)
                PersonasdataGridView.DataSource = BLL.NotasCreditoBLL.GetList(t => t.Observaciones.Contains(a));
           if(FiltrarcomboBox.SelectedIndex == 1)
                PersonasdataGridView.DataSource = BLL.NotasCreditoBLL.GetList(t => t.NotasID == ID);
        }
    }
}
