namespace BlaParser
{
    partial class Bla
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
            txtFrom = new TextBox();
            txtTo = new TextBox();
            btnParse = new Button();
            label1 = new Label();
            btUnparse = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            blaInfo = new Button();
            SuspendLayout();
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(12, 36);
            txtFrom.MaxLength = int.MaxValue;
            txtFrom.Multiline = true;
            txtFrom.Name = "txtFrom";
            txtFrom.ScrollBars = ScrollBars.Vertical;
            txtFrom.Size = new Size(776, 180);
            txtFrom.TabIndex = 0;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(12, 243);
            txtTo.MaxLength = int.MaxValue;
            txtTo.Multiline = true;
            txtTo.Name = "txtTo";
            txtTo.ScrollBars = ScrollBars.Vertical;
            txtTo.Size = new Size(776, 195);
            txtTo.TabIndex = 1;
            // 
            // btnParse
            // 
            btnParse.Location = new Point(12, 7);
            btnParse.Name = "btnParse";
            btnParse.Size = new Size(75, 23);
            btnParse.TabIndex = 2;
            btnParse.Text = "Parse";
            btnParse.UseVisualStyleBackColor = true;
            btnParse.Click += btnParse_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 225);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Result:";
            // 
            // btUnparse
            // 
            btUnparse.Location = new Point(713, 7);
            btUnparse.Name = "btUnparse";
            btUnparse.Size = new Size(75, 23);
            btUnparse.TabIndex = 4;
            btUnparse.Text = "UnParse";
            btUnparse.UseVisualStyleBackColor = true;
            btUnparse.Click += btUnparse_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(647, 446);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 5;
            label2.Text = "Copyright @ 2025 - Sales ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 478);
            label3.Name = "label3";
            label3.Size = new Size(187, 15);
            label3.TabIndex = 6;
            label3.Text = "of course its not responsive layout";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(829, 221);
            label4.Name = "label4";
            label4.Size = new Size(187, 15);
            label4.TabIndex = 7;
            label4.Text = "of course its not responsive layout";
            // 
            // blaInfo
            // 
            blaInfo.Location = new Point(566, 441);
            blaInfo.Name = "blaInfo";
            blaInfo.Size = new Size(75, 25);
            blaInfo.TabIndex = 8;
            blaInfo.Text = "info";
            blaInfo.UseVisualStyleBackColor = true;
            blaInfo.Click += blaInfo_Click;
            // 
            // Bla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 470);
            Controls.Add(blaInfo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btUnparse);
            Controls.Add(label1);
            Controls.Add(btnParse);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Name = "Bla";
            Text = "Bla parser - Jose Badran Dialect";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFrom;
        private TextBox txtTo;
        private Button btnParse;
        private Label label1;
        private Button btUnparse;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button blaInfo;
    }
}