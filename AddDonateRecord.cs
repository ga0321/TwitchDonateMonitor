using System;
using System.Windows.Forms;

namespace DonateMonitor
{
    public partial class AddDonateRecord : Form
    {
        public string RecordDateTime { get; private set; }
        public string RecordType { get; private set; }
        public string RecordAccount { get; private set; }
        public string RecordDisplayName { get; private set; }
        public decimal RecordAmount { get; private set; }
        public string RecordCurrency { get; private set; }
        public string RecordMessage { get; private set; }
        public string RecordSubPlan { get; private set; }

        public AddDonateRecord()
        {
            InitializeComponent();
            InitTypeComboBox();
            TbDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            CbType.SelectedIndex = 0;
            TbCurrency.Text = "TWD";
        }

        private void InitTypeComboBox()
        {
            CbType.Items.Clear();
            CbType.Items.AddRange(new string[]
            {
                Global.Type_ECPay,
                Global.Type_OPay,
                Global.Type_HiveBee,
                Global.Type_Paypal,
                Global.Type_Sub,
                Global.Type_Resub,
                Global.Custom_Sub_Gift,
                Global.Custom_Bits
            });
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            if (CbType.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇類型", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RecordDateTime = TbDateTime.Text;
            RecordType = CbType.SelectedItem.ToString();
            RecordAccount = TbAccount.Text;
            RecordDisplayName = TbDisplayName.Text;
            decimal.TryParse(TbAmount.Text, out decimal amount);
            RecordAmount = amount;
            RecordCurrency = TbCurrency.Text;
            RecordMessage = TbMessage.Text;
            RecordSubPlan = TbSubPlan.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
