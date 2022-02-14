
namespace proga1
{
    partial class rabForm
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
            this.Field5 = new System.Windows.Forms.TextBox();
            this.Field4 = new System.Windows.Forms.TextBox();
            this.Field3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.idField = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Data2 = new System.Windows.Forms.DataGridView();
            this.Field2 = new System.Windows.Forms.TextBox();
            this.SearchField = new System.Windows.Forms.TextBox();
            this.Field1 = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Field5);
            this.panel1.Controls.Add(this.Field4);
            this.panel1.Controls.Add(this.Field3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.idField);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.Data2);
            this.panel1.Controls.Add(this.Field2);
            this.panel1.Controls.Add(this.SearchField);
            this.panel1.Controls.Add(this.Field1);
            this.panel1.Controls.Add(this.SearchLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 437);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Field5
            // 
            this.Field5.Location = new System.Drawing.Point(126, 143);
            this.Field5.Name = "Field5";
            this.Field5.Size = new System.Drawing.Size(153, 20);
            this.Field5.TabIndex = 20;
            // 
            // Field4
            // 
            this.Field4.Location = new System.Drawing.Point(126, 121);
            this.Field4.Name = "Field4";
            this.Field4.Size = new System.Drawing.Size(153, 20);
            this.Field4.TabIndex = 19;
            // 
            // Field3
            // 
            this.Field3.Location = new System.Drawing.Point(126, 96);
            this.Field3.Name = "Field3";
            this.Field3.Size = new System.Drawing.Size(153, 20);
            this.Field3.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID_Студента";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID_Области";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Дата_сдачи_работы";
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
            // idField
            // 
            this.idField.Location = new System.Drawing.Point(429, 55);
            this.idField.Name = "idField";
            this.idField.Size = new System.Drawing.Size(100, 20);
            this.idField.TabIndex = 12;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(104, 376);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 23);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(606, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(23, 28);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Data2
            // 
            this.Data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data2.Location = new System.Drawing.Point(0, 168);
            this.Data2.Name = "Data2";
            this.Data2.Size = new System.Drawing.Size(613, 166);
            this.Data2.TabIndex = 0;
            // 
            // Field2
            // 
            this.Field2.Location = new System.Drawing.Point(126, 72);
            this.Field2.Name = "Field2";
            this.Field2.Size = new System.Drawing.Size(153, 20);
            this.Field2.TabIndex = 8;
            // 
            // SearchField
            // 
            this.SearchField.Location = new System.Drawing.Point(104, 350);
            this.SearchField.Name = "SearchField";
            this.SearchField.Size = new System.Drawing.Size(509, 20);
            this.SearchField.TabIndex = 7;
            // 
            // Field1
            // 
            this.Field1.Location = new System.Drawing.Point(126, 49);
            this.Field1.Name = "Field1";
            this.Field1.Size = new System.Drawing.Size(153, 20);
            this.Field1.TabIndex = 6;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(37, 357);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(41, 13);
            this.SearchLabel.TabIndex = 5;
            this.SearchLabel.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата_начала_работы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название_работы";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(25, 408);
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
            // rabForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 437);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rabForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rabForm";
            this.Load += new System.EventHandler(this.rabForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox idField;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridView Data2;
        private System.Windows.Forms.TextBox Field2;
        private System.Windows.Forms.TextBox SearchField;
        private System.Windows.Forms.TextBox Field1;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox Field5;
        private System.Windows.Forms.TextBox Field4;
        private System.Windows.Forms.TextBox Field3;
    }
}