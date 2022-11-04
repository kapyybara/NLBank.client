﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    class KhoanVayDTO
    {
        private String _MaKV ;
        private String _MaKH ;
        private String _MaTSDB ;
        private String _MaLoaiKV ;
        private String _MucDich ;
        private int _SoTienVay ;
        private String _LoaiTien ;
        public String MaKV {
            get { return _MaKV; }
            set { _MaKV = value; }
        }
        public String MaKH {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        public String MaTSDB {
            get { return _MaTSDB; }
            set { _MaTSDB = value; }
        }
        public String MaLoaiKV {
            get { return _MaLoaiKV; }
            set { _MaLoaiKV = value; }
        }
        public String MucDich {
            get { return _MucDich; }
            set { _MucDich = value; }
        }
        public int SoTienVay {
            get { return _SoTienVay; }
            set { _SoTienVay = value; }
        }
        public String LoaiTien {
            get { return _LoaiTien; }
            set { _LoaiTien = value; }
        }

        public KhoanVayDTO(String maKV, String maKH, String maTSDB, String maLoaiKV, String mucDich, int soTienVay, String loaiTien)
        {
            _MaKH = maKH;
            _MaKV = maKV;
            _MaTSDB = maTSDB;
            _MaLoaiKV = maLoaiKV;
            _MucDich = mucDich;
            _SoTienVay = soTienVay;
            _LoaiTien = loaiTien;
        }
        public KhoanVayDTO() { }

    }
}