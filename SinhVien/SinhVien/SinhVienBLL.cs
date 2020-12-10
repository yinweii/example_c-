using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVien
{
    
    class SinhVienBLL
    {
        SinhVienDAL dalsv;
        public SinhVienBLL()
        {
            dalsv = new SinhVienDAL();

        }
        public DataTable getAllSinhVien()
        {
            return dalsv.getAllSinhVien();
        }
        public bool addSinhVien(SinhVien sv)
        {
            return dalsv.addSinhVien(sv);
        }
        public bool editSinhVien(SinhVien sv)
        {
            return dalsv.editSinhVien(sv);
        }
        public bool deleteSinhVien(SinhVien sv)
        {
            return dalsv.deleteSinhVien(sv);
        }
        public DataTable findlSinhVien(string sv)
        {
            return dalsv.findlSinhVien(sv);
        }


    }

}
