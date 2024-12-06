namespace WinForms_Student_Managed_app
{
    partial class FormEditAndRemove
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
            textBoxID = new TextBox();
            openFileDialogStudentImage = new OpenFileDialog();
            ButtonEdit = new Button();
            RemoveButton = new Button();
            UploadImageButton = new Button();
            FemaleRadioButton = new RadioButton();
            MaleRadioButton = new RadioButton();
            labelID = new Label();
            GenderGroupBox = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            PictureBox = new PictureBox();
            AddressTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            LastNameTextBox = new TextBox();
            PictureLable = new Label();
            AddressLable = new Label();
            PhoneNumberLable = new Label();
            GenderLable = new Label();
            BirthDateLable = new Label();
            LastNameLable = new Label();
            FirstNameTextBox = new TextBox();
            FirstNameLable = new Label();
            buttonFind = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            openFileDialog1 = new OpenFileDialog();
            GenderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(268, 30);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(283, 27);
            textBoxID.TabIndex = 38;
            // 
            // openFileDialogStudentImage
            // 
            openFileDialogStudentImage.FileName = "openFileDialogStudentImage";
            // 
            // ButtonEdit
            // 
            ButtonEdit.BackColor = Color.LawnGreen;
            ButtonEdit.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonEdit.Location = new Point(635, 651);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new Size(169, 39);
            ButtonEdit.TabIndex = 36;
            ButtonEdit.Text = "Edit";
            ButtonEdit.UseVisualStyleBackColor = false;
            ButtonEdit.Click += ButtonEdit_Click_1;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = Color.LightCoral;
            RemoveButton.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemoveButton.ForeColor = Color.Black;
            RemoveButton.Location = new Point(457, 651);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(155, 39);
            RemoveButton.TabIndex = 35;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // UploadImageButton
            // 
            UploadImageButton.BackColor = Color.Gainsboro;
            UploadImageButton.Location = new Point(830, 422);
            UploadImageButton.Name = "UploadImageButton";
            UploadImageButton.Size = new Size(283, 29);
            UploadImageButton.TabIndex = 34;
            UploadImageButton.Text = "upload image";
            UploadImageButton.UseVisualStyleBackColor = false;
            UploadImageButton.Click += UploadImageButton_Click;
            // 
            // FemaleRadioButton
            // 
            FemaleRadioButton.AutoSize = true;
            FemaleRadioButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            FemaleRadioButton.Location = new Point(98, 36);
            FemaleRadioButton.Name = "FemaleRadioButton";
            FemaleRadioButton.Size = new Size(86, 27);
            FemaleRadioButton.TabIndex = 16;
            FemaleRadioButton.TabStop = true;
            FemaleRadioButton.Text = "Female";
            FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            MaleRadioButton.Location = new Point(6, 36);
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Size = new Size(69, 27);
            MaleRadioButton.TabIndex = 15;
            MaleRadioButton.TabStop = true;
            MaleRadioButton.Text = "Male";
            MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.BackColor = Color.FromArgb(128, 255, 255);
            labelID.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelID.Location = new Point(198, 34);
            labelID.Name = "labelID";
            labelID.Size = new Size(50, 23);
            labelID.TabIndex = 37;
            labelID.Text = "ID :";
            // 
            // GenderGroupBox
            // 
            GenderGroupBox.Controls.Add(FemaleRadioButton);
            GenderGroupBox.Controls.Add(MaleRadioButton);
            GenderGroupBox.Location = new Point(268, 263);
            GenderGroupBox.Name = "GenderGroupBox";
            GenderGroupBox.Size = new Size(221, 78);
            GenderGroupBox.TabIndex = 33;
            GenderGroupBox.TabStop = false;
            GenderGroupBox.Enter += GenderGroupBox_Enter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(268, 226);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(283, 27);
            dateTimePicker1.TabIndex = 32;
            // 
            // PictureBox
            // 
            PictureBox.BackColor = Color.PaleTurquoise;
            PictureBox.Location = new Point(830, 215);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(283, 191);
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 31;
            PictureBox.TabStop = false;
            PictureBox.Click += PictureBox_Click;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(830, 34);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(283, 146);
            AddressTextBox.TabIndex = 30;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(268, 379);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(283, 27);
            PhoneTextBox.TabIndex = 29;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(268, 153);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(283, 27);
            LastNameTextBox.TabIndex = 28;
            // 
            // PictureLable
            // 
            PictureLable.AutoSize = true;
            PictureLable.BackColor = Color.FromArgb(255, 192, 255);
            PictureLable.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PictureLable.Location = new Point(706, 215);
            PictureLable.Name = "PictureLable";
            PictureLable.Size = new Size(98, 23);
            PictureLable.TabIndex = 27;
            PictureLable.Text = "Picture :";
            // 
            // AddressLable
            // 
            AddressLable.AutoSize = true;
            AddressLable.BackColor = Color.FromArgb(192, 192, 255);
            AddressLable.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddressLable.Location = new Point(700, 34);
            AddressLable.Name = "AddressLable";
            AddressLable.Size = new Size(104, 23);
            AddressLable.TabIndex = 26;
            AddressLable.Text = "Address :";
            // 
            // PhoneNumberLable
            // 
            PhoneNumberLable.AutoSize = true;
            PhoneNumberLable.BackColor = Color.FromArgb(192, 255, 255);
            PhoneNumberLable.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneNumberLable.Location = new Point(73, 383);
            PhoneNumberLable.Name = "PhoneNumberLable";
            PhoneNumberLable.Size = new Size(175, 23);
            PhoneNumberLable.TabIndex = 25;
            PhoneNumberLable.Text = "Phone Number :";
            // 
            // GenderLable
            // 
            GenderLable.AutoSize = true;
            GenderLable.BackColor = Color.FromArgb(192, 255, 192);
            GenderLable.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenderLable.Location = new Point(150, 302);
            GenderLable.Name = "GenderLable";
            GenderLable.Size = new Size(98, 23);
            GenderLable.TabIndex = 24;
            GenderLable.Text = "Gender :";
            // 
            // BirthDateLable
            // 
            BirthDateLable.AutoSize = true;
            BirthDateLable.BackColor = Color.FromArgb(255, 255, 192);
            BirthDateLable.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BirthDateLable.Location = new Point(114, 230);
            BirthDateLable.Name = "BirthDateLable";
            BirthDateLable.Size = new Size(134, 23);
            BirthDateLable.TabIndex = 23;
            BirthDateLable.Text = "Birth Date :";
            // 
            // LastNameLable
            // 
            LastNameLable.AutoSize = true;
            LastNameLable.BackColor = Color.FromArgb(255, 224, 192);
            LastNameLable.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LastNameLable.Location = new Point(114, 157);
            LastNameLable.Name = "LastNameLable";
            LastNameLable.Size = new Size(135, 23);
            LastNameLable.TabIndex = 22;
            LastNameLable.Text = "Last Name :";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(268, 79);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(283, 27);
            FirstNameTextBox.TabIndex = 21;
            // 
            // FirstNameLable
            // 
            FirstNameLable.AutoSize = true;
            FirstNameLable.BackColor = Color.FromArgb(255, 192, 192);
            FirstNameLable.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FirstNameLable.ForeColor = Color.Black;
            FirstNameLable.Location = new Point(108, 83);
            FirstNameLable.Name = "FirstNameLable";
            FirstNameLable.Size = new Size(140, 23);
            FirstNameLable.TabIndex = 20;
            FirstNameLable.Text = "First Name :";
            // 
            // buttonFind
            // 
            buttonFind.BackColor = Color.Violet;
            buttonFind.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFind.Location = new Point(36, 30);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(140, 32);
            buttonFind.TabIndex = 39;
            buttonFind.Text = "Find";
            buttonFind.UseVisualStyleBackColor = false;
            buttonFind.Click += buttonFind_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialogFormEdiRem";
            // 
            // FormEditAndRemove
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 721);
            Controls.Add(buttonFind);
            Controls.Add(textBoxID);
            Controls.Add(ButtonEdit);
            Controls.Add(RemoveButton);
            Controls.Add(UploadImageButton);
            Controls.Add(labelID);
            Controls.Add(GenderGroupBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(PictureBox);
            Controls.Add(AddressTextBox);
            Controls.Add(PhoneTextBox);
            Controls.Add(LastNameTextBox);
            Controls.Add(PictureLable);
            Controls.Add(AddressLable);
            Controls.Add(PhoneNumberLable);
            Controls.Add(GenderLable);
            Controls.Add(BirthDateLable);
            Controls.Add(LastNameLable);
            Controls.Add(FirstNameTextBox);
            Controls.Add(FirstNameLable);
            Name = "FormEditAndRemove";
            Text = "FormEditAndRemove";
            GenderGroupBox.ResumeLayout(false);
            GenderGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialogStudentImage;
        private Button ButtonEdit;
        private Button RemoveButton;
        private Label labelID;
        private Label PictureLable;
        private Label AddressLable;
        private Label PhoneNumberLable;
        private Label GenderLable;
        private Label BirthDateLable;
        private Label LastNameLable;
        private Label FirstNameLable;
        private Button buttonFind;
        private FileSystemWatcher fileSystemWatcher1;
        public TextBox textBoxID;
        public Button UploadImageButton;
        public RadioButton FemaleRadioButton;
        public RadioButton MaleRadioButton;
        public GroupBox GenderGroupBox;
        public DateTimePicker dateTimePicker1;
        public PictureBox PictureBox;
        public TextBox AddressTextBox;
        public TextBox PhoneTextBox;
        public TextBox LastNameTextBox;
        public TextBox FirstNameTextBox;
        private OpenFileDialog openFileDialog1;
    }
}