namespace DabMemo
{
    partial class frmTagManagerUpdate
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
            this.btn_TagManager_regist = new System.Windows.Forms.Button();
            this.btn_TagManager_close = new System.Windows.Forms.Button();
            this.txt_TagManagerUpdate_remarks = new System.Windows.Forms.TextBox();
            this.txt_TagManagerUpdate_regist = new System.Windows.Forms.TextBox();
            this.lbl_TagManagerUpdate_remarks = new System.Windows.Forms.Label();
            this.lbl_TagManagerUpdate_update = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_TagManager_regist
            // 
            this.btn_TagManager_regist.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_TagManager_regist.Location = new System.Drawing.Point(348, 251);
            this.btn_TagManager_regist.Name = "btn_TagManager_regist";
            this.btn_TagManager_regist.Size = new System.Drawing.Size(85, 29);
            this.btn_TagManager_regist.TabIndex = 11;
            this.btn_TagManager_regist.Text = "更新";
            this.btn_TagManager_regist.UseVisualStyleBackColor = true;
            // 
            // btn_TagManager_close
            // 
            this.btn_TagManager_close.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_TagManager_close.Location = new System.Drawing.Point(243, 251);
            this.btn_TagManager_close.Name = "btn_TagManager_close";
            this.btn_TagManager_close.Size = new System.Drawing.Size(85, 29);
            this.btn_TagManager_close.TabIndex = 10;
            this.btn_TagManager_close.Text = "閉じる";
            this.btn_TagManager_close.UseVisualStyleBackColor = true;
            // 
            // txt_TagManagerUpdate_remarks
            // 
            this.txt_TagManagerUpdate_remarks.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_TagManagerUpdate_remarks.Location = new System.Drawing.Point(114, 182);
            this.txt_TagManagerUpdate_remarks.Name = "txt_TagManagerUpdate_remarks";
            this.txt_TagManagerUpdate_remarks.Size = new System.Drawing.Size(319, 27);
            this.txt_TagManagerUpdate_remarks.TabIndex = 9;
            // 
            // txt_TagManagerUpdate_regist
            // 
            this.txt_TagManagerUpdate_regist.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_TagManagerUpdate_regist.Location = new System.Drawing.Point(114, 77);
            this.txt_TagManagerUpdate_regist.Name = "txt_TagManagerUpdate_regist";
            this.txt_TagManagerUpdate_regist.Size = new System.Drawing.Size(319, 27);
            this.txt_TagManagerUpdate_regist.TabIndex = 8;
            // 
            // lbl_TagManagerUpdate_remarks
            // 
            this.lbl_TagManagerUpdate_remarks.AutoSize = true;
            this.lbl_TagManagerUpdate_remarks.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TagManagerUpdate_remarks.Location = new System.Drawing.Point(49, 185);
            this.lbl_TagManagerUpdate_remarks.Name = "lbl_TagManagerUpdate_remarks";
            this.lbl_TagManagerUpdate_remarks.Size = new System.Drawing.Size(48, 20);
            this.lbl_TagManagerUpdate_remarks.TabIndex = 7;
            this.lbl_TagManagerUpdate_remarks.Text = "備考：";
            // 
            // lbl_TagManagerUpdate_update
            // 
            this.lbl_TagManagerUpdate_update.AutoSize = true;
            this.lbl_TagManagerUpdate_update.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TagManagerUpdate_update.Location = new System.Drawing.Point(39, 79);
            this.lbl_TagManagerUpdate_update.Name = "lbl_TagManagerUpdate_update";
            this.lbl_TagManagerUpdate_update.Size = new System.Drawing.Size(61, 20);
            this.lbl_TagManagerUpdate_update.TabIndex = 6;
            this.lbl_TagManagerUpdate_update.Text = "タグ名：";
            // 
            // frmTagManagerUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 317);
            this.Controls.Add(this.btn_TagManager_regist);
            this.Controls.Add(this.btn_TagManager_close);
            this.Controls.Add(this.txt_TagManagerUpdate_remarks);
            this.Controls.Add(this.txt_TagManagerUpdate_regist);
            this.Controls.Add(this.lbl_TagManagerUpdate_remarks);
            this.Controls.Add(this.lbl_TagManagerUpdate_update);
            this.Name = "frmTagManagerUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "タグ管理画面 - 更新";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TagManager_regist;
        private System.Windows.Forms.Button btn_TagManager_close;
        private System.Windows.Forms.TextBox txt_TagManagerUpdate_remarks;
        private System.Windows.Forms.TextBox txt_TagManagerUpdate_regist;
        private System.Windows.Forms.Label lbl_TagManagerUpdate_remarks;
        private System.Windows.Forms.Label lbl_TagManagerUpdate_update;
    }
}