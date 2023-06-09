using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhaSach.Models;

namespace QuanLyNhaSach.DataAccess
{
    public class ConnectDB
    {
        DataSet dsQLNhaSach;
        SqlDataAdapter dataAdapter;
        SqlConnection conn;
        DataColumn[] key;
        private string query;
        //constructor
        public ConnectDB()
        {
            dsQLNhaSach = new DataSet();
            conn = DBConfig.getConnectString();
        }
        //method
        //connect To Table
        private SqlDataAdapter selectSach()
        {
            query = "select * from SACH ORDER BY TENSACH";
            return new SqlDataAdapter(query, conn);
        }
        private SqlDataAdapter selectByQuery(string q)
        {
            return new SqlDataAdapter(q, conn);
        }

        //set key primary
        private void setPrimaryKey(DataTable table, string columnName)
        {
            key = new DataColumn[1];
            key[0] = table.Columns[columnName];
            table.PrimaryKey = key;
        }
        private void set2PrimaryKey(DataTable table, string columnName, string columnName2)
        {
            key = new DataColumn[2];
            key[0] = table.Columns[columnName];
            key[1] = table.Columns[columnName2];
            table.PrimaryKey = key;
        }
        private void set3PrimaryKey(DataTable table, string columnName, string columnName2, string columnName3)
        {
            key = new DataColumn[3];
            key[0] = table.Columns[columnName];
            key[1] = table.Columns[columnName2];
            key[2] = table.Columns[columnName3];
            table.PrimaryKey = key;
        }
        private void set4PrimaryKey(DataTable table, string columnName, string columnName2, string columnName3, string columnName4)
        {
            key = new DataColumn[4];
            key[0] = table.Columns[columnName];
            key[1] = table.Columns[columnName2];
            key[2] = table.Columns[columnName3];
            key[3] = table.Columns[columnName4];
            table.PrimaryKey = key;
        }
        //get data new check and delete data old
        private DataTable ResetDataOfTable(DataTable table)
        {
            if(table != null && table.Rows.Count != 0)//is valid
            {
                table.Rows.Clear();
                table.Columns.Clear();
                return new DataTable();
            }
            return table;
        }

