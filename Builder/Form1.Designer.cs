namespace Builder
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
            this.label1 = new System.Windows.Forms.Label();
            this.IPhoneBtn = new System.Windows.Forms.Button();
            this.AndroidBtn = new System.Windows.Forms.Button();
            this.BuildPartiallyBtn = new System.Windows.Forms.Button();
            this.BuildFullBtn = new System.Windows.Forms.Button();
            this.lblPhoneInfo = new System.Windows.Forms.Label();
            this.zLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите тип телефона";
            // 
            // IPhoneBtn
            // 
            this.IPhoneBtn.Location = new System.Drawing.Point(186, 76);
            this.IPhoneBtn.Name = "IPhoneBtn";
            this.IPhoneBtn.Size = new System.Drawing.Size(132, 42);
            this.IPhoneBtn.TabIndex = 1;
            this.IPhoneBtn.Text = "IPhone";
            this.IPhoneBtn.UseVisualStyleBackColor = true;
            this.IPhoneBtn.Click += new System.EventHandler(this.IPhoneBtn_Click);
            // 
            // AndroidBtn
            // 
            this.AndroidBtn.Location = new System.Drawing.Point(417, 76);
            this.AndroidBtn.Name = "AndroidBtn";
            this.AndroidBtn.Size = new System.Drawing.Size(132, 42);
            this.AndroidBtn.TabIndex = 2;
            this.AndroidBtn.Text = "Android";
            this.AndroidBtn.UseVisualStyleBackColor = true;
            this.AndroidBtn.Click += new System.EventHandler(this.AndroidBtn_Click);
            // 
            // BuildPartiallyBtn
            // 
            this.BuildPartiallyBtn.Location = new System.Drawing.Point(204, 217);
            this.BuildPartiallyBtn.Name = "BuildPartiallyBtn";
            this.BuildPartiallyBtn.Size = new System.Drawing.Size(114, 70);
            this.BuildPartiallyBtn.TabIndex = 3;
            this.BuildPartiallyBtn.Text = "Собрать только корпус и дисплей";
            this.BuildPartiallyBtn.UseVisualStyleBackColor = true;
            this.BuildPartiallyBtn.Click += new System.EventHandler(this.BuildPartiallyBtn_Click);
            // 
            // BuildFullBtn
            // 
            this.BuildFullBtn.Location = new System.Drawing.Point(425, 217);
            this.BuildFullBtn.Name = "BuildFullBtn";
            this.BuildFullBtn.Size = new System.Drawing.Size(115, 70);
            this.BuildFullBtn.TabIndex = 4;
            this.BuildFullBtn.Text = "Собрать целый телефон";
            this.BuildFullBtn.UseVisualStyleBackColor = true;
            this.BuildFullBtn.Click += new System.EventHandler(this.BuildFullBtn_Click);
            // 
            // lblPhoneInfo
            // 
            this.lblPhoneInfo.AutoSize = true;
            this.lblPhoneInfo.Location = new System.Drawing.Point(240, 330);
            this.lblPhoneInfo.Name = "lblPhoneInfo";
            this.lblPhoneInfo.Size = new System.Drawing.Size(0, 16);
            this.lblPhoneInfo.TabIndex = 5;
            // 
            // zLabel
            // 
            this.zLabel.AutoSize = true;
            this.zLabel.Location = new System.Drawing.Point(284, 162);
            this.zLabel.Name = "zLabel";
            this.zLabel.Size = new System.Drawing.Size(0, 16);
            this.zLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zLabel);
            this.Controls.Add(this.lblPhoneInfo);
            this.Controls.Add(this.BuildFullBtn);
            this.Controls.Add(this.BuildPartiallyBtn);
            this.Controls.Add(this.AndroidBtn);
            this.Controls.Add(this.IPhoneBtn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IPhoneBtn;
        private System.Windows.Forms.Button AndroidBtn;
        private System.Windows.Forms.Button BuildPartiallyBtn;
        private System.Windows.Forms.Button BuildFullBtn;
        private System.Windows.Forms.Label lblPhoneInfo;
        private System.Windows.Forms.Label zLabel;
    }
}

