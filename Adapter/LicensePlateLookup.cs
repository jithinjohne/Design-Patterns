using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class LicensePlateLookup : ILicensePlateLookup
    {
        private readonly IExternalDependencyIDontWantToUse externalDependencyIDontWantToUse;

        public LicensePlateLookup(IExternalDependencyIDontWantToUse externalDependencyIDontWantToUse)
        {
            this.externalDependencyIDontWantToUse = externalDependencyIDontWantToUse;
        }

        public LicensePlateLookup() :
            this(new AbcCorpDatabaseLookup())
        { }

        public string NameForLicensePlateNumber(string licensePlateNumber)
        {
            return externalDependencyIDontWantToUse.OwnerNameFromLicensePlateNumber(licensePlateNumber);
        }
    }
}
