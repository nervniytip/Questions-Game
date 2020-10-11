namespace Questions_Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_NewGame = new System.Windows.Forms.Button();
            this.button_Continue = new System.Windows.Forms.Button();
            this.panel_Questions = new System.Windows.Forms.Panel();
            this.label_Question = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Questions.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_NewGame
            // 
            this.button_NewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_NewGame.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_NewGame.Location = new System.Drawing.Point(250, 150);
            this.button_NewGame.Name = "button_NewGame";
            this.button_NewGame.Size = new System.Drawing.Size(300, 70);
            this.button_NewGame.TabIndex = 0;
            this.button_NewGame.Text = "Новая игра";
            this.button_NewGame.UseVisualStyleBackColor = true;
            this.button_NewGame.Click += new System.EventHandler(this.Button_NewGame_Click);
            // 
            // button_Continue
            // 
            this.button_Continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Continue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Continue.Location = new System.Drawing.Point(250, 280);
            this.button_Continue.Name = "button_Continue";
            this.button_Continue.Size = new System.Drawing.Size(300, 70);
            this.button_Continue.TabIndex = 0;
            this.button_Continue.Text = "Продолжить";
            this.button_Continue.UseVisualStyleBackColor = true;
            this.button_Continue.Click += new System.EventHandler(this.Button_Continue_Click);
            // 
            // panel_Questions
            // 
            this.panel_Questions.BackColor = System.Drawing.Color.Transparent;
            this.panel_Questions.Controls.Add(this.label_Question);
            this.panel_Questions.Controls.Add(this.button1);
            this.panel_Questions.Controls.Add(this.button2);
            this.panel_Questions.Controls.Add(this.button3);
            this.panel_Questions.Controls.Add(this.button4);
            this.panel_Questions.Location = new System.Drawing.Point(12, 12);
            this.panel_Questions.Name = "panel_Questions";
            this.panel_Questions.Size = new System.Drawing.Size(760, 537);
            this.panel_Questions.TabIndex = 1;
            this.panel_Questions.Visible = false;
            // 
            // label_Question
            // 
            this.label_Question.BackColor = System.Drawing.Color.Transparent;
            this.label_Question.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Question.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Question.Location = new System.Drawing.Point(0, 0);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(760, 254);
            this.label_Question.TabIndex = 1;
            this.label_Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(0, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(760, 70);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(0, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(760, 70);
            this.button2.TabIndex = 0;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gainsboro;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(0, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(760, 70);
            this.button3.TabIndex = 0;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gainsboro;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(0, 467);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(760, 70);
            this.button4.TabIndex = 0;
            this.button4.TabStop = false;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(129)))), ((int)(((byte)(178)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel_Questions);
            this.Controls.Add(this.button_Continue);
            this.Controls.Add(this.button_NewGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Victorina";
            this.panel_Questions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_NewGame;
        private System.Windows.Forms.Button button_Continue;
        private System.Windows.Forms.Panel panel_Questions;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
    }
}

