using System;
using System.Collections.Generic;
using System.Data;
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
namespace ElectroSoftWPF.Usuario
{
    /// <summary>
    /// Lógica de interacción para vwLogin.xaml
    /// </summary>
    public partial class vwLogin : Window
    {
        public vwLogin()
        {
            InitializeComponent();
        }
        byte contador = 0;
        UsuarioImpl brl;

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {

            if (contador >= 3)
            {
                MessageBox.Show("Supero la cantidad de intentos permitidos el login");
                this.Close();
            }
            else
            {
                if (txtNombreUsuario.Text != "" && txtPassword.Password != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        brl = new UsuarioImpl();
                        dt = brl.Login1(txtNombreUsuario.Text, txtPassword.Password);
                        if (dt.Rows.Count > 0)
                        {


                            Sesion.idSesion = int.Parse(dt.Rows[0][0].ToString());
                            Sesion.usuarioSesion = dt.Rows[0][1].ToString();
                            Sesion.rolSesion = dt.Rows[0][2].ToString();

                            //string pass = txtPassword.Password;
                            this.Visibility = Visibility.Hidden;
                            MainWindow win = new MainWindow();
                            win.Show();
                            this.Close();
                        }
                        else
                        {
                            lblPasswordIncorrecto.Content = "Usuario y/o Contraseña Incorrecto";
                            contador++;

                            txtNombreUsuario.Text = "";
                            txtPassword.Password = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar un nombre de Usuario y Contraseña");
                    contador++;
                }
            }
        }


    

    private void BtnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnRecuperar_Click(object sender, RoutedEventArgs e)
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
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    }

