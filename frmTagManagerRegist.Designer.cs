namespace DabMemo
{
    partial class frmTagManagerRegist
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
            this.lbl_TagManagerRegist_regist = new System.Windows.Forms.Label();
            this.lbl_TagManagerRegist_remarks = new System.Windows.Forms.Label();
            this.txt_TagManagerRegist_regist = new System.Windows.Forms.TextBox();
            this.txt_TagManagerRegist_remarks = new System.Windows.Forms.TextBox();
            this.btn_TagManager_close = new System.Windows.Forms.Button();
            this.btn_TagManager_regist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_TagManagerRegist_regist
            // 
            this.lbl_TagManagerRegist_regist.AutoSize = true;
            this.lbl_TagManagerRegist_regist.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TagManagerRegist_regist.Location = new System.Drawing.Point(38, 80);
            this.lbl_TagManagerRegist_regist.Name = "lbl_TagManagerRegist_regist";
            this.lbl_TagManagerRegist_regist.Size = new System.Drawing.Size(61, 20);
            this.lbl_TagManagerRegist_regist.TabIndex = 0;
            this.lbl_TagManagerRegist_regist.Text = "タグ名：";
            // 
            // lbl_TagManagerRegist_remarks
            // 
            this.lbl_TagManagerRegist_remarks.AutoSize = true;
            this.lbl_TagManagerRegist_remarks.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_TagManagerRegist_remarks.Location = new System.Drawing.Point(49, 185);
            this.lbl_TagManagerRegist_remarks.Name = "lbl_TagManagerRegist_remarks";
            this.lbl_TagManagerRegist_remarks.Size = new System.Drawing.Size(48, 20);
            this.lbl_TagManagerRegist_remarks.TabIndex = 1;
            this.lbl_TagManagerRegist_remarks.Text = "備考：";
            // 
            // txt_TagManagerRegist_regist
            // 
            this.txt_TagManagerRegist_regist.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_TagManagerRegist_regist.Location = new System.Drawing.Point(114, 77);
            this.txt_TagManagerRegist_regist.Name = "txt_TagManagerRegist_regist";
            this.txt_TagManagerRegist_regist.Size = new System.Drawing.Size(319, 27);
            this.txt_TagManagerRegist_regist.TabIndex = 2;
            // 
            // txt_TagManagerRegist_remarks
            // 
            this.txt_TagManagerRegist_remarks.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt_TagManagerRegist_remarks.Location = new System.Drawing.Point(114, 182);
            this.txt_TagManagerRegist_remarks.Name = "txt_TagManagerRegist_remarks";
            this.txt_TagManagerRegist_remarks.Size = new System.Drawing.Size(319, 27);
            this.txt_TagManagerRegist_remarks.TabIndex = 3;
            // 
            // btn_TagManager_close
            // 
            this.btn_TagManager_close.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_TagManager_close.Location = new System.Drawing.Point(243, 251);
            this.btn_TagManager_close.Name = "btn_TagManager_close";
            this.btn_TagManager_close.Size = new System.Drawing.Size(85, 29);
            this.btn_TagManager_close.TabIndex = 4;
            this.btn_TagManager_close.Text = "閉じる";
            this.btn_TagManager_close.UseVisualStyleBackColor = true;
            // 
            // btn_TagManager_regist
            // 
            this.btn_TagManager_regist.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_TagManager_regist.Location = new System.Drawing.Point(348, 251);
            this.btn_TagManager_regist.Name = "btn_TagManager_regist";
            this.btn_TagManager_regist.Size = new System.Drawing.Size(85, 29);
            this.btn_TagManager_regist.TabIndex = 5;
            this.btn_TagManager_regist.Text = "登録";
            this.btn_TagManager_regist.UseVisualStyleBackColor = true;
            // 
            // frmTagManagerRegist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 317);
            this.Controls.Add(this.btn_TagManager_regist);
            this.Controls.Add(this.btn_TagManager_close);
            this.Controls.Add(this.txt_TagManagerRegist_remarks);
            this.Controls.Add(this.txt_TagManagerRegist_regist);
            this.Controls.Add(this.lbl_TagManagerRegist_remarks);
            this.Controls.Add(this.lbl_TagManagerRegist_regist);
            this.Name = "frmTagManagerRegist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "タグ管理画面 - 登録";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TagManagerRegist_regist;
        private System.Windows.Forms.Label lbl_TagManagerRegist_remarks;
        private System.Windows.Forms.TextBox txt_TagManagerRegist_regist;
        private System.Windows.Forms.TextBox txt_TagManagerRegist_remarks;
        private System.Windows.Forms.Button btn_TagManager_close;
        private System.Windows.Forms.Button btn_TagManager_regist;
    }
}