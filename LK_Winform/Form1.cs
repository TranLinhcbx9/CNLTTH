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
                    //int maLoaiLinhKien = int.Parse(txtMaLoaiLinhKien.Text);
                    //int maNhaCungCap = int.Parse(txtMaNhaCungCap.Text);
                    //int maLoaiMay = int.Parse(txtMaLoaiMay.Text);
                    string tenLinhKien = txtTenLinhKien.Text;
                    string thongSoKiThuat = txtThongSoKiThuat.Text;
                    string moTa = txtMoTa.Text;
                    float giaBan = float.Parse(txtGiaBan.Text);
                    string thoiGianBaoHanh = txtThoiGianBaoHanh.Text;
                    LinhKien lk = new LinhKien(tenLinhKien, thongSoKiThuat, moTa, giaBan, thoiGianBaoHanh);
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
                            LoadData();
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
                        LoadData();
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
                        //cleartext2();
                        //LoadData();
                    }
                    else //web api sent error response 
                    {
                        MessageBox.Show("Thêm thất bại");

                    }
                }
            }
        }
    }
}

