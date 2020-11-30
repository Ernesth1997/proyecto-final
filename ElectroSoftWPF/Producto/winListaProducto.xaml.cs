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
using System.Data;
using Model;
using Implementation;


namespace ElectroSoftWPF.Producto
{
    /// <summary>
    /// Lógica de interacción para winListaProducto.xaml
    /// </summary>
    public partial class winListaProducto : Window
    {
        public winListaProducto()
        {
            InitializeComponent();
        }

        MProducto prod;
        ProductoImpl implProducto;

        void LoadDataGrid()
        {
            try
            {
                implProducto = new ProductoImpl();
                dgvDatos.ItemsSource = null;
                dgvDatos.ItemsSource = implProducto.Select().DefaultView;
                dgvDatos.Columns[0].Visibility = Visibility.Collapsed;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataGrid();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnSelecionarProducto_Click(object sender, RoutedEventArgs e)
        {
            if (prod != null)
            {
                Generica.idProduct = prod.IdProducto;
                Generica.nombreProduct = prod.NombreProducto;
                Generica.precioVent = prod.PrecioVenta;
                Generica.stock = prod.Stock;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe selecionar un Producto");
            }
        }

        private void miSelectProducto_Click(object sender, RoutedEventArgs e)
        {
            if (prod != null)
            {
                Generica.idProduct = prod.IdProducto;
                Generica.nombreProduct = prod.NombreProducto;
                Generica.precioVent = prod.PrecioVenta;
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe selecionar un Producto");
            }
        }

        private void dgvDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            prod = null;
            if (dgvDatos.SelectedItems != null && dgvDatos.Items.Count > 0)
            {
                try
                {
                    DataRowView dataRow = (DataRowView)dgvDatos.SelectedItem;

                    int idProducto = int.Parse(dataRow.Row.ItemArray[0].ToString());
                    implProducto = new ProductoImpl();
                    prod = implProducto.Get(idProducto);

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error en el get" + ex.Message);
                }

            }
        }
    }
}
