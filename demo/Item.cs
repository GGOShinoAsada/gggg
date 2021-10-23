using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class Item
    {
        [JsonProperty("payment_id")]
        public string payment_id { get; set; }
        [JsonProperty("date")]
        public string date { get; set; }
        [JsonProperty("lsc")]
        public string lsc { get; set; }
        [JsonProperty("contacts")]
        public string contacts { get; set; }
        [JsonProperty("positions")]
        public string positions { get; set; }
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("taxationSystem")]
        public string taxationSystem { get; set; }
        [JsonProperty("paymentType")]
        public string paymentType { get; set; }
        [JsonProperty("uploadfile")]
        public string uploadFile { get; set; }
        [JsonProperty("uploaddate")]
        public string uploaddate { get; set; }
        [JsonProperty("od_status")]
        public string od_status { get; set; }
       /* [JsonProperty("od_params")]
        public OD_PARAMS od_params { get; set; }*/
        [JsonProperty("OD_TIMESTAMP")]
        public string OD_TIMESTAMP { get; set; }
        [JsonProperty("OD_CASSET_NUMBER")]
        public string OD_KASSE_NUMBER { get; set; }
    }
    
    public class OD_PARAMS
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("deviseSN")]
        public string deviseSN { get; set; }
        [JsonProperty("deviseRN")]
        public string deviseRN { get; set; }
        [JsonProperty("fsNumber")]
        public string fsNumber { get; set; }
        [JsonProperty("ofdName")]
        public string ofdName { get; set; }
        [JsonProperty("ofdWebsite")]
        public string ofdWebsite { get; set; }
        [JsonProperty("ofdinn")]
        public string ofdinn { get; set; }
        [JsonProperty("fnswebsite")]
        public string fnsWebsite { get; set; }
        [JsonProperty("companyINN")]
        public string companyINN { get; set; }
        [JsonProperty("documentNumber")]
        public string documentNumber { get; set; }
        [JsonProperty("shiftNumber")]
        public string shiftNumber { get; set; }
        [JsonProperty("documentIndex")]
        public string documentIndex { get; set; }
        [JsonProperty("processedAt")]
        public string processedAt { get; set; }
        [JsonProperty("fp")]
        public string fp { get; set; }
        [JsonProperty("callbackUrl")]
        public string callbackUrl { get; set; }

    }
}
