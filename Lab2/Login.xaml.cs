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

namespace Lab2
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }


        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtPassword.Password;

            if (Validar(usuario, contraseña)){

                Menu menu = new Menu();
                menu.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña invalidos");
            }
        }

        private bool Validar(string usuario, string contraseña)
        {
           
                return  usuario.ToLower() == "carlos" && contraseña.ToLower() == "123456";
          
            
        }

        private void SalirBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
