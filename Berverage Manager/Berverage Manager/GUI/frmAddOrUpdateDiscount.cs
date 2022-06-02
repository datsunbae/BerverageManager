using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Berverage_Manager.BUS;
using Berverage_Manager.DataContext;

namespace Berverage_Manager.GUI
{
    public partial class frmAddOrUpdateDiscount : Form
    {
        private static string action_Form;
        DataGridViewRow row;
        CT_KhuyenMaiChietKhau_BUS CT_KhuyenMaiChietKhau_BUS;
        DoiTuongKhuyenMai_BUS doiTuongKhuyenMai_BUS;
        KhuyenMai_BUS khuyenMai_BUS;
        ChietKhau_BUS chietKhau_BUS;
        int indexRowSelected = -1;
        public frmAddOrUpdateDiscount(String actionForm)
        {
            InitializeComponent();
            action_Form = actionForm;
            CT_KhuyenMaiChietKhau_BUS = new CT_KhuyenMaiChietKhau_BUS();
            doiTuongKhuyenMai_BUS = new DoiTuongKhuyenMai_BUS();
            khuyenMai_BUS = new KhuyenMai_BUS();
            chietKhau_BUS = new ChietKhau_BUS();
        }

        private void LoadCBDoiTuongKhuyenMai()
        {
            KMTCK_CB_DoiTuongKH.DataSource = doiTuongKhuyenMai_BUS.LayTatCaDoiTuongKhuyenMai();
            KMTCK_CB_DoiTuongKH.DisplayMember = "TENDTKM";
            KMTCK_CB_DoiTuongKH.ValueMember = "MADTKM";
        }

        private void LoadThongTinKM()
        {
            int rowSelectedUpdate = ucDiscount.uc_KhuyenMai.indexRowSelected;
            row = ucDiscount.uc_KhuyenMai.dgv_KhuyenMai.Rows[rowSelectedUpdate];
            KHUYENMAI km = khuyenMai_BUS.LayKhuyenMaiBangMKM(int.Parse(row.Cells[0].Value.ToString()));
            KMTCK_TXT_TenKM.Text = km.TENKM;

            if (km.SLAPDUNG != null)
            {
                KMTCK_TXT_SLApDung.Text = km.SLAPDUNG.ToString();
            }
            else
            {
                KMTCK_TXT_SLApDung.Enabled = false;
                KMTCK_CheckBox_SLApDung.Checked = true;
            }
            KMTCK_DATE_NgayBD.Value = km.TUNGAY.Value;
            if (km.DENNGAY != null)
            {
                KMTCK_DATE_NgayKT.Value = km.DENNGAY.Value;
            }
            else
            {
                KMTCK_DATE_NgayKT.Enabled = false;
                KMTCK_CheckBox_NgayKT.Checked = true;
            }
            KMTCK_CB_DoiTuongKH.SelectedValue = km.MADTKM;
        }

        public void FillDataDGV(List<CTKHUYENMAI_CHIETKHAU> listCTKMTCK)
        {
            KMTCK_DGV_CTKMTCK.Rows.Clear();
            foreach (var item in listCTKMTCK)
            {
                int RowNew = KMTCK_DGV_CTKMTCK.Rows.Add();
                KMTCK_DGV_CTKMTCK.Rows[RowNew].Cells[0].Value = item.GIATU;
                if (item.DENGIA != null)
                {
                    KMTCK_DGV_CTKMTCK.Rows[RowNew].Cells[1].Value = item.DENGIA;
                }
                else
                {
                    KMTCK_DGV_CTKMTCK.Rows[RowNew].Cells[1].Value = "Không giới hạn";
                }
                KMTCK_DGV_CTKMTCK.Rows[RowNew].Cells[2].Value = item.CK;
                KMTCK_DGV_CTKMTCK.Rows[RowNew].Cells[3].Value = chietKhau_BUS.LayChietKhauBangMCK(item.LOAICK).TENCK;
            }
        }

        private void frmAddOrUpdateDiscount_Load(object sender, EventArgs e)
        {
            LoadCBDoiTuongKhuyenMai();

            if (action_Form == "Update")
            {
                panel1.Enabled = false;
                LoadThongTinKM();
                int maKM = int.Parse(row.Cells[0].Value.ToString());
                FillDataDGV(CT_KhuyenMaiChietKhau_BUS.LayDanhSachCTKhuyenMaiBangMKM(maKM));
            }
        }

        private void ThemCTKhuyenMaiTheoCK_DGV()
        {
            int row = KMTCK_DGV_CTKMTCK.Rows.Add();
            KMTCK_DGV_CTKMTCK.Rows[row].Cells[0].Value = KMTCK_TXT_GiaTu.Text;
            KMTCK_DGV_CTKMTCK.Rows[row].Cells[1].Value = KMTCK_TXT_DenGia.Text;
            KMTCK_DGV_CTKMTCK.Rows[row].Cells[2].Value = KMTCK_TXT_ChietKhau.Text;
            KMTCK_DGV_CTKMTCK.Rows[row].Cells[3].Value = KMTCK_CB_LoaiCK.Text;
        }

        private void KMTCK_BTN_Them_Click(object sender, EventArgs e)
        {
            if (KMTCK_TXT_GiaTu.Text != "" && KMTCK_TXT_ChietKhau.Text != "")
            {
                ThemCTKhuyenMaiTheoCK_DGV();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Thông báo");
            }
        }

        private void KMTCK_DGV_CTKMTCK_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            KMTCK_DGV_CTKMTCK.Rows[e.RowIndex].Height = 40;
        }

