namespace _243557_Windows_From_App___Data_Base__
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
            dgStudents = new DataGridView();
            btnRefreshView = new Button();
            txtSName = new TextBox();
            txtFatherName = new TextBox();
            txtCNIC = new TextBox();
            cmbGender = new ComboBox();
            dtpDOB = new DateTimePicker();
            txtAddress = new TextBox();
            cmbDegreeProgram = new ComboBox();
            txtMatricGrade = new TextBox();
            txtInterGrade = new TextBox();
            btnAddStudent = new Button();
            txtUpdateRegId = new TextBox();
            txtUpdateName = new TextBox();
            txtUpdateAddress = new TextBox();
            txtUpdateMatricGrade = new TextBox();
            txtUpdateInterGrade = new TextBox();
            btnUpdateRecord = new Button();
            txtDeleteRegId = new TextBox();
            btnDeleteStudent = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgStudents).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgStudents
            // 
            dgStudents.BackgroundColor = Color.SeaShell;
            dgStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudents.Location = new Point(10, 10);
            dgStudents.Name = "dgStudents";
            dgStudents.Size = new Size(669, 200);
            dgStudents.TabIndex = 0;
            // 
            // btnRefreshView
            // 
            btnRefreshView.BackColor = Color.Gold;
            btnRefreshView.Location = new Point(10, 220);
            btnRefreshView.Name = "btnRefreshView";
            btnRefreshView.Size = new Size(150, 30);
            btnRefreshView.TabIndex = 1;
            btnRefreshView.Text = "Refresh Student List";
            btnRefreshView.UseVisualStyleBackColor = false;
            btnRefreshView.Click += btnRefreshView_Click;
            // 
            // txtSName
            // 
            txtSName.Location = new Point(12, 31);
            txtSName.Name = "txtSName";
            txtSName.PlaceholderText = "Name";
            txtSName.Size = new Size(100, 23);
            txtSName.TabIndex = 3;
            // 
            // txtFatherName
            // 
            txtFatherName.Location = new Point(12, 90);
            txtFatherName.Name = "txtFatherName";
            txtFatherName.PlaceholderText = "Father Name";
            txtFatherName.Size = new Size(100, 23);
            txtFatherName.TabIndex = 4;
            txtFatherName.TextChanged += txtFatherName_TextChanged;
            // 
            // txtCNIC
            // 
            txtCNIC.Location = new Point(12, 119);
            txtCNIC.Name = "txtCNIC";
            txtCNIC.PlaceholderText = "CNIC";
            txtCNIC.Size = new Size(100, 23);
            txtCNIC.TabIndex = 5;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            cmbGender.Location = new Point(246, 51);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 23);
            cmbGender.TabIndex = 6;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(167, 80);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(200, 23);
            dtpDOB.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 61);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 8;
            // 
            // cmbDegreeProgram
            // 
            cmbDegreeProgram.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDegreeProgram.Items.AddRange(new object[] { "BSCS", "BSEE", "BSAF" });
            cmbDegreeProgram.Location = new Point(246, 22);
            cmbDegreeProgram.Name = "cmbDegreeProgram";
            cmbDegreeProgram.Size = new Size(121, 23);
            cmbDegreeProgram.TabIndex = 9;
            // 
            // txtMatricGrade
            // 
            txtMatricGrade.Location = new Point(12, 148);
            txtMatricGrade.Name = "txtMatricGrade";
            txtMatricGrade.PlaceholderText = "Matric Grade (e.g., 85.5)";
            txtMatricGrade.Size = new Size(136, 23);
            txtMatricGrade.TabIndex = 10;
            // 
            // txtInterGrade
            // 
            txtInterGrade.Location = new Point(12, 177);
            txtInterGrade.Name = "txtInterGrade";
            txtInterGrade.PlaceholderText = "Inter Grade (e.g., 78.0)";
            txtInterGrade.Size = new Size(136, 23);
            txtInterGrade.TabIndex = 11;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.Green;
            btnAddStudent.ForeColor = SystemColors.ControlLightLight;
            btnAddStudent.Location = new Point(190, 128);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(150, 30);
            btnAddStudent.TabIndex = 12;
            btnAddStudent.Text = "Add Student (Task 2)";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // txtUpdateRegId
            // 
            txtUpdateRegId.Location = new Point(18, 22);
            txtUpdateRegId.Name = "txtUpdateRegId";
            txtUpdateRegId.PlaceholderText = "RegId to Update";
            txtUpdateRegId.Size = new Size(100, 23);
            txtUpdateRegId.TabIndex = 13;
            // 
            // txtUpdateName
            // 
            txtUpdateName.Location = new Point(128, 22);
            txtUpdateName.Name = "txtUpdateName";
            txtUpdateName.PlaceholderText = "New Name";
            txtUpdateName.Size = new Size(110, 23);
            txtUpdateName.TabIndex = 14;
            // 
            // txtUpdateAddress
            // 
            txtUpdateAddress.Location = new Point(18, 90);
            txtUpdateAddress.Name = "txtUpdateAddress";
            txtUpdateAddress.PlaceholderText = "New Address";
            txtUpdateAddress.Size = new Size(100, 23);
            txtUpdateAddress.TabIndex = 15;
            // 
            // txtUpdateMatricGrade
            // 
            txtUpdateMatricGrade.Location = new Point(128, 51);
            txtUpdateMatricGrade.Name = "txtUpdateMatricGrade";
            txtUpdateMatricGrade.PlaceholderText = "New Matric Grade";
            txtUpdateMatricGrade.Size = new Size(110, 23);
            txtUpdateMatricGrade.TabIndex = 16;
            // 
            // txtUpdateInterGrade
            // 
            txtUpdateInterGrade.Location = new Point(18, 51);
            txtUpdateInterGrade.Name = "txtUpdateInterGrade";
            txtUpdateInterGrade.PlaceholderText = "New Inter Grade";
            txtUpdateInterGrade.Size = new Size(100, 23);
            txtUpdateInterGrade.TabIndex = 17;
            // 
            // btnUpdateRecord
            // 
            btnUpdateRecord.BackColor = Color.Navy;
            btnUpdateRecord.ForeColor = SystemColors.ControlLightLight;
            btnUpdateRecord.Location = new Point(124, 90);
            btnUpdateRecord.Name = "btnUpdateRecord";
            btnUpdateRecord.Size = new Size(150, 30);
            btnUpdateRecord.TabIndex = 18;
            btnUpdateRecord.Text = "Update Record (Task 4)";
            btnUpdateRecord.UseVisualStyleBackColor = false;
            btnUpdateRecord.Click += btnUpdateRecord_Click;
            // 
            // txtDeleteRegId
            // 
            txtDeleteRegId.Location = new Point(95, 22);
            txtDeleteRegId.Name = "txtDeleteRegId";
            txtDeleteRegId.PlaceholderText = "RegId to Delete";
            txtDeleteRegId.Size = new Size(100, 23);
            txtDeleteRegId.TabIndex = 19;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.BackColor = Color.Teal;
            btnDeleteStudent.ForeColor = SystemColors.ControlLightLight;
            btnDeleteStudent.Location = new Point(70, 51);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(150, 30);
            btnDeleteStudent.TabIndex = 20;
            btnDeleteStudent.Text = "Delete Student (Task 5)";
            btnDeleteStudent.UseVisualStyleBackColor = false;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.PaleGreen;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCNIC);
            groupBox1.Controls.Add(btnAddStudent);
            groupBox1.Controls.Add(txtInterGrade);
            groupBox1.Controls.Add(txtMatricGrade);
            groupBox1.Controls.Add(txtSName);
            groupBox1.Controls.Add(cmbDegreeProgram);
            groupBox1.Controls.Add(txtFatherName);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(dtpDOB);
            groupBox1.Controls.Add(cmbGender);
            groupBox1.Location = new Point(9, 261);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(384, 240);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task 2 - ADD Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(179, 23);
            label2.Name = "label2";
            label2.Size = new Size(56, 17);
            label2.TabIndex = 14;
            label2.Text = "Degree:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 52);
            label1.Name = "label1";
            label1.Size = new Size(61, 17);
            label1.TabIndex = 13;
            label1.Text = "Gender: ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 128, 255);
            groupBox2.Controls.Add(txtUpdateName);
            groupBox2.Controls.Add(txtUpdateRegId);
            groupBox2.Controls.Add(txtUpdateMatricGrade);
            groupBox2.Controls.Add(txtUpdateAddress);
            groupBox2.Controls.Add(btnUpdateRecord);
            groupBox2.Controls.Add(txtUpdateInterGrade);
            groupBox2.Location = new Point(399, 261);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 132);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "Task 4 - Update Student";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Cyan;
            groupBox3.Controls.Add(btnDeleteStudent);
            groupBox3.Controls.Add(txtDeleteRegId);
            groupBox3.Location = new Point(399, 399);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(280, 102);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Task 5 - Delete Student";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(708, 539);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgStudents);
            Controls.Add(btnRefreshView);
            Name = "Form1";
            Text = "Ahmad Rayan - Student Registration System (ADO.NET)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgStudents).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgStudents;
        private System.Windows.Forms.Button btnRefreshView;

        // Add
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtCNIC;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cmbDegreeProgram;
        private System.Windows.Forms.TextBox txtMatricGrade;
        private System.Windows.Forms.TextBox txtInterGrade;
        private System.Windows.Forms.Button btnAddStudent;

        // Update
        private System.Windows.Forms.TextBox txtUpdateRegId;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.TextBox txtUpdateMatricGrade;
        private System.Windows.Forms.TextBox txtUpdateInterGrade;
        private System.Windows.Forms.Button btnUpdateRecord;

        // Delete
        private System.Windows.Forms.TextBox txtDeleteRegId;
        private System.Windows.Forms.Button btnDeleteStudent;

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Label label2;
    }
}