using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOPersonas2022.Windows
{
    public partial class frmComienzaCon : Form
    {
        public frmComienzaCon()
        {
            InitializeComponent();
        }

        private string comienzaCon;
        public string GetComienzaCon()
        {
            return comienzaCon;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                comienzaCon = txtComienza.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtComienza.Text))
            {
                valido = false;
                errorProvider1.SetError(txtComienza,"Debe ingresar algún caracter");
            }

            return valido;
        }
    }
}
