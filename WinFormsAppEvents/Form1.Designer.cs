namespace WinFormsAppEvents
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
            submitBtn = new Button();
            nametext = new TextBox();
            SuspendLayout();
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.DodgerBlue;
            submitBtn.ForeColor = Color.AliceBlue;
            submitBtn.Location = new Point(300, 188);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(112, 34);
            submitBtn.TabIndex = 1;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.MouseHover += submitBtn_MouseHover_1;
            // 
            // nametext
            // 
            nametext.Location = new Point(286, 117);
            nametext.Name = "nametext";
            nametext.Size = new Size(150, 31);
            nametext.TabIndex = 0;
            nametext.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nametext);
            Controls.Add(submitBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitBtn;
        private TextBox nametext;
    }
}