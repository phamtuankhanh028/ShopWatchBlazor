using Microsoft.JSInterop;

namespace ShopWatch.Client.Shared
{
    public partial class MainLayout
    {
        protected override async void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                await js.InvokeVoidAsync("shop");
            }   
        }
    }
}
