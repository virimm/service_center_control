namespace service_center_control
{
    partial class UCOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCOrders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonNewOrder = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgOrders = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tbOrdersSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrdersFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNewOrder
            // 
            this.buttonNewOrder.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(152)))), ((int)(((byte)(253)))));
            this.buttonNewOrder.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNewOrder.BorderRadius = 7;
            this.buttonNewOrder.ButtonText = "Новый заказ";
            this.buttonNewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewOrder.DisabledColor = System.Drawing.Color.Gray;
            this.buttonNewOrder.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonNewOrder.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonNewOrder.Iconimage")));
            this.buttonNewOrder.Iconimage_right = null;
            this.buttonNewOrder.Iconimage_right_Selected = null;
            this.buttonNewOrder.Iconimage_Selected = null;
            this.buttonNewOrder.IconMarginLeft = 0;
            this.buttonNewOrder.IconMarginRight = 0;
            this.buttonNewOrder.IconRightVisible = true;
            this.buttonNewOrder.IconRightZoom = 0D;
            this.buttonNewOrder.IconVisible = true;
            this.buttonNewOrder.IconZoom = 80D;
            this.buttonNewOrder.IsTab = false;
            this.buttonNewOrder.Location = new System.Drawing.Point(3, 3);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonNewOrder.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.buttonNewOrder.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonNewOrder.selected = false;
            this.buttonNewOrder.Size = new System.Drawing.Size(123, 42);
            this.buttonNewOrder.TabIndex = 0;
            this.buttonNewOrder.Text = "Новый заказ";
            this.buttonNewOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonNewOrder.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.buttonNewOrder.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dgOrders
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgOrders.DoubleBuffered = true;
            this.dgOrders.EnableHeadersVisualStyles = false;
            this.dgOrders.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.dgOrders.HeaderForeColor = System.Drawing.Color.Black;
            this.dgOrders.Location = new System.Drawing.Point(3, 51);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgOrders.Size = new System.Drawing.Size(739, 178);
            this.dgOrders.TabIndex = 1;
            // 
            // tbOrdersSearch
            // 
            this.tbOrdersSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOrdersSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbOrdersSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbOrdersSearch.HintForeColor = System.Drawing.Color.Empty;
            this.tbOrdersSearch.HintText = "        Поиск";
            this.tbOrdersSearch.isPassword = false;
            this.tbOrdersSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.tbOrdersSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.tbOrdersSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.tbOrdersSearch.LineThickness = 2;
            this.tbOrdersSearch.Location = new System.Drawing.Point(261, 7);
            this.tbOrdersSearch.Name = "tbOrdersSearch";
            this.tbOrdersSearch.Size = new System.Drawing.Size(134, 35);
            this.tbOrdersSearch.TabIndex = 2;
            this.tbOrdersSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Заказ №";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Статус";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Устройство";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Клиент";
            this.Column4.Name = "Column4";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Дата приема";
            this.Column8.Name = "Column8";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Крайний срок";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Принял";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Цена";
            this.Column7.Name = "Column7";
            // 
            // btnOrdersFilter
            // 
            this.btnOrdersFilter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(152)))), ((int)(((byte)(253)))));
            this.btnOrdersFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdersFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrdersFilter.BorderRadius = 7;
            this.btnOrdersFilter.ButtonText = "Фильтр";
            this.btnOrdersFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrdersFilter.DisabledColor = System.Drawing.Color.Gray;
            this.btnOrdersFilter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOrdersFilter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnOrdersFilter.Iconimage")));
            this.btnOrdersFilter.Iconimage_right = null;
            this.btnOrdersFilter.Iconimage_right_Selected = null;
            this.btnOrdersFilter.Iconimage_Selected = null;
            this.btnOrdersFilter.IconMarginLeft = 0;
            this.btnOrdersFilter.IconMarginRight = 0;
            this.btnOrdersFilter.IconRightVisible = true;
            this.btnOrdersFilter.IconRightZoom = 0D;
            this.btnOrdersFilter.IconVisible = true;
            this.btnOrdersFilter.IconZoom = 80D;
            this.btnOrdersFilter.IsTab = false;
            this.btnOrdersFilter.Location = new System.Drawing.Point(132, 3);
            this.btnOrdersFilter.Name = "btnOrdersFilter";
            this.btnOrdersFilter.Normalcolor = System.Drawing.Color.Transparent;
            this.btnOrdersFilter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.btnOrdersFilter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOrdersFilter.selected = false;
            this.btnOrdersFilter.Size = new System.Drawing.Size(123, 42);
            this.btnOrdersFilter.TabIndex = 0;
            this.btnOrdersFilter.Text = "Фильтр";
            this.btnOrdersFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOrdersFilter.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.btnOrdersFilter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // UCOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbOrdersSearch);
            this.Controls.Add(this.dgOrders);
            this.Controls.Add(this.btnOrdersFilter);
            this.Controls.Add(this.buttonNewOrder);
            this.Name = "UCOrders";
            this.Size = new System.Drawing.Size(745, 232);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton buttonNewOrder;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgOrders;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbOrdersSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private Bunifu.Framework.UI.BunifuFlatButton btnOrdersFilter;
    }
}
