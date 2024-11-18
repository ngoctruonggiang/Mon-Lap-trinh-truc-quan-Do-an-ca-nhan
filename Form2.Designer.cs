namespace WinForms_Student_Managed_app
{
    partial class AddStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            FirstNameLable = new Label();
            FirstNameTextBox = new TextBox();
            LastNameLable = new Label();
            BirthDateLable = new Label();
            GenderLable = new Label();
            PhoneNumberLable = new Label();
            AddressLable = new Label();
            PictureLable = new Label();
            LastNameTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            AddressTextBox = new TextBox();
            PictureBox = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            GenderGroupBox = new GroupBox();
            FemaleRadioButton = new RadioButton();
            MaleRadioButton = new RadioButton();
            UploadImageButton = new Button();
            CancelButton = new Button();
            AddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            GenderGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FirstNameLable
            // 
            FirstNameLable.AutoSize = true;
            FirstNameLable.BackColor = Color.FromArgb(255, 192, 192);
            FirstNameLable.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FirstNameLable.ForeColor = Color.Black;
            FirstNameLable.Location = new Point(89, 57);
            FirstNameLable.Name = "FirstNameLable";
            FirstNameLable.Size = new Size(140, 23);
            FirstNameLable.TabIndex = 0;
            FirstNameLable.Text = "First Name :";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(249, 53);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(283, 27);
            FirstNameTextBox.TabIndex = 1;
            FirstNameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // LastNameLable
            // 
            LastNameLable.AutoSize = true;
            LastNameLable.BackColor = Color.FromArgb(255, 224, 192);
            LastNameLable.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LastNameLable.Location = new Point(94, 131);
            LastNameLable.Name = "LastNameLable";
            LastNameLable.Size = new Size(135, 23);
            LastNameLable.TabIndex = 2;
            LastNameLable.Text = "Last Name :";
            // 
            // BirthDateLable
            // 
            BirthDateLable.AutoSize = true;
            BirthDateLable.BackColor = Color.FromArgb(255, 255, 192);
            BirthDateLable.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BirthDateLable.Location = new Point(95, 206);
            BirthDateLable.Name = "BirthDateLable";
            BirthDateLable.Size = new Size(134, 23);
            BirthDateLable.TabIndex = 3;
            BirthDateLable.Text = "Birth Date :";
            BirthDateLable.Click += BirthDateLable_Click;
            // 
            // GenderLable
            // 
            GenderLable.AutoSize = true;
            GenderLable.BackColor = Color.FromArgb(192, 255, 192);
            GenderLable.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GenderLable.Location = new Point(131, 279);
            GenderLable.Name = "GenderLable";
            GenderLable.Size = new Size(98, 23);
            GenderLable.TabIndex = 4;
            GenderLable.Text = "Gender :";
            GenderLable.Click += GenderLable_Click;
            // 
            // PhoneNumberLable
            // 
            PhoneNumberLable.AutoSize = true;
            PhoneNumberLable.BackColor = Color.FromArgb(192, 255, 255);
            PhoneNumberLable.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PhoneNumberLable.Location = new Point(54, 353);
            PhoneNumberLable.Name = "PhoneNumberLable";
            PhoneNumberLable.Size = new Size(175, 23);
            PhoneNumberLable.TabIndex = 5;
            PhoneNumberLable.Text = "Phone Number :";
            PhoneNumberLable.Click += PhoneNumberLable_Click;
            // 
            // AddressLable
            // 
            AddressLable.AutoSize = true;
            AddressLable.BackColor = Color.FromArgb(192, 192, 255);
            AddressLable.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddressLable.Location = new Point(681, 53);
            AddressLable.Name = "AddressLable";
            AddressLable.Size = new Size(104, 23);
            AddressLable.TabIndex = 6;
            AddressLable.Text = "Address :";
            // 
            // PictureLable
            // 
            PictureLable.AutoSize = true;
            PictureLable.BackColor = Color.FromArgb(255, 192, 255);
            PictureLable.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PictureLable.Location = new Point(687, 234);
            PictureLable.Name = "PictureLable";
            PictureLable.Size = new Size(98, 23);
            PictureLable.TabIndex = 7;
            PictureLable.Text = "Picture :";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(249, 127);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(283, 27);
            LastNameTextBox.TabIndex = 8;
            LastNameTextBox.TextChanged += LastNameTextBox_TextChanged;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(249, 349);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(283, 27);
            PhoneTextBox.TabIndex = 10;
            PhoneTextBox.TextChanged += PhoneTextBox_TextChanged;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(811, 53);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(283, 146);
            AddressTextBox.TabIndex = 11;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // PictureBox
            // 
            PictureBox.BackColor = Color.PaleTurquoise;
            PictureBox.Location = new Point(811, 234);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(283, 191);
            PictureBox.TabIndex = 12;
            PictureBox.TabStop = false;
            PictureBox.Click += PictureBox_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(249, 206);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(283, 27);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // GenderGroupBox
            // 
            GenderGroupBox.Controls.Add(FemaleRadioButton);
            GenderGroupBox.Controls.Add(MaleRadioButton);
            GenderGroupBox.Location = new Point(249, 239);
            GenderGroupBox.Name = "GenderGroupBox";
            GenderGroupBox.Size = new Size(221, 78);
            GenderGroupBox.TabIndex = 14;
            GenderGroupBox.TabStop = false;
            GenderGroupBox.Enter += GenderGroupBox_Enter;
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
            // UploadImageButton
            // 
            UploadImageButton.BackColor = Color.Gainsboro;
            UploadImageButton.Location = new Point(811, 441);
            UploadImageButton.Name = "UploadImageButton";
            UploadImageButton.Size = new Size(283, 29);
            UploadImageButton.TabIndex = 15;
            UploadImageButton.Text = "upload image";
            UploadImageButton.UseVisualStyleBackColor = false;
            UploadImageButton.Click += UploadImageButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.LightCoral;
            CancelButton.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CancelButton.ForeColor = Color.Black;
            CancelButton.Location = new Point(438, 670);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(155, 39);
            CancelButton.TabIndex = 16;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.LawnGreen;
            AddButton.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(616, 670);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(169, 39);
            AddButton.TabIndex = 17;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1186, 721);
            Controls.Add(AddButton);
            Controls.Add(CancelButton);
            Controls.Add(UploadImageButton);
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
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            Load += AddStudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            GenderGroupBox.ResumeLayout(false);
            GenderGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNameLable;
        private TextBox FirstNameTextBox;
        private Label LastNameLable;
        private Label BirthDateLable;
        private Label GenderLable;
        private Label PhoneNumberLable;
        private Label AddressLable;
        private Label PictureLable;
        private TextBox LastNameTextBox;
        private TextBox textBox1;
        private TextBox PhoneTextBox;
        private TextBox AddressTextBox;
        private PictureBox PictureBox;
        private DateTimePicker dateTimePicker1;
        private GroupBox GenderGroupBox;
        private RadioButton FemaleRadioButton;
        private RadioButton MaleRadioButton;
        private Button UploadImageButton;
        private Button CancelButton;
        private Button AddButton;
    }
}