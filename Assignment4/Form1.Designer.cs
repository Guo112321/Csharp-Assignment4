namespace Assignment4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLogin = new Panel();
            btnLogin = new Button();
            txtPd = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panelUser = new Panel();
            lstAccount = new ListBox();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            groupBox1 = new GroupBox();
            cmbAccount = new ComboBox();
            label3 = new Label();
            btncreate = new Button();
            txtCreateDescription = new TextBox();
            txtCreateAmout = new TextBox();
            label6 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            TransactionId = new DataGridViewTextBoxColumn();
            TransactionDate = new DataGridViewTextBoxColumn();
            Amout = new DataGridViewTextBoxColumn();
            AccountId = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            labelName = new Label();
            panelLogin.SuspendLayout();
            panelUser.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(txtPd);
            panelLogin.Controls.Add(txtEmail);
            panelLogin.Controls.Add(label2);
            panelLogin.Controls.Add(label1);
            panelLogin.Location = new Point(462, 2);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(246, 451);
            panelLogin.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnLogin.Location = new Point(77, 237);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 36);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPd
            // 
            txtPd.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtPd.Location = new Point(95, 160);
            txtPd.Name = "txtPd";
            txtPd.Size = new Size(131, 28);
            txtPd.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtEmail.Location = new Point(95, 114);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(131, 28);
            txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label2.Location = new Point(3, 160);
            label2.Name = "label2";
            label2.Size = new Size(99, 22);
            label2.TabIndex = 1;
            label2.Text = "Password: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(38, 117);
            label1.Name = "label1";
            label1.Size = new Size(64, 22);
            label1.TabIndex = 0;
            label1.Text = "Email: ";
            // 
            // panelUser
            // 
            panelUser.Controls.Add(lstAccount);
            panelUser.Controls.Add(groupBox2);
            panelUser.Controls.Add(groupBox1);
            panelUser.Controls.Add(dataGridView1);
            panelUser.Controls.Add(labelName);
            panelUser.Location = new Point(21, 12);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(1053, 422);
            panelUser.TabIndex = 1;
            // 
            // lstAccount
            // 
            lstAccount.FormattingEnabled = true;
            lstAccount.ItemHeight = 17;
            lstAccount.Location = new Point(838, 15);
            lstAccount.Name = "lstAccount";
            lstAccount.Size = new Size(189, 55);
            lstAccount.TabIndex = 8;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLightLight;
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            groupBox2.Location = new Point(838, 307);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(195, 91);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Deleting Transaction";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btnDelete.Location = new Point(53, 53);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Perform";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(cmbAccount);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btncreate);
            groupBox1.Controls.Add(txtCreateDescription);
            groupBox1.Controls.Add(txtCreateAmout);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 134);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(831, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(202, 220);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Creating Transaction";
            // 
            // cmbAccount
            // 
            cmbAccount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccount.FormattingEnabled = true;
            cmbAccount.Location = new Point(95, 72);
            cmbAccount.Name = "cmbAccount";
            cmbAccount.Size = new Size(101, 30);
            cmbAccount.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(21, 76);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 9;
            label3.Text = "Account:";
            // 
            // btncreate
            // 
            btncreate.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            btncreate.Location = new Point(61, 177);
            btncreate.Name = "btncreate";
            btncreate.Size = new Size(75, 23);
            btncreate.TabIndex = 8;
            btncreate.Text = "Perform";
            btncreate.UseVisualStyleBackColor = true;
            btncreate.Click += btncreate_Click;
            // 
            // txtCreateDescription
            // 
            txtCreateDescription.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            txtCreateDescription.Location = new Point(21, 136);
            txtCreateDescription.Multiline = true;
            txtCreateDescription.Name = "txtCreateDescription";
            txtCreateDescription.Size = new Size(140, 35);
            txtCreateDescription.TabIndex = 7;
            // 
            // txtCreateAmout
            // 
            txtCreateAmout.Location = new Point(89, 38);
            txtCreateAmout.Name = "txtCreateAmout";
            txtCreateAmout.Size = new Size(72, 28);
            txtCreateAmout.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label6.Location = new Point(21, 113);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 5;
            label6.Text = "Description: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 10.5F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label5.Location = new Point(21, 42);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Amout: ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TransactionId, TransactionDate, Amout, AccountId, Description });
            dataGridView1.Location = new Point(21, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(720, 300);
            dataGridView1.TabIndex = 1;
            // 
            // TransactionId
            // 
            TransactionId.HeaderText = "TransactionId";
            TransactionId.Name = "TransactionId";
            TransactionId.ReadOnly = true;
            // 
            // TransactionDate
            // 
            TransactionDate.HeaderText = "TransactionDate";
            TransactionDate.Name = "TransactionDate";
            TransactionDate.ReadOnly = true;
            TransactionDate.Width = 150;
            // 
            // Amout
            // 
            Amout.HeaderText = "Amout";
            Amout.Name = "Amout";
            Amout.ReadOnly = true;
            Amout.Width = 80;
            // 
            // AccountId
            // 
            AccountId.HeaderText = "AccountId";
            AccountId.Name = "AccountId";
            AccountId.ReadOnly = true;
            // 
            // Description
            // 
            Description.HeaderText = "Description";
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Width = 250;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            labelName.Location = new Point(21, 15);
            labelName.Name = "labelName";
            labelName.Size = new Size(73, 27);
            labelName.TabIndex = 0;
            labelName.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 484);
            Controls.Add(panelUser);
            Controls.Add(panelLogin);
            Name = "Form1";
            Text = "Form1";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLogin;
        private Label label1;
        private TextBox txtPd;
        private TextBox txtEmail;
        private Label label2;
        private Button btnLogin;
        private Panel panelUser;
        private DataGridView dataGridView1;
        private Label labelName;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Button btncreate;
        private TextBox txtCreateDescription;
        private TextBox txtCreateAmout;
        private GroupBox groupBox2;
        private Button btnDelete;
        private Label label3;
        private ListBox lstAccount;
        private ComboBox cmbAccount;
        private DataGridViewTextBoxColumn TransactionId;
        private DataGridViewTextBoxColumn TransactionDate;
        private DataGridViewTextBoxColumn Amout;
        private DataGridViewTextBoxColumn AccountId;
        private DataGridViewTextBoxColumn Description;
    }
}
