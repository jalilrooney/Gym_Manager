namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.horizontalPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.restaurerBox = new System.Windows.Forms.PictureBox();
            this.menuBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancelBox = new System.Windows.Forms.PictureBox();
            this.minBox = new System.Windows.Forms.PictureBox();
            this.verticalPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.centerPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.horizontalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBox)).BeginInit();
            this.verticalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.horizontalPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // horizontalPanel
            // 
            this.horizontalPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.horizontalPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("horizontalPanel.BackgroundImage")));
            this.horizontalPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.horizontalPanel.Controls.Add(this.restaurerBox);
            this.horizontalPanel.Controls.Add(this.menuBox);
            this.horizontalPanel.Controls.Add(this.pictureBox1);
            this.horizontalPanel.Controls.Add(this.cancelBox);
            this.horizontalPanel.Controls.Add(this.minBox);
            this.horizontalPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.horizontalPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.horizontalPanel.GradientBottomRight = System.Drawing.Color.White;
            this.horizontalPanel.GradientTopLeft = System.Drawing.Color.White;
            this.horizontalPanel.GradientTopRight = System.Drawing.Color.White;
            this.horizontalPanel.Location = new System.Drawing.Point(250, 0);
            this.horizontalPanel.Name = "horizontalPanel";
            this.horizontalPanel.Quality = 10;
            this.horizontalPanel.Size = new System.Drawing.Size(1050, 50);
            this.horizontalPanel.TabIndex = 1;
            this.horizontalPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.horizontalPanel_Paint);
            // 
            // restaurerBox
            // 
            this.restaurerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.restaurerBox.BackColor = System.Drawing.Color.Transparent;
            this.restaurerBox.Image = ((System.Drawing.Image)(resources.GetObject("restaurerBox.Image")));
            this.restaurerBox.Location = new System.Drawing.Point(992, 3);
            this.restaurerBox.Name = "restaurerBox";
            this.restaurerBox.Size = new System.Drawing.Size(15, 15);
            this.restaurerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.restaurerBox.TabIndex = 2;
            this.restaurerBox.TabStop = false;
            this.restaurerBox.Visible = false;
            this.restaurerBox.Click += new System.EventHandler(this.restaurerBox_Click);
            // 
            // menuBox
            // 
            this.menuBox.BackColor = System.Drawing.Color.Transparent;
            this.menuBox.Image = ((System.Drawing.Image)(resources.GetObject("menuBox.Image")));
            this.menuBox.Location = new System.Drawing.Point(6, 9);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(35, 35);
            this.menuBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuBox.TabIndex = 3;
            this.menuBox.TabStop = false;
            this.menuBox.Click += new System.EventHandler(this.menuBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(966, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // cancelBox
            // 
            this.cancelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBox.BackColor = System.Drawing.Color.Transparent;
            this.cancelBox.Image = ((System.Drawing.Image)(resources.GetObject("cancelBox.Image")));
            this.cancelBox.Location = new System.Drawing.Point(1013, 3);
            this.cancelBox.Name = "cancelBox";
            this.cancelBox.Size = new System.Drawing.Size(20, 20);
            this.cancelBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cancelBox.TabIndex = 0;
            this.cancelBox.TabStop = false;
            this.cancelBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // minBox
            // 
            this.minBox.BackColor = System.Drawing.Color.Transparent;
            this.minBox.Image = ((System.Drawing.Image)(resources.GetObject("minBox.Image")));
            this.minBox.Location = new System.Drawing.Point(992, 3);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(15, 15);
            this.minBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minBox.TabIndex = 1;
            this.minBox.TabStop = false;
            this.minBox.Click += new System.EventHandler(this.minBox_Click);
            // 
            // verticalPanel
            // 
            this.verticalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.verticalPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("verticalPanel.BackgroundImage")));
            this.verticalPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.verticalPanel.Controls.Add(this.bunifuFlatButton2);
            this.verticalPanel.Controls.Add(this.bunifuFlatButton1);
            this.verticalPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.verticalPanel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.verticalPanel.GradientBottomRight = System.Drawing.Color.Black;
            this.verticalPanel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.verticalPanel.GradientTopRight = System.Drawing.Color.White;
            this.verticalPanel.Location = new System.Drawing.Point(0, 0);
            this.verticalPanel.Name = "verticalPanel";
            this.verticalPanel.Quality = 10;
            this.verticalPanel.Size = new System.Drawing.Size(250, 650);
            this.verticalPanel.TabIndex = 0;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Navy;
            this.bunifuFlatButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "View  List";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 20;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 80D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 163);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Navy;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(250, 71);
            this.bunifuFlatButton2.TabIndex = 1;
            this.bunifuFlatButton2.Text = "View  List";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Navy;
            this.bunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Add Member";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 20;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 94);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Navy;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(250, 69);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "Add Member";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // centerPanel
            // 
            this.centerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("centerPanel.BackgroundImage")));
            this.centerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.centerPanel.GradientBottomRight = System.Drawing.Color.White;
            this.centerPanel.GradientTopLeft = System.Drawing.Color.White;
            this.centerPanel.GradientTopRight = System.Drawing.Color.White;
            this.centerPanel.Location = new System.Drawing.Point(250, 50);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Quality = 10;
            this.centerPanel.Size = new System.Drawing.Size(1050, 600);
            this.centerPanel.TabIndex = 2;
            this.centerPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.centerPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.centerPanel);
            this.Controls.Add(this.horizontalPanel);
            this.Controls.Add(this.verticalPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.horizontalPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.restaurerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBox)).EndInit();
            this.verticalPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel centerPanel;
        private System.Windows.Forms.PictureBox cancelBox;
        private Bunifu.Framework.UI.BunifuGradientPanel verticalPanel;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox minBox;
        private System.Windows.Forms.PictureBox restaurerBox;
        private System.Windows.Forms.PictureBox menuBox;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        public Bunifu.Framework.UI.BunifuGradientPanel horizontalPanel;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}

