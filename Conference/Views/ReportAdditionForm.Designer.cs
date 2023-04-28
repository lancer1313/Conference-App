namespace Conference.Views
{
    partial class ReportAdditionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportAdditionForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textSpeciality = new System.Windows.Forms.ComboBox();
            this.textTheme = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newReportBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.textSpeciality);
            this.panel1.Controls.Add(this.textTheme);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 205);
            this.panel1.TabIndex = 13;
            // 
            // textSpeciality
            // 
            this.textSpeciality.FormattingEnabled = true;
            this.textSpeciality.Items.AddRange(new object[] {
            "Информатика",
            "Биология",
            "Математика",
            "Физика",
            "Химия"});
            this.textSpeciality.Location = new System.Drawing.Point(145, 88);
            this.textSpeciality.Name = "textSpeciality";
            this.textSpeciality.Size = new System.Drawing.Size(220, 23);
            this.textSpeciality.TabIndex = 11;
            // 
            // textTheme
            // 
            this.textTheme.Location = new System.Drawing.Point(145, 49);
            this.textTheme.Name = "textTheme";
            this.textTheme.Size = new System.Drawing.Size(220, 23);
            this.textTheme.TabIndex = 3;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(145, 11);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(220, 23);
            this.textName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Специальность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тематика";
            // 
            // newReportBtn
            // 
            this.newReportBtn.BackColor = System.Drawing.Color.Green;
            this.newReportBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.newReportBtn.Location = new System.Drawing.Point(12, 309);
            this.newReportBtn.Name = "newReportBtn";
            this.newReportBtn.Size = new System.Drawing.Size(133, 40);
            this.newReportBtn.TabIndex = 14;
            this.newReportBtn.Text = "Добавить";
            this.newReportBtn.UseVisualStyleBackColor = false;
            this.newReportBtn.Click += new System.EventHandler(this.newReportBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.closeBtn.Location = new System.Drawing.Point(339, 309);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(133, 40);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(23, 239);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 21);
            this.errorLabel.TabIndex = 16;
            // 
            // ReportAdditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.newReportBtn);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "ReportAdditionForm";
            this.Text = "Добавить доклад";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private ComboBox textSpeciality;
        private TextBox textTheme;
        private TextBox textName;
        private Label label5;
        private Label label1;
        private Label label2;
        private Button newReportBtn;
        private Button closeBtn;
        private Label errorLabel;
    }
}