using System.Data.SqlClient;

namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        //@"calea"


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
            this.listBox_Univ = new System.Windows.Forms.ListBox();
            this.listBox_Fac = new System.Windows.Forms.ListBox();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.textBox_CodeUniv = new System.Windows.Forms.TextBox();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Univ
            // 
            this.listBox_Univ.FormattingEnabled = true;
            this.listBox_Univ.Location = new System.Drawing.Point(142, 105);
            this.listBox_Univ.Name = "listBox_Univ";
            this.listBox_Univ.Size = new System.Drawing.Size(120, 95);
            this.listBox_Univ.TabIndex = 0;
            this.listBox_Univ.SelectedIndexChanged += new System.EventHandler(this.listBox_Univ_SelectedIndexChanged);
            // 
            // listBox_Fac
            // 
            this.listBox_Fac.FormattingEnabled = true;
            this.listBox_Fac.Location = new System.Drawing.Point(470, 105);
            this.listBox_Fac.Name = "listBox_Fac";
            this.listBox_Fac.Size = new System.Drawing.Size(120, 95);
            this.listBox_Fac.TabIndex = 1;
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(470, 258);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(100, 20);
            this.textBox_City.TabIndex = 2;
            this.textBox_City.TextChanged += new System.EventHandler(this.textBox_City_TextChanged);
            // 
            // textBox_CodeUniv
            // 
            this.textBox_CodeUniv.Location = new System.Drawing.Point(470, 319);
            this.textBox_CodeUniv.Name = "textBox_CodeUniv";
            this.textBox_CodeUniv.Size = new System.Drawing.Size(100, 20);
            this.textBox_CodeUniv.TabIndex = 3;
            // 
            // button_Edit
            // 
            this.button_Edit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Edit.Location = new System.Drawing.Point(142, 254);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Edit.TabIndex = 4;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Edit Facultati";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.textBox_CodeUniv);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.listBox_Fac);
            this.Controls.Add(this.listBox_Univ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Univ;
        private System.Windows.Forms.ListBox listBox_Fac;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.TextBox textBox_CodeUniv;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

