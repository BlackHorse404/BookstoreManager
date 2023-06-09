using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QuanLyNhaSach.DataAccess;
using QuanLyNhaSach.Models;

namespace QuanLyNhaSach.Bussiness
{
    class BookstoreBussiness
    {
        //field
        private ConnectDB db;

        //constructor 
        public BookstoreBussiness()
        {
            db = new ConnectDB();
        }

        //method bussiness
        //check login
        public bool checkLoginAccount(string username, string password, ref string lastname, ref string maNV, out int quyen)
        {
            string Tusername, Tpassword;
            quyen = -1;
            DataTable TAccount = db.getAccountByUsername(username);
            if(TAccount.Rows.Count != 0)
            {
                Tusername = TAccount.Rows[0]["TENTK"].ToString().Trim();
                Tpassword = TAccount.Rows[0]["MATKHAU"].ToString().Trim();
                quyen = int.Parse(TAccount.Rows[0]["QUYEN"].ToString());
                //check login
                if (Tusername == username && Tpassword == password)
                {
                    lastname = "Quản Lý";
                    maNV = TAccount.Rows[0]["MANV"].ToString();
                    if (username.ToLower() != "quanly")
                    {
                        string[] temp = TAccount.Rows[0]["TENNV"].ToString().Trim().Split(' ');
                        lastname = temp[temp.Length - 2] +" "+temp[temp.Length - 1];
                    }
                    return true;
                }
            }
            else if(username == "admin" && password == "admin")
            {
                TAccount = db.getAccountByUsername("quanly");
                lastname = "Administrator";
                maNV = TAccount.Rows[0]["MANV"].ToString().Trim();
                return true;
            }
            return false;
        }
        //load data

        public DataTable loadDataForChartSach()
        {
            return db.getDataChartSach();
        }

        public float layThanhTienSachWith(string maSach, int sl)
        {
            return db.getThanhTienSachWith(maSach, sl);
        }
        public DataTable loadDataSach()
        {
            return db.getAllSach();
        }
        public DataTable loadDataForListBook()
        {
            return db.getAllSach_TG_NXB_TL();
        }

        public DataTable loadDataForListAccount()
        {
            return db.getAllAccountAndNameNV();
        }

        public DataTable loadDataForListMemberCard()
        {
            return db.getAllMemberCardAndInfo();
        }
        
        public DataTable loadDataForListPhieuNhap()
        {
            return db.getAllPhieuNhapSach();
        }

        public BookDetails_Model loadInfoBookDetails(string maSach)
        {
            try
            {
                DataTable tInfo = db.getInfoDetailsBook(maSach);
                BookDetails_Model b = new BookDetails_Model(
                    tInfo.Rows[0]["MASACH"].ToString(),
                    tInfo.Rows[0]["TENSACH"].ToString(),
                    tInfo.Rows[0]["TENNXB"].ToString(),
                    tInfo.Rows[0]["TENTG"].ToString(),
                    tInfo.Rows[0]["TENTL"].ToString(),
                    tInfo.Rows[0]["MOTA"].ToString(),
                    int.Parse(tInfo.Rows[0]["SOLUONGTON"].ToString()),
                    float.Parse(tInfo.Rows[0]["GIASACH"].ToString()),
                    tInfo.Rows[0]["ANHBIA"].ToString()
                );
                return b;
            }
            catch
            {
                return null;
            }
            
        }

        public DataTable loadDataNXB()
        {
            return db.getAllNXB();
        }
        
        public DataTable loadDataTacGia()
        {
            return db.getAllTacGia();
        }

        public DataTable loadDataTheLoai()
        {
            return db.getAllTheLoai();
        }

        public DataTable loadDataSachByMaSach(string maSach)
        {
            return db.getAllSachByMaSach(maSach);
        }

        public DataTable loadDataDetailSachByMaSach(string maSach)
        {
            return db.getInfoDetailSachByMaSach(maSach);
        }

