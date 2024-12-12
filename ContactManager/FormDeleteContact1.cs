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
    public partial class FormDeleteContact : Form
    {
        public FormDeleteContact()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(phone) || phone.Length != 9 || !long.TryParse(phone, out _))
            {
                MessageBox.Show("Por favor, ingresa un número de teléfono válido.", "Error");
                return;
            }

            Contact contact = Contact.Contacts.Find(c => c.Phone == phone);
            if (contact == null)
            {
                MessageBox.Show("No se encontró ningún contacto con ese número.", "Error");
                return;
            }

            Contact.Contacts.Remove(contact);
            MessageBox.Show("Contacto eliminado correctamente.", "Éxito");
            this.Close();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
