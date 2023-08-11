using Game.Lib.Infrastructure.Steam.CustomTypes;
using Game.Lib.Infrastructure.Steam.Enumerations;
using Game.Lib.Infrastructure.Steam.Services.Abstraction;
using System.Globalization;

namespace Game.Lib.Infrastructure.Steam.Services.Implementation
{
    public class CultureService : ICultureService
    {
        Dictionary<Culture, CultureValue> CultureList = new Dictionary<Culture, CultureValue>();

        public CultureService()
        {
            //Dil listesine elemanlar ekleniyor.
            //Yeni dil olursa buraya ekleme yap.
            CultureList.Add(Culture.TR_tr, new CultureValue { CultureName = "turkish", CultureShortName = "tr", CultureInfo = new CultureInfo("TR-tr") });
            CultureList.Add(Culture.EN_us, new CultureValue { CultureName = "english", CultureShortName = "us", CultureInfo = new CultureInfo("EN-us") });
        }

        public CultureValue GetCultureValue(Culture culture)
        {
            return CultureList[culture];
        }
    }
}
