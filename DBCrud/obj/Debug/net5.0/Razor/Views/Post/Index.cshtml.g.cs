#pragma checksum "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\DB-Entity-Framework-2\DBCrud\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eacf9dfd3bbf44e724e93d2b226189ba5cf51556"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
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
#nullable restore
#line 1 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\DB-Entity-Framework-2\DBCrud\Views\_ViewImports.cshtml"
using DBCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\DB-Entity-Framework-2\DBCrud\Views\_ViewImports.cshtml"
using DBCrud.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eacf9dfd3bbf44e724e93d2b226189ba5cf51556", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"754b194330ccf3182506c2732ac2d2ad3e565f42", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\DB-Entity-Framework-2\DBCrud\Views\Post\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
#nullable restore
#line 9 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\DB-Entity-Framework-2\DBCrud\Views\Post\Index.cshtml"
 if (TempData.ContainsKey("Status"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n            <strong>Notification!</strong> ");
#nullable restore
#line 12 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\DB-Entity-Framework-2\DBCrud\Views\Post\Index.cshtml"
                                      Write(TempData["Status"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n            <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>\r\n        </div>\r\n");
#nullable restore
#line 15 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\DB-Entity-Framework-2\DBCrud\Views\Post\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Title</th>
            <th scope=""col"">Content</th>
            <th scope=""col"">Date</th>
            <th scope=""col"">ImageUrl</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 29 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\DB-Entity-Framework-2\DBCrud\Views\Post\Index.cshtml"
         foreach (var item in @Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 32 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\DB-Entity-Framework-2\DBCrud\Views\Post\Index.cshtml"
                            Write(count++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 33 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\DB-Entity-Framework-2\DBCrud\Views\Post\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\DB-Entity-Framework-2\DBCrud\Views\Post\Index.cshtml"
               Write(Html.Raw(@item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\DB-Entity-Framework-2\DBCrud\Views\Post\Index.cshtml"
               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><img alt=\"ImageUrl\"");
            BeginWriteAttribute("src", " src=\"", 1001, "\"", 1021, 1);
#nullable restore
#line 36 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\DB-Entity-Framework-2\DBCrud\Views\Post\Index.cshtml"
WriteAttributeValue("", 1007, item.ImageUrl, 1007, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\DB-Entity-Framework-2\DBCrud\Views\Post\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
