using Login.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Otra forma de agregar datos al DataGridView:
//string tipo = comboBox1.Text;
//int.TryParse(tbCantidad.Text, out int cantidad);
//this.dgvRegistro.Rows.Add(tipo, cantidad);
//lblGuardado.Text = "LOS ELEMENTOS SE GUARDARON CORRECTAMENTE";

namespace Login.Formularios
{
    public partial class RegistroMaterial : Form
    {
        List<Registro> listaMateriales = new List<Registro>();
        public RegistroMaterial()
        {
            InitializeComponent();
            lblGuardado.Text = null;
            this.ControlBox = false;
            dgvRegistro.DataSource = null;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new MenuOpc().Show();
        }

        private void RegistroMaterial_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Registro material = new Registro();
            material.Tipo = comboBox1.Text;
            if (material.Tipo = comboBox1.SelectedItem.)
            int.TryParse(tbCantidad.Text, out int cantidad);
            material.Cantidad = cantidad;
            listaMateriales.Add(material);
            dgvRegistro.DataSource = null;
            dgvRegistro.DataSource = listaMateriales;
            comboBox1.Focus();
            tbCantidad.Clear();

            

        }
        
    }
}
