namespace WinForms_Student_Managed_app
{
    partial class FormStatistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatistics));
            panelTotalStudents = new Panel();
            labelTotalStudents = new Label();
            panelMaleRatio = new Panel();
            panelFemaleRatio = new Panel();
            labelMaleRatio = new Label();
            labelFemaleRatio = new Label();
            panelTotalStudents.SuspendLayout();
            panelMaleRatio.SuspendLayout();
            panelFemaleRatio.SuspendLayout();
            SuspendLayout();
            // 
            // panelTotalStudents
            // 
            panelTotalStudents.BackColor = Color.BlueViolet;
            panelTotalStudents.Controls.Add(labelTotalStudents);
            panelTotalStudents.Location = new Point(3, 1);
            panelTotalStudents.Name = "panelTotalStudents";
            panelTotalStudents.Size = new Size(795, 182);
            panelTotalStudents.TabIndex = 0;
            // 
            // labelTotalStudents
            // 
            labelTotalStudents.AutoSize = true;
            labelTotalStudents.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalStudents.Location = new Point(255, 78);
            labelTotalStudents.Name = "labelTotalStudents";
            labelTotalStudents.Size = new Size(283, 33);
            labelTotalStudents.TabIndex = 0;
            labelTotalStudents.Text = "Total Students is : ";
            labelTotalStudents.TextAlign = ContentAlignment.MiddleCenter;
            labelTotalStudents.Click += label1_Click;
            // 
            // panelMaleRatio
            // 
            panelMaleRatio.BackColor = Color.MediumBlue;
            panelMaleRatio.Controls.Add(labelMaleRatio);
            panelMaleRatio.Location = new Point(3, 181);
            panelMaleRatio.Name = "panelMaleRatio";
            panelMaleRatio.Size = new Size(394, 273);
            panelMaleRatio.TabIndex = 1;
            // 
            // panelFemaleRatio
            // 
            panelFemaleRatio.BackColor = Color.FromArgb(255, 128, 255);
            panelFemaleRatio.Controls.Add(labelFemaleRatio);
            panelFemaleRatio.Location = new Point(394, 181);
            panelFemaleRatio.Name = "panelFemaleRatio";
            panelFemaleRatio.Size = new Size(404, 273);
            panelFemaleRatio.TabIndex = 2;
            // 
            // labelMaleRatio
            // 
            labelMaleRatio.AutoSize = true;
            labelMaleRatio.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMaleRatio.ForeColor = Color.FromArgb(255, 128, 255);
            labelMaleRatio.Location = new Point(9, 121);
            labelMaleRatio.Name = "labelMaleRatio";
            labelMaleRatio.Size = new Size(135, 33);
            labelMaleRatio.TabIndex = 0;
            labelMaleRatio.Text = "% Male :";
            // 
            // labelFemaleRatio
            // 
            labelFemaleRatio.AutoSize = true;
            labelFemaleRatio.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFemaleRatio.ForeColor = Color.MediumBlue;
            labelFemaleRatio.Location = new Point(3, 121);
            labelFemaleRatio.Name = "labelFemaleRatio";
            labelFemaleRatio.Size = new Size(169, 33);
            labelFemaleRatio.TabIndex = 0;
            labelFemaleRatio.Text = "% Female :";
            // 
            // FormStatistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFemaleRatio);
            Controls.Add(panelMaleRatio);
            Controls.Add(panelTotalStudents);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormStatistics";
            Text = "FormStatistics";
            panelTotalStudents.ResumeLayout(false);
            panelTotalStudents.PerformLayout();
            panelMaleRatio.ResumeLayout(false);
            panelMaleRatio.PerformLayout();
            panelFemaleRatio.ResumeLayout(false);
            panelFemaleRatio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTotalStudents;
        public Label labelTotalStudents;
        public Panel panelMaleRatio;
        private Panel panelFemaleRatio;
        private Label labelMaleRatio;
        private Label labelFemaleRatio;
    }
}