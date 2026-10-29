namespace oyutnii_burtgrl_system
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TreeNode treeNode1 = new TreeNode("Компьютерын ухаан");
            TreeNode treeNode2 = new TreeNode("Мэдээллийн технологи");
            TreeNode treeNode3 = new TreeNode("Програм хангамж");
            TreeNode treeNode4 = new TreeNode("Математик,");
            TreeNode treeNode5 = new TreeNode("Физик");
            TreeNode treeNode6 = new TreeNode("Байгалийн ухааны сургууль", new TreeNode[] { treeNode4, treeNode5 });
            chkScholarship = new CheckBox();
            txtCode = new TextBox();
            rbDay = new RadioButton();
            checkedListBox1 = new CheckedListBox();
            numAge = new NumericUpDown();
            cmbDepartment = new ComboBox();
            txtPhone = new TextBox();
            dtpBirthDate = new DateTimePicker();
            btnRegister = new Button();
            lblTotalCount = new Label();
            lstLanguages = new ListBox();
            picProfile = new PictureBox();
            dgvStudents = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colAge = new DataGridViewTextBoxColumn();
            treeDepartment = new TreeView();
            panel1 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // chkScholarship
            // 
            chkScholarship.AutoSize = true;
            chkScholarship.Checked = true;
            chkScholarship.CheckState = CheckState.Checked;
            chkScholarship.Location = new Point(12, 103);
            chkScholarship.Name = "chkScholarship";
            chkScholarship.Size = new Size(168, 36);
            chkScholarship.TabIndex = 1;
            chkScholarship.Text = "Тэтгэлэгтэй";
            chkScholarship.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(12, 34);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(200, 39);
            txtCode.TabIndex = 2;
            txtCode.Text = "M.SW24D019";
            // 
            // rbDay
            // 
            rbDay.AutoSize = true;
            rbDay.Checked = true;
            rbDay.Location = new Point(12, 169);
            rbDay.Name = "rbDay";
            rbDay.Size = new Size(241, 36);
            rbDay.TabIndex = 4;
            rbDay.TabStop = true;
            rbDay.Text = "Өдрийн сургалт   ";
            rbDay.TextAlign = ContentAlignment.MiddleRight;
            rbDay.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Програмчлал", "Өгөгдлийн бүтэц", "Алгоритм", "Өгөгдлийн сан", "Сүлжээ" });
            checkedListBox1.Location = new Point(12, 226);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(240, 184);
            checkedListBox1.TabIndex = 6;
            // 
            // numAge
            // 
            numAge.Location = new Point(13, 459);
            numAge.Minimum = new decimal(new int[] { 16, 0, 0, 0 });
            numAge.Name = "numAge";
            numAge.Size = new Size(240, 39);
            numAge.TabIndex = 7;
            numAge.Value = new decimal(new int[] { 21, 0, 0, 0 });
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "Мэдээллийн технологи" });
            cmbDepartment.Location = new Point(13, 556);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(239, 40);
            cmbDepartment.TabIndex = 8;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(13, 658);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(239, 39);
            txtPhone.TabIndex = 9;
            txtPhone.Text = "9911-9911";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(13, 735);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(276, 39);
            dtpBirthDate.TabIndex = 10;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.Control;
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.Highlight;
            btnRegister.Location = new Point(30, 814);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(206, 75);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Бүртгэх   ";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.Location = new Point(300, 41);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(94, 32);
            lblTotalCount.TabIndex = 12;
            lblTotalCount.Text = "Нийт: 1";
            // 
            // lstLanguages
            // 
            lstLanguages.FormattingEnabled = true;
            lstLanguages.Items.AddRange(new object[] { "Монгол", "Англи", "Орос", "Хятад", "Япон", "Солонгос" });
            lstLanguages.Location = new Point(309, 115);
            lstLanguages.Name = "lstLanguages";
            lstLanguages.Size = new Size(240, 164);
            lstLanguages.TabIndex = 13;
            // 
            // picProfile
            // 
            picProfile.ErrorImage = (Image)resources.GetObject("picProfile.ErrorImage");
            picProfile.Image = (Image)resources.GetObject("picProfile.Image");
            picProfile.InitialImage = (Image)resources.GetObject("picProfile.InitialImage");
            picProfile.Location = new Point(309, 328);
            picProfile.Name = "picProfile";
            picProfile.Size = new Size(240, 219);
            picProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            picProfile.TabIndex = 14;
            picProfile.TabStop = false;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { colName, colPhone, colAge });
            dgvStudents.Location = new Point(658, 115);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 82;
            dgvStudents.Size = new Size(543, 164);
            dgvStudents.TabIndex = 15;
            // 
            // colName
            // 
            colName.HeaderText = "Owog ner";
            colName.MinimumWidth = 10;
            colName.Name = "colName";
            colName.Width = 200;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Утас";
            colPhone.MinimumWidth = 10;
            colPhone.Name = "colPhone";
            colPhone.Width = 200;
            // 
            // colAge
            // 
            colAge.HeaderText = "Нас";
            colAge.MinimumWidth = 10;
            colAge.Name = "colAge";
            colAge.Width = 200;
            // 
            // treeDepartment
            // 
            treeDepartment.Location = new Point(658, 328);
            treeDepartment.Name = "treeDepartment";
            treeNode1.Name = "Компьютерын ухаан";
            treeNode1.Text = "Компьютерын ухаан";
            treeNode2.Name = "Node1";
            treeNode2.Text = "Мэдээллийн технологи";
            treeNode3.Name = "Node2";
            treeNode3.Text = "Програм хангамж";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Математик,";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Физик";
            treeNode6.Name = "Node3";
            treeNode6.Text = "Байгалийн ухааны сургууль";
            treeDepartment.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode6 });
            treeDepartment.Size = new Size(543, 194);
            treeDepartment.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(309, 585);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 336);
            panel1.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 293);
            label10.Name = "label10";
            label10.Size = new Size(57, 32);
            label10.TabIndex = 9;
            label10.Text = "Хэл:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 261);
            label9.Name = "label9";
            label9.Size = new Size(96, 32);
            label9.TabIndex = 8;
            label9.Text = "Хичээл:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 229);
            label8.Name = "label8";
            label8.Size = new Size(106, 32);
            label8.TabIndex = 7;
            label8.Text = "Тэтгэлэг:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 192);
            label7.Name = "label7";
            label7.Size = new Size(99, 32);
            label7.TabIndex = 6;
            label7.Text = "Тэнхим:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 160);
            label6.Name = "label6";
            label6.Size = new Size(104, 32);
            label6.TabIndex = 5;
            label6.Text = "Сургалт:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 128);
            label5.Name = "label5";
            label5.Size = new Size(161, 32);
            label5.TabIndex = 4;
            label5.Text = "Төрсөн өдөр:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 96);
            label4.Name = "label4";
            label4.Size = new Size(59, 32);
            label4.TabIndex = 3;
            label4.Text = "Нас:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 64);
            label3.Name = "label3";
            label3.Size = new Size(66, 32);
            label3.TabIndex = 2;
            label3.Text = "Утас:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 32);
            label2.Name = "label2";
            label2.Size = new Size(60, 32);
            label2.TabIndex = 1;
            label2.Text = "Код:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(221, 32);
            label1.TabIndex = 0;
            label1.Text = "ОЮУТНЫ БҮРТГЭЛ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 929);
            Controls.Add(panel1);
            Controls.Add(treeDepartment);
            Controls.Add(dgvStudents);
            Controls.Add(picProfile);
            Controls.Add(lstLanguages);
            Controls.Add(lblTotalCount);
            Controls.Add(btnRegister);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtPhone);
            Controls.Add(cmbDepartment);
            Controls.Add(numAge);
            Controls.Add(checkedListBox1);
            Controls.Add(rbDay);
            Controls.Add(txtCode);
            Controls.Add(chkScholarship);
            Name = "Form1";
            Text = "\\=] ";
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox chkScholarship;
        private TextBox txtCode;
        private RadioButton rbDay;
        private CheckedListBox checkedListBox1;
        private NumericUpDown numAge;
        private ComboBox cmbDepartment;
        private TextBox txtPhone;
        private DateTimePicker dtpBirthDate;
        private Button btnRegister;
        private Label lblTotalCount;
        private ListBox lstLanguages;
        private PictureBox picProfile;
        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colAge;
        private TreeView treeDepartment;
        private Panel panel1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
