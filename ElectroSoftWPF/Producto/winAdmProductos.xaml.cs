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
    /// Lógica de interacción para winAdmProductos.xaml
    /// </summary>
    public partial class winAdmProductos : Window
    {
        Validaciones v = new Validaciones();
        MProducto producto = null;
        ProductoImpl implProducto;
        CategoriaImpl categoriaImp = null;
        byte op = 0;
        void EnableButtons()
        {
            btnInsertar.IsEnabled = false;
            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;

            btnGuardar.IsEnabled = true;
            btnCancelar.IsEnabled = true;

            txtCategoria.IsEnabled = true;
            txtCompra.IsEnabled = true;
            txtNombreProducto.IsEnabled = true;
            txtStock.IsEnabled = true;
            txtVenta.IsEnabled = true;
            txtNombreProducto.Focus();
        }
        void DisableButtons()
        {
            btnInsertar.IsEnabled = true;
            btnModificar.IsEnabled = true;
            btnEliminar.IsEnabled = true;

            btnGuardar.IsEnabled = false;
            btnCancelar.IsEnabled = true;

            txtCategoria.IsEnabled = false;
            txtCompra.IsEnabled = false;
            txtNombreProducto.IsEnabled = false;
            txtStock.IsEnabled = false;
            txtVenta.IsEnabled = false;
        }
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
        void FillComboCategoria()
        {
            try
            {
                categoriaImp = new CategoriaImpl();
                txtCategoria.DisplayMemberPath = "nombre";
                txtCategoria.SelectedValuePath = "idCategoria";
                txtCategoria.ItemsSource = categoriaImp.SelectIDName().DefaultView;
                txtCategoria.SelectedIndex = 0;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "comboBook categoria");
            }
        }


        public void limpiar()
        {
            txtStock.Clear();
            txtNombreProducto.Clear();
            txtCompra.Clear();
            txtVenta.Clear();
        }
        public winAdmProductos()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataGrid();
            FillComboCategoria();
        }

        private void txtNombreProducto_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            v.validarLetras(e);
        }

        private void txtCompra_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            v.validarNumeros(e);
        }

        private void txtVenta_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            v.validarNumeros(e);
        }
        private void txtStock_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            v.validarNumeros(e);
        }
        private void txtCategoria_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            v.validarNumeros(e);
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click(object sender, RoutedEventArgs e)
        {
            op = 1;
            EnableButtons();
            limpiar();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            op = 2;
            EnableButtons();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (producto != null && dgvDatos.Items.Count > 0 && dgvDatos.SelectedItem != null)
            {
                if (MessageBox.Show("Esta realmente seguro de eliminar el registro?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        implProducto = new ProductoImpl();
                        int res = implProducto.Delete(producto);
                        if (res > 0)
                        {
                            MessageBox.Show(res + " Registro eliminado");
                            LoadDataGrid();
                            DisableButtons();
                        }
                        else
                        {
                            MessageBox.Show("Error Inesperado");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case 1:
                    if (txtNombreProducto.Text != "" && txtNombreProducto.Text.Length > 3 && txtCompra.Text!= "" && txtVenta.Text!= "" && txtStock.Text!= "" && txtCategoria.Text!= "")

                    {
                        try
                        {
                            implProducto = new ProductoImpl();
                            int res = implProducto.Insert(new MProducto(txtNombreProducto.Text.Trim(),decimal.Parse(txtCompra.Text.Trim()),decimal.Parse(txtVenta.Text.Trim()),int.Parse(txtStock.Text.Trim()),int.Parse(txtCategoria.SelectedValue.ToString())));
                            if (res > 0)
                            {
                                MessageBox.Show("Registro insertado con éxito.");
                                LoadDataGrid();
                                DisableButtons();
                                limpiar();
                            }
                            else
                            {
                                MessageBox.Show("No se insertaron registros");
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Complete todos los campos correctamente !!!");
                    }
                    break;
                case 2:
                    try
                    {
                        implProducto = new ProductoImpl();
                        producto.NombreProducto = txtNombreProducto.Text;
                        producto.PrecioCompra =decimal.Parse(txtCompra.Text);
                        producto.PrecioVenta = decimal.Parse(txtVenta.Text);
                        producto.Stock = int.Parse(txtStock.Text);
                        producto.IdCategoria = int.Parse(txtCategoria.SelectedValue.ToString());
                        int res = implProducto.Update(producto);
                        if (res > 0)
                        {
                            MessageBox.Show("Registro modificado con éxito.");
                            LoadDataGrid();
                            DisableButtons();
                            limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se modificaron registros");
                        }
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DisableButtons();
            LoadDataGrid();
            limpiar();
        }

        private void dgvDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgvDatos.Items.Count > 0 && dgvDatos.SelectedItem != null)
            {
                try
                {
                    producto = null;
                    DataRowView d = (DataRowView)dgvDatos.SelectedItem;
                    int id = int.Parse(d.Row.ItemArray[0].ToString());
                    implProducto = new ProductoImpl();
                    producto = implProducto.Get(id);
                    if (producto != null)   
                    {
                        txtNombreProducto.Text = producto.NombreProducto;
                        txtCompra.Text = producto.PrecioCompra.ToString();
                        txtVenta.Text = producto.PrecioVenta.ToString();
                        txtStock.Text = producto.Stock.ToString();
                        txtCategoria.SelectedValue.ToString();
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
