using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;

namespace QuanLyNhaSach.Extensions
{
    public static class Ultilities
    {
        public static string maNV { get; set; }
        public static void fillDataCombobox(ComboBox t, DataTable src, string display, string value)
        {
            t.DataSource = src;
            t.DisplayMember = display;
            t.ValueMember = value;
        }

        public static int getIndexFromDataTable(DataTable table, string ColumnName, string value)
        {
            int index = -1;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i][ColumnName].ToString().Equals(value))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static void showDialogNotice(int state, string nameAction, string messError)
        {
            if(state == 1)
            {
                MessageBox.Show(nameAction + " Thành Công !","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(state == 0)
            {
                MessageBox.Show(messError, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Có lỗi bất định xảy ra !","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
