using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRealState
{

    public partial class FrmAddOrEdit : Form
    {
        IRealStateRepository Repository;
        public int contactid = 0;

        public FrmAddOrEdit()
        {
            InitializeComponent();
            Repository = new RealStateRepository();
        }
        private bool ValidateInput()
        {

            if (txtNameOrFamily.Text == "")
            {
                MessageBox.Show("لطفا نام و نام خانوادگی را پر کنید", ("توجه"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("لطفا تلفن را پر کنید", ("توجه"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSaleOrRent.Text == "")
            {
                MessageBox.Show("لطفا اجاره/فروش را پر کنید", ("توجه"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtMeterage.Text == "")
            {
                MessageBox.Show("لطفا متراژ را پر کنید", ("توجه"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPrice.Text == "")
            {
                MessageBox.Show("لطفا قیمت را پر کنید", ("توجه"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtaddress.Text == "")
            {
                MessageBox.Show("لطفا آدرس را پر کنید", ("توجه"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;


        }

        private void FrmAddOrEdit_Load(object sender, EventArgs e)
        {
            if (contactid == 0)
            {
                this.Text = "افزودن ملک";
            }
            else
            {
                this.Text = "ویرایش ملک";
                DataTable data = Repository.SelectRow(contactid);
                txtNameOrFamily.Text = data.Rows[0][1].ToString();
                txtPhoneNumber.Text = data.Rows[0][2].ToString();
                txtSaleOrRent.Text = data.Rows[0][3].ToString();
                txtMeterage.Text = data.Rows[0][4].ToString();
                txtPrice.Text = data.Rows[0][5].ToString();
                txtaddress.Text = data.Rows[0][6].ToString();
                txtdecription.Text = data.Rows[0][7].ToString();
                btnsubmit.Text = "ویرایش";

            }

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                try
                {
                    int txtmeterage = Convert.ToInt32(txtMeterage.Text);
                    int txtprice = Convert.ToInt32(txtPrice.Text);
                    bool insucces;
                    if (contactid == 0)
                    {
                        Repository.Insert(txtNameOrFamily.Text, txtPhoneNumber.Text, txtSaleOrRent.Text, txtmeterage, txtprice, txtaddress.Text, txtdecription.Text);
                        insucces = true;
                    }
                    else
                    {
                        Repository.Edit(contactid, txtNameOrFamily.Text, txtPhoneNumber.Text, txtSaleOrRent.Text, txtmeterage, txtprice, txtaddress.Text, txtdecription.Text);
                        insucces = true;
                    }

                    if (insucces == true)
                    {
                        MessageBox.Show("عملیات با موفقیت انجام شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("عملیات با موفقیت انجام نشد", "نا موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("لطفا در فیلد متراژ و قیمت فقط عدد وارد کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                }



            }
        }
        private void btnwholeprice_Click_1(object sender, EventArgs e)
        {
            if (txtSaleOrRent.Text == "فروش")
            {

                double txtmeterage = Convert.ToDouble(txtMeterage.Text);
                double txtprice = Convert.ToDouble(txtPrice.Text);
                double multiple = txtprice * txtmeterage;
                MessageBox.Show($"قیمت فروش کل {multiple} هست", "محسابه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("(ابن عملیات فقط برای ملک فروش است ( فیلد فروش/اجاره را چک کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            decimal price;
            price = decimal.Parse(txtPrice.Text, System.Globalization.NumberStyles.Currency);
            txtPrice.Text = price.ToString("#,#");
            txtPrice.SelectionStart = txtPrice.Text.Length;
        }

    }
}
