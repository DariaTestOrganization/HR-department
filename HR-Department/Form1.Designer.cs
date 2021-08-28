
namespace HR_Department
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.depList = new System.Windows.Forms.ComboBox();
            this.depName = new System.Windows.Forms.TextBox();
            this.addDepButton = new System.Windows.Forms.Button();
            this.saveDepButton = new System.Windows.Forms.Button();
            this.delDepButon = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.empList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.delPhotoButton = new System.Windows.Forms.Button();
            this.savePhotoButton = new System.Windows.Forms.Button();
            this.addPhotoButton = new System.Windows.Forms.Button();
            this.empPhoto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fioEmp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateBirthEmp = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.addressEmp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.telEmp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emailEmp = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.positionEmp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.salaryEmp = new System.Windows.Forms.NumericUpDown();
            this.workYears = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.delEmpButton = new System.Windows.Forms.Button();
            this.saveEmpButton = new System.Windows.Forms.Button();
            this.addEmpButton = new System.Windows.Forms.Button();
            this.clearFieldsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workYears)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.empList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.delDepButon);
            this.groupBox1.Controls.Add(this.saveDepButton);
            this.groupBox1.Controls.Add(this.addDepButton);
            this.groupBox1.Controls.Add(this.depName);
            this.groupBox1.Controls.Add(this.depList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сотрудники";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearFieldsButton);
            this.groupBox2.Controls.Add(this.delEmpButton);
            this.groupBox2.Controls.Add(this.saveEmpButton);
            this.groupBox2.Controls.Add(this.workYears);
            this.groupBox2.Controls.Add(this.addEmpButton);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.salaryEmp);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.positionEmp);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.emailEmp);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.telEmp);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.addressEmp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateBirthEmp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.fioEmp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(499, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 453);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.delPhotoButton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.savePhotoButton);
            this.groupBox3.Controls.Add(this.addPhotoButton);
            this.groupBox3.Controls.Add(this.empPhoto);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(213, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 453);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фото";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список департаментов:";
            // 
            // depList
            // 
            this.depList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depList.FormattingEnabled = true;
            this.depList.Location = new System.Drawing.Point(12, 54);
            this.depList.Name = "depList";
            this.depList.Size = new System.Drawing.Size(183, 23);
            this.depList.TabIndex = 1;
            this.depList.SelectedIndexChanged += new System.EventHandler(this.depList_SelectedIndexChanged);
            // 
            // depName
            // 
            this.depName.Location = new System.Drawing.Point(12, 83);
            this.depName.Name = "depName";
            this.depName.Size = new System.Drawing.Size(183, 21);
            this.depName.TabIndex = 2;
            // 
            // addDepButton
            // 
            this.addDepButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDepButton.Location = new System.Drawing.Point(12, 111);
            this.addDepButton.Name = "addDepButton";
            this.addDepButton.Size = new System.Drawing.Size(57, 23);
            this.addDepButton.TabIndex = 3;
            this.addDepButton.Text = "Add";
            this.addDepButton.UseVisualStyleBackColor = true;
            this.addDepButton.Click += new System.EventHandler(this.addDepButton_Click);
            // 
            // saveDepButton
            // 
            this.saveDepButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveDepButton.Location = new System.Drawing.Point(75, 111);
            this.saveDepButton.Name = "saveDepButton";
            this.saveDepButton.Size = new System.Drawing.Size(57, 23);
            this.saveDepButton.TabIndex = 4;
            this.saveDepButton.Text = "Save";
            this.saveDepButton.UseVisualStyleBackColor = true;
            // 
            // delDepButon
            // 
            this.delDepButon.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delDepButon.Location = new System.Drawing.Point(138, 111);
            this.delDepButon.Name = "delDepButon";
            this.delDepButon.Size = new System.Drawing.Size(57, 23);
            this.delDepButon.TabIndex = 5;
            this.delDepButon.Text = "Delete";
            this.delDepButon.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Список cотрудников:";
            // 
            // empList
            // 
            this.empList.FormattingEnabled = true;
            this.empList.ItemHeight = 15;
            this.empList.Location = new System.Drawing.Point(12, 174);
            this.empList.Name = "empList";
            this.empList.ScrollAlwaysVisible = true;
            this.empList.Size = new System.Drawing.Size(183, 274);
            this.empList.TabIndex = 7;
            this.empList.SelectedIndexChanged += new System.EventHandler(this.empList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Фото сотрудника:";
            // 
            // delPhotoButton
            // 
            this.delPhotoButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delPhotoButton.Location = new System.Drawing.Point(193, 418);
            this.delPhotoButton.Name = "delPhotoButton";
            this.delPhotoButton.Size = new System.Drawing.Size(87, 23);
            this.delPhotoButton.TabIndex = 10;
            this.delPhotoButton.Text = "Delete";
            this.delPhotoButton.UseVisualStyleBackColor = true;
            // 
            // savePhotoButton
            // 
            this.savePhotoButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.savePhotoButton.Location = new System.Drawing.Point(100, 418);
            this.savePhotoButton.Name = "savePhotoButton";
            this.savePhotoButton.Size = new System.Drawing.Size(87, 23);
            this.savePhotoButton.TabIndex = 9;
            this.savePhotoButton.Text = "Save";
            this.savePhotoButton.UseVisualStyleBackColor = true;
            // 
            // addPhotoButton
            // 
            this.addPhotoButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPhotoButton.Location = new System.Drawing.Point(6, 418);
            this.addPhotoButton.Name = "addPhotoButton";
            this.addPhotoButton.Size = new System.Drawing.Size(87, 23);
            this.addPhotoButton.TabIndex = 8;
            this.addPhotoButton.Text = "Add";
            this.addPhotoButton.UseVisualStyleBackColor = true;
            this.addPhotoButton.Click += new System.EventHandler(this.addPhotoButton_Click);
            // 
            // empPhoto
            // 
            this.empPhoto.Image = global::HR_Department.Properties.Resources.profile;
            this.empPhoto.Location = new System.Drawing.Point(6, 54);
            this.empPhoto.Name = "empPhoto";
            this.empPhoto.Size = new System.Drawing.Size(274, 358);
            this.empPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.empPhoto.TabIndex = 0;
            this.empPhoto.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "ФИО";
            // 
            // fioEmp
            // 
            this.fioEmp.Location = new System.Drawing.Point(9, 54);
            this.fioEmp.Name = "fioEmp";
            this.fioEmp.Size = new System.Drawing.Size(239, 21);
            this.fioEmp.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Дата рождения";
            // 
            // dateBirthEmp
            // 
            this.dateBirthEmp.Location = new System.Drawing.Point(9, 98);
            this.dateBirthEmp.Name = "dateBirthEmp";
            this.dateBirthEmp.Size = new System.Drawing.Size(239, 21);
            this.dateBirthEmp.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 15;
            // 
            // addressEmp
            // 
            this.addressEmp.Location = new System.Drawing.Point(9, 148);
            this.addressEmp.Name = "addressEmp";
            this.addressEmp.Size = new System.Drawing.Size(239, 21);
            this.addressEmp.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Адрес";
            // 
            // telEmp
            // 
            this.telEmp.Location = new System.Drawing.Point(9, 193);
            this.telEmp.Name = "telEmp";
            this.telEmp.Size = new System.Drawing.Size(239, 21);
            this.telEmp.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Номер телефона";
            // 
            // emailEmp
            // 
            this.emailEmp.Location = new System.Drawing.Point(9, 237);
            this.emailEmp.Name = "emailEmp";
            this.emailEmp.Size = new System.Drawing.Size(239, 21);
            this.emailEmp.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Email";
            // 
            // positionEmp
            // 
            this.positionEmp.Location = new System.Drawing.Point(9, 282);
            this.positionEmp.Name = "positionEmp";
            this.positionEmp.Size = new System.Drawing.Size(239, 21);
            this.positionEmp.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Должность";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Зарплата";
            // 
            // salaryEmp
            // 
            this.salaryEmp.Location = new System.Drawing.Point(121, 318);
            this.salaryEmp.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.salaryEmp.Name = "salaryEmp";
            this.salaryEmp.Size = new System.Drawing.Size(102, 21);
            this.salaryEmp.TabIndex = 25;
            // 
            // workYears
            // 
            this.workYears.Location = new System.Drawing.Point(121, 345);
            this.workYears.Name = "workYears";
            this.workYears.Size = new System.Drawing.Size(102, 21);
            this.workYears.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 15);
            this.label12.TabIndex = 26;
            this.label12.Text = "Стаж";
            // 
            // delEmpButton
            // 
            this.delEmpButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delEmpButton.Location = new System.Drawing.Point(10, 418);
            this.delEmpButton.Name = "delEmpButton";
            this.delEmpButton.Size = new System.Drawing.Size(116, 23);
            this.delEmpButton.TabIndex = 13;
            this.delEmpButton.Text = "Delete employee";
            this.delEmpButton.UseVisualStyleBackColor = true;
            // 
            // saveEmpButton
            // 
            this.saveEmpButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveEmpButton.Location = new System.Drawing.Point(132, 389);
            this.saveEmpButton.Name = "saveEmpButton";
            this.saveEmpButton.Size = new System.Drawing.Size(117, 23);
            this.saveEmpButton.TabIndex = 12;
            this.saveEmpButton.Text = "Save employee";
            this.saveEmpButton.UseVisualStyleBackColor = true;
            // 
            // addEmpButton
            // 
            this.addEmpButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmpButton.Location = new System.Drawing.Point(10, 389);
            this.addEmpButton.Name = "addEmpButton";
            this.addEmpButton.Size = new System.Drawing.Size(116, 23);
            this.addEmpButton.TabIndex = 11;
            this.addEmpButton.Text = "Add employee";
            this.addEmpButton.UseVisualStyleBackColor = true;
            // 
            // clearFieldsButton
            // 
            this.clearFieldsButton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearFieldsButton.Location = new System.Drawing.Point(132, 418);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.Size = new System.Drawing.Size(116, 23);
            this.clearFieldsButton.TabIndex = 28;
            this.clearFieldsButton.Text = "Clear fields";
            this.clearFieldsButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автоматизированная система управления отделом кадров";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workYears)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox depList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox depName;
        private System.Windows.Forms.ListBox empList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delDepButon;
        private System.Windows.Forms.Button saveDepButton;
        private System.Windows.Forms.Button addDepButton;
        private System.Windows.Forms.Button delPhotoButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button savePhotoButton;
        private System.Windows.Forms.Button addPhotoButton;
        private System.Windows.Forms.PictureBox empPhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fioEmp;
        private System.Windows.Forms.Button delEmpButton;
        private System.Windows.Forms.Button saveEmpButton;
        private System.Windows.Forms.NumericUpDown workYears;
        private System.Windows.Forms.Button addEmpButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown salaryEmp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox positionEmp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox emailEmp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox telEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addressEmp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateBirthEmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearFieldsButton;
    }
}

