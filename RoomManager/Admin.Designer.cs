namespace RoomManager
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.removeRoomBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.addRoomBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.roomNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.roomTable = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.customerIdTB = new System.Windows.Forms.TextBox();
            this.bookedRoomNameTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkOutDateTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkInDateTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneNumberTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchCustomerTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customerNameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.customerTable = new System.Windows.Forms.DataGridView();
            this.customerIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookedRoomColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.HotPink;
            this.tabPage1.Controls.Add(this.descriptionTB);
            this.tabPage1.Controls.Add(this.removeRoomBtn);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.searchTB);
            this.tabPage1.Controls.Add(this.addRoomBtn);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.roomNameTB);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.roomTable);
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(876, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý phòng";
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(225, 121);
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(330, 20);
            this.descriptionTB.TabIndex = 9;
            // 
            // removeRoomBtn
            // 
            this.removeRoomBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.removeRoomBtn.BackColor = System.Drawing.Color.Red;
            this.removeRoomBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeRoomBtn.Font = new System.Drawing.Font("UVN Gio May", 12F);
            this.removeRoomBtn.Location = new System.Drawing.Point(742, 68);
            this.removeRoomBtn.Name = "removeRoomBtn";
            this.removeRoomBtn.Padding = new System.Windows.Forms.Padding(8);
            this.removeRoomBtn.Size = new System.Drawing.Size(126, 56);
            this.removeRoomBtn.TabIndex = 8;
            this.removeRoomBtn.Text = "Xóa phòng";
            this.removeRoomBtn.UseVisualStyleBackColor = false;
            this.removeRoomBtn.Click += new System.EventHandler(this.removeRoomBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4);
            this.label3.Size = new System.Drawing.Size(76, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tìm kiếm:";
            // 
            // searchTB
            // 
            this.searchTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.searchTB.Location = new System.Drawing.Point(3, 3);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(870, 20);
            this.searchTB.TabIndex = 6;
            this.searchTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // addRoomBtn
            // 
            this.addRoomBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addRoomBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.addRoomBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRoomBtn.Font = new System.Drawing.Font("UVN Gio May", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoomBtn.Location = new System.Drawing.Point(589, 68);
            this.addRoomBtn.Name = "addRoomBtn";
            this.addRoomBtn.Padding = new System.Windows.Forms.Padding(8);
            this.addRoomBtn.Size = new System.Drawing.Size(126, 56);
            this.addRoomBtn.TabIndex = 5;
            this.addRoomBtn.Text = "Thêm phòng";
            this.addRoomBtn.UseVisualStyleBackColor = false;
            this.addRoomBtn.Click += new System.EventHandler(this.addRoomBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mô tả phòng";
            // 
            // roomNameTB
            // 
            this.roomNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.roomNameTB.Location = new System.Drawing.Point(225, 68);
            this.roomNameTB.Name = "roomNameTB";
            this.roomNameTB.Size = new System.Drawing.Size(330, 20);
            this.roomNameTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên phòng";
            // 
            // roomTable
            // 
            this.roomTable.AllowUserToAddRows = false;
            this.roomTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.roomTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.roomTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomTable.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.NullValue = "N/A";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.roomTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.roomTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.roomNameColumn,
            this.statusColumn});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.roomTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.roomTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roomTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.roomTable.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.roomTable.Location = new System.Drawing.Point(3, 225);
            this.roomTable.Name = "roomTable";
            this.roomTable.ReadOnly = true;
            this.roomTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.roomTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Circle3D", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roomTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.roomTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(4);
            this.roomTable.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.roomTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.roomTable.Size = new System.Drawing.Size(870, 267);
            this.roomTable.TabIndex = 0;
            // 
            // IdColumn
            // 
            this.IdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IdColumn.HeaderText = "Mã phòng";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // roomNameColumn
            // 
            this.roomNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.roomNameColumn.HeaderText = "Tên phòng";
            this.roomNameColumn.Name = "roomNameColumn";
            this.roomNameColumn.ReadOnly = true;
            this.roomNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.roomNameColumn.Width = 350;
            // 
            // statusColumn
            // 
            this.statusColumn.HeaderText = "Mô tả";
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            this.statusColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.HotPink;
            this.tabPage2.Controls.Add(this.customerIdTB);
            this.tabPage2.Controls.Add(this.bookedRoomNameTB);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.checkOutDateTB);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.checkInDateTB);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.phoneNumberTB);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.searchCustomerTB);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.customerNameTB);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.customerTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê";
            // 
            // customerIdTB
            // 
            this.customerIdTB.Enabled = false;
            this.customerIdTB.Location = new System.Drawing.Point(281, 29);
            this.customerIdTB.Name = "customerIdTB";
            this.customerIdTB.Size = new System.Drawing.Size(421, 20);
            this.customerIdTB.TabIndex = 24;
            this.customerIdTB.Visible = false;
            // 
            // bookedRoomNameTB
            // 
            this.bookedRoomNameTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bookedRoomNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookedRoomNameTB.Enabled = false;
            this.bookedRoomNameTB.HideSelection = false;
            this.bookedRoomNameTB.Location = new System.Drawing.Point(280, 185);
            this.bookedRoomNameTB.Name = "bookedRoomNameTB";
            this.bookedRoomNameTB.Size = new System.Drawing.Size(421, 20);
            this.bookedRoomNameTB.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(89, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 29);
            this.label9.TabIndex = 22;
            this.label9.Text = "Phòng đã đặt";
            // 
            // checkOutDateTB
            // 
            this.checkOutDateTB.Enabled = false;
            this.checkOutDateTB.Location = new System.Drawing.Point(685, 125);
            this.checkOutDateTB.Name = "checkOutDateTB";
            this.checkOutDateTB.Size = new System.Drawing.Size(187, 20);
            this.checkOutDateTB.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(468, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ngày trả phòng";
            // 
            // checkInDateTB
            // 
            this.checkInDateTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkInDateTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.checkInDateTB.Enabled = false;
            this.checkInDateTB.HideSelection = false;
            this.checkInDateTB.Location = new System.Drawing.Point(685, 70);
            this.checkInDateTB.Name = "checkInDateTB";
            this.checkInDateTB.Size = new System.Drawing.Size(186, 20);
            this.checkInDateTB.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(468, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ngày đặt phòng";
            // 
            // phoneNumberTB
            // 
            this.phoneNumberTB.Enabled = false;
            this.phoneNumberTB.Location = new System.Drawing.Point(228, 125);
            this.phoneNumberTB.Name = "phoneNumberTB";
            this.phoneNumberTB.Size = new System.Drawing.Size(187, 20);
            this.phoneNumberTB.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tìm kiếm:";
            // 
            // searchCustomerTB
            // 
            this.searchCustomerTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchCustomerTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.searchCustomerTB.Location = new System.Drawing.Point(3, 3);
            this.searchCustomerTB.Name = "searchCustomerTB";
            this.searchCustomerTB.Size = new System.Drawing.Size(870, 20);
            this.searchCustomerTB.TabIndex = 15;
            this.searchCustomerTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchCustomerTB.TextChanged += new System.EventHandler(this.searchCustomerTB_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(11, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số điện thoại";
            // 
            // customerNameTB
            // 
            this.customerNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.customerNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerNameTB.Enabled = false;
            this.customerNameTB.HideSelection = false;
            this.customerNameTB.Location = new System.Drawing.Point(228, 70);
            this.customerNameTB.Name = "customerNameTB";
            this.customerNameTB.Size = new System.Drawing.Size(186, 20);
            this.customerNameTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(11, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên khách hàng";
            // 
            // customerTable
            // 
            this.customerTable.AllowUserToAddRows = false;
            this.customerTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.customerTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.customerTable.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.customerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdColumn,
            this.customerNameColumn,
            this.phoneNumberColumn,
            this.checkInDateColumn,
            this.checkOutDate,
            this.bookedRoomColumn});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerTable.DefaultCellStyle = dataGridViewCellStyle8;
            this.customerTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customerTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.customerTable.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.customerTable.Location = new System.Drawing.Point(3, 225);
            this.customerTable.Name = "customerTable";
            this.customerTable.ReadOnly = true;
            this.customerTable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customerTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.customerTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(4);
            this.customerTable.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.customerTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerTable.Size = new System.Drawing.Size(870, 267);
            this.customerTable.TabIndex = 9;
            this.customerTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerTable_CellClick);
            // 
            // customerIdColumn
            // 
            this.customerIdColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customerIdColumn.Frozen = true;
            this.customerIdColumn.HeaderText = "Mã Khách hàng";
            this.customerIdColumn.Name = "customerIdColumn";
            this.customerIdColumn.ReadOnly = true;
            this.customerIdColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // customerNameColumn
            // 
            this.customerNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customerNameColumn.Frozen = true;
            this.customerNameColumn.HeaderText = "Tên khách hàng";
            this.customerNameColumn.Name = "customerNameColumn";
            this.customerNameColumn.ReadOnly = true;
            this.customerNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customerNameColumn.Width = 150;
            // 
            // phoneNumberColumn
            // 
            this.phoneNumberColumn.Frozen = true;
            this.phoneNumberColumn.HeaderText = "Số điện thoại";
            this.phoneNumberColumn.Name = "phoneNumberColumn";
            this.phoneNumberColumn.ReadOnly = true;
            this.phoneNumberColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.phoneNumberColumn.Width = 150;
            // 
            // checkInDateColumn
            // 
            this.checkInDateColumn.Frozen = true;
            this.checkInDateColumn.HeaderText = "Ngày đặt phòng";
            this.checkInDateColumn.Name = "checkInDateColumn";
            this.checkInDateColumn.ReadOnly = true;
            this.checkInDateColumn.Width = 150;
            // 
            // checkOutDate
            // 
            this.checkOutDate.Frozen = true;
            this.checkOutDate.HeaderText = "Ngày trả phòng";
            this.checkOutDate.Name = "checkOutDate";
            this.checkOutDate.ReadOnly = true;
            this.checkOutDate.Width = 150;
            // 
            // bookedRoomColumn
            // 
            this.bookedRoomColumn.Frozen = true;
            this.bookedRoomColumn.HeaderText = "Phòng đã đặt";
            this.bookedRoomColumn.Name = "bookedRoomColumn";
            this.bookedRoomColumn.ReadOnly = true;
            this.bookedRoomColumn.Width = 150;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView roomTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roomNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addRoomBtn;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button removeRoomBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchCustomerTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customerNameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView customerTable;
        private System.Windows.Forms.TextBox phoneNumberTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookedRoomColumn;
        private System.Windows.Forms.TextBox bookedRoomNameTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox checkOutDateTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox checkInDateTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox customerIdTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.TextBox descriptionTB;
    }
}