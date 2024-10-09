namespace SistemaGimnasio.View
{
    partial class VistaAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaAdministrador));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridClases = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.claseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.claseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idClaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreInstructorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espaciosDisponiblesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClases)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(12, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(885, 1);
            this.panel3.TabIndex = 15;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(863, 9);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(16, 16);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(885, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnClose.TabIndex = 13;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "CLASES";
            // 
            // gridClases
            // 
            this.gridClases.AutoGenerateColumns = false;
            this.gridClases.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gridClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClaseDataGridViewTextBoxColumn,
            this.nombreClaseDataGridViewTextBoxColumn,
            this.nombreInstructorDataGridViewTextBoxColumn,
            this.Dias,
            this.horarioDataGridViewTextBoxColumn,
            this.capacidadDataGridViewTextBoxColumn,
            this.espaciosDisponiblesDataGridViewTextBoxColumn});
            this.gridClases.DataSource = this.claseBindingSource1;
            this.gridClases.GridColor = System.Drawing.Color.DimGray;
            this.gridClases.Location = new System.Drawing.Point(12, 60);
            this.gridClases.Name = "gridClases";
            this.gridClases.ReadOnly = true;
            this.gridClases.RowHeadersWidth = 35;
            this.gridClases.Size = new System.Drawing.Size(786, 319);
            this.gridClases.TabIndex = 0;
            this.gridClases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridClases_CellClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.txtBuscar.ForeColor = System.Drawing.Color.LightGray;
            this.txtBuscar.Location = new System.Drawing.Point(12, 30);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(677, 24);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscar.Location = new System.Drawing.Point(695, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.Color.LightGray;
            this.btnInsertar.Location = new System.Drawing.Point(801, 60);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(100, 30);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.LightGray;
            this.btnEditar.Location = new System.Drawing.Point(801, 96);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 30);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.LightGray;
            this.btnBorrar.Location = new System.Drawing.Point(801, 132);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 30);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar clase:";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.Black;
            this.btnCerrarSesion.Location = new System.Drawing.Point(801, 310);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(100, 69);
            this.btnCerrarSesion.TabIndex = 16;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panel2.Controls.Add(this.btnCerrarSesion);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnBorrar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnInsertar);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Controls.Add(this.gridClases);
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 490);
            this.panel2.TabIndex = 3;
            // 
            // claseBindingSource1
            // 
            this.claseBindingSource1.DataSource = typeof(SistemaGimnasio.Clase);
            // 
            // claseBindingSource
            // 
            this.claseBindingSource.DataSource = typeof(SistemaGimnasio.Clase);
            // 
            // idClaseDataGridViewTextBoxColumn
            // 
            this.idClaseDataGridViewTextBoxColumn.DataPropertyName = "IdClase";
            this.idClaseDataGridViewTextBoxColumn.HeaderText = "IdClase";
            this.idClaseDataGridViewTextBoxColumn.Name = "idClaseDataGridViewTextBoxColumn";
            this.idClaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClaseDataGridViewTextBoxColumn.Width = 52;
            // 
            // nombreClaseDataGridViewTextBoxColumn
            // 
            this.nombreClaseDataGridViewTextBoxColumn.DataPropertyName = "NombreClase";
            this.nombreClaseDataGridViewTextBoxColumn.HeaderText = "NombreClase";
            this.nombreClaseDataGridViewTextBoxColumn.Name = "nombreClaseDataGridViewTextBoxColumn";
            this.nombreClaseDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreClaseDataGridViewTextBoxColumn.Width = 110;
            // 
            // nombreInstructorDataGridViewTextBoxColumn
            // 
            this.nombreInstructorDataGridViewTextBoxColumn.DataPropertyName = "NombreInstructor";
            this.nombreInstructorDataGridViewTextBoxColumn.HeaderText = "NombreInstructor";
            this.nombreInstructorDataGridViewTextBoxColumn.Name = "nombreInstructorDataGridViewTextBoxColumn";
            this.nombreInstructorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreInstructorDataGridViewTextBoxColumn.Width = 110;
            // 
            // Dias
            // 
            this.Dias.DataPropertyName = "Dias";
            this.Dias.HeaderText = "Dias";
            this.Dias.Name = "Dias";
            this.Dias.ReadOnly = true;
            this.Dias.Width = 130;
            // 
            // horarioDataGridViewTextBoxColumn
            // 
            this.horarioDataGridViewTextBoxColumn.DataPropertyName = "Horario";
            this.horarioDataGridViewTextBoxColumn.HeaderText = "Horario";
            this.horarioDataGridViewTextBoxColumn.Name = "horarioDataGridViewTextBoxColumn";
            this.horarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacidadDataGridViewTextBoxColumn
            // 
            this.capacidadDataGridViewTextBoxColumn.DataPropertyName = "Capacidad";
            this.capacidadDataGridViewTextBoxColumn.HeaderText = "Capacidad";
            this.capacidadDataGridViewTextBoxColumn.Name = "capacidadDataGridViewTextBoxColumn";
            this.capacidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // espaciosDisponiblesDataGridViewTextBoxColumn
            // 
            this.espaciosDisponiblesDataGridViewTextBoxColumn.DataPropertyName = "EspaciosDisponibles";
            this.espaciosDisponiblesDataGridViewTextBoxColumn.HeaderText = "EspaciosDisponibles";
            this.espaciosDisponiblesDataGridViewTextBoxColumn.Name = "espaciosDisponiblesDataGridViewTextBoxColumn";
            this.espaciosDisponiblesDataGridViewTextBoxColumn.ReadOnly = true;
            this.espaciosDisponiblesDataGridViewTextBoxColumn.Width = 130;
            // 
            // VistaAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(909, 440);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gimnasio - Vista Administrador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VistaAdministrador_FormClosing);
            this.Load += new System.EventHandler(this.VistaAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridClases)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.claseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource claseBindingSource;
        private System.Windows.Forms.BindingSource claseBindingSource1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnMinimize;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridClases;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreInstructorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn espaciosDisponiblesDataGridViewTextBoxColumn;
    }
}