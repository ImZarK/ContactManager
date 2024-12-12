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
    public partial class FormUpdateContact : Form
    {
        public FormUpdateContact()
        {
            InitializeComponent();
        }

        private void txtNewPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textOldPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string oldPhone = textOldPhone.Text.Trim();
            string newName = txtNewName.Text.Trim();
            string newPhone = txtNewPhone.Text.Trim();

            if (string.IsNullOrEmpty(oldPhone) || oldPhone.Length != 9 || !long.TryParse(oldPhone, out _))
            {
                MessageBox.Show("Por favor, ingresa un número de teléfono válido del contacto a actualizar.", "Error");
                return;
            }

            Contact contact = Contact.Contacts.Find(c => c.Phone == oldPhone);
            if (contact == null)
            {
                MessageBox.Show("No se encontró ningún contacto con ese número.", "Error");
                return;
            }

            if (string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newPhone) || newPhone.Length != 9 || !long.TryParse(newPhone, out _))
            {
                MessageBox.Show("Por favor, ingresa datos válidos para el nuevo contacto.", "Error");
                return;
            }

            contact.Name = newName;
            contact.Phone = newPhone;
            MessageBox.Show("Contacto actualizado correctamente.", "Éxito");
            this.Close();
        }
    }
}
