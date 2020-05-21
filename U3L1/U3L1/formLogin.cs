using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U3L1
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_Contr_Click(object sender, EventArgs e)
        {

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if(this.txt_Nombre.Text == "Admin" && this.txt_Contr.Text == "admin")
            {
                MessageBox.Show("Usted a Ingresado Correctamente.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblk_OlvideContr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvidé mi contraseña",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
