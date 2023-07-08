
namespace MyRealState
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearchsaleORrent = new System.Windows.Forms.TextBox();
            this.txtboxsearchname = new System.Windows.Forms.TextBox();
            this.gpbox2 = new System.Windows.Forms.GroupBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgrealstate = new System.Windows.Forms.DataGridView();
            this.ContactID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOrFamily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellsOrRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meterage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddbullding = new System.Windows.Forms.ToolStripButton();
            this.btnrefresh = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.gpbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrealstate)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtsearchsaleORrent);
            this.groupBox1.Controls.Add(this.txtboxsearchname);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "پیدا کن!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "فروش/اجاره:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(683, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام و نام خانوادگی:";
            // 
            // txtsearchsaleORrent
            // 
            this.txtsearchsaleORrent.Location = new System.Drawing.Point(173, 28);
            this.txtsearchsaleORrent.Name = "txtsearchsaleORrent";
            this.txtsearchsaleORrent.Size = new System.Drawing.Size(190, 21);
            this.txtsearchsaleORrent.TabIndex = 1;
            this.txtsearchsaleORrent.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtboxsearchname
            // 
            this.txtboxsearchname.Location = new System.Drawing.Point(518, 28);
            this.txtboxsearchname.Name = "txtboxsearchname";
            this.txtboxsearchname.Size = new System.Drawing.Size(159, 21);
            this.txtboxsearchname.TabIndex = 0;
            this.txtboxsearchname.TextChanged += new System.EventHandler(this.txtboxsearchname_TextChanged);
            // 
            // gpbox2
            // 
            this.gpbox2.Controls.Add(this.BtnEdit);
            this.gpbox2.Controls.Add(this.btnDelete);
            this.gpbox2.Controls.Add(this.dgrealstate);
            this.gpbox2.Location = new System.Drawing.Point(0, 117);
            this.gpbox2.Name = "gpbox2";
            this.gpbox2.Size = new System.Drawing.Size(784, 290);
            this.gpbox2.TabIndex = 1;
            this.gpbox2.TabStop = false;
            this.gpbox2.Text = "مشخصات ملک";
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(616, 267);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "ویرایش ملک";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(697, 267);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف ملک";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgrealstate
            // 
            this.dgrealstate.AllowUserToAddRows = false;
            this.dgrealstate.AllowUserToDeleteRows = false;
            this.dgrealstate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrealstate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrealstate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContactID,
            this.NameOrFamily,
            this.PhoneNumber,
            this.SellsOrRent,
            this.Meterage,
            this.Price,
            this.Address,
            this.Description});
            this.dgrealstate.Location = new System.Drawing.Point(0, 20);
            this.dgrealstate.Name = "dgrealstate";
            this.dgrealstate.ReadOnly = true;
            this.dgrealstate.Size = new System.Drawing.Size(782, 241);
            this.dgrealstate.TabIndex = 0;
            // 
            // ContactID
            // 
            this.ContactID.DataPropertyName = "ContactID";
            this.ContactID.HeaderText = "کد";
            this.ContactID.Name = "ContactID";
            this.ContactID.ReadOnly = true;
            this.ContactID.Visible = false;
            // 
            // NameOrFamily
            // 
            this.NameOrFamily.DataPropertyName = "NameOrFamily";
            this.NameOrFamily.HeaderText = "نام و نام خانوادگی";
            this.NameOrFamily.Name = "NameOrFamily";
            this.NameOrFamily.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "تلفن";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // SellsOrRent
            // 
            this.SellsOrRent.DataPropertyName = "SaleOrRent";
            this.SellsOrRent.HeaderText = "فروش/اجاره";
            this.SellsOrRent.Name = "SellsOrRent";
            this.SellsOrRent.ReadOnly = true;
            // 
            // Meterage
            // 
            this.Meterage.DataPropertyName = "Meterage";
            this.Meterage.HeaderText = "متراژ";
            this.Meterage.Name = "Meterage";
            this.Meterage.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "قیمت";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "آدرس";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddbullding,
            this.btnrefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddbullding
            // 
            this.btnAddbullding.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddbullding.Image = ((System.Drawing.Image)(resources.GetObject("btnAddbullding.Image")));
            this.btnAddbullding.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddbullding.Name = "btnAddbullding";
            this.btnAddbullding.Size = new System.Drawing.Size(23, 22);
            this.btnAddbullding.Text = "افرودن ملک";
            this.btnAddbullding.Click += new System.EventHandler(this.btnAddbullding_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnrefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnrefresh.Image")));
            this.btnrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(23, 22);
            this.btnrefresh.Text = "رفرش";
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.gpbox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "املاک";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrealstate)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbox2;
        private System.Windows.Forms.DataGridView dgrealstate;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOrFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellsOrRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Meterage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.ToolStripButton btnAddbullding;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripButton btnrefresh;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearchsaleORrent;
        private System.Windows.Forms.TextBox txtboxsearchname;
    }
}