        //get Datas table single 
        public DataTable getAllSach()
        {
            DataTable t = new DataTable();
            dataAdapter = selectSach();
            dataAdapter.Fill(t);
            return t;
        }
        public DataTable getAllSachByMaSach(string maSach)
        {
            DataTable table = new DataTable();
            query = string.Format(@"select * from SACH where MaSach = '{0}'",maSach);
            dataAdapter = selectByQuery(query);

            dataAdapter.Fill(table);

            return table;
        }
        public DataTable getInfoDetailSachByMaSach(string maSach)
        {
            DataSet dsTemp = new DataSet();
            query = string.Format(@"select * from THONGTINSACH where MASACH = '{0}'",maSach);
            dataAdapter = selectByQuery(query);

            dataAdapter.Fill(dsTemp, "T_THONGTINSACH");

            return dsTemp.Tables["T_THONGTINSACH"];
        }
        public List<string> getAllMaPhieuOfSachBy(string maSach)
        {
            List<string> lMaPhieu = new List<string>();
            query = string.Format(@"select MAPHIEU from CTPHIEUNHAP where MASACH = '{0}'",maSach);
            dataAdapter = selectByQuery(query);
            DataTable temp = new DataTable();
            dataAdapter.Fill(temp);
            foreach(DataRow e in temp.Rows)
            {
                lMaPhieu.Add(e["MAPHIEU"].ToString());
            }
            return lMaPhieu;
        }
        public DataTable getAllThongTinSachBy(string maSach)
        {
            query = string.Format(@"select * from THONGTINSACH where MASACH = '{0}'", maSach);
            dataAdapter = selectByQuery(query);
            DataTable temp = new DataTable();
            dataAdapter.Fill(temp);
            return temp;
        }
        public DataTable getAllNXB()
        {
            query = string.Format(@"select * from NHAXUATBAN");
            dataAdapter = selectByQuery(query);

            dataAdapter.Fill(dsQLNhaSach, "T_NXB");

            return dsQLNhaSach.Tables["T_NXB"];
        }
        public DataTable getAllTacGia()
        {
            query = string.Format(@"select * from TACGIA");
            dataAdapter = selectByQuery(query);

            dataAdapter.Fill(dsQLNhaSach, "T_TACGIA");

            return dsQLNhaSach.Tables["T_TACGIA"];
        }
        public DataTable getAllTheLoai()
        {
            query = string.Format(@"select * from THELOAI");
            dataAdapter = selectByQuery(query);

            dataAdapter.Fill(dsQLNhaSach, "T_THELOAI");

            return dsQLNhaSach.Tables["T_THELOAI"];
        }
        public DataTable getAllPhieuNhap()
        {
            query = string.Format(@"select * from PHIEUNHAP");
            dataAdapter = selectByQuery(query);

            dataAdapter.Fill(dsQLNhaSach, "T_PhieuNhap");

            return dsQLNhaSach.Tables["T_PhieuNhap"];
        }
        public DataTable getAllCTPhieuNhap()
        {
            query = string.Format(@"select * from CTPHIEUNHAP");
            dataAdapter = selectByQuery(query);

            dataAdapter.Fill(dsQLNhaSach, "T_CTPhieuNhap");

            return dsQLNhaSach.Tables["T_CTPhieuNhap"];
        }
        public DataTable getAllCTPhieuNhap(string maPhieu)
        {
            query = string.Format(@"select * from CTPHIEUNHAP where MAPHIEU = '{0}'",maPhieu);
            dataAdapter = selectByQuery(query);

            DataTable t = new DataTable();
            dataAdapter.Fill(t);

            return t;
        }
        public DataTable getAllThongTinSach()
        {
            query = string.Format(@"select * from THONGTINSACH");
            dataAdapter = selectByQuery(query);

            dataAdapter.Fill(dsQLNhaSach, "T_TTS");

            return dsQLNhaSach.Tables["T_TTS"];
        }
        public DataTable getAllAccount()
        {
            DataTable table = new DataTable();
            dataAdapter = selectByQuery("select * from TAIKHOANNV");
            dataAdapter.Fill(table);
            return table;
        }
        public DataTable getAllAccountMaNVNull()
        {
            DataTable table = new DataTable();
            dataAdapter = selectByQuery("select * from TAIKHOANNV where MATK not in (select MATK from NHANVIEN)");
            dataAdapter.Fill(table);
            return table;
        }
        public DataTable getAccountBy(string tenTK)
        {
            DataTable table = new DataTable();
            dataAdapter = selectByQuery(string.Format("select * from TAIKHOANNV where TENTK = '{0}'", tenTK));
            dataAdapter.Fill(table);
            return table;
        }
        public DataTable getAllNhanVien()
        {
            DataTable t = new DataTable();
            dataAdapter = selectByQuery("select * from NHANVIEN");
            dataAdapter.Fill(t);
            return t;
        }
        public DataTable getNhanVienBy(string maNV)
        {
            DataTable table = new DataTable();
            dataAdapter = selectByQuery(string.Format("select * from NHANVIEN where MANV = '{0}'",maNV));
            dataAdapter.Fill(table);
            return table;
        }
        public DataTable getAllKhachHang()
        {
            DataTable table = new DataTable();
            dataAdapter = selectByQuery(string.Format("select * from KHACHHANG"));
            dataAdapter.Fill(table);
            return table;
        }
        public DataTable getAllKhachHangBy(string maKH)
        {
            DataTable table = new DataTable();
            dataAdapter = selectByQuery(string.Format("select * from KHACHHANG where MAKH = '{0}'",maKH));
            dataAdapter.Fill(table);
            return table;
        }
        public DataTable getAllLoaiThe()
        {
            DataTable table = new DataTable();
            dataAdapter = selectByQuery(string.Format("select * from LOAITHE"));
            dataAdapter.Fill(table);
            return table;
        }
        public DataTable getAllHoaDon()
        {
            DataTable table = new DataTable();
            dataAdapter = selectByQuery(string.Format("select * from HOADON"));
            dataAdapter.Fill(table);
            return table;
        }
        public DataTable getAllCTHoaDonBy(string maHD, string maKH)
        {
            DataTable table = new DataTable();
            dataAdapter = selectByQuery(string.Format("select * from CTHOADON where MAHOADON = '{0}' AND MAKHACH = '{1}'",maHD, maKH));
            dataAdapter.Fill(table);
            return table;
        }
        public DataTable getAllMemberCard()
        {
            DataTable table = new DataTable();
            dataAdapter = selectByQuery(string.Format("select * from THETHANHVIEN"));
            dataAdapter.Fill(table);
            return table;
        }
        public DataTable getAllHoaDonBy(string maHD)
        {
            DataTable table = new DataTable();
            dataAdapter = selectByQuery(string.Format("select * from HOADON where MAHOADON = '{0}'", maHD));
            dataAdapter.Fill(table);
            return table;
        }
        public DataTable getDataChartSach()
        {
            DataTable table = new DataTable();
            dataAdapter = selectByQuery(string.Format("select S.TENSACH ,count(*) SL from HOADON HD, CTHOADON CT, SACH S WHERE HD.MAHOADON = CT.MAHOADON AND S.MASACH = CT.MASACH GROUP BY CT.MASACH, S.TENSACH"));
            dataAdapter.Fill(table);
            return table;
        }
        //update
        public int updateSach(Sach s)
        {
            try
            {
                dataAdapter = selectSach();
                DataTable Tsach = ResetDataOfTable(dsQLNhaSach.Tables["TSACH"]);
                Tsach = getAllSach();
                setPrimaryKey(Tsach, "MASACH");
                DataRow dr = Tsach.Rows.Find(s.maSach);
                if (dr != null)//tim thay
                {
                    dr["TENSACH"] = s.tenSach;
                    dr["SOLUONGTON"] = s.slTon;
                    dr["GIASACH"] = s.giaSach;
                    dr["MOTA"] = s.moTa;
                    dr["ANHBIA"] = s.anhBia;

                    SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(Tsach);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int updateThongTinSach(ThongTinSach tts)
        {
            try
            {
                dataAdapter = selectByQuery("select * from THONGTINSACH");
                DataTable T = ResetDataOfTable(dsQLNhaSach.Tables["T_THONGTINSACH"]);
                T = getAllThongTinSachBy(tts.maSach);
                setPrimaryKey(T, "MASACH");
                DataRow dr = T.Rows.Find(tts.maSach);
                if (dr != null)//tim thay
                {
                    dr["MATG"] = tts.maTG;
                    dr["MANXB"] = tts.maNXB;
                    dr["MATHELOAI"] = tts.MaTheLoai;

                    SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(T);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int updateNhanVien(NhanVien nv)
        {
            try
            {
                dataAdapter = selectByQuery("Select * from NHANVIEN");
                DataTable T = ResetDataOfTable(dsQLNhaSach.Tables["T_NHANVIEN"]);
                T = getAllNhanVien();
                setPrimaryKey(T, "MANV");
                DataRow dr = T.Rows.Find(nv.maNV);
                if (dr != null)//tim thay
                {
                    dr["TENNV"] = nv.tenNV;
                    dr["NGAYSINH"] = nv.NgaySinh;
                    dr["DIACHI"] = nv.DiaChi;
                    dr["SDT"] = nv.SDT;
                    dr["MATK"] = nv.MaTK;

                    SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(T);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int updateTaiKhoan(Account acc)
        {
            try
            {
                dataAdapter = selectByQuery("Select * from TAIKHOANNV");
                DataTable T = ResetDataOfTable(dsQLNhaSach.Tables["T_TAIKHOANNV"]);
                T = getAllAccount();
                setPrimaryKey(T, "MATK");
                DataRow dr = T.Rows.Find(acc.MaTK);
                if (dr != null)//tim thay
                {
                    dr["TENTK"] = acc.tenTK;
                    dr["MATKHAU"] = acc.matKhau;
                    dr["QUYEN"] = acc.quyen;

                    SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(T);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int updateMemberCard(MemberCard mc)
        {
            try
            {
                dataAdapter = selectByQuery("Select * from THETHANHVIEN");
                DataTable T = new DataTable();
                dataAdapter.Fill(T);
                setPrimaryKey(T, "MATHE");
                DataRow dr = T.Rows.Find(mc.maThe);
                if (dr != null)//tim thay
                {
                    dr["TENTHE"] = mc.tenThe;
                    dr["MALOAITHE"] = mc.maLoaiThe;
                    dr["NGAYCAP"] = mc.ngayCap;

                    SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(T);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int updateKhachHang(KhachHang kh)
        {
            try
            {
                dataAdapter = selectByQuery("Select * from KHACHHANG");
                DataTable T = new DataTable();
                dataAdapter.Fill(T);
                setPrimaryKey(T, "MAKH");
                DataRow dr = T.Rows.Find(kh.maKH);
                if (dr != null)//tim thay
                {
                    dr["TENKH"] = kh.tenKH;
                    dr["GIOITINH"] = kh.gioiTinh;
                    dr["SDT"] = kh.SDT;
                    dr["MATHE"] = kh.maTheTV;

                    SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(T);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int updateCTPhieuNhap(string maPN, string maSach ,int soluong, float giaNhap)
        {
            try
            {
                dataAdapter = selectByQuery("Select * from CTPHIEUNHAP");
                DataTable T = new DataTable();
                dataAdapter.Fill(T);
                set2PrimaryKey(T, "MAPHIEU", "MASACH");
                DataRow dr = T.Rows.Find(new string[] { maPN, maSach });
                if (dr != null)//tim thay
                {
                    dr["SOLUONG"] = soluong;
                    dr["GIASACH"] = giaNhap;

                    SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(T);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int updateSoLuongSachTonKhoKhiBanRa(string maSach, int SLBan)
        {
            try
            {
                dataAdapter = selectSach();
                DataTable Tsach = ResetDataOfTable(dsQLNhaSach.Tables["TSACH"]);
                Tsach = getAllSach();
                setPrimaryKey(Tsach, "MASACH");
                DataRow dr = Tsach.Rows.Find(maSach);
                if (dr != null)//tim thay
                {
                    int old = int.Parse(dr["SOLUONGTON"].ToString());
                    dr["SOLUONGTON"] = old - SLBan;

                    SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(Tsach);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        //insert
        public int insertHoaDon(HoaDon hd)
        {
            try
            {
                dataAdapter = selectByQuery("select * from HOADON"); ;
                DataTable T = new DataTable();
                dataAdapter.Fill(T);
                setPrimaryKey(T, "MAHOADON");
                //insert new Row
                DataRow dr = T.NewRow();
                dr["MAHOADON"] = hd.maHD;
                dr["NGAYBAN"] = hd.ngayBan;
                dr["MANV"] = hd.maNV;
                //check is duplicate
                DataRow drCheck = T.Rows.Find(hd.maHD);
                if (drCheck != null)
                {
                    return 0;
                }
                //insert into TSach
                T.Rows.Add(dr);
                //execute Save
                SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(T);
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int insertCTHoaDon(CTHOADON cthd)
        {
            try
            {
                dataAdapter = selectByQuery("select * from CTHOADON");
                DataTable T = new DataTable();
                dataAdapter.Fill(T);
                set3PrimaryKey(T, "MAHOADON", "MASACH", "MAKHACH");
                //insert new Row
                DataRow dr = T.NewRow();
                dr["MAHOADON"] = cthd.MaHD;
                dr["MASACH"] = cthd.MaSach;
                dr["MAKHACH"] = cthd.MaKH;
                dr["SOLUONG"] = cthd.soLuong;
                //check is duplicate
                DataRow drCheck = T.Rows.Find(new string[] { cthd.MaHD, cthd.MaKH, cthd.MaSach });
                if (drCheck != null)
                {
                    return 0;
                }
                //insert into TSach
                T.Rows.Add(dr);
                //execute Save
                SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(T);
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int insertNewSach(Sach sach)
        {
            try
            {
                dataAdapter = selectSach();
                DataTable Tsach = ResetDataOfTable(dsQLNhaSach.Tables["TSACH"]);
                Tsach = getAllSach();
                setPrimaryKey(Tsach, "MASACH");
                //insert new Row in LOP
                DataRow dr = Tsach.NewRow();
                dr["MASACH"] = sach.maSach;
                dr["TENSACH"] = sach.tenSach;
                dr["SOLUONGTON"] = sach.slTon;
                dr["GIASACH"] = sach.giaSach;
                dr["MOTA"] = sach.moTa;
                dr["ANHBIA"] = sach.anhBia;
                //check is duplicate
                DataRow drCheck = Tsach.Rows.Find(sach.maSach);
                if (drCheck != null)
                {
                    return 0;
                }
                //insert into TSach
                Tsach.Rows.Add(dr);
                //execute Save
                SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(Tsach);
            }
            catch
            {
                return -1;
            }
            return 1;
        } 
        public int insertPhieuNhap(PhieuNhap pn)
        {
            try
            {
                dataAdapter = selectByQuery("select * from PhieuNhap");
                DataTable TPhieuNhap = ResetDataOfTable(dsQLNhaSach.Tables["T_PhieuNhap"]);
                TPhieuNhap = getAllPhieuNhap();
                setPrimaryKey(TPhieuNhap, "MAPN");
                //insert new Row in LOP
                DataRow dr = TPhieuNhap.NewRow();
                dr["MAPN"] = pn.maPN;
                dr["NGAYNHAP"] = pn.NgayNhap;
                dr["MANV"] = pn.maNV;
                //check is duplicate
                DataRow drCheck = TPhieuNhap.Rows.Find(pn.maPN);
                if (drCheck != null)
                {
                    return 0;
                }
                //insert into TSach
                TPhieuNhap.Rows.Add(dr);
                //execute Save
                SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(TPhieuNhap);
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int insertCTPhieuNhap(CTPhieuNhap ctpn)
        {
            try
            {
                dataAdapter = selectByQuery("select * from CTPhieuNhap"); ;
                DataTable TCTPhieuNhap = ResetDataOfTable(dsQLNhaSach.Tables["T_CTPhieuNhap"]);
                TCTPhieuNhap = getAllCTPhieuNhap();
                set2PrimaryKey(TCTPhieuNhap, "MAPHIEU","MASACH");
                //insert new Row in LOP
                DataRow dr = TCTPhieuNhap.NewRow();
                dr["MAPHIEU"] = ctpn.maPN;
                dr["MASACH"] = ctpn.maSach;
                dr["SOLUONG"] = ctpn.soLuongNhap;
                dr["GIASACH"] = ctpn.giaSachNhap;
                //check is duplicate
                DataRow drCheck = TCTPhieuNhap.Rows.Find(new string[] { ctpn.maPN, ctpn.maSach });
                if (drCheck != null)
                {
                    return 0;
                }
                //insert into TSach
                TCTPhieuNhap.Rows.Add(dr);
                //execute Save
                SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(TCTPhieuNhap);
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int insertThongTinSach(ThongTinSach tts)
        {
            try
            {
                dataAdapter = selectByQuery("select * from THONGTINSACH"); ;
                DataTable T_TTS = ResetDataOfTable(dsQLNhaSach.Tables["T_TTS"]);
                T_TTS = getAllThongTinSach();
                set4PrimaryKey(T_TTS, "MASACH", "MATG", "MANXB", "MATHELOAI");
                //insert new Row in LOP
                DataRow dr = T_TTS.NewRow();
                dr["MASACH"] = tts.maSach;
                dr["MATG"] = tts.maTG;
                dr["MANXB"] = tts.maNXB;
                dr["MATHELOAI"] = tts.MaTheLoai;
                //check is duplicate
                DataRow drCheck = T_TTS.Rows.Find(new string[] { tts.maSach, tts.MaTheLoai, tts.maTG, tts.MaTheLoai });
                if (drCheck != null)
                {
                    return 0;
                }
                //insert into TSach
                T_TTS.Rows.Add(dr);
                //execute Save
                SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(T_TTS);
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int insertNewAccount(Account acc)
        {
            try
            {
                dataAdapter = selectByQuery("select * from TAIKHOANNV"); ;
                DataTable T = ResetDataOfTable(dsQLNhaSach.Tables["T_Account"]);
                T = getAllAccount();
                setPrimaryKey(T, "MATK");
                //insert new Row in LOP
                DataRow dr = T.NewRow();
                dr["MATK"] = acc.MaTK;
                dr["TENTK"] = acc.tenTK;
                dr["MATKHAU"] = acc.matKhau;
                dr["QUYEN"] = acc.quyen;
                //check is duplicate
                DataRow drCheck = T.Rows.Find(acc.tenTK);
                if (drCheck != null)
                {
                    return 0;
                }
                //insert into TSach
                T.Rows.Add(dr);
                //execute Save
                SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(T);
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int insertNewNhanVien(NhanVien nv)
        {
            try
            {
                dataAdapter = selectByQuery("select * from NHANVIEN"); ;
                DataTable T = ResetDataOfTable(dsQLNhaSach.Tables["T_NV"]);
                T = getAllNhanVien();
                setPrimaryKey(T, "MANV");
                //insert new Row in LOP
                DataRow dr = T.NewRow();
                dr["MANV"] = nv.maNV;
                dr["TENNV"] = nv.tenNV;
                dr["NGAYSINH"] = nv.NgaySinh;
                dr["DIACHI"] = nv.DiaChi;
                dr["SDT"] = nv.SDT;
                dr["MATK"] = nv.MaTK;
                //check is duplicate
                DataRow drCheck = T.Rows.Find(nv.maNV);
                if (drCheck != null)
                {
                    return 0;
                }
                //insert into TSach
                T.Rows.Add(dr);
                //execute Save
                SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(T);
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int insertMemberCard(MemberCard mc)
        {
            try
            {
                dataAdapter = selectByQuery("select * from THETHANHVIEN"); ;
                DataTable T = new DataTable();
                dataAdapter.Fill(T);
                setPrimaryKey(T, "MATHE");
                //insert new Row
                DataRow dr = T.NewRow();
                dr["MATHE"] = mc.maThe;
                dr["TENTHE"] = mc.tenThe;
                dr["MALOAITHE"] = mc.maLoaiThe;
                dr["NGAYCAP"] = DateTime.Now.ToString("d");
                //check is duplicate
                DataRow drCheck = T.Rows.Find(mc.maThe);
                if (drCheck != null)
                {
                    return 0;
                }
                //insert into TSach
                T.Rows.Add(dr);
                //execute Save
                SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(T);
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int insertKhachHang(KhachHang kh)
        {
            try
            {
                dataAdapter = selectByQuery("select * from KHACHHANG"); ;
                DataTable T = new DataTable();
                dataAdapter.Fill(T);
                setPrimaryKey(T, "MAKH");
                //insert new Row
                DataRow dr = T.NewRow();
                dr["MAKH"] = "KH"+ DateTime.Now.ToString("yy") + (T.Rows.Count > 0 ? T.Rows.Count+1 : 1).ToString("000");
                dr["TENKH"] = kh.tenKH;
                dr["GIOITINH"] = kh.gioiTinh;
                dr["MATHE"] = kh.maTheTV != string.Empty ? kh.maTheTV : null;
                //check is duplicate
                DataRow drCheck = T.Rows.Find(kh.maKH);
                if (drCheck != null)
                {
                    return 0;
                }
                //insert into TSach
                T.Rows.Add(dr);
                //execute Save
                SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Update(T);
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        //delete
        public int deleteSach(string maSach)
        {
            try
            {
                dataAdapter = selectSach();
                DataTable Tsach = ResetDataOfTable(dsQLNhaSach.Tables["TSACH"]);
                Tsach = getAllSach();
                setPrimaryKey(Tsach, "MASACH");
                DataRow dr = Tsach.Rows.Find(maSach);
                if (dr != null)//tim thay
                {
                    dr.Delete();
                    SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(Tsach);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int deleteThongTinChiTiet(ThongTinSach tts)
        {
            try
            {
                dataAdapter = selectByQuery("Select * from THONGTINSACH");
                DataTable T_TTS = ResetDataOfTable(dsQLNhaSach.Tables["T_TTS"]);
                T_TTS = getAllThongTinSach();
                set4PrimaryKey(T_TTS, "MASACH", "MATG", "MANXB", "MATHELOAI");
                DataRow dr = T_TTS.Rows.Find(new string[] {tts.maSach, tts.maTG, tts.maNXB, tts.MaTheLoai });
                if (dr != null)//tim thay
                {
                    dr.Delete();
                    SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(T_TTS);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int deleteCTPhieuNhap(string maPhieuNhap, string maSach)
        {
            try
            {
                dataAdapter = selectByQuery("select * from CTPHIEUNHAP");
                DataTable TCTPhieuNhap = ResetDataOfTable(dsQLNhaSach.Tables["T_CTPhieuNhap"]);
                TCTPhieuNhap = getAllCTPhieuNhap();
                set2PrimaryKey(TCTPhieuNhap,"MAPHIEU", "MASACH");
                DataRow dr = TCTPhieuNhap.Rows.Find(new string[] { maPhieuNhap, maSach });
                if (dr != null)//tim thay
                {
                    dr.Delete();
                    SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(TCTPhieuNhap);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int deletePhieuNhap(string maPhieu)
        {
            try
            {
                dataAdapter = selectByQuery("select * from PHIEUNHAP");
                DataTable T = ResetDataOfTable(dsQLNhaSach.Tables["T_PhieuNhap"]);
                T = getAllPhieuNhap();
                setPrimaryKey(T, "MAPN");
                DataRow dr = T.Rows.Find(maPhieu);
                if (dr != null)//tim thay
                {
                    dr.Delete();
                    SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(T);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int deleteAccount(string tenTK)
        {
            try
            {
                dataAdapter = selectByQuery("select * from TAIKHOANNV");
                DataTable T = ResetDataOfTable(dsQLNhaSach.Tables["T_TAIKHOANNV"]);
                T = getAllAccount();
                setPrimaryKey(T, "TENTK");
                DataRow dr = T.Rows.Find(tenTK);
                if (dr != null)//tim thay
                {
                    dr.Delete();
                    SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(T);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int deleteNhanVien(string maNV)
        {
            try
            {
                dataAdapter = selectByQuery("select * from NHANVIEN");
                DataTable T = ResetDataOfTable(dsQLNhaSach.Tables["T_NV"]);
                T = getAllNhanVien();
                setPrimaryKey(T, "MANV");
                DataRow dr = T.Rows.Find(maNV);
                if (dr != null)//tim thay
                {
                    dr.Delete();
                    SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(T);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int deleteMemberCard(string maThe)
        {
            try
            {
                dataAdapter = selectByQuery("select * from THETHANHVIEN");
                DataTable T = new DataTable();
                dataAdapter.Fill(T);
                setPrimaryKey(T, "MATHE");
                DataRow dr = T.Rows.Find(maThe);
                if (dr != null)//tim thay
                {
                    dr.Delete();
                    SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(T);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }
        public int deleteKhachHang(string maKH)
        {
            try
            {
                dataAdapter = selectByQuery("select * from KHACHHANG");
                DataTable T = new DataTable();
                dataAdapter.Fill(T);
                setPrimaryKey(T, "MAKH");
                DataRow dr = T.Rows.Find(maKH);
                if (dr != null)//tim thay
                {
                    dr.Delete();
                    SqlCommandBuilder cB = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(T);
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                return -1;
            }
            return 1;
        }

        //get Data table multi
        public DataTable getAllInfoPhieuNhapByMa(string maPhieu)
        {
            DataTable t = new DataTable();
            dataAdapter = selectByQuery(string.Format("SELECT PN.*, CTPN.* , NV.TENNV, S.TENSACH FROM PHIEUNHAP PN, CTPHIEUNHAP CTPN, NHANVIEN NV, SACH S WHERE CTPN.MAPHIEU = PN.MAPN AND PN.MANV = NV.MANV AND CTPN.MASACH = S.MASACH and pn.MAPN = '{0}'",maPhieu));
            dataAdapter.Fill(t);
            return t;
        }
        public DataTable getAllSach_TG_NXB_TL()
        {
            DataSet dsTemp = new DataSet();
            dataAdapter = selectByQuery("select s.MASACH, s.TENSACH, s.SOLUONGTON, s.GIASACH, TENTG, TENNXB, TENTL from Sach s, THONGTINSACH tt, TACGIA tg, NHAXUATBAN nxb, THELOAI tl where s.MASACH = tt.MASACH and tg.MATG = tt.MATG and tl.MATL = tt.MATHELOAI and nxb.MANXB = tt.MANXB");
            dataAdapter.Fill(dsTemp, "TSach_NXB_TG_TL");
            return dsTemp.Tables["TSach_NXB_TG_TL"];
        }
        public DataTable getAllSach_TG_NXB_TLContain(string name)
        {
            DataTable t = new DataTable();
            dataAdapter = selectByQuery(string.Format("select s.MASACH, s.TENSACH, s.SOLUONGTON, s.GIASACH, TENTG, TENNXB, TENTL from Sach s, THONGTINSACH tt, TACGIA tg, NHAXUATBAN nxb, THELOAI tl where s.MASACH = tt.MASACH and tg.MATG = tt.MATG and tl.MATL = tt.MATHELOAI and nxb.MANXB = tt.MANXB and s.TENSACH LIKE N'%{0}%'", name));
            dataAdapter.Fill(t);
            return t;
        }
        public DataTable getAllSachByMaSachLike(string maSach)
        {
            DataTable table = new DataTable();
            query = string.Format(@"select s.MASACH, s.TENSACH, s.SOLUONGTON, s.GIASACH, TENTG, TENNXB, TENTL from Sach s, THONGTINSACH tt, TACGIA tg, NHAXUATBAN nxb, THELOAI tl where s.MASACH = tt.MASACH and tg.MATG = tt.MATG and tl.MATL = tt.MATHELOAI and nxb.MANXB = tt.MANXB and s.MASACH LIKE N'%{0}%'", maSach);
            dataAdapter = selectByQuery(query);

            dataAdapter.Fill(table);

            return table;
        }
        public DataTable getAllSach_TG_NXB_TL_FilterTheLoai(string MaTL)
        {
            DataTable t = new DataTable();
            dataAdapter = selectByQuery(string.Format("select s.MASACH, s.TENSACH, s.SOLUONGTON, s.GIASACH, TENTG, TENNXB, TENTL from Sach s, THONGTINSACH tt, TACGIA tg, NHAXUATBAN nxb, THELOAI tl where s.MASACH = tt.MASACH and tg.MATG = tt.MATG and tl.MATL = tt.MATHELOAI and nxb.MANXB = tt.MANXB and tt.MATHELOAI = '{0}'", MaTL));
            dataAdapter.Fill(t);
            return t;
        }
        public DataTable getAllSach_TG_NXB_TL_FilterNhaXuatBan(string MaNXB)
        {
            DataTable t = new DataTable();
            dataAdapter = selectByQuery(string.Format("select s.MASACH, s.TENSACH, s.SOLUONGTON, s.GIASACH, TENTG, TENNXB, TENTL from Sach s, THONGTINSACH tt, TACGIA tg, NHAXUATBAN nxb, THELOAI tl where s.MASACH = tt.MASACH and tg.MATG = tt.MATG and tl.MATL = tt.MATHELOAI and nxb.MANXB = tt.MANXB and nxb.MANXB = '{0}'", MaNXB));
            dataAdapter.Fill(t);
            return t;
        }
        public DataTable getAllPhieuNhapSach()
        {
            DataSet dsTemp = new DataSet();
            dataAdapter = selectByQuery("select * from PHIEUNHAP");

            dataAdapter.Fill(dsTemp, "T_PhieuNhap_Sach");
            return dsTemp.Tables["T_PhieuNhap_Sach"];
        }
        public DataTable getAllAccountAndNameNV()
        {
            DataSet dsTemp = new DataSet();
            dataAdapter = selectByQuery("select tk.*, nv.MANV, nv.TENNV from TAIKHOANNV tk, NHANVIEN nv where tk.MATK = nv.MATK");

            dataAdapter.Fill(dsTemp, "T_Account_NV");
            return dsTemp.Tables["T_Account_NV"];
        }
        public DataTable getAllMemberCardAndInfo()
        {
            DataSet dsTemp = new DataSet();
            dataAdapter = selectByQuery("select kh.MAKH, kh.TENKH, kh.GIOITINH, kh.MATHE, ttv.TENTHE, ttv.NGAYCAP, lt.CHIETKHAU from KHACHHANG kh, THETHANHVIEN ttv, LOAITHE lt where kh.MATHE = ttv.MATHE and ttv.MALOAITHE = lt.MALOAITHE");

            dataAdapter.Fill(dsTemp, "T_CardMember_Info");
            return dsTemp.Tables["T_CardMember_Info"];
        }
        public DataTable getAllMemberCardAndInfo(string maThe)
        {
            DataTable t = new DataTable();
            dataAdapter = selectByQuery(string.Format("select kh.MAKH, kh.TENKH, kh.GIOITINH, kh.MATHE, ttv.TENTHE, ttv.NGAYCAP, lt.CHIETKHAU, kh.SDT, lt.MALOAITHE from KHACHHANG kh, THETHANHVIEN ttv, LOAITHE lt where kh.MATHE = ttv.MATHE and ttv.MALOAITHE = lt.MALOAITHE and kh.MATHE = '{0}'", maThe));

            dataAdapter.Fill(t);
            return t;
        }
        public DataTable getAccountByUsername(string username)
        {
            DataSet loginUser = new DataSet();
            query = string.Format(@"select MANV, TENTK, MATKHAU, TENNV, QUYEN from TAIKHOANNV, NHANVIEN where TENTK = '{0}' and TAIKHOANNV.MATK = NHANVIEN.MATK", username);
            dataAdapter = selectByQuery(query);

            dataAdapter.Fill(loginUser, "T_AccountByUsername");

            return loginUser.Tables["T_AccountByUsername"];
        }

        public DataTable getHoaDonBy(DateTime date) {
            DataTable t = new DataTable();
            query = string.Format(@"SELECT HOADON.MAHOADON, HOADON.NGAYBAN, CTHOADON.SOLUONG, CTHOADON.MASACH, SACH.TENSACH, SACH.GIASACH, KHACHHANG.TENKH, NHANVIEN.TENNV FROM HOADON, CTHOADON, SACH, KHACHHANG, NHANVIEN WHERE HOADON.MAHOADON = CTHOADON.MAHOADON  AND CTHOADON.MAKHACH = KHACHHANG.MAKH AND CTHOADON.MASACH = SACH.MASACH AND HOADON.MANV = NHANVIEN.MANV AND DAY(NGAYBAN) = {0} AND MONTH(NGAYBAN) = {1} AND YEAR(NGAYBAN) = {2}", date.Day, date.Month, date.Year);
            dataAdapter = selectByQuery(query);

            dataAdapter.Fill(t);

            return t;
        }
        public DataTable getInfoDetailsBook(string maSach)
        {
            DataSet dsTemp = new DataSet();
            query = string.Format(@"select s.*, nxb.TENNXB, tl.TENTL, tg.TENTG from SACH s, NHAXUATBAN nxb, TACGIA tg, THELOAI tl, THONGTINSACH tts where s.MASACH = tts.MASACH and tl.MATL = tts.MATHELOAI and tg.MATG = tts.MATG and nxb.MANXB = tts.MANXB and s.MASACH = '{0}'", maSach);
            dataAdapter = selectByQuery(query);

            dataAdapter.Fill(dsTemp, "T_DetaisBook");

            return dsTemp.Tables["T_DetaisBook"];
        }
        public DataTable getAllHoaDonDetail()
        {
            DataSet dsNew = new DataSet();
            query = string.Format(@"select hd.MAHOADON, hd.NGAYBAN, cthd.MASACH, s.TENSACH, kh.TENKH, cthd.SOLUONG, s.GIASACH, hd.MANV from HOADON hd, CTHOADON cthd, KHACHHANG kh, SACH s where hd.MAHOADON = cthd.MAHOADON and kh.MAKH = cthd.MAKHACH and s.MASACH = cthd.MASACH");
            dataAdapter = selectByQuery(query);

            dataAdapter.Fill(dsNew, "T_DetailsHoaDon");

            return dsNew.Tables["T_DetailsHoaDon"];
        }
        public DataTable getAllHoaDonDetailByDate(DateTime date)
        {
            DataSet dsNew = new DataSet();
            query = string.Format(@"select hd.MAHOADON, hd.NGAYBAN, cthd.MASACH, s.TENSACH, kh.TENKH, cthd.SOLUONG, s.GIASACH, hd.MANV from HOADON hd, CTHOADON cthd, KHACHHANG kh, SACH s where hd.MAHOADON = cthd.MAHOADON and kh.MAKH = cthd.MAKHACH and s.MASACH = cthd.MASACH and DAY(NGAYBAN) = {0} and MONTH(NGAYBAN) = {1} and YEAR(NGAYBAN) = {2}", date.Day, date.Month, date.Year);
            dataAdapter = selectByQuery(query);

            dataAdapter.Fill(dsNew, "T_DetailsHoaDonByDate");

            return dsNew.Tables["T_DetailsHoaDonByDate"];
        }

        // caculator
        public float getSumThanhTien()
        {
            query = "select SUM(s.GIASACH*SOLUONG) from HOADON hd, CTHOADON cthd, SACH s where hd.MAHOADON = cthd.MAHOADON and s.MASACH = cthd.MASACH";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            float sum = 0;
            string temp = cmd.ExecuteScalar().ToString();
            if (temp != string.Empty)
                sum = float.Parse(temp);
            conn.Close();
            return sum;
        }
        public float getSumThanhTienByDate(DateTime date)
        {
            query = string.Format("select SUM(GIASACH*SOLUONG) from HOADON hd, CTHOADON cthd, SACH s where hd.MAHOADON = cthd.MAHOADON and s.MASACH = cthd.MASACH and DAY(NGAYBAN) = {0} and MONTH(NGAYBAN) = {1} and YEAR(NGAYBAN) = {2}", date.Day, date.Month, date.Year);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            float sum = 0;
            string temp = cmd.ExecuteScalar().ToString();
            if(temp != string.Empty)
                sum = float.Parse(temp);
            conn.Close();
            return sum;
        }
        public float getThanhTienSachWith(string maSach, int sl)
        {
            query = string.Format("select {0} * GIASACH as THANHTIEN from SACH where MASACH = '{1}'", sl, maSach);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            float kq = 0;
            string temp = cmd.ExecuteScalar().ToString();
            if (temp != string.Empty)
                kq = float.Parse(temp);
            conn.Close();
            return kq;
            
        }
    }
}
