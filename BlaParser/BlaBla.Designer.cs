namespace BlaParser
{
    partial class BlaBla
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
            blablabla = new TextBox();
            blablablabla = new TextBox();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // blablabla
            // 
            blablabla.BackColor = Color.Red;
            blablabla.Location = new Point(12, 33);
            blablabla.MaxLength = int.MaxValue;
            blablabla.Multiline = true;
            blablabla.Name = "blablabla";
            blablabla.ReadOnly = true;
            blablabla.ScrollBars = ScrollBars.Vertical;
            blablabla.Size = new Size(419, 122);
            blablabla.TabIndex = 0;
            // 
            // blablablabla
            // 
            blablablabla.BackColor = Color.Red;
            blablablabla.Location = new Point(12, 5);
            blablablabla.Multiline = true;
            blablablabla.Name = "blablablabla";
            blablablabla.ReadOnly = true;
            blablablabla.Size = new Size(419, 22);
            blablablabla.TabIndex = 1;
            blablablabla.Text = "BLA";
            blablablabla.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 189);
            label3.Name = "label3";
            label3.Size = new Size(302, 15);
            label3.TabIndex = 7;
            label3.Text = "of course its not responsive layout, like the previous one";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(464, 80);
            label1.Name = "label1";
            label1.Size = new Size(302, 15);
            label1.TabIndex = 8;
            label1.Text = "of course its not responsive layout, like the previous one";
            // 
            // BlaBla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OrangeRed;
            ClientSize = new Size(443, 167);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(blablablabla);
            Controls.Add(blablabla);
            Name = "BlaBla";
            Text = "BlaBla";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox blablabla;
        private TextBox blablablabla;
        private Label label3;
        private Label label1;
    }
}