using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        private List<AddressBookEntry> addressBookEntries = new List<AddressBookEntry>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhoneNumber.Text;

            AddressBookEntry entry = new AddressBookEntry
            {
                Name = name,
                Email = email,
                PhoneNumber = phoneNumber
            };

            addressBookEntries.Add(entry);

            txtName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();

            MessageBox.Show("Entry saved successfully!");
        }
    }

    public class AddressBookEntry
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