        public DataTable loadDataHoaDonDetails()
        {
            return db.getAllHoaDonDetail();
        }

        public DataTable loadDataHoaDonDetailsByDate(DateTime date)
        {
            return db.getAllHoaDonDetailByDate(date);
        }

        public DataTable loadDataNhanVien()
        {
            return db.getAllNhanVien();
        }

        public DataTable loadDataTaiKhoan()
        {
            return db.getAllAccount();
        }

        public DataTable loadDataNhanVienBy(string maNV)
        {
            return db.getNhanVienBy(maNV);
        }

        public DataTable loadDataTaiKhoanBy(string tenTK)
        {
            return db.getAccountBy(tenTK);
        }

        public DataTable loadDataTaiKhoanNhanVienNotUse()
        {
            return db.getAllAccountMaNVNull();
        }

        public DataTable loadDataHoaDonBy(DateTime date)
        {
            return db.getHoaDonBy(date);
        }
        public DataTable loadDataHoaDonBy(string maHD)
        {
            return db.getAllHoaDonBy(maHD);
        }

        public DataTable loadDataLoaiThe()
        {
            return db.getAllLoaiThe();
        }

        public DataTable loadDataKhachHang()
        {
            return db.getAllKhachHang();
        }

        public DataTable loadDataMemberCardAndInfoByMaThe(string maThe)
        {
            return db.getAllMemberCardAndInfo(maThe);
        }

        public DataSet loadDataForBill(string maHD, string maKH)
        {
            DataSet t = new DataSet();
            t.Tables.Add(db.getAllCTHoaDonBy(maHD, maKH));
            return t;
        }

        public DataTable loadDataPhieuNhapByMaPhieu(string maPhieu)
        {
            return db.getAllInfoPhieuNhapByMa(maPhieu);
        }
        public DataTable loadDataCTPhieuNhap(string maPhieu)
        {
            return db.getAllCTPhieuNhap(maPhieu);
        }
        //search
        public DataTable searchSachWithMaSach(string maSach)
        {
            return db.getAllSachByMaSachLike(maSach);
        }
        public DataTable searchSachWithName(string name)
        {
            return db.getAllSach_TG_NXB_TLContain(name);
        }
        public DataTable filterSachByTheLoai(string MaTL)
        {
            return db.getAllSach_TG_NXB_TL_FilterTheLoai(MaTL);
        }
        public DataTable filterSachByNXB(string MaNXB)
        {
            return db.getAllSach_TG_NXB_TL_FilterNhaXuatBan(MaNXB);
        }
        // tính toán tổng tiền
        public float SumMoney()
        {
            return db.getSumThanhTien();
        }

        public float SumMoneyByDate(DateTime date)
        {
            return db.getSumThanhTienByDate(date);
        }
        
