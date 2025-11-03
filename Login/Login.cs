using Login.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login
{
    public partial class Login : Form
    {
        
        public Login()
        {
          
            InitializeComponent();
           
            this.FormClosing += MenuOpc_FormClosing;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string cif = "";
            string password = "";
            string usercif = tbCif.Text;
            string passworduser = tbPassword.Text;
           if (usercif == cif && passworduser == password )
            {
                this.Hide();
                new MenuOpc().Show();
            }
            else
            {
                MessageBox.Show("El cif o la contraseña son invalidos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbCif.Clear();
                tbCif.Focus();
                tbPassword.Clear();

            }
            
        }
        private void Validar()
        {
            
        }

        

        private void MenuOpc_FormClosing (object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas seguro que deseas salir?", "ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
