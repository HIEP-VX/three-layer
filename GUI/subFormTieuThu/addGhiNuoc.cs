using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class addGhiNuoc : Form
    {
        public bool isExit = true;
        public event Action DataAdded;
        private frmTieuThu fTT;

        public addGhiNuoc(frmTieuThu fTT)
        {
            InitializeComponent();
            setLinear.SetLinearGradient(btnThem, "#56d8e4", "#9f01ea");
            this.fTT = fTT;
        }
        static string[] DataTableColumnToStringArray(DataTable dataTable, string columnName)
        {
            int rows = dataTable.Rows.Count;
            string[] dataArray = new string[rows];

            for (int i = 0; i < rows; i++)
                dataArray[i] = dataTable.Rows[i][columnName].ToString();
            
            return dataArray;
        }

        // Định nghĩa một Tuple để lưu trữ hai giá trị
        public class MyData
        {
            public string MaKH { get; set; }
            public string MaNV { get; set; }
        }

        // Hàm để chuyển dữ liệu từ DataTable thành một danh sách của Tuple
        static List<MyData> DataTableToTupleList(DataTable dataTable)
        {
            List<MyData> dataList = new List<MyData>();

            foreach (DataRow row in dataTable.Rows)
            {
                dataList.Add(new MyData
                {
                    MaKH = row["MaKH"].ToString(),
                    MaNV = row["MaNV"].ToString()
                });
            }
            return dataList;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "select makh, dc.maNV from khachhang join diaChi dc on dc.phuong = KhachHang.phuong where tinhTrang = 1";
            DataTable dataTable = AccessData.getData(query);

            string sql = "select diaChi.maNV from diaChi join khachhang kh on kh.phuong = diaChi.phuong";
            
            using (SqlConnection conn = SqlConnectionData.connect())
            {
                conn.Open();
                int maTT = 0;
                string query1 = "declare @maTT INT\n"+
                                "INSERT INTO tieuThu (maKH, ThoiGianDau, ThoiGianCuoi, maNV) values (@maKH, @ThoiGianDau, @ThoiGianCuoi, @maNV)\n"+
                                "SET @maTT = SCOPE_IDENTITY()\n"+
                                "select @maTT as 'maTT'";
                thoiGianGhiNuoc.thoiGianCuoi = dateThoiGianCuoi.Value;
                List<MyData> myDataList = DataTableToTupleList(dataTable);
                //string[] maKHArray = DataTableColumnToStringArray(dataTable, "MaKH");
               //string[] maNVArray = DataTableColumnToStringArray(dataTable, "MaNV");
                for (int i = 0; i < myDataList.Count; i++)
                {

                    using (SqlCommand cmd = new SqlCommand(query1, conn))
                    {
                        cmd.Parameters.Clear();

                        //dataTable.Rows[i]["MaKH"].ToString()
                        cmd.Parameters.AddWithValue("@maKH", myDataList[i].MaKH);
                        cmd.Parameters.AddWithValue("@ThoiGianDau", dateThoiGianDau.Value);
                        cmd.Parameters.AddWithValue("@ThoiGianCuoi", dateThoiGianCuoi.Value);
                        cmd.Parameters.AddWithValue("@maNV", myDataList[i].MaNV);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                                maTT = int.Parse(reader["maTT"].ToString());
                        }
                        string query2 = "UPDATE TIEUTHU SET CHISOCU = (SELECT CHISODAU FROM DONGHONUOC dhn, KHACHHANG kh where dhn.MADHN = kh.MADHN and kh.MAKH = @maKH) where maKH = @maKH and maTT = " + maTT;

                        using (SqlCommand cmd1 = new SqlCommand(query2, conn))
                        {
                            cmd1.Parameters.AddWithValue("@maKH", dataTable.Rows[i]["MaKH"].ToString());
                            cmd1.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                DataAdded?.Invoke();
                fTT.HandleAddButton();
            }
        }

        private void addGhiNuoc_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
