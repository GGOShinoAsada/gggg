using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class Check
    {
        public string PrintCheck(string response)
        { 
            string check = "";
            string payment_id = "";
            string date = "";
            string lsc = "";
            string contacts = "";
            string fns = "";
            string ofdName = "";
            string ofdWebSite = "";
            string pCount = "";
            string pPrise = "";
            string pName = "";       
            int payment_id_index = response.IndexOf("\"payment_id\":\"");
            int date_index = response.IndexOf("\"date\":\"");
            int lsc_index = response.IndexOf("\"lsc\":\"");
            int contacts_index = response.IndexOf("\"contacts\":\"");
            int p_index = response.IndexOf("\"positions\":\"");
            int pay_count_index = response.IndexOf("\\\"PAY_COUNT\\\";i:");
            int pay_price_index = response.IndexOf("\\\"PAY_PRICE\\\";d:");
            int pay_name_index = response.IndexOf("\\\"PAY_NAME\\\";s:5:\\");
            int taxation_system_index = response.IndexOf("\"taxationSystem\":\"");
            int devise_rn_index = response.IndexOf("\"deviceRN\":\"");
            int fns_number_index = response.IndexOf("\\\"fsNumber\\\":\\\"");
            int ofd_name_index = response.IndexOf("\"ofdName\\\":\\\"");
            int ofd_web_site_index = response.IndexOf("\\\"ofdWebsite\\\":\\\"");
            int ofd_inn_index = response.IndexOf("\\\"ofdinn\\\":\\\"");
            int start = payment_id_index;
            int end = date_index;
            string temp = "";
            for (int j = start; j < end; j++)
            {
                temp += response[j];
            }
            temp = temp.Split(':')[1];
            temp = temp.Replace("\"", "");
            temp = temp.Replace(",", "");
            payment_id = temp;
            temp = "";
            start = date_index;
            end = lsc_index;
            for (int j = start; j < end; j++)
            {
                temp += response[j];
            }
            temp = temp.Remove(0, 8);
            temp = temp.Replace("\"", "");
            temp = temp.Replace(",", "");
            date = temp;
            temp = "";
            start = lsc_index;
            end = contacts_index;
            for (int i = start; i < end; i++)
            {
                temp += response[i];
            }
            temp = temp.Split(':')[1];
            temp = temp.Replace("\"", "");
            temp = temp.Replace(",", "");
            lsc = temp;
            temp = "";
            start = contacts_index;
            end = p_index;
            for (int i = start; i < end; i++)
            {
                temp += response[i];
            }
            temp = temp.Split(':')[1];
            temp = temp.Replace("\"", "");
            temp = temp.Replace(",", "");
            contacts = temp;
            temp = "";
            start = fns_number_index;
            end = ofd_name_index;
            for (int i = start; i < end; i++)
            {
                temp += response[i];
            }
            temp = temp.Split(':')[1];
            temp = temp.Replace("\\", "");
            temp = temp.Replace("\"", "");
            temp = temp.Replace(",", "");
            fns = temp;
            temp = "";
            start = ofd_name_index;
            end = ofd_web_site_index;
            for (int i = start; i < end; i++)
            {
                temp += response[i];
            }
            temp = temp.Split(':')[1];
            temp = temp.Replace("\\", "");
            temp = temp.Replace("\"", "");
            temp = temp.Replace(",", "");
            ofdName = temp;
            temp = "";
            start = ofd_web_site_index;
            end = ofd_inn_index;
            for (int i = start; i < end; i++)
            {
                temp += response[i];
            }
            temp = temp.Split(':')[1];
            temp = temp.Replace("\\", "");
            temp = temp.Replace("\"", "");
            temp = temp.Replace(",", "");
            ofdWebSite = temp;
            temp = "";
            start = pay_count_index;
            end = pay_price_index;
            for (int i = start; i < end; i++)
            {
                temp += response[i];
            }
            temp = temp.Remove(0, 20);
            temp = temp.Replace(":", "");
            pCount = temp;
            temp = "";
            start = pay_price_index;
            end = pay_name_index;
            for (int i = start; i < end; i++)
            {
                temp += response[i];
            }
            temp = temp.Remove(0, 16);
            temp = temp.Replace(";s:8:", "");
            pPrise = temp;
            temp = "";
            start = pay_name_index;
            end = taxation_system_index;
            for (int i = start; i < end; i++)
            {
                temp += response[i];
            }
            temp = temp.Remove(0, 19);
            temp = temp.Remove(temp.IndexOf("\""), temp.Length - temp.IndexOf("\""));
            temp = temp.Replace("\\", "");
            pName = temp;
            check = "ЧЕК\n ДАТЕ ПОКУПКИ: " + date + "\nЛИЦЕВОЙ СЧЕТ: " + lsc + "\nКОНТАКТНЫЕ ДАННЫЕ: " + contacts + " ФНС: " + fns + "\nОФД ИМЯ: " + ofdName + "\nОФД САЙТ: " + ofdWebSite + "\n=============\nТОВАР\nНАЗВАНИЕ: " + pName + "\nКОЛИЧЕСТВО ТОВАРОВ: " + pCount + "\nСТОИМОСТЬ: " + pPrise; 
            return check;
        }
       
    }
    
}
