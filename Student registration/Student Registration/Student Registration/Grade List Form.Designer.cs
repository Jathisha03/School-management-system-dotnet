namespace Student_Registration
{
    partial class Grade_List_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grade_List_Form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGradeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGradeGroup = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGradeOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGradeDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnGradeEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnGradeSave = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGradeSearch = new System.Windows.Forms.TextBox();
            this.dgvGrade = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGradeName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGradeGroup);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGradeOrder);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(6, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 176);
            this.groupBox1.TabIndex = 27;
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
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grade Name";
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
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grade Group";
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
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Grade Order";
            // 
            // txtGradeOrder
            // 
            this.txtGradeOrder.Location = new System.Drawing.Point(229, 117);
            this.txtGradeOrder.Name = "txtGradeOrder";
            this.txtGradeOrder.Size = new System.Drawing.Size(205, 32);
            this.txtGradeOrder.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1010, 43);
            this.label1.TabIndex = 28;
            this.label1.Text = "Grade List Form";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGradeDelete
            // 
            this.btnGradeDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGradeDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGradeDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGradeDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGradeDelete.FillColor = System.Drawing.SystemColors.Desktop;
            this.btnGradeDelete.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeDelete.ForeColor = System.Drawing.Color.White;
            this.btnGradeDelete.Location = new System.Drawing.Point(334, 247);
            this.btnGradeDelete.Name = "btnGradeDelete";
            this.btnGradeDelete.Size = new System.Drawing.Size(123, 45);
            this.btnGradeDelete.TabIndex = 36;
            this.btnGradeDelete.Text = "Delete";
            // 
            // btnGradeEdit
            // 
            this.btnGradeEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGradeEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGradeEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGradeEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGradeEdit.FillColor = System.Drawing.SystemColors.Desktop;
            this.btnGradeEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeEdit.ForeColor = System.Drawing.Color.White;
            this.btnGradeEdit.Location = new System.Drawing.Point(173, 247);
            this.btnGradeEdit.Name = "btnGradeEdit";
            this.btnGradeEdit.Size = new System.Drawing.Size(123, 45);
            this.btnGradeEdit.TabIndex = 35;
            this.btnGradeEdit.Text = "Edit";
            // 
            // btnGradeSave
            // 
            this.btnGradeSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGradeSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGradeSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGradeSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGradeSave.FillColor = System.Drawing.SystemColors.Desktop;
            this.btnGradeSave.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeSave.ForeColor = System.Drawing.Color.White;
            this.btnGradeSave.Location = new System.Drawing.Point(1, 247);
            this.btnGradeSave.Name = "btnGradeSave";
            this.btnGradeSave.Size = new System.Drawing.Size(123, 45);
            this.btnGradeSave.TabIndex = 34;
            this.btnGradeSave.Text = "Save";
            this.btnGradeSave.Click += new System.EventHandler(this.btnGradeSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(474, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // txtGradeSearch
            // 
            this.txtGradeSearch.Location = new System.Drawing.Point(535, 63);
            this.txtGradeSearch.Name = "txtGradeSearch";
            this.txtGradeSearch.Size = new System.Drawing.Size(461, 32);
            this.txtGradeSearch.TabIndex = 31;
            // 
            // dgvGrade
            // 
            this.dgvGrade.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrade.Location = new System.Drawing.Point(474, 105);
            this.dgvGrade.Name = "dgvGrade";
            this.dgvGrade.RowHeadersWidth = 51;
            this.dgvGrade.RowTemplate.Height = 24;
            this.dgvGrade.Size = new System.Drawing.Size(522, 187);
            this.dgvGrade.TabIndex = 32;
            // 
            // Grade_List_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1010, 300);
            this.Controls.Add(this.btnGradeDelete);
            this.Controls.Add(this.btnGradeEdit);
            this.Controls.Add(this.btnGradeSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtGradeSearch);
            this.Controls.Add(this.dgvGrade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Grade_List_Form";
            this.Text = "Grade_List_Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGradeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGradeGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGradeOrder;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnGradeDelete;
        private Guna.UI2.WinForms.Guna2Button btnGradeEdit;
        private Guna.UI2.WinForms.Guna2Button btnGradeSave;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtGradeSearch;
        private System.Windows.Forms.DataGridView dgvGrade;
    }
}