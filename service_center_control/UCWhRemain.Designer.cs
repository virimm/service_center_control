namespace service_center_control
{
    partial class UCWhRemain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCWhRemain));
            this.dgWhRemains = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbWhRemainSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnWhRemainFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgWhRemains)).BeginInit();
            this.SuspendLayout();
            // 
            // dgWhRemains
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgWhRemains.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgWhRemains.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgWhRemains.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgWhRemains.BackgroundColor = System.Drawing.Color.White;
            this.dgWhRemains.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgWhRemains.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgWhRemains.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgWhRemains.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgWhRemains.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgWhRemains.DoubleBuffered = true;
            this.dgWhRemains.EnableHeadersVisualStyles = false;
            this.dgWhRemains.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.dgWhRemains.HeaderForeColor = System.Drawing.Color.Black;
            this.dgWhRemains.Location = new System.Drawing.Point(3, 44);
            this.dgWhRemains.Name = "dgWhRemains";
            this.dgWhRemains.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgWhRemains.Size = new System.Drawing.Size(733, 144);
            this.dgWhRemains.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Артикул";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Наименование";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Остаток";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // tbWhRemainSearch
            // 
            this.tbWhRemainSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbWhRemainSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbWhRemainSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbWhRemainSearch.HintForeColor = System.Drawing.Color.Empty;
            this.tbWhRemainSearch.HintText = "        Поиск";
            this.tbWhRemainSearch.isPassword = false;
            this.tbWhRemainSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.tbWhRemainSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.tbWhRemainSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.tbWhRemainSearch.LineThickness = 2;
            this.tbWhRemainSearch.Location = new System.Drawing.Point(108, 3);
            this.tbWhRemainSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbWhRemainSearch.Name = "tbWhRemainSearch";
            this.tbWhRemainSearch.Size = new System.Drawing.Size(121, 31);
            this.tbWhRemainSearch.TabIndex = 10;
            this.tbWhRemainSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnWhRemainFilter
            // 
            this.btnWhRemainFilter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(152)))), ((int)(((byte)(253)))));
            this.btnWhRemainFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnWhRemainFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWhRemainFilter.BorderRadius = 7;
            this.btnWhRemainFilter.ButtonText = "Фильтр";
            this.btnWhRemainFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWhRemainFilter.DisabledColor = System.Drawing.Color.Gray;
            this.btnWhRemainFilter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnWhRemainFilter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnWhRemainFilter.Iconimage")));
            this.btnWhRemainFilter.Iconimage_right = null;
            this.btnWhRemainFilter.Iconimage_right_Selected = null;
            this.btnWhRemainFilter.Iconimage_Selected = null;
            this.btnWhRemainFilter.IconMarginLeft = 0;
            this.btnWhRemainFilter.IconMarginRight = 0;
            this.btnWhRemainFilter.IconRightVisible = true;
            this.btnWhRemainFilter.IconRightZoom = 0D;
            this.btnWhRemainFilter.IconVisible = true;
            this.btnWhRemainFilter.IconZoom = 70D;
            this.btnWhRemainFilter.IsTab = false;
            this.btnWhRemainFilter.Location = new System.Drawing.Point(3, 3);
            this.btnWhRemainFilter.Name = "btnWhRemainFilter";
            this.btnWhRemainFilter.Normalcolor = System.Drawing.Color.Transparent;
            this.btnWhRemainFilter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.btnWhRemainFilter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnWhRemainFilter.selected = false;
            this.btnWhRemainFilter.Size = new System.Drawing.Size(98, 32);
            this.btnWhRemainFilter.TabIndex = 9;
            this.btnWhRemainFilter.Text = "Фильтр";
            this.btnWhRemainFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWhRemainFilter.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.btnWhRemainFilter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // UCWhRemain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbWhRemainSearch);
            this.Controls.Add(this.btnWhRemainFilter);
            this.Controls.Add(this.dgWhRemains);
            this.Name = "UCWhRemain";
            this.Size = new System.Drawing.Size(739, 191);
            ((System.ComponentModel.ISupportInitialize)(this.dgWhRemains)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgWhRemains;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbWhRemainSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnWhRemainFilter;
    }
}
