using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace D2BOTViewer
{
    public partial class Form1 : Form
    {
        public string CurrentUser { get; set; }
        public int TempCount { get; set; }

        public Form1()
        {
            InitializeComponent();
            Get_UserList();
        }

        public void Get_UserList()
        {
            string apppath = $@"{Environment.CurrentDirectory}\";
            //先針對目前目路的檔案做處理 
            foreach (string f in Directory.GetFiles(apppath))
            {
                if (f.Contains(".txt"))
                {
                    menuStrip1.Items.Add(f.Replace(apppath, "").Replace(" ", ""));
                }
            }
        }

        public void Get_ReadUserDropTxt()
        {
            string[] text = File.ReadAllLines(CurrentUser, System.Text.Encoding.GetEncoding(936));

            //string[] text = CharSetConverter.ToTraditional(fileReader.ReadToEnd()).Replace("__", "_");

            List<string[]> list = new List<string[]>();
            string item_info = "";
            string[] tmp = new string[4] { "", "", "", "" };
            foreach (var k in text)
            {
                Console.WriteLine(CharSetConverter.LanChange(k));
                string str = CharSetConverter.ToTraditional((k));
                //如果為空，代表上面是有數值的裝備

                //時間
                if (str.Contains("2021") || str.Contains("2022"))
                {
                    var i = str.Replace("__", "_").Split('_');
                    tmp[0] = i[0]; //時間
                    tmp[1] = i[1].Replace(":", ""); //任務
                    //剩餘資訊
                    string tmp_str = "";
                    if (str.Contains("屬性如下"))
                    {
                        tmp[2] = i[3] +"\r\n" +i[4];
                        for (int a = 2; a < i.Length; a++)
                        {
                            tmp_str += i[a];
                        }
                        continue;
                    }
                    else
                    {
                        tmp[2] = i[2]; //符文之類的
                        list.Add(tmp);
                        tmp = new string[4] { "", "", "", "" };
                    }
                }
                else if (str == "")
                {
                    //if (tmp[0] == "" && tmp[1] == "")
                    //{
                    //    break;
                    //}
                    tmp[3] = item_info;
                    item_info = "";
                    list.Add(tmp);
                    tmp = new string[4] { "", "", "", "" };
                    continue;
                }
                else
                {
                    item_info += str+"\n";
                }
            }

            dgv_report_list.Rows.Clear();
            for (int item = list.Count-1; item > 0; item--)
            {
                dgv_report_list.Rows.Add(item, list[item][0], list[item][1], list[item][2], list[item][3]);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            CurrentUser = e.ClickedItem.Text;
            Get_ReadUserDropTxt();
        }

        private void cbx_dropNotify_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_dropNotify.Checked)
            {
                timer_dropNotify.Enabled = true;
                Properties.Settings.Default.txt_lineToken = txt_lineToken.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                timer_dropNotify.Enabled = false;
            }
        }

        private void timer_dropNotify_Tick(object sender, EventArgs e)
        {
            Get_ReadUserDropTxt();
            int count = dgv_report_list.Rows.Count;
            if (count > TempCount)
            {
                string time = dgv_report_list.Rows[0].Cells[1].Value.ToString();
                string title = dgv_report_list.Rows[0].Cells[3].Value.ToString();
                string info = dgv_report_list.Rows[0].Cells[4].Value.ToString();

                string msg = "";

                if (info.Length > 0)
                {
                    msg = $"\n帳號：{CurrentUser}　{time}\n\n名稱：{title}\n素質：\n{info}";
                }
                else
                {
                    msg = $"\n帳號：{CurrentUser}　{time}\n\n名稱：{title}";
                }
                LineNotify(msg);
                TempCount = count;
            }
        }

        //Line Notify
        public void LineNotify(string msg)
        {
            try
            {
                String line_notify_url = @"https://notify-api.line.me/api/notify";
                msg = @"message=" + HttpUtility.UrlEncode(msg);
                byte[] byteArray = Encoding.UTF8.GetBytes(msg);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(line_notify_url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.Headers.Add("Authorization", $"Bearer {txt_lineToken.Text}");
                request.Timeout = 30000;

                // Get the request stream.  
                Stream dataStream = request.GetRequestStream();
                // Write the data to the request stream.  
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the Stream object.  
                dataStream.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                int responseCode = (int)response.StatusCode;
                String responseMsg = (String)new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch { }
        }

    }
}
