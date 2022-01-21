
namespace project_2
{
    partial class productForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cartButton = new System.Windows.Forms.Button();
            this.wishlistButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.beefPictureBox = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutKetoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.homepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutKetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.infoRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.beefPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalahari Crisps Air-Dried Beef Chips";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cartButton
            // 
            this.cartButton.Location = new System.Drawing.Point(297, 543);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(102, 36);
            this.cartButton.TabIndex = 1;
            this.cartButton.Text = "&Add to cart";
            this.cartButton.UseVisualStyleBackColor = true;
            // 
            // wishlistButton
            // 
            this.wishlistButton.Location = new System.Drawing.Point(165, 543);
            this.wishlistButton.Name = "wishlistButton";
            this.wishlistButton.Size = new System.Drawing.Size(126, 36);
            this.wishlistButton.TabIndex = 2;
            this.wishlistButton.Text = "&Add to wishlist";
            this.wishlistButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 543);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(147, 36);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "&Back to shopping";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // beefPictureBox
            // 
            this.beefPictureBox.Image = global::project_2.Properties.Resources.kalahari_crisps;
            this.beefPictureBox.Location = new System.Drawing.Point(12, 102);
            this.beefPictureBox.Name = "beefPictureBox";
            this.beefPictureBox.Size = new System.Drawing.Size(385, 220);
            this.beefPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.beefPictureBox.TabIndex = 4;
            this.beefPictureBox.TabStop = false;
            this.beefPictureBox.Click += new System.EventHandler(this.beefPictureBox_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.Location = new System.Drawing.Point(13, 336);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(179, 19);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = "Nutritional Information";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.aboutKetoToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutKetoToolStripMenuItem1,
            this.homepageToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.homeToolStripMenuItem.Text = "&Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // aboutKetoToolStripMenuItem1
            // 
            this.aboutKetoToolStripMenuItem1.Name = "aboutKetoToolStripMenuItem1";
            this.aboutKetoToolStripMenuItem1.Size = new System.Drawing.Size(205, 34);
            this.aboutKetoToolStripMenuItem1.Text = "&About Keto";
            // 
            // homepageToolStripMenuItem
            // 
            this.homepageToolStripMenuItem.Name = "homepageToolStripMenuItem";
            this.homepageToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.homepageToolStripMenuItem.Text = "&Homepage";
            // 
            // aboutKetoToolStripMenuItem
            // 
            this.aboutKetoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactUsToolStripMenuItem1});
            this.aboutKetoToolStripMenuItem.Name = "aboutKetoToolStripMenuItem";
            this.aboutKetoToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.aboutKetoToolStripMenuItem.Text = "&Help";
            this.aboutKetoToolStripMenuItem.Click += new System.EventHandler(this.aboutKetoToolStripMenuItem_Click);
            // 
            // contactUsToolStripMenuItem1
            // 
            this.contactUsToolStripMenuItem1.Name = "contactUsToolStripMenuItem1";
            this.contactUsToolStripMenuItem1.Size = new System.Drawing.Size(200, 34);
            this.contactUsToolStripMenuItem1.Text = "Contact Us";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartToolStripMenuItem});
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.contactUsToolStripMenuItem.Text = "&Account";
            // 
            // cartToolStripMenuItem
            // 
            this.cartToolStripMenuItem.Name = "cartToolStripMenuItem";
            this.cartToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.cartToolStripMenuItem.Text = "&Cart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "$24 Per box of 10";
            // 
            // infoRichTextBox
            // 
            this.infoRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.infoRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoRichTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.infoRichTextBox.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoRichTextBox.Location = new System.Drawing.Point(12, 370);
            this.infoRichTextBox.Name = "infoRichTextBox";
            this.infoRichTextBox.ReadOnly = true;
            this.infoRichTextBox.Size = new System.Drawing.Size(385, 98);
            this.infoRichTextBox.TabIndex = 8;
            this.infoRichTextBox.Text = resources.GetString("infoRichTextBox.Text");
            // 
            // productForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(414, 591);
            this.Controls.Add(this.infoRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.beefPictureBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.wishlistButton);
            this.Controls.Add(this.cartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "productForm";
            this.Text = "Product Page";
            ((System.ComponentModel.ISupportInitialize)(this.beefPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Button wishlistButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox beefPictureBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutKetoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutKetoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem homepageToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox infoRichTextBox;
    }
}

