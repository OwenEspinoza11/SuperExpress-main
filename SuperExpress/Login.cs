using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperExpress
{
    public partial class Login : Form
    {
        Conexion conexion;
        string Rol;
        int Count = 3;
        Inicio inicio;

        BackgroundWorker bg = new BackgroundWorker();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (Count == 0)
            {
                txtUsuario.Enabled = false;
                txtContraseña.Enabled = false;
                btnIngresar.Enabled = false;
                MessageBox.Show("Cometiste muchos errores, espera 10 segundos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Thread.Sleep(10000);
                txtUsuario.Enabled = true;
                txtContraseña.Enabled = true;
                btnIngresar.Enabled = true;
                Count = 4;
                Count--;

            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;

                if (txtUsuario.Text.Equals("") || txtContraseña.Text.Equals(""))
                {
                    MessageBox.Show("No pueden haber campos vacios", "Alerta");
                    Cursor.Current = Cursors.Default;
                    return;
                }

                conexion = new Conexion(txtUsuario.Text, txtContraseña.Text);
                if (this.conexion.connect.State == ConnectionState.Open)
                {

                    bg.WorkerReportsProgress = true;
                    bg.ProgressChanged += bg_ProgressChanged;
                    bg.DoWork += bg_DoWork;
                    bg.RunWorkerCompleted += bg_RunWorkerCompleted;
                    bg.RunWorkerAsync();
                    LblProgresB.Visible = true;
                    PBInicio.Visible = true;



                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    --Count;
                    MessageBox.Show("Error:usuario o contrasenia incorrecta ", Count + " Intentos restantes");
                    if (Count == 0)
                    {
                        MessageBox.Show("Cometiste muchos errores, espera 10 segundos!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Count = 3;
                        btnCancelar.Enabled = false;
                        btnIngresar.Enabled = false;
                        Thread.Sleep(10000);
                        btnCancelar.Enabled = true;
                        btnIngresar.Enabled = true;
                    }
                }

            }
        }

        private void bg_DoWork(object sender, EventArgs e)
        {
            int progreso = 0;


            for (int i = 0; i <= 100; i++)
            {
                progreso++;
                Thread.Sleep(50);
                bg.ReportProgress(i);
            }
        }

        private void bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PBInicio.Value = e.ProgressPercentage;
            PBInicio.Style = ProgressBarStyle.Continuous;


            if (e.ProgressPercentage > 100)
            {
                LblProgresB.Text = "100%";
                PBInicio.Value = PBInicio.Maximum;
            }
            else
            {
                LblProgresB.Text = Convert.ToString(e.ProgressPercentage) + "%";
                PBInicio.Value = e.ProgressPercentage;
            }
        }

        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show($"Acceso exitoso al sistema, iniciaste sesión como ADMIN ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible = false;

            inicio = new Inicio(conexion);

            inicio.Show();
            this.Hide();

            PBInicio.Value = 0;
            LblProgresB.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
