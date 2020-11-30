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
namespace ElectroSoftWPF.Cliente
{
    /// <summary>
    /// Lógica de interacción para winAdmCliente.xaml
    /// </summary>
    public partial class winAdmCliente : Window
    {
        Validaciones v = new Validaciones();
        MCliente cliente=null;
        ClienteImpl implCliente;
        /// <summary>
        /// 1 insert 2 update
        /// </summary>
        byte op = 0;
        void EnableButtons()
        {
            btnInsertar.IsEnabled = false;
            btnModificar.IsEnabled = false;
            btnEliminar.IsEnabled = false;

            btnGuardar.IsEnabled = true;
            btnCancelar.IsEnabled = true;

            txtNit.IsEnabled = true;
            txtRazonSocial.IsEnabled = true;
            txtNit.Focus();
        }
  

        void DisableButtons()
        {
            btnInsertar.IsEnabled = true;
            btnModificar.IsEnabled = true;
            btnEliminar.IsEnabled = true;

            btnGuardar.IsEnabled = false;
            btnCancelar.IsEnabled = true;

            txtNit.IsEnabled = false;
            txtRazonSocial.IsEnabled = false;

            txtNit.Clear();
            txtRazonSocial.Clear();
        }
        public void limpiar()
        {
            txtBuscar.Clear();
            txtNit.Clear();
            txtRazonSocial.Clear();
        }
        void LoadDataGrid()
        {
            try
            {
                implCliente=new ClienteImpl();
                dgvDatos.ItemsSource = null;
                dgvDatos.ItemsSource = implCliente.Select().DefaultView;
                dgvDatos.Columns[0].Visibility = Visibility.Collapsed;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void BuscarCliente()
        {
            try
            {
                implCliente = new ClienteImpl();
                dgvDatos.ItemsSource = null;
                dgvDatos.ItemsSource = implCliente.BuscarClienteN(txtBuscar.Text.Trim(),txtBuscar.Text.Trim()).DefaultView;
                dgvDatos.Columns[0].Visibility = Visibility.Hidden;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public winAdmCliente()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        void insertar()
        {
            implCliente = new ClienteImpl();
            int res = implCliente.Insert(new MCliente(txtNit.Text.Trim(), txtRazonSocial.Text.Trim()));
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
        void modificar()
        {
            implCliente = new ClienteImpl();
            cliente.Nit = txtNit.Text;
            cliente.RazonSocial = txtRazonSocial.Text;
            int res = implCliente.Update(cliente);
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
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case 1:
                    if (txtNit.Text != "" && txtNit.Text.Length>3 && txtRazonSocial.Text != "" && txtRazonSocial.Text.Length>2)
                    {
                        try
                        {
                            if (dgvDatos.Items.Count>0)
                            {
                                TextBlock ci;
                                int cantidad = 0;
                                for (int i = 0; i < dgvDatos.Items.Count; i++)
                                {
                                    ci = dgvDatos.Columns[1].GetCellContent(dgvDatos.Items[i]) as TextBlock;
                                    if (ci.Text==txtNit.Text)
                                    {
                                        cantidad++;
                                    }
                                    if (cantidad == 0)
                                    {
                                        insertar();
                                    }
                                    else
                                    {
                                        MessageBox.Show("El Nit/Ci ya se encuentra registrado intente nuevamente...");
                                    }
                                    break;
                                }
                            } 
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                    else {
                        MessageBox.Show("Ingrese  Nit y/o Razon Social Del Cliente correctamente...");

                    }
                    break;
                case 2:
                    try
                    {
                        if (dgvDatos.Items.Count > 0)
                        {
                            TextBlock ci;
                            int cantidad = 0;
                            for (int i = 0; i < dgvDatos.Items.Count; i++)
                            {
                                ci = dgvDatos.Columns[1].GetCellContent(dgvDatos.Items[i]) as TextBlock;
                                if (ci.Text == txtNit.Text)
                                {
                                    cantidad++;
                                }
                                if (cantidad == 0)
                                {
                                    modificar();
                                }
                                else
                                {
                                    MessageBox.Show("El Nit/Ci ya se encuentra registrado intente nuevamente...");
                                }
                                break;
                            }
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
            if (cliente != null && dgvDatos.Items.Count > 0 && dgvDatos.SelectedItem != null)
            {
                if (MessageBox.Show("Esta realmente seguro de eliminar el registro?","Eliminar",MessageBoxButton.YesNo,MessageBoxImage.Question)==MessageBoxResult.Yes)
                {
                    try
                    {
                        implCliente=new ClienteImpl();
                        int res=implCliente.Delete(cliente);
                        if (res>0)
                        {
                            LoadDataGrid();
                            MessageBox.Show(res + " Registro eliminado");
                            DisableButtons();
                            limpiar();
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataGrid();
        }

        private void dgvDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgvDatos.Items.Count>0&& dgvDatos.SelectedItem!=null)
            {
                try
                {
                    cliente = null;
                    DataRowView d = (DataRowView)dgvDatos.SelectedItem;
                    int id = int.Parse(d.Row.ItemArray[0].ToString());
                    implCliente=new ClienteImpl();
                    cliente = implCliente.Get(id);
                    if (cliente!=null)
                    {
                        txtNit.Text = cliente.Nit;
                        txtRazonSocial.Text = cliente.RazonSocial;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void txtRazonSocial_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void txtNit_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
           // v.validarNumeros(e);

        }

        private void txtRazonSocial_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            v.validarLetras(e);
        }

        private void txtBuscar_TextChanged(object sender, TextChangedEventArgs e)
        {
           if (txtBuscar.Text== "")
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

      

        private void dgvDatos_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {

        }

        private void BtnSelecCliente_Click(object sender, RoutedEventArgs e)
        {
            if (cliente != null)
            {
                Generica.idClient = cliente.IdCliente;
                Generica.nit = cliente.Nit;
                Generica.razonSocial = cliente.RazonSocial;
                this.Close();

            }
            else
            {
                MessageBox.Show("Debe selecionar un cliente");
            }
        }
    }
}