        private void KMTCK_BTN_Go_Click(object sender, EventArgs e)
        {
            if (indexRowSelected >= 0)
            {
                KMTCK_DGV_CTKMTCK.Rows.RemoveAt(indexRowSelected);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn chi tiết khuyến mãi cần xóa!", "Thông báo");
            }
        }

        private void KMTCK_DGV_CTKMTCK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRowSelected = e.RowIndex;
        }

        private void KMTCK_BTN_Luu_Click(object sender, EventArgs e)
        {
            if (action_Form == "Add")
            {
                if (KMTCK_DGV_CTKMTCK.Rows.Count > 0)
                {
                    //Them khuyen mai vao CSDL
                    KHUYENMAI km = new KHUYENMAI();
                    km.TENKM = KMTCK_TXT_TenKM.Text;
                    if (KMTCK_CheckBox_SLApDung.Checked != true)
                    {
                        km.SLAPDUNG = int.Parse(KMTCK_TXT_SLApDung.Text);
                        km.SLAPDUNGCONLAI = int.Parse(KMTCK_TXT_SLApDung.Text);
                    }
                    km.TUNGAY = KMTCK_DATE_NgayBD.Value.Date;
                    if (KMTCK_CheckBox_NgayKT.Checked != true)
                    {
                        km.DENNGAY = KMTCK_DATE_NgayKT.Value.Date;
                    }
                    km.TRANGTHAI = true;
                    km.MAHTKM = 1; // ma = 1 : khuyen mai theo chiet khau
                    km.MADTKM = int.Parse(KMTCK_CB_DoiTuongKH.SelectedValue.ToString());
                    khuyenMai_BUS.ThemKhuyenMai(km);

                    int tongDong = KMTCK_DGV_CTKMTCK.Rows.Count;
                    //Them CT Khuyen mai theo chiet khau vao CSDL
                    CTKHUYENMAI_CHIETKHAU ct_KMTCK = new CTKHUYENMAI_CHIETKHAU();
                    for (int i = 0; i < tongDong; i++)
                    {
                        ct_KMTCK.MAKM = km.MAKM;
                        ct_KMTCK.GIATU = double.Parse(KMTCK_DGV_CTKMTCK.Rows[i].Cells[0].Value.ToString());
                        if (KMTCK_DGV_CTKMTCK.Rows[i].Cells[1].Value.ToString() != "")
                        {
                            ct_KMTCK.DENGIA = double.Parse(KMTCK_DGV_CTKMTCK.Rows[i].Cells[1].Value.ToString());
                        }
                        ct_KMTCK.CK = double.Parse(KMTCK_TXT_ChietKhau.Text); ;
                        ct_KMTCK.LOAICK = chietKhau_BUS.LayMaChietKhauBangTenCK(KMTCK_DGV_CTKMTCK.Rows[i].Cells[3].Value.ToString());
                        CT_KhuyenMaiChietKhau_BUS.ThemCT_KhuyenMaiChietKhau(ct_KMTCK);
                    }

                    ucDiscount.uc_KhuyenMai.FillDataDGV(khuyenMai_BUS.LayTatCaKhuyenMai());
                    this.Close();
                    MessageBox.Show("Thêm khuyến mãi thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Bạn chưa thêm khuyến mãi!", "Thông báo");
                }
            }
            else
            {
                //Sua khuyen mai vao CSDL
                KHUYENMAI km = khuyenMai_BUS.LayKhuyenMaiBangMKM(int.Parse(row.Cells[0].Value.ToString()));
                km.TENKM = KMTCK_TXT_TenKM.Text;
                if (KMTCK_CheckBox_SLApDung.Checked != true)
                {
                    int slPhieuDaDung = km.SLAPDUNG.Value - km.SLAPDUNGCONLAI.Value;
                    km.SLAPDUNG = int.Parse(KMTCK_TXT_SLApDung.Text);
                    km.SLAPDUNGCONLAI = int.Parse(KMTCK_TXT_SLApDung.Text) - slPhieuDaDung;
                }
                km.TUNGAY = KMTCK_DATE_NgayBD.Value.Date;
                if (KMTCK_CheckBox_NgayKT.Checked != true)
                {
                    km.DENNGAY = KMTCK_DATE_NgayKT.Value.Date;
                }
                km.MADTKM = int.Parse(KMTCK_CB_DoiTuongKH.SelectedValue.ToString());
                khuyenMai_BUS.SuaKhuyenMai(km);

                ucDiscount.uc_KhuyenMai.FillDataDGV(khuyenMai_BUS.LayTatCaKhuyenMai());
                ucDiscount.uc_KhuyenMai.CapNhatTrangThaiKM();
                this.Close();
                MessageBox.Show("Sửa khuyến mãi thành công!", "Thông báo");
            }
        }

        private void KMTCK_CheckBox_NgayKT_CheckedChanged(object sender, EventArgs e)
        {
            if (KMTCK_CheckBox_NgayKT.Checked)
            {
                KMTCK_DATE_NgayKT.Enabled = false;
            }
            else
            {
                KMTCK_DATE_NgayKT.Enabled = true;
            }
        }

        private void KMTCK_CheckBox_SLApDung_CheckedChanged(object sender, EventArgs e)
        {
            if (KMTCK_CheckBox_SLApDung.Checked)
            {
                KMTCK_TXT_SLApDung.Enabled = false;
            }
            else
            {
                KMTCK_TXT_SLApDung.Enabled = true;
            }
        }
    }
}
