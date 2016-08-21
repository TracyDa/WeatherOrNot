﻿using System.Collections.Generic;

namespace Weather
{
    class DataLib
    {
        public static string[] OWMicons = { "01d", "01n", "02d", "02n", "03d", "03n", "04d", "04n", "09d", "09n", "10d", "10n", "11d", "11n", "13d", "13n", "50d", "50n" };
        public static string[] myicons = { "\xf00d", "\xf00d", "\xf002", "\xf002", "\xf041", "\xf041", "\xf013", "\xf013", "\xf006", "\xf006", "\xf019", "\xf019", "\xf010", "\xf010", "\xf01b", "\xf01b", "\xf003", "&#xf003", };
        public static Dictionary<string, string> iconDict = new Dictionary<string, string>();
        public static string[] blueIcons = { "\xf019", "\xf010", "\xf006" };
        public static string[] whiteIcons = { "\xf002", "\xf041", "\xf013", "\xf01b", "&#xf003" };

        public static string[] windEN = { "N", "NE", "E", "SE", "S", "SW", "W", "NW" };
        public static string[] windZH = { "北风", "东北风", "东风", "东南风", "南风", "西南风", "西风", "西北风" };


        public static string jsonFile = "result.json";


    }
}