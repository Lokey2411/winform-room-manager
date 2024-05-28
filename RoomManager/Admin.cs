using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using RoomManager.Controller;
using RoomManager.Models;

namespace RoomManager
{
    public partial class Admin : Form
    {
        //room form controller
        private static RoomController roomController = new RoomController();
        private void updateRoomsTable(Room[] rooms)
        {
            //update rooms table depend on data
            roomTable.Rows.Clear();

            // Thêm các đối tượng Room vào DataGridView
            foreach (var room in rooms)
            {
                roomTable.Rows.Add(room.ID, room.Name, room.Status);
            }
        }
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, System.EventArgs e)
        {
            //get all rooms while load form
            Room[] rooms = roomController.GetAllRooms();
            updateRoomsTable(rooms);
            updateCustomersTable(customerController.GetAllCustomers());
        }

        private void addRoomBtn_Click(object sender, System.EventArgs e)
        {
            //add rooms
            string name = roomNameTB.Text.Trim();
            string status = roomStatusCB.Text.Trim();
            if(name == "" || status == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            int httpStatus = roomController.AddNewRoom(name, status);
            switch (httpStatus) {
                case 200:
                    //success
                    MessageBox.Show("Thêm mới thành công!");
                    updateRoomsTable(roomController.GetAllRooms());
                    break;
                case 409:
                    //duplicated data
                    MessageBox.Show("Phòng đã thêm! Xin vui lòng nhập lại");
                    break;
                case 500:
                    // server error
                    MessageBox.Show("Xin lỗi! Yêu cầu không thể được xử lý");
                    break;
                default: 
                    //unknown error
                    MessageBox.Show("Lỗi không xác định! Xin vui lòng thử lại");
                    break;
            }

        }

        private void searchTB_TextChanged(object sender, System.EventArgs e)
        {
            //get the searchTB
            TextBox target = (TextBox)sender;
            if (target.Text == "")
            {
                //if nothing is texted, get all rooms
                updateRoomsTable(roomController.GetAllRooms());
            }
            else
            {
                //get the data
                updateRoomsTable(roomController.SearchRoomByName(target.Text));
            }
        }

        private void removeRoomBtn_Click(object sender, System.EventArgs e)
        {
            //show the alert that allow user to confirm the delete 
            string message = "Bạn có chắc chắn muốn xóa phòng";
            string title = "Thông báo";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);  // show the messagebox then get the user's yes or no
            if (result == DialogResult.Yes)
            {
                //remove data   
                //get the selected row
                if (roomTable.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = roomTable.SelectedRows[0];
                    int id = Convert.ToInt32(selectedRow.Cells["IdColumn"].Value.ToString());
                    int status = roomController.RemoveRoom(id);
                    switch (status)
                    {
                        case 200:
                            //success
                            MessageBox.Show("Xóa thành công!");
                            updateRoomsTable(roomController.GetAllRooms());
                            break;
                        case 400:
                            //  request can't handle
                            MessageBox.Show("Không tìm thấy phòng");
                            break;
                        case 500: 
                            // internal error
                            break;
                        default: 
                            //unknown error
                            MessageBox.Show("Lỗi không xác định"); break;
                    }
                }
            }
        }
        //customer form controller
        private static CustomerController customerController = new CustomerController();
        private void updateCustomersTable(Customer[] customers)
        {
            //update rooms table depend on data
            customerTable.Rows.Clear();

            // Thêm các đối tượng Room vào DataGridView
            foreach (var customer in customers)
            {
                customerTable.Rows.Add(customer.ID, customer.Name, customer.PhoneNumber, customer.checkInDate, customer.checkOutDate, customer.room.Name);
            }
        }
        private DataGridViewRow getSelectedRow(DataGridView dataGridView)
        {
            return dataGridView.SelectedRows[0];
        }

        private void customerTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //get selected row
            DataGridViewRow selectedRow = getSelectedRow(customerTable);
            //set TB values
            customerIdTB.Text = selectedRow.Cells[0].Value.ToString();
            customerNameTB.Text = selectedRow.Cells[1].Value.ToString();
            phoneNumberTB.Text = selectedRow.Cells[2].Value.ToString();
            checkInDateTB.Text = selectedRow.Cells[3].Value.ToString();
            checkOutDateTB.Text = selectedRow.Cells[4].Value.ToString();
            bookedRoomNameTB.Text = selectedRow.Cells[5].Value.ToString();
        }

        private void searchCustomerTB_TextChanged(object sender, EventArgs e)
        {
            TextBox target = (TextBox)sender;
            if (target.Text == "")
            {
                //if the input is an empty string
                updateCustomersTable(customerController.GetAllCustomers());
            }
            else
            {
                updateCustomersTable(customerController.SearchCustomer(target.Text));
            }
        }
    }
}
