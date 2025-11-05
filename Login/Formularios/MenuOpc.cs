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
    public partial class MenuOpc : Form
    {
        public MenuOpc()
        {
            InitializeComponent();

            this.ControlBox = false;
        }

        private void MenuOpc_FormClosing(object sender, FormClosingEventArgs e)
        {
            
           
            
           
        }

        private void ingresarMaterialRecicladoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registroDeMaterialRecicladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegistroMaterial().Show();
        }

        private void menuDeOpcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void consultaDePuntosIndividualesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ConsultaPuntos().Show();
        }

        private void MenuOpc_Load(object sender, EventArgs e)
        {

        }

        private void rankingDeVisualizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Ranking().Show();
        }
    }
}
