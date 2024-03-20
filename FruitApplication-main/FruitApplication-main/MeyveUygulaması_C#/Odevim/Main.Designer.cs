
namespace Odevim
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.baslaButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sureLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.meyvePureLbl = new System.Windows.Forms.Label();
            this.katiMeyveLbl = new System.Windows.Forms.Label();
            this.masterImage = new System.Windows.Forms.PictureBox();
            this.masterGramajLbl = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toplamVerimLbl = new System.Windows.Forms.Label();
            this.VerimKatiLbl = new System.Windows.Forms.Label();
            this.pureVerimLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // baslaButton
            // 
            this.baslaButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.baslaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baslaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.baslaButton.Location = new System.Drawing.Point(0, 386);
            this.baslaButton.Name = "baslaButton";
            this.baslaButton.Size = new System.Drawing.Size(1208, 64);
            this.baslaButton.TabIndex = 0;
            this.baslaButton.Text = "Başla !!!";
            this.baslaButton.UseVisualStyleBackColor = true;
            this.baslaButton.Click += new System.EventHandler(this.baslaButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sureLabel
            // 
            this.sureLabel.AutoEllipsis = true;
            this.sureLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sureLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sureLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sureLabel.ForeColor = System.Drawing.Color.Maroon;
            this.sureLabel.Location = new System.Drawing.Point(0, 0);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(1208, 54);
            this.sureLabel.TabIndex = 1;
            this.sureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.pureVerimLbl);
            this.panel1.Controls.Add(this.VerimKatiLbl);
            this.panel1.Controls.Add(this.meyvePureLbl);
            this.panel1.Controls.Add(this.katiMeyveLbl);
            this.panel1.Controls.Add(this.masterImage);
            this.panel1.Controls.Add(this.masterGramajLbl);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.baslaButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 450);
            this.panel1.TabIndex = 2;
            // 
            // meyvePureLbl
            // 
            this.meyvePureLbl.AutoSize = true;
            this.meyvePureLbl.BackColor = System.Drawing.SystemColors.Control;
            this.meyvePureLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.meyvePureLbl.Location = new System.Drawing.Point(964, 184);
            this.meyvePureLbl.Name = "meyvePureLbl";
            this.meyvePureLbl.Size = new System.Drawing.Size(170, 29);
            this.meyvePureLbl.TabIndex = 5;
            this.meyvePureLbl.Text = "Meyve Püresi";
            this.meyvePureLbl.Visible = false;
            // 
            // katiMeyveLbl
            // 
            this.katiMeyveLbl.AutoSize = true;
            this.katiMeyveLbl.BackColor = System.Drawing.SystemColors.Control;
            this.katiMeyveLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.katiMeyveLbl.Location = new System.Drawing.Point(12, 184);
            this.katiMeyveLbl.Name = "katiMeyveLbl";
            this.katiMeyveLbl.Size = new System.Drawing.Size(247, 29);
            this.katiMeyveLbl.TabIndex = 4;
            this.katiMeyveLbl.Text = "Katı Meyve Sıkacağı";
            this.katiMeyveLbl.Visible = false;
            // 
            // masterImage
            // 
            this.masterImage.BackColor = System.Drawing.SystemColors.Window;
            this.masterImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterImage.Location = new System.Drawing.Point(284, 0);
            this.masterImage.Name = "masterImage";
            this.masterImage.Size = new System.Drawing.Size(609, 355);
            this.masterImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.masterImage.TabIndex = 0;
            this.masterImage.TabStop = false;
            // 
            // masterGramajLbl
            // 
            this.masterGramajLbl.BackColor = System.Drawing.SystemColors.Desktop;
            this.masterGramajLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.masterGramajLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.masterGramajLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.masterGramajLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masterGramajLbl.ForeColor = System.Drawing.SystemColors.Window;
            this.masterGramajLbl.Location = new System.Drawing.Point(284, 355);
            this.masterGramajLbl.Name = "masterGramajLbl";
            this.masterGramajLbl.Size = new System.Drawing.Size(609, 31);
            this.masterGramajLbl.TabIndex = 3;
            this.masterGramajLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(893, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(315, 386);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 386);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "potakal.jpg");
            this.imageList1.Images.SetKeyName(1, "mandalina.jpg");
            this.imageList1.Images.SetKeyName(2, "Greyfurt.jpg");
            this.imageList1.Images.SetKeyName(3, "elma.jpg");
            this.imageList1.Images.SetKeyName(4, "armut.jpeg");
            this.imageList1.Images.SetKeyName(5, "Cilek.jpg");
            // 
            // toplamVerimLbl
            // 
            this.toplamVerimLbl.AutoEllipsis = true;
            this.toplamVerimLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toplamVerimLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.toplamVerimLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toplamVerimLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamVerimLbl.ForeColor = System.Drawing.Color.Maroon;
            this.toplamVerimLbl.Location = new System.Drawing.Point(0, 54);
            this.toplamVerimLbl.Name = "toplamVerimLbl";
            this.toplamVerimLbl.Size = new System.Drawing.Size(1208, 45);
            this.toplamVerimLbl.TabIndex = 3;
            this.toplamVerimLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VerimKatiLbl
            // 
            this.VerimKatiLbl.AutoSize = true;
            this.VerimKatiLbl.BackColor = System.Drawing.SystemColors.Control;
            this.VerimKatiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VerimKatiLbl.Location = new System.Drawing.Point(12, 213);
            this.VerimKatiLbl.Name = "VerimKatiLbl";
            this.VerimKatiLbl.Size = new System.Drawing.Size(42, 29);
            this.VerimKatiLbl.TabIndex = 6;
            this.VerimKatiLbl.Text = "lbl";
            this.VerimKatiLbl.Visible = false;
            // 
            // pureVerimLbl
            // 
            this.pureVerimLbl.AutoSize = true;
            this.pureVerimLbl.BackColor = System.Drawing.SystemColors.Control;
            this.pureVerimLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pureVerimLbl.Location = new System.Drawing.Point(964, 224);
            this.pureVerimLbl.Name = "pureVerimLbl";
            this.pureVerimLbl.Size = new System.Drawing.Size(42, 29);
            this.pureVerimLbl.TabIndex = 7;
            this.pureVerimLbl.Text = "lbl";
            this.pureVerimLbl.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 504);
            this.Controls.Add(this.toplamVerimLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sureLabel);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button baslaButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label sureLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox masterImage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label masterGramajLbl;
        private System.Windows.Forms.Label toplamVerimLbl;
        private System.Windows.Forms.Label katiMeyveLbl;
        private System.Windows.Forms.Label meyvePureLbl;
        private System.Windows.Forms.Label VerimKatiLbl;
        private System.Windows.Forms.Label pureVerimLbl;
    }
}

