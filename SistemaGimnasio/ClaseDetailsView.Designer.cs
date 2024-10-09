namespace SistemaGimnasio.View
{
    partial class ClaseDetailsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClaseDetailsView));
            this.txtNombreClase = new System.Windows.Forms.TextBox();
            this.txtNombreInstructor = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.txtCapacidad = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblErrorNombreClase = new System.Windows.Forms.Label();
            this.lblErrorNombreInstructor = new System.Windows.Forms.Label();
            this.lblErrorDias = new System.Windows.Forms.Label();
            this.lblErrorHorario = new System.Windows.Forms.Label();
            this.lblErrorCapacidad = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreClase
            // 
            this.txtNombreClase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNombreClase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreClase.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtNombreClase.ForeColor = System.Drawing.Color.LightGray;
            this.txtNombreClase.Location = new System.Drawing.Point(35, 43);
            this.txtNombreClase.Name = "txtNombreClase";
            this.txtNombreClase.Size = new System.Drawing.Size(290, 24);
            this.txtNombreClase.TabIndex = 20;
            this.txtNombreClase.Tag = "Nombre de la clase";
            this.txtNombreClase.Enter += new System.EventHandler(this.txtNombreClase_Enter);
            this.txtNombreClase.Leave += new System.EventHandler(this.txtNombreClase_Leave);
            // 
            // txtNombreInstructor
            // 
            this.txtNombreInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNombreInstructor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreInstructor.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtNombreInstructor.ForeColor = System.Drawing.Color.LightGray;
            this.txtNombreInstructor.Location = new System.Drawing.Point(35, 93);
            this.txtNombreInstructor.Name = "txtNombreInstructor";
            this.txtNombreInstructor.Size = new System.Drawing.Size(290, 24);
            this.txtNombreInstructor.TabIndex = 21;
            this.txtNombreInstructor.Tag = "Nombre del instructor";
            this.txtNombreInstructor.Enter += new System.EventHandler(this.txtNombreInstructor_Enter);
            this.txtNombreInstructor.Leave += new System.EventHandler(this.txtNombreInstructor_Leave);
            // 
            // txtDias
            // 
            this.txtDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtDias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDias.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtDias.ForeColor = System.Drawing.Color.LightGray;
            this.txtDias.Location = new System.Drawing.Point(35, 143);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(290, 24);
            this.txtDias.TabIndex = 22;
            this.txtDias.Enter += new System.EventHandler(this.txtDias_Enter);
            this.txtDias.Leave += new System.EventHandler(this.txtDias_Leave);
            // 
            // txtHorario
            // 
            this.txtHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtHorario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHorario.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtHorario.ForeColor = System.Drawing.Color.LightGray;
            this.txtHorario.Location = new System.Drawing.Point(35, 193);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(290, 24);
            this.txtHorario.TabIndex = 23;
            this.txtHorario.Enter += new System.EventHandler(this.txtHorario_Enter);
            this.txtHorario.Leave += new System.EventHandler(this.txtHorario_Leave);
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCapacidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCapacidad.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtCapacidad.ForeColor = System.Drawing.Color.LightGray;
            this.txtCapacidad.Location = new System.Drawing.Point(35, 243);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Size = new System.Drawing.Size(290, 24);
            this.txtCapacidad.TabIndex = 24;
            this.txtCapacidad.Enter += new System.EventHandler(this.txtCapacidad_Enter);
            this.txtCapacidad.Leave += new System.EventHandler(this.txtCapacidad_Leave);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancelar.Location = new System.Drawing.Point(190, 303);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 40);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuardar.Location = new System.Drawing.Point(35, 303);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 40);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblErrorNombreClase
            // 
            this.lblErrorNombreClase.AutoSize = true;
            this.lblErrorNombreClase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblErrorNombreClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombreClase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.lblErrorNombreClase.Location = new System.Drawing.Point(35, 68);
            this.lblErrorNombreClase.Name = "lblErrorNombreClase";
            this.lblErrorNombreClase.Size = new System.Drawing.Size(0, 13);
            this.lblErrorNombreClase.TabIndex = 27;
            // 
            // lblErrorNombreInstructor
            // 
            this.lblErrorNombreInstructor.AutoSize = true;
            this.lblErrorNombreInstructor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblErrorNombreInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombreInstructor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.lblErrorNombreInstructor.Location = new System.Drawing.Point(35, 118);
            this.lblErrorNombreInstructor.Name = "lblErrorNombreInstructor";
            this.lblErrorNombreInstructor.Size = new System.Drawing.Size(0, 13);
            this.lblErrorNombreInstructor.TabIndex = 28;
            // 
            // lblErrorDias
            // 
            this.lblErrorDias.AutoSize = true;
            this.lblErrorDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblErrorDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.lblErrorDias.Location = new System.Drawing.Point(35, 168);
            this.lblErrorDias.Name = "lblErrorDias";
            this.lblErrorDias.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDias.TabIndex = 29;
            // 
            // lblErrorHorario
            // 
            this.lblErrorHorario.AutoSize = true;
            this.lblErrorHorario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblErrorHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorHorario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.lblErrorHorario.Location = new System.Drawing.Point(35, 218);
            this.lblErrorHorario.Name = "lblErrorHorario";
            this.lblErrorHorario.Size = new System.Drawing.Size(0, 13);
            this.lblErrorHorario.TabIndex = 30;
            // 
            // lblErrorCapacidad
            // 
            this.lblErrorCapacidad.AutoSize = true;
            this.lblErrorCapacidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.lblErrorCapacidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCapacidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(0)))), ((int)(((byte)(32)))));
            this.lblErrorCapacidad.Location = new System.Drawing.Point(35, 268);
            this.lblErrorCapacidad.Name = "lblErrorCapacidad";
            this.lblErrorCapacidad.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCapacidad.TabIndex = 31;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(332, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 32;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ClaseDetailsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(360, 379);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblErrorCapacidad);
            this.Controls.Add(this.lblErrorHorario);
            this.Controls.Add(this.lblErrorDias);
            this.Controls.Add(this.lblErrorNombreInstructor);
            this.Controls.Add(this.lblErrorNombreClase);
            this.Controls.Add(this.txtNombreClase);
            this.Controls.Add(this.txtNombreInstructor);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtCapacidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClaseDetailsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clase";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ClaseDetailsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreClase;
        private System.Windows.Forms.TextBox txtNombreInstructor;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.TextBox txtCapacidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblErrorNombreClase;
        private System.Windows.Forms.Label lblErrorNombreInstructor;
        private System.Windows.Forms.Label lblErrorDias;
        private System.Windows.Forms.Label lblErrorHorario;
        private System.Windows.Forms.Label lblErrorCapacidad;
        private System.Windows.Forms.PictureBox btnClose;
    }
}