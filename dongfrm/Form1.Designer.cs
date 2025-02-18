namespace dongfrm
{
    partial class frm1
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
            this.components = new System.ComponentModel.Container();
            this.lblYourName = new System.Windows.Forms.Label();
            this.lblYearofbirth = new System.Windows.Forms.Label();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtYourName = new System.Windows.Forms.TextBox();
            this.txtYearofBirthday = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYourName
            // 
            this.lblYourName.AutoSize = true;
            this.lblYourName.Location = new System.Drawing.Point(14, 27);
            this.lblYourName.Name = "lblYourName";
            this.lblYourName.Size = new System.Drawing.Size(64, 13);
            this.lblYourName.TabIndex = 0;
            this.lblYourName.Text = "Your name :";
            // 
            // lblYearofbirth
            // 
            this.lblYearofbirth.AutoSize = true;
            this.lblYearofbirth.Location = new System.Drawing.Point(14, 65);
            this.lblYearofbirth.Name = "lblYearofbirth";
            this.lblYearofbirth.Size = new System.Drawing.Size(87, 13);
            this.lblYearofbirth.TabIndex = 2;
            this.lblYearofbirth.Text = "Year of birthday :";
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(36, 110);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 4;
            this.btnshow.Text = "&Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(166, 110);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(70, 23);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(281, 110);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtYourName
            // 
            this.txtYourName.Location = new System.Drawing.Point(100, 27);
            this.txtYourName.Name = "txtYourName";
            this.txtYourName.Size = new System.Drawing.Size(283, 20);
            this.txtYourName.TabIndex = 1;
            this.txtYourName.Leave += new System.EventHandler(this.txtYourName_Leave);
            // 
            // txtYearofBirthday
            // 
            this.txtYearofBirthday.Location = new System.Drawing.Point(100, 62);
            this.txtYearofBirthday.Name = "txtYearofBirthday";
            this.txtYearofBirthday.Size = new System.Drawing.Size(283, 20);
            this.txtYearofBirthday.TabIndex = 3;
            this.txtYearofBirthday.TextChanged += new System.EventHandler(this.txtYearofBirthday_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 158);
            this.Controls.Add(this.txtYearofBirthday);
            this.Controls.Add(this.txtYourName);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.lblYearofbirth);
            this.Controls.Add(this.lblYourName);
            this.Name = "frm1";
            this.Text = "NguyenThiHuyen_2033210481";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYourName;
        private System.Windows.Forms.Label lblYearofbirth;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtYourName;
        private System.Windows.Forms.TextBox txtYearofBirthday;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

