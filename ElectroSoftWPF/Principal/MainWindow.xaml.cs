using System;
using System.Windows;
using System.Windows.Controls;
using Model;

namespace ElectroSoftWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void lvwMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                       
        }

        private void ItemHome_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ItemCategoria_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void ItemUsuario_Selected(object sender, RoutedEventArgs e)
        {

        }
        

        private void btnOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            btnOpenMenu.Visibility = Visibility.Hidden;
            btnMenuCollapse.Visibility = Visibility.Visible;
            ImgLogo.Visibility = Visibility.Visible;
        }

        private void btnMenuCollapse_Click(object sender, RoutedEventArgs e)
        {
            btnMenuCollapse.Visibility = Visibility.Hidden;
            btnOpenMenu.Visibility = Visibility.Visible;
            ImgLogo.Visibility = Visibility.Hidden;
            
            //MainMenu.Width=Convert.ToDouble(Stretch.Fill);
        }
        private void btnCliente_Click(object sender, RoutedEventArgs e)
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

        private void btnUsuario_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Usuario.winAdmUsuario vw = new Usuario.winAdmUsuario();
                vw.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnProveedor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Proveedor.winAdmProveedor vw = new Proveedor.winAdmProveedor();
                vw.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnCategoria_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Categoria.winAdmCategorias vw = new Categoria.winAdmCategorias();
                vw.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void UpdateUsuario_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Usuario.vwCambiarLogin vw = new Usuario.vwCambiarLogin();
                vw.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void itemReportes_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            try
            {
                lblUsuario.Content = " rol : " + Sesion.rolSesion + " \n" + " usuario : " + Sesion.usuarioSesion + " ";

                switch (Sesion.rolSesion)
                {
                    case "Almacenero":
                        //ItemProveedor.Visibility = Visibility.Hidden;
                        //ItemCliente.Visibility = Visibility.Hidden;
                        //ItemUpdateUsuario.Visibility = Visibility.Hidden;
                        viewItemUsuario.Visibility = Visibility.Hidden;

                        break;
                    case "Contador":
                        viewItemUpdatePassword.Visibility = Visibility.Hidden;
                        viewItemCliente.Visibility = Visibility.Hidden;
                        viewItemRegistroProducto.Visibility = Visibility.Hidden;
                        viewItemUsuario.Visibility = Visibility.Hidden;

                        break;
                }
            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.Message);
            }

        }

        private void btnListaCliente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Producto.winAdmProductos vw = new Producto.winAdmProductos();
                vw.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnListProducto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Producto.winListaProducto vw = new Producto.winListaProducto();
                vw.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnListaProducto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Producto.winAdmProductos vw = new Producto.winAdmProductos();
                vw.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnVenta_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Ventas.winAdmVentas vw = new Ventas.winAdmVentas();
                vw.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


    }
}
