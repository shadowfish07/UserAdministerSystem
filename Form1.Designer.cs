namespace UserAdministerSystem
{
    partial class frmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_EnterAsGuess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(74, 69);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(225, 27);
            this.txt_UserName.TabIndex = 2;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(74, 108);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(225, 27);
            this.txt_Password.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(74, 173);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(186, 33);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "登录";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(74, 212);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(93, 33);
            this.btn_register.TabIndex = 5;
            this.btn_register.Text = "注册";
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // btn_EnterAsGuess
            // 
            this.btn_EnterAsGuess.Location = new System.Drawing.Point(173, 212);
            this.btn_EnterAsGuess.Name = "btn_EnterAsGuess";
            this.btn_EnterAsGuess.Size = new System.Drawing.Size(87, 33);
            this.btn_EnterAsGuess.TabIndex = 6;
            this.btn_EnterAsGuess.Text = "游客进入";
            this.btn_EnterAsGuess.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 299);
            this.Controls.Add(this.btn_EnterAsGuess);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_EnterAsGuess;
    }
}

