
namespace proga1
{
    partial class studentForm
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
            this.Data1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.idSTField = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.GruppaSTField = new System.Windows.Forms.TextBox();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.NameSTField = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Data1
            // 
            this.Data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data1.Location = new System.Drawing.Point(0, 107);
            this.Data1.Name = "Data1";
            this.Data1.Size = new System.Drawing.Size(613, 166);
            this.Data1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.idSTField);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.Data1);
            this.panel1.Controls.Add(this.GruppaSTField);
            this.panel1.Controls.Add(this.SearchField);
            this.panel1.Controls.Add(this.NameSTField);
            this.panel1.Controls.Add(this.SearchLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 370);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(321, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID для удалени и редактирования";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(393, 12);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(136, 32);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Удалить по ID";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // idSTField
            // 
            this.idSTField.Location = new System.Drawing.Point(429, 55);
            this.idSTField.Name = "idSTField";
            this.idSTField.Size = new System.Drawing.Size(100, 20);
            this.idSTField.TabIndex = 12;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(104, 305);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 23);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(604, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(23, 28);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // GruppaSTField
            // 
            this.GruppaSTField.Location = new System.Drawing.Point(104, 71);
            this.GruppaSTField.Name = "GruppaSTField";
            this.GruppaSTField.Size = new System.Drawing.Size(155, 20);
            this.GruppaSTField.TabIndex = 8;
            // 
            // SearchField
            // 
            this.SearchField.Location = new System.Drawing.Point(104, 279);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(509, 20);
            this.SearchField.TabIndex = 7;
            // 
            // NameSTField
            // 
            this.NameSTField.Location = new System.Drawing.Point(104, 48);
            this.NameSTField.Name = "NameSTField";
            this.NameSTField.Size = new System.Drawing.Size(155, 20);
            this.NameSTField.TabIndex = 6;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(37, 286);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(41, 13);
            this.SearchLabel.TabIndex = 5;
            this.SearchLabel.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "GruppaStudent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NameStudent";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(23, 337);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 2;
            this.BackButton.Text = "Hazad";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(61, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 32);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(217, 12);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(147, 32);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Редактировать по ID";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 382);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "studentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.studentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Data1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox GruppaSTField;
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.TextBox NameSTField;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox idSTField;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label3;
    }
}