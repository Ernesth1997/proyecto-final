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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;

namespace ElectroSoftWPF.Usuario
{
    /// <summary>
    /// Lógica de interacción para winAdmUsuario.xaml
    /// </summary>
    public partial class winAdmUsuario : System.Windows.Window
    {
        public winAdmUsuario()
        {
            InitializeComponent();
            
        }
       
        Validaciones v = new Validaciones();
        MUsuario usuario = null;
        UsuarioImpl implUsuario;
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

            txtSegundoApellido.IsEnabled = true;
            txtNombre.IsEnabled = true;
            txtPrimerApellido.IsEnabled = true;
            txtEmail.IsEnabled = true;
            txtCi.IsEnabled = true;
            cbxRol.IsEnabled = true;
            txtNombre.Focus();
        }
        void DisableButtons()
        {
            btnInsertar.IsEnabled = true;
            btnModificar.IsEnabled = true;
            btnEliminar.IsEnabled = true;

            btnGuardar.IsEnabled = false;
            btnCancelar.IsEnabled = true;

            txtSegundoApellido.IsEnabled = false;
            txtNombre.IsEnabled = false;
            txtPrimerApellido.IsEnabled = false;
            txtEmail.IsEnabled = false;
            txtCi.IsEnabled = false;
            cbxRol.IsEnabled = true;
            
        }
        void limpiar()
        {
            txtBuscar.Clear();
            txtSegundoApellido.Clear();
            txtNombre.Clear();
            txtPrimerApellido.Clear();
            txtEmail.Clear();
            txtCi.Clear();
            //cbxRol.Clear();
        }
        void modificar()
        {
            txtCi.IsEnabled = false;
        }
        void LoadDataGrid()
        {
            try
            {
                implUsuario = new UsuarioImpl();
                dgvDatos.ItemsSource = null;
                dgvDatos.ItemsSource = implUsuario.Select().DefaultView;
                dgvDatos.Columns[0].Visibility = Visibility.Collapsed;
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataGrid();
        }
        private void filas(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case 1:

                    if (txtNombre.Text!="" && txtPrimerApellido.Text!="")
                    {
                        if (txtCi.Text != "" && txtEmail.Text != "")
                        {
                            if (cbxRol.Text != "")
                            {
                                try
                                {
                                        implUsuario = new UsuarioImpl();
                                        int res = implUsuario.Insert(new MUsuario(txtNombre.Text.Trim(), txtPrimerApellido.Text.Trim(), txtSegundoApellido.Text.Trim(), txtCi.Text.Trim(), txtEmail.Text.Trim(), cbxRol.Text));
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
                                MessageBox.Show("Seleccione un rol!");
                            }
                                
                        }
                        else
                        {
                            MessageBox.Show("ingrese ci y/o email");
                        
                        }
                    }
                    else
                    {
                        MessageBox.Show("ingrese nombre completo");

                    }
 
            break;
                   case 2:

                    try
                    {
                        implUsuario = new UsuarioImpl();
                        usuario.Nombre = txtNombre.Text;
                        usuario.PrimerApellido = txtPrimerApellido.Text;
                        usuario.SegundoApellido = txtSegundoApellido.Text;
                        usuario.Email = txtEmail.Text;
                        usuario.Rol = cbxRol.Text;
                        int res = implUsuario.Update(usuario);
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
            modificar();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (usuario != null && dgvDatos.Items.Count > 0 && dgvDatos.SelectedItem != null)
            {
                if (MessageBox.Show("Esta realmente seguro de eliminar el registro?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        implUsuario = new UsuarioImpl();
                        int res = implUsuario.Delete(usuario);
                        if (res > 0)
                        {
                            MessageBox.Show(res + " Registro eliminado");
                            LoadDataGrid();
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

        private void dgvDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgvDatos.Items.Count > 0 && dgvDatos.SelectedItem != null)
            {
                try
                {
                    usuario = null;
                    DataRowView d = (DataRowView)dgvDatos.SelectedItem;
                    int id = int.Parse(d.Row.ItemArray[0].ToString());
                    implUsuario = new UsuarioImpl();
                    usuario = implUsuario.Get(id);
                    if (usuario != null)
                    {
                        txtNombre.Text = usuario.Nombre;
                        txtPrimerApellido.Text = usuario.PrimerApellido;
                        txtSegundoApellido.Text = usuario.SegundoApellido;
                        txtEmail.Text = usuario.Email;
                        cbxRol.Text = usuario.Rol;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtNombre_PreviewTextInput(object sender, TextCompositionEventArgs e)
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

        private void txtCi_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }
        private void txtEmail_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //v.email(e);            
        }

        private void BtnExcel_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            try
            {


                excel.Cells.Borders.ColorIndex = 5;
                excel.Cells.Interior.ColorIndex = 10;


                for (int j = 1; j < dgvDatos.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[j];

                    sheet1.Cells[j].Font.Bold = 14;
                    sheet1.Cells[j].Interior.ColorIndex = 8;

                    sheet1.Columns[j].ColumnWidth = 15;
                    myRange.Value2 = dgvDatos.Columns[j].Header;
                }
                for (int j = 0; j < dgvDatos.Items.Count; j++)
                {
                    for (int i = 1; i < dgvDatos.Columns.Count; i++)
                    {
                        Range myRange = (Range)sheet1.Cells[j + 2, i];
                        myRange.Value2 = ((DataRowView)dgvDatos.Items[j]).Row[i].ToString();
                    }
                }
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
                implUsuario = new UsuarioImpl();
                dgvDatos.ItemsSource = null;
                dgvDatos.ItemsSource = implUsuario.BuscarUsuario(txtBuscar.Text.Trim()).DefaultView;
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

        private void txtRol_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            v.validarLetras(e);
        }
    }
}
