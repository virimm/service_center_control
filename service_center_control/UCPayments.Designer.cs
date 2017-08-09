namespace service_center_control
{
    partial class UCPayments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPayments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLeft = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnPayIn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblPaymentsQ = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPaymentsTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelRight = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tbPaymentsSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnPaymentsFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgPayments = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnPayOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeft.BackgroundImage")));
            this.panelLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelLeft.Controls.Add(this.btnPayOut);
            this.panelLeft.Controls.Add(this.btnPayIn);
            this.panelLeft.Controls.Add(this.lblPaymentsQ);
            this.panelLeft.Controls.Add(this.lblPaymentsTitle);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.GradientBottomLeft = System.Drawing.Color.White;
            this.panelLeft.GradientBottomRight = System.Drawing.Color.White;
            this.panelLeft.GradientTopLeft = System.Drawing.Color.White;
            this.panelLeft.GradientTopRight = System.Drawing.Color.White;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Quality = 10;
            this.panelLeft.Size = new System.Drawing.Size(200, 232);
            this.panelLeft.TabIndex = 0;
            // 
            // btnPayIn
            // 
            this.btnPayIn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPayIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnPayIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayIn.BorderRadius = 4;
            this.btnPayIn.ButtonText = "Приход";
            this.btnPayIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayIn.DisabledColor = System.Drawing.Color.Gray;
            this.btnPayIn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPayIn.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPayIn.Iconimage")));
            this.btnPayIn.Iconimage_right = null;
            this.btnPayIn.Iconimage_right_Selected = null;
            this.btnPayIn.Iconimage_Selected = null;
            this.btnPayIn.IconMarginLeft = 0;
            this.btnPayIn.IconMarginRight = 0;
            this.btnPayIn.IconRightVisible = true;
            this.btnPayIn.IconRightZoom = 0D;
            this.btnPayIn.IconVisible = true;
            this.btnPayIn.IconZoom = 50D;
            this.btnPayIn.IsTab = false;
            this.btnPayIn.Location = new System.Drawing.Point(8, 93);
            this.btnPayIn.Name = "btnPayIn";
            this.btnPayIn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnPayIn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(168)))), ((int)(((byte)(78)))));
            this.btnPayIn.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPayIn.selected = false;
            this.btnPayIn.Size = new System.Drawing.Size(90, 34);
            this.btnPayIn.TabIndex = 2;
            this.btnPayIn.Text = "Приход";
            this.btnPayIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayIn.Textcolor = System.Drawing.Color.White;
            this.btnPayIn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblPaymentsQ
            // 
            this.lblPaymentsQ.AutoSize = true;
            this.lblPaymentsQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPaymentsQ.Location = new System.Drawing.Point(71, 39);
            this.lblPaymentsQ.Name = "lblPaymentsQ";
            this.lblPaymentsQ.Size = new System.Drawing.Size(60, 20);
            this.lblPaymentsQ.TabIndex = 1;
            this.lblPaymentsQ.Text = "22 грн.";
            // 
            // lblPaymentsTitle
            // 
            this.lblPaymentsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentsTitle.AutoSize = true;
            this.lblPaymentsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPaymentsTitle.Location = new System.Drawing.Point(69, 4);
            this.lblPaymentsTitle.Name = "lblPaymentsTitle";
            this.lblPaymentsTitle.Size = new System.Drawing.Size(62, 24);
            this.lblPaymentsTitle.TabIndex = 0;
            this.lblPaymentsTitle.Text = "Касса";
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRight.BackgroundImage")));
            this.panelRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelRight.Controls.Add(this.tbPaymentsSearch);
            this.panelRight.Controls.Add(this.btnPaymentsFilter);
            this.panelRight.Controls.Add(this.dgPayments);
            this.panelRight.GradientBottomLeft = System.Drawing.Color.White;
            this.panelRight.GradientBottomRight = System.Drawing.Color.White;
            this.panelRight.GradientTopLeft = System.Drawing.Color.White;
            this.panelRight.GradientTopRight = System.Drawing.Color.White;
            this.panelRight.Location = new System.Drawing.Point(206, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Quality = 10;
            this.panelRight.Size = new System.Drawing.Size(539, 232);
            this.panelRight.TabIndex = 1;
            // 
            // tbPaymentsSearch
            // 
            this.tbPaymentsSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPaymentsSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPaymentsSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPaymentsSearch.HintForeColor = System.Drawing.Color.Empty;
            this.tbPaymentsSearch.HintText = "        Поиск";
            this.tbPaymentsSearch.isPassword = false;
            this.tbPaymentsSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.tbPaymentsSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.tbPaymentsSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.tbPaymentsSearch.LineThickness = 2;
            this.tbPaymentsSearch.Location = new System.Drawing.Point(108, 4);
            this.tbPaymentsSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbPaymentsSearch.Name = "tbPaymentsSearch";
            this.tbPaymentsSearch.Size = new System.Drawing.Size(121, 31);
            this.tbPaymentsSearch.TabIndex = 4;
            this.tbPaymentsSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnPaymentsFilter
            // 
            this.btnPaymentsFilter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(152)))), ((int)(((byte)(253)))));
            this.btnPaymentsFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnPaymentsFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPaymentsFilter.BorderRadius = 7;
            this.btnPaymentsFilter.ButtonText = "Фильтр";
            this.btnPaymentsFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaymentsFilter.DisabledColor = System.Drawing.Color.Gray;
            this.btnPaymentsFilter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPaymentsFilter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPaymentsFilter.Iconimage")));
            this.btnPaymentsFilter.Iconimage_right = null;
            this.btnPaymentsFilter.Iconimage_right_Selected = null;
            this.btnPaymentsFilter.Iconimage_Selected = null;
            this.btnPaymentsFilter.IconMarginLeft = 0;
            this.btnPaymentsFilter.IconMarginRight = 0;
            this.btnPaymentsFilter.IconRightVisible = true;
            this.btnPaymentsFilter.IconRightZoom = 0D;
            this.btnPaymentsFilter.IconVisible = true;
            this.btnPaymentsFilter.IconZoom = 70D;
            this.btnPaymentsFilter.IsTab = false;
            this.btnPaymentsFilter.Location = new System.Drawing.Point(3, 4);
            this.btnPaymentsFilter.Name = "btnPaymentsFilter";
            this.btnPaymentsFilter.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPaymentsFilter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.btnPaymentsFilter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPaymentsFilter.selected = false;
            this.btnPaymentsFilter.Size = new System.Drawing.Size(98, 32);
            this.btnPaymentsFilter.TabIndex = 3;
            this.btnPaymentsFilter.Text = "Фильтр";
            this.btnPaymentsFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPaymentsFilter.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.btnPaymentsFilter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dgPayments
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPayments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgPayments.DoubleBuffered = true;
            this.dgPayments.EnableHeadersVisualStyles = false;
            this.dgPayments.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.dgPayments.HeaderForeColor = System.Drawing.Color.Black;
            this.dgPayments.Location = new System.Drawing.Point(0, 39);
            this.dgPayments.Name = "dgPayments";
            this.dgPayments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgPayments.Size = new System.Drawing.Size(536, 190);
            this.dgPayments.TabIndex = 2;
            // 
            // btnPayOut
            // 
            this.btnPayOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPayOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(79)))), ((int)(((byte)(71)))));
            this.btnPayOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayOut.BorderRadius = 4;
            this.btnPayOut.ButtonText = "Расход";
            this.btnPayOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnPayOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPayOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPayOut.Iconimage")));
            this.btnPayOut.Iconimage_right = null;
            this.btnPayOut.Iconimage_right_Selected = null;
            this.btnPayOut.Iconimage_Selected = null;
            this.btnPayOut.IconMarginLeft = 0;
            this.btnPayOut.IconMarginRight = 0;
            this.btnPayOut.IconRightVisible = true;
            this.btnPayOut.IconRightZoom = 0D;
            this.btnPayOut.IconVisible = true;
            this.btnPayOut.IconZoom = 50D;
            this.btnPayOut.IsTab = false;
            this.btnPayOut.Location = new System.Drawing.Point(103, 93);
            this.btnPayOut.Name = "btnPayOut";
            this.btnPayOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(79)))), ((int)(((byte)(71)))));
            this.btnPayOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnPayOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPayOut.selected = false;
            this.btnPayOut.Size = new System.Drawing.Size(90, 34);
            this.btnPayOut.TabIndex = 2;
            this.btnPayOut.Text = "Расход";
            this.btnPayOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayOut.Textcolor = System.Drawing.Color.White;
            this.btnPayOut.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Создано";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Клиент";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Комментарий";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 75F;
            this.Column4.HeaderText = "Приход";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 75F;
            this.Column5.HeaderText = "Расход";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.FillWeight = 75F;
            this.Column6.HeaderText = "Остаток";
            this.Column6.Name = "Column6";
            // 
            // UCPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Name = "UCPayments";
            this.Size = new System.Drawing.Size(745, 232);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel panelLeft;
        private Bunifu.Framework.UI.BunifuGradientPanel panelRight;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgPayments;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPaymentsQ;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPaymentsTitle;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPaymentsSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnPaymentsFilter;
        private Bunifu.Framework.UI.BunifuFlatButton btnPayIn;
        private Bunifu.Framework.UI.BunifuFlatButton btnPayOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}
