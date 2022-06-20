using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berverage_Manager.GUI
{
    public partial class frmConfirmCode : Form
    {
        private int code;
        private string eMailNhanVien;
        public frmConfirmCode(string emailNV, int maXacMinh)
        {
            eMailNhanVien = emailNV;
            code = maXacMinh;
            InitializeComponent();
        }



        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            if(txtMaXacMinh.Text == code.ToString())
            {
                this.Hide();
                frmNewPassword frmNewPassword = new frmNewPassword(eMailNhanVien);
                frmNewPassword.Show();
            }
            else
            {
                MessageBox.Show("Mã xác minh không chính xác!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
