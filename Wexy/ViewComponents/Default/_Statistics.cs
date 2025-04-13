using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Wexy.ViewComponents.Default
{
    public class _Statistics:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // Context nesnesi oluşturarak veritabanı tablolara erişim sağlanır
            using var c = new Context();

            // ViewBag üzerinden, veritabanından çekilen veriler ve manuel değerler taşınır
            ViewBag.v1 = c.Destinations.Count();  // Destinations tablosundaki kayıt sayısı
            ViewBag.v2 = c.Guides.Count();        // Guides tablosundaki kayıt sayısı
            ViewBag.v3 = "285";                  // Manuel olarak atanan sabit değer
            ViewBag.v4 = "25";                   // Manuel olarak atanan sabit değer

            return View();
        }
    }
}
