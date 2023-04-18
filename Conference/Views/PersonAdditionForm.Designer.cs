namespace Conference.Views
{
    partial class PersonAdditionForm
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
            this.newPersonBtn = new System.Windows.Forms.Button();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textRole = new System.Windows.Forms.ComboBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newPersonBtn
            // 
            this.newPersonBtn.BackColor = System.Drawing.Color.Green;
            this.newPersonBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.newPersonBtn.Location = new System.Drawing.Point(12, 309);
            this.newPersonBtn.Name = "newPersonBtn";
            this.newPersonBtn.Size = new System.Drawing.Size(133, 40);
            this.newPersonBtn.TabIndex = 0;
            this.newPersonBtn.Text = "Добавить";
            this.newPersonBtn.UseVisualStyleBackColor = false;
            this.newPersonBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(145, 11);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(220, 23);
            this.textFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(145, 49);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(220, 23);
            this.textLastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номер телефона";
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(145, 127);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.Size = new System.Drawing.Size(220, 23);
            this.textPhoneNumber.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Электронная почта";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(145, 166);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(220, 23);
            this.textEmail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Должность";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.textRole);
            this.panel1.Controls.Add(this.textLastName);
            this.panel1.Controls.Add(this.textFirstName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textEmail);
            this.panel1.Controls.Add(this.textPhoneNumber);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 205);
            this.panel1.TabIndex = 12;
            // 
            // textRole
            // 
            this.textRole.FormattingEnabled = true;
            this.textRole.Items.AddRange(new object[] {
            "Студент",
            "Аспирант",
            "Преподаватель"});
            this.textRole.Location = new System.Drawing.Point(145, 88);
            this.textRole.Name = "textRole";
            this.textRole.Size = new System.Drawing.Size(220, 23);
            this.textRole.TabIndex = 11;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(12, 233);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 21);
            this.errorLabel.TabIndex = 13;
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
            // PersonAdditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newPersonBtn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "PersonAdditionForm";
            this.Text = "Добавить участника";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button newPersonBtn;
        private TextBox textFirstName;
        private Label label1;
        private Label label2;
        private TextBox textLastName;
        private Label label3;
        private TextBox textPhoneNumber;
        private Label label4;
        private TextBox textEmail;
        private Label label5;
        private Panel panel1;
        private Label errorLabel;
        private ComboBox textRole;
        private Button closeBtn;
    }
}