using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModal
    {
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }

        public PrizeModal()
        {

        }

        public PrizeModal(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);

            PlaceName = placeName;
            PlaceNumber = placeNumberValue;
            PrizeAmount = prizeAmountValue;
            PrizePercentage = prizePercentageValue;
        }
    }
}
