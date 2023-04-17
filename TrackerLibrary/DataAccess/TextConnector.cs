using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModals.csv";
        public PrizeModal CreatePrize(PrizeModal model)
        {
            List<PrizeModal> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModals();
            int currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            model.Id = currentId;
            prizes.Add(model);
            //convert the prizes to list<string>
            //save the list<string> to text file
            prizes.SaveToprizeFile(PrizesFile);

      
        }
    }
}
