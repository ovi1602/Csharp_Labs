namespace Lab3
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_AddCity = new System.Windows.Forms.TextBox();
            this.textBox_DeleteUni = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox_AddUniv = new System.Windows.Forms.TextBox();
            this.textBox_AddCode = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.newNameBox = new System.Windows.Forms.TextBox();
            this.newCityBox = new System.Windows.Forms.TextBox();
            this.newCodeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Delete";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Update";
            // 
            // textBox_AddCity
            // 
            this.textBox_AddCity.Location = new System.Drawing.Point(175, 100);
            this.textBox_AddCity.Name = "textBox_AddCity";
            this.textBox_AddCity.Size = new System.Drawing.Size(100, 20);
            this.textBox_AddCity.TabIndex = 3;
            this.textBox_AddCity.Text = "City";
            // 
            // textBox_DeleteUni
            // 
            this.textBox_DeleteUni.Location = new System.Drawing.Point(175, 206);
            this.textBox_DeleteUni.Name = "textBox_DeleteUni";
            this.textBox_DeleteUni.Size = new System.Drawing.Size(100, 20);
            this.textBox_DeleteUni.TabIndex = 4;
            this.textBox_DeleteUni.Text = "Uni name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(175, 309);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Uni Name to change";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_AddUniv
            // 
            this.textBox_AddUniv.Location = new System.Drawing.Point(314, 100);
            this.textBox_AddUniv.Name = "textBox_AddUniv";
            this.textBox_AddUniv.Size = new System.Drawing.Size(100, 20);
            this.textBox_AddUniv.TabIndex = 6;
            this.textBox_AddUniv.Text = "University";
            // 
            // textBox_AddCode
            // 
            this.textBox_AddCode.Location = new System.Drawing.Point(451, 100);
            this.textBox_AddCode.Name = "textBox_AddCode";
            this.textBox_AddCode.Size = new System.Drawing.Size(100, 20);
            this.textBox_AddCode.TabIndex = 7;
            this.textBox_AddCode.Text = "Code";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(175, 154);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 8;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newNameBox
            // 
            this.newNameBox.Location = new System.Drawing.Point(175, 335);
            this.newNameBox.Name = "newNameBox";
            this.newNameBox.Size = new System.Drawing.Size(100, 20);
            this.newNameBox.TabIndex = 11;
            this.newNameBox.Text = "New name";
            this.newNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // newCityBox
            // 
            this.newCityBox.Location = new System.Drawing.Point(314, 335);
            this.newCityBox.Name = "newCityBox";
            this.newCityBox.Size = new System.Drawing.Size(100, 20);
            this.newCityBox.TabIndex = 12;
            this.newCityBox.Text = "New City";
            // 
            // newCodeBox
            // 
            this.newCodeBox.Location = new System.Drawing.Point(451, 335);
            this.newCodeBox.Name = "newCodeBox";
            this.newCodeBox.Size = new System.Drawing.Size(100, 20);
            this.newCodeBox.TabIndex = 13;
            this.newCodeBox.Text = "New code";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newCodeBox);
            this.Controls.Add(this.newCityBox);
            this.Controls.Add(this.newNameBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_AddCode);
            this.Controls.Add(this.textBox_AddUniv);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox_DeleteUni);
            this.Controls.Add(this.textBox_AddCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.FormClosed += Form2_FormClosed;

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_AddCity;
        private System.Windows.Forms.TextBox textBox_DeleteUni;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox_AddUniv;
        private System.Windows.Forms.TextBox textBox_AddCode;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox newNameBox;
        private System.Windows.Forms.TextBox newCityBox;
        private System.Windows.Forms.TextBox newCodeBox;
    }
}