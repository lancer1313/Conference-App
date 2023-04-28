namespace Conference.Views
{
    partial class ViewMeetingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMeetingForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.peopleOnMeetingTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textDayTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSectionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addPersonToMeeting = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleOnMeetingTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.peopleOnMeetingTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Участники собрания";
            // 
            // peopleOnMeetingTable
            // 
            this.peopleOnMeetingTable.AllowUserToAddRows = false;
            this.peopleOnMeetingTable.AllowUserToDeleteRows = false;
            this.peopleOnMeetingTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peopleOnMeetingTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.peopleOnMeetingTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.peopleOnMeetingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleOnMeetingTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.peopleOnMeetingTable.Location = new System.Drawing.Point(6, 22);
            this.peopleOnMeetingTable.Name = "peopleOnMeetingTable";
            this.peopleOnMeetingTable.ReadOnly = true;
            this.peopleOnMeetingTable.RowHeadersVisible = false;
            this.peopleOnMeetingTable.RowTemplate.Height = 25;
            this.peopleOnMeetingTable.Size = new System.Drawing.Size(478, 275);
            this.peopleOnMeetingTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.textCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textDayTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textSectionName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 113);
            this.panel1.TabIndex = 14;
            // 
            // textCount
            // 
            this.textCount.Location = new System.Drawing.Point(163, 69);
            this.textCount.Name = "textCount";
            this.textCount.ReadOnly = true;
            this.textCount.Size = new System.Drawing.Size(232, 23);
            this.textCount.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Количество участников";
            // 
            // textDayTime
            // 
            this.textDayTime.Location = new System.Drawing.Point(163, 40);
            this.textDayTime.Name = "textDayTime";
            this.textDayTime.ReadOnly = true;
            this.textDayTime.Size = new System.Drawing.Size(232, 23);
            this.textDayTime.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата и время";
            // 
            // textSectionName
            // 
            this.textSectionName.Location = new System.Drawing.Point(163, 11);
            this.textSectionName.Name = "textSectionName";
            this.textSectionName.ReadOnly = true;
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
            // addPersonToMeeting
            // 
            this.addPersonToMeeting.BackColor = System.Drawing.Color.Green;
            this.addPersonToMeeting.ForeColor = System.Drawing.SystemColors.Window;
            this.addPersonToMeeting.Location = new System.Drawing.Point(517, 168);
            this.addPersonToMeeting.Name = "addPersonToMeeting";
            this.addPersonToMeeting.Size = new System.Drawing.Size(155, 40);
            this.addPersonToMeeting.TabIndex = 15;
            this.addPersonToMeeting.Text = "Добавить участника";
            this.addPersonToMeeting.UseVisualStyleBackColor = false;
            this.addPersonToMeeting.Click += new System.EventHandler(this.addPersonToMeeting_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.closeBtn.Location = new System.Drawing.Point(517, 403);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(155, 40);
            this.closeBtn.TabIndex = 16;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Фамилия";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Должность";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Статус";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ViewMeetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.addPersonToMeeting);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "ViewMeetingForm";
            this.Text = "Собрание";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peopleOnMeetingTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView peopleOnMeetingTable;
        private Panel panel1;
        private TextBox textDayTime;
        private Label label3;
        private TextBox textSectionName;
        private Label label1;
        private TextBox textCount;
        private Label label2;
        private Button addPersonToMeeting;
        private Button closeBtn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
    }
}