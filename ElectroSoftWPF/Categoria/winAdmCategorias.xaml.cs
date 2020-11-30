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

namespace ElectroSoftWPF.Categoria
{
    /// <summary>
    /// Lógica de interacción para winAdmCategorias.xaml
    /// </summary>
    public partial class winAdmCategorias : Window
    {
        Validaciones v = new Validaciones();
        MCategoria categoria = null;
        CategoriaImpl implCategoria;
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

            txtCategoria.IsEnabled = true;
            txtDescripcion.IsEnabled = true;
            txtCategoria.Focus();
        }
        void DisableButtons()
        {
            btnInsertar.IsEnabled = true;
            btnModificar.IsEnabled = true;
            btnEliminar.IsEnabled = true;

            btnGuardar.IsEnabled = false;
            btnCancelar.IsEnabled = true;

            txtCategoria.IsEnabled = false;
            txtDescripcion.IsEnabled = false;
            
            txtDescripcion.Clear();
        }
        void LoadDataGrid()
        {
            try
            {
                implCategoria = new CategoriaImpl();
                dgvDatos.ItemsSource = null;
                dgvDatos.ItemsSource = implCategoria.Select().DefaultView;
                dgvDatos.Columns[0].Visibility = Visibility.Collapsed;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void limpiar()
        {
            txtDescripcion.Clear();
            txtCategoria.Clear();
        }
        public winAdmCategorias()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDataGrid();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case 1:
                    if (txtDescripcion.Text != "" && txtDescripcion.Text.Length>3 && txtCategoria.Text != "" && txtCategoria.Text.Length > 3)
                    {
                        try
                        {
                            implCategoria = new CategoriaImpl();
                            int res = implCategoria.Insert(new MCategoria(txtCategoria.Text.Trim(), txtDescripcion.Text.Trim()));
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
                        MessageBox.Show("Ingrese una descripcion y/o selecione una categoria!!");
                    }
                    break;
                case 2:
                    try
                    {
                        implCategoria = new CategoriaImpl();
                        categoria.Nombre = txtCategoria.Text;
                        categoria.Descripcion = txtDescripcion.Text;
                        int res = implCategoria.Update(categoria);
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
            if (categoria != null && dgvDatos.Items.Count > 0 && dgvDatos.SelectedItem != null)
            {
                if (MessageBox.Show("Esta realmente seguro de eliminar el registro?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        implCategoria = new CategoriaImpl();
                        int res = implCategoria.Delete(categoria);
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

        private void dgvDatos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgvDatos.Items.Count > 0 && dgvDatos.SelectedItem != null)
            {
                try
                {
                    categoria = null;
                    DataRowView d = (DataRowView)dgvDatos.SelectedItem;
                    int id = int.Parse(d.Row.ItemArray[0].ToString());
                    implCategoria = new CategoriaImpl();
                    categoria = implCategoria.Get(id);
                    if (categoria != null)
                    {
                        txtCategoria.Text = categoria.Nombre;
                        txtDescripcion.Text = categoria.Descripcion;
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

        private void txtDescripcion_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            v.validarLetras(e);
        }

        private void txtCategoria_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            v.validarLetras(e);
        }
    }
}
