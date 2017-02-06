using Nancy;
using Sides.Objects;

namespace Triangle
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];

      Get["/output"] = _ => {
        TriangleVariables userTriangle = new TriangleVariables {
        Side1 = Request.Query["side1"],
        Side2 = Request.Query["side2"],
        Side3 = Request.Query["side3"]
      };
        return View["output.cshtml", userTriangle];
      };
    }
  }
}
