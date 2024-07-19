namespace Student_Registration
{
    partial class Subject_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subject_List));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGradeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGradeGroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGradeOrder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSubjectDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubjectEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubjectSave = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGradeSearch = new System.Windows.Forms.TextBox();
            this.dgvSubject = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1016, 43);
            this.label1.TabIndex = 29;
            this.label1.Text = "Subject List Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGradeName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGradeGroup);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGradeOrder);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(6, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 204);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject Name";
            // 
            // txtGradeName
            // 
            this.txtGradeName.Location = new System.Drawing.Point(229, 42);
            this.txtGradeName.Name = "txtGradeName";
            this.txtGradeName.Size = new System.Drawing.Size(205, 32);
            this.txtGradeName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject Index";
            // 
            // txtGradeGroup
            // 
            this.txtGradeGroup.Location = new System.Drawing.Point(229, 79);
            this.txtGradeGroup.Name = "txtGradeGroup";
            this.txtGradeGroup.Size = new System.Drawing.Size(205, 32);
            this.txtGradeGroup.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(7, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Subject Number";
            // 
            // txtGradeOrder
            // 
            this.txtGradeOrder.Location = new System.Drawing.Point(229, 117);
            this.txtGradeOrder.Name = "txtGradeOrder";
            this.txtGradeOrder.Size = new System.Drawing.Size(205, 32);
            this.txtGradeOrder.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(7, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Subject Order";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 32);
            this.textBox1.TabIndex = 8;
            // 
            // btnSubjectDelete
            // 
            this.btnSubjectDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubjectDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubjectDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubjectDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubjectDelete.FillColor = System.Drawing.SystemColors.Desktop;
            this.btnSubjectDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectDelete.ForeColor = System.Drawing.Color.White;
            this.btnSubjectDelete.Location = new System.Drawing.Point(338, 256);
            this.btnSubjectDelete.Name = "btnSubjectDelete";
            this.btnSubjectDelete.Size = new System.Drawing.Size(123, 45);
            this.btnSubjectDelete.TabIndex = 39;
            this.btnSubjectDelete.Text = "Delete";
            // 
            // btnSubjectEdit
            // 
            this.btnSubjectEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubjectEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubjectEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubjectEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubjectEdit.FillColor = System.Drawing.SystemColors.Desktop;
            this.btnSubjectEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectEdit.ForeColor = System.Drawing.Color.White;
            this.btnSubjectEdit.Location = new System.Drawing.Point(180, 256);
            this.btnSubjectEdit.Name = "btnSubjectEdit";
            this.btnSubjectEdit.Size = new System.Drawing.Size(123, 45);
            this.btnSubjectEdit.TabIndex = 38;
            this.btnSubjectEdit.Text = "Edit";
            // 
            // btnSubjectSave
            // 
            this.btnSubjectSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubjectSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubjectSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubjectSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubjectSave.FillColor = System.Drawing.SystemColors.Desktop;
            this.btnSubjectSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubjectSave.ForeColor = System.Drawing.Color.White;
            this.btnSubjectSave.Location = new System.Drawing.Point(5, 256);
            this.btnSubjectSave.Name = "btnSubjectSave";
            this.btnSubjectSave.Size = new System.Drawing.Size(123, 45);
            this.btnSubjectSave.TabIndex = 37;
            this.btnSubjectSave.Text = "Save";
            this.btnSubjectSave.Click += new System.EventHandler(this.btnSubjectSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(489, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // txtGradeSearch
            // 
            this.txtGradeSearch.Location = new System.Drawing.Point(550, 46);
            this.txtGradeSearch.Name = "txtGradeSearch";
            this.txtGradeSearch.Size = new System.Drawing.Size(461, 32);
            this.txtGradeSearch.TabIndex = 40;
            // 
            // dgvSubject
            // 
            this.dgvSubject.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubject.Location = new System.Drawing.Point(489, 88);
            this.dgvSubject.Name = "dgvSubject";
            this.dgvSubject.RowHeadersWidth = 51;
            this.dgvSubject.RowTemplate.Height = 24;
            this.dgvSubject.Size = new System.Drawing.Size(522, 213);
            this.dgvSubject.TabIndex = 41;
            // 
            // Subject_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1016, 312);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtGradeSearch);
            this.Controls.Add(this.dgvSubject);
            this.Controls.Add(this.btnSubjectDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubjectEdit);
            this.Controls.Add(this.btnSubjectSave);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Subject_List";
            this.Text = "Subject_List";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGradeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGradeGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGradeOrder;
        private Guna.UI2.WinForms.Guna2Button btnSubjectDelete;
        private Guna.UI2.WinForms.Guna2Button btnSubjectEdit;
        private Guna.UI2.WinForms.Guna2Button btnSubjectSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtGradeSearch;
        private System.Windows.Forms.DataGridView dgvSubject;
    }
}