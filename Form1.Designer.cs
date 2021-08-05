
namespace keygen
{
    partial class MainForm
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
        private void InitializeComponent( )
        {
            this.Genbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.github = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.downloadLink = new System.Windows.Forms.LinkLabel();
            this.Outputbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Genbutton
            // 
            this.Genbutton.Location = new System.Drawing.Point(125, 155);
            this.Genbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Genbutton.Name = "Genbutton";
            this.Genbutton.Size = new System.Drawing.Size(150, 20);
            this.Genbutton.TabIndex = 1;
            this.Genbutton.Text = "Generate Key!";
            this.Genbutton.UseVisualStyleBackColor = true;
            this.Genbutton.Click += new System.EventHandler(this.Genbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Http Log Viewer Keygen\r\n1.Modify Hosts File (hijack www.apacheviewer.com to 0.0.0" +
    ".0)\r\n2.Generate Unlock Code.";
            // 
            // github
            // 
            this.github.AutoSize = true;
            this.github.Location = new System.Drawing.Point(81, 51);
            this.github.Name = "github";
            this.github.Size = new System.Drawing.Size(167, 12);
            this.github.TabIndex = 3;
            this.github.TabStop = true;
            this.github.Text = "https://github.com/NS-Sp4ce";
            this.github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.github_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "My Github:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Program Download Link:";
            // 
            // downloadLink
            // 
            this.downloadLink.AutoSize = true;
            this.downloadLink.Location = new System.Drawing.Point(153, 64);
            this.downloadLink.Name = "downloadLink";
            this.downloadLink.Size = new System.Drawing.Size(179, 12);
            this.downloadLink.TabIndex = 6;
            this.downloadLink.TabStop = true;
            this.downloadLink.Text = "https://www.apacheviewer.com/";
            this.downloadLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Outputbox
            // 
            this.Outputbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Outputbox.Location = new System.Drawing.Point(11, 82);
            this.Outputbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Outputbox.Name = "Outputbox";
            this.Outputbox.Size = new System.Drawing.Size(364, 71);
            this.Outputbox.TabIndex = 7;
            this.Outputbox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 181);
            this.Controls.Add(this.Outputbox);
            this.Controls.Add(this.downloadLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.github);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Genbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "HTTP Log Viewer Keygen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Genbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel github;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel downloadLink;
        private System.Windows.Forms.RichTextBox Outputbox;
    }
}

