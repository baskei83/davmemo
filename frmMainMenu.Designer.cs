namespace DabMemo
{
    partial class frmMainMenu
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckBoxCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TagCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PayerCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProductNameCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.AmountOfMoneyCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MethodOfPaymentCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NumberOfPaymentsCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RemarksCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_MainMenu_Tag = new System.Windows.Forms.ComboBox();
            this.cmb_MainMenu_ProductName = new System.Windows.Forms.ComboBox();
            this.cmb_MainMenu_MethodOfPayment = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxCol,
            this.TagCol,
            this.PayerCol,
            this.ProductNameCol,
            this.AmountOfMoneyCol,
            this.MethodOfPaymentCol,
            this.NumberOfPaymentsCol,
            this.RemarksCol});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            // 
            // CheckBoxCol
            // 
            this.CheckBoxCol.Frozen = true;
            resources.ApplyResources(this.CheckBoxCol, "CheckBoxCol");
            this.CheckBoxCol.Name = "CheckBoxCol";
            // 
            // TagCol
            // 
            resources.ApplyResources(this.TagCol, "TagCol");
            this.TagCol.Name = "TagCol";
            // 
            // PayerCol
            // 
            resources.ApplyResources(this.PayerCol, "PayerCol");
            this.PayerCol.Name = "PayerCol";
            // 
            // ProductNameCol
            // 
            resources.ApplyResources(this.ProductNameCol, "ProductNameCol");
            this.ProductNameCol.Name = "ProductNameCol";
            // 
            // AmountOfMoneyCol
            // 
            resources.ApplyResources(this.AmountOfMoneyCol, "AmountOfMoneyCol");
            this.AmountOfMoneyCol.Name = "AmountOfMoneyCol";
            // 
            // MethodOfPaymentCol
            // 
            resources.ApplyResources(this.MethodOfPaymentCol, "MethodOfPaymentCol");
            this.MethodOfPaymentCol.Name = "MethodOfPaymentCol";
            // 
            // NumberOfPaymentsCol
            // 
            resources.ApplyResources(this.NumberOfPaymentsCol, "NumberOfPaymentsCol");
            this.NumberOfPaymentsCol.Name = "NumberOfPaymentsCol";
            // 
            // RemarksCol
            // 
            resources.ApplyResources(this.RemarksCol, "RemarksCol");
            this.RemarksCol.Name = "RemarksCol";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cmb_MainMenu_Tag
            // 
            this.cmb_MainMenu_Tag.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_MainMenu_Tag, "cmb_MainMenu_Tag");
            this.cmb_MainMenu_Tag.Name = "cmb_MainMenu_Tag";
            // 
            // cmb_MainMenu_ProductName
            // 
            this.cmb_MainMenu_ProductName.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_MainMenu_ProductName, "cmb_MainMenu_ProductName");
            this.cmb_MainMenu_ProductName.Name = "cmb_MainMenu_ProductName";
            // 
            // cmb_MainMenu_MethodOfPayment
            // 
            this.cmb_MainMenu_MethodOfPayment.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_MainMenu_MethodOfPayment, "cmb_MainMenu_MethodOfPayment");
            this.cmb_MainMenu_MethodOfPayment.Name = "cmb_MainMenu_MethodOfPayment";
            // 
            // frmMainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmb_MainMenu_MethodOfPayment);
            this.Controls.Add(this.cmb_MainMenu_ProductName);
            this.Controls.Add(this.cmb_MainMenu_Tag);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn TagCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn PayerCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProductNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountOfMoneyCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn MethodOfPaymentCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn NumberOfPaymentsCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemarksCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_MainMenu_Tag;
        private System.Windows.Forms.ComboBox cmb_MainMenu_ProductName;
        private System.Windows.Forms.ComboBox cmb_MainMenu_MethodOfPayment;
    }
}

