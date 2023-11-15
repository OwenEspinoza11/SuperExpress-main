using CapaDatos;
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
    public partial class Inicio : Form
    {

        int n;
        public Inicio(Conexion conexion)
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void MenuProveedores_Click(object sender, EventArgs e)
        {
            Limpiar();
            LimpiarDataGridView();
            ProveedorMenu();
            OcultarFecha();
        }

        private void ProveedorMenu()
        {
            //se modifica la vaina según se necesite
            label1.Text = "Id Proveedor";
            label2.Text = "Nombre de proveedor";
            label3.Text = "Dirección";
            label4.Text = "Telefono";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            dateTimePicker1.Text = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;
        }

        private void OcultarFecha()
        {
            dateTimePicker2.Visible = false;
            dateTimePicker3.Visible = false;

            textBox7.Visible = true;
            textBox8.Visible = true;
        }

        private void MostrarFecha()
        {
            dateTimePicker2.Visible = true;
            dateTimePicker3.Visible = true;

            textBox7.Visible = false;
            textBox8.Visible = false;
        }

        private void LimpiarDataGridView()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
            LimpiarDataGridView();
            ProductoMenu();
            MostrarFecha();
        }

        private void ProductoMenu()
        {
            label1.Text = "Id Producto";
            label2.Text = "Nombre de producto";
            label3.Text = "Precio";
            label4.Text = "Stock";
            label5.Text = "Id Proveedor";
            label6.Text = "Categoria";
            label7.Text = "Fecha de lote";
            label8.Text = "Fecha de vencimiento";
            label9.Text = "";
            dateTimePicker1.Text = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            dateTimePicker2.Text = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            dateTimePicker3.Text = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;

            textBox9.Enabled = false;
        }

        private void MenuClientes_Click(object sender, EventArgs e)
        {
            ClientesMenu();
            Limpiar();
            LimpiarDataGridView();
            OcultarFecha();
        }

        private void ClientesMenu()
        {
            label1.Text = "Id Cliente";
            label2.Text = "Nombre";
            label3.Text = "Apellido";
            label4.Text = "Correo";
            label5.Text = "Telefono";
            dateTimePicker1.Text = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
            textBox9.Enabled = false;

            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //VentaMenu();
            //Limpiar();
            //LimpiarDataGridView();
        }

        private void VentaMenu()
        {
            //para ventas
            label1.Text = "Id Venta";
            label2.Text = "Id Cliente";
            label7.Text = "Fecha Venta";
            label4.Text = "Correo";
            label5.Text = "Telefono";

            label6.Text = "";
            label3.Text = "";
            label8.Text = "";
            label9.Text = "";

            dateTimePicker1.Text = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            dateTimePicker2.Text = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

            dateTimePicker2.Visible = true;

            textBox3.Visible = false;
            textBox7.Visible = false;

        }

        private void Limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }



        private void iBtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (label1.Text == "Id Proveedor")
            {
                // Crear una instancia de la clase Proveedores
                Proveedor proveedor = new Proveedor();

                // Asignar los valores de las propiedades
                // Intentar convertir la cadena a un valor entero de manera segura
                if (int.TryParse(textBox1.Text, out int idProveedor))
                {
                    // Asignar el valor convertido a la propiedad
                    proveedor.ID_Proveedor = idProveedor;
                }
                else
                {
                    // Manejar el caso en que la conversión no sea exitosa
                    MessageBox.Show("El valor en Id Proveedor no es un número entero válido.");
                    return; // Sale del método porque no se puede continuar con valores no válidos
                }

                proveedor.Nombre = textBox2.Text;
                proveedor.Direccion = textBox3.Text;
                proveedor.Telefono = textBox4.Text;
                proveedor.FechaRegistro = dateTimePicker1.Value;


                // Asegurarse de que el DataGridView tenga al menos una columna antes de agregar filas
                if (dataGridView1.Columns.Count == 0)
                {
                    // Agregar columnas al DataGridView
                    dataGridView1.Columns.Add("Columna1", "Id Proveedor");
                    dataGridView1.Columns.Add("Columna2", "Nombre");
                    dataGridView1.Columns.Add("Columna3", "Direccion");
                    dataGridView1.Columns.Add("Columna4", "Telefono");
                    dataGridView1.Columns.Add("Columna5", "Fecha agregado");
                    // Agregar más columnas según sea necesario
                }

                // Agregar una nueva fila al DataGridView
                int n = dataGridView1.Rows.Add();

                // Agregar los valores directamente usando el objeto Proveedores
                dataGridView1.Rows[n].Cells[0].Value = proveedor.ID_Proveedor;
                dataGridView1.Rows[n].Cells[1].Value = proveedor.Nombre;
                dataGridView1.Rows[n].Cells[2].Value = proveedor.Direccion;
                dataGridView1.Rows[n].Cells[3].Value = proveedor.Telefono;
                dataGridView1.Rows[n].Cells[4].Value = proveedor.FechaRegistro;

                Limpiar();
            }




            else if (label1.Text == "Id Cliente")
            {
                // Crear una instancia de la clase Proveedores
                Cliente cliente = new Cliente();

                // Asignar los valores de las propiedades
                // Intentar convertir la cadena a un valor entero de manera segura
                if (int.TryParse(textBox1.Text, out int idCliente))
                {
                    // Asignar el valor convertido a la propiedad
                    cliente.ID_Cliente = idCliente;
                }
                else
                {
                    // Manejar el caso en que la conversión no sea exitosa
                    MessageBox.Show("El valor en Id Cliente no es un número entero válido.");
                    return; // Sale del método porque no se puede continuar con valores no válidos
                }

                cliente.Nombre = textBox2.Text;
                cliente.Apellido = textBox3.Text;
                cliente.CorreoElectronico = textBox4.Text;
                cliente.Telefono = textBox5.Text;
                cliente.FechaRegistro = dateTimePicker1.Value;

                // Asegurarse de que el DataGridView tenga al menos una columna antes de agregar filas
                if (dataGridView1.Columns.Count == 0)
                {
                    // Agregar columnas al DataGridView
                    dataGridView1.Columns.Add("Columna1", "Id Cliente");
                    dataGridView1.Columns.Add("Columna2", "Nombre");
                    dataGridView1.Columns.Add("Columna3", "Apellido");
                    dataGridView1.Columns.Add("Columna4", "Correo");
                    dataGridView1.Columns.Add("Columna5", "Telefono");
                    dataGridView1.Columns.Add("Columna6", "Fecha agregado");
                    // Agregar más columnas según sea necesario
                }

                // Asegúrate de que hay al menos una fila antes de intentar acceder a las celdas
                if (dataGridView1.Rows.Count > 0)
                {
                    // Agregar una nueva fila al DataGridView
                    int n = dataGridView1.Rows.Add();

                    // Verificar que el índice de la fila sea válido
                    if (n >= 0 && n < dataGridView1.Rows.Count)
                    {
                        // Agregar los valores directamente usando el objeto Cliente
                        dataGridView1.Rows[n].Cells[0].Value = cliente.ID_Cliente;
                        dataGridView1.Rows[n].Cells[1].Value = cliente.Nombre;
                        dataGridView1.Rows[n].Cells[2].Value = cliente.Apellido;
                        dataGridView1.Rows[n].Cells[3].Value = cliente.CorreoElectronico;
                        dataGridView1.Rows[n].Cells[4].Value = cliente.Telefono;
                        dataGridView1.Rows[n].Cells[5].Value = cliente.FechaRegistro;

                        Limpiar();
                    }
                }
            }
        }

        private void MenuInfo_Click(object sender, EventArgs e)
        {
            frmInfo info = new frmInfo();
            info.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            VentaMenu();
            Limpiar();
            LimpiarDataGridView();
            MostrarFecha();
        }

        private void btnDetalleVenta_Click(object sender, EventArgs e)
        {
            DetVentaMenu();
            Limpiar();
            LimpiarDataGridView();
            OcultarFecha();
        }

        private void DetVentaMenu()
        {
            //para ventas
            label1.Text = "Id detalle venta";
            label2.Text = "Id Venta";
            label3.Text = "Id Producto";
            label4.Text = "Cantidad";
            label5.Text = "Precio";
            label6.Text = "Subtotal";

            label7.Text = "";
            label8.Text = "";
            label9.Text = "";

            dateTimePicker1.Text = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            dateTimePicker2.Text = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

            dateTimePicker2.Visible = false;

            textBox3.Visible = false;
            textBox7.Visible = false;

        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CompraMenu();
            Limpiar();
            LimpiarDataGridView();
            MostrarFecha();
        }

        private void CompraMenu()
        {
            label1.Text = "Id Venta";
            label2.Text = "Total";
            label7.Text = "Fecha Compra";

            label4.Text = "";
            label5.Text = "";

            label6.Text = "";
            label3.Text = "";
            label8.Text = "";
            label9.Text = "";

            dateTimePicker1.Text = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            dateTimePicker2.Text = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

            dateTimePicker2.Visible = true;

            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
        }

        private void verDetalleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DetCompraMenu();
            Limpiar();
            LimpiarDataGridView();
            OcultarFecha();
        }

        private void DetCompraMenu()
        {
            //para ventas
            label1.Text = "Id detalle compra";
            label2.Text = "Id compra";
            label3.Text = "Id Producto";
            label4.Text = "Cantidad";
            label5.Text = "Precio";
            label6.Text = "Subtotal";

            label7.Text = "";
            label8.Text = "";
            label9.Text = "";

            dateTimePicker1.Text = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
            dateTimePicker2.Text = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");

            dateTimePicker2.Visible = false;

            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
        }
    }
}
