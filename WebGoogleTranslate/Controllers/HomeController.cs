using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebGoogleTranslate.Models;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace WebGoogleTranslate.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            TranslateModel tmd = new TranslateModel();

            tmd.Langs = fillList();
            tmd.SelectedSourceLg = "es";
            tmd.SelectedTargetLg = "en";

            return View(tmd);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        [HttpGet]
        public string TranslateApi(string sl = "", string tl = "", string tx = "")
        {
            HttpClient hc = new HttpClient();
            JsonSerializer jss = new JsonSerializer();
            List<string> li = new List<string>();
            string uri = $"https://translate.google.com/translate_a/single?client=gtx&dt=t&dt=ld&dt=qca&dt=rm&dt=bd&dj=1&&ie=UTF-8&oe=UTF-8&inputm=2&otf=2&iid=1dd3b944-fa62-4b55-b330-74909a99969e";

            if (sl == "")
            {
                sl = "es";
                //&sl=es&tl=ps&hl=ps
                uri += $"&sl={sl}&tl={tl}&hl={tl}";

                if (tx == "")
                {
                    tx = "&q=Lenguaje";
                    li.Add(get_translation(hc, uri + tx));
                    tx = "&q=Origen";
                    li.Add(get_translation(hc, uri + tx));
                    tx = "&q=Destino";
                    li.Add(get_translation(hc, uri + tx));

                    tx = JsonConvert.SerializeObject(li);
                }
            }
            else
            {
                uri += $"&sl={sl}&tl={tl}&hl={tl}&q={tx}";

                li.Add(get_translation(hc, uri));

                tx = JsonConvert.SerializeObject(li);
            }

            if(tx == "")
            {
                return "401";
            }
            else
            {
                return tx;
            }
            
        }

        private string get_translation(HttpClient hc, string tx)
        {
            var hrm = hc.GetStringAsync(tx).Result;
            var json = JObject.Parse(hrm);
            var ftok = json.First.First;
            var stok = ftok.First;

            return stok["trans"].ToString().Replace("\"", "");
        }

        private string convert()
        {

            return "";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<SelectListItem> fillList(string selected = "auto")
        {
            List<SelectListItem> sli = new List<SelectListItem>();
            sli.Add(new SelectListItem { Text = "Auto", Value = "auto" });
            sli.Add(new SelectListItem { Text = "Afrikaans", Value = "af" });
            sli.Add(new SelectListItem { Text = "Albanian", Value = "sq" });
            sli.Add(new SelectListItem { Text = "Amharic", Value = "am" });
            sli.Add(new SelectListItem { Text = "Arabic", Value = "ar" });
            sli.Add(new SelectListItem { Text = "Armenian", Value = "hy" });
            sli.Add(new SelectListItem { Text = "Azerbaijani", Value = "az" });
            sli.Add(new SelectListItem { Text = "Basque", Value = "eu" });
            sli.Add(new SelectListItem { Text = "Belarusian", Value = "be" });
            sli.Add(new SelectListItem { Text = "Bengali", Value = "bn" });
            sli.Add(new SelectListItem { Text = "Bosnian", Value = "bs" });
            sli.Add(new SelectListItem { Text = "Bulgarian", Value = "bg" });
            sli.Add(new SelectListItem { Text = "Catalan", Value = "ca" });
            sli.Add(new SelectListItem { Text = "Cebuano", Value = "ceb" });
            sli.Add(new SelectListItem { Text = "Chinese (Simplified)", Value = "zh-CN" });
            sli.Add(new SelectListItem { Text = "Chinese (Traditional)", Value = "zh-TW" });
            sli.Add(new SelectListItem { Text = "Corsican", Value = "co" });
            sli.Add(new SelectListItem { Text = "Croatian", Value = "hr" });
            sli.Add(new SelectListItem { Text = "Czech", Value = "cs" });
            sli.Add(new SelectListItem { Text = "Danish", Value = "da" });
            sli.Add(new SelectListItem { Text = "Dutch", Value = "nl" });
            sli.Add(new SelectListItem { Text = "English", Value = "en" });
            sli.Add(new SelectListItem { Text = "Esperanto", Value = "eo" });
            sli.Add(new SelectListItem { Text = "Estonian", Value = "et" });
            sli.Add(new SelectListItem { Text = "Finnish", Value = "fi" });
            sli.Add(new SelectListItem { Text = "French", Value = "fr" });
            sli.Add(new SelectListItem { Text = "Frisian", Value = "fy" });
            sli.Add(new SelectListItem { Text = "Galician", Value = "gl" });
            sli.Add(new SelectListItem { Text = "Georgian", Value = "ka" });
            sli.Add(new SelectListItem { Text = "German", Value = "de" });
            sli.Add(new SelectListItem { Text = "Greek", Value = "el" });
            sli.Add(new SelectListItem { Text = "Gujarati", Value = "gu" });
            sli.Add(new SelectListItem { Text = "Haitian Creole", Value = "ht" });
            sli.Add(new SelectListItem { Text = "Hausa", Value = "ha" });
            sli.Add(new SelectListItem { Text = "Hawaiian", Value = "haw" });
            sli.Add(new SelectListItem { Text = "Hebrew", Value = "he" });
            sli.Add(new SelectListItem { Text = "Hindi", Value = "hi" });
            sli.Add(new SelectListItem { Text = "Hmong", Value = "hmn" });
            sli.Add(new SelectListItem { Text = "Hungarian", Value = "hu" });
            sli.Add(new SelectListItem { Text = "Icelandic", Value = "is" });
            sli.Add(new SelectListItem { Text = "Igbo", Value = "ig" });
            sli.Add(new SelectListItem { Text = "Indonesian", Value = "id" });
            sli.Add(new SelectListItem { Text = "Irish", Value = "ga" });
            sli.Add(new SelectListItem { Text = "Italian", Value = "it" });
            sli.Add(new SelectListItem { Text = "Japanese", Value = "ja" });
            sli.Add(new SelectListItem { Text = "Javanese", Value = "jv" });
            sli.Add(new SelectListItem { Text = "Kannada", Value = "kn" });
            sli.Add(new SelectListItem { Text = "Kazakh", Value = "kk" });
            sli.Add(new SelectListItem { Text = "Khmer", Value = "km" });
            sli.Add(new SelectListItem { Text = "Kinyarwanda", Value = "rw" });
            sli.Add(new SelectListItem { Text = "Korean", Value = "ko" });
            sli.Add(new SelectListItem { Text = "Kurdish", Value = "ku" });
            sli.Add(new SelectListItem { Text = "Kyrgyz", Value = "ky" });
            sli.Add(new SelectListItem { Text = "Lao", Value = "lo" });
            sli.Add(new SelectListItem { Text = "Latin", Value = "la" });
            sli.Add(new SelectListItem { Text = "Latvian", Value = "lv" });
            sli.Add(new SelectListItem { Text = "Lithuanian", Value = "lt" });
            sli.Add(new SelectListItem { Text = "Luxembourgish", Value = "lb" });
            sli.Add(new SelectListItem { Text = "Macedonian", Value = "mk" });
            sli.Add(new SelectListItem { Text = "Malagasy", Value = "mg" });
            sli.Add(new SelectListItem { Text = "Malay", Value = "ms" });
            sli.Add(new SelectListItem { Text = "Malayalam", Value = "ml" });
            sli.Add(new SelectListItem { Text = "Maltese", Value = "mt" });
            sli.Add(new SelectListItem { Text = "Maori", Value = "mi" });
            sli.Add(new SelectListItem { Text = "Marathi", Value = "mr" });
            sli.Add(new SelectListItem { Text = "Mongolian", Value = "mn" });
            sli.Add(new SelectListItem { Text = "Myanmar (Burmese)", Value = "my" });
            sli.Add(new SelectListItem { Text = "Nepali", Value = "ne" });
            sli.Add(new SelectListItem { Text = "Norwegian", Value = "no" });
            sli.Add(new SelectListItem { Text = "Nyanja (Chichewa)", Value = "ny" });
            sli.Add(new SelectListItem { Text = "Odia (Oriya)", Value = "or" });
            sli.Add(new SelectListItem { Text = "Pashto", Value = "ps" });
            sli.Add(new SelectListItem { Text = "Persian", Value = "fa" });
            sli.Add(new SelectListItem { Text = "Polish", Value = "pl" });
            sli.Add(new SelectListItem { Text = "Portuguese (Portugal, Brazil)", Value = "pt" });
            sli.Add(new SelectListItem { Text = "Punjabi", Value = "pa" });
            sli.Add(new SelectListItem { Text = "Romanian", Value = "ro" });
            sli.Add(new SelectListItem { Text = "Russian", Value = "ru" });
            sli.Add(new SelectListItem { Text = "Samoan", Value = "sm" });
            sli.Add(new SelectListItem { Text = "Scots Gaelic", Value = "gd" });
            sli.Add(new SelectListItem { Text = "Serbian", Value = "sr" });
            sli.Add(new SelectListItem { Text = "Sesotho", Value = "st" });
            sli.Add(new SelectListItem { Text = "Shona", Value = "sn" });
            sli.Add(new SelectListItem { Text = "Sindhi", Value = "sd" });
            sli.Add(new SelectListItem { Text = "Sinhala (Sinhalese)", Value = "si" });
            sli.Add(new SelectListItem { Text = "Slovak", Value = "sk" });
            sli.Add(new SelectListItem { Text = "Slovenian", Value = "sl" });
            sli.Add(new SelectListItem { Text = "Somali", Value = "so" });
            sli.Add(new SelectListItem { Text = "Spanish", Value = "es" });
            sli.Add(new SelectListItem { Text = "Sundanese", Value = "su" });
            sli.Add(new SelectListItem { Text = "Swahili", Value = "sw" });
            sli.Add(new SelectListItem { Text = "Swedish", Value = "sv" });
            sli.Add(new SelectListItem { Text = "Tagalog (Filipino)", Value = "tl" });
            sli.Add(new SelectListItem { Text = "Tajik", Value = "tg" });
            sli.Add(new SelectListItem { Text = "Tamil", Value = "ta" });
            sli.Add(new SelectListItem { Text = "Tatar", Value = "tt" });
            sli.Add(new SelectListItem { Text = "Telugu", Value = "te" });
            sli.Add(new SelectListItem { Text = "Thai", Value = "th" });
            sli.Add(new SelectListItem { Text = "Turkish", Value = "tr" });
            sli.Add(new SelectListItem { Text = "Turkmen", Value = "tk" });
            sli.Add(new SelectListItem { Text = "Ukrainian", Value = "uk" });
            sli.Add(new SelectListItem { Text = "Urdu", Value = "ur" });
            sli.Add(new SelectListItem { Text = "Uyghur", Value = "ug" });
            sli.Add(new SelectListItem { Text = "Uzbek", Value = "uz" });
            sli.Add(new SelectListItem { Text = "Vietnamese", Value = "vi" });
            sli.Add(new SelectListItem { Text = "Welsh", Value = "cy" });
            sli.Add(new SelectListItem { Text = "Xhosa", Value = "xh" });
            sli.Add(new SelectListItem { Text = "Yiddish", Value = "yi" });
            sli.Add(new SelectListItem { Text = "Yoruba", Value = "yo" });
            sli.Add(new SelectListItem { Text = "Zulu", Value = "zu" });

            return sli;
        }
    }
}
