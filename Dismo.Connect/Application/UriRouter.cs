using Microsoft.AspNetCore.Components;

namespace Dismo.Connect.Application
{
    public class UriRouter
    {
        private readonly NavigationManager _navigationManager;

        public UriRouter(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public string Route(string relative)
        {
            return $"{_navigationManager.BaseUri}{relative}";
        }
    }
}
