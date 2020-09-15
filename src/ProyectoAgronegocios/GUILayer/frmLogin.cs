using ProyectoAgronegocios.BusinessLayer;
using ProyectoAgronegocios.Entities;
using System;
using System.Windows.Forms;

namespace ProyectoAgronegocios.GUILayer
{
    public partial class frmLogin : Form
    {
        private bool isClosed = false;
        private Empleado user;
        private int temporizador = 3;

        public frmLogin()
        {
            InitializeComponent();
        }

        public bool IsClosed { get => isClosed; set => isClosed = value; }
        internal Empleado User { get => user; set => user = value; }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            if (txtUsuario.Text.Length == 0)
            {
                lblEstadoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
                lblEstadoLogin.ForeColor = System.Drawing.Color.White;
                lblEstadoLogin.Text = "DATO OBLIGATORIO: USUARIO";
                txtUsuario.Focus();

                return;
            }

            if (txtClave.Text.Length == 0)
            {
                lblEstadoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
                lblEstadoLogin.ForeColor = System.Drawing.Color.White;
                lblEstadoLogin.Text = "DATO OBLIGATORIO: CLAVE";
                txtClave.Focus();

                return;
            }

            User = EmpleadoService.validarUsuario(txtUsuario.Text, txtClave.Text);

            if (user != null)
            {
                btnIngresar.Enabled = false;
                tempoAcceso.Enabled = true;
            }
            else
            {
                lblEstadoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
                lblEstadoLogin.ForeColor = System.Drawing.Color.White;
                lblEstadoLogin.Text = "ACCESO DENEGADO - DATOS INCORRECTOS";

                txtClave.Text = "";
                txtUsuario.Text = "";
                txtUsuario.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            isClosed = true;
            Close();
        }

        private void tempoAcceso_Tick(object sender, EventArgs e)
        {
            lblEstadoLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            lblEstadoLogin.ForeColor = System.Drawing.Color.White;
            lblEstadoLogin.Text = "ACCESO CORRECTO [" + temporizador.ToString() + "]";
            temporizador--;

            if (temporizador == -1)
            {
                tempoAcceso.Enabled = false;
                Close();
            }
        }
    }
}
