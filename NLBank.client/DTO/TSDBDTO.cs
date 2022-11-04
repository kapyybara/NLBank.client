﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.DTO
{
    class TSDBDTO
    {
        private String _MaTSDB; 
        private String _MaLoaiTSDB ; 
        private String _TenTSDB ; 
        private String _MaKH ; 
        private int _TriGiaTS ;  
        private String _HinhThucDB ; 
        public String MaTSDB {
            get { return _MaTSDB; }
            set { _MaTSDB = value; } 
        }
        public String MaLoaiTSDB {
            get { return _MaLoaiTSDB; }
            set { _MaLoaiTSDB = value; }
        }
        public String TenTSDB {
            get { return _TenTSDB; }
            set { _TenTSDB = value; }
        }
        public String MaKH {
            get { return _MaKH; }
            set { _MaKH = value; }
        }
        public int TriGiaTS {
            get { return _TriGiaTS; }
            set { _TriGiaTS = value; }
        }
        public String HinhThucDB {
            get { return _HinhThucDB; }
            set { _HinhThucDB = value; }
        }
        public TSDBDTO(String maTSDB, String maLoaiTSDB, String tenTSDB, String maKH, int triGiaTS, String hinhThucDB)
        {
            _MaTSDB = maTSDB;
            _MaLoaiTSDB = maLoaiTSDB;
            _TenTSDB = tenTSDB;
            _MaKH = maKH;
            _TriGiaTS = triGiaTS;
            _HinhThucDB = hinhThucDB;
        }
        public TSDBDTO() { }
    }
}