﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using SistemaGimnasio.View;

namespace SistemaGimnasio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.panel2.Paint += new PaintEventHandler(this.panel2_Paint);
            this.panel3.Paint += new PaintEventHandler(this.panel2_Paint);
        }

        #region DESIGN METHODS
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Crear un objeto Pen para dibujar la línea (color negro, grosor 2 píxeles)
            Pen pen = new Pen(Color.DimGray, 2);

            // Dibujar una línea desde las coordenadas (10, 10) hasta (200, 10)
            e.Graphics.DrawLine(pen, 10, 10, 440, 10);

            // Liberar los recursos del Pen después de usarlo
            pen.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Crear un objeto Pen para dibujar la línea (color negro, grosor 2 píxeles)
            Pen pen = new Pen(Color.DimGray, 2);

            // Dibujar una línea desde las coordenadas (10, 10) hasta (200, 10)
            e.Graphics.DrawLine(pen, 10, 10, 440, 10);

            // Liberar los recursos del Pen después de usarlo
            pen.Dispose();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.DimGray;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "CONTRASEÑA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "CONTRASEÑA";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string contrasena = txtPass.Text;

            // Llama a la función para autenticar
            if (Autenticar(usuario, contrasena, out string rol, out int idUsuario))
            {
                // Si el usuario es válido, abrir la vista correspondiente
                if (rol == "Administrador")
                {
                    VistaAdministrador vistaAdministrador = new VistaAdministrador();
                    vistaAdministrador.Show();
                    this.Hide(); // Opcional: Ocultar el formulario de login
                }
                else if (rol == "Socio")
                {
                    VistaSocio vistaSocio = new VistaSocio(idUsuario);
                    vistaSocio.Show();
                    this.Hide(); // Opcional: Ocultar el formulario de login
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private bool Autenticar(string usuario, string contrasena, out string rol, out int idUsuario)
        {
            rol = null;
            idUsuario = 0;

            using (SqlConnection connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SistemaGimnasio;Data Source=DESKTOP-PP0K0MS"))
            {
                string query = "SELECT Rol, ID_Usuario FROM Usuarios WHERE Nombre_Usuario = @usuario AND Contraseña = @contrasena";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@contrasena", contrasena);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        rol = reader["Rol"].ToString();
                        idUsuario = int.Parse(reader["ID_Usuario"].ToString());
                        return true; // Usuario autenticado
                    }
                }
            }

            return false; // Usuario no autenticado
        }
    }
}
