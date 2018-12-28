using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MemoEditSelectLine
{
    public partial class frmMemoEditTest : DevExpress.XtraEditors.XtraForm
    {
        public frmMemoEditTest()
        {
            InitializeComponent();
        }

        private void frmMemoEditTest_Load(object sender, EventArgs e)
        {
            this.memoEdit1.Text = 
@"AAA
BBB
CCC
DDD
EEE
FFF
GGG
HHH
III
JJJ
KKK
LLL
MMM
NNN
OOO
PPP
";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchText = txtSearch.Text;
            var isContain = memoEdit1.Text.Contains(searchText);

            if (!isContain)
            {
                XtraMessageBox.Show($"沒有找到{searchText}。");
                return;
            }

            memoEdit1.MaskBox.MaskBoxSelectionStart = memoEdit1.Text.IndexOf(searchText);
            memoEdit1.MaskBox.MaskBoxSelectionLength = searchText.Length;
            memoEdit1.ScrollToCaret();
        }
    }
}
