namespace ödev1_1473
{
    partial class Form1
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
            this.lbSiralar = new System.Windows.Forms.ListBox();
            this.btnSiraCikart = new System.Windows.Forms.Button();
            this.btnSiraAl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSiralar
            // 
            this.lbSiralar.FormattingEnabled = true;
            this.lbSiralar.Location = new System.Drawing.Point(182, 53);
            this.lbSiralar.Name = "lbSiralar";
            this.lbSiralar.Size = new System.Drawing.Size(120, 160);
            this.lbSiralar.TabIndex = 5;
            this.lbSiralar.SelectedIndexChanged += new System.EventHandler(this.lbSiralar_SelectedIndexChanged);
            // 
            // btnSiraCikart
            // 
            this.btnSiraCikart.Location = new System.Drawing.Point(334, 90);
            this.btnSiraCikart.Name = "btnSiraCikart";
            this.btnSiraCikart.Size = new System.Drawing.Size(107, 86);
            this.btnSiraCikart.TabIndex = 4;
            this.btnSiraCikart.Text = "Sıra Çıkart";
            this.btnSiraCikart.UseVisualStyleBackColor = true;
            this.btnSiraCikart.Click += new System.EventHandler(this.btnSiraCikart_Click_1);
            // 
            // btnSiraAl
            // 
            this.btnSiraAl.Location = new System.Drawing.Point(48, 90);
            this.btnSiraAl.Name = "btnSiraAl";
            this.btnSiraAl.Size = new System.Drawing.Size(107, 86);
            this.btnSiraAl.TabIndex = 3;
            this.btnSiraAl.Text = "Sıra Al";
            this.btnSiraAl.UseVisualStyleBackColor = true;
            this.btnSiraAl.Click += new System.EventHandler(this.btnSiraAl_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSiralar);
            this.Controls.Add(this.btnSiraCikart);
            this.Controls.Add(this.btnSiraAl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSiralar;
        private System.Windows.Forms.Button btnSiraCikart;
        private System.Windows.Forms.Button btnSiraAl;
    }
}

