namespace Ass
{
    partial class Form1
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
            this.newcustomerbttn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customer_list_button = new System.Windows.Forms.Button();
            this.Hire_costume_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newcustomerbttn
            // 
            this.newcustomerbttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newcustomerbttn.Location = new System.Drawing.Point(169, 98);
            this.newcustomerbttn.Name = "newcustomerbttn";
            this.newcustomerbttn.Size = new System.Drawing.Size(143, 88);
            this.newcustomerbttn.TabIndex = 0;
            this.newcustomerbttn.Text = "Register New Customer";
            this.newcustomerbttn.UseVisualStyleBackColor = true;
            this.newcustomerbttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(317, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 88);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search Customer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // customer_list_button
            // 
            this.customer_list_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_list_button.Location = new System.Drawing.Point(318, 98);
            this.customer_list_button.Name = "customer_list_button";
            this.customer_list_button.Size = new System.Drawing.Size(137, 88);
            this.customer_list_button.TabIndex = 2;
            this.customer_list_button.Text = "View Customer List";
            this.customer_list_button.UseVisualStyleBackColor = true;
            // 
            // Hire_costume_button
            // 
            this.Hire_costume_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hire_costume_button.Location = new System.Drawing.Point(169, 189);
            this.Hire_costume_button.Name = "Hire_costume_button";
            this.Hire_costume_button.Size = new System.Drawing.Size(143, 93);
            this.Hire_costume_button.TabIndex = 3;
            this.Hire_costume_button.Text = "Hire Costume";
            this.Hire_costume_button.UseVisualStyleBackColor = true;
            this.Hire_costume_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(461, 192);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(140, 90);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "THE COSTUME HIRE MANAGEMENT SYSTEM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.Hire_costume_button);
            this.Controls.Add(this.customer_list_button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.newcustomerbttn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newcustomerbttn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button customer_list_button;
        private System.Windows.Forms.Button Hire_costume_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label1;
    }
}

