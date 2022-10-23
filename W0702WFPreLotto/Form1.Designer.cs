namespace W0702WFPreLotto
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
            this.Num1 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.Label();
            this.Num3 = new System.Windows.Forms.Label();
            this.Num4 = new System.Windows.Forms.Label();
            this.Num5 = new System.Windows.Forms.Label();
            this.Num6 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.BackColor = System.Drawing.SystemColors.Info;
            this.Num1.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num1.Location = new System.Drawing.Point(13, 13);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(138, 145);
            this.Num1.TabIndex = 0;
            this.Num1.Text = "label1";
            this.Num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Num2
            // 
            this.Num2.BackColor = System.Drawing.SystemColors.Info;
            this.Num2.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num2.Location = new System.Drawing.Point(180, 13);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(138, 145);
            this.Num2.TabIndex = 0;
            this.Num2.Text = "label1";
            this.Num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Num3
            // 
            this.Num3.BackColor = System.Drawing.SystemColors.Info;
            this.Num3.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num3.Location = new System.Drawing.Point(347, 13);
            this.Num3.Name = "Num3";
            this.Num3.Size = new System.Drawing.Size(138, 145);
            this.Num3.TabIndex = 0;
            this.Num3.Text = "label1";
            this.Num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Num4
            // 
            this.Num4.BackColor = System.Drawing.SystemColors.Info;
            this.Num4.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num4.Location = new System.Drawing.Point(514, 13);
            this.Num4.Name = "Num4";
            this.Num4.Size = new System.Drawing.Size(138, 145);
            this.Num4.TabIndex = 0;
            this.Num4.Text = "label1";
            this.Num4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Num5
            // 
            this.Num5.BackColor = System.Drawing.SystemColors.Info;
            this.Num5.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num5.Location = new System.Drawing.Point(681, 13);
            this.Num5.Name = "Num5";
            this.Num5.Size = new System.Drawing.Size(138, 145);
            this.Num5.TabIndex = 0;
            this.Num5.Text = "label1";
            this.Num5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Num6
            // 
            this.Num6.BackColor = System.Drawing.SystemColors.Info;
            this.Num6.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Num6.Location = new System.Drawing.Point(848, 13);
            this.Num6.Name = "Num6";
            this.Num6.Size = new System.Drawing.Size(138, 145);
            this.Num6.TabIndex = 0;
            this.Num6.Text = "label1";
            this.Num6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(12, 196);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(974, 44);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "번호 생성";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.OnGenerate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 257);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.Num6);
            this.Controls.Add(this.Num5);
            this.Controls.Add(this.Num4);
            this.Controls.Add(this.Num3);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Name = "Form1";
            this.Text = "로또";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Num1;
        private System.Windows.Forms.Label Num2;
        private System.Windows.Forms.Label Num3;
        private System.Windows.Forms.Label Num4;
        private System.Windows.Forms.Label Num5;
        private System.Windows.Forms.Label Num6;
        private System.Windows.Forms.Button btnGenerate;
    }
}