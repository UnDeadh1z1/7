
namespace proga1
{
    partial class mainForm
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
            this.AuthButton = new System.Windows.Forms.Button();
            this.RukovoTable = new System.Windows.Forms.Button();
            this.OtchetButton = new System.Windows.Forms.Button();
            this.SvyazTable = new System.Windows.Forms.Button();
            this.RabotiTable = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.StudentButton = new System.Windows.Forms.Button();
            this.GruppaTable = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AuthButton);
            this.panel1.Controls.Add(this.RukovoTable);
            this.panel1.Controls.Add(this.OtchetButton);
            this.panel1.Controls.Add(this.SvyazTable);
            this.panel1.Controls.Add(this.RabotiTable);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.StudentButton);
            this.panel1.Controls.Add(this.GruppaTable);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 341);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown_1);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(57, 285);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(110, 44);
            this.AuthButton.TabIndex = 19;
            this.AuthButton.Text = "К автоизации";
            this.AuthButton.UseVisualStyleBackColor = true;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // RukovoTable
            // 
            this.RukovoTable.Location = new System.Drawing.Point(162, 171);
            this.RukovoTable.Name = "RukovoTable";
            this.RukovoTable.Size = new System.Drawing.Size(75, 55);
            this.RukovoTable.TabIndex = 17;
            this.RukovoTable.Text = "Руководители";
            this.RukovoTable.UseVisualStyleBackColor = true;
            this.RukovoTable.Click += new System.EventHandler(this.RukovoTable_Click);
            // 
            // OtchetButton
            // 
            this.OtchetButton.Location = new System.Drawing.Point(262, 52);
            this.OtchetButton.Name = "OtchetButton";
            this.OtchetButton.Size = new System.Drawing.Size(118, 80);
            this.OtchetButton.TabIndex = 16;
            this.OtchetButton.Text = "Отчет по работе";
            this.OtchetButton.UseVisualStyleBackColor = true;
            this.OtchetButton.Click += new System.EventHandler(this.OtchetButton_Click);
            // 
            // SvyazTable
            // 
            this.SvyazTable.Location = new System.Drawing.Point(57, 171);
            this.SvyazTable.Name = "SvyazTable";
            this.SvyazTable.Size = new System.Drawing.Size(75, 55);
            this.SvyazTable.TabIndex = 15;
            this.SvyazTable.Text = "Работы и руководители";
            this.SvyazTable.UseVisualStyleBackColor = true;
            this.SvyazTable.Click += new System.EventHandler(this.SvyazTable_Click);
            // 
            // RabotiTable
            // 
            this.RabotiTable.Location = new System.Drawing.Point(162, 110);
            this.RabotiTable.Name = "RabotiTable";
            this.RabotiTable.Size = new System.Drawing.Size(75, 55);
            this.RabotiTable.TabIndex = 14;
            this.RabotiTable.Text = "Работы";
            this.RabotiTable.UseVisualStyleBackColor = true;
            this.RabotiTable.Click += new System.EventHandler(this.RabotiTable_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 55);
            this.button3.TabIndex = 13;
            this.button3.Text = "Область исследования";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // StudentButton
            // 
            this.StudentButton.Location = new System.Drawing.Point(162, 52);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(75, 52);
            this.StudentButton.TabIndex = 12;
            this.StudentButton.Text = "Студенты";
            this.StudentButton.UseVisualStyleBackColor = true;
            this.StudentButton.Click += new System.EventHandler(this.StudentButton_Click);
            // 
            // GruppaTable
            // 
            this.GruppaTable.Location = new System.Drawing.Point(57, 52);
            this.GruppaTable.Name = "GruppaTable";
            this.GruppaTable.Size = new System.Drawing.Size(75, 52);
            this.GruppaTable.TabIndex = 11;
            this.GruppaTable.Text = "Группа";
            this.GruppaTable.UseVisualStyleBackColor = true;
            this.GruppaTable.Click += new System.EventHandler(this.GruppaTable_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(353, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(27, 28);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 341);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.Button RukovoTable;
        private System.Windows.Forms.Button OtchetButton;
        private System.Windows.Forms.Button SvyazTable;
        private System.Windows.Forms.Button RabotiTable;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.Button GruppaTable;
    }
}