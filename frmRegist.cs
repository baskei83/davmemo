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
    public partial class frmRegist : Form
    {
        public frmRegist()
        {
            InitializeComponent();
        }

        #region "「閉じる」押下"
        private void btn_Regist_Close_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMainMenu frm = new frmMainMenu();
            frm.Enabled = true;
            frm.Show();
        }
        #endregion
    }
}
