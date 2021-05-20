
namespace History
{
    partial class Topic
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
            this.Test = new System.Windows.Forms.Button();
            this.TBText = new System.Windows.Forms.TextBox();
            this.Menu = new System.Windows.Forms.Button();
            this.TBTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Test
            // 
            this.Test.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Test.Location = new System.Drawing.Point(680, 614);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(135, 92);
            this.Test.TabIndex = 1;
            this.Test.Text = "Test";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // TBText
            // 
            this.TBText.AcceptsReturn = true;
            this.TBText.Location = new System.Drawing.Point(40, 197);
            this.TBText.Multiline = true;
            this.TBText.Name = "TBText";
            this.TBText.ReadOnly = true;
            this.TBText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TBText.Size = new System.Drawing.Size(708, 395);
            this.TBText.TabIndex = 2;
            // 
            // Menu
            // 
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Menu.Location = new System.Drawing.Point(-3, 614);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(172, 92);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // TBTitle
            // 
            this.TBTitle.Enabled = false;
            this.TBTitle.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBTitle.Location = new System.Drawing.Point(40, 27);
            this.TBTitle.Multiline = true;
            this.TBTitle.Name = "TBTitle";
            this.TBTitle.ReadOnly = true;
            this.TBTitle.Size = new System.Drawing.Size(708, 120);
            this.TBTitle.TabIndex = 5;
            // 
            // Topic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 698);
            this.Controls.Add(this.TBTitle);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.TBText);
            this.Controls.Add(this.Test);
            this.Name = "Topic";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.TextBox TBText;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.TextBox TBTitle;
    }
}