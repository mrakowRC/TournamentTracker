using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static List<string> LoadFile(this string file) 
        {
            if(!File.Exists(file))
            {
                return new List<string>() ;
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModal> ConvertToPrizeModals(this List<string> lines)
        {
        List<PrizeModal> output = new List<PrizeModal>();
            foreach (string line in lines) 
            {
                string[] cols = line.Split(',');
                PrizeModal p = new PrizeModal();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }
            return output;
        }

        public static void SaveToprizeFile(this List<PrizeModal> models, string fileName) 
        {
            List<string> lines = new List<string>();

            foreach (PrizeModal p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
    }
}
