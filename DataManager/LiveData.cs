using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    public class LiveData
    {
        public string stockName = "";
        public float lastPrice = 0.0f;
        public float dayHigh = 0.0f;
        public float dayLow = 0.0f;
        public float openPrice = 0.0f;
        public int totalBuyQnt = 0;
        public int totalSellQnt = 0;
        public float bestBid1 = 0.0f;
        public float bestBid2 = 0.0f;
        public float bestBid3 = 0.0f;
        public float bestBid4 = 0.0f;
        public float bestBid5 = 0.0f;
        public float bestOffer1 = 0.0f;
        public float bestOffer2 = 0.0f;
        public float bestOffer3 = 0.0f;
        public float bestOffer4 = 0.0f;
        public float bestOffer5 = 0.0f;

        public void AddData(string key, string val)
        {
            val = val.Replace(",", "");
            int intVal = 0;
            float floatVal = 0.0f;
            try
            {
                intVal = int.Parse(val);
            }
            catch { }

            try
            {
                floatVal = float.Parse(val);
            }
            catch { }

            switch(key)
            {
                case "companyName":
                    stockName = val;
                    break;

                case "lastPrice":
                    lastPrice = floatVal;
                    break;

                case "buyPrice1":
                    bestBid1 = floatVal;
                    break;

                case "buyPrice2":
                    bestBid2 = floatVal;
                    break;

                case "buyPrice3":
                    bestBid3 = floatVal;
                    break;

                case "buyPrice4":
                    bestBid4 = floatVal;
                    break;

                case "buyPrice5":
                    bestBid5 = floatVal;
                    break;

                case "sellPrice1":
                    bestOffer1 = floatVal;
                    break;

                case "sellPrice2":
                    bestOffer2 = floatVal;
                    break;

                case "sellPrice3":
                    bestOffer3 = floatVal;
                    break;

                case "sellPrice4":
                    bestOffer4 = floatVal;
                    break;

                case "sellPrice5":
                    bestOffer5 = floatVal;
                    break;

                case "open":
                    openPrice = floatVal;
                    break;

                case "dayLow":
                    dayLow = floatVal;
                    break;

                case "dayHigh":
                    dayHigh = floatVal;
                    break;

                case "totalBuyQuantity":
                    totalBuyQnt = intVal;
                    break;

                case "totalSellQuantity":
                    totalSellQnt = intVal;
                    break;
            }
        }
    }
}
