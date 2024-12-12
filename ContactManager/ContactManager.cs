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
    public partial class ContactManager : Form  
    {
        public ContactManager()
        {
            InitializeComponent();
        }

        private void btnSearchContact_Click(object sender, EventArgs e)
        {
            FormSearchContact searchForm = new FormSearchContact();
            searchForm.ShowDialog();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            FormAddContact addForm = new FormAddContact();
            addForm.ShowDialog();
        }

        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            FormUpdateContact updateForm = new FormUpdateContact();
            updateForm.ShowDialog();
        }

        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            FormDeleteContact deleteForm = new FormDeleteContact();
            deleteForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
