using System.Linq;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace WebApplication2
{
    public class RouteConvention<TController> : IApplicationModelConvention where TController : ControllerBase
    {
        public void Apply(ApplicationModel appModel)
        {
            foreach (var controller in appModel.Controllers)
            {
                var isValid = typeof(TController).GetTypeInfo().IsAssignableFrom(controller.ControllerType);
                var matchedSelectors = controller.Selectors.Where(x => x.AttributeRouteModel != null).ToList();
                if (matchedSelectors.Any())
                {
                    foreach (var selectorModel in matchedSelectors)
                    {
                        selectorModel.AttributeRouteModel = isValid ? selectorModel.AttributeRouteModel : null;
                    }
                }
            }
        }
    }
}
