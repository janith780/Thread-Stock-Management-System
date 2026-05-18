namespace Thread
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.lgtxtusername = new System.Windows.Forms.Label();
            this.lgtxtpassword = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtenterpw = new System.Windows.Forms.TextBox();
            this.btnloginhome = new System.Windows.Forms.Button();
            this.btnregisterform = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lgtxtusername
            // 
            this.lgtxtusername.AutoSize = true;
            this.lgtxtusername.BackColor = System.Drawing.Color.Transparent;
            this.lgtxtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgtxtusername.Location = new System.Drawing.Point(206, 91);
            this.lgtxtusername.Name = "lgtxtusername";
            this.lgtxtusername.Size = new System.Drawing.Size(188, 20);
            this.lgtxtusername.TabIndex = 0;
            this.lgtxtusername.Text = "Enter Your  Username";
            this.lgtxtusername.Click += new System.EventHandler(this.lgtxtusername_Click);
            // 
            // lgtxtpassword
            // 
            this.lgtxtpassword.AutoSize = true;
            this.lgtxtpassword.BackColor = System.Drawing.Color.Transparent;
            this.lgtxtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgtxtpassword.Location = new System.Drawing.Point(206, 149);
            this.lgtxtpassword.Name = "lgtxtpassword";
            this.lgtxtpassword.Size = new System.Drawing.Size(178, 20);
            this.lgtxtpassword.TabIndex = 1;
            this.lgtxtpassword.Text = "Enter Your Password";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(419, 91);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(319, 20);
            this.txtuser.TabIndex = 2;
            // 
            // txtenterpw
            // 
            this.txtenterpw.Location = new System.Drawing.Point(419, 149);
            this.txtenterpw.Name = "txtenterpw";
            this.txtenterpw.Size = new System.Drawing.Size(319, 20);
            this.txtenterpw.TabIndex = 3;
            this.txtenterpw.UseSystemPasswordChar = true;
            // 
            // btnloginhome
            // 
            this.btnloginhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloginhome.Location = new System.Drawing.Point(334, 241);
            this.btnloginhome.Name = "btnloginhome";
            this.btnloginhome.Size = new System.Drawing.Size(234, 55);
            this.btnloginhome.TabIndex = 4;
            this.btnloginhome.Text = "Login ";
            this.btnloginhome.UseVisualStyleBackColor = true;
            this.btnloginhome.Click += new System.EventHandler(this.btnloginhome_Click);
            // 
            // btnregisterform
            // 
            this.btnregisterform.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregisterform.Location = new System.Drawing.Point(247, 354);
            this.btnregisterform.Name = "btnregisterform";
            this.btnregisterform.Size = new System.Drawing.Size(417, 55);
            this.btnregisterform.TabIndex = 5;
            this.btnregisterform.Text = "You don\'t have an Account ?";
            this.btnregisterform.UseVisualStyleBackColor = true;
            this.btnregisterform.Click += new System.EventHandler(this.btnregisterform_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(419, 199);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(115, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnregisterform);
            this.Controls.Add(this.btnloginhome);
            this.Controls.Add(this.txtenterpw);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lgtxtpassword);
            this.Controls.Add(this.lgtxtusername);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lgtxtusername;
        private System.Windows.Forms.Label lgtxtpassword;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtenterpw;
        private System.Windows.Forms.Button btnloginhome;
        private System.Windows.Forms.Button btnregisterform;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}