using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Model;
using Implementation;
using System.Data;

namespace ElectroSoftWPF.Ventas
{
    /// <summary>
    /// Lógica de interacción para winAdmVentas.xaml
    /// </summary>
    public partial class winAdmVentas : Window
    {
        public winAdmVentas()
        {
            InitializeComponent();
        }
        MCliente client;
        MProducto product;
        DataTable dt;
        ProductoVenta  productVent;
        List<detalleVenta> detalle;
        Validaciones obj = new Validaciones();
        //Methods methods;
        ProductoVenta PV;
        MVenta Vent;
        VentaImpl ventaImpl;
        List<ProductoVenta> listaProductos;
        void datosCliente()
        {
            client = null;
            if (Generica.idClient != 0)
            {
                client = new MCliente(Generica.idClient, Generica.nit, Generica.razonSocial);
                txtIdCliente.Text = client.IdCliente.ToString();
                txtNit.Text = client.Nit;
                txtRazonSocial.Text = client.RazonSocial;
            }
        }
        void datosProducto()
        {
            product = null;
            if (Generica.idProduct != 0)
            {
                product = new MProducto(Generica.idProduct, Generica.nombreProduct,  Generica.precioVent, Generica.stock);
                txtIdProducto.Text = product.IdProducto.ToString();
                txtNombreProducto.Text = product.NombreProducto;                            
                txtPrecioVenta.Text = product.PrecioVenta.ToString();
                txtStock.Text = product.Stock.ToString();
            }
        }
        public decimal calcularTotal()
        {
            try
            {
                decimal sum = 0;
                TextBlock x;
                for (int i = 0; i < dgvDatos.Items.Count; i++)
                {
                    x = dgvDatos.Columns[4].GetCellContent(dgvDatos.Items[i]) as TextBlock;
                    sum += decimal.Parse(x.Text);
                    txtTotalImporte.Text = sum.ToString();
                }
                return sum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return -1;
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtNit.IsEnabled = false;
            txtRazonSocial.IsEnabled = false;
            txtNombreProducto.IsEnabled = false;
            txtStock.IsEnabled = false;
            //txtPrecioVenta.IsEnabled = false;
        }

        private void BtnBuscarCliente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cliente.winAdmCliente vw = new Cliente.winAdmCliente();
                vw.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnProducto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Producto.winListaProducto vw = new Producto.winListaProducto();
                vw.ShowDialog();
                txtCantidad.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            datosCliente();
            datosProducto();
        }
        public void add()
        {
            bool esAgregado = false;
            if (txtCantidad.Text != "")
            {
                try
                {

                    if (int.Parse(txtCantidad.Text) > int.Parse(txtStock.Text))
                    {
                        MessageBox.Show("No hay cantidad suficiente");
                    }
                    else
                    {

                        ProductoVenta item = new ProductoVenta();

                        item.idProducto = product.IdProducto;
                        item.Nombre = txtNombreProducto.Text;
                        item.Stock = txtStock.Text;
                        item.PreVenta = decimal.Parse(txtPrecioVenta.Text);
                        item.CantProducto = int.Parse(txtCantidad.Text);
                        item.importe = item.PreVenta * item.CantProducto;

                        dgvDatos.Items.Add(item);
                        dgvDatos.UpdateLayout();
                        clearTextProducto();
                        decimal aux = calcularTotal();                    
                        esAgregado = true;
                    }
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message);
                }

            }
            else
            {
                if (esAgregado == false)
                {
                    MessageBox.Show("Ingresa La Cantidad..!!");
                }

            }
        }
        int cantidad = 0;
        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            if (dgvDatos.Items.Count > 0)
            {
                TextBlock id;
                cantidad = 0;
                for (int i = 0; i < dgvDatos.Items.Count; i++)
                {
                    id = dgvDatos.Columns[0].GetCellContent(dgvDatos.Items[i]) as TextBlock;
                    if (id.Text == txtIdProducto.Text)
                    {
                        cantidad++;
                    }
                  
                }
                if (cantidad == 0)
                {
                    add();
                }
                else
                {
                    MessageBox.Show("El producto ya ha sido ingresado");
                    txtIdProducto.Text = "";
                    txtNombreProducto.Text = "";
                    txtStock.Text = "";
                    txtPrecioVenta.Text = "";
                    txtCantidad.Text = "";
                }
            }
            else
            {
                cantidad = 0;
                add();
            }
        }
        void limpiar()
        {
            txtCantidad.Clear();
            txtIdCliente.Clear();
            txtIdProducto.Clear();
            txtNit.Clear();
            txtNombreProducto.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();
            txtTotalImporte.Clear();
            txtRazonSocial.Clear();
        }
        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            limpiar();
            dgvDatos.Items.Clear();
        }
        void Eliminar()
        {
            try
            {
                if (dgvDatos.SelectedIndex >= 0)
                {
                    for (int i = 0; i <= dgvDatos.SelectedItems.Count; i++)
                    {
                        dgvDatos.Items.Remove(dgvDatos.SelectedItems[i]);
                        decimal aux = calcularTotal();
                        //totalLetras();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            txtPrecioVenta.Focus();
            if (dgvDatos.SelectedItems != null && dgvDatos.Items.Count > 0)
            {
                ProductoVenta PV = new ProductoVenta();
                try
                {
                    if (dgvDatos.SelectedIndex >= 0)
                    {
                        PV = (ProductoVenta)dgvDatos.SelectedItem;
                        txtStock.Text = " " + PV.Stock;
                        txtNombreProducto.Text = " " + PV.Nombre;
                        txtPrecioVenta.Text = " " + PV.PreVenta;
                        txtCantidad.Text = " " + PV.CantProducto;
                        Eliminar();
                    }
                    else
                    {
                        MessageBox.Show("Debe Seleccionar  Datos Para Modificar:");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL CARGAR DATOS A LOS TXT PARA MOFIFICAR :" + ex.Message);
                }

            }
        }
        void clearTextProducto()
        {
           
            txtIdProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();
            txtCantidad.Clear();

        }

        void   ClearCliente()
            {
            txtIdCliente.Clear();
            txtNit.Clear();
            txtRazonSocial.Clear();
            }
        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dgvDatos.SelectedIndex >= 0)
                {
                    if (MessageBox.Show("Esta Segur@ De Eliminar Esta Fila..??", "ELIMINAR", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        for (int i = 0; i <= dgvDatos.SelectedItems.Count; i++)
                        {
                            dgvDatos.Items.Remove(dgvDatos.SelectedItems[i]);
                            decimal aux = calcularTotal();
                            //totalLetras();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe Seleccionar una fila si desea Eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVender_Click(object sender, RoutedEventArgs e)
        {
            {
                if (dgvDatos.Items.Count > 0)
                {
                    try
                    {

                        if (txtNit.Text != "" && txtRazonSocial.Text != "")
                        {
                            if (MessageBox.Show("Esta Segur@ de Realizar la venta..??", "Vender", MessageBoxButton.YesNo,
                            MessageBoxImage.Question) == MessageBoxResult.Yes)
                            {
                                Vent = new MVenta(decimal.Parse(txtTotalImporte.Text), 0, Sesion.idSesion, client.IdCliente);
                                detalle = new List<detalleVenta>();

                                TextBlock precioVenta, cantidad, idProducto;
                                for (int i = 0; i < dgvDatos.Items.Count; i++)
                                {
                                    precioVenta = dgvDatos.Columns[2].GetCellContent(dgvDatos.Items[i]) as TextBlock;
                                    cantidad = dgvDatos.Columns[3].GetCellContent(dgvDatos.Items[i]) as TextBlock;
                                    idProducto = dgvDatos.Columns[0].GetCellContent(dgvDatos.Items[i]) as TextBlock;
                                    detalleVenta det = new detalleVenta(decimal.Parse(precioVenta.Text), int.Parse(cantidad.Text.Trim()), int.Parse(idProducto.Text), Vent.idVenta);
                                    detalle.Add(det);
                                }
                            }
                            ventaImpl= new VentaImpl(Vent, detalle);
                            ventaImpl.Insert();

                            MessageBox.Show("La Venta Realizado Con Exito ");

                            dgvDatos.Items.Clear();
                            clearTextProducto();
                            ClearCliente();
                            txtTotalImporte.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Ingrese Datos Del cliente..!!");
                            txtNit.Focus();
                            clearTextProducto();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Debe requerir un Producto");
                }
            }
        }
    }
}
