using System;
using System.Windows.Forms;

namespace RoomManager
{
    public partial class DangNhap_DangKy : Form
    {
        private AuthManager auth = new AuthManager();
        public DangNhap_DangKy()
        {
            InitializeComponent();
        }

        private void toSignUp_Click(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            String username = usernameTB.Text;
            String password = passwordTB.Text;
            String role = auth.signIn(username, password);
            if (role == "admin")
            {
                Admin admin = new Admin();
                //this.Hide();
                admin.ShowDialog();
            }
            else if (role == "user") { }
            else
            {
                MessageBox.Show("Đăng nhập thất bại, vui lòng thử lại");
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            String username = usernameSignUpTB.Text;
            String password = passwordSignUpTB.Text;
            String reEnteredPassword = reEnterPasswordTB.Text;
            String customerName = customerNameTB.Text;
            String phoneNumber = phoneNumberTB.Text;
            if (password != reEnteredPassword)
            {
                MessageBox.Show("Mật khẩu không trùng khớp, vui lòng nhập lại!");
                return;
            }
            if (password.Length < 4 || password.Length > 16)
            {
                MessageBox.Show("Mật khẩu phải có từ 4-16 ký tự");
                return;
            }
            auth.signUp(username, password, customerName, phoneNumber);
        }

    }
}
