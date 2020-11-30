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

namespace ElectroSoftWPF.Usuario
{
    /// <summary>
    /// Lógica de interacción para vwCambiarLogin.xaml
    /// </summary>
    public partial class vwCambiarLogin : Window
    {
        public vwCambiarLogin()
        {
            InitializeComponent();
        }
        UsuarioImpl ui;
        Validaciones v = new Validaciones();
        MUsuario user;
        void FillDataGrid()
        {
            try
            {
                ui = new UsuarioImpl();
                DgvDatos.ItemsSource = null;
                DgvDatos.ItemsSource = ui.Select().DefaultView;
                DgvDatos.Columns[0].Visibility = Visibility.Hidden;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + " error al filtrar");
            }
        }
        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtModificar_Click(object sender, RoutedEventArgs e)
        {
            //stpDatos.IsEnabled = true;
            DgvDatos.IsEnabled = true;
            try
            {
                if (DgvDatos.SelectedIndex >= 0)
                {

                    if (txtNombreUsuario.Text != "" && txtPasswordA.Password != "")
                    {
                        if (txtPasswordN.Password != "")
                        {
                            user.PrimerApellido = txtNombreUsuario.Text;
                            user.Ci = txtPasswordA.Password;
                            ui = new UsuarioImpl(user);

                            ui.UpdatePassword(txtPasswordN.Password);
                            MessageBox.Show("Password  Modificado con exito.. A:" + txtPasswordN.Password);
                            txtNombreUsuario.Text = "";
                            txtPasswordA.Password = "";
                            txtPasswordN.Password = "";

                            FillDataGrid();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Ingrese su nuevo Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar su Nombre de usuario y/o Password Actual");
                    }
                }
                else
                {
                    MessageBox.Show("Debe Seleccionar sus Datos de la Lista..!!");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al modificar Datos del Proveedor" + ex.Message);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtNombreUsuario_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            v.validarLetras(e);
        }

        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillDataGrid();
        }

        private void DgvDatos_SelectedCellsChanged_1(object sender, SelectedCellsChangedEventArgs e)
        {
            if (DgvDatos.Items.Count > 0 && DgvDatos.SelectedItem != null)
            {
                try
                {
                    ui = null;
                    DataRowView d = (DataRowView)DgvDatos.SelectedItem;
                    int id = int.Parse(d.Row.ItemArray[0].ToString());
                    ui = new UsuarioImpl();
                    user = ui.Get(id);
                    if (user != null)
                    {
                        txtNombreUsuario.Text = user.PrimerApellido;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            txtNombreUsuario.Clear();
            txtPasswordA.Clear();
            txtPasswordN.Clear();
            FillDataGrid();
        }
    }
}
