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
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridReservas = new System.Windows.Forms.DataGridView();
            this.NombreClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreInstructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EspaciosDisponibles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReservarLugar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.claseBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "CLASES";
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
            this.gridReservas.Size = new System.Drawing.Size(751, 319);
            this.gridReservas.TabIndex = 7;
            this.gridReservas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridReservas_CellClick_1);
            // 
            // NombreClase
            // 
            this.NombreClase.DataPropertyName = "NombreClase";
            this.NombreClase.HeaderText = "Clase";
            this.NombreClase.Name = "NombreClase";
            // 
            // NombreInstructor
            // 
            this.NombreInstructor.DataPropertyName = "NombreInstructor";
            this.NombreInstructor.HeaderText = "Instructor";
            this.NombreInstructor.Name = "NombreInstructor";
            // 
            // Dias
            // 
            this.Dias.DataPropertyName = "Dias";
            this.Dias.HeaderText = "Dias";
            this.Dias.Name = "Dias";
            // 
            // Horario
            // 
            this.Horario.DataPropertyName = "Horario";
            this.Horario.HeaderText = "Horario";
            this.Horario.Name = "Horario";
            // 
            // Capacidad
            // 
            this.Capacidad.DataPropertyName = "Capacidad";
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            // 
            // EspaciosDisponibles
            // 
            this.EspaciosDisponibles.DataPropertyName = "EspaciosDisponibles";
            this.EspaciosDisponibles.HeaderText = "EspaciosDisponible";
            this.EspaciosDisponibles.Name = "EspaciosDisponibles";
            this.EspaciosDisponibles.Width = 110;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(768, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 64);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancelar reserva";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idReservaDataGridViewTextBoxColumn
            // 
            this.idReservaDataGridViewTextBoxColumn.DataPropertyName = "IdReserva";
            this.idReservaDataGridViewTextBoxColumn.HeaderText = "IdReserva";
            this.idReservaDataGridViewTextBoxColumn.Name = "idReservaDataGridViewTextBoxColumn";
            // 
            // idClaseDataGridViewTextBoxColumn
            // 
            this.idClaseDataGridViewTextBoxColumn.DataPropertyName = "IdClase";
            this.idClaseDataGridViewTextBoxColumn.HeaderText = "IdClase";
            this.idClaseDataGridViewTextBoxColumn.Name = "idClaseDataGridViewTextBoxColumn";
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // nombreClaseDataGridViewTextBoxColumn
            // 
            this.nombreClaseDataGridViewTextBoxColumn.DataPropertyName = "NombreClase";
            this.nombreClaseDataGridViewTextBoxColumn.HeaderText = "NombreClase";
            this.nombreClaseDataGridViewTextBoxColumn.Name = "nombreClaseDataGridViewTextBoxColumn";
            // 
            // nombreInstructorDataGridViewTextBoxColumn
            // 
            this.nombreInstructorDataGridViewTextBoxColumn.DataPropertyName = "NombreInstructor";
            this.nombreInstructorDataGridViewTextBoxColumn.HeaderText = "NombreInstructor";
            this.nombreInstructorDataGridViewTextBoxColumn.Name = "nombreInstructorDataGridViewTextBoxColumn";
            // 
            // diasDataGridViewTextBoxColumn
            // 
            this.diasDataGridViewTextBoxColumn.DataPropertyName = "Dias";
            this.diasDataGridViewTextBoxColumn.HeaderText = "Dias";
            this.diasDataGridViewTextBoxColumn.Name = "diasDataGridViewTextBoxColumn";
            // 
            // horarioDataGridViewTextBoxColumn
            // 
            this.horarioDataGridViewTextBoxColumn.DataPropertyName = "Horario";
            this.horarioDataGridViewTextBoxColumn.HeaderText = "Horario";
            this.horarioDataGridViewTextBoxColumn.Name = "horarioDataGridViewTextBoxColumn";
            // 
            // capacidadDataGridViewTextBoxColumn
            // 
            this.capacidadDataGridViewTextBoxColumn.DataPropertyName = "Capacidad";
            this.capacidadDataGridViewTextBoxColumn.HeaderText = "Capacidad";
            this.capacidadDataGridViewTextBoxColumn.Name = "capacidadDataGridViewTextBoxColumn";
            // 
            // espaciosDisponiblesDataGridViewTextBoxColumn
            // 
            this.espaciosDisponiblesDataGridViewTextBoxColumn.DataPropertyName = "EspaciosDisponibles";
            this.espaciosDisponiblesDataGridViewTextBoxColumn.HeaderText = "EspaciosDisponibles";
            this.espaciosDisponiblesDataGridViewTextBoxColumn.Name = "espaciosDisponiblesDataGridViewTextBoxColumn";
            // 
            // reservaBindingSource1
            // 
            this.reservaBindingSource1.DataSource = typeof(SistemaGimnasio.Reserva);
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(SistemaGimnasio.Reserva);
            // 
            // claseBindingSource
            // 
            this.claseBindingSource.DataSource = typeof(SistemaGimnasio.Clase);
            // 
            // VistaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReservarLugar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridReservas);
            this.Name = "VistaSocio";
            this.Text = "VistaSocio";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridReservas;
        private System.Windows.Forms.BindingSource claseBindingSource;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.Button btnReservarLugar;
        private System.Windows.Forms.Button button1;
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
    }
}