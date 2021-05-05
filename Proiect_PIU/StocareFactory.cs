
using System.Configuration;

namespace Proiect_PIU
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisier";
        public static IstocareData GetAdministratorStocare()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrareBuget_FisierBinar(numeFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrareBuget_FisierText(numeFisier + "." + formatSalvare);
                }
            }

            return null;
        }
    }
}
