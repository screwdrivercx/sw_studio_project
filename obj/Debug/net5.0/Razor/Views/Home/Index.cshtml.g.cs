#pragma checksum "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a37aa8454f2555b5c983c6aebefc43987bf6625"
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
#line 1 "C:\Users\Non\Documents\Github\sw_studio_project\Views\_ViewImports.cshtml"
using sw_studio_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Non\Documents\Github\sw_studio_project\Views\_ViewImports.cshtml"
using sw_studio_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a37aa8454f2555b5c983c6aebefc43987bf6625", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"434dee868b1ee30434ead438132f50511cac621f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rooms>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "History", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "History", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("timeline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return checkSubmit()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";
    var i = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("<header>\n       <nav class=\"navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3\">\n            <div class=\"container\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a37aa8454f2555b5c983c6aebefc43987bf66257850", async() => {
                WriteLiteral("sw studio");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target="".navbar-collapse"" aria-controls=""navbarSupportedContent""
                        aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""navbar-collapse collapse d-sm-inline-flex justify-content-between"">
                    <ul class=""navbar-nav flex-grow-1"">
                        <li class=""nav-item"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a37aa8454f2555b5c983c6aebefc43987bf662510063", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </li>\n                        <li class=\"nav-item\">\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a37aa8454f2555b5c983c6aebefc43987bf662511812", async() => {
                WriteLiteral("History");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </li>\n                        <li class=\"nav-item ml-auto\">\n                             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a37aa8454f2555b5c983c6aebefc43987bf662513573", async() => {
                WriteLiteral("Log Out");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </li>
                    </ul>
                </div>
                <div>
                    <p></p>
                </div>
            </div>
        </nav>

</div>
<div class=""container my-5"">
    <h1 class=""display-4"">Room List</h1>
    <table class=""table mt-4"">
        <thead>
            <tr>
                <th>#</th>
                <th>room</th>
                <th>room number</th>
                <th>accessory</th>
                <th>count</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 48 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
             foreach (var room in Model.rooms)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <tr>\n                    <td>\n                        ");
#nullable restore
#line 52 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 55 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
                   Write(room.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 58 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
                   Write(room.number);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 61 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
                   Write(room.accName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 64 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
                   Write(room.accNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        <button class=\"btn btn-success\" onclick=\"rent(this)\"");
            BeginWriteAttribute("value", "value =\"", 2565, "\"", 2586, 1);
#nullable restore
#line 67 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
WriteAttributeValue("", 2573, room.accName, 2573, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("number", " number=", 2587, "", 2610, 1);
#nullable restore
#line 67 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
WriteAttributeValue("", 2595, room.accNumber, 2595, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >เลือก</button>\n                    </td>   \n                </tr>\n");
#nullable restore
#line 70 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
                i+=1;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n        \n    </table>\n\n</div>\n<div id =  \'bg-timeline\' class = \'bg-timeline\'>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a37aa8454f2555b5c983c6aebefc43987bf662518748", async() => {
                WriteLiteral(@"
    <span class='rentHeader' name = 'objName'  >โปรดระบุเวลาที่จะใช้งาน</span>
    <input type ='hidden' id='hidden' name = 'objName' value=""Submit"" number =12>
    <div class  = 'dateS'>
        <input id = 'time-start' name='timeStart' type = ""date"" > <br/> 
");
#nullable restore
#line 83 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
         for(var j = 0 ; j<24;j++){


#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"radio\" name= \'timeS\' class = \'hourBtS\'");
                BeginWriteAttribute("id", " id=", 3286, "", 3294, 2);
                WriteAttributeValue("", 3290, "S+", 3290, 2, true);
#nullable restore
#line 85 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
WriteAttributeValue("", 3292, j, 3292, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", "  value=", 3294, "", 3304, 1);
#nullable restore
#line 85 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
WriteAttributeValue("", 3302, j, 3302, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  disabled=false >\n            <label class=\"for-hourBtS\"");
                BeginWriteAttribute("for", " for=", 3361, "", 3370, 2);
                WriteAttributeValue("", 3366, "S+", 3366, 2, true);
#nullable restore
#line 86 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
WriteAttributeValue("", 3368, j, 3368, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 86 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
                                           Write(j);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n");
#nullable restore
#line 87 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br/> \n        </div>\n\n        <div class  = \'dateE\'>\n            <input id = \'time-end\' name=\'timeEnd\' type = \"date\"> \n            <br/> \n");
#nullable restore
#line 94 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
             for(var j = 0 ; j<24;j++){

#line default
#line hidden
#nullable disable
                WriteLiteral("                <input type=\"radio\" name= \'timeE\' class = \'hourBtE\'");
                BeginWriteAttribute("id", " id=", 3646, "", 3654, 2);
                WriteAttributeValue("", 3650, "E+", 3650, 2, true);
#nullable restore
#line 95 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
WriteAttributeValue("", 3652, j, 3652, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=", 3654, "", 3663, 1);
#nullable restore
#line 95 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
WriteAttributeValue("", 3661, j, 3661, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  disabled=false>\n                <label class=\"for-hourBtE\"");
                BeginWriteAttribute("for", " for=", 3723, "", 3732, 2);
                WriteAttributeValue("", 3728, "E+", 3728, 2, true);
#nullable restore
#line 96 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
WriteAttributeValue("", 3730, j, 3730, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 96 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
                                               Write(j);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n");
#nullable restore
#line 97 "C:\Users\Non\Documents\Github\sw_studio_project\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\n         <input type=\"submit\" class= \'submit\'/>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<script>
    document.getElementById('time-start').addEventListener('input',function(e){
           var objName = document.getElementById('hidden').getAttribute('value')
           var a =  httpGet(`https://localhost:5001/CheckLog/checkDate/?Date=${e.target.value}&objName=${objName}`)
           var timeNumber = a.substring(1,a.length-1).split("","");
           var objNumber = document.getElementById('hidden').getAttribute('number');
           for(let k =0; k<24;k++){
               if(timeNumber[k] >= objNumber ){
                    document.getElementById(`S+${k}`).disabled = true;
                    document.getElementById(`S+${k}`).checked = false;
               }
               else{
                   document.getElementById(`S+${k}`).disabled = false;
               }
           }
    })
    document.getElementById('time-end').addEventListener('input',function(e){
           var objName = document.getElementById('hidden').getAttribute('value')
           var a =  httpGet(`https://localhost:5");
            WriteLiteral(@"001/CheckLog/checkDate/?Date=${e.target.value}&objName=${objName}`)
           var timeNumber = a.substring(1,a.length-1).split("","");
           var objNumber = document.getElementById('hidden').getAttribute('number');
           for(let k =0; k<24;k++){
               if(timeNumber[k] >= objNumber ){
                    document.getElementById(`E+${k}`).disabled = true;
                    document.getElementById(`E+${k}`).checked = false;
               }
               else{
                   document.getElementById(`E+${k}`).disabled = false;
               }
           }

    })
    /*document.getElementById('time-start').addEventListener('input',function(e){
           var a =  httpGet(`https://localhost:5001/CheckLog/checkEnd/?Date=${e.target.value}`)
    })*/
    var popup= document.getElementById(""bg-timeline"");
    function rent(obj){
        document.getElementsByClassName('rentHeader')[0].innerHTML += "" ""+obj.getAttribute('value');
        document.getElementById('hidden').setAttribute('value',ob");
            WriteLiteral(@"j.getAttribute('value'))
        document.getElementById('hidden').setAttribute('number',obj.getAttribute('number'))
        popup.style.display =""block""
    }
    window.onclick = function(event) {
        if (event.target == document.getElementById(""bg-timeline"")) {
            popup.style.display = ""none"";
        }
    }
    function httpGet(theUrl,date)
    {
        var xmlHttp = new XMLHttpRequest();
        xmlHttp.open( ""GET"", theUrl, false ); // false for synchronous request
        xmlHttp.send( null );
        return xmlHttp.responseText;
    }
    //string startD , int startH, string endD, int endH,int objNumber , string objName
    function checkSubmit(){
        //////
        let dateS  = document.getElementById('time-start').value
        let dateE  = document.getElementById('time-end').value
        let radioS = $(""input[type='radio'][name='timeS']:checked"").val();
        let radioE = $(""input[type='radio'][name='timeE']:checked"").val();
        let objNumber =  document.getElementById('hid");
            WriteLiteral(@"den').getAttribute('number')
        let objName =  document.getElementById('hidden').getAttribute('value')
        if(dateS === """" || dateE === """" || (dateE == dateS && radioE< radioS ) ){
           alert(""Invalid format"")
            return false
        }
        let a  = httpGet(`https://localhost:5001/CheckLog/checkSubmit/?startD=${dateS}&startH=${radioS}&endD=${dateE}&endH=${radioE}&objNumber=${objNumber}&objName=${objName}`)
        if(a == ""true""){
            alert(""Success"")
            return true;
        }
        else 
            alert(""Fail"")
            return false;
         
    }

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rooms> Html { get; private set; }
    }
}
#pragma warning restore 1591
