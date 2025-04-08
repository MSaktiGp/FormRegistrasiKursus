namespace Registrasi
{
    partial class FormLogin
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
            labelUsn = new Label();
            labelPw = new Label();
            textBoxUsn = new TextBox();
            textBoxPw = new TextBox();
            buttonClear = new Button();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // labelUsn
            // 
            labelUsn.AutoSize = true;
            labelUsn.Location = new Point(154, 50);
            labelUsn.Name = "labelUsn";
            labelUsn.Size = new Size(60, 15);
            labelUsn.TabIndex = 0;
            labelUsn.Text = "Username";
            // 
            // labelPw
            // 
            labelPw.AutoSize = true;
            labelPw.Location = new Point(154, 89);
            labelPw.Name = "labelPw";
            labelPw.Size = new Size(57, 15);
            labelPw.TabIndex = 1;
            labelPw.Text = "Password";
            // 
            // textBoxUsn
            // 
            textBoxUsn.Location = new Point(254, 42);
            textBoxUsn.Name = "textBoxUsn";
            textBoxUsn.PlaceholderText = "Username";
            textBoxUsn.Size = new Size(245, 23);
            textBoxUsn.TabIndex = 2;
            // 
            // textBoxPw
            // 
            textBoxPw.Location = new Point(254, 81);
            textBoxPw.Name = "textBoxPw";
            textBoxPw.PasswordChar = '*';
            textBoxPw.PlaceholderText = "Password";
            textBoxPw.Size = new Size(245, 23);
            textBoxPw.TabIndex = 3;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(254, 134);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(424, 134);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogin);
            Controls.Add(buttonClear);
            Controls.Add(textBoxPw);
            Controls.Add(textBoxUsn);
            Controls.Add(labelPw);
            Controls.Add(labelUsn);
            Name = "FormLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsn;
        private Label labelPw;
        private TextBox textBoxUsn;
        private TextBox textBoxPw;
        private Button buttonClear;
        private Button buttonLogin;
    }
}
