namespace Conference.Views
{
    partial class MeetingAdditionForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textDayTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textSectionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newMeetingBtn = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.textDayTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textSectionName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 205);
            this.panel1.TabIndex = 13;
            // 
            // textDayTime
            // 
            this.textDayTime.Location = new System.Drawing.Point(140, 40);
            this.textDayTime.Name = "textDayTime";
            this.textDayTime.Size = new System.Drawing.Size(232, 23);
            this.textDayTime.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Время проведения";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(140, 67);
            this.dateTimePicker.MinDate = new System.DateTime(2023, 4, 17, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(232, 23);
            this.dateTimePicker.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата проведения";
            // 
            // textSectionName
            // 
            this.textSectionName.Location = new System.Drawing.Point(140, 11);
            this.textSectionName.Name = "textSectionName";
            this.textSectionName.Size = new System.Drawing.Size(232, 23);
            this.textSectionName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название секции";
            // 
            // newMeetingBtn
            // 
            this.newMeetingBtn.Location = new System.Drawing.Point(339, 309);
            this.newMeetingBtn.Name = "newMeetingBtn";
            this.newMeetingBtn.Size = new System.Drawing.Size(133, 40);
            this.newMeetingBtn.TabIndex = 14;
            this.newMeetingBtn.Text = "Добавить";
            this.newMeetingBtn.UseVisualStyleBackColor = true;
            this.newMeetingBtn.Click += new System.EventHandler(this.newMeetingBtn_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.Location = new System.Drawing.Point(9, 234);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 21);
            this.errorLabel.TabIndex = 15;
            // 
            // MeetingAdditionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.newMeetingBtn);
            this.Controls.Add(this.panel1);
            this.Name = "MeetingAdditionForm";
            this.Text = "Добавить собрание по секции";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePicker;
        private Label label2;
        private TextBox textSectionName;
        private Label label1;
        private Button newMeetingBtn;
        private TextBox textDayTime;
        private Label label3;
        private Label errorLabel;
    }
}