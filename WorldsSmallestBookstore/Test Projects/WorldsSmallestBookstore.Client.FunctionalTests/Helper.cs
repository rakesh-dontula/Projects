﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WatiN.Core;


namespace WorldsSmallestBookstore.Tests
{
    public static class WebBrowser
    {
        public static IE Current
        {
            get
            {
                if (!ScenarioContext.Current.ContainsKey("browser"))
                    ScenarioContext.Current["browser"] = new IE();
                return ScenarioContext.Current["browser"] as IE;
            }
        }
    }
}
