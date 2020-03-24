namespace Makeup_Store
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelp = new System.Windows.Forms.Panel();
            this.panelu = new System.Windows.Forms.Panel();
            this.password = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.passpic = new System.Windows.Forms.PictureBox();
            this.userpic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panelp);
            this.panel1.Controls.Add(this.panelu);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.passpic);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.userpic);
            this.panel1.Location = new System.Drawing.Point(235, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 419);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(86, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dont have an account? Sign up";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(37, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Log In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(79, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "Log In";
            // 
            // panelp
            // 
            this.panelp.BackColor = System.Drawing.Color.White;
            this.panelp.Location = new System.Drawing.Point(35, 255);
            this.panelp.Name = "panelp";
            this.panelp.Size = new System.Drawing.Size(250, 1);
            this.panelp.TabIndex = 7;
            // 
            // panelu
            // 
            this.panelu.BackColor = System.Drawing.Color.White;
            this.panelu.Location = new System.Drawing.Point(35, 195);
            this.panelu.Name = "panelu";
            this.panelu.Size = new System.Drawing.Size(250, 1);
            this.panelu.TabIndex = 4;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(72, 227);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 15);
            this.password.TabIndex = 6;
            this.password.Text = "Password";
            this.password.Click += new System.EventHandler(this.password_Click);
            this.password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(72, 167);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 15);
            this.name.TabIndex = 3;
            this.name.Text = "Username";
            this.name.Click += new System.EventHandler(this.textBox1_Click);
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passpic
            // 
            this.passpic.Image = ((System.Drawing.Image)(resources.GetObject("passpic.Image")));
            this.passpic.Location = new System.Drawing.Point(35, 219);
            this.passpic.Name = "passpic";
            this.passpic.Size = new System.Drawing.Size(24, 24);
            this.passpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.passpic.TabIndex = 5;
            this.passpic.TabStop = false;
            // 
            // userpic
            // 
            this.userpic.Image = global::Makeup_Store.Properties.Resources.userwhite;
            this.userpic.Location = new System.Drawing.Point(35, 159);
            this.userpic.Name = "userpic";
            this.userpic.Size = new System.Drawing.Size(30, 30);
            this.userpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userpic.TabIndex = 2;
            this.userpic.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(144)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(803, 520);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.PictureBox userpic;
        private System.Windows.Forms.Panel panelp;
        private System.Windows.Forms.Panel panelu;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox passpic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}