﻿namespace ClinicaFrba.Abm_Afiliado
{
    partial class A_Familia
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
            this.btVolver = new System.Windows.Forms.Button();
            this.btIngresar = new System.Windows.Forms.Button();
            this.dateFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDirec = new System.Windows.Forms.TextBox();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbConjunto = new System.Windows.Forms.Label();
            this.lvlFamilia = new System.Windows.Forms.Label();
            this.cbPlanMedico = new System.Windows.Forms.ComboBox();
            this.cbTipoDoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btVolver
            // 
            this.btVolver.Location = new System.Drawing.Point(69, 364);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 34;
            this.btVolver.Text = "Cancelar";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // btIngresar
            // 
            this.btIngresar.Location = new System.Drawing.Point(233, 364);
            this.btIngresar.Name = "btIngresar";
            this.btIngresar.Size = new System.Drawing.Size(75, 23);
            this.btIngresar.TabIndex = 33;
            this.btIngresar.Text = "Ingresar";
            this.btIngresar.UseVisualStyleBackColor = true;
            this.btIngresar.Click += new System.EventHandler(this.btIngresar_Click);
            // 
            // dateFechaNac
            // 
            this.dateFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFechaNac.Location = new System.Drawing.Point(233, 221);
            this.dateFechaNac.Name = "dateFechaNac";
            this.dateFechaNac.Size = new System.Drawing.Size(100, 20);
            this.dateFechaNac.TabIndex = 32;
            this.dateFechaNac.Value = new System.DateTime(2016, 10, 21, 16, 15, 55, 0);
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "Soltero/a",
            "Casado/a",
            "Concubinato",
            "Viudo/a",
            "Divorciado/a"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(233, 273);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(100, 21);
            this.cbEstadoCivil.TabIndex = 31;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbSexo.Location = new System.Drawing.Point(233, 247);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(100, 21);
            this.cbSexo.TabIndex = 30;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(233, 195);
            this.txtMail.MaxLength = 250;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 27;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(233, 169);
            this.txtTel.MaxLength = 15;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 26;
            this.txtTel.TextChanged += new System.EventHandler(this.txtTel_TextChanged);
            // 
            // txtDirec
            // 
            this.txtDirec.Location = new System.Drawing.Point(233, 143);
            this.txtDirec.MaxLength = 250;
            this.txtDirec.Name = "txtDirec";
            this.txtDirec.Size = new System.Drawing.Size(100, 20);
            this.txtDirec.TabIndex = 25;
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(233, 91);
            this.txtNroDoc.MaxLength = 18;
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(100, 20);
            this.txtNroDoc.TabIndex = 23;
            this.txtNroDoc.TextChanged += new System.EventHandler(this.txtNroDoc_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(233, 65);
            this.txtApellido.MaxLength = 250;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 22;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(233, 39);
            this.txtNombre.MaxLength = 250;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 21;
            // 
            // lbConjunto
            // 
            this.lbConjunto.AutoSize = true;
            this.lbConjunto.Location = new System.Drawing.Point(34, 42);
            this.lbConjunto.Name = "lbConjunto";
            this.lbConjunto.Size = new System.Drawing.Size(108, 273);
            this.lbConjunto.TabIndex = 20;
            this.lbConjunto.Text = "Nombre\r\n\r\nApellido\r\n\r\nNro. Documento\r\n\r\nTipo Documento\r\n\r\nDirección\r\n\r\nTeléfono\r\n" +
    "\r\nMail\r\n\r\nFecha de Nacimiento\r\n\r\nSexo\r\n\r\nEstado Civil\r\n\r\nPlan Médico";
            // 
            // lvlFamilia
            // 
            this.lvlFamilia.AutoSize = true;
            this.lvlFamilia.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlFamilia.Location = new System.Drawing.Point(33, 9);
            this.lvlFamilia.Name = "lvlFamilia";
            this.lvlFamilia.Size = new System.Drawing.Size(180, 23);
            this.lvlFamilia.TabIndex = 35;
            this.lvlFamilia.Text = "Asocie a un familiar";
            // 
            // cbPlanMedico
            // 
            this.cbPlanMedico.FormattingEnabled = true;
            this.cbPlanMedico.Items.AddRange(new object[] {
            "110",
            "120",
            "130",
            "140",
            "150"});
            this.cbPlanMedico.Location = new System.Drawing.Point(233, 300);
            this.cbPlanMedico.Name = "cbPlanMedico";
            this.cbPlanMedico.Size = new System.Drawing.Size(100, 21);
            this.cbPlanMedico.TabIndex = 36;
            // 
            // cbTipoDoc
            // 
            this.cbTipoDoc.FormattingEnabled = true;
            this.cbTipoDoc.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "LE"});
            this.cbTipoDoc.Location = new System.Drawing.Point(233, 117);
            this.cbTipoDoc.Name = "cbTipoDoc";
            this.cbTipoDoc.Size = new System.Drawing.Size(100, 21);
            this.cbTipoDoc.TabIndex = 37;
            // 
            // A_Familia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 396);
            this.Controls.Add(this.cbTipoDoc);
            this.Controls.Add(this.cbPlanMedico);
            this.Controls.Add(this.lvlFamilia);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btIngresar);
            this.Controls.Add(this.dateFechaNac);
            this.Controls.Add(this.cbEstadoCivil);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtDirec);
            this.Controls.Add(this.txtNroDoc);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbConjunto);
            this.Name = "A_Familia";
            this.Text = "A_Familia";
            this.Load += new System.EventHandler(this.A_Familia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Button btIngresar;
        private System.Windows.Forms.DateTimePicker dateFechaNac;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtDirec;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbConjunto;
        private System.Windows.Forms.Label lvlFamilia;
        private System.Windows.Forms.ComboBox cbPlanMedico;
        private System.Windows.Forms.ComboBox cbTipoDoc;
    }
}