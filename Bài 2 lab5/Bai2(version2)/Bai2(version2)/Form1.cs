using MailKit.Net.Imap;
using MailKit;

namespace Bai2_version2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //tạo các cột trong listView1 (theo hướng dẫn trong file thực hành)
            listView1.Columns.Add("Email", 200);
            listView1.Columns.Add("From", 100);
            listView1.Columns.Add("Thời gian", 100);
            listView1.View = View.Details;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //lấy dữ liệu không đổi
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            try
            {
                using (var client = new ImapClient())
                {
                    //kết nối bất đồng bộ interface imap của gmail tại cổng 993, có dùng SSL
                    await client.ConnectAsync("imap.gmail.com", 993, true);
                    await client.AuthenticateAsync(email, password);

                    //tạo đối tượng chứa thông tin inbox của client
                    var inbox = client.Inbox;
                    await inbox.OpenAsync(FolderAccess.ReadOnly);

                    //đếm total và recent, in ra màn hình
                    txtTotal.Text = inbox.Count.ToString();
                    txtRecent.Text = inbox.Recent.ToString();

                    //làm mới listView1
                    listView1.Items.Clear();

                    //xử lý thông tin trong inbox in ra listView1 (theo hướng dẫn file thực hành nhưng chỉ lấy 20 email gần nhất)
                    //sử dụng hàm tìm max để tránh lỗi inbox của user đó có ít hơn 20 thư
                    for (int i = inbox.Count - 1; i >= Math.Max(0, inbox.Count - 20); i--)
                    {
                        var message = await inbox.GetMessageAsync(i);

                        //thay vì lấy từng cái như file hướng dẫn rồi gom vào 1 đối tượng chính
                        //ta lấy hết rồi gom vào đối tượng chính đó luôn
                        var listViewItems = new ListViewItem(new[]
                        {
                    message.Subject, //tiêu đề
                    message.From.ToString(), //đến từ
                    message.Date.LocalDateTime.ToString() //ngày giờ
                });

                        listView1.Items.Add(listViewItems);
                    }

                    //xong rồi thì disconnect
                    await client.DisconnectAsync(true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
    }
}
