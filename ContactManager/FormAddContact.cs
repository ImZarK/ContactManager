using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager
{
    public partial class FormAddContact : Form
    {
        public FormAddContact()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("El nombre y el teléfono son obligatorios.", "Error");
                return;
            }

            if (phone.Length != 9 || !long.TryParse(phone, out _))
            {
                MessageBox.Show("El teléfono debe ser numérico y tener 11 dígitos.", "Error");
                return;
            }

            Contact.Contacts.Add(new Contact(name, phone));
            MessageBox.Show("Contacto añadido correctamente.", "Éxito");
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
