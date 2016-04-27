// use TinyGPIO.cs
// https://github.com/sample-by-jsakamoto/SignalR-on-RaspberryPi/blob/master/myapp/TinyGPIO.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;
using MvcApplication2;
using MvcApplication2.SignalR;
using System.Diagnostics;
using MvcApplication2.PInvoke;
using System.Runtime.InteropServices;
using SharpNFC;


namespace MvcApplication2.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OnButtonTestNFC(string currentNFC)
        {
            if (currentNFC == "true") MvcApplication2.SignalR.NFC.Instance.UpdateNFCStatus("false");
            else MvcApplication2.SignalR.NFC.Instance.UpdateNFCStatus("true");
            return null;
        }
    }
}









