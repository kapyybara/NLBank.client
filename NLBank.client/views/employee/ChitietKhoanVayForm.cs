﻿using MaterialSkin;
using MaterialSkin.Controls;
using NLBank.client.DAL;
using NLBank.client.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLBank.client.views.employee
{
    public partial class ChitietKhoanVayForm : MaterialForm
    {
        int thoihanvay = 0;
        int mucphi = 0;
        decimal laisuat = 0;
        decimal laiquahan = 0; 
        KhoanVayDTO kv = new KhoanVayDTO();
       
        public ChitietKhoanVayForm(KhoanVayDTO kv)
        {
            this.kv = kv;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        Boolean isValid()
        {
            int number = 0;
            try
            {
                thoihanvay = int.Parse(thoihanvay_input.Text);
                mucphi = int.Parse(mucphi_input.Text);
                laisuat = decimal.Parse(laisuat_input.Text);
                laiquahan = decimal.Parse(laiquahan_input.Text);
                return true; 
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void ChitietKhoanVayForm_Load(object sender, EventArgs e)
        {
            makh.Text = kv.MaKH.ToString();
            makv.Text = kv.MaKV.ToString();
            sotienvay.Text = kv.SoTienVay.ToString();
            loaikv.Text = kv.MaLoaiKV.ToString();
            taisanthechap.Text = kv.MaTSDB.ToString();
            mucdich.Text = kv.MucDich; 

            

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                HDTDDTO hDTDDTO = new HDTDDTO();
                hDTDDTO.LoaiTien = "VND";
                hDTDDTO.MaKH = kv.MaKH;
                hDTDDTO.MAKV = kv.MaKV;
                hDTDDTO.Muc_dich = kv.MucDich;
                hDTDDTO.LaiSuat = laisuat;
                hDTDDTO.LaiQuaHan = laiquahan;
                hDTDDTO.ThoiHanVay = thoihanvay;
                hDTDDTO.PhuongThucTra = phuongthuctra_combobox.Text;
                hDTDDTO.NgayKi = ngayky_picker.Value.Date;
                hDTDDTO.TGGiaiNgan = ngaygiaingan_picker.Value.Date;
                hDTDDTO.MucPhi = mucphi;
                var result = HDTDDAL.ThemHDTD(hDTDDTO);
                Console.Write(result);
                MessageBox.Show("Tạo hợp đồng mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // TODO hien thong bao loi . Nhap lai 
                MessageBox.Show("Thông tin không hợp lệ. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                thoihanvay_input.Text = "";
                laiquahan_input.Text = "";
                laisuat_input.Text = "";
                mucphi_input.Text = "";
            }
            
        }

        private void xoa_kv_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa khoản vay", "Chấp nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.OK))
            {
                //Do something
                KhoanVayDAL.XoaKhoanVay(kv.MaKV); 
            }
            else
            {

            }
        }
    }
}
