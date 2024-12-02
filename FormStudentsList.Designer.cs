namespace WinForms_Student_Managed_app
{
    partial class FormStudentsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentsList));
            dataGridViewListStudents = new DataGridView();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListStudents).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewListStudents
            // 
            dataGridViewListStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListStudents.Location = new Point(0, 0);
            dataGridViewListStudents.Name = "dataGridViewListStudents";
            dataGridViewListStudents.RowHeadersWidth = 51;
            dataGridViewListStudents.Size = new Size(803, 450);
            dataGridViewListStudents.TabIndex = 0;
            dataGridViewListStudents.CellClick += dataGridViewListStudents_CellClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormStudentsList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewListStudents);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormStudentsList";
            Text = "FormStudentsList";
            ((System.ComponentModel.ISupportInitialize)dataGridViewListStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewListStudents;
        private OpenFileDialog openFileDialog1;
    }
}