namespace Conference.Views
{
    partial class ViewPersonForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPersonForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textRole = new System.Windows.Forms.TextBox();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newReportBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.personsReportTable = new System.Windows.Forms.DataGridView();
            this.joinMeetingBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.personMeetingsTable = new System.Windows.Forms.DataGridView();
            this.closeBtn = new System.Windows.Forms.Button();
            this.deletePersonBtn = new System.Windows.Forms.Button();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personsReportTable)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personMeetingsTable)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(665, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 205);
            this.panel1.TabIndex = 13;
            // 
            // textRole
            // 
            this.textRole.Location = new System.Drawing.Point(121, 94);
            this.textRole.Name = "textRole";
            this.textRole.ReadOnly = true;
            this.textRole.Size = new System.Drawing.Size(220, 23);
            this.textRole.TabIndex = 11;
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(121, 52);
            this.textLastName.Name = "textLastName";
            this.textLastName.ReadOnly = true;
            this.textLastName.Size = new System.Drawing.Size(220, 23);
            this.textLastName.TabIndex = 3;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(121, 14);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.ReadOnly = true;
            this.textFirstName.Size = new System.Drawing.Size(220, 23);
            this.textFirstName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Должность";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Электронная почта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Фамилия";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(121, 169);
            this.textEmail.Name = "textEmail";
            this.textEmail.ReadOnly = true;
            this.textEmail.Size = new System.Drawing.Size(220, 23);
            this.textEmail.TabIndex = 7;
            // 
            // textPhoneNumber
            // 
            this.textPhoneNumber.Location = new System.Drawing.Point(121, 130);
            this.textPhoneNumber.Name = "textPhoneNumber";
            this.textPhoneNumber.ReadOnly = true;
            this.textPhoneNumber.Size = new System.Drawing.Size(220, 23);
            this.textPhoneNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Номер телефона";
            // 
            // newReportBtn
            // 
            this.newReportBtn.BackColor = System.Drawing.Color.Green;
            this.newReportBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.newReportBtn.Location = new System.Drawing.Point(867, 352);
            this.newReportBtn.Name = "newReportBtn";
            this.newReportBtn.Size = new System.Drawing.Size(155, 40);
            this.newReportBtn.TabIndex = 14;
            this.newReportBtn.Text = "Добавить доклад";
            this.newReportBtn.UseVisualStyleBackColor = false;
            this.newReportBtn.Click += new System.EventHandler(this.newReportBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.personsReportTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 205);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Доклады участника";
            // 
            // personsReportTable
            // 
            this.personsReportTable.AllowUserToAddRows = false;
            this.personsReportTable.AllowUserToDeleteRows = false;
            this.personsReportTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personsReportTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personsReportTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.personsReportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personsReportTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column10});
            this.personsReportTable.Location = new System.Drawing.Point(6, 22);
            this.personsReportTable.Name = "personsReportTable";
            this.personsReportTable.ReadOnly = true;
            this.personsReportTable.RowHeadersVisible = false;
            this.personsReportTable.RowTemplate.Height = 25;
            this.personsReportTable.Size = new System.Drawing.Size(635, 177);
            this.personsReportTable.TabIndex = 0;
            this.personsReportTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personsReportTable_CellContentClick);
            // 
            // joinMeetingBtn
            // 
            this.joinMeetingBtn.BackColor = System.Drawing.Color.Green;
            this.joinMeetingBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.joinMeetingBtn.Location = new System.Drawing.Point(694, 352);
            this.joinMeetingBtn.Name = "joinMeetingBtn";
            this.joinMeetingBtn.Size = new System.Drawing.Size(155, 40);
            this.joinMeetingBtn.TabIndex = 16;
            this.joinMeetingBtn.Text = "Добавиться в собрание";
            this.joinMeetingBtn.UseVisualStyleBackColor = false;
            this.joinMeetingBtn.Click += new System.EventHandler(this.joinMeetingBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.personMeetingsTable);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 210);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Собрания участника";
            // 
            // personMeetingsTable
            // 
            this.personMeetingsTable.AllowUserToAddRows = false;
            this.personMeetingsTable.AllowUserToDeleteRows = false;
            this.personMeetingsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personMeetingsTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.personMeetingsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personMeetingsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column11});
            this.personMeetingsTable.Location = new System.Drawing.Point(6, 22);
            this.personMeetingsTable.Name = "personMeetingsTable";
            this.personMeetingsTable.ReadOnly = true;
            this.personMeetingsTable.RowHeadersVisible = false;
            this.personMeetingsTable.RowTemplate.Height = 25;
            this.personMeetingsTable.Size = new System.Drawing.Size(635, 182);
            this.personMeetingsTable.TabIndex = 0;
            this.personMeetingsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personMeetingsTable_CellContentClick);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.closeBtn.Location = new System.Drawing.Point(867, 409);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(155, 40);
            this.closeBtn.TabIndex = 18;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // deletePersonBtn
            // 
            this.deletePersonBtn.BackColor = System.Drawing.Color.Red;
            this.deletePersonBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.deletePersonBtn.Location = new System.Drawing.Point(867, 228);
            this.deletePersonBtn.Name = "deletePersonBtn";
            this.deletePersonBtn.Size = new System.Drawing.Size(155, 39);
            this.deletePersonBtn.TabIndex = 19;
            this.deletePersonBtn.Text = "Удалить участника";
            this.deletePersonBtn.UseVisualStyleBackColor = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ID";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Секция";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Дата";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Статус участия";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column11
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Column11.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column11.HeaderText = "";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Тематика";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Специальность";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column10
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.Column10.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column10.HeaderText = "";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ViewPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 461);
            this.Controls.Add(this.deletePersonBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.joinMeetingBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.newReportBtn);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1050, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1050, 500);
            this.Name = "ViewPersonForm";
            this.Text = "Участник";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personsReportTable)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personMeetingsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox textRole;
        private TextBox textLastName;
        private TextBox textFirstName;
        private Label label5;
        private Label label1;
        private Label label4;
        private Label label2;
        private TextBox textEmail;
        private TextBox textPhoneNumber;
        private Label label3;
        private Button newReportBtn;
        private GroupBox groupBox1;
        private DataGridView personsReportTable;
        private Button joinMeetingBtn;
        private GroupBox groupBox2;
        private DataGridView personMeetingsTable;
        private Button closeBtn;
        private Button deletePersonBtn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn Column5;
        private DataGridViewButtonColumn Column10;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewButtonColumn Column11;
    }
}