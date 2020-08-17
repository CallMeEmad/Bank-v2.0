using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BankApp
{
    public partial class frmMainBank : Form
    {
        Dictionary<int, string> AccessModifiers = new Dictionary<int, string>();

        Dictionary<long, int> Customers = new Dictionary<long, int>();

        public frmMainBank()
        {
            InitializeComponent();

            AccessModifiers.Add(1, "حق برداشت به تنهایی");
            AccessModifiers.Add(2, "حق امضا");
            AccessModifiers.Add(3, "حق برداشت در صورت کفایت امضا");

        }
        void LoadCustomerType()
        {
            cmbAccessModifiers.DataSource = AccessModifiers.ToList();
            cmbAccessModifiers.DisplayMember = "Value";
            cmbAccessModifiers.ValueMember = "Key";
        }
        private void frmMainBank_Load(object sender, EventArgs e)
        {
            LoadCustomerType();
            GridSetup();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtCostomerNum.Text.Trim().Length < 3
                || txtCostomerNum.Text.Trim().Length > 10)
            {
                MessageBox.Show("طول شناسه مشتری باید بین 3 تا 10 رقم باشد", "طول غیر مجاز");
                return;
            }

            bool isExists = Customers.ContainsKey(Convert.ToInt32(txtCostomerNum.Text));
            if (isExists)
            {
                MessageBox.Show("این شناسه قبلا استفاده شده است", "شناسه تکراری");
                return;
            }

            Customers.Add(
                Convert.ToInt32(txtCostomerNum.Text),
                Convert.ToInt32(cmbAccessModifiers.SelectedValue)
                );

            dgCustomers.Rows.Add(dgCustomers.Rows.Count + 1, txtCostomerNum.Text, cmbAccessModifiers.Text);
            RefreshForm();

        }


        private void GridSetup()
        {
            dgCustomers.Columns.Add("RowNum", "ردیف");
            dgCustomers.Columns.Add("Customer", "شماره مشتری");
            dgCustomers.Columns.Add("CustomerType", "سطح دسترسی");
        }
        private void cmbAccessModifiers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txtCostomerNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar));
        }
        private void RefreshForm()
        {
            txtCostomerNum.Text = string.Empty;
            cmbAccessModifiers.SelectedIndex = 0;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var mainCustomers
                = Customers.Where(ex => ex.Value == 1).Select(ex => ex.Key).ToList(); // حق برداشت به تنهایی
            var withdrawBySignersSign
                = Customers.Where(ex => ex.Value == 3).Select(ex => ex.Key).ToList(); // حق برداشت در صورت کفایت امضا
            var signerCustomers
                = Customers.Where(ex => ex.Value == 2).Select(ex => ex.Key).ToList(); // حق امضا


            if (mainCustomers.Count <= 0 && withdrawBySignersSign.Count <= 0)
            {
                MessageBox.Show("هیچ حالتی برای برداشت از حساب وجود ندارد");
                return;
            }

            string strWithdrawMethods = string.Empty;
            int methodsNum = 1;

            if (mainCustomers.Count > 0)
            {
                strWithdrawMethods = $"حالت {methodsNum} : مشتریان {string.Join(",", mainCustomers)} امضا کرده باشند" + Environment.NewLine;
                methodsNum += 1;
            }
            if (signerCustomers.Count > 0 && withdrawBySignersSign.Count > 0)
            {
                strWithdrawMethods += $"حالت {methodsNum} : { (withdrawBySignersSign.Count == 1 ? 2 : withdrawBySignersSign.Count) - 1} نفر از مشتریان  {string.Join(",", withdrawBySignersSign)} به همراه {(signerCustomers.Count == 1 ? 2 : signerCustomers.Count) - 1} نفر از مشتریان {string.Join(",", signerCustomers)}امضا کرده باشند" + Environment.NewLine;
                methodsNum += 1;
            }
            if (withdrawBySignersSign.Count > 0)
            {
                strWithdrawMethods += $"حالت {methodsNum} : بیش از {(withdrawBySignersSign.Count == 1 ? 2 : withdrawBySignersSign.Count) - 1} نفر از مشتریان {string.Join(",", withdrawBySignersSign)} امضا کرده باشند";
                methodsNum += 1;
            }

            MessageBox.Show(strWithdrawMethods, "حالت های برداشت", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }
    }
}
