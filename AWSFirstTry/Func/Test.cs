using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.IO;


namespace AWSFirstTry.Func
{
    public class Test
    {
        //_____________________________________GET Method______________________________________________
        public static void GET_Method()
        {
            string url = String.Format("https://cl0xbpvfk6.execute-api.ap-southeast-1.amazonaws.com/test/helloworld");
            WebRequest requestObject = WebRequest.Create(url);
            requestObject.Method = "GET";
            HttpWebResponse responseObjGet = null;
            responseObjGet = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                sr.Close();
            }
        }

        //_____________________________________GET Method______________________________________________
        public static void POST_Method()
        {
            string url = String.Format("https://cl0xbpvfk6.execute-api.ap-southeast-1.amazonaws.com/test/helloworld");
            WebRequest requestObject = WebRequest.Create(url);
            requestObject.Method = "GET";
            HttpWebResponse responseObjGet = null;
            responseObjGet = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
