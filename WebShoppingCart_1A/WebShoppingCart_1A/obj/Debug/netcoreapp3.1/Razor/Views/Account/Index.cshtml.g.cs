#pragma checksum "E:\Documents\NUS ISS\SA4102 Foundation\4. NETCORE\CA project (shopping website)\final\Team 1A\WebShoppingCart_1A\WebShoppingCart_1A\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d964fa064e76d8f7e07ecaba669df0f818d207c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "E:\Documents\NUS ISS\SA4102 Foundation\4. NETCORE\CA project (shopping website)\final\Team 1A\WebShoppingCart_1A\WebShoppingCart_1A\Views\_ViewImports.cshtml"
using WebShoppingCart_1A;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Documents\NUS ISS\SA4102 Foundation\4. NETCORE\CA project (shopping website)\final\Team 1A\WebShoppingCart_1A\WebShoppingCart_1A\Views\_ViewImports.cshtml"
using WebShoppingCart_1A.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d964fa064e76d8f7e07ecaba669df0f818d207c5", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2396f6fe83ecb21a5f42a3f30c611e9c32f0fdb", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Documents\NUS ISS\SA4102 Foundation\4. NETCORE\CA project (shopping website)\final\Team 1A\WebShoppingCart_1A\WebShoppingCart_1A\Views\Account\Index.cshtml"
  
    var accounts = ViewData["accounts"] as List<Account>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\Documents\NUS ISS\SA4102 Foundation\4. NETCORE\CA project (shopping website)\final\Team 1A\WebShoppingCart_1A\WebShoppingCart_1A\Views\Account\Index.cshtml"
 if (Context.Request.Cookies["UserId"] != null && accounts != null)
{
    //foreach (var account in accounts)
    //{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h1>Welcome Back User!</h1>\r\n        </div>\r\n");
#nullable restore
#line 12 "E:\Documents\NUS ISS\SA4102 Foundation\4. NETCORE\CA project (shopping website)\final\Team 1A\WebShoppingCart_1A\WebShoppingCart_1A\Views\Account\Index.cshtml"
    //}
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
