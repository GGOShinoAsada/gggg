using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;
using System.Web;
using Leaf.xNet;

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
            textBox1.Text = ""
;           textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        string sendMsg (string pid, string pdate, string pemail, string pls, string pitog, string pname)
        {
            string n = "";
            var par = new RequestParams();

            par["PAY_ID"] = pid;
            par["PAY_DATE"] = pdate;
            par["PAY_EMAIL"] = pemail;
            par["PAY_LS"] = pls;
            par["PAY_ITOG"] = pitog;
            par["PAY_NAME"] = pname;
            par["PAY_ACTION"] = "REC";
            var req  = new Leaf.xNet.HttpRequest();
            var resp = req.Get("https://pay.pay-ok.org/demo/?REQ=", par);
            par = new RequestParams();
            par["PAQY_ID"] = pid;
            par["PAY_ACTION"] = "GET_INFO";
            resp = req.Get("https://pay.pay-ok.org/demo/?REQ=", par);
            n = resp.ToString();
           
            /*try
            {
                using (var request = 
                {
                    var urlParams = new RequestParams();
                    urlParams.Add();

                    request.AddHeader("Accept", "application/json");
                    request.Get("", urlParams);
                    request.AddHeader("Content-Type:", "application/json");
                    request.AddHeader("Authorization", "Bearer " + textBox56.Text);

                    string content = request.Post("https://edge.qiwi.com/sinap/api/v2/terms/99/payments", urlParams).ToString();
                    textBox58.Text = content;
                }
            }
            catch (Exception e)
            {
                richTextBox1.Text = e.StackTrace;
            }*/
            return n;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pid = textBox1.Text;
            string pdate = textBox2.Text;
            string pemail = textBox3.Text;
            string pls = textBox4.Text;
            string pitog = textBox5.Text;
            string pname = textBox6.Text;
            string resp = sendMsg(pid, pdate, pemail, pls, pitog, pname);
            richTextBox1.Text = resp;
        }
    }
}
