using JMShopAdmin.BusinessLayer;
using JMShopAdmin.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMShopAdmin.PresentationLayer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cierra el form LoginForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Comprueba credenciales y accede al menú principal si todos es correcto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            bool result = this.ValidateChildren();
            if (result)
            {
                Database.Connect();
                Boolean Confirmed = false;
                AdministradorDAO.GetAll();
                foreach (Administrador admin in MemoryObjectsDAO.GetListaAdministradores())
                {
                    if (admin.NombreUsuario == textBoxUserName.Text && admin.Password == textBoxPassword.Text)
                    {
                        Confirmed = true;
                    }
                }
                if (Confirmed)
                {
                    MainMenuForm newForm = new MainMenuForm();
                    newForm.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("No se ha podido establecer conexión con la base de datos, nombre de usuario y/o contraseña incorrecto/s");
                }
            }
            else
            {
                MessageBox.Show(this, "Se necesita rellenar nombre de usuario y contraseña", "invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Validacion para que no esté vacío la caja de nombre de admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxUserName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxUserName.Text != "")
            {
                errorProviderLogin.SetError(textBoxUserName, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderLogin.SetError(textBoxUserName, "Tienes que introducir algun valor.");
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Validacion para que no esté vacío la caja de contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPassword.Text != "")
            {
                errorProviderLogin.SetError(textBoxPassword, "");
                e.Cancel = false;
            }
            else
            {
                errorProviderLogin.SetError(textBoxPassword, "Tienes que introducir algun valor.");
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Navega a la pantalla de recuperar contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRecPass_Click(object sender, EventArgs e)
        {
            PasswordRecoveryForm newForm = new PasswordRecoveryForm();
            newForm.ShowDialog(this);
        }
    }
}
