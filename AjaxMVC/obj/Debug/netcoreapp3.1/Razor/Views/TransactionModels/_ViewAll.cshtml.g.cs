#pragma checksum "C:\Users\sethm\Desktop\AjaxMVC\AjaxMVC\Views\TransactionModels\_ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82508c58a7c4e744537833535cb35cb17ee694c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TransactionModels__ViewAll), @"mvc.1.0.view", @"/Views/TransactionModels/_ViewAll.cshtml")]
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
#line 1 "C:\Users\sethm\Desktop\AjaxMVC\AjaxMVC\Views\_ViewImports.cshtml"
using AjaxMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sethm\Desktop\AjaxMVC\AjaxMVC\Views\_ViewImports.cshtml"
using AjaxMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82508c58a7c4e744537833535cb35cb17ee694c3", @"/Views/TransactionModels/_ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad45f33a89d4405e901f8e8d461c0245afef4663", @"/Views/_ViewImports.cshtml")]
    public class Views_TransactionModels__ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AjaxMVC.Models.TransactionModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 9 "C:\Users\sethm\Desktop\AjaxMVC\AjaxMVC\Views\TransactionModels\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 12 "C:\Users\sethm\Desktop\AjaxMVC\AjaxMVC\Views\TransactionModels\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.BeneficiaryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\sethm\Desktop\AjaxMVC\AjaxMVC\Views\TransactionModels\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\sethm\Desktop\AjaxMVC\AjaxMVC\Views\TransactionModels\_ViewAll.cshtml"
           Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 551, "\"", 669, 4);
            WriteAttributeValue("", 561, "showInPopup(\'", 561, 13, true);
#nullable restore
#line 21 "C:\Users\sethm\Desktop\AjaxMVC\AjaxMVC\Views\TransactionModels\_ViewAll.cshtml"
WriteAttributeValue("", 574, Url.Action("AddOrEdit", "TransactionModels", null, Context.Request.Scheme), 574, 75, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 649, "\',\'New", 649, 6, true);
            WriteAttributeValue(" ", 655, "Transaction\')", 656, 14, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success text-white\">\r\n                    <i class=\"fas fa-random\"></i>New Transaction\r\n                </a>\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\sethm\Desktop\AjaxMVC\AjaxMVC\Views\TransactionModels\_ViewAll.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\sethm\Desktop\AjaxMVC\AjaxMVC\Views\TransactionModels\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\sethm\Desktop\AjaxMVC\AjaxMVC\Views\TransactionModels\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.BeneficiaryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\sethm\Desktop\AjaxMVC\AjaxMVC\Views\TransactionModels\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\Users\sethm\Desktop\AjaxMVC\AjaxMVC\Views\TransactionModels\_ViewAll.cshtml"
               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1418, "\"", 1565, 4);
            WriteAttributeValue("", 1428, "showInPopup(\'", 1428, 13, true);
#nullable restore
#line 44 "C:\Users\sethm\Desktop\AjaxMVC\AjaxMVC\Views\TransactionModels\_ViewAll.cshtml"
WriteAttributeValue("", 1441, Url.Action("AddOrEdit", "TransactionModels", new {id = item.TransactionId }, Context.Request.Scheme), 1441, 101, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1542, "\',\'Update", 1542, 9, true);
            WriteAttributeValue(" ", 1551, "Transaction\')", 1552, 14, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info text-white\">\r\n                        <i class=\"fas fa-pencil-alt\"></i>Edit\r\n                    </a>\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82508c58a7c4e744537833535cb35cb17ee694c38173", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\sethm\Desktop\AjaxMVC\AjaxMVC\Views\TransactionModels\_ViewAll.cshtml"
                                             WriteLiteral(item.TransactionId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 51 "C:\Users\sethm\Desktop\AjaxMVC\AjaxMVC\Views\TransactionModels\_ViewAll.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<script>
    showInPopup = (url, title) => {
    $.ajax({
        type: ""GET"",
        url: url,
        success: function (res) {
            $(""#form-modal .modal-body"").html(res);
            $(""#form-modal .modal-title"").html(title);
            $(""#form-modal"").modal('show');
        }
    })
};

jQueryAjaxPost = form => {
    try {
        $.ajax({
            type: 'POST',
            url: form.action,
            data: new FormData(form),
            contentType: false,
            processData: false,
            success: function (res) {
                if (res.isValid) {
                    $(""#view-all"").html(res);
                    $(""#form-modal .modal-body"").html('');
                    $(""#form-modal .modal-title"").html('');
                    $(""#form-modal"").modal('hide');
                }
                else
                    $(""#form-modal .modal-body"").html(res.html);
            },
            error: function (err) {
      ");
            WriteLiteral("          console.log(err);\r\n            }\r\n        })\r\n    }\r\n    catch (e) {\r\n        console.log(e);\r\n    }\r\n    return false;\r\n}\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AjaxMVC.Models.TransactionModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
