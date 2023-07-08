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
    public partial class Form1 : Form
    {
        IRealStateRepository Repository;

        public Form1()
        {
            InitializeComponent();
            Repository = new RealStateRepository();
        }
        private void BindGrid()
        {
            dgrealstate.AutoGenerateColumns = false;
            dgrealstate.DataSource = Repository.SelectAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnAddbullding_Click(object sender, EventArgs e)
        {
            FrmAddOrEdit frm = new FrmAddOrEdit();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = dgrealstate.CurrentRow.Cells[1].Value.ToString();
            string meterage = dgrealstate.CurrentRow.Cells[6].Value.ToString();
            string res = name + "  " + meterage;
            if (MessageBox.Show($"آیا از حذف ملک {res} مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int contactid = Convert.ToInt32(dgrealstate.CurrentRow.Cells[0].Value.ToString());
                Repository.Delete(contactid);
                BindGrid();
            }
            else
            {

            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            FrmAddOrEdit frm = new FrmAddOrEdit();
            int contactID = Convert.ToInt32(dgrealstate.CurrentRow.Cells[0].Value.ToString());
            frm.contactid = contactID;
            Repository.SelectRow(contactID);


            if (frm.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void txtboxsearchname_TextChanged(object sender, EventArgs e)
        {
            dgrealstate.DataSource = Repository.searche(txtboxsearchname.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dgrealstate.DataSource = Repository.searche(txtsearchsaleORrent.Text);
        }

    }
}