        //thêm, xóa sửa dữ liệu
        public int insertSach(string maSach, string tenSach, int SLTon, float giaSach, string moTa, string anhBia)
        {
            Sach s = new Sach() {
                maSach = maSach,
                tenSach = tenSach,
                slTon = SLTon,
                giaSach = giaSach,
                moTa = moTa,
                anhBia = anhBia
            };

            return db.insertNewSach(s);
        }
        public int insertPhieuNhapAndCTPhieuNhap(string maPN, string maSach, int SLSachNhap, string maNV, float giaSachNhap)
        {
            PhieuNhap pn = new PhieuNhap()
            {
                maPN = maPN,
                maNV = maNV,
                NgayNhap = DateTime.Now.Date
            };
            CTPhieuNhap ctpn = new CTPhieuNhap()
            {
                maPN = maPN,
                maSach = maSach,
                soLuongNhap = SLSachNhap,
                giaSachNhap = giaSachNhap
            };
            int kq = db.insertPhieuNhap(pn);
            if (kq == 1)
                kq = db.insertCTPhieuNhap(ctpn);
            return kq;
        }
        public int insertTaiKhoan(string tenTK, string matKhau, int Quyen)
        {
            int num = loadDataTaiKhoan().Rows.Count;
            string maTK = "TK" + (num > 0 ? num : 0).ToString("000");
            Account acc = new Account()
            {
                MaTK = maTK,
                tenTK = tenTK,
                matKhau = matKhau,
                quyen = Quyen
            };
            return db.insertNewAccount(acc);
        }
        public int insertThongTinChiTietSach(string maSach, string maTacGia, string maNXB, string maTheLoai)
        {
            ThongTinSach tts = new ThongTinSach()
            {
                maSach = maSach,
                maTG = maTacGia,
                maNXB = maNXB,
                MaTheLoai = maTheLoai
            };
            return db.insertThongTinSach(tts);
        }
        public int insertNhanVien(string maNV, string tenNV, DateTime NgaySinh, string Diachi, string sdt, string maTK)
        {
            NhanVien nv = new NhanVien() {
                maNV = maNV,
                tenNV = tenNV,
                NgaySinh = NgaySinh,
                DiaChi = Diachi,
                SDT = sdt,
                MaTK = maTK
            };
            return db.insertNewNhanVien(nv);
        }
        public int insertMemberCard(string maThe, string tenKH, string gioiTinh, string sdt, string tenThe, string loaiThe)
        {
            MemberCard mc = new MemberCard()
            {
                maThe = maThe,
                tenThe = tenThe,
                maLoaiThe = loaiThe
            };

            KhachHang kh = new KhachHang()
            {
                tenKH = tenKH,
                gioiTinh = gioiTinh,
                SDT = sdt,
                maTheTV = mc.maThe
            };
            int kq = db.insertMemberCard(mc);
            if(kq == 1)
                kq = db.insertKhachHang(kh);
            return kq;
        }
        public int insertHoaDonAndCTHoaDon(string maSach, string tenKH, string maNV, int sl,ref string maHD, out string maKH)
        {
            int kq = -1;
            bool permiss = false;
            //khoi tao mã hoadon
            DataTable T = db.getAllHoaDon();
            if (maHD == string.Empty)
            {
                permiss = true;
                maHD = "HD" + DateTime.Now.ToString("yy") + (T.Rows.Count > 0 ? T.Rows.Count + 1 : 1).ToString("000");
            }
            //tim ma KH
            maKH = string.Empty;
            DataTable KHs = loadDataKhachHang();
            foreach (DataRow r in KHs.Rows)
            {
                if(r["TENKH"].ToString().Trim().Equals(tenKH))
                {
                    maKH = r["MAKH"].ToString().Trim();
                    break;
                }
            }
            //neu chua ton tai KH thi add KH moi
            if (maKH == string.Empty)
            {
                maKH = "KH" + DateTime.Now.ToString("yy") + (KHs.Rows.Count > 0 ? KHs.Rows.Count + 1 : 1).ToString("000");
                KhachHang kh = new KhachHang()
                {
                    maKH = maKH,
                    tenKH = tenKH,
                    SDT = null,
                    gioiTinh = "Nam",
                    maTheTV = null
                };
                kq = db.insertKhachHang(kh);
            }
            else
                kq = 2;
          
            HoaDon hd = new HoaDon()
            {
                maHD = maHD,
                maNV = maNV,
                ngayBan = DateTime.Now
            };
            CTHOADON cthd = new CTHOADON() {
                MaHD = maHD,
                MaKH = maKH,
                MaSach = maSach,
                soLuong = sl
            };

            if ((kq == 2 || kq == 1) && permiss)
            {
                kq = db.insertHoaDon(hd);
            }
            else
                kq = 3;

            if (kq == 1 || kq == 3)
                kq = db.insertCTHoaDon(cthd);
            return kq;

        }

        public int updateSLSachTrongKho(string maSach, int slBan)
        {
            return db.updateSoLuongSachTonKhoKhiBanRa(maSach, slBan);
        }

