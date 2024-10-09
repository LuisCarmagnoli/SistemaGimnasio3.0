namespace SistemaGimnasio
{
    partial class VistaSocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaSocio));
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.gridReservas = new System.Windows.Forms.DataGridView();
            this.NombreClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInstructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EspaciosDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReservaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreInstructorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.espaciosDisponiblesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnReservarLugar = new System.Windows.Forms.Button();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.claseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Buscar clase:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(662, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(11, 34);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(645, 20);
            this.txtBuscar.TabIndex = 9;
            // 
            // gridReservas
            // 
            this.gridReservas.AutoGenerateColumns = false;
            this.gridReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreClase,
            this.NombreInstructor,
            this.Dias,
            this.Horario,
            this.Capacidad,
            this.EspaciosDisponibles,
            this.Estado,
            this.idReservaDataGridViewTextBoxColumn,
            this.idClaseDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.nombreClaseDataGridViewTextBoxColumn,
            this.nombreInstructorDataGridViewTextBoxColumn,
            this.diasDataGridViewTextBoxColumn,
            this.horarioDataGridViewTextBoxColumn,
            this.capacidadDataGridViewTextBoxColumn,
            this.espaciosDisponiblesDataGridViewTextBoxColumn});
            this.gridReservas.DataSource = this.reservaBindingSource1;
            this.gridReservas.Location = new System.Drawing.Point(11, 63);
            this.gridReservas.Name = "gridReservas";
            this.gridReservas.ReadOnly = true;
            this.gridReservas.Size = new System.Drawing.Size(751, 319);
            this.gridReservas.TabIndex = 7;
            this.gridReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridReservas_CellClick);
            // 
            // NombreClase
            // 
            this.NombreClase.DataPropertyName = "NombreClase";
            this.NombreClase.HeaderText = "Clase";
            this.NombreClase.Name = "NombreClase";
            this.NombreClase.ReadOnly = true;
            // 
            // NombreInstructor
            // 
            this.NombreInstructor.DataPropertyName = "NombreInstructor";
            this.NombreInstructor.HeaderText = "Instructor";
            this.NombreInstructor.Name = "NombreInstructor";
            this.NombreInstructor.ReadOnly = true;
            // 
            // Dias
            // 
            this.Dias.DataPropertyName = "Dias";
            this.Dias.HeaderText = "Dias";
            this.Dias.Name = "Dias";
            this.Dias.ReadOnly = true;
            // 
            // Horario
            // 
            this.Horario.DataPropertyName = "Horario";
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            this.Horario.ReadOnly = true;
            // 
            // Capacidad
            // 
            this.Capacidad.DataPropertyName = "Capacidad";
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.ReadOnly = true;
            // 
            // EspaciosDisponibles
            // 
            this.EspaciosDisponibles.DataPropertyName = "EspaciosDisponibles";
            this.EspaciosDisponibles.HeaderText = "EspaciosDisponible";
            this.EspaciosDisponibles.Name = "EspaciosDisponibles";
            this.EspaciosDisponibles.ReadOnly = true;
            this.EspaciosDisponibles.Width = 110;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // idReservaDataGridViewTextBoxColumn
            // 
            this.idReservaDataGridViewTextBoxColumn.DataPropertyName = "IdReserva";
            this.idReservaDataGridViewTextBoxColumn.HeaderText = "IdReserva";
            this.idReservaDataGridViewTextBoxColumn.Name = "idReservaDataGridViewTextBoxColumn";
            this.idReservaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClaseDataGridViewTextBoxColumn
            // 
            this.idClaseDataGridViewTextBoxColumn.DataPropertyName = "IdClase";
            this.idClaseDataGridViewTextBoxColumn.HeaderText = "IdClase";
            this.idClaseDataGridViewTextBoxColumn.Name = "idClaseDataGridViewTextBoxColumn";
            this.idClaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreClaseDataGridViewTextBoxColumn
            // 
            this.nombreClaseDataGridViewTextBoxColumn.DataPropertyName = "NombreClase";
            this.nombreClaseDataGridViewTextBoxColumn.HeaderText = "NombreClase";
            this.nombreClaseDataGridViewTextBoxColumn.Name = "nombreClaseDataGridViewTextBoxColumn";
            this.nombreClaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreInstructorDataGridViewTextBoxColumn
            // 
            this.nombreInstructorDataGridViewTextBoxColumn.DataPropertyName = "NombreInstructor";
            this.nombreInstructorDataGridViewTextBoxColumn.HeaderText = "NombreInstructor";
            this.nombreInstructorDataGridViewTextBoxColumn.Name = "nombreInstructorDataGridViewTextBoxColumn";
            this.nombreInstructorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diasDataGridViewTextBoxColumn
            // 
            this.diasDataGridViewTextBoxColumn.DataPropertyName = "Dias";
            this.diasDataGridViewTextBoxColumn.HeaderText = "Dias";
            this.diasDataGridViewTextBoxColumn.Name = "diasDataGridViewTextBoxColumn";
            this.diasDataGridViewTextBoxColumn.ReadOnly = true;
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
            // 
            // reservaBindingSource1
            // 
            this.reservaBindingSource1.DataSource = typeof(SistemaGimnasio.Reserva);
            // 
            // btnReservarLugar
            // 
            this.btnReservarLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservarLugar.Location = new System.Drawing.Point(768, 62);
            this.btnReservarLugar.Name = "btnReservarLugar";
            this.btnReservarLugar.Size = new System.Drawing.Size(100, 64);
            this.btnReservarLugar.TabIndex = 13;
            this.btnReservarLugar.Text = "Reservar lugar";
            this.btnReservarLugar.UseVisualStyleBackColor = true;
            this.btnReservarLugar.Click += new System.EventHandler(this.btnReservarLugar_Click);
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReserva.Location = new System.Drawing.Point(768, 132);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(100, 64);
            this.btnCancelarReserva.TabIndex = 14;
            this.btnCancelarReserva.Text = "Cancelar reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(SistemaGimnasio.Reserva);
            // 
            // claseBindingSource
            // 
            this.claseBindingSource.DataSource = typeof(SistemaGimnasio.Clase);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCerrarSesion.Location = new System.Drawing.Point(768, 313);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(100, 69);
            this.btnCerrarSesion.TabIndex = 15;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // VistaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 390);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnReservarLugar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.gridReservas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gimnasio - Vista Socio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VistaSocio_FormClosing);
            this.Load += new System.EventHandler(this.VistaSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.claseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView gridReservas;
        private System.Windows.Forms.BindingSource claseBindingSource;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.Button btnReservarLugar;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.BindingSource reservaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreInstructor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn EspaciosDisponibles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReservaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreInstructorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn espaciosDisponiblesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}