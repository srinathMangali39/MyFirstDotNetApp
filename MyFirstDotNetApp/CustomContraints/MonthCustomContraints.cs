using System.Text.RegularExpressions;

namespace MyFirstDotNetApp.CustomContraints;

// sales-report/2040/apr 
public class MonthCustomContraints : IRouteConstraint
{
    public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
    {
        if (!values.ContainsKey(routeKey))
        {
            return false;
        }
        Regex regex = new Regex($"^(apr|jun|oct|jan)$");
        string? monthValue = Convert.ToString(values[routeKey]);
        if (regex.IsMatch(monthValue))
        {
            return true;
        }
        return false;
    }
}

