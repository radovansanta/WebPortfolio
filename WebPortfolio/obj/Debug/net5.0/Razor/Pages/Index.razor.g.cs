#pragma checksum "/Users/radovansanta/RiderProjects/WebPortfolio/WebPortfolio/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9bcfd92c1345019d6f28a1066c48205d75f830c"
// <auto-generated/>
#pragma warning disable 1591
namespace WebPortfolio.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/radovansanta/RiderProjects/WebPortfolio/WebPortfolio/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/radovansanta/RiderProjects/WebPortfolio/WebPortfolio/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/radovansanta/RiderProjects/WebPortfolio/WebPortfolio/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/radovansanta/RiderProjects/WebPortfolio/WebPortfolio/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/radovansanta/RiderProjects/WebPortfolio/WebPortfolio/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/radovansanta/RiderProjects/WebPortfolio/WebPortfolio/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/radovansanta/RiderProjects/WebPortfolio/WebPortfolio/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/radovansanta/RiderProjects/WebPortfolio/WebPortfolio/_Imports.razor"
using WebPortfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/radovansanta/RiderProjects/WebPortfolio/WebPortfolio/_Imports.razor"
using WebPortfolio.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/radovansanta/RiderProjects/WebPortfolio/WebPortfolio/Pages/Index.razor"
using WebPortfolio.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/radovansanta/RiderProjects/WebPortfolio/WebPortfolio/Pages/Index.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/radovansanta/RiderProjects/WebPortfolio/WebPortfolio/Pages/Index.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<WebPortfolio.Components.MainSection>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\n");
            __builder.OpenComponent<WebPortfolio.Components.AnotherComponent>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n\n\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", 
#nullable restore
#line 12 "/Users/radovansanta/RiderProjects/WebPortfolio/WebPortfolio/Pages/Index.razor"
             display

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "class", "loader-wrapper");
            __builder.AddMarkupContent(7, "<span class=\"loader\"><span class=\"loader-inner\"></span></span>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "/Users/radovansanta/RiderProjects/WebPortfolio/WebPortfolio/Pages/Index.razor"
      

    string display = "";


    private async Task MakeToastWithButterAndJamAsync()
    {
        await Task.Delay(4000);
        display = "display: none";
    }
    
    protected override async Task OnInitializedAsync()
    {
        await MakeToastWithButterAndJamAsync();
    }
    


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
