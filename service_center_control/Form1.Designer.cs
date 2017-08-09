namespace service_center_control
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnClose = new Bunifu.Framework.UI.BunifuTileButton();
            this.panelMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnSettings = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnReports = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnWarehouse = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnPayments = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnShop = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnClients = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnOrders = new Bunifu.Framework.UI.BunifuTileButton();
            this.panelData = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panelBot = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTop.BackgroundImage")));
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.Controls.Add(this.btnClose);
            this.bunifuTransition1.SetDecoration(this.panelTop, BunifuAnimatorNS.DecorationType.None);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.GradientBottomLeft = System.Drawing.Color.Blue;
            this.panelTop.GradientBottomRight = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelTop.GradientTopLeft = System.Drawing.Color.White;
            this.panelTop.GradientTopRight = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Quality = 10;
            this.panelTop.Size = new System.Drawing.Size(745, 25);
            this.panelTop.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.color = System.Drawing.Color.Transparent;
            this.btnClose.colorActive = System.Drawing.Color.Red;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImagePosition = 4;
            this.btnClose.ImageZoom = 70;
            this.btnClose.LabelPosition = 0;
            this.btnClose.LabelText = "";
            this.btnClose.Location = new System.Drawing.Point(720, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnReports);
            this.panelMenu.Controls.Add(this.btnWarehouse);
            this.panelMenu.Controls.Add(this.btnPayments);
            this.panelMenu.Controls.Add(this.btnShop);
            this.panelMenu.Controls.Add(this.btnClients);
            this.panelMenu.Controls.Add(this.btnOrders);
            this.bunifuTransition1.SetDecoration(this.panelMenu, BunifuAnimatorNS.DecorationType.None);
            this.panelMenu.GradientBottomLeft = System.Drawing.Color.White;
            this.panelMenu.GradientBottomRight = System.Drawing.Color.White;
            this.panelMenu.GradientTopLeft = System.Drawing.Color.White;
            this.panelMenu.GradientTopRight = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(0, 25);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Quality = 10;
            this.panelMenu.Size = new System.Drawing.Size(745, 100);
            this.panelMenu.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.color = System.Drawing.Color.Transparent;
            this.btnSettings.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnSettings, BunifuAnimatorNS.DecorationType.None);
            this.btnSettings.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImagePosition = 9;
            this.btnSettings.ImageZoom = 50;
            this.btnSettings.LabelPosition = 42;
            this.btnSettings.LabelText = "Настройки";
            this.btnSettings.Location = new System.Drawing.Point(637, 0);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(96, 111);
            this.btnSettings.TabIndex = 0;
            // 
            // btnReports
            // 
            this.btnReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.color = System.Drawing.Color.Transparent;
            this.btnReports.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnReports, BunifuAnimatorNS.DecorationType.None);
            this.btnReports.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImagePosition = 9;
            this.btnReports.ImageZoom = 50;
            this.btnReports.LabelPosition = 42;
            this.btnReports.LabelText = "Отчеты";
            this.btnReports.Location = new System.Drawing.Point(533, 0);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(96, 111);
            this.btnReports.TabIndex = 0;
            // 
            // btnWarehouse
            // 
            this.btnWarehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWarehouse.BackColor = System.Drawing.Color.Transparent;
            this.btnWarehouse.color = System.Drawing.Color.Transparent;
            this.btnWarehouse.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.btnWarehouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnWarehouse, BunifuAnimatorNS.DecorationType.None);
            this.btnWarehouse.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWarehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnWarehouse.Image = ((System.Drawing.Image)(resources.GetObject("btnWarehouse.Image")));
            this.btnWarehouse.ImagePosition = 9;
            this.btnWarehouse.ImageZoom = 50;
            this.btnWarehouse.LabelPosition = 42;
            this.btnWarehouse.LabelText = "Склад";
            this.btnWarehouse.Location = new System.Drawing.Point(429, 0);
            this.btnWarehouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWarehouse.Name = "btnWarehouse";
            this.btnWarehouse.Size = new System.Drawing.Size(96, 111);
            this.btnWarehouse.TabIndex = 0;
            this.btnWarehouse.Click += new System.EventHandler(this.btnWarehouse_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayments.BackColor = System.Drawing.Color.Transparent;
            this.btnPayments.color = System.Drawing.Color.Transparent;
            this.btnPayments.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.btnPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnPayments, BunifuAnimatorNS.DecorationType.None);
            this.btnPayments.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnPayments.Image = ((System.Drawing.Image)(resources.GetObject("btnPayments.Image")));
            this.btnPayments.ImagePosition = 9;
            this.btnPayments.ImageZoom = 50;
            this.btnPayments.LabelPosition = 42;
            this.btnPayments.LabelText = "Платежи";
            this.btnPayments.Location = new System.Drawing.Point(325, 0);
            this.btnPayments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(96, 111);
            this.btnPayments.TabIndex = 0;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnShop
            // 
            this.btnShop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShop.BackColor = System.Drawing.Color.Transparent;
            this.btnShop.color = System.Drawing.Color.Transparent;
            this.btnShop.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.btnShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnShop, BunifuAnimatorNS.DecorationType.None);
            this.btnShop.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnShop.Image = ((System.Drawing.Image)(resources.GetObject("btnShop.Image")));
            this.btnShop.ImagePosition = 9;
            this.btnShop.ImageZoom = 50;
            this.btnShop.LabelPosition = 42;
            this.btnShop.LabelText = "Магазин";
            this.btnShop.Location = new System.Drawing.Point(221, 0);
            this.btnShop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(96, 111);
            this.btnShop.TabIndex = 0;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnClients
            // 
            this.btnClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClients.BackColor = System.Drawing.Color.Transparent;
            this.btnClients.color = System.Drawing.Color.Transparent;
            this.btnClients.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.btnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnClients, BunifuAnimatorNS.DecorationType.None);
            this.btnClients.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnClients.Image = ((System.Drawing.Image)(resources.GetObject("btnClients.Image")));
            this.btnClients.ImagePosition = 9;
            this.btnClients.ImageZoom = 50;
            this.btnClients.LabelPosition = 42;
            this.btnClients.LabelText = "Клиенты";
            this.btnClients.Location = new System.Drawing.Point(117, 0);
            this.btnClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(96, 111);
            this.btnClients.TabIndex = 0;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnOrders.color = System.Drawing.Color.Transparent;
            this.btnOrders.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.btnOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnOrders, BunifuAnimatorNS.DecorationType.None);
            this.btnOrders.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnOrders.Image")));
            this.btnOrders.ImagePosition = 9;
            this.btnOrders.ImageZoom = 50;
            this.btnOrders.LabelPosition = 42;
            this.btnOrders.LabelText = "Заказы";
            this.btnOrders.Location = new System.Drawing.Point(13, 0);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(96, 111);
            this.btnOrders.TabIndex = 0;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // panelData
            // 
            this.panelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelData.BackgroundImage")));
            this.panelData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.panelData, BunifuAnimatorNS.DecorationType.None);
            this.panelData.GradientBottomLeft = System.Drawing.Color.White;
            this.panelData.GradientBottomRight = System.Drawing.Color.White;
            this.panelData.GradientTopLeft = System.Drawing.Color.White;
            this.panelData.GradientTopRight = System.Drawing.Color.White;
            this.panelData.Location = new System.Drawing.Point(0, 127);
            this.panelData.Name = "panelData";
            this.panelData.Quality = 10;
            this.panelData.Size = new System.Drawing.Size(745, 301);
            this.panelData.TabIndex = 2;
            // 
            // panelBot
            // 
            this.panelBot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBot.BackgroundImage")));
            this.panelBot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.panelBot, BunifuAnimatorNS.DecorationType.None);
            this.panelBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBot.GradientBottomLeft = System.Drawing.Color.White;
            this.panelBot.GradientBottomRight = System.Drawing.Color.White;
            this.panelBot.GradientTopLeft = System.Drawing.Color.White;
            this.panelBot.GradientTopRight = System.Drawing.Color.White;
            this.panelBot.Location = new System.Drawing.Point(0, 446);
            this.panelBot.Name = "panelBot";
            this.panelBot.Quality = 10;
            this.panelBot.Size = new System.Drawing.Size(745, 17);
            this.panelBot.TabIndex = 3;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelTop;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            this.bunifuTransition1.TimeStep = 0.04F;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 463);
            this.Controls.Add(this.panelBot);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelTop);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel panelBot;
        private Bunifu.Framework.UI.BunifuGradientPanel panelData;
        private Bunifu.Framework.UI.BunifuGradientPanel panelMenu;
        private Bunifu.Framework.UI.BunifuGradientPanel panelTop;
        private Bunifu.Framework.UI.BunifuTileButton btnClose;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuTileButton btnOrders;
        private Bunifu.Framework.UI.BunifuTileButton btnSettings;
        private Bunifu.Framework.UI.BunifuTileButton btnReports;
        private Bunifu.Framework.UI.BunifuTileButton btnWarehouse;
        private Bunifu.Framework.UI.BunifuTileButton btnPayments;
        private Bunifu.Framework.UI.BunifuTileButton btnShop;
        private Bunifu.Framework.UI.BunifuTileButton btnClients;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}

