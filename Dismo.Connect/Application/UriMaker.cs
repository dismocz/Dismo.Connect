using Microsoft.AspNetCore.Components;

namespace Dismo.Connect.Application
{
    public class UriMaker
    {
        private readonly NavigationManager _navigationManager;

        public UriMaker(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public string Route(string relative)
        {
            return $"{_navigationManager.BaseUri}{relative}";
        }
    }
}
