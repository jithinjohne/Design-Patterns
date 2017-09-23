using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class AbcCorpDatabaseLookup : IExternalDependencyIDontWantToUse
    {
        public string OwnerNameFromLicensePlateNumber(string licensePlateNumber)
        {
            return $"Owner of {licensePlateNumber}";
        }
    }
}
