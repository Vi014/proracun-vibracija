namespace Proracun_vibracija
{
    partial class Forma_Centar_Tekst
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
            this.button1 = new System.Windows.Forms.Button();
            this.zoomPicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.zoomPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1330, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // zoomPicture
            // 
            this.zoomPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zoomPicture.Image = global::Proracun_vibracija.Properties.Resources.placeholder;
            this.zoomPicture.Location = new System.Drawing.Point(1330, 57);
            this.zoomPicture.Name = "zoomPicture";
            this.zoomPicture.Size = new System.Drawing.Size(130, 159);
            this.zoomPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zoomPicture.TabIndex = 2;
            this.zoomPicture.TabStop = false;
            this.zoomPicture.Visible = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 693);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1200, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 73);
            this.button2.TabIndex = 12;
            this.button2.TabStop = false;
            this.button2.Text = "Return to top";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Forma_Centar_Tekst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 717);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zoomPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Forma_Centar_Tekst";
            this.Text = "PLACEHOLDERSTRING Forma_Centar_Tekst.Text";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Forma_Centar_Tekst_FormClosing);
            this.Load += new System.EventHandler(this.Forma_Centar_Tekst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zoomPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox zoomPicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}