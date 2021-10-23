using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Leaf.xNet;
using System.Text.Json;

namespace demo
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


       // static HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://pay.pay-ok.org/demo/");
  

        string sendRequest(string pid, string pdate, string pemail, string pls, string pitog, string pname)
        {
            string result = "";
           //var req = HttpWebRequest.Create("https://pay.pay-ok.org/demo/") as HttpWebRequest;
            //req.Method = "GET";
           /*
            try
            {

                using (var streamWriter = new StreamWriter(req.GetRequestStream()))
                {
                    string json = new JavaScriptSerializer().Serialize(new
                    {
                        PAY_ID = pid,
                        PAY_DATE = pdate,
                        PAY_EMAIL = pemail,
                        PAY_LS = pls,
                        PAY_ITOG = pitog,
                        PAY_NAME = pname
                    });

                    streamWriter.Write(json);

                }
                var httpResponse = (HttpWebResponse)req.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                richTextBox1.Text = e.StackTrace;
            }

                /* request.Method = "GET";
                 request.ContentType = "application/json";
                 try
                 {

                     using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                     {
                         string json = new JavaScriptSerializer().Serialize(new
                         {
                             PAY_ID = pid,
                             PAY_DATE = pdate,
                             PAY_EMAIL = pemail,
                             PAY_LS = pls,
                             PAY_ITOG = pitog,
                             PAY_NAME = pname
                         });

                         streamWriter.Write(json);

                     }
                     var httpResponse = (HttpWebResponse)request.GetResponse();
                     using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                     {
                         result = streamReader.ReadToEnd();
                     }
                 }
                 catch (Exception e)
                 {
                     richTextBox1.Text = e.StackTrace;
                 }*/
                return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t_id.Text = ""
;           t_date.Text = "";
            t_email.Text = "";
            t_name.Text = "";
            t_itog.Text = "";
            t_ls.Text = "";
            check_id.Text = "";
            richTextBox1.Text = "";
        }

        string sendMsg (string pid, string pdate, string pemail, string pls, string pitog, string pname)
        {
            string n = "";
            try
            {
                

                var par = new RequestParams();
          
                par["REQ"] = "{\"PAY_ID\":\"" +pid+"\",\"PAY_DATE\":\""+pdate+"\", \"PAY_EMAIL\":\""+pemail+"\",\"PAY_LS\": \""+pls+"\", \"PAY_ITOG\": \""+pitog+"\", \"PAY_NAME\" : \""+pname+"\",\"PAY_ACTION\": \"REG\" }";
                
                var req = new Leaf.xNet.HttpRequest();
                var resp = req.Get("https://pay.pay-ok.org/demo/", par);
                
                n = resp.ToString();
            }
            catch (Exception e)
            {
                n = e.StackTrace;
            }           
            return n;
        }

        string checkStatus (string pid)
        {
            string check = "";
           
            try
            { 
                string response = "";
                var par = new RequestParams();
                par["REQ"] = "{\"PAY_ID\":\"" + pid + "\",\"PAY_ACTION\": \"GET_INFO\" }";
               
                var req = new Leaf.xNet.HttpRequest();
                var resp = req.Get("https://pay.pay-ok.org/demo/", par);
                int t = 9;
                Check c = new Check();
                int u = 0;
                response = resp.ToString();
                check = c.PrintCheck(response);
            }
            catch (Exception e)
            {
                check = "ошибка";
            }
            return check;
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            string pid = t_id.Text;
            string pdate = t_date.Text;
            string pemail = t_email.Text;
            string pls = t_ls.Text;
            string pitog = t_itog.Text;
            string pname = t_name.Text;
            string resp = sendMsg(pid, pdate, pemail, pls, pitog, pname);
            richTextBox1.Text = resp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string t_id = check_id.Text;
            string resp = checkStatus(t_id);
            richTextBox1.Text = resp;

        }
    }
}
