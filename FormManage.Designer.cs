namespace WinForms_Student_Managed_app
{
    partial class FormManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManage));
            labelID = new Label();
            labelFirstName = new Label();
            labelLastName = new Label();
            labelBirthDay = new Label();
            labelGender = new Label();
            labelPhone = new Label();
            labelAddress = new Label();
            labelPicture = new Label();
            textBoxID = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPhone = new TextBox();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridViewManage = new DataGridView();
            labelSearch = new Label();
            textBoxSearch = new TextBox();
            buttonUploadImg = new Button();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonRemove = new Button();
            buttonReset = new Button();
            labelTotalStudents = new Label();
            dateTimePickerBirthDay = new DateTimePicker();
            panel1 = new Panel();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            buttonSearch = new Button();
            openFileDialogManage = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManage).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelID.Location = new Point(90, 9);
            labelID.Name = "labelID";
            labelID.Size = new Size(36, 23);
            labelID.TabIndex = 0;
            labelID.Text = "ID";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFirstName.Location = new Point(12, 62);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(119, 23);
            labelFirstName.TabIndex = 1;
            labelFirstName.Text = "FirstName";
            labelFirstName.Click += labelFirstName_Click;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelLastName.Location = new Point(17, 122);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(114, 23);
            labelLastName.TabIndex = 2;
            labelLastName.Text = "LastName";
            // 
            // labelBirthDay
            // 
            labelBirthDay.AutoSize = true;
            labelBirthDay.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBirthDay.Location = new Point(21, 179);
            labelBirthDay.Name = "labelBirthDay";
            labelBirthDay.Size = new Size(105, 23);
            labelBirthDay.TabIndex = 3;
            labelBirthDay.Text = "BitrhDay";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGender.Location = new Point(42, 243);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(84, 23);
            labelGender.TabIndex = 4;
            labelGender.Text = "Gender";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPhone.Location = new Point(54, 308);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(72, 23);
            labelPhone.TabIndex = 5;
            labelPhone.Text = "Phone";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAddress.Location = new Point(41, 371);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(90, 23);
            labelAddress.TabIndex = 6;
            labelAddress.Text = "Address";
            // 
            // labelPicture
            // 
            labelPicture.AutoSize = true;
            labelPicture.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPicture.Location = new Point(47, 472);
            labelPicture.Name = "labelPicture";
            labelPicture.Size = new Size(84, 23);
            labelPicture.TabIndex = 7;
            labelPicture.Text = "Picture";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(143, 12);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(262, 27);
            textBoxID.TabIndex = 8;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(143, 367);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(262, 97);
            textBoxAddress.TabIndex = 9;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(143, 304);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(262, 27);
            textBoxPhone.TabIndex = 10;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(143, 118);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(262, 27);
            textBoxLastName.TabIndex = 11;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(143, 58);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(262, 27);
            textBoxFirstName.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(143, 486);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // dataGridViewManage
            // 
            dataGridViewManage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewManage.Location = new Point(423, 62);
            dataGridViewManage.Name = "dataGridViewManage";
            dataGridViewManage.RowHeadersWidth = 51;
            dataGridViewManage.Size = new Size(761, 474);
            dataGridViewManage.TabIndex = 14;
            dataGridViewManage.CellContentClick += dataGridViewManage_CellContentClick;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSearch.Location = new Point(423, 9);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(249, 23);
            labelSearch.TabIndex = 15;
            labelSearch.Text = "Enter a value to search";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(678, 9);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(331, 27);
            textBoxSearch.TabIndex = 16;
            // 
            // buttonUploadImg
            // 
            buttonUploadImg.Location = new Point(142, 656);
            buttonUploadImg.Name = "buttonUploadImg";
            buttonUploadImg.Size = new Size(263, 27);
            buttonUploadImg.TabIndex = 17;
            buttonUploadImg.Text = "Upload Image";
            buttonUploadImg.UseVisualStyleBackColor = true;
            buttonUploadImg.Click += buttonUploadImg_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Lime;
            buttonAdd.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.Location = new Point(423, 671);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(125, 38);
            buttonAdd.TabIndex = 18;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Cyan;
            buttonEdit.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEdit.Location = new Point(554, 671);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(125, 38);
            buttonEdit.TabIndex = 19;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.BackColor = Color.FromArgb(255, 128, 128);
            buttonRemove.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRemove.Location = new Point(685, 671);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(125, 38);
            buttonRemove.TabIndex = 20;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = false;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonReset
            // 
            buttonReset.BackColor = Color.FromArgb(255, 128, 0);
            buttonReset.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.Location = new Point(816, 671);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(125, 38);
            buttonReset.TabIndex = 21;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // labelTotalStudents
            // 
            labelTotalStudents.AutoSize = true;
            labelTotalStudents.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalStudents.Location = new Point(979, 539);
            labelTotalStudents.Name = "labelTotalStudents";
            labelTotalStudents.Size = new Size(161, 23);
            labelTotalStudents.TabIndex = 22;
            labelTotalStudents.Text = "Total Students";
            // 
            // dateTimePickerBirthDay
            // 
            dateTimePickerBirthDay.Location = new Point(142, 177);
            dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            dateTimePickerBirthDay.Size = new Size(250, 27);
            dateTimePickerBirthDay.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButtonFemale);
            panel1.Controls.Add(radioButtonMale);
            panel1.Location = new Point(142, 232);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 49);
            panel1.TabIndex = 24;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(122, 11);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(78, 24);
            radioButtonFemale.TabIndex = 1;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(3, 11);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(63, 24);
            radioButtonMale.TabIndex = 0;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(128, 128, 255);
            buttonSearch.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSearch.Location = new Point(1015, 4);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(169, 38);
            buttonSearch.TabIndex = 25;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // openFileDialogManage
            // 
            openFileDialogManage.FileName = "openFileDialogManage";
            // 
            // FormManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 721);
            Controls.Add(buttonSearch);
            Controls.Add(panel1);
            Controls.Add(dateTimePickerBirthDay);
            Controls.Add(labelTotalStudents);
            Controls.Add(buttonReset);
            Controls.Add(buttonRemove);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(buttonUploadImg);
            Controls.Add(textBoxSearch);
            Controls.Add(labelSearch);
            Controls.Add(dataGridViewManage);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxID);
            Controls.Add(labelPicture);
            Controls.Add(labelAddress);
            Controls.Add(labelPhone);
            Controls.Add(labelGender);
            Controls.Add(labelBirthDay);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Controls.Add(labelID);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormManage";
            Text = "FormManage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewManage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelID;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelBirthDay;
        private Label labelGender;
        private Label labelPhone;
        private Label labelAddress;
        private Label labelPicture;
        private TextBox textBoxID;
        private TextBox textBoxAddress;
        private TextBox textBoxPhone;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label labelSearch;
        private TextBox textBoxSearch;
        private Button buttonUploadImg;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonRemove;
        private Button buttonReset;
        private Label labelTotalStudents;
        private DateTimePicker dateTimePickerBirthDay;
        private Panel panel1;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private Button buttonSearch;
        public DataGridView dataGridViewManage;
        public OpenFileDialog openFileDialogManage;
    }
}