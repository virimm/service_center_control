namespace service_center_control
{
    partial class UCShop
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCShop));
            this.tbShopSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgShop = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.buttonNewSale = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShopFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgShop)).BeginInit();
            this.SuspendLayout();
            // 
            // tbShopSearch
            // 
            this.tbShopSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbShopSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbShopSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbShopSearch.HintForeColor = System.Drawing.Color.Empty;
            this.tbShopSearch.HintText = "        Поиск";
            this.tbShopSearch.isPassword = false;
            this.tbShopSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.tbShopSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.tbShopSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.tbShopSearch.LineThickness = 2;
            this.tbShopSearch.Location = new System.Drawing.Point(261, 7);
            this.tbShopSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbShopSearch.Name = "tbShopSearch";
            this.tbShopSearch.Size = new System.Drawing.Size(134, 35);
            this.tbShopSearch.TabIndex = 10;
            this.tbShopSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgShop
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgShop.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgShop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgShop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgShop.BackgroundColor = System.Drawing.Color.White;
            this.dgShop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgShop.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgShop.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7});
            this.dgShop.DoubleBuffered = true;
            this.dgShop.EnableHeadersVisualStyles = false;
            this.dgShop.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.dgShop.HeaderForeColor = System.Drawing.Color.Black;
            this.dgShop.Location = new System.Drawing.Point(3, 51);
            this.dgShop.Name = "dgShop";
            this.dgShop.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgShop.Size = new System.Drawing.Size(739, 178);
            this.dgShop.TabIndex = 9;
            // 
            // buttonNewSale
            // 
            this.buttonNewSale.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(152)))), ((int)(((byte)(253)))));
            this.buttonNewSale.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNewSale.BorderRadius = 7;
            this.buttonNewSale.ButtonText = "Новая продажа";
            this.buttonNewSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewSale.DisabledColor = System.Drawing.Color.Gray;
            this.buttonNewSale.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonNewSale.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonNewSale.Iconimage")));
            this.buttonNewSale.Iconimage_right = null;
            this.buttonNewSale.Iconimage_right_Selected = null;
            this.buttonNewSale.Iconimage_Selected = null;
            this.buttonNewSale.IconMarginLeft = 0;
            this.buttonNewSale.IconMarginRight = 0;
            this.buttonNewSale.IconRightVisible = true;
            this.buttonNewSale.IconRightZoom = 0D;
            this.buttonNewSale.IconVisible = true;
            this.buttonNewSale.IconZoom = 80D;
            this.buttonNewSale.IsTab = false;
            this.buttonNewSale.Location = new System.Drawing.Point(3, 3);
            this.buttonNewSale.Name = "buttonNewSale";
            this.buttonNewSale.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonNewSale.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.buttonNewSale.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonNewSale.selected = false;
            this.buttonNewSale.Size = new System.Drawing.Size(123, 42);
            this.buttonNewSale.TabIndex = 7;
            this.buttonNewSale.Text = "Новая продажа";
            this.buttonNewSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonNewSale.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.buttonNewSale.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnShopFilter
            // 
            this.btnShopFilter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(152)))), ((int)(((byte)(253)))));
            this.btnShopFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnShopFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShopFilter.BorderRadius = 7;
            this.btnShopFilter.ButtonText = "Фильтр";
            this.btnShopFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShopFilter.DisabledColor = System.Drawing.Color.Gray;
            this.btnShopFilter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShopFilter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShopFilter.Iconimage")));
            this.btnShopFilter.Iconimage_right = null;
            this.btnShopFilter.Iconimage_right_Selected = null;
            this.btnShopFilter.Iconimage_Selected = null;
            this.btnShopFilter.IconMarginLeft = 0;
            this.btnShopFilter.IconMarginRight = 0;
            this.btnShopFilter.IconRightVisible = true;
            this.btnShopFilter.IconRightZoom = 0D;
            this.btnShopFilter.IconVisible = true;
            this.btnShopFilter.IconZoom = 80D;
            this.btnShopFilter.IsTab = false;
            this.btnShopFilter.Location = new System.Drawing.Point(132, 3);
            this.btnShopFilter.Name = "btnShopFilter";
            this.btnShopFilter.Normalcolor = System.Drawing.Color.Transparent;
            this.btnShopFilter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.btnShopFilter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShopFilter.selected = false;
            this.btnShopFilter.Size = new System.Drawing.Size(123, 42);
            this.btnShopFilter.TabIndex = 8;
            this.btnShopFilter.Text = "Фильтр";
            this.btnShopFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnShopFilter.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.btnShopFilter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Продажа №";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Сотрудник";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Склад";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Клиент";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Описание";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Оплачено";
            this.Column7.Name = "Column7";
            // 
            // UCShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbShopSearch);
            this.Controls.Add(this.dgShop);
            this.Controls.Add(this.buttonNewSale);
            this.Controls.Add(this.btnShopFilter);
            this.Name = "UCShop";
            this.Size = new System.Drawing.Size(745, 232);
            ((System.ComponentModel.ISupportInitialize)(this.dgShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox tbShopSearch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgShop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private Bunifu.Framework.UI.BunifuFlatButton buttonNewSale;
        private Bunifu.Framework.UI.BunifuFlatButton btnShopFilter;
    }
}
