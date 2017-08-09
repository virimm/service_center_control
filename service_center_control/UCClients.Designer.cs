namespace service_center_control
{
    partial class UCClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCClients));
            this.tbClientsSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgClients = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonNewClient = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientsFilter = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).BeginInit();
            this.SuspendLayout();
            // 
            // tbClientsSearch
            // 
            this.tbClientsSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbClientsSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbClientsSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbClientsSearch.HintForeColor = System.Drawing.Color.Empty;
            this.tbClientsSearch.HintText = "        Поиск";
            this.tbClientsSearch.isPassword = false;
            this.tbClientsSearch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.tbClientsSearch.LineIdleColor = System.Drawing.Color.Gray;
            this.tbClientsSearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.tbClientsSearch.LineThickness = 2;
            this.tbClientsSearch.Location = new System.Drawing.Point(261, 7);
            this.tbClientsSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbClientsSearch.Name = "tbClientsSearch";
            this.tbClientsSearch.Size = new System.Drawing.Size(134, 35);
            this.tbClientsSearch.TabIndex = 6;
            this.tbClientsSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgClients
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClients.BackgroundColor = System.Drawing.Color.White;
            this.dgClients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5});
            this.dgClients.DoubleBuffered = true;
            this.dgClients.EnableHeadersVisualStyles = false;
            this.dgClients.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.dgClients.HeaderForeColor = System.Drawing.Color.Black;
            this.dgClients.Location = new System.Drawing.Point(3, 51);
            this.dgClients.Name = "dgClients";
            this.dgClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgClients.Size = new System.Drawing.Size(739, 178);
            this.dgClients.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Телефон";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Адрес";
            this.Column4.Name = "Column4";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Email";
            this.Column6.Name = "Column6";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Примечание";
            this.Column5.Name = "Column5";
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(152)))), ((int)(((byte)(253)))));
            this.buttonNewClient.BackColor = System.Drawing.Color.Transparent;
            this.buttonNewClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonNewClient.BorderRadius = 7;
            this.buttonNewClient.ButtonText = "Новый  клиент";
            this.buttonNewClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNewClient.DisabledColor = System.Drawing.Color.Gray;
            this.buttonNewClient.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonNewClient.Iconimage = ((System.Drawing.Image)(resources.GetObject("buttonNewClient.Iconimage")));
            this.buttonNewClient.Iconimage_right = null;
            this.buttonNewClient.Iconimage_right_Selected = null;
            this.buttonNewClient.Iconimage_Selected = null;
            this.buttonNewClient.IconMarginLeft = 0;
            this.buttonNewClient.IconMarginRight = 0;
            this.buttonNewClient.IconRightVisible = true;
            this.buttonNewClient.IconRightZoom = 0D;
            this.buttonNewClient.IconVisible = true;
            this.buttonNewClient.IconZoom = 80D;
            this.buttonNewClient.IsTab = false;
            this.buttonNewClient.Location = new System.Drawing.Point(3, 3);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Normalcolor = System.Drawing.Color.Transparent;
            this.buttonNewClient.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.buttonNewClient.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonNewClient.selected = false;
            this.buttonNewClient.Size = new System.Drawing.Size(123, 42);
            this.buttonNewClient.TabIndex = 3;
            this.buttonNewClient.Text = "Новый  клиент";
            this.buttonNewClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonNewClient.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.buttonNewClient.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnClientsFilter
            // 
            this.btnClientsFilter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(152)))), ((int)(((byte)(253)))));
            this.btnClientsFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnClientsFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientsFilter.BorderRadius = 7;
            this.btnClientsFilter.ButtonText = "Фильтр";
            this.btnClientsFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientsFilter.DisabledColor = System.Drawing.Color.Gray;
            this.btnClientsFilter.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClientsFilter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClientsFilter.Iconimage")));
            this.btnClientsFilter.Iconimage_right = null;
            this.btnClientsFilter.Iconimage_right_Selected = null;
            this.btnClientsFilter.Iconimage_Selected = null;
            this.btnClientsFilter.IconMarginLeft = 0;
            this.btnClientsFilter.IconMarginRight = 0;
            this.btnClientsFilter.IconRightVisible = true;
            this.btnClientsFilter.IconRightZoom = 0D;
            this.btnClientsFilter.IconVisible = true;
            this.btnClientsFilter.IconZoom = 80D;
            this.btnClientsFilter.IsTab = false;
            this.btnClientsFilter.Location = new System.Drawing.Point(132, 3);
            this.btnClientsFilter.Name = "btnClientsFilter";
            this.btnClientsFilter.Normalcolor = System.Drawing.Color.Transparent;
            this.btnClientsFilter.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(218)))), ((int)(((byte)(248)))));
            this.btnClientsFilter.OnHoverTextColor = System.Drawing.Color.White;
            this.btnClientsFilter.selected = false;
            this.btnClientsFilter.Size = new System.Drawing.Size(123, 42);
            this.btnClientsFilter.TabIndex = 4;
            this.btnClientsFilter.Text = "Фильтр";
            this.btnClientsFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientsFilter.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(108)))), ((int)(((byte)(107)))));
            this.btnClientsFilter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // UCClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tbClientsSearch);
            this.Controls.Add(this.dgClients);
            this.Controls.Add(this.buttonNewClient);
            this.Controls.Add(this.btnClientsFilter);
            this.Name = "UCClients";
            this.Size = new System.Drawing.Size(745, 232);
            ((System.ComponentModel.ISupportInitialize)(this.dgClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox tbClientsSearch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgClients;
        private Bunifu.Framework.UI.BunifuFlatButton buttonNewClient;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientsFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
