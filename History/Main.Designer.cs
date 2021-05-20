
namespace History
{
    partial class Main
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
            this.First = new System.Windows.Forms.Button();
            this.Second = new System.Windows.Forms.Button();
            this.Third = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // First
            // 
            this.First.Location = new System.Drawing.Point(118, 72);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(330, 71);
            this.First.TabIndex = 0;
            this.First.Text = "Франция от начала революции до падение Напалеона";
            this.First.UseVisualStyleBackColor = true;
            this.First.Click += new System.EventHandler(this.First_Click);
            // 
            // Second
            // 
            this.Second.Location = new System.Drawing.Point(118, 209);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(330, 71);
            this.Second.TabIndex = 1;
            this.Second.Text = "История Древней Греции";
            this.Second.UseVisualStyleBackColor = true;
            this.Second.Click += new System.EventHandler(this.First_Click);
            // 
            // Third
            // 
            this.Third.Location = new System.Drawing.Point(118, 344);
            this.Third.Name = "Third";
            this.Third.Size = new System.Drawing.Size(330, 71);
            this.Third.TabIndex = 2;
            this.Third.Text = "Иконоборчество в Византии";
            this.Third.UseVisualStyleBackColor = true;
            this.Third.Click += new System.EventHandler(this.First_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 545);
            this.Controls.Add(this.Third);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.First);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button First;
        private System.Windows.Forms.Button Second;
        private System.Windows.Forms.Button Third;
    }
}

