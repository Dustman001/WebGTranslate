#pragma checksum "C:\Users\Administrator\source\repos\WebGoogleTranslate\WebGoogleTranslate\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a09758ebf7122b1c3ab5a35384125c4e91d5ccf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Administrator\source\repos\WebGoogleTranslate\WebGoogleTranslate\Views\_ViewImports.cshtml"
using WebGoogleTranslate;

#line default
#line hidden
#line 2 "C:\Users\Administrator\source\repos\WebGoogleTranslate\WebGoogleTranslate\Views\_ViewImports.cshtml"
using WebGoogleTranslate.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a09758ebf7122b1c3ab5a35384125c4e91d5ccf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8140067d39c54ef27f4663c7aeeeefd43319257a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebGoogleTranslate.Models.TranslateModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\source\repos\WebGoogleTranslate\WebGoogleTranslate\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var SrcSel = new SelectList(Model.Langs, "Value", "Text", "es");
    var TrgSel = new SelectList(Model.Langs, "Value", "Text", "en");
    ViewData["Sources"] = SrcSel;
    ViewData["Targets"] = TrgSel;

#line default
#line hidden
            BeginContext(306, 432, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""container"">
        <h2>Translation Test Page</h2>
        <p id=""unmode1"">Sample pages using ASP.NET Core MVC to tranlate simple Text</pid=""unmode""><br />
        <p id=""unmode2"">Sample pages using ASP.NET Core MVC to tranlate simple Text</p><br />
        <p id=""unmode3"">Sample pages using ASP.NET Core MVC to tranlate simple Text</p><br />
        <div class=""form-group"">
            ");
            EndContext();
            BeginContext(739, 126, false);
#line 18 "C:\Users\Administrator\source\repos\WebGoogleTranslate\WebGoogleTranslate\Views\Home\Index.cshtml"
       Write(Html.LabelFor(model => model.SelectedSourceLg, "Idioma", htmlAttributes: new { @class = "control-label col-md-2", @id="idm" }));

#line default
#line hidden
            EndContext();
            BeginContext(865, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(921, 208, false);
#line 20 "C:\Users\Administrator\source\repos\WebGoogleTranslate\WebGoogleTranslate\Views\Home\Index.cshtml"
           Write(Html.DropDownListFor(M => M.SelectedSourceLg, new SelectList(Model.Langs, "Value", "Text", Model.SelectedSourceLg), new { @class = "dropdown col-md-4", @id = "PagLang", @onchange = "PageLangs(this.value);" }));

#line default
#line hidden
            EndContext();
            BeginContext(1129, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1148, 31, false);
#line 21 "C:\Users\Administrator\source\repos\WebGoogleTranslate\WebGoogleTranslate\Views\Home\Index.cshtml"
           Write(Html.Hidden("PagLangSet", "es"));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 90, true);
            WriteLiteral("\r\n            </div>\r\n        </div><br />\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1270, 115, false);
#line 25 "C:\Users\Administrator\source\repos\WebGoogleTranslate\WebGoogleTranslate\Views\Home\Index.cshtml"
       Write(Html.LabelFor(model => model.SelectedSourceLg, "Origen", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1385, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1441, 170, false);
#line 27 "C:\Users\Administrator\source\repos\WebGoogleTranslate\WebGoogleTranslate\Views\Home\Index.cshtml"
           Write(Html.DropDownListFor(M => M.SelectedSourceLg, new SelectList(Model.Langs, "Value", "Text", Model.SelectedSourceLg), new { @class = "dropdown col-md-4", @id = "SrcLang" }));

#line default
#line hidden
            EndContext();
            BeginContext(1611, 90, true);
            WriteLiteral("\r\n            </div>\r\n        </div><br />\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1702, 108, false);
#line 31 "C:\Users\Administrator\source\repos\WebGoogleTranslate\WebGoogleTranslate\Views\Home\Index.cshtml"
       Write(Html.LabelFor(M => M.SelectedTargetLg, "Destino", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1810, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1866, 170, false);
#line 33 "C:\Users\Administrator\source\repos\WebGoogleTranslate\WebGoogleTranslate\Views\Home\Index.cshtml"
           Write(Html.DropDownListFor(M => M.SelectedTargetLg, new SelectList(Model.Langs, "Value", "Text", Model.SelectedTargetLg), new { @class = "dropdown col-md-4", @id = "TrgLang" }));

#line default
#line hidden
            EndContext();
            BeginContext(2036, 91, true);
            WriteLiteral(";\r\n            </div>\r\n        </div><br />\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(2128, 103, false);
#line 37 "C:\Users\Administrator\source\repos\WebGoogleTranslate\WebGoogleTranslate\Views\Home\Index.cshtml"
       Write(Html.LabelFor(M => M.Origin, "Texto Origen", htmlAttributes: new { @class = "control-label col-md-4" }));

#line default
#line hidden
            EndContext();
            BeginContext(2231, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(2287, 81, false);
#line 39 "C:\Users\Administrator\source\repos\WebGoogleTranslate\WebGoogleTranslate\Views\Home\Index.cshtml"
           Write(Html.TextAreaFor(m => m.Origin, 10, 10, new { @class = "form-control col-md-4" }));

#line default
#line hidden
            EndContext();
            BeginContext(2368, 90, true);
            WriteLiteral("\r\n            </div>\r\n        </div><br />\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(2459, 106, false);
#line 43 "C:\Users\Administrator\source\repos\WebGoogleTranslate\WebGoogleTranslate\Views\Home\Index.cshtml"
       Write(Html.LabelFor(M => M.Result, "Texto Traducido", htmlAttributes: new { @class = "control-label col-md-4" }));

#line default
#line hidden
            EndContext();
            BeginContext(2565, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(2621, 81, false);
#line 45 "C:\Users\Administrator\source\repos\WebGoogleTranslate\WebGoogleTranslate\Views\Home\Index.cshtml"
           Write(Html.TextAreaFor(m => m.Result, 10, 10, new { @class = "form-control col-md-4" }));

#line default
#line hidden
            EndContext();
            BeginContext(2702, 1349, true);
            WriteLiteral(@"
            </div>
        </div><br />
    </div>
</div>
<script type=""text/javascript"">

    var pl = document.getElementById(""PagLang"");
    var sl = document.getElementById(""SrcLang"");
    var tl = document.getElementById(""TrgLang"");
    var ps = document.getElementById(""PagLangSet"");
    var idm = document.getElementById('idm');

    var url = 'https://translate.google.com/translate_a/single?client=at&dt=t&dt=ld&dt=qca&dt=rm&dt=bd&dj=1&&ie=UTF-8&oe=UTF-8&inputm=2&otf=2&iid=1dd3b944-fa62-4b55-b330-74909a99969e';
    var urk = 'https://translate.google.com/translate_a/single?client=at&dt=t&dt=ld&dt=qca&dt=rm&dt=bd&dj=1&&ie=UTF-8&oe=UTF-8&inputm=2&otf=2&iid=1dd3b944-fa62-4b55-b330-74909a99969e&sl=es&tl=ps&hl=ps&q=""Idioma""';

    function PageLangs(val) {
        //& sl=es & tl=en & hl=en & q=""Quiero un Nuevo trabajo""
        // + '&sl=' + pls.value + '&tl=' + pl.value + '&hl=' + pl.value + '&q=' + '""' + idm.innerText + '""';

        urlk = url + '&sl=' + ps.value + '&tl=' + pl.value + '");
            WriteLiteral(@"&hl=' + pl.value + '&q=""' + idm.innerHTML + '""';
        document.getElementById(""unmode1"").innerText = urlk;

        document.getElementById(""unmode1"").innerText = fetch(urk).then(response => response.json())
            .then(json => console.log(json));
    }

    window.onload = function () {

    };
</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebGoogleTranslate.Models.TranslateModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
