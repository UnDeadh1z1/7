
namespace proga1
{
    partial class rukForm
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
            this.searchButton = new System.Windows.Forms.Button();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.Data2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.idField = new System.Windows.Forms.TextBox();
            this.Field1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Data2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(92, 267);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 23);
            this.searchButton.TabIndex = 56;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // SearchField
            // 
            this.SearchField.Location = new System.Drawing.Point(92, 241);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(440, 20);
            this.SearchField.TabIndex = 55;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(25, 248);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(41, 13);
            this.SearchLabel.TabIndex = 54;
            this.SearchLabel.Text = "Search";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(26, 299);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 53;
            this.BackButton.Text = "Hazad";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Data2
            // 
            this.Data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data2.Location = new System.Drawing.Point(12, 98);
            this.Data2.Name = "Data2";
            this.Data2.Size = new System.Drawing.Size(520, 135);
            this.Data2.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(324, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 36);
            this.label3.TabIndex = 51;
            this.label3.Text = "ID для удалени и редактирования";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(396, 13);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(136, 32);
            this.deleteButton.TabIndex = 50;
            this.deleteButton.Text = "Удалить по ID";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(432, 56);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(100, 20);
            this.idField.TabIndex = 49;
            // 
            // Field1
            // 
            this.Field1.Location = new System.Drawing.Point(122, 51);
            this.Field1.Name = "Field1";
            this.Field1.Size = new System.Drawing.Size(155, 20);
            this.Field1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Имя Руководителя";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(220, 13);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(147, 32);
            this.editButton.TabIndex = 46;
            this.editButton.Text = "Редактировать по ID";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(563, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(23, 28);
            this.CloseButton.TabIndex = 45;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 326);
            this.panel1.TabIndex = 57;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(80, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 32);
            this.addButton.TabIndex = 31;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // rukForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 326);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.SearchField);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Data2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.idField);
            this.Controls.Add(this.Field1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rukForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rukForm";
            this.Load += new System.EventHandler(this.rukForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridView Data2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.TextBox Field1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addButton;
    }
}