using System.Windows.Forms;

namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.add_button = new System.Windows.Forms.Button();
            this.subtract_button = new System.Windows.Forms.Button();
            this.multiply_button = new System.Windows.Forms.Button();
            this.divide_button = new System.Windows.Forms.Button();
            this.second_number_tb = new System.Windows.Forms.TextBox();
            this.first_number_tb = new System.Windows.Forms.TextBox();
            this.first_number_label = new System.Windows.Forms.Label();
            this.second_number_label = new System.Windows.Forms.Label();
            this.result_label = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.modulus_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(26, 133);
            this.add_button.Margin = new System.Windows.Forms.Padding(2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(70, 19);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // subtract_button
            // 
            this.subtract_button.Location = new System.Drawing.Point(172, 133);
            this.subtract_button.Margin = new System.Windows.Forms.Padding(2);
            this.subtract_button.Name = "subtract_button";
            this.subtract_button.Size = new System.Drawing.Size(70, 19);
            this.subtract_button.TabIndex = 1;
            this.subtract_button.Text = "Subtract";
            this.subtract_button.UseVisualStyleBackColor = true;
            this.subtract_button.Click += new System.EventHandler(this.subtract_button_Click);
            // 
            // multiply_button
            // 
            this.multiply_button.Location = new System.Drawing.Point(26, 191);
            this.multiply_button.Margin = new System.Windows.Forms.Padding(2);
            this.multiply_button.Name = "multiply_button";
            this.multiply_button.Size = new System.Drawing.Size(70, 19);
            this.multiply_button.TabIndex = 2;
            this.multiply_button.Text = "Multiply";
            this.multiply_button.UseVisualStyleBackColor = true;
            this.multiply_button.Click += new System.EventHandler(this.multiply_button_Click);
            // 
            // divide_button
            // 
            this.divide_button.Location = new System.Drawing.Point(172, 191);
            this.divide_button.Margin = new System.Windows.Forms.Padding(2);
            this.divide_button.Name = "divide_button";
            this.divide_button.Size = new System.Drawing.Size(70, 19);
            this.divide_button.TabIndex = 3;
            this.divide_button.Text = "Divide";
            this.divide_button.UseVisualStyleBackColor = true;
            this.divide_button.Click += new System.EventHandler(this.divide_button_Click);
            // 
            // second_number_tb
            // 
            this.second_number_tb.Location = new System.Drawing.Point(172, 83);
            this.second_number_tb.Margin = new System.Windows.Forms.Padding(2);
            this.second_number_tb.Name = "second_number_tb";
            this.second_number_tb.Size = new System.Drawing.Size(95, 20);
            this.second_number_tb.TabIndex = 4;
            // 
            // first_number_tb
            // 
            this.first_number_tb.Location = new System.Drawing.Point(172, 45);
            this.first_number_tb.Margin = new System.Windows.Forms.Padding(2);
            this.first_number_tb.Name = "first_number_tb";
            this.first_number_tb.Size = new System.Drawing.Size(95, 20);
            this.first_number_tb.TabIndex = 5;
            // 
            // first_number_label
            // 
            this.first_number_label.AutoSize = true;
            this.first_number_label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.first_number_label.Location = new System.Drawing.Point(26, 42);
            this.first_number_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.first_number_label.Name = "first_number_label";
            this.first_number_label.Size = new System.Drawing.Size(102, 21);
            this.first_number_label.TabIndex = 6;
            this.first_number_label.Text = "First Number";
            // 
            // second_number_label
            // 
            this.second_number_label.AutoSize = true;
            this.second_number_label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.second_number_label.Location = new System.Drawing.Point(26, 80);
            this.second_number_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.second_number_label.Name = "second_number_label";
            this.second_number_label.Size = new System.Drawing.Size(123, 21);
            this.second_number_label.TabIndex = 7;
            this.second_number_label.Text = "Second Number";
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.result_label.Location = new System.Drawing.Point(104, 229);
            this.result_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(73, 28);
            this.result_label.TabIndex = 8;
            this.result_label.Text = "Result: ";
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title.Location = new System.Drawing.Point(85, 6);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(137, 37);
            this.title.TabIndex = 9;
            this.title.Text = "Calculator";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modulus_button
            // 
            this.modulus_button.Location = new System.Drawing.Point(92, 162);
            this.modulus_button.Margin = new System.Windows.Forms.Padding(2);
            this.modulus_button.Name = "modulus_button";
            this.modulus_button.Size = new System.Drawing.Size(70, 19);
            this.modulus_button.TabIndex = 10;
            this.modulus_button.Text = "Modulus";
            this.modulus_button.UseVisualStyleBackColor = true;
            this.modulus_button.Click += new System.EventHandler(this.modulus_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 292);
            this.Controls.Add(this.modulus_button);
            this.Controls.Add(this.title);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.second_number_label);
            this.Controls.Add(this.first_number_label);
            this.Controls.Add(this.first_number_tb);
            this.Controls.Add(this.second_number_tb);
            this.Controls.Add(this.divide_button);
            this.Controls.Add(this.multiply_button);
            this.Controls.Add(this.subtract_button);
            this.Controls.Add(this.add_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Button add_button;
        private Button subtract_button;
        private Button multiply_button;
        private Button divide_button;
        private TextBox second_number_tb;
        private TextBox first_number_tb;
        private Label first_number_label;
        private Label second_number_label;
        private Label result_label;
        private Label title;
        private Button modulus_button;
    }
}