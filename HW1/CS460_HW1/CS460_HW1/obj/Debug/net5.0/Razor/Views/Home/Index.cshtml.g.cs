#pragma checksum "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cb0c25e4a2043d2722744cf8815b3fad9f57c3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\_ViewImports.cshtml"
using CS460_HW1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\_ViewImports.cshtml"
using CS460_HW1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cb0c25e4a2043d2722744cf8815b3fad9f57c3d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"508aed1989febfd03cc04fd4e1d5deb51e371f40", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<double>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cb0c25e4a2043d2722744cf8815b3fad9f57c3d5193", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n\r\n</script>\r\n");
#nullable restore
#line 10 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
  
    List<string> frontgears = new List<string>();
    List<string> reargears = new List<string>();

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<div class=\"container-fluid\" style=\"padding-bottom:15px;\">\r\n    <h1 class=\"display-4\" style=\"text-align: center;\">Bike Gearing Calculator</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cb0c25e4a2043d2722744cf8815b3fad9f57c3d6738", async() => {
                WriteLiteral(@"
        <div class=""row"" style=""padding-bottom: 1%;"">
            <div class=""col"">
                <p style=""padding-left: 35%;"">Wheel Circumference (in mm)</p>
            </div>
            <div class=""col"">
                <input class=""form-control"" type=""text"" placeholder=""EX: 2111.5"" id=""Circumference"" name=""Circumference"" style=""width: 50%;"">

            </div>
        </div>

        <div class=""row"" style=""padding-bottom: 1%;"">
            <div class=""col"">
                <p style=""padding-left: 35%;"">Front chainring sizes</p>
            </div>
            <div class=""col"">
                <input class=""form-control"" type=""text"" placeholder=""EX: 30,46"" id=""Front"" name=""Front"" style=""width: 50%;"">
            </div>
        </div>

        <div class=""row"" style=""padding-bottom: 1%;"">
            <div class=""col"">
                <p style=""padding-left: 35%;"">Rear cog sizes</p>
            </div>
            <div class=""col"">
                <input class=""form-control"" ty");
                WriteLiteral(@"pe=""text"" placeholder=""EX: 11,13,15,17,19,21,23,25,27"" id=""Rear"" name=""Rear"" style=""width: 50%;"">
            </div>
        </div>

        <div class=""row"" style=""padding-bottom: 1%;"">
            <div class=""col"">
                <p style=""padding-left: 35%;"">Pedaling cadence (RPM)</p>
            </div>
            <div class=""col"">
                <input class=""form-control"" type=""text"" placeholder=""EX: 90"" id=""RPM"" name=""RPM"" style=""width: 50%;"">
            </div>
        </div>

        <div class=""form-check"" style=""padding-left: 20%;"">
            <input class=""form-check-input"" type=""radio"" name=""Speed"" id=""MPH"" value=""MPH"">
            <label class=""form-check-label"" for=""MPH"">
                MPH
            </label>
        </div>
        <div class=""form-check"" style=""padding-left: 20%;"">
            <input class=""form-check-input"" type=""radio"" name=""Speed"" id=""KPH"" value=""KPH"">
            <label class=""form-check-label"" for=""KPH"">
                KPH
            </label");
                WriteLiteral(">\r\n        </div>\r\n\r\n\r\n\r\n        <div class=\"col-12\" style=\"padding-left:45%;\">\r\n            <input class=\"btn btn-primary\" type=\"submit\" value=\"Submit\">\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 77 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"slidecontainer\">\r\n        <input type=\"range\" min=\"1\" max=\"100\" value=\"50\" class=\"slider\" id=\"myRange\">\r\n        <p>Desired Speed: <span id=\"value\"></span></p>\r\n    </div>\r\n");
#nullable restore
#line 83 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
     foreach (var f in ViewData["fronts"] as IEnumerable<string>)
    {
        frontgears.Add(f);
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
     foreach (var r in ViewData["rears"] as IEnumerable<string>)
    {
        reargears.Add(r);
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
     

    
    int count = 0;
    int marker = 0;
    


#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered\">\r\n        <thead>\r\n            <tr>\r\n                <th scope=\"col\">Cogs</th>\r\n");
#nullable restore
#line 101 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
                 for (int i = 0; i < frontgears.Count; ++i)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 103 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
                   Write(frontgears[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 104 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th scope=\"col\">Cogs</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n\r\n");
#nullable restore
#line 110 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
             for (int j = 0; j < reargears.Count; ++j)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 113 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
                   Write(reargears[j]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 114 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
                     for (int k = 0; k < frontgears.Count; ++k)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
                         if (k + count < Model.Count)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td");
            BeginWriteAttribute("id", " id=\"", 3924, "\"", 3948, 1);
#nullable restore
#line 118 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
WriteAttributeValue("", 3929, Model[k + count], 3929, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 118 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
                                                    Write(Math.Round(Model[k + count], 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 119 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
                      
                        count += frontgears.Count;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>");
#nullable restore
#line 124 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
                   Write(reargears[j]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 127 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 134 "C:\Users\Korbin Cardoza\source\repos\CS460_HW1\CS460_HW1\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<double>> Html { get; private set; }
    }
}
#pragma warning restore 1591