using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// config 的摘要说明
/// </summary>
public class config
{
    public config()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    // 应用ID,您的APPID
    public static string app_id = "2016092100566112";

    // 支付宝网关
    public static string gatewayUrl = "https://openapi.alipaydev.com/gateway.do";

    // 商户私钥，您的原始格式RSA私钥
    public static string private_key = "MIIEowIBAAKCAQEAtcTGLPobwGDQjIiNsTdFgypg9PSAWnT95TWL3htlQFIgy5+bxHnTDLJPf3bEydsqS+/XUlU5ao+MEYSZDgdlGARdN89cfOukKQwCJAoUHomoSeH0ZLqoHwFRw6VAyCbZFH3HkSY/n+bBbZAt43sgncEwU55xQcHUEVaYbYDTwsNJxTF6eicvGv5HTAiqKCs6o4mwaGBw2DCXhD9UbcIojxffZYgmiq+74kTeJCDnF+Vdw0k592YojUUogSOdCCy3Iwco9wSKY/ARdq/WSsC2P6m1X04dRTsd6Qyr7XJElAwZc9jP+ejLvrAaa7OGID7j45xZdOOvmgffQXvlRQVf9wIDAQABAoIBADCnOPx0/dSilW/oZTTYPIz9XPJ0N57+za76hDOxVYq/8PNQB5uxmCI/4DOYENiPB2VID3SER1gUkENoIKe2pwKkuGbl5DWzxT8PbctDv1rlMdyE1KvZooKaEc6yfwKUE2r+t9pMSJ9+Xqv6+a14GaTgPxVCxcH6Jc92RFqbLxNkStbXLpT+XaJA2+ymmFUGqgg8XR3a7fXM0UunrUp9zMCTzTFkwLjqjXpff8AXGOVDwgWQEF0GFT0CNH0yeObAy8P714O3b0GOYvX1qdsvrgXMVsqT87y/RIcdpR37E3bRAX5+XmoVKm6vK+CgKFim23rHtVVUY78PQl60XCw70XECgYEA4RtgUFp/e17q82aF7RsWIgjWtF/ooMohoJx6xGHmYEONKtLFoiz2TqrhQXNMDuF/mbX/YjMXPsnMJ60P1b08hFwij8DlkBd2K1i+OupYFfzxDhA+x4qIOvX9cuSqUX4ld3AXu6Gyt3EeE5Bl2Noym7GC0b2fRURetS55Bv1TGOsCgYEAzrbOFEKMjIcBlFHRAQESbLVXWLLrg1cwoWFY2TdF43Z3y6SQk4Tf8qVwe1X9IzfRcorSJcwYPexXvL5gkXun7Gy16A1cqkDV8outmowFX0w7I/QaISczpDEM4mmXgc/fzG5KAxaiTCtW+RzMewfkHmA6KN8zARCW5sxtGLQ20iUCgYAmz1R8pg2ilIvHaR6f8XKQbZuuv3ZY+mBv02qrHwHcCOl2v54JRt00VOu/IAS18BTSyHj+UjaowZvsHz9Cp3yeiVAAHs61WAYslQE/IRYMvG5G8XARcQXpvG10+I2QvUHyZKYC2G76h4sa7mNQztW42BLo3FtwUshNTnTZSqWf/wKBgHKc1vxSvbz46f5Dst+cqYuOrERox75F7Je98tZVGDH7MIa/0s2IQec2pXws/DK3szCQGd6NH+/NiAQFhmODrWKgD+f+6J8ZXcaifXoQIrZo/O19XbN+Gdryu1MZ+sAl8s9VY0H9HbWf3hQ3TIT2phvVfMnGn2/6s8B6Hg8xdKflAoGBAKfKCp8mqs0jhVpujiqVJPE9aYSrlgF8M+Nsdn4348scVtU+4k+JDWcQXi/6zQOXyKLaP1+vWI9mTn9YgPMmaUrUIR6MIHn6WGS1cZt+EGUC6rGA9hQPnsVhMlEewhMmbl1CNH9UuS1a5hGXwjuwbsUI7a48JoFO41XQdm72l1W0";

    // 支付宝公钥,查看地址：https://openhome.alipay.com/platform/keyManage.htm 对应APPID下的支付宝公钥。
    public static string alipay_public_key = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA2qEh7g7N89dED2j26UXT7zUGCK/wsi6HwUxbejBYnVWoymQjPLUCEL5Ph0miruXG1yE2F71gR95KDmwW3SMhzI8VfatI4RXq74RFkMVADLbYWZ1JwA2or/jJyKLwSOdIim0yIs/mAxJc7udRm3qsTyyMCZ3LdDbaXzpIahucaeRV4eGBjFmlA4lXc0J6fUzIQU2BzYV7bU1Vy2UCk5ZPPis0I0KHCAk/z3GJWiGVeB0jLA4xwrYXsJZCkXbCmYV4EGKOnOGw47SB0bHJSi4jOFkQx9H+8WzF9PlBATSuMIuEDw1s8DnL64NFWrk8sQBtS6tb9pJtQCrYDwUG5G0WxwIDAQAB";

    // 签名方式
    public static string sign_type = "RSA2";

    // 编码格式
    public static string charset = "UTF-8";
}