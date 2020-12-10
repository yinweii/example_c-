using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVien
{
    public partial class Form1 : Form
    {
        SinhVienBLL bllsv;
        public Form1()
        {
            InitializeComponent();
            bllsv = new SinhVienBLL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showAllSinhVien();
        }
        public void showAllSinhVien()
        {
            DataTable dt = bllsv.getAllSinhVien();
            dataGridView1.DataSource = dt;
        }
        public bool CheckData()
        {
            double n;
            if (string.IsNullOrEmpty(txt_masv.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã Sinh Viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_masv.Focus();
                return false;
                
            }
           
            if (string.IsNullOrEmpty(txt_masv.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã Họ Tên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_hoten.Focus();
                return false;
            }
            
            if (cmb_gt.SelectedIndex <= -1)
            {
                MessageBox.Show("Bạn chưa Chọn giới tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmb_makhoa.SelectedIndex <= -1)
            {
                MessageBox.Show("Bạn chưa Chọn khoa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            
            if (!double.TryParse(txt_diem.Text, out n) || n < 0 || n > 10 )
            {
                MessageBox.Show("Định dạng không đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                SinhVien sv = new SinhVien();
                sv.Masv = txt_masv.Text;
                sv.Hoten = txt_hoten.Text;
                sv.Ngaysinh = date_picker.Value;
                sv.Gioitinh = cmb_gt.Text;
                sv.Makhoa = cmb_makhoa.Text;
                sv.Diem = (double) double.Parse(txt_diem.Text);
                bllsv.addSinhVien(sv);
                showAllSinhVien();
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow.Index != -1)
            {
                txt_masv.Text = dataGridView1.CurrentRow.Cells["masv"].Value.ToString();
                txt_hoten.Text = dataGridView1.CurrentRow.Cells["hoten"].Value.ToString();
                date_picker.Value = (DateTime) dataGridView1.CurrentRow.Cells["ngaysinh"].Value;
                cmb_gt.Text = dataGridView1.CurrentRow.Cells["gioitinh"].Value.ToString();
                cmb_makhoa.Text = dataGridView1.CurrentRow.Cells["makhoa"].Value.ToString();
                txt_diem.Text = dataGridView1.CurrentRow.Cells["diem"].Value.ToString();
            }
            else
            {
                MessageBox.Show("ERROR !", "Error !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                SinhVien sv = new SinhVien();
                sv.Masv = txt_masv.Text;
                sv.Hoten = txt_hoten.Text;
                //sv.Ngaysinh = date_picker.Value;
                sv.Gioitinh = cmb_gt.Text;
                sv.Makhoa = cmb_makhoa.Text;
                sv.Diem = (double)double.Parse(txt_diem.Text);
                bllsv.editSinhVien(sv);
                showAllSinhVien();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                SinhVien sv = new SinhVien();
                sv.Masv = txt_masv.Text;
                bllsv.deleteSinhVien(sv);
                showAllSinhVien();
            }
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string value = txt_search.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllsv.findlSinhVien(value);
                dataGridView1.DataSource = dt;
            }
            else
            {
                showAllSinhVien();
            }
        }

        private void btn_refesh_Click(object sender, EventArgs e)
        {
            txt_masv.Clear();
            txt_hoten.Clear();
            txt_diem.Clear();
            txt_diem.Clear();
            txt_search.Clear();
            date_picker.Value = DateTime.Today;
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
