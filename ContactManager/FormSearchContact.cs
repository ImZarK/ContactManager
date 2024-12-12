using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class FormSearchContact : Form
    {
        public FormSearchContact()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(phone) || phone.Length != 9 || !long.TryParse(phone, out _))
            {
                MessageBox.Show("Por favor, ingresa un número de teléfono válido (9 dígitos).", "Error");
                return;
            }

            Contact contact = Contact.Contacts.Find(c => c.Phone == phone);

            if (contact != null)
            {
                lblResult.Text = $"Nombre: {contact.Name}\nTeléfono: {contact.Phone}";
            }
            else
            {
                lblResult.Text = "No se encontró ningún contacto con este número.";
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
