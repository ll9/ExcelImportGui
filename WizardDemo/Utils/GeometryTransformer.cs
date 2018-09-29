using DotSpatial.Projections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WizardDemo.Utils
{
    public static class GeometryTransformer
    {
        public static string GetGeomFromTextString(double x, double y, string projection)
        {
            var fromProjection = ProjectionInfo.FromProj4String(projection);
            var toProjection = ProjectionInfo.FromProj4String("+proj=longlat +ellps=WGS84 +datum=WGS84 +no_defs ");

            var xy = new[] { x, y };
            var z = new[] { 0.0 };

            Reproject.ReprojectPoints(xy, z, fromProjection, toProjection, 0, 1);


            return $"GeomFromText('POINT({xy[0]} {xy[1]})', 4326)";
        }
    }
}
