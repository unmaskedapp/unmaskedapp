#pragma checksum "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2df6d56ce118601455d30c8b86904442b889cde"
// <auto-generated/>
#pragma warning disable 1591
namespace UnmaskedApp.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\_Imports.razor"
using UnmaskedApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\_Imports.razor"
using UnmaskedApp.Client.Elements;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\_Imports.razor"
using UnmaskedApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\_Imports.razor"
using UnmaskedApp.Shared.Model;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenDialog>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenNotification>(2);
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "sidebar");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenComponent<UnmaskedApp.Client.Shared.NavMenu>(7);
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "id", "out");
            __builder.AddAttribute(12, "class", "main");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Shared\MainLayout.razor"
                                     () => MouseClickHandler.InvokeBodyClick()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.AddMarkupContent(15, "<div class=\"top-row px-4\">\r\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "content px-4");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.AddContent(19, 
#nullable restore
#line 17 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UnmaskedApp.Client.Code.Events.MouseClickHandler MouseClickHandler { get; set; }
    }
}
#pragma warning restore 1591