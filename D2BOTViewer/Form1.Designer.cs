
namespace D2BOTViewer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_report_list = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cbx_dropNotify = new System.Windows.Forms.CheckBox();
            this.timer_dropNotify = new System.Windows.Forms.Timer(this.components);
            this.txt_lineToken = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report_list)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_report_list
            // 
            this.dgv_report_list.AllowUserToAddRows = false;
            this.dgv_report_list.AllowUserToDeleteRows = false;
            this.dgv_report_list.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_report_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_report_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_report_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_report_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_report_list.Location = new System.Drawing.Point(0, 24);
            this.dgv_report_list.Name = "dgv_report_list";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_report_list.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_report_list.RowHeadersVisible = false;
            this.dgv_report_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_report_list.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_report_list.RowTemplate.Height = 100;
            this.dgv_report_list.Size = new System.Drawing.Size(697, 683);
            this.dgv_report_list.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "時間";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "任務";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "物品";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "能力";
            this.Column5.Name = "Column5";
            this.Column5.Width = 300;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cbx_dropNotify
            // 
            this.cbx_dropNotify.AutoSize = true;
            this.cbx_dropNotify.Location = new System.Drawing.Point(310, 5);
            this.cbx_dropNotify.Name = "cbx_dropNotify";
            this.cbx_dropNotify.Size = new System.Drawing.Size(72, 16);
            this.cbx_dropNotify.TabIndex = 4;
            this.cbx_dropNotify.Text = "掉寶提醒";
            this.cbx_dropNotify.UseVisualStyleBackColor = true;
            this.cbx_dropNotify.CheckedChanged += new System.EventHandler(this.cbx_dropNotify_CheckedChanged);
            // 
            // timer_dropNotify
            // 
            this.timer_dropNotify.Interval = 60000;
            this.timer_dropNotify.Tick += new System.EventHandler(this.timer_dropNotify_Tick);
            // 
            // txt_lineToken
            // 
            this.txt_lineToken.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::D2BOTViewer.Properties.Settings.Default, "txt_lineToken", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_lineToken.Location = new System.Drawing.Point(388, 2);
            this.txt_lineToken.Name = "txt_lineToken";
            this.txt_lineToken.Size = new System.Drawing.Size(309, 22);
            this.txt_lineToken.TabIndex = 5;
            this.txt_lineToken.Text = global::D2BOTViewer.Properties.Settings.Default.txt_lineToken;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 707);
            this.Controls.Add(this.txt_lineToken);
            this.Controls.Add(this.cbx_dropNotify);
            this.Controls.Add(this.dgv_report_list);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "掉寶查詢";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_report_list;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.CheckBox cbx_dropNotify;
        private System.Windows.Forms.Timer timer_dropNotify;
        private System.Windows.Forms.TextBox txt_lineToken;
    }
}

