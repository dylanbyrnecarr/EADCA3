#pragma checksum "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aece36c01311f6c3798b5eca845c6e280555f711"
// <auto-generated/>
#pragma warning disable 1591
namespace CA2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\_Imports.razor"
using CA2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\_Imports.razor"
using CA2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
using ValidateSearch;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
 if (found)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h2");
            __builder.AddContent(1, "Showing Results for: ");
            __builder.AddContent(2, 
#nullable restore
#line 10 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                              searchFor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
}
else if (topNews)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<h2>Trending News</h2>");
#nullable restore
#line 15 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<h2>Latest News</h2>");
#nullable restore
#line 19 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
 if (news == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p><em>Loading. Please Wait.</em></p>");
#nullable restore
#line 23 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                                      }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "mb-5 d-flex justify-content-between");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "justify-content-center");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-danger");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                                                 Main

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "All News");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n        ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-danger");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                                                 Top

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Trending");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "justify-content-center");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(22);
            __builder.AddAttribute(23, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 32 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                          currentSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 32 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                                                         SubmitValidate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(26);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n            ");
                __builder2.OpenElement(28, "input");
                __builder2.AddAttribute(29, "type", "search");
                __builder2.AddAttribute(30, "id", "searchFor");
                __builder2.AddAttribute(31, "class", "form-control rounded");
                __builder2.AddAttribute(32, "placeholder", "Enter a search paramter");
                __builder2.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                                                                                         currentSearch.SearchInput

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentSearch.SearchInput = __value, currentSearch.SearchInput));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\n            ");
                __builder2.OpenElement(36, "button");
                __builder2.AddAttribute(37, "class", "btn btn-danger");
                __builder2.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                                                     Search

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(39, "Search");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\n            ");
                __Blazor.CA2.Pages.Index.TypeInference.CreateValidationMessage_0(__builder2, 41, 42, 
#nullable restore
#line 36 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                                      ()=> currentSearch.SearchInput

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "container");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "row");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-sm-12");
#nullable restore
#line 43 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                             foreach (var topic in news.data)
                            {   

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "card mb-1");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "card-body");
            __builder.OpenElement(54, "h5");
            __builder.AddAttribute(55, "class", "card-title");
            __builder.AddContent(56, 
#nullable restore
#line 47 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                                                                topic.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n                                        ");
            __builder.OpenElement(58, "p");
            __builder.AddAttribute(59, "class", "card-subtitle");
            __builder.AddContent(60, 
#nullable restore
#line 48 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                                                                  topic.published_at

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n                                        ");
            __builder.OpenElement(62, "a");
            __builder.AddAttribute(63, "class", "card-link");
            __builder.AddAttribute(64, "href", "https://" + (
#nullable restore
#line 49 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                                                                            topic.source

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "target", "_blank");
            __builder.AddContent(66, "Source: ");
            __builder.AddContent(67, 
#nullable restore
#line 49 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                                                                                                                   topic.source

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\n                                        ");
            __builder.OpenElement(69, "p");
            __builder.AddAttribute(70, "class", "card-text");
            __builder.AddContent(71, 
#nullable restore
#line 50 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                                                              topic.description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\n                                        ");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "class", "btn btn-danger");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                                                                                 (() => Similar(topic.uuid))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(76, "Find Related News");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                               
                             }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\n                        ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "mb-5 d-block mx-auto text-center");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "class", "btn btn-outline-dark");
            __builder.AddAttribute(82, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                                                                           Previous

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(83, "Previous");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\n                            ");
            __builder.OpenElement(85, "button");
            __builder.AddAttribute(86, "class", "btn btn-outline-dark");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                                                                           Next

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(88, "Next");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
                      }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\dylan\Desktop\CA2\CA2\CA2\CA2\Pages\Index.razor"
        private Root news;
    private const string mainUrl = "https://api.thenewsapi.com/v1/news/";
    private const string apiKey = "?api_token=hRZxjKBIxxHBgzOlPsmtDpQIGHEkwGlHfUCN48RT";
    private string errorMessage;
    private int pageNews = 1;
    private bool topNews;
    private bool found;


    private async Task GetNewsAsync()
    {
        try
        {
            news = await Http.GetFromJsonAsync<Root>(mainUrl + "all" + apiKey + "&language=en&page=" + pageNews);
            found = false;
            topNews = false;
            errorMessage = String.Empty;
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }


    private async Task GetSimilarNewsAsync(string uuid)
    {
        try
        {
            news = await Http.GetFromJsonAsync<Root>(mainUrl + "similar/" + uuid + apiKey + "&language=en&page=" + pageNews);
            found = false;
            topNews = false;
            errorMessage = String.Empty;
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

    private async Task GetTopNewsAsync()
    {
        try
        {
            news = await Http.GetFromJsonAsync<Root>(mainUrl + "top" + apiKey + "&language=en&page=" + pageNews);
            found = false;
            topNews = true;
            errorMessage = String.Empty;
        }
        catch (Exception e)
        {
            topNews = false;
            errorMessage = e.Message;
        }
    }

    private async Task GetSearchNewsAsync()
    {
        try
        {
            news = await Http.GetFromJsonAsync<Root>(mainUrl + "all" + apiKey + "&search=" + currentSearch.SearchInput + "&language=en&page=" + pageNews);
            found = true;
            topNews = false;
            errorMessage = String.Empty;
        }
        catch (Exception e)
        {
            found = false;
            errorMessage = e.Message;
        }
    }


    protected override async Task OnInitializedAsync()
    {
        await GetNewsAsync();
    }

    public async void Main()
    {
        await GetNewsAsync();
        StateHasChanged();
    }

    public async void Top()
    {
        await GetTopNewsAsync();
        StateHasChanged();
    }

    public async void Similar(string uuid)
    {
        await GetSimilarNewsAsync(uuid);
        StateHasChanged();
    }


    public async void Search()
    {
        await GetSearchNewsAsync();
        StateHasChanged();
    }


    public void Previous()
    {
        if (found)
        {
            if (pageNews >= 2)
            {
                pageNews--;
            }
            else
            {
                pageNews = 1;
            }
            currentSearch = searchFor;
            Search();
            StateHasChanged();
        }
        else if (topNews)
        {
            if (pageNews >= 2)
            {
                pageNews--;
            }
            else
            {
                pageNews = 1;
            }
            Top();
            StateHasChanged();
        }
        else
        {
            if (pageNews >= 2)
            {
                pageNews--;
            }
            else
            {
                pageNews = 1;
            }
            Main();
            StateHasChanged();
        }
    }

    public void Next()
    {
        if (found)
        {
            pageNews++;
            currentSearch = searchFor;
            Search();
            StateHasChanged();
        }
        else if (topNews)
        {
            pageNews++;
            Top();
            StateHasChanged();
        }
        else
        {
            pageNews++;
            Main();
            StateHasChanged();
        }
    }


    private ValidSearch currentSearch = new ValidSearch();
    private ValidSearch searchFor = null;

    private void SubmitValidate()
    {
        searchFor = currentSearch;
        currentSearch = new ValidSearch();
    }


    public class Meta
    {
        public int found { get; set; }
        public int returned { get; set; }
        public int limit { get; set; }
        public int page { get; set; }
    }

    public class Datum
    {
        public string uuid { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string keywords { get; set; }
        public string snippet { get; set; }
        public string url { get; set; }
        public string image_url { get; set; }
        public string language { get; set; }
        public DateTime published_at { get; set; }
        public string source { get; set; }
        public List<string> categories { get; set; }
        public object relevance_score { get; set; }
    }

    public class Root
    {
        public Meta meta { get; set; }
        public List<Datum> data { get; set; }
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.CA2.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591