using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_App.Pages
{
    public class IndexModel : PageModel
    {
        /*added the IConfiguration here so we can access the user secrets*/
        private readonly IConfiguration _configuration;

        public string ConnectionString { get; private set; }

        public IndexModel(IConfiguration configuration)
        {
            /*initialize here when this instance started*/
            _configuration = configuration;
        }

        public void OnGet()
        {
            /*set here the ConnectionString value*/
            ConnectionString = this._configuration["connectionstrings"];
        }
    }
}