        public int deleteSachFromTable(string maSach)
        {
            int kq = 0;
            DataTable T_tts = db.getAllThongTinSachBy(maSach);
            foreach(DataRow r in T_tts.Rows)
            {
                ThongTinSach tts = new ThongTinSach()
                {
                    maSach = maSach,
                    maNXB = r["MANXB"].ToString(),
                    maTG = r["MATG"].ToString(),
                    MaTheLoai = r["MATHELOAI"].ToString()
                };
                kq = db.deleteThongTinChiTiet(tts);
            }
            
            List<string> lMaPhieu = db.getAllMaPhieuOfSachBy(maSach);
            for(int i = 0; i < lMaPhieu.Count; i++)
            {
                if(kq == 1)
                    kq = db.deleteCTPhieuNhap(lMaPhieu[i], maSach);
                if (kq == 1)
                    kq = db.deletePhieuNhap(lMaPhieu[i]);   
            }
            if (kq == 1)
                kq = db.deleteSach(maSach);
            return kq;
        }
        public int deleteTaiKhoan(string username)
        {
            return db.deleteAccount(username);
        }
        public int deleteNhanVien(string maNV)
        {
            return db.deleteNhanVien(maNV);
        }
        public int deleteMemberCard(string maThe, string maKH, string tenKH, string gioiTinh, string sdt)
        {
            KhachHang kh = new KhachHang()
            {
                maKH = maKH,
                tenKH = tenKH,
                gioiTinh = gioiTinh,
                SDT = sdt,
                maTheTV = null
            };
            int kq = db.updateKhachHang(kh);
            if(kq == 1)
                kq = db.deleteMemberCard(maThe);
            return kq;
        }

        public int updateCTPhieuNhap(string maPhieu, string maSach, int sl, float gia)
        {
            return db.updateCTPhieuNhap(maPhieu, maSach, sl, gia);
        }
        public int updateSach(string maSach, string tenSach, int SLTon, float giaSach, string moTa, string anhBia, string maTG, string maNXB, string maTL)
        {
            Sach s = new Sach() {
                maSach = maSach,
                tenSach = tenSach,
                slTon = SLTon,
                giaSach = giaSach,
                moTa = moTa,
                anhBia = anhBia
            };

            ThongTinSach tts = new ThongTinSach() {
                maSach = maSach, 
                maTG = maTG,
                MaTheLoai = maTL,
                maNXB = maNXB
            };

            int kq = db.updateThongTinSach(tts);
            if (kq == 1)
                kq = db.updateSach(s);
            return kq;
        }
        public int updateTaiKhoan(string maTK, string tenTK, string matKhau, int Quyen)
        {
            Account acc = new Account()
            {
                MaTK = maTK,
                tenTK = tenTK,
                matKhau = matKhau,
                quyen = Quyen
            };
            return db.updateTaiKhoan(acc);
        }
        public int updateNhanVien(string maNV, string tenNV, DateTime NgaySinh, string Diachi, string sdt, string maTK)
        {
            NhanVien nv = new NhanVien()
            {
                maNV = maNV,
                tenNV = tenNV,
                NgaySinh = NgaySinh,
                DiaChi = Diachi,
                SDT = sdt,
                MaTK = maTK
            };
            return db.updateNhanVien(nv);
        }
        public int updateMembercard(string maThe, string maKH, string tenKH, string gioiTinh, string sdt, string tenThe, string maLoaiThe)
        {
            MemberCard mc = new MemberCard() {
                maThe = maThe,
                ngayCap = DateTime.Now.Date,
                maLoaiThe = maLoaiThe,
                tenThe = tenThe
            };

            KhachHang kh = new KhachHang()
            {
                maKH = maKH,
                tenKH = tenKH,
                gioiTinh = gioiTinh,
                SDT = sdt,
                maTheTV = maThe
            };
            int kq = db.updateMemberCard(mc);
            if (kq == 1)
                kq = db.updateKhachHang(kh);
            return kq;
        }
    }
}
