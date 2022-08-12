namespace XMLtest
{
    partial class Tag2A2
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
            this.loadButt = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.saveButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loadButt
            // 
            this.loadButt.Location = new System.Drawing.Point(616, 25);
            this.loadButt.Name = "loadButt";
            this.loadButt.Size = new System.Drawing.Size(172, 23);
            this.loadButt.TabIndex = 0;
            this.loadButt.Text = "Load settings XML in box";
            this.loadButt.UseVisualStyleBackColor = true;
            this.loadButt.Click += new System.EventHandler(this.loadButt_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 54);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputBox.Size = new System.Drawing.Size(776, 384);
            this.outputBox.TabIndex = 1;
            // 
            // saveButt
            // 
            this.saveButt.Location = new System.Drawing.Point(12, 25);
            this.saveButt.Name = "saveButt";
            this.saveButt.Size = new System.Drawing.Size(172, 23);
            this.saveButt.TabIndex = 2;
            this.saveButt.Text = "Save window location and size";
            this.saveButt.UseVisualStyleBackColor = true;
            this.saveButt.Click += new System.EventHandler(this.saveButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = " ";
            // 
            // Tag2A2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButt);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.loadButt);
            this.Name = "Tag2A2";
            this.Text = "Tag2A2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButt;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button saveButt;
        private System.Windows.Forms.Label label1;
    }
}