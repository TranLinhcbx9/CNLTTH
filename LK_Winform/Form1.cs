using LK_Winform.DTO;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace LK_Winform
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            LoadData();

        }
        Dictionary<int, string> ListDictionaryLLK = new Dictionary<int, string>();
        Dictionary<int, string> ListDictionaryNCC = new Dictionary<int, string>();
        Dictionary<int, string> ListDictionaryLM = new Dictionary<int, string>();

        public string baseAddress = "https://localhost:44386/";

        List<LinhKien> listLinhKien = null;
        List<LoaiLinhKien> listloailinhkien = null;
        List<LoaiMay> listLoaiMay = null;
        List<NhaCC> listNhaCC = null;

        bool kTLinhKien = false;
        bool kTLLK = false;
        bool kTLM = false;
        bool kTNCC = false;

        public void ErrorLinhKien()
        {
            if (cboMaLoaiLinhKien.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }

            else if (cboMaLoaiMay.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else if (cboMaNhaCungCap.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }

            else if (txtTenLinhKien.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else if (txtThongSoKiThuat.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else if (txtMoTa.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }

            else if (txtGiaBan.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else if (txtThoiGianBaoHanh.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                this.kTLinhKien = true;
            }
        }

        public void ErrorLLK()
        {
            if (txtTenLLK2.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                this.kTLLK = true;
            }
        }

        public void ErrorLM()
        {
            if (txtTenLM3.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                this.kTLM = true;
            }
        }

        public void ErrorNCC()
        {
            if (txtTenNCC.Text == "")
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            }
            else
            {
                this.kTNCC = true;
            }
        }

        public void ResetLK()
        {
            txtMaLinhKien.Clear();
            txtTenLinhKien.Clear();
            txtThongSoKiThuat.Clear();
            txtThoiGianBaoHanh.Clear();
            txtMoTa.Clear();
            txtGiaBan.Clear();

        }

        public void ResetLLK()
        {
            txtMaLLK2.Clear();
            txtTenLLK2.Clear();

        }

        public void ResetLM()
        {
            txtMaLM3.Clear();
            txtTenLM3.Clear();

        }
        public void ResetNCC()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();

        }
        public void LoadData()
        {
            LoadDataLK();
            LoadDataLLK();
            LoadDataLM();
            LoadDataNCC();
            LoadLoaiLinhKienCbo();
            LoadNhaCCCbo();
            LoaiMayCbo();
            //listLoaiSP = LoadLoaiSP();
            //if (listLoaiSP != null)
            //    dtgdisplayLoaiSP.DataSource = listLoaiSP;
        }

        public void LoadDataLK()
        {
            listLinhKien = LoadLinhKien();
            if (listLinhKien != null)
            {
                dtgDisplayLinhKien.DataSource = listLinhKien;
            }
        }

        public void LoadDataLLK()
        {
            listloailinhkien = LoadLoaiLinhKien();
            if (listloailinhkien != null)
            {
                dtgDisplayLLK.DataSource = listloailinhkien;
            }
        }

        public void LoadDataLM()
        {
            listLoaiMay = LoadLoaiMay();
            if (listLoaiMay != null)
            {
                dtgDisplayLM.DataSource = listLoaiMay;
            }

        }

        public void LoadDataNCC()
        {
            listNhaCC = LoadNhaCC();
            if (listNhaCC != null)
            {
                dtgDisplayNCC.DataSource = listNhaCC;
            }
        }
        private List<LinhKien> LoadLinhKien()
        {
            List<LinhKien> list = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("listlinhkien");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<LinhKien>>();
                    readTask.Wait();

                    list = readTask.Result;

                }
                else //web api sent error response 
                {
                    //log response status here..    

                }
            }
            return list;
        }

        private List<LoaiLinhKien> LoadLoaiLinhKien()
        {
            List<LoaiLinhKien> list = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("listloailinhkien");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<LoaiLinhKien>>();
                    readTask.Wait();

                    list = readTask.Result;

                }
                else //web api sent error response 
                {
                    //log response status here..    

                }
            }
            return list;
        }

        private List<LoaiMay> LoadLoaiMay()
        {
            List<LoaiMay> list = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("listloaimay");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<LoaiMay>>();
                    readTask.Wait();

                    list = readTask.Result;

                }
                else //web api sent error response 
                {
                    //log response status here..    

                }
            }
            return list;
        }

        private List<NhaCC> LoadNhaCC()
        {
            List<NhaCC> list = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("listnhacc");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<NhaCC>>();
                    readTask.Wait();

                    list = readTask.Result;

                }
                else //web api sent error response 
                {
                    //log response status here..    

                }
            }
            return list;
        }

        private void LoadLoaiLinhKienCbo()
        {
            List<LoaiLinhKien> list = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("listloailinhkien");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<LoaiLinhKien>>();
                    readTask.Wait();

                    list = readTask.Result;
                    foreach (var item in list)
                    {
                        ListDictionaryLLK.Add(item.maLoaiLinhKien, item.tenLoai);
                    }
                    cboMaLoaiLinhKien.DataSource = new BindingSource(ListDictionaryLLK, null);
                    cboMaLoaiLinhKien.DisplayMember = "Value";
                    cboMaLoaiLinhKien.ValueMember = "Key";
                }
                else //web api sent error response 
                {
                    //log response status here..    

                }
            }
        }

        private void LoadNhaCCCbo()
        {
            List<NhaCC> list = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("listnhacc");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<NhaCC>>();
                    readTask.Wait();

                    list = readTask.Result;
                    foreach (var item in list)
                    {
                        ListDictionaryNCC.Add(item.maNhaCungCap, item.tenNhaCungCap);
                    }
                    cboMaNhaCungCap.DataSource = new BindingSource(ListDictionaryNCC, null);
                    cboMaNhaCungCap.DisplayMember = "Value";
                    cboMaNhaCungCap.ValueMember = "Key";
                }
                else //web api sent error response 
                {
                    //log response status here..    

                }
            }
        }

        private void LoaiMayCbo()
        {
            List<LoaiMay> list = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                //HTTP GET
                var responseTask = client.GetAsync("listloaimay");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<List<LoaiMay>>();
                    readTask.Wait();

                    list = readTask.Result;
                    foreach (var item in list)
                    {
                        ListDictionaryLM.Add(item.maLoaiMay, item.tenLoaiMay);
                    }
                    cboMaLoaiMay.DataSource = new BindingSource(ListDictionaryLM, null);
                    cboMaLoaiMay.DisplayMember = "Value";
                    cboMaLoaiMay.ValueMember = "Key";
                }
                else //web api sent error response 
                {
                    //log response status here..    

                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ErrorLinhKien();
            //ErrorSP();
            //int maLinhKien = int.Parse(txtMaLinhKien.Text);
            if (kTLinhKien == true)
            {

                LinhKien lk = new LinhKien();
                lk.maLoaiLinhKien = int.Parse(cboMaLoaiLinhKien.SelectedValue.ToString());
                lk.maNhaCungCap = int.Parse(cboMaLoaiLinhKien.SelectedValue.ToString());
                lk.maLoaiMay = int.Parse(cboMaLoaiMay.SelectedValue.ToString());
                lk.tenLinhKien = txtTenLinhKien.Text;
                lk.thongSoKiThuat = txtThongSoKiThuat.Text;
                lk.moTa = txtMoTa.Text;
                lk.giaBan = double.Parse(txtGiaBan.Text);
                lk.thoiGianBaoHanh = txtThoiGianBaoHanh.Text;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);

                    //HTTP POST
                    var postTask = client.PostAsJsonAsync<LinhKien>("themlinhkien", lk);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công");
                        //ClearLinhKien();
                        LoadDataLK();
                        ResetLK();
                    }
                    else //web api sent error response 
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại");

                    }
                }
            }
        }

        private void dtgDisplayLinhKien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgDisplayLinhKien.CurrentRow.Cells[0].Value != null)
            {
                txtMaLinhKien.Text = dtgDisplayLinhKien.CurrentRow.Cells[0].Value.ToString();
            }

            if (dtgDisplayLinhKien.CurrentRow.Cells[4].Value != null)
            {
                txtTenLinhKien.Text = dtgDisplayLinhKien.CurrentRow.Cells[4].Value.ToString();
            }

            if (dtgDisplayLinhKien.CurrentRow.Cells[5].Value != null)
            {
                txtThongSoKiThuat.Text = dtgDisplayLinhKien.CurrentRow.Cells[5].Value.ToString();
            }

            if (dtgDisplayLinhKien.CurrentRow.Cells[6].Value != null)
            {
                txtMoTa.Text = dtgDisplayLinhKien.CurrentRow.Cells[6].Value.ToString();
            }

            if (dtgDisplayLinhKien.CurrentRow.Cells[7].Value != null)
            {
                txtGiaBan.Text = dtgDisplayLinhKien.CurrentRow.Cells[7].Value.ToString();
            }

            if (dtgDisplayLinhKien.CurrentRow.Cells[8].Value != null)
            {
                txtThoiGianBaoHanh.Text = dtgDisplayLinhKien.CurrentRow.Cells[8].Value.ToString();
            }
            //txtPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //if (dataGridView1.CurrentRow.Cells[4].Value != null)
            //{
            //    txtPP.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            //}
            //if (dataGridView1.CurrentRow.Cells[5].Value != null)
            //{
            //    pictureBox1.Image = Image.FromFile(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            //}
            //if (dataGridView1.CurrentRow.Cells[6].Value != null)
            //{
            //    pictureBox2.Image = Image.FromFile(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            //}
            //if (dataGridView1.CurrentRow.Cells[7].Value != null)
            //{
            //    txtStock.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //}
            //if (dataGridView1.CurrentRow.Cells[8].Value != null)
            //{
            //    cboStatus.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            //}
        }

        private void btnThemLLK_Click(object sender, EventArgs e)
        {
            ErrorLLK();
            if (kTLLK == true)
            {
                //string maLoaiLinhKien = txtMaLLK2.Text;

                string tenLoaiLinhKien = txtTenLLK2.Text;

                LoaiLinhKien model = new LoaiLinhKien();

                //model.maLoai = int.Parse(maLoaiLinhKien);
                model.tenLoai = tenLoaiLinhKien;
                ////SIZE model = new SIZE();
                ////model.SizeID = int.Parse(IDSize);
                //model.Size1 = SizeName;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);
                    //HTTP GET
                    var postTask = client.PostAsJsonAsync<LoaiLinhKien>("themloailinhkien", model);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Thêm linh kiện thành công");
                        //cleartext2();
                        LoadDataLLK();
                        ResetLLK();
                    }
                    else //web api sent error response 
                    {
                        MessageBox.Show("Thêm linh kiện thất bại");

                    }
                }
            }
        }

        private void btnThemLM_Click(object sender, EventArgs e)
        {
            ErrorLM();
            if (kTLM == true)
            {
                //string maLoaiLinhKien = txtMaLLK2.Text;

                string tenLoaiMay = txtTenLM3.Text;

                LoaiMay model = new LoaiMay();
                model.tenLoaiMay = tenLoaiMay;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);
                    //HTTP GET
                    var postTask = client.PostAsJsonAsync<LoaiMay>("themloaimay", model);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Thêm thành công");
                        //cleartext2();
                        LoadDataLM();
                        ResetLM();
                    }
                    else //web api sent error response 
                    {
                        MessageBox.Show("Thêm thất bại");

                    }
                }
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            ErrorNCC();
            if (kTNCC == true)
            {
                //string maLoaiLinhKien = txtMaLLK2.Text;

                string tenNhaCungCap = txtTenNCC.Text;

                NhaCC model = new NhaCC();
                model.tenNhaCungCap = tenNhaCungCap;
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);
                    //HTTP GET
                    var postTask = client.PostAsJsonAsync<NhaCC>("themnhacc", model);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Thêm thành công");
                        LoadDataNCC();
                        ResetNCC();

                    }
                    else //web api sent error response 
                    {
                        MessageBox.Show("Thêm thất bại");

                    }
                }
            }
        }

        private void btnResetLK_Click(object sender, EventArgs e)
        {
            ResetLK();
        }
        private void btnResetLM_Click(object sender, EventArgs e)
        {
            ResetLM();
        }
        private void btnResetLLK_Click(object sender, EventArgs e)
        {
            ResetLLK();
        }
        private void btnResetNCC_Click_1(object sender, EventArgs e)
        {
            ResetNCC();
        }

        private void btnResetLLK_Click_1(object sender, EventArgs e)
        {
            ResetLLK();
        }
        private void dtgDisplayLLK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgDisplayLLK.CurrentRow.Cells[0].Value != null)
            {
                txtMaLLK2.Text = dtgDisplayLLK.CurrentRow.Cells[0].Value.ToString();
            }

            if (dtgDisplayLLK.CurrentRow.Cells[1].Value != null)
            {
                txtTenLLK2.Text = dtgDisplayLLK.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void dtgDisplayLM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgDisplayLM.CurrentRow.Cells[0].Value != null)
            {
                txtMaLM3.Text = dtgDisplayLM.CurrentRow.Cells[0].Value.ToString();
            }

            if (dtgDisplayLM.CurrentRow.Cells[1].Value != null)
            {
                txtTenLM3.Text = dtgDisplayLM.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void dtgDisplayNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgDisplayNCC.CurrentRow.Cells[0].Value != null)
            {
                txtMaNCC.Text = dtgDisplayNCC.CurrentRow.Cells[0].Value.ToString();
            }

            if (dtgDisplayNCC.CurrentRow.Cells[1].Value != null)
            {
                txtTenNCC.Text = dtgDisplayNCC.CurrentRow.Cells[1].Value.ToString();
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ErrorLinhKien();
            //ErrorSP();
            //int maLinhKien = int.Parse(txtMaLinhKien.Text);
            if (kTLinhKien == true)
            {

                LinhKien lk = new LinhKien();
                int id = int.Parse(txtMaLinhKien.Text);
                lk.maLoaiLinhKien = int.Parse(cboMaLoaiLinhKien.SelectedValue.ToString());
                lk.maNhaCungCap = int.Parse(cboMaLoaiLinhKien.SelectedValue.ToString());
                lk.maLoaiMay = int.Parse(cboMaLoaiMay.SelectedValue.ToString());
                lk.tenLinhKien = txtTenLinhKien.Text;
                lk.thongSoKiThuat = txtThongSoKiThuat.Text;
                lk.moTa = txtMoTa.Text;
                lk.giaBan = double.Parse(txtGiaBan.Text);
                lk.thoiGianBaoHanh = txtThoiGianBaoHanh.Text;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);

                    //HTTP POST
                    var postTask = client.PutAsJsonAsync<LinhKien>("sualinhkien/"+id, lk);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Sửa thành công");
                        //ClearLinhKien();
                        LoadDataLK();
                        ResetLK();
                    }
                    else //web api sent error response 
                    {
                        MessageBox.Show("Sửa thất bại");

                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //LinhKien lk = new LinhKien();
            if (txtMaLinhKien.Text == "")
            {
                MessageBox.Show("ID not null");
            }
            else
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);

                    int id = int.Parse(txtMaLinhKien.Text);
                    //HTTP POST
                    var postTask = client.DeleteAsync("xoalinhkien/" + id);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (result.IsSuccessStatusCode)
                        {

                            MessageBox.Show("Xoá thành công");
                            //ClearLinhKien();
                            LoadDataLK();
                            ResetLK();
                        }
                        else //web api sent error response 
                        {
                            MessageBox.Show("Xóa thất bại");

                        }
                    }
                }
            }
        }

        private void btnSuaLLK_Click(object sender, EventArgs e)
        {
            ErrorLLK();
            //ErrorSP();
            //int maLinhKien = int.Parse(txtMaLinhKien.Text);
            if (kTLLK == true)
            {

                LoaiLinhKien llk = new LoaiLinhKien();
                int id = int.Parse(txtMaLLK2.Text);
                llk.tenLoai = txtTenLLK2.Text;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);

                    //HTTP POST
                    var postTask = client.PutAsJsonAsync<LoaiLinhKien>("sualoailinhkien/" + id, llk);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Sửa thành công");
                        //ClearLinhKien();
                        LoadDataLLK();
                        ResetLLK();
                    }
                    else //web api sent error response 
                    {
                        MessageBox.Show("Sửa thất bại");

                    }
                }
            }
        }

        private void btnSuaLM_Click(object sender, EventArgs e)
        {
            ErrorLM();
            //ErrorSP();
            //int maLinhKien = int.Parse(txtMaLinhKien.Text);
            if (kTLM == true)
            {

                LoaiMay lm = new LoaiMay();
                int id = int.Parse(txtMaLM3.Text);
                lm.tenLoaiMay = txtTenLM3.Text;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);

                    //HTTP POST
                    var postTask = client.PutAsJsonAsync<LoaiMay>("sualoaimay/" + id, lm);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Sửa thành công");
                        //ClearLinhKien();
                        LoadDataLM();
                        ResetLM();
                    }
                    else //web api sent error response 
                    {
                        MessageBox.Show("Sửa thất bại");

                    }
                }
            }
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            ErrorNCC();
            //ErrorSP();
            //int maLinhKien = int.Parse(txtMaLinhKien.Text);
            if (kTNCC == true)
            {

                NhaCC ncc = new NhaCC();
                int id = int.Parse(txtMaNCC.Text);
                ncc.tenNhaCungCap = txtTenNCC.Text;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);

                    //HTTP POST
                    var postTask = client.PutAsJsonAsync<NhaCC>("suanhacc/" + id, ncc);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Sửa thành công");
                        //ClearLinhKien();
                        LoadDataNCC();
                        ResetNCC();
                    }
                    else //web api sent error response 
                    {
                        MessageBox.Show("Sửa thất bại");

                    }
                }
            }
        }

        private void btnXoaLLK_Click(object sender, EventArgs e)
        {
            if (txtMaLLK2.Text == "")
            {
                MessageBox.Show("ID not null");
            }
            else
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);

                    int id = int.Parse(txtMaLLK2.Text);
                    //HTTP POST
                    var postTask = client.DeleteAsync("xoaloailinhkien/" + id);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (result.IsSuccessStatusCode)
                        {

                            MessageBox.Show("Xoá thành công");
                            //ClearLinhKien();
                            LoadDataLLK();
                            ResetLLK();
                        }
                        else //web api sent error response 
                        {
                            MessageBox.Show("Xóa thất bại");

                        }
                    }
                }
            }
        }

        private void btnXoaLM_Click(object sender, EventArgs e)
        {
            if (txtMaLM3.Text == "")
            {
                MessageBox.Show("ID not null");
            }
            else
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);

                    int id = int.Parse(txtMaLM3.Text);
                    //HTTP POST
                    var postTask = client.DeleteAsync("xoaloaimay/" + id);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (result.IsSuccessStatusCode)
                        {

                            MessageBox.Show("Xoá thành công");
                            //ClearLinhKien();
                            LoadDataLM();
                            ResetLM();
                        }
                        else //web api sent error response 
                        {
                            MessageBox.Show("Xóa thất bại");

                        }
                    }
                }
            }
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("ID not null");
            }
            else
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseAddress);

                    int id = int.Parse(txtMaNCC.Text);
                    //HTTP POST
                    var postTask = client.DeleteAsync("xoanhacc/" + id);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (result.IsSuccessStatusCode)
                        {

                            MessageBox.Show("Xoá thành công");
                            //ClearLinhKien();
                            LoadDataNCC();
                            ResetNCC();
                        }
                        else //web api sent error response 
                        {
                            MessageBox.Show("Xóa thất bại");

                        }
                    }
                }
            }
        }
    }
}

