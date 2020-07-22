using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DabMemo
{
    public partial class frmMainMenu : Form
    {
        #region "初期化処理"
        public frmMainMenu()
        {
            InitializeComponent();
        }
        #endregion

        #region "各ボタン操作"
        #region "メインメニュー：「登録」押下"
        private void btn_MainMenu_regist_Click(object sender, EventArgs e)
        {
            frmRegist frm = new frmRegist();
            frm.Show();
            this.Enabled = false;
        }
        #endregion

        #region "メインメニュー：「更新」押下"
        private void btn_MainMenu_update_Click(object sender, EventArgs e)
        {
            frmUpdate frm = new frmUpdate();
            frm.Show();
            this.Enabled = false;
        }
        #endregion

        #region "メインメニュー」「削除」押下"
        private void btn_MainMenu_delete_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        #region "メインメニュー：「タグ管理」押下"
        private void btn_MainMenu_Tag_Click(object sender, EventArgs e)
        {
            frmTagManager frm = new frmTagManager();
            frm.Show();
            this.Enabled = false;
        }
        #endregion

        #region "メインメニュー：「×」ボタン押下時"
        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rslt = MessageBox.Show("終了しますか？", "終了確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (rslt == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion
        #endregion
    }
}
