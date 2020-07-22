namespace DabMemo
{
    partial class frmTagManager
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
            this.btn_TagManager_search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckBoxCol = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TagNoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarksCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_TagManager_regist = new System.Windows.Forms.Button();
            this.btn_TagManager_update = new System.Windows.Forms.Button();
            this.btn_TagManager_delete = new System.Windows.Forms.Button();
            this.btn_TagManager_Close = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TagManager_search
            // 
            this.btn_TagManager_search.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.btn_TagManager_search.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_TagManager_search.Location = new System.Drawing.Point(464, 36);
            this.btn_TagManager_search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_TagManager_search.Name = "btn_TagManager_search";
            this.btn_TagManager_search.Size = new System.Drawing.Size(91, 29);
            this.btn_TagManager_search.TabIndex = 14;
            this.btn_TagManager_search.Text = "検索";
            this.btn_TagManager_search.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9.75F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(32, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "検索キーワード";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBoxCol,
            this.TagNoCol,
            this.TagNameCol,
            this.RemarksCol,
            this.RegistCol,
            this.UpdateCol});
            this.dataGridView1.Location = new System.Drawing.Point(37, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(710, 220);
            this.dataGridView1.TabIndex = 15;
            // 
            // CheckBoxCol
            // 
            this.CheckBoxCol.Frozen = true;
            this.CheckBoxCol.HeaderText = "□";
            this.CheckBoxCol.Name = "CheckBoxCol";
            this.CheckBoxCol.Width = 30;
            // 
            // TagNoCol
            // 
            this.TagNoCol.HeaderText = "タグ管理No";
            this.TagNoCol.Name = "TagNoCol";
            // 
            // TagNameCol
            // 
            this.TagNameCol.HeaderText = "タグ名";
            this.TagNameCol.Name = "TagNameCol";
            this.TagNameCol.Width = 180;
            // 
            // RemarksCol
            // 
            this.RemarksCol.HeaderText = "備考";
            this.RemarksCol.Name = "RemarksCol";
            this.RemarksCol.Width = 150;
            // 
            // RegistCol
            // 
            this.RegistCol.HeaderText = "登録日時";
            this.RegistCol.Name = "RegistCol";
            // 
            // UpdateCol
            // 
            this.UpdateCol.HeaderText = "更新日時";
            this.UpdateCol.Name = "UpdateCol";
            // 
            // btn_TagManager_regist
            // 
            this.btn_TagManager_regist.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_TagManager_regist.Location = new System.Drawing.Point(37, 386);
            this.btn_TagManager_regist.Name = "btn_TagManager_regist";
            this.btn_TagManager_regist.Size = new System.Drawing.Size(109, 31);
            this.btn_TagManager_regist.TabIndex = 16;
            this.btn_TagManager_regist.Text = "登録";
            this.btn_TagManager_regist.UseVisualStyleBackColor = true;
            // 
            // btn_TagManager_update
            // 
            this.btn_TagManager_update.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_TagManager_update.Location = new System.Drawing.Point(184, 386);
            this.btn_TagManager_update.Name = "btn_TagManager_update";
            this.btn_TagManager_update.Size = new System.Drawing.Size(109, 31);
            this.btn_TagManager_update.TabIndex = 17;
            this.btn_TagManager_update.Text = "更新";
            this.btn_TagManager_update.UseVisualStyleBackColor = true;
            // 
            // btn_TagManager_delete
            // 
            this.btn_TagManager_delete.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_TagManager_delete.Location = new System.Drawing.Point(331, 386);
            this.btn_TagManager_delete.Name = "btn_TagManager_delete";
            this.btn_TagManager_delete.Size = new System.Drawing.Size(109, 31);
            this.btn_TagManager_delete.TabIndex = 18;
            this.btn_TagManager_delete.Text = "削除";
            this.btn_TagManager_delete.UseVisualStyleBackColor = true;
            // 
            // btn_TagManager_Close
            // 
            this.btn_TagManager_Close.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_TagManager_Close.Location = new System.Drawing.Point(638, 386);
            this.btn_TagManager_Close.Name = "btn_TagManager_Close";
            this.btn_TagManager_Close.Size = new System.Drawing.Size(109, 31);
            this.btn_TagManager_Close.TabIndex = 19;
            this.btn_TagManager_Close.Text = "閉じる";
            this.btn_TagManager_Close.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 19);
            this.textBox1.TabIndex = 20;
            // 
            // frmTagManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_TagManager_Close);
            this.Controls.Add(this.btn_TagManager_delete);
            this.Controls.Add(this.btn_TagManager_update);
            this.Controls.Add(this.btn_TagManager_regist);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_TagManager_search);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTagManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "タグ管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TagManager_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBoxCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagNoCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemarksCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateCol;
        private System.Windows.Forms.Button btn_TagManager_regist;
        private System.Windows.Forms.Button btn_TagManager_update;
        private System.Windows.Forms.Button btn_TagManager_delete;
        private System.Windows.Forms.Button btn_TagManager_Close;
        private System.Windows.Forms.TextBox textBox1;
    }
}