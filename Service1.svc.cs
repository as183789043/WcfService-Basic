﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼、svc 和組態檔中的類別名稱 "Service1"。
    // 注意: 若要啟動 WCF 測試用戶端以便測試此服務，請在 [方案總管] 中選取 Service1.svc 或 Service1.svc.cs，然後開始偵錯。
    public class Service1 : IService1
    {
        public double PiValue()
        {
            double pi = Math.PI;
            return pi;
        }
        public string HelloWorld()
        {
            return "HelloWorld";
        }

        public int AbsValue(int value)
        {
            if (value >= 0)
            {
                return value;
            }
            else {
                return -value;
            }
        }
    }
}