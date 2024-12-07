namespace WinForms_Student_Managed_app
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addNewStudentToolStripMenuItem = new ToolStripMenuItem();
            studentsListToolStripMenuItem = new ToolStripMenuItem();
            statisticsToolStripMenuItem = new ToolStripMenuItem();
            editRemoveToolStripMenuItem = new ToolStripMenuItem();
            manageStudentsFormToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            courseToolStripMenuItem = new ToolStripMenuItem();
            scoreToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentToolStripMenuItem, courseToolStripMenuItem, scoreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1006, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.BackColor = Color.Bisque;
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewStudentToolStripMenuItem, studentsListToolStripMenuItem, statisticsToolStripMenuItem, editRemoveToolStripMenuItem, manageStudentsFormToolStripMenuItem, printToolStripMenuItem });
            studentToolStripMenuItem.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(105, 27);
            studentToolStripMenuItem.Text = "Student";
            studentToolStripMenuItem.Click += studentToolStripMenuItem_Click;
            // 
            // addNewStudentToolStripMenuItem
            // 
            addNewStudentToolStripMenuItem.BackColor = Color.FromArgb(255, 192, 192);
            addNewStudentToolStripMenuItem.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addNewStudentToolStripMenuItem.ForeColor = SystemColors.HotTrack;
            addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            addNewStudentToolStripMenuItem.Size = new Size(333, 28);
            addNewStudentToolStripMenuItem.Text = "Add New Student";
            addNewStudentToolStripMenuItem.Click += addNewStudentToolStripMenuItem_Click;
            // 
            // studentsListToolStripMenuItem
            // 
            studentsListToolStripMenuItem.BackColor = Color.FromArgb(255, 255, 192);
            studentsListToolStripMenuItem.ForeColor = SystemColors.HotTrack;
            studentsListToolStripMenuItem.Name = "studentsListToolStripMenuItem";
            studentsListToolStripMenuItem.Size = new Size(333, 28);
            studentsListToolStripMenuItem.Text = "Students List";
            studentsListToolStripMenuItem.Click += studentsListToolStripMenuItem_Click;
            // 
            // statisticsToolStripMenuItem
            // 
            statisticsToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 192);
            statisticsToolStripMenuItem.ForeColor = SystemColors.HotTrack;
            statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            statisticsToolStripMenuItem.Size = new Size(333, 28);
            statisticsToolStripMenuItem.Text = "Statistics";
            statisticsToolStripMenuItem.Click += statisticsToolStripMenuItem_Click;
            // 
            // editRemoveToolStripMenuItem
            // 
            editRemoveToolStripMenuItem.BackColor = Color.FromArgb(192, 255, 255);
            editRemoveToolStripMenuItem.ForeColor = SystemColors.HotTrack;
            editRemoveToolStripMenuItem.Name = "editRemoveToolStripMenuItem";
            editRemoveToolStripMenuItem.Size = new Size(333, 28);
            editRemoveToolStripMenuItem.Text = "Edit / Remove";
            editRemoveToolStripMenuItem.Click += editRemoveToolStripMenuItem_Click;
            // 
            // manageStudentsFormToolStripMenuItem
            // 
            manageStudentsFormToolStripMenuItem.BackColor = Color.FromArgb(192, 192, 255);
            manageStudentsFormToolStripMenuItem.ForeColor = SystemColors.HotTrack;
            manageStudentsFormToolStripMenuItem.Name = "manageStudentsFormToolStripMenuItem";
            manageStudentsFormToolStripMenuItem.Size = new Size(333, 28);
            manageStudentsFormToolStripMenuItem.Text = "Manage Students Form";
            manageStudentsFormToolStripMenuItem.Click += manageStudentsFormToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.BackColor = Color.FromArgb(255, 192, 255);
            printToolStripMenuItem.ForeColor = SystemColors.HotTrack;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(333, 28);
            printToolStripMenuItem.Text = "Print";
            // 
            // courseToolStripMenuItem
            // 
            courseToolStripMenuItem.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            courseToolStripMenuItem.Size = new Size(94, 27);
            courseToolStripMenuItem.Text = "Course";
            // 
            // scoreToolStripMenuItem
            // 
            scoreToolStripMenuItem.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            scoreToolStripMenuItem.Size = new Size(80, 27);
            scoreToolStripMenuItem.Text = "Score";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1006, 721);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem courseToolStripMenuItem;
        private ToolStripMenuItem scoreToolStripMenuItem;
        private ToolStripMenuItem addNewStudentToolStripMenuItem;
        private ToolStripMenuItem studentsListToolStripMenuItem;
        private ToolStripMenuItem statisticsToolStripMenuItem;
        private ToolStripMenuItem editRemoveToolStripMenuItem;
        private ToolStripMenuItem manageStudentsFormToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
    }
}
