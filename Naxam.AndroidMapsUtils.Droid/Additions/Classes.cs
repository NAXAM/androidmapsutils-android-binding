using Droid = Android;

namespace Com.Google.Maps.Android.Kml
{
    partial class KmlMultiGeometry
    {
        public Java.Lang.Object GeometryObject
        {
            get
            {
                return new Droid.Runtime.JavaList<Com.Google.Maps.Android.Kml.IKmlGeometry>(KmlGeometryObject);
            }
        }
	}
	partial class KmlLineString
	{
		public Java.Lang.Object GeometryObject
		{
			get
			{
                return new Droid.Runtime.JavaList<Droid.Gms.Maps.Model.LatLng>(KmlGeometryObject);
			}
		}
	}
	partial class KmlPoint
	{
		public Java.Lang.Object GeometryObject
		{
			get
			{
				return KmlGeometryObject;
			}
		}
	}
	partial class KmlPolygon
	{
		public Java.Lang.Object GeometryObject
		{
			get
			{
                return new Droid.Runtime.JavaList<System.Collections.Generic.IList<Droid.Gms.Maps.Model.LatLng>>(KmlGeometryObject);
			}
		}
	}
}
