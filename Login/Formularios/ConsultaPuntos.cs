using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Formularios
{
    public partial class ConsultaPuntos : Form
    {
        public ConsultaPuntos()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void ConsultaPuntos_Load(object sender, EventArgs e)
        {

        }

        public void ConsultaPuntos_FormCancel()
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuOpc().Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
