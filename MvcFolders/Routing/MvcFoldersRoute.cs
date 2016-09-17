using System;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MvcFolders.Routing
{
    public class MvcFoldersRoute : RouteBase
    {
        public const string RouteDataParametersKey = "_mvcFoldersRouteDataParameters";

        private FeatureFolders _mvcFeatureFolders;

        public MvcFoldersRoute(FeatureFolders featureFolders)
        {
            _mvcFeatureFolders = featureFolders;
        }

        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            var request = httpContext.Request;
            var path = (request.AppRelativeCurrentExecutionFilePath + request.PathInfo).Substring(2); // remove ~/
            var pathParts = path.Split('/').Where(s => !string.IsNullOrEmpty(s)).ToArray();
            var actionData = _mvcFeatureFolders.FindActionData(pathParts, 0);

            if (actionData == null)
                return null;

            var routeData = actionData.CreateRouteData(this);
            var urlParameters = pathParts.Skip(actionData.Depth).ToArray();
            routeData.DataTokens.Add(RouteDataParametersKey, urlParameters);
            return routeData;
        }

        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            // TODO implement this so we can use existing routing styles
            throw new NotImplementedException();
        }
    }
}