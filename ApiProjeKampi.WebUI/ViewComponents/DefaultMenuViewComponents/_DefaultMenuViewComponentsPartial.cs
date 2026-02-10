using Microsoft.AspNetCore.Mvc;

namespace ApiProjeKampi.WebUI.ViewComponents.DeafultMenuViewComponents
{
    public class _DefaultMenuViewComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {  
            return View(); 
        }
    }
}
