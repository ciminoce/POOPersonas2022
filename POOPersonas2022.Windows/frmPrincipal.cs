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
            CargarComboLocalidades();
            repositorio = new RepositorioDePersonas();
            if (repositorio.GetCantidad()>0)
            {
                RecargarGrilla();
            }
        }

        private void CargarComboLocalidades()
        {
            var listaLocalidades = Enum.GetValues(typeof(Localidad)).Cast<Localidad>().ToList();
            foreach (var localidad in listaLocalidades)
            {
                tscboLocalidades.ComboBox.Items.Add(localidad);
            }
        }

        private void RecargarGrilla()
        {
            lista = repositorio.GetLista();
            MostrarLista();
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
            if (dgvDatos.SelectedRows.Count==0)
            {
                return;
            }

            var r = dgvDatos.SelectedRows[0];
            Persona pEditar = r.Tag as Persona;
            frmPersonasAE frm = new frmPersonasAE() { Text = "Editar Persona" };
            frm.SetPersona(pEditar);
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            pEditar = frm.GetPersona();
            SetearFila(r,pEditar);




        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            //TODO:Preguntar si quiere salir
            repositorio.Guardar();
            Application.Exit();
        }


        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count==0)
            {
                return;
            }

            var r = dgvDatos.SelectedRows[0];
            Persona pBorrar=r.Tag as Persona;
            DialogResult dr = MessageBox.Show($"¿Desea borrar a {pBorrar.NombreCompleto()}?",
                "Confirmar Borrado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (dr==DialogResult.No)
            {
                return;
            }
            repositorio.Borrar(pBorrar);
            dgvDatos.Rows.Remove(r);
        }

        private void masculinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sexo = Sexo.Masculino;
            ListarPorSexo(sexo);
        }

        private void ListarPorSexo(Sexo sexo)
        {
            lista = repositorio.FiltrarPorSexo(sexo);
            MostrarLista();
        }

        private void femeninoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sexo = Sexo.Femenino;
            ListarPorSexo(sexo);

        }

        private void tsbRefrescar_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void tscboLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            var localidadFiltrar =(Localidad) tscboLocalidades.ComboBox.SelectedItem;
            lista = repositorio.FiltrarPorLocalidad(localidadFiltrar);
            MostrarLista();
        }

        private void aZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.OrdenarAlfaAsc();
            MostrarLista();
        }

        private void zAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.OrdenarAlfaDesc();
            MostrarLista();
        }

        private void edadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lista = repositorio.OrdenarPorEdadAsc();
            MostrarLista();
        }

        private void comienzanConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComienzaCon frm = new frmComienzaCon() { Text = "Filtrar Personas" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            var comienzaCon = frm.GetComienzaCon();
            lista = repositorio.GetLista(comienzaCon);
            MostrarLista();

        }
    }
}
