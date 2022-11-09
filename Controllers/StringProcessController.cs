using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using HDK700.Models;
namespace HDK700.Controllers
{
    public class StringProcessController:Controller
    
     {
     StringProcess strPro = new StringProcess();
      
      public IActionResult Index ()
      {
            return View();
      }
      
      [HttpPost]
      public IActionResult Index(string strInput )
      {
        string strResult = strPro.RemoveRemainingWhiteSpace(strInput);
        ViewBag.thongTin= strResult;
    
        return View();
      }
      StringProcess strPrL =new StringProcess();
       public IActionResult Lower()
      {
            return View();
      }
      
      [HttpPost]
      public IActionResult Lower(string strInput )
      {
        string strResult = strPrL.LowerToUpper(strInput);
        ViewBag.lower= strResult;
    
        return View();
      }
      StringProcess strPrU =new StringProcess();
       public IActionResult Upper()
      {
            return View();
      }
      
      [HttpPost]
      public IActionResult Upper(string strInput )
      {
        string strResult = strPrU.UpperToLower(strInput);
        ViewBag.upper= strResult;
    
        return View();
      }
      
        StringProcess strPrC =new StringProcess();
       public IActionResult Capone()
      {
            return View();
      }
      
      [HttpPost]
      public IActionResult Capone(string strInput )
      {
        string strResult= strPrC.CapitalizeOneFirstCharacter(strInput);
        ViewBag.cap= strResult;
    
        return View();
     }
      StringProcess strPrM =new StringProcess();
       public IActionResult Remove()
      {
            return View();
      }
      
      [HttpPost]
      public IActionResult Remove(string strInput )
      {
        string strResult= strPrM.RemoveVietnameseAccents(strInput);
        ViewBag.remove= strResult;
    
        return View();
     }
     StringProcess strPrCF =new StringProcess();
       public IActionResult CapitalizeFirst()
      {
            return View();
      }
    
      
      [HttpPost]
      public IActionResult CapitalizeFirst(string strInput )
      {
        string strResult= strPro.CapitalizeFirstCharacter(strInput);
        ViewBag.mess = strResult;
    
        return View();
      }
      }
      }

