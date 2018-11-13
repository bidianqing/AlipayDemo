using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlipayDemo
{
    public class AlipayTradePagePayRequest
    {
        public string app_id { get; set; } = "2016092100566112";
        public string method { get; set; } = "alipay.trade.page.pay";
        public string charset { get; set; } = "utf-8";
        public string sign_type { get; set; } = "RSA2";
        public string sign { get; set; }
        public string timestamp { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        public string version { get; set; } = "1.0";
        public string biz_content { get; set; }
    }

    public class AlipayTradePagePayModel
    {
        public string out_trade_no { get; set; } = DateTime.Now.Ticks.ToString();
        public string product_code { get; set; } = "FAST_INSTANT_TRADE_PAY";
        public decimal total_amount { get; set; } = 8.88M;
        public string subject { get; set; } = "iPhone";
    }
}
