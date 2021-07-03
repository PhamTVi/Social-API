using Newtonsoft.Json.Linq;
using System;
using ZaloDotNetSDK;


namespace PostContent
{
    class Program
    {
        static void Main(string[] args)
        {
            long appId = 7955687447591500;// id ứng dụng tạo ra
            string secretKey = "CPT27WWFCvVBWoYnLYs"; // Khóa bí mật tạo ra .
            string callbackUrl = "https://www.google.com";// Đường dẫn muốn chia sẽ
            ZaloAppInfo appInfo = new ZaloAppInfo(appId, secretKey, callbackUrl);
            ZaloAppClient appClient = new ZaloAppClient(appInfo);
            string accessToken = "r0Pc30X6kolM1sG32a-ATCERHX9JF5Kv79G0bbezdlYQ5fNH6JbS9ifO0aG1RDpZ0HiDJeIv5YLArq5A6ZEO8qbJqic5TOcdpLsG14opZAGS6b866gm7Q0hE4bnQ8Oygra8KN9QaYolLGnaDHEeDRLLCdubQOyiZr4kPLHpd3prQW9rT2o_3AjePbnwIkTxosT2DaWZ_sxKOLOfQspH1hKXPLvjEBeOu1u6HcGfgI3rRW1ISbAY4lKG9aLT8QKSvMqsRbL2iK6FRH0HJ3KuwNNh7mvTkYe";
            //accesstoken: Vào https://developers.zalo.me/ Chọn công d
            JObject postFeed = appClient.postFeed(accessToken, "test post", "https://developers.zalo.me/");



            Console.WriteLine("Post");
        }
    }
}
