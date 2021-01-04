using LK_Winform.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LK_Winform
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        public string baseAddress = "https://localhost:44386/";


        private void btnLogin_Click(object sender, EventArgs e)
        {

            //LinhKien lk = new LinhKien();
            //int id = int.Parse(txtMaLinhKien.Text);
            //lk.maLoaiLinhKien = int.Parse(cboMaLoaiLinhKien.SelectedValue.ToString());
            //lk.maNhaCungCap = int.Parse(cboMaLoaiLinhKien.SelectedValue.ToString());
            //lk.maLoaiMay = int.Parse(cboMaLoaiMay.SelectedValue.ToString());
            //lk.tenLinhKien = txtTenLinhKien.Text;
            //lk.thongSoKiThuat = txtThongSoKiThuat.Text;
            //lk.moTa = txtMoTa.Text;
            //lk.giaBan = double.Parse(txtGiaBan.Text);
            //lk.thoiGianBaoHanh = txtThoiGianBaoHanh.Text;

            User user = new User();
            
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);

                //HTTP POST
                var postTask = client.PutAsJsonAsync<User>("login/" + userName +"/"+ passWord, user);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    //ClearLinhKien();
                }
                else //web api sent error response 
                {
                    MessageBox.Show("Sửa thất bại");

                }
            }
        }
    }
}
