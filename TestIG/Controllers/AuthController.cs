using System;
using System.Net;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestIG.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index(string code)
        {
            NameValueCollection parameters = new NameValueCollection();
            parameters.Add("client_id", "98b9d5fba0b04b7eb1fd21682d7101b4");
            parameters.Add("client_secret", "95e27054c68344e59f2f1b70e43416a3");
            parameters.Add("grant_type", "authorization_code");
            parameters.Add("redirect_uri", "http://localhost:49997/Auth");
            parameters.Add("code", code);

            WebClient client = new WebClient();
            var result = client.UploadValues("https://api.instagram.com/oauth/access_token", parameters);

            var response = System.Text.Encoding.Default.GetString(result);
            return View();
        }
    }
}