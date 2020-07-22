namespace DabMemo
{
    partial class frmRegist
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Regist_TagName = new System.Windows.Forms.ComboBox();
            this.cmb_Regist_Payer = new System.Windows.Forms.ComboBox();
            this.cmb_Update_PaymentMethod = new System.Windows.Forms.ComboBox();
            this.txt_Regist_ProductName = new System.Windows.Forms.TextBox();
            this.txt_Regist_Payment = new System.Windows.Forms.TextBox();
            this.txt_Regist_NumberOfPayments = new System.Windows.Forms.TextBox();
            this.txt_Regist_Remarks = new System.Windows.Forms.TextBox();
            this.btn_Regist_Close = new System.Windows.Forms.Button();
            this.btn_Regist_Regist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(88, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "タグ名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(88, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "支払者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(88, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "品名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(88, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "使用金額：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(88, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "支払方法：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(88, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "支払回数：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(88, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "備考：";
            // 
            // cmb_Regist_TagName
            // 
            this.cmb_Regist_TagName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Regist_TagName.FormattingEnabled = true;
            this.cmb_Regist_TagName.Location = new System.Drawing.Point(177, 45);
            this.cmb_Regist_TagName.Name = "cmb_Regist_TagName";
            this.cmb_Regist_TagName.Size = new System.Drawing.Size(173, 20);
            this.cmb_Regist_TagName.TabIndex = 7;
            // 
            // cmb_Regist_Payer
            // 
            this.cmb_Regist_Payer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Regist_Payer.FormattingEnabled = true;
            this.cmb_Regist_Payer.Location = new System.Drawing.Point(177, 86);
            this.cmb_Regist_Payer.Name = "cmb_Regist_Payer";
            this.cmb_Regist_Payer.Size = new System.Drawing.Size(245, 20);
            this.cmb_Regist_Payer.TabIndex = 8;
            // 
            // cmb_Update_PaymentMethod
            // 
            this.cmb_Update_PaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Update_PaymentMethod.FormattingEnabled = true;
            this.cmb_Update_PaymentMethod.Location = new System.Drawing.Point(177, 206);
            this.cmb_Update_PaymentMethod.Name = "cmb_Update_PaymentMethod";
            this.cmb_Update_PaymentMethod.Size = new System.Drawing.Size(245, 20);
            this.cmb_Update_PaymentMethod.TabIndex = 9;
            // 
            // txt_Regist_ProductName
            // 
            this.txt_Regist_ProductName.Location = new System.Drawing.Point(177, 126);
            this.txt_Regist_ProductName.Name = "txt_Regist_ProductName";
            this.txt_Regist_ProductName.Size = new System.Drawing.Size(245, 19);
            this.txt_Regist_ProductName.TabIndex = 10;
            // 
            // txt_Regist_Payment
            // 
            this.txt_Regist_Payment.Location = new System.Drawing.Point(177, 166);
            this.txt_Regist_Payment.Name = "txt_Regist_Payment";
            this.txt_Regist_Payment.Size = new System.Drawing.Size(245, 19);
            this.txt_Regist_Payment.TabIndex = 11;
            // 
            // txt_Regist_NumberOfPayments
            // 
            this.txt_Regist_NumberOfPayments.Location = new System.Drawing.Point(177, 245);
            this.txt_Regist_NumberOfPayments.Name = "txt_Regist_NumberOfPayments";
            this.txt_Regist_NumberOfPayments.Size = new System.Drawing.Size(173, 19);
            this.txt_Regist_NumberOfPayments.TabIndex = 12;
            // 
            // txt_Regist_Remarks
            // 
            this.txt_Regist_Remarks.Location = new System.Drawing.Point(177, 286);
            this.txt_Regist_Remarks.Name = "txt_Regist_Remarks";
            this.txt_Regist_Remarks.Size = new System.Drawing.Size(245, 19);
            this.txt_Regist_Remarks.TabIndex = 13;
            // 
            // btn_Regist_Close
            // 
            this.btn_Regist_Close.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Regist_Close.Location = new System.Drawing.Point(350, 341);
            this.btn_Regist_Close.Name = "btn_Regist_Close";
            this.btn_Regist_Close.Size = new System.Drawing.Size(89, 30);
            this.btn_Regist_Close.TabIndex = 14;
            this.btn_Regist_Close.Text = "閉じる";
            this.btn_Regist_Close.UseVisualStyleBackColor = true;
            this.btn_Regist_Close.Click += new System.EventHandler(this.btn_Regist_Close_Click);
            // 
            // btn_Regist_Regist
            // 
            this.btn_Regist_Regist.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_Regist_Regist.Location = new System.Drawing.Point(456, 341);
            this.btn_Regist_Regist.Name = "btn_Regist_Regist";
            this.btn_Regist_Regist.Size = new System.Drawing.Size(89, 30);
            this.btn_Regist_Regist.TabIndex = 15;
            this.btn_Regist_Regist.Text = "登録";
            this.btn_Regist_Regist.UseVisualStyleBackColor = true;
            // 
            // frmRegist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(557, 394);
            this.Controls.Add(this.btn_Regist_Regist);
            this.Controls.Add(this.btn_Regist_Close);
            this.Controls.Add(this.txt_Regist_Remarks);
            this.Controls.Add(this.txt_Regist_NumberOfPayments);
            this.Controls.Add(this.txt_Regist_Payment);
            this.Controls.Add(this.txt_Regist_ProductName);
            this.Controls.Add(this.cmb_Update_PaymentMethod);
            this.Controls.Add(this.cmb_Regist_Payer);
            this.Controls.Add(this.cmb_Regist_TagName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRegist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登録画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Regist_TagName;
        private System.Windows.Forms.ComboBox cmb_Regist_Payer;
        private System.Windows.Forms.ComboBox cmb_Update_PaymentMethod;
        private System.Windows.Forms.TextBox txt_Regist_ProductName;
        private System.Windows.Forms.TextBox txt_Regist_Payment;
        private System.Windows.Forms.TextBox txt_Regist_NumberOfPayments;
        private System.Windows.Forms.TextBox txt_Regist_Remarks;
        private System.Windows.Forms.Button btn_Regist_Close;
        private System.Windows.Forms.Button btn_Regist_Regist;
    }
}