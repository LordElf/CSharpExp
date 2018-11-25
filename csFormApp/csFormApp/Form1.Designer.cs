namespace csFormApp
{
    partial class Fcontacts
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
            this.bLogin = new System.Windows.Forms.Button();
            this.BRegister = new System.Windows.Forms.Button();
            this.userT = new System.Windows.Forms.TextBox();
            this.passwordT = new System.Windows.Forms.TextBox();
            this.userL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.assureL = new System.Windows.Forms.Label();
            this.passwordAsT = new System.Windows.Forms.TextBox();
            this.BConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(174, 352);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(128, 39);
            this.bLogin.TabIndex = 0;
            this.bLogin.Text = "login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // BRegister
            // 
            this.BRegister.Location = new System.Drawing.Point(477, 352);
            this.BRegister.Name = "BRegister";
            this.BRegister.Size = new System.Drawing.Size(121, 39);
            this.BRegister.TabIndex = 1;
            this.BRegister.Text = "register";
            this.BRegister.UseVisualStyleBackColor = true;
            this.BRegister.Click += new System.EventHandler(this.button2_Click);
            // 
            // userT
            // 
            this.userT.Location = new System.Drawing.Point(205, 97);
            this.userT.Name = "userT";
            this.userT.Size = new System.Drawing.Size(285, 25);
            this.userT.TabIndex = 0;
            // 
            // passwordT
            // 
            this.passwordT.Location = new System.Drawing.Point(205, 166);
            this.passwordT.Name = "passwordT";
            this.passwordT.Size = new System.Drawing.Size(285, 25);
            this.passwordT.TabIndex = 2;
            this.passwordT.UseSystemPasswordChar = true;
            // 
            // userL
            // 
            this.userL.AutoSize = true;
            this.userL.Location = new System.Drawing.Point(88, 100);
            this.userL.Name = "userL";
            this.userL.Size = new System.Drawing.Size(39, 15);
            this.userL.TabIndex = 3;
            this.userL.Text = "user";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // assureL
            // 
            this.assureL.AutoSize = true;
            this.assureL.Location = new System.Drawing.Point(17, 243);
            this.assureL.Name = "assureL";
            this.assureL.Size = new System.Drawing.Size(167, 15);
            this.assureL.TabIndex = 5;
            this.assureL.Text = "assure your password";
            this.assureL.Visible = false;
            // 
            // passwordAsT
            // 
            this.passwordAsT.Location = new System.Drawing.Point(205, 240);
            this.passwordAsT.Name = "passwordAsT";
            this.passwordAsT.Size = new System.Drawing.Size(285, 25);
            this.passwordAsT.TabIndex = 6;
            this.passwordAsT.UseSystemPasswordChar = true;
            this.passwordAsT.Visible = false;
            // 
            // BConfirm
            // 
            this.BConfirm.Location = new System.Drawing.Point(612, 211);
            this.BConfirm.Name = "BConfirm";
            this.BConfirm.Size = new System.Drawing.Size(75, 23);
            this.BConfirm.TabIndex = 7;
            this.BConfirm.Text = "Confirm";
            this.BConfirm.UseVisualStyleBackColor = true;
            this.BConfirm.Visible = false;
            // 
            // Fcontacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 436);
            this.Controls.Add(this.BConfirm);
            this.Controls.Add(this.passwordAsT);
            this.Controls.Add(this.assureL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userL);
            this.Controls.Add(this.passwordT);
            this.Controls.Add(this.userT);
            this.Controls.Add(this.BRegister);
            this.Controls.Add(this.bLogin);
            this.Name = "Fcontacts";
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button BRegister;
        private System.Windows.Forms.TextBox userT;
        private System.Windows.Forms.TextBox passwordT;
        private System.Windows.Forms.Label userL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label assureL;
        private System.Windows.Forms.TextBox passwordAsT;
        private System.Windows.Forms.Button BConfirm;
    }
}

