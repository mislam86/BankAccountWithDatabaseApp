using System.Windows.Forms;
using BankAccountWithDatabaseApp.BLL;
using BankAccountWithDatabaseApp.Model;

namespace BankAccountWithDatabaseApp.UI
{
    public partial class CustomerAccountInfoUI : Form
    {
        public CustomerAccountInfoUI()
        {
            InitializeComponent();
        }
        Manager manager = new Manager();
        private void saveButton_Click(object sender, System.EventArgs e)
        {
            Account anAccount = new Account();

            anAccount.CustomerName = customerNameEntryTextBox.Text;
            anAccount.AccountNumber = accountNumberEntryTextBox.Text;
            anAccount.Email = customerEmailEntryTextBox.Text;
            anAccount.OpeningDate = customerEmailEntryTextBox.Text;
            anAccount.Balance = 0;

            MessageBox.Show(manager.Save(anAccount));
        }
    }
}
