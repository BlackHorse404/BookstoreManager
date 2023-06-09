using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyNhaSach.Models
{
    public class BookDetails_Model
    {
        public string maSach { get; set; }
        public string tenSach { get; set; }
        public string nxb { get; set; }
        public string tacGia { get; set; }
        public string theLoai { get; set; }
        public string moTa { get; set; }
        public int slTon { get; set; }
        public float giaSach { get; set; }
        public string anhBia { get; set; }

        public BookDetails_Model(string maSach, string tenSach, string nxb, string tacGia, string theLoai, string moTa, int slTon, float giaSach, string anhBia)
        {
            this.maSach = maSach;
            this.nxb = nxb;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.theLoai = theLoai;
            this.moTa = moTa;
            this.slTon = slTon;
            this.giaSach = giaSach;
            this.anhBia = anhBia;
        } 
    }
}
