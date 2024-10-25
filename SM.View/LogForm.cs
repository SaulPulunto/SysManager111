using Microsoft.VisualBasic.ApplicationServices;
using SM.BussinessLogic;
using SM.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SM.View
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string UserName = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            UsersBL userBL = UsersBL.Instance;

            try
            {
                if (userBL.Login(UserName, password))
                {
                    MessageBox.Show("Login exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MenuForm fr = new MenuForm();
                    fr.Show();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}

