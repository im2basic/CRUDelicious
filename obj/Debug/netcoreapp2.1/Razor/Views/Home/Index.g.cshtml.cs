#pragma checksum "C:\Users\basic\Desktop\codingDojo\c#\Orm\CruDelicious\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce24a5fcaa7d820ff0dfe210b1591ea2e9d88fe5"
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
#line 1 "C:\Users\basic\Desktop\codingDojo\c#\Orm\CruDelicious\Views\_ViewImports.cshtml"
using CruDelicious;

#line default
#line hidden
#line 1 "C:\Users\basic\Desktop\codingDojo\c#\Orm\CruDelicious\Views\Home\Index.cshtml"
using CruDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce24a5fcaa7d820ff0dfe210b1591ea2e9d88fe5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b15da1d6f0454838bbf08eaa2330962effdf87a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dishes>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 132, true);
            WriteLiteral("<div class=\"header\">\r\n<h1>Welcome to CRUDelicious</h1>\r\n<h5>Check out some dishes!</h5>\r\n<a href=\"/new\">Add a Dish</a>\r\n</div><br>\r\n");
            EndContext();
#line 8 "C:\Users\basic\Desktop\codingDojo\c#\Orm\CruDelicious\Views\Home\Index.cshtml"
 foreach(var Dish in Model)
{

#line default
#line hidden
            BeginContext(213, 6, true);
            WriteLiteral("    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 219, "\"", 244, 2);
            WriteAttributeValue("", 226, "/info/", 226, 6, true);
#line 10 "C:\Users\basic\Desktop\codingDojo\c#\Orm\CruDelicious\Views\Home\Index.cshtml"
WriteAttributeValue("", 232, Dish.DishId, 232, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(245, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(247, 13, false);
#line 10 "C:\Users\basic\Desktop\codingDojo\c#\Orm\CruDelicious\Views\Home\Index.cshtml"
                            Write(Dish.NameDish);

#line default
#line hidden
            EndContext();
            BeginContext(260, 11, true);
            WriteLiteral("</a><p> by ");
            EndContext();
            BeginContext(272, 9, false);
#line 10 "C:\Users\basic\Desktop\codingDojo\c#\Orm\CruDelicious\Views\Home\Index.cshtml"
                                                     Write(Dish.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(281, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 11 "C:\Users\basic\Desktop\codingDojo\c#\Orm\CruDelicious\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(290, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dishes>> Html { get; private set; }
    }
}
#pragma warning restore 1591
