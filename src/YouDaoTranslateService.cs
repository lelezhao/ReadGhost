using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace ReadGhost.src
{
    class YouDaoTranslateService
    {
        public static string serverUrl = "http://fanyi.youdao.com/openapi.do?keyfrom=tinyclass&key=1500198520&type=data&doctype=xml&version=1.1&q=";
        public static string GetTranslateResult(string word)
        {
            WebRequest request = WebRequest.Create(serverUrl + word);
            WebResponse response = request.GetResponse();
            string result = new StreamReader(response.GetResponseStream(), Encoding.UTF8).ReadToEnd();
            response.Close();
            return result;
        }
    }
}
