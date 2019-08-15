using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SpecflowPages
{
    public class ConstantUtils
    {
        //Base Url
        public static string Url = "http://www.skillswap.pro/";

        //ScreenshotPath
        // public static string ScreenshotPath = @"C:\Users\Neelam\Desktop\Mars project\SpecflowTests-Base\SpecflowTests-Base\SpecflowTests\SpecflowPages\TestReports\Screenshots";
        public static string ScreenshotPath = Directory.GetCurrentDirectory();

        //ExtentReportsPath
        // public static string ReportsPath = @"C:\Users\Neelam\Desktop\Mars project\SpecflowTests-Base\SpecflowTests-Base\SpecflowTests\SpecflowPages\TestReports\Test1.html";
        public static string ReportsPath = Directory.GetCurrentDirectory();
        //ReportXML Path
        // public static string ReportXMLPath = @"C:\Users\Neelam\Desktop\Mars project\SpecflowTests-Base\SpecflowTests-Base\SpecflowTests\SpecflowPages\TestReports\ReportXML1.xml";
        public static string ReportXMLPath = Directory.GetCurrentDirectory();


    }
}
