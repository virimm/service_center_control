namespace service_center_control
{
    partial class UCWhIncome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCWhIncome));
            this.dgWhIncome = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnWhIncome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbWhIncomeSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnWhIncomeFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgWhIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // dgWhIncome
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgWhIncome.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgWhIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgWhIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgWhIncome.BackgroundColor = System.Drawing.Color.White;
            this.dgWhIncome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgWhIncome.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgWhIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgWhIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWhIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.dgWhIncome.DoubleBuffered = true;
            this.dgWhIncome.EnableHeadersVisualStyles = false;
            this.dgWhIncome.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.dgWhIncome.HeaderForeColor = System.Drawing.Color.Black;
            this.dgWhIncome.Location = new System.Drawing.Point(3, 44);
            this.dgWhIncome.Name = "dgWhIncome";
            this.dgWhIncome.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgWhIncome.Size = new System.Drawing.Size(733, 145);
            this.dgWhIncome.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Оприходование";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Накладная №";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Сотрудник";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Поставщик";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // btnWhIncome
            // 
            this.btnWhIncome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnWhIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnWhIncome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWhIncome.BorderRadius = 4;
            this.btnWhIncome.ButtonText = "Оприходование";
            this.btnWhIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWhIncome.DisabledColor = System.Drawing.Color.Gray;
            this.btnWhIncome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnWhIncome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnWhIncome.Iconimage")));
            this.btnWhIncome.Iconimage_right = null;
            this.btnWhIncome.Iconimage_right_Selected = null;
            this.btnWhIncome.Iconimage_Selected = null;
            this.btnWhIncome.IconMarginLeft = 0;
            this.btnWhIncome.IconMarginRight = 0;
            this.btnWhIncome.IconRightVisible = true;
            this.btnWhIncome.IconRightZoom = 0D;
            this.btnWhIncome.IconVisible = true;
            this.btnWhIncome.IconZoom = 50D;
            this.btnWhIncome.IsTab = false;
            this.btnWhIncome.Location = new System.Drawing.Point(3, 3);
            this.btnWhIncome.Name = "btnWhIncome";
            this.btnWhIncome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnWhIncome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(168)))), ((int)(((byte)(78)))));
            this.btnWhIncome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnWhIncome.selected = false;
            this.btnWhIncome.Size = new System.Drawing.Size(147, 34);
            this.btnWhIncome.TabIndex = 10;
            this.btnWhIncome.Text = "Оприходование";
            this.btnWhIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWhIncome.Textcolor = System.Drawing.Color.White;
            this.btnWhIncome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tbWhIncomeSearch
            // 
            this.tbWhIncomeSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbWhIncomeSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbWhIncomeSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbWhIncomeSearch.HintForeColor = System.Drawing.Color.Empty;
            this.tbWhIncomeSearch.HintText = "        Поиск";
            this.tbWhIncomeSearch.isPassword = false;
            this.tbWhIncomeSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.tbWhIncomeSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.tbWhIncomeSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.tbWhIncomeSearch.LineThickness = 2;
            this.tbWhIncomeSearch.Location = new System.Drawing.Point(261, 4);
            this.tbWhIncomeSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbWhIncomeSearch.Name = "tbWhIncomeSearch";
            this.tbWhIncomeSearch.Size = new System.Drawing.Size(121, 31);
            this.tbWhIncomeSearch.TabIndex = 12;
            this.tbWhIncomeSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnWhIncomeFilter
            // 
            this.btnWhIncomeFilter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(152)))), ((int)(((byte)(253)))));
            this.btnWhIncomeFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnWhIncomeFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWhIncomeFilter.BorderRadius = 7;
            this.btnWhIncomeFilter.ButtonText = "Фильтр";
            this.btnWhIncomeFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWhIncomeFilter.DisabledColor = System.Drawing.Color.Gray;
            this.btnWhIncomeFilter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnWhIncomeFilter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnWhIncomeFilter.Iconimage")));
            this.btnWhIncomeFilter.Iconimage_right = null;
            this.btnWhIncomeFilter.Iconimage_right_Selected = null;
            this.btnWhIncomeFilter.Iconimage_Selected = null;
            this.btnWhIncomeFilter.IconMarginLeft = 0;
            this.btnWhIncomeFilter.IconMarginRight = 0;
            this.btnWhIncomeFilter.IconRightVisible = true;
            this.btnWhIncomeFilter.IconRightZoom = 0D;
            this.btnWhIncomeFilter.IconVisible = true;
            this.btnWhIncomeFilter.IconZoom = 70D;
            this.btnWhIncomeFilter.IsTab = false;
            this.btnWhIncomeFilter.Location = new System.Drawing.Point(156, 3);
            this.btnWhIncomeFilter.Name = "btnWhIncomeFilter";
            this.btnWhIncomeFilter.Normalcolor = System.Drawing.Color.Transparent;
            this.btnWhIncomeFilter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.btnWhIncomeFilter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnWhIncomeFilter.selected = false;
            this.btnWhIncomeFilter.Size = new System.Drawing.Size(98, 32);
            this.btnWhIncomeFilter.TabIndex = 11;
            this.btnWhIncomeFilter.Text = "Фильтр";
            this.btnWhIncomeFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWhIncomeFilter.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.btnWhIncomeFilter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // UCWhIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbWhIncomeSearch);
            this.Controls.Add(this.btnWhIncomeFilter);
            this.Controls.Add(this.btnWhIncome);
            this.Controls.Add(this.dgWhIncome);
            this.Name = "UCWhIncome";
            this.Size = new System.Drawing.Size(739, 191);
            ((System.ComponentModel.ISupportInitialize)(this.dgWhIncome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgWhIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private Bunifu.Framework.UI.BunifuFlatButton btnWhIncome;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbWhIncomeSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnWhIncomeFilter;
    }
}
