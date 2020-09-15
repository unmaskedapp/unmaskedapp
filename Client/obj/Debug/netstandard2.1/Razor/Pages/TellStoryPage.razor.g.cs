#pragma checksum "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c256ddf014848c9929dbf318a018728a2db47b3"
// <auto-generated/>
#pragma warning disable 1591
namespace UnmaskedApp.Client.Pages
{
    #line hidden
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
#nullable restore
#line 2 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
using System;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tellstory")]
    public partial class TellStoryPage : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Tell your maskless adventure</h3>\r\n\r\n");
#nullable restore
#line 13 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
 if (items == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 16 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "margin-left:1em;margin-right:1em");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 20 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
         foreach (StoryElement item in items)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenLabel>(8);
            __builder.AddAttribute(9, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                               GetItemPositionText(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(11);
            __builder.AddAttribute(12, "Icon", "keyboard_arrow_up");
            __builder.AddAttribute(13, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                                                          (async () => await MoveItemIndexBy(item, 1))

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(15);
            __builder.AddAttribute(16, "Icon", "keyboard_arrow_down");
            __builder.AddAttribute(17, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                                                            (async () => await MoveItemIndexBy(item, -1))

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(19);
            __builder.AddAttribute(20, "Icon", "delete");
            __builder.AddAttribute(21, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                                               (async () => await DeleteItem(item))

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n            <br>\r\n            ");
            __builder.OpenComponent<UnmaskedApp.Client.Elements.StoryElementAdapter>(23);
            __builder.AddAttribute(24, "EditMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "Element", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<UnmaskedApp.Shared.Model.StoryElement>(
#nullable restore
#line 27 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                                                          item

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n            <br>\r\n            <div style=\"height:20px\"></div>\r\n");
#nullable restore
#line 30 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 32 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(30);
            __builder.AddAttribute(31, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                     () => AddItemTypeToList(StoryElement.Types.TEXT)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(33, "Text");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(35);
            __builder.AddAttribute(36, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                     () => AddItemTypeToList(StoryElement.Types.IMAGE)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(38, "Image");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(40);
            __builder.AddAttribute(41, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                     () => AddItemTypeToList(StoryElement.Types.CUSTOM)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(43, "Custom Image");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(45);
            __builder.AddAttribute(46, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                     () => AddItemTypeToList(StoryElement.Types.EFFECT)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(48, "Sound Effect");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(49, "\r\n\r\n<br>\r\n<div style=\"height:20px\"></div>\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(50);
            __builder.AddAttribute(51, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                     SaveStory

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(53, "Save Story");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenButton>(55);
            __builder.AddAttribute(56, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                     LoadStory

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(58, "Load Story");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\r\n\r\n<br id=\"bottom\">");
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
       
    bool requiresScrollToBottom = false;
    string savedString;
    List<StoryElement> items = new List<StoryElement>();

    protected override void OnInitialized()
    {
        DialogService.OnClose += Close;
    }

    void IDisposable.Dispose()
    {
        DialogService.OnClose -= Close;
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (requiresScrollToBottom)
        {
            await JSRuntime.InvokeAsync<bool>("scrollToElementId", "bottom");
            requiresScrollToBottom = false;
        }
    }

    void AddItemTypeToList(StoryElement.Types type)
    {
        requiresScrollToBottom = true;
        items.Add(new StoryElement(type));
    }

    string GetItemPositionText(StoryElement item)
    {
        int position = items.IndexOf(item) + 1;
        return position.ToString() + ".";
    }

    async Task MoveItemIndexBy(StoryElement item, int amount)
    {
        await Task.Delay(0);

        int idx = items.IndexOf(item);
        items.RemoveAt(idx);

        int finalIndex = Math.Clamp(idx - amount, 0, items.Count);
        items.Insert(finalIndex, item);
    }

    async Task DeleteItem(StoryElement item)
    {
        await Task.Delay(0);

        items.Remove(item);
    }

    string SerializeStory()
    {
        System.Text.StringBuilder builder = new System.Text.StringBuilder();

        for (int i = 0; i < items.Count; i++)
        {
            string serializedObject = StoryElement.Serialize(items[i]);
            if (i < items.Count - 1)
                builder.AppendLine(serializedObject);
            else
                builder.Append(serializedObject);
        }

        string output = builder.ToString();

        return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(output));
    }

    void DeserializeTest(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            NotificationService.Notify(new NotificationMessage() { Severity = NotificationSeverity.Error, Summary = "Error", Detail = "Loading story failed", Duration = 4000 });
            return;
        }

        string data = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(value));

        items.Clear();
        string[] dataArray = data.Split("\n");
        items.AddRange(dataArray.Select(o => StoryElement.TryDeserialize(o)));
    }

    async Task SaveStory()
    {
        savedString = SerializeStory();
        if (string.IsNullOrWhiteSpace(savedString))
        {
            NotificationService.Notify(new NotificationMessage() { Severity = NotificationSeverity.Error, Summary = "Error", Detail = "Saving story failed", Duration = 4000 });
            return;
        }

        await DialogService.OpenAsync("Save Story", ds =>
            

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(60);
            __builder2.AddAttribute(61, "Style", "padding: 20px; align-items:center;");
            __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                __builder3.AddMarkupContent(63, "\r\n                ");
                __builder3.AddMarkupContent(64, "<p Style=\"margin-bottom: 10px;\">Click and copy the code</p>\r\n                ");
                __builder3.OpenElement(65, "div");
                __builder3.AddAttribute(66, "class", "row");
                __builder3.AddMarkupContent(67, "\r\n                    ");
                __builder3.OpenElement(68, "div");
                __builder3.AddAttribute(69, "class", "col-md-12");
                __builder3.AddMarkupContent(70, "\r\n                        ");
                __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(71);
                __builder3.AddAttribute(72, "ReadOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 148 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder3.AddAttribute(73, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 148 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                                                              savedString

#line default
#line hidden
#nullable disable
                ));
                __builder3.CloseComponent();
                __builder3.AddMarkupContent(74, "\r\n                        <div style=\"height:10px\"></div>\r\n                        ");
                __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(75);
                __builder3.AddAttribute(76, "Text", "Ok");
                __builder3.AddAttribute(77, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 150 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                                                       () => ds.Close(true)

#line default
#line hidden
#nullable disable
                )));
                __builder3.AddAttribute(78, "Style", "margin-bottom: 10px; width: 150px");
                __builder3.CloseComponent();
                __builder3.AddMarkupContent(79, "\r\n                    ");
                __builder3.CloseElement();
                __builder3.AddMarkupContent(80, "\r\n                ");
                __builder3.CloseElement();
                __builder3.AddMarkupContent(81, "\r\n            ");
            }
            ));
            __builder2.CloseComponent();
        }
#nullable restore
#line 153 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                         );
    }


    string ValueDialog;
    async Task LoadStory() =>
        await DialogService.OpenAsync("Load Story", ds =>
        

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenComponent<Radzen.Blazor.RadzenCard>(82);
            __builder2.AddAttribute(83, "Style", "padding: 20px; align-items:center;");
            __builder2.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                __builder3.AddMarkupContent(85, "\r\n            ");
                __builder3.AddMarkupContent(86, "<p Style=\"margin-bottom: 10px;\">Confirm?</p>\r\n            ");
                __builder3.OpenElement(87, "div");
                __builder3.AddAttribute(88, "class", "row");
                __builder3.AddMarkupContent(89, "\r\n                ");
                __builder3.OpenElement(90, "div");
                __builder3.AddAttribute(91, "class", "col-md-12");
                __builder3.AddMarkupContent(92, "\r\n                    ");
                __builder3.OpenComponent<Radzen.Blazor.RadzenTextBox>(93);
                __builder3.AddAttribute(94, "Placeholder", "Paste story code...");
                __builder3.AddAttribute(95, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 164 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                                                                                  ValueDialog

#line default
#line hidden
#nullable disable
                ));
                __builder3.AddAttribute(96, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ValueDialog = __value, ValueDialog))));
                __builder3.AddAttribute(97, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ValueDialog));
                __builder3.CloseComponent();
                __builder3.AddMarkupContent(98, "\r\n                    <div style=\"height:10px\"></div>\r\n                    ");
                __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(99);
                __builder3.AddAttribute(100, "Text", "Ok");
                __builder3.AddAttribute(101, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 166 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                                                   () => ds.Close(true)

#line default
#line hidden
#nullable disable
                )));
                __builder3.AddAttribute(102, "Style", "margin-bottom: 10px; width: 150px");
                __builder3.CloseComponent();
                __builder3.AddMarkupContent(103, "\r\n                    ");
                __builder3.OpenComponent<Radzen.Blazor.RadzenButton>(104);
                __builder3.AddAttribute(105, "Text", "Cancel");
                __builder3.AddAttribute(106, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 167 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                                                       () => ds.Close(false)

#line default
#line hidden
#nullable disable
                )));
                __builder3.AddAttribute(107, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 167 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                                                                                           ButtonStyle.Secondary

#line default
#line hidden
#nullable disable
                ));
                __builder3.AddAttribute(108, "Style", "margin-bottom: 10px; width: 150px");
                __builder3.CloseComponent();
                __builder3.AddMarkupContent(109, "\r\n                ");
                __builder3.CloseElement();
                __builder3.AddMarkupContent(110, "\r\n            ");
                __builder3.CloseElement();
                __builder3.AddMarkupContent(111, "\r\n        ");
            }
            ));
            __builder2.CloseComponent();
        }
#nullable restore
#line 170 "D:\Developer\Projects\Web\UnmaskedApp\UnmaskedApp\Client\Pages\TellStoryPage.razor"
                     , new DialogOptions() { Height = "200" });


    void Close(dynamic result)
    {
        if (result == true)
        {
            try
            {
                DeserializeTest(ValueDialog);
            }
            catch
            {
                NotificationService.Notify(new NotificationMessage() { Severity = NotificationSeverity.Error, Summary = "Error", Detail = "Invalid story code", Duration = 4000 });
            }

            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
