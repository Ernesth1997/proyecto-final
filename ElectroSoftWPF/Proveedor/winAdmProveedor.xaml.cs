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
namespace ElectroSoftWPF.Proveedor
{
    /// <summary>
    /// Lógica de interacción para winAdmProveedor.xaml
    /// </summary>
    public partial class winAdmProveedor : Window
    {
        Validaciones v = new Validaciones();
        MProveedor proveedor = null;
        ProveedorImpl implProveedor;
        byte op=0;
        void EnableButtons()
        {
            btnInsertar.IsEnabled = false;
            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;

            btnGuardar.IsEnabled = true;
            btnCancelar.IsEnabled = true;

            txtNombres.IsEnabled = true;
            txtPrimerApellido.IsEnabled = true;
            txtSegundoApellido.IsEnabled = true;
            txtDireccion.IsEnabled = true;
            txtTelefono.IsEnabled = true;
            txtNombres.Focus();
        }
        void DisableButtons()
        {
            btnInsertar.IsEnabled = true;
            btnModificar.IsEnabled = true;
            btnEliminar.IsEnabled = true;

            btnGuardar.IsEnabled = false;
            btnCancelar.IsEnabled = true;

            txtNombres.IsEnabled = false;
            txtPrimerApellido.IsEnabled = false;
            txtSegundoApellido.IsEnabled = false;
            txtDireccion.IsEnabled = false;
            txtTelefono.IsEnabled = false;
            
            txtNombres.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }
        void LoadDataGrid()
        {
            try
            {
                implProveedor = new ProveedorImpl();
                dgvDatos.ItemsSource = null;
                dgvDatos.ItemsSource = implProveedor.Select().DefaultView;
                dgvDatos.Columns[0].Visibility = Visibility.Collapsed;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void limpiar()
        {
            txtDireccion.Clear();
            txtNombres.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtTelefono.Clear();
            txtBuscar.Clear();
        }
        public winAdmProveedor()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case 1:
                    try
                    {
                        implProveedor = new ProveedorImpl();
                        int res = implProveedor.Insert(new MProveedor(txtNombres.Text.Trim(), txtPrimerApellido.Text.Trim(), txtSegundoApellido.Text.Trim(), txtDireccion.Text.Trim(), Convert.ToInt32(txtTelefono.Text.Trim())));
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
                    break;

                case 2:
                    try
                    {
                        implProveedor = new ProveedorImpl();
                        proveedor.Nombre = txtNombres.Text;
                        proveedor.PrimerApellido = txtPrimerApellido.Text;
                        proveedor.SegundoApellido =txtSegundoApellido.Text;
                        proveedor.Direccion = txtDireccion.Text;
                        proveedor.Telefono = Convert.ToInt32(txtTelefono.Text);
                        int res = implProveedor.Update(proveedor);
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
            if (proveedor != null && dgvDatos.Items.Count > 0 && dgvDatos.SelectedItem != null)
            {
                if (MessageBox.Show("Esta realmente seguro de eliminar el registro?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        implProveedor = new ProveedorImpl();
                        int res = implProveedor.Delete(proveedor);
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

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataGrid();
        }

        private void dgvDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgvDatos.Items.Count > 0 && dgvDatos.SelectedItem != null)
            {
                try
                {
                    proveedor = null;
                    DataRowView d = (DataRowView)dgvDatos.SelectedItem;
                    int id = int.Parse(d.Row.ItemArray[0].ToString());
                    implProveedor = new ProveedorImpl();
                    proveedor = implProveedor.Get(id);
                    if (proveedor != null)
                    {
                        txtNombres.Text = proveedor.Nombre;
                        txtPrimerApellido.Text = proveedor.PrimerApellido;
                        txtSegundoApellido.Text = proveedor.SegundoApellido;
                        txtDireccion.Text = proveedor.Direccion;
                        txtTelefono.Text = Convert.ToString(proveedor.Telefono);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtNombres_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            v.validarLetras(e);            
        }

        private void txtPrimerApellido_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            v.validarLetras(e);
        }

        private void txtSegundoApellido_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            v.validarLetras(e);
        }

        private void txtDireccion_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            v.validarLetras(e);
        }

        private void txtTelefono_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            v.validarNumeros(e);
        }
        void BuscarCliente()
        {
            try
            {
                implProveedor = new ProveedorImpl();
                dgvDatos.ItemsSource = null;
                dgvDatos.ItemsSource = implProveedor.BuscarProveedorN(txtBuscar.Text.Trim()).DefaultView;
                dgvDatos.Columns[0].Visibility = Visibility.Hidden;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                dgvDatos.ItemsSource = null;
            }
            else
            {
                if (txtBuscar.Text.Length >= 3)
                {
                    BuscarCliente();
                }
                else
                {
                    dgvDatos.ItemsSource = null;
                }
            }
        }

        private void txtBuscar_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            v.validarLetras(e);
        }
    }
}
