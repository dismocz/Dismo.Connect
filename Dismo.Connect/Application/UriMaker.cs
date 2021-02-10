using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Dismo.Connect.Application
{
    public class UriMaker
    {
        private readonly IJSRuntime _jsRuntime;
        private string _base;

        public UriMaker(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task InitializeAsync()
        {
            _base = await _jsRuntime.InvokeAsync<string>("getBaseUri");
        }

        public string Route(string relative)
        {
            return $"{_base}{relative}";
        }
    }
}
