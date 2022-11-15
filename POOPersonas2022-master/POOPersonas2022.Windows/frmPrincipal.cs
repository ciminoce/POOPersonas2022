using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POOPersonas2022.Datos;
using POOPersonas2022.Entidades;

namespace POOPersonas2022.Windows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private RepositorioDePersonas repositorio;
        private List<Persona> lista;
        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmPersonasAE frm = new frmPersonasAE();
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            Persona p = frm.GetPersona();
            repositorio.Agregar(p);
            DataGridViewRow r = ConstruirFila();
            SetearFila(r, p);
            AgregarFila(r);
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, Persona persona)
        {
            r.Cells[cmnDni.Index].Value = persona.Dni;
            r.Cells[cmnPersona.Index].Value = persona.NombreCompleto();
            r.Cells[cmnFechaNacimiento.Index].Value = persona.FechaNacimiento.ToShortDateString();
            r.Cells[cmnSexo.Index].Value = persona.Sexo;
            r.Cells[cmnLocalidad.Index].Value = persona.Localidad;
            r.Cells[cmnEdad.Index].Value = persona.GetEdad();

            r.Tag = persona;
        }

        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarComboLocalidades(tscboLocalidades);
            repositorio = new RepositorioDePersonas();
            if (repositorio.GetCantidad()>0)
            {
                lista = repositorio.GetLista();
                MostrarLista();
            }
        }

        private void CargarComboLocalidades(ToolStripComboBox tsbCombo)
        {
            var listaEnum = Enum.GetValues(typeof(Localidad)).Cast<Localidad>().ToList();
            foreach (var localidad in listaEnum)
            {
                tsbCombo.Items.Add(localidad);
            }

        }

        private void MostrarLista()
        {
            dgvDatos.Rows.Clear();
            foreach (var persona in lista)
            {
                var r = ConstruirFila();
                SetearFila(r,persona);
                AgregarFila(r);
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            //TODO:Preguntar si quiere salir
            repositorio.Guardar();
            Application.Exit();
        }

        private void tscboLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            var localidad = (Localidad) tscboLocalidades.ComboBox.SelectedItem;
            MessageBox.Show(localidad.ToString());
        }
    }
}
