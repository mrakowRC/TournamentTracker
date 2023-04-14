﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public PrizeModal CreatePrize(PrizeModal model)
        {
            model.Id = 1;
            return model;
        }
    }
}
