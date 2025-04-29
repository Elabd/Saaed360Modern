using Saaed360Modern.Contracts.Wcf;

using System.Xml.Linq;


namespace Api.HelperClasses
{
    public static class TemplateHelper
    {

        static TemplateHelper()
        {
            ;
        }
        public static List<string> XmltoList(string xml)
        {
            XDocument xDocument = XDocument.Parse(xml.ToLower());
            List<string> result = new List<string>();


            var items = (from r in xDocument.Root.Elements("damagedpartsdetaildto")
                         select new damagedparts()
                         {
                             PartName = (string)r.Element("partname"),
                             IsSelected = (bool)r.Element("isselected")
                         }).ToList();
            foreach (var item in items)
            {
                if (item.IsSelected)
                    result.Add(item.PartName);
            }

            return result;
        }
        public static List<string> GetVehicleDamagedParts(VehicleDriverModelDTO vehicle)
        {
            List<string> Result = new List<string>();
            List<string> Parts = XmltoList(vehicle.DamagedPartData.DamagedVehicleDetails);
            if (vehicle.VehicleDamagedParts == null || !vehicle.VehicleDamagedParts.Any()) return Parts;
            foreach (var part in Parts)
            {
                var damage = vehicle.VehicleDamagedParts.Where(e => e.DamagedPartName == part).FirstOrDefault();
                if (damage != null) Result.Add(string.Format("{0} ({1})", part, damage.DamagedPartSeverityName));
                else Result.Add(part);
            }
            return Result;
        }
    }

    public class damagedparts
    {
        public string PartName { set; get; }
        public bool IsSelected { set; get; }
    }
}
