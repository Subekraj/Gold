using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Jewellery_management_system
{
    public partial class sms_api_test : Form
    {
        public sms_api_test()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string to, message;
                to = txt_phone.Text;
                message = txt_message.Text;
                string baseURL = "http://api.clickatell.com/http/sendmsg?user=zisan94268&password=OYeNLVUHTNIHbD&api_id=3528011&to='" + to + "'&text='" + message + "'";
                client.OpenRead(baseURL);
                MessageBox.Show("Successfully sent message");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
    }
}
