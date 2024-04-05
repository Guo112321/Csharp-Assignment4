using Assignment4.Models.Entities;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        private UserDetail userDetail;
        private User user;

        public Form1()
        {
            InitializeComponent();
            panelUser.Hide();
            panelLogin.Show();
            InitializeData();
        }

        public void JoinUserDetail()
        {
            try
            {
                using (var context = new MMABooksContext())
                {
                    var accounts = context.Accounts.Where(a => a.UserId == user.Id).ToList();
                    var transactions = context.TransactionHistories
                        .Where(t => context.Accounts.Any(a => a.AccountId == t.AccountId && a.UserId == user.Id))
                        .ToList();

                    userDetail = new UserDetail(user, accounts, transactions);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InitializeData()
        {
            try
            {
                using (var context = new MMABooksContext())
                {
                    if (!context.Users.Any())
                    {
                        var user = new User
                        {
                            Firstname = "Xinfu",
                            Lastname = "Guo",
                            Email = "123@abc.com",
                            Password = "123",
                            DateCreated = DateTime.Now
                        };
                        context.Users.Add(user);
                        context.SaveChanges();

                        var account1 = new Account
                        {
                            AccountType = "Debit Card",
                            UserId = user.Id,
                            CurrentBalance = 2000,
                            DateCreated = DateTime.Now
                        };
                        context.Accounts.Add(account1);

                        var account2 = new Account
                        {
                            AccountType = "Debit Card",
                            UserId = user.Id,
                            CurrentBalance = 5000,
                            DateCreated = DateTime.Now
                        };
                        context.Accounts.Add(account2);
                        context.SaveChanges();

                        var transaction1 = new TransactionHistory
                        {
                            AccountId = account1.AccountId,
                            TransactionDate = DateTime.Now,
                            Amount = 2000,
                            Description = "Deposit cash into card."
                        };
                        context.TransactionHistories.Add(transaction1);

                        var transaction2 = new TransactionHistory
                        {
                            AccountId = account2.AccountId,
                            TransactionDate = DateTime.Now,
                            Amount = 5000,
                            Description = "Deposit cash into card."
                        };
                        context.TransactionHistories.Add(transaction2);

                        context.SaveChanges();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void UpdateDGV()
        {
            dataGridView1.Rows.Clear();
            foreach (var t in userDetail.transactions)
            {
                dataGridView1.Rows.Add(
                t.TransactionId.ToString(),
                t.TransactionDate.ToString(),
                t.Amount,
                t.AccountId,
                t.Description
                );
            }
        }
        public void UpdateCurrentBalance()
        {
            lstAccount.Items.Clear();
            foreach (var a in userDetail.accounts)
            {
                lstAccount.Items.Add($"Account: {a.AccountId} -- {a.CurrentBalance}$");
            }
        }

        public void UpdateCombBox()
        {
            cmbAccount.Items.Clear();
            foreach (var a in userDetail.accounts)
            {
                cmbAccount.Items.Add(a.AccountId);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new MMABooksContext())
                {
                    string email = txtEmail.Text;
                    string pd = txtPd.Text;

                    if (context.Users.Any(u => u.Email == email && u.Password == pd))
                    {
                        user = context.Users.FirstOrDefault(u => u.Email == email && u.Password == pd);
                        panelLogin.Hide();
                        panelUser.Show();
                        JoinUserDetail();
                        labelName.Text = user.Firstname + " " + user.Lastname;
                        UpdateDGV();
                        UpdateCurrentBalance();
                        UpdateCombBox();
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new MMABooksContext())
                {
                    int amount = int.Parse(txtCreateAmout.Text);
                    int accountID = int.Parse(cmbAccount.Text);
                    string description = txtCreateDescription.Text;

                    var transaction = new TransactionHistory
                    {
                        AccountId = accountID,
                        TransactionDate = DateTime.Now,
                        Description = description,
                        Amount = amount
                    };

                    userDetail.transactions.Add(transaction);
                    context.TransactionHistories.Add(transaction);

                    userDetail.accounts.FirstOrDefault(a => a.AccountId == accountID).CurrentBalance -= amount;
                    context.Accounts.FirstOrDefault(a => a.AccountId == accountID).CurrentBalance -= amount;

                    context.SaveChanges();

                    UpdateCurrentBalance();
                    UpdateDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new MMABooksContext())
                {
                    int transactionId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    int accountID = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    double amount = Convert.ToDouble(dataGridView1.CurrentRow.Cells[2].Value.ToString());

                    userDetail.transactions.Remove(userDetail.transactions.FirstOrDefault(t => t.TransactionId == transactionId));
                    context.TransactionHistories.Remove(context.TransactionHistories.FirstOrDefault(t => t.TransactionId == transactionId));

                    userDetail.accounts.FirstOrDefault(a => a.AccountId == accountID).CurrentBalance += amount;
                    context.Accounts.FirstOrDefault(a => a.AccountId == accountID).CurrentBalance += amount;

                    context.SaveChanges();

                    UpdateCurrentBalance();
                    UpdateDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
