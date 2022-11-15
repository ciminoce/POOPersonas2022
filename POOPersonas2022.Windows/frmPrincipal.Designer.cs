
namespace POOPersonas2022.Windows
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cmnDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnFechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFiltrar = new System.Windows.Forms.ToolStripDropDownButton();
            this.sexoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masculinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.femeninoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tscboLocalidades = new System.Windows.Forms.ToolStripComboBox();
            this.comienzanConToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRefrescar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbOrdenar = new System.Windows.Forms.ToolStripDropDownButton();
            this.aZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caracteresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDatos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 412);
            this.panel1.TabIndex = 13;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Silver;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnDni,
            this.cmnPersona,
            this.cmnSexo,
            this.cmnFechaNacimiento,
            this.cmnLocalidad,
            this.cmnEdad});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(800, 412);
            this.dgvDatos.TabIndex = 0;
            // 
            // cmnDni
            // 
            this.cmnDni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cmnDni.HeaderText = "DNI";
            this.cmnDni.Name = "cmnDni";
            this.cmnDni.ReadOnly = true;
            this.cmnDni.Width = 51;
            // 
            // cmnPersona
            // 
            this.cmnPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnPersona.HeaderText = "Persona";
            this.cmnPersona.Name = "cmnPersona";
            this.cmnPersona.ReadOnly = true;
            // 
            // cmnSexo
            // 
            this.cmnSexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnSexo.HeaderText = "Sexo";
            this.cmnSexo.Name = "cmnSexo";
            this.cmnSexo.ReadOnly = true;
            // 
            // cmnFechaNacimiento
            // 
            this.cmnFechaNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnFechaNacimiento.HeaderText = "Fecha Nac";
            this.cmnFechaNacimiento.Name = "cmnFechaNacimiento";
            this.cmnFechaNacimiento.ReadOnly = true;
            // 
            // cmnLocalidad
            // 
            this.cmnLocalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnLocalidad.HeaderText = "Localidad";
            this.cmnLocalidad.Name = "cmnLocalidad";
            this.cmnLocalidad.ReadOnly = true;
            // 
            // cmnEdad
            // 
            this.cmnEdad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.cmnEdad.DefaultCellStyle = dataGridViewCellStyle16;
            this.cmnEdad.HeaderText = "Edad";
            this.cmnEdad.Name = "cmnEdad";
            this.cmnEdad.ReadOnly = true;
            this.cmnEdad.Width = 57;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbBorrar,
            this.tsbEditar,
            this.toolStripSeparator1,
            this.tsbFiltrar,
            this.tsbRefrescar,
            this.toolStripSeparator2,
            this.tsbOrdenar,
            this.toolStripSeparator3,
            this.tsbSalir,
            this.toolStripSeparator4});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 38);
            this.toolStrip2.TabIndex = 12;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::POOPersonas2022.Windows.Properties.Resources._1473267083_document_new;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(46, 35);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbBorrar
            // 
            this.tsbBorrar.Image = global::POOPersonas2022.Windows.Properties.Resources._1473267191_delete_file;
            this.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrar.Name = "tsbBorrar";
            this.tsbBorrar.Size = new System.Drawing.Size(43, 35);
            this.tsbBorrar.Text = "Borrar";
            this.tsbBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbBorrar.Click += new System.EventHandler(this.tsbBorrar_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.Image = global::POOPersonas2022.Windows.Properties.Resources._1473267203_edit_file;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(41, 35);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbFiltrar
            // 
            this.tsbFiltrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sexoToolStripMenuItem,
            this.localidadToolStripMenuItem,
            this.comienzanConToolStripMenuItem});
            this.tsbFiltrar.Image = global::POOPersonas2022.Windows.Properties.Resources._1476724560_filter;
            this.tsbFiltrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFiltrar.Name = "tsbFiltrar";
            this.tsbFiltrar.Size = new System.Drawing.Size(50, 35);
            this.tsbFiltrar.Text = "Filtrar";
            this.tsbFiltrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // sexoToolStripMenuItem
            // 
            this.sexoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masculinoToolStripMenuItem,
            this.femeninoToolStripMenuItem});
            this.sexoToolStripMenuItem.Name = "sexoToolStripMenuItem";
            this.sexoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sexoToolStripMenuItem.Text = "Sexo";
            // 
            // masculinoToolStripMenuItem
            // 
            this.masculinoToolStripMenuItem.Name = "masculinoToolStripMenuItem";
            this.masculinoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.masculinoToolStripMenuItem.Text = "Masculino";
            this.masculinoToolStripMenuItem.Click += new System.EventHandler(this.masculinoToolStripMenuItem_Click);
            // 
            // femeninoToolStripMenuItem
            // 
            this.femeninoToolStripMenuItem.Name = "femeninoToolStripMenuItem";
            this.femeninoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.femeninoToolStripMenuItem.Text = "Femenino";
            this.femeninoToolStripMenuItem.Click += new System.EventHandler(this.femeninoToolStripMenuItem_Click);
            // 
            // localidadToolStripMenuItem
            // 
            this.localidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tscboLocalidades});
            this.localidadToolStripMenuItem.Name = "localidadToolStripMenuItem";
            this.localidadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.localidadToolStripMenuItem.Text = "Localidad";
            // 
            // tscboLocalidades
            // 
            this.tscboLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscboLocalidades.Name = "tscboLocalidades";
            this.tscboLocalidades.Size = new System.Drawing.Size(121, 23);
            this.tscboLocalidades.SelectedIndexChanged += new System.EventHandler(this.tscboLocalidades_SelectedIndexChanged);
            // 
            // comienzanConToolStripMenuItem
            // 
            this.comienzanConToolStripMenuItem.Name = "comienzanConToolStripMenuItem";
            this.comienzanConToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comienzanConToolStripMenuItem.Text = "Comienzan con...";
            this.comienzanConToolStripMenuItem.Click += new System.EventHandler(this.comienzanConToolStripMenuItem_Click);
            // 
            // tsbRefrescar
            // 
            this.tsbRefrescar.Image = global::POOPersonas2022.Windows.Properties.Resources.Button_Refresh_icon;
            this.tsbRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefrescar.Name = "tsbRefrescar";
            this.tsbRefrescar.Size = new System.Drawing.Size(59, 35);
            this.tsbRefrescar.Text = "Refrescar";
            this.tsbRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbRefrescar.Click += new System.EventHandler(this.tsbRefrescar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbOrdenar
            // 
            this.tsbOrdenar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aZToolStripMenuItem,
            this.zAToolStripMenuItem,
            this.caracteresToolStripMenuItem,
            this.edadToolStripMenuItem});
            this.tsbOrdenar.Image = global::POOPersonas2022.Windows.Properties.Resources._1476726158_view_sort_ascending;
            this.tsbOrdenar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOrdenar.Name = "tsbOrdenar";
            this.tsbOrdenar.Size = new System.Drawing.Size(63, 35);
            this.tsbOrdenar.Text = "Ordenar";
            this.tsbOrdenar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // aZToolStripMenuItem
            // 
            this.aZToolStripMenuItem.Name = "aZToolStripMenuItem";
            this.aZToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aZToolStripMenuItem.Text = "A-Z";
            this.aZToolStripMenuItem.Click += new System.EventHandler(this.aZToolStripMenuItem_Click);
            // 
            // zAToolStripMenuItem
            // 
            this.zAToolStripMenuItem.Name = "zAToolStripMenuItem";
            this.zAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zAToolStripMenuItem.Text = "Z-A";
            this.zAToolStripMenuItem.Click += new System.EventHandler(this.zAToolStripMenuItem_Click);
            // 
            // caracteresToolStripMenuItem
            // 
            this.caracteresToolStripMenuItem.Name = "caracteresToolStripMenuItem";
            this.caracteresToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.caracteresToolStripMenuItem.Text = "Caracteres";
            // 
            // edadToolStripMenuItem
            // 
            this.edadToolStripMenuItem.Name = "edadToolStripMenuItem";
            this.edadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.edadToolStripMenuItem.Text = "Edad";
            this.edadToolStripMenuItem.Click += new System.EventHandler(this.edadToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbSalir
            // 
            this.tsbSalir.Image = global::POOPersonas2022.Windows.Properties.Resources.Log_Out_icon;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(33, 35);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnFechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnEdad;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbBorrar;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsbFiltrar;
        private System.Windows.Forms.ToolStripMenuItem sexoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masculinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem femeninoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tscboLocalidades;
        private System.Windows.Forms.ToolStripMenuItem comienzanConToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbRefrescar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton tsbOrdenar;
        private System.Windows.Forms.ToolStripMenuItem aZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caracteresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}

