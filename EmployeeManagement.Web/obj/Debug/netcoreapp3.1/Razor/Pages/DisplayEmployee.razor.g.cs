#pragma checksum "C:\Users\marc_\OneDrive\Desktop\Kudvenkat\Blazor\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b910fac4b790d2cae4095a2d45a7b0e0d45b6457"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\marc_\OneDrive\Desktop\Kudvenkat\Blazor\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marc_\OneDrive\Desktop\Kudvenkat\Blazor\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\marc_\OneDrive\Desktop\Kudvenkat\Blazor\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\marc_\OneDrive\Desktop\Kudvenkat\Blazor\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\marc_\OneDrive\Desktop\Kudvenkat\Blazor\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\marc_\OneDrive\Desktop\Kudvenkat\Blazor\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\marc_\OneDrive\Desktop\Kudvenkat\Blazor\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\marc_\OneDrive\Desktop\Kudvenkat\Blazor\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\marc_\OneDrive\Desktop\Kudvenkat\Blazor\Projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
    public partial class DisplayEmployee : DisplayEmployeeBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card m-3");
            __builder.AddAttribute(2, "style", "min-width: 18rem; max-width:30.5%");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-header");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "h3");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "checkbox");
            __builder.AddAttribute(11, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\marc_\OneDrive\Desktop\Kudvenkat\Blazor\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                              CheckBoxChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
#nullable restore
#line 7 "C:\Users\marc_\OneDrive\Desktop\Kudvenkat\Blazor\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
__builder.AddContent(13, Employee.FirstName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, " ");
#nullable restore
#line 7 "C:\Users\marc_\OneDrive\Desktop\Kudvenkat\Blazor\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
__builder.AddContent(15, Employee.LastName);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "class", "card-img-top imageThumbnail");
            __builder.AddAttribute(21, "src", 
#nullable restore
#line 10 "C:\Users\marc_\OneDrive\Desktop\Kudvenkat\Blazor\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                                                   Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n");
#nullable restore
#line 12 "C:\Users\marc_\OneDrive\Desktop\Kudvenkat\Blazor\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
     if (ShowFooter)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "card-footer text-center");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", 
#nullable restore
#line 15 "C:\Users\marc_\OneDrive\Desktop\Kudvenkat\Blazor\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
                       $"/employeedetails/{Employee.EmployeeId}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(29, "class", "btn btn-primary m-1");
            __builder.AddContent(30, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.AddMarkupContent(32, "<a href=\"#\" class=\"btn btn-primary m-1\">Edit</a>\r\n        ");
            __builder.AddMarkupContent(33, "<a href=\"#\" class=\"btn btn-danger m-1\">Delete</a>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 19 "C:\Users\marc_\OneDrive\Desktop\Kudvenkat\Blazor\Projects\BlazorTutorial\EmployeeManagement.Web\Pages\DisplayEmployee.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
