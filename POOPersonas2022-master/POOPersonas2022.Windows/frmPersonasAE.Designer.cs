
namespace POOPersonas2022.Windows
{
    partial class frmPersonasAE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SegundoNombreTextBox = new System.Windows.Forms.TextBox();
            this.PrimerNombreTextBox = new System.Windows.Forms.TextBox();
            this.ApellidoTextBox = new System.Windows.Forms.TextBox();
            this.DNITextBox = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FemeninoRadioButton = new System.Windows.Forms.RadioButton();
            this.MasculinoRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.FechaNacDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LocalidadesComboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // SegundoNombreTextBox
            // 
            this.SegundoNombreTextBox.Location = new System.Drawing.Point(139, 127);
            this.SegundoNombreTextBox.MaxLength = 50;
            this.SegundoNombreTextBox.Name = "SegundoNombreTextBox";
            this.SegundoNombreTextBox.Size = new System.Drawing.Size(279, 20);
            this.SegundoNombreTextBox.TabIndex = 39;
            // 
            // PrimerNombreTextBox
            // 
            this.PrimerNombreTextBox.Location = new System.Drawing.Point(139, 99);
            this.PrimerNombreTextBox.MaxLength = 50;
            this.PrimerNombreTextBox.Name = "PrimerNombreTextBox";
            this.PrimerNombreTextBox.Size = new System.Drawing.Size(279, 20);
            this.PrimerNombreTextBox.TabIndex = 38;
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Location = new System.Drawing.Point(139, 70);
            this.ApellidoTextBox.MaxLength = 50;
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(279, 20);
            this.ApellidoTextBox.TabIndex = 37;
            // 
            // DNITextBox
            // 
            this.DNITextBox.Location = new System.Drawing.Point(139, 42);
            this.DNITextBox.MaxLength = 8;
            this.DNITextBox.Name = "DNITextBox";
            this.DNITextBox.Size = new System.Drawing.Size(100, 20);
            this.DNITextBox.TabIndex = 36;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::POOPersonas2022.Windows.Properties.Resources.Close_2_icon;
            this.btnCancelar.Location = new System.Drawing.Point(440, 224);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 61);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Localidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Fecha Nac:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FemeninoRadioButton);
            this.groupBox1.Controls.Add(this.MasculinoRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(422, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 65);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // FemeninoRadioButton
            // 
            this.FemeninoRadioButton.AutoSize = true;
            this.FemeninoRadioButton.Location = new System.Drawing.Point(6, 42);
            this.FemeninoRadioButton.Name = "FemeninoRadioButton";
            this.FemeninoRadioButton.Size = new System.Drawing.Size(71, 17);
            this.FemeninoRadioButton.TabIndex = 1;
            this.FemeninoRadioButton.Text = "Femenino";
            this.FemeninoRadioButton.UseVisualStyleBackColor = true;
            // 
            // MasculinoRadioButton
            // 
            this.MasculinoRadioButton.AutoSize = true;
            this.MasculinoRadioButton.Checked = true;
            this.MasculinoRadioButton.Location = new System.Drawing.Point(6, 19);
            this.MasculinoRadioButton.Name = "MasculinoRadioButton";
            this.MasculinoRadioButton.Size = new System.Drawing.Size(73, 17);
            this.MasculinoRadioButton.TabIndex = 0;
            this.MasculinoRadioButton.TabStop = true;
            this.MasculinoRadioButton.Text = "Masculino";
            this.MasculinoRadioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Segundo Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Primer Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "DNI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Apellido:";
            // 
            // btnOK
            // 
            this.btnOK.Image = global::POOPersonas2022.Windows.Properties.Resources._1462990863_save_as_2;
            this.btnOK.Location = new System.Drawing.Point(37, 224);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 61);
            this.btnOK.TabIndex = 43;
            this.btnOK.Text = "OK";
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FechaNacDateTimePicker
            // 
            this.FechaNacDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacDateTimePicker.Location = new System.Drawing.Point(139, 184);
            this.FechaNacDateTimePicker.Name = "FechaNacDateTimePicker";
            this.FechaNacDateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.FechaNacDateTimePicker.TabIndex = 51;
            // 
            // LocalidadesComboBox
            // 
            this.LocalidadesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LocalidadesComboBox.FormattingEnabled = true;
            this.LocalidadesComboBox.Location = new System.Drawing.Point(139, 156);
            this.LocalidadesComboBox.Name = "LocalidadesComboBox";
            this.LocalidadesComboBox.Size = new System.Drawing.Size(279, 21);
            this.LocalidadesComboBox.TabIndex = 52;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmPersonasAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 309);
            this.Controls.Add(this.LocalidadesComboBox);
            this.Controls.Add(this.FechaNacDateTimePicker);
            this.Controls.Add(this.SegundoNombreTextBox);
            this.Controls.Add(this.PrimerNombreTextBox);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.DNITextBox);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "frmPersonasAE";
            this.Text = "frmPersonasAE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SegundoNombreTextBox;
        private System.Windows.Forms.TextBox PrimerNombreTextBox;
        private System.Windows.Forms.TextBox ApellidoTextBox;
        private System.Windows.Forms.TextBox DNITextBox;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FemeninoRadioButton;
        private System.Windows.Forms.RadioButton MasculinoRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaNacDateTimePicker;
        private System.Windows.Forms.ComboBox LocalidadesComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}