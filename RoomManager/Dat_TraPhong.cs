using RoomManager.Controller;
using RoomManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomManager
{
    public partial class Dat_TraPhong : Form
    {
        private static RoomController roomController = new RoomController();
        private static CustomerController customerController = new CustomerController();
        public string username;
        public Dat_TraPhong()
        {
            InitializeComponent();
        }
        private void updatePhongdatTable(Room[] rooms)
        {
            Grid_datphong.Rows.Clear();

            foreach (var room in rooms)
            {
                Grid_datphong.Rows.Add(room.ID, room.Name, room.Status);
            }
        }
        private void Dat_TraPhong_Load(object sender, EventArgs e)
        {
            Room[] rooms = roomController.GetAllRooms();
            updatePhongdatTable (rooms);
            User user = customerController.GetUser(username);
            TB_tenDatphong.Text = user.Name;
            TB_sdtDatphong.Text = user.PhoneNumber;
            string[] descriptions = roomController.GetAllRoomDescriptions();
            foreach(string d  in descriptions)
            {
                CBB_motaPhong.Items.Add(d);
            }
            Price1_traphong_caculate();
        }
        private void Price_datphong_caculate()
        {
            TimeSpan duration_Day = datePick_tra_datphong.Value.Date - datePick_dat_datphong.Value.Date;
            int totalDay_datphong = duration_Day.Days;
            int totalMoney_datphong = totalDay_datphong * 50000;
            LB_money_datphong.Text = totalMoney_datphong.ToString("N0") + "VNĐ";
        }
        private void Price1_traphong_caculate()
        {
            TimeSpan duration_Day = datePick_tra1_traphong.Value.Date - datePick_dat_traphong.Value.Date;
            int firstTotalDay_traphong = duration_Day.Days;
            int firstMoney_traphong = firstTotalDay_traphong * 50000;
            LB_firstMoney_traphong.Text = firstMoney_traphong.ToString("N0") + "VNĐ";
        }
        private void Price2_traphong_caculate()
        {
            TimeSpan duration_Day_first = datePick_tra1_traphong.Value.Date - datePick_dat_traphong.Value.Date;
            TimeSpan duration_Day_second = datePick_tra2_traphong.Value.Date - datePick_dat_traphong.Value.Date;
            int firstTotalDay_traphong = duration_Day_first.Days;
            int secondTotalDay_traphong = duration_Day_second.Days;
            int totalMoney_traphong = firstTotalDay_traphong * 50000;
            if (secondTotalDay_traphong < firstTotalDay_traphong)
            {
                int reduceDays = firstTotalDay_traphong - secondTotalDay_traphong;
                totalMoney_traphong -= reduceDays * 50000;
            }
            else if (secondTotalDay_traphong > firstTotalDay_traphong)
            {
                int extraDays = secondTotalDay_traphong - firstTotalDay_traphong;
                totalMoney_traphong += extraDays * 15000;
            }
            LB_total_traphong.Text = totalMoney_traphong.ToString("N0") + "VNĐ";
        }
        private void datePick_datphong_ValueChanged(object sender, EventArgs e)
        {
            Price_datphong_caculate();
        }
        private void datePick_traphong_ValueChanged(object sender, EventArgs e)
        {
            Price2_traphong_caculate();
        }
        private void BNT_datphong_Click(object sender, EventArgs e)
        {
            SqlDateTime checkin = datePick_dat_datphong.Value;
            SqlDateTime checkout = datePick_tra_datphong.Value;

            DialogResult result_datphong = MessageBox.Show("Bạn chắc chắn với các thông tin của mình chưa ?", "Xác nhận đặt phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result_datphong == DialogResult.Yes)
            {

                MessageBox.Show("Bạn đã đặt phòng thành công!", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void BTN_traphong_Click(object sender, EventArgs e)
        {
            DialogResult result_traphong = MessageBox.Show("Bạn xác nhận các thông tin và đồng ý thanh toán trả phòng ?", "Xác nhận trả phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result_traphong == DialogResult.Yes)
            {
                MessageBox.Show("Bạn đã trả phòng và thanh toán thành công!", "Thông báo xác nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void CBB_motaPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (comboBox.Text == "")
            {
                updatePhongdatTable(roomController.GetAllRooms());
            }
            else
            {
                updatePhongdatTable(roomController.SearchRoomByName(comboBox.Text));
            }
        }
        private void Grid_datphong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid_datphong.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Grid_datphong.SelectedRows[0];
                string phongDangdat = selectedRow.Cells[1].Value .ToString();
                LB_PhongdangDat.Text = phongDangdat;
            }
        }
    }
}
