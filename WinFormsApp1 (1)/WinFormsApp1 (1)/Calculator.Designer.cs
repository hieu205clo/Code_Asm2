namespace WinFormsApp1
{
    partial class Calculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnPay = new Button();
            btnRemove = new Button();
            btnReturn = new Button();
            btnCalculator = new Button();
            btnDelete = new Button();
            txtThisWaterMonth = new TextBox();
            txtLastWaterMonth = new TextBox();
            txtName = new TextBox();
            txtCustomerType = new ComboBox();
            lsvBill = new ListView();
            txtMember = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 49);
            label1.Name = "label1";
            label1.Size = new Size(222, 32);
            label1.TabIndex = 0;
            label1.Text = "Customer's Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 111);
            label2.Name = "label2";
            label2.Size = new Size(192, 32);
            label2.TabIndex = 1;
            label2.Text = "Customer Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 176);
            label3.Name = "label3";
            label3.Size = new Size(337, 32);
            label3.TabIndex = 2;
            label3.Text = "Number of family members:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 240);
            label4.Name = "label4";
            label4.Size = new Size(321, 32);
            label4.TabIndex = 3;
            label4.Text = "Water quantity last month:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 296);
            label5.Name = "label5";
            label5.Size = new Size(315, 32);
            label5.TabIndex = 4;
            label5.Text = "Water quantity this month";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPay);
            groupBox1.Controls.Add(btnRemove);
            groupBox1.Controls.Add(btnReturn);
            groupBox1.Controls.Add(btnCalculator);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(txtThisWaterMonth);
            groupBox1.Controls.Add(txtLastWaterMonth);
            groupBox1.Controls.Add(txtMember);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtCustomerType);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(-1, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1144, 344);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer information";
            // 
            // btnPay
            // 
            btnPay.Enabled = false;
            btnPay.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPay.Location = new Point(999, 284);
            btnPay.Margin = new Padding(3, 4, 3, 4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(138, 51);
            btnPay.TabIndex = 8;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(597, 279);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(138, 51);
            btnRemove.TabIndex = 15;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.Location = new Point(999, 40);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(138, 51);
            btnReturn.TabIndex = 6;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnCalculator
            // 
            btnCalculator.Location = new Point(597, 161);
            btnCalculator.Margin = new Padding(3, 4, 3, 4);
            btnCalculator.Name = "btnCalculator";
            btnCalculator.Size = new Size(138, 51);
            btnCalculator.TabIndex = 14;
            btnCalculator.Text = "Calculator";
            btnCalculator.UseVisualStyleBackColor = true;
            btnCalculator.Click += btnCalculator_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(597, 40);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 51);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtThisWaterMonth
            // 
            txtThisWaterMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtThisWaterMonth.Location = new Point(338, 296);
            txtThisWaterMonth.Margin = new Padding(3, 4, 3, 4);
            txtThisWaterMonth.Name = "txtThisWaterMonth";
            txtThisWaterMonth.Size = new Size(203, 34);
            txtThisWaterMonth.TabIndex = 12;
            // 
            // txtLastWaterMonth
            // 
            txtLastWaterMonth.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLastWaterMonth.Location = new Point(338, 235);
            txtLastWaterMonth.Margin = new Padding(3, 4, 3, 4);
            txtLastWaterMonth.Name = "txtLastWaterMonth";
            txtLastWaterMonth.Size = new Size(203, 34);
            txtLastWaterMonth.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(238, 43);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(303, 34);
            txtName.TabIndex = 9;
            // 
            // txtCustomerType
            // 
            txtCustomerType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCustomerType.FormattingEnabled = true;
            txtCustomerType.Items.AddRange(new object[] { "Household customer ", "Administrative agency", "Production units ", "Business services" });
            txtCustomerType.Location = new Point(238, 105);
            txtCustomerType.Margin = new Padding(3, 4, 3, 4);
            txtCustomerType.Name = "txtCustomerType";
            txtCustomerType.Size = new Size(303, 36);
            txtCustomerType.TabIndex = 8;
            txtCustomerType.SelectedIndexChanged += txtCustomerType_SelectedIndexChanged;
            // 
            // lsvBill
            // 
            lsvBill.Location = new Point(14, 352);
            lsvBill.Margin = new Padding(3, 4, 3, 4);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(1129, 352);
            lsvBill.TabIndex = 6;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.ItemSelectionChanged += lsvBill_ItemSelectionChanged;
            // 
            // txtMember
            // 
            txtMember.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMember.Location = new Point(376, 170);
            txtMember.Margin = new Padding(3, 4, 3, 4);
            txtMember.Name = "txtMember";
            txtMember.Size = new Size(203, 34);
            txtMember.TabIndex = 10;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 721);
            Controls.Add(lsvBill);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Calculator";
            Text = "Calculator";
            Load += Calculator_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnReturn;
        private Button btnRemove;
        private Button btnCalculator;
        private Button btnDelete;
        private TextBox txtThisWaterMonth;
        private TextBox txtLastWaterMonth;
        private TextBox txtName;
        private ComboBox txtCustomerType;
        private ListView lsvBill;
        private Button btnPay;
        private TextBox txtMember;
    }
}