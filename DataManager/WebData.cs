using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Threading;

namespace DataManager
{
    public class WebData
    {
        private static SortedList<string, SortedSet<Func<LiveData, int>>> callbackData = new SortedList<string, SortedSet<Func<LiveData, int>>>();

        public static void AddCallback(string symbol, Func<LiveData, int> func)
        {
            if(callbackData.ContainsKey(symbol))
            {
                callbackData[symbol].Add(func);
            }
            else
            {
                SortedSet<Func<LiveData, int>> funcSet = new SortedSet<Func<LiveData, int>>();
                funcSet.Add(func);
                callbackData.Add(symbol, funcSet);
            }
        }

        public static void RemoveCallBack(string symbol, Func<LiveData, int> func)
        {
            if(callbackData.ContainsKey(symbol))
            {
                //callbackData[symbol].Remove(func);
            }
        }


        public static void StartFetch()
        {
            while(true)
            {
                try
                {
                    foreach (var s in callbackData)
                    {
                        LiveData d = GetLiveData(s.Key);
                        foreach (var f in s.Value)
                        {
                            f(d);
                        }
                    }
                }
                catch { }
            }
        }

        public static LiveData GetLiveData(string symbol)
        {
            //xMH7BiBu6s24LHCizug3
            //https://www.quandl.com/api/v3/datasets/NSE/ABB.json?api_key=xMH7BiBu6s24LHCizug3

            var request = (HttpWebRequest)WebRequest.Create("http://nseindia.com/live_market/dynaContent/live_watch/get_quote/GetQuote.jsp?symbol=" + symbol + "&illiquid=0");
            request.Accept = "*/*";
            request.Headers.Add("Accept-Language", "en-US,en;q=0.5");
            request.Host = "nseindia.com";
            request.Referer = "http://nseindia.com/live_market/dynaContent/live_watch/get_quote/GetQuote.jsp?symbol=" + symbol + "&illiquid=0";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:28.0) Gecko/20100101 Firefox/28.0";
            request.Headers.Add("X-Requested-With", "XMLHttpRequest");

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            int start = responseString.IndexOf("responseDiv");
            start = responseString.IndexOf(',', start);
            int end = responseString.IndexOf("</div>", start);

            responseString = responseString.Substring(start, end - start);
            return readString(responseString);
        }

        private static LiveData readString(string str)
        {
            LiveData d = new LiveData();
            //SortedList<string, string> data = new SortedList<string, string>();
            int start = str.IndexOf(','), end = 0;
            string key = "", val = "";
            while(-1 != start)
            {
                start = str.IndexOf('\"', start);
                start++;
                end = str.IndexOf('\"', start);
                key = str.Substring(start, end - start);
                start = str.IndexOf(':', end);
                start = str.IndexOf('\"', start);
                start++;
                end = str.IndexOf('\"', start);
                val = str.Substring(start, end - start);
                start = str.IndexOf(',', end);
                //data.Add(key, val);
                d.AddData(key, val);
            }
            return d;
        }
    }
}
