using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeddingBox.Controllers
{
    public class AlbumViewModel
    {
        #region Fields
        public List<string> filePaths { get; set; }
        #endregion
    }

    public class AlbumController : Controller
    {
        // GET: Album
        public ActionResult Index()
        {
            var fileList = System.IO.Directory.GetFiles(Server.MapPath("~/Album/")).Select(x =>
            {
                var index = x.LastIndexOf("\\");
                return x.Substring(index + 1, x.Length - index - 1);
            }).ToList();
            var viewModel = new AlbumViewModel { filePaths = fileList };
            return View(viewModel);
        }
    }
}