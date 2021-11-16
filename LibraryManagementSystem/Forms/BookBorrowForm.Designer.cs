
namespace LibraryManagementSystem.Forms
{
    partial class BookBorrowForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.tbStudentId = new System.Windows.Forms.TextBox();
            this.tbBookId = new System.Windows.Forms.TextBox();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(57, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.book;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(184, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(66, 62);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(256, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrow Book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.dtpReturnDate);
            this.groupBoxInput.Controls.Add(this.dtpBorrowDate);
            this.groupBoxInput.Controls.Add(this.btnSubmit);
            this.groupBoxInput.Controls.Add(this.lblReturnDate);
            this.groupBoxInput.Controls.Add(this.lblBorrowDate);
            this.groupBoxInput.Controls.Add(this.lblStudentId);
            this.groupBoxInput.Controls.Add(this.lblBookId);
            this.groupBoxInput.Controls.Add(this.tbStudentId);
            this.groupBoxInput.Controls.Add(this.tbBookId);
            this.groupBoxInput.Location = new System.Drawing.Point(57, 141);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(687, 262);
            this.groupBoxInput.TabIndex = 2;
            this.groupBoxInput.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSubmit.Location = new System.Drawing.Point(262, 188);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(164, 62);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Borrow Book";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStudentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblStudentId.Location = new System.Drawing.Point(138, 61);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(91, 20);
            this.lblStudentId.TabIndex = 0;
            this.lblStudentId.Text = "Student ID:";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBookId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBookId.Location = new System.Drawing.Point(138, 22);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(71, 20);
            this.lblBookId.TabIndex = 0;
            this.lblBookId.Text = "Book ID:";
            // 
            // tbStudentId
            // 
            this.tbStudentId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbStudentId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbStudentId.Location = new System.Drawing.Point(250, 58);
            this.tbStudentId.Name = "tbStudentId";
            this.tbStudentId.Size = new System.Drawing.Size(264, 26);
            this.tbStudentId.TabIndex = 0;
            // 
            // tbBookId
            // 
            this.tbBookId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbBookId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbBookId.Location = new System.Drawing.Point(250, 19);
            this.tbBookId.Name = "tbBookId";
            this.tbBookId.Size = new System.Drawing.Size(264, 26);
            this.tbBookId.TabIndex = 0;
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBorrowDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBorrowDate.Location = new System.Drawing.Point(138, 99);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(102, 20);
            this.lblBorrowDate.TabIndex = 0;
            this.lblBorrowDate.Text = "Borrow Date:";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReturnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblReturnDate.Location = new System.Drawing.Point(138, 143);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(101, 20);
            this.lblReturnDate.TabIndex = 0;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpBorrowDate.Location = new System.Drawing.Point(250, 99);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(264, 26);
            this.dtpBorrowDate.TabIndex = 2;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpReturnDate.Location = new System.Drawing.Point(250, 141);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(264, 26);
            this.dtpReturnDate.TabIndex = 2;
            // 
            // BookBorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxInput);
            this.Name = "BookBorrowForm";
            this.Text = "BookBorrowForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox tbStudentId;
        private System.Windows.Forms.TextBox tbBookId;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Label lblReturnDate;
    }
}