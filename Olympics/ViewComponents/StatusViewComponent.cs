using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Olympics.ViewComponents
{
    public class StatusViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string status)
        {
            return View("Default", status);
        }
    }
}