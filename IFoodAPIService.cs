using IfoodMercado.Models;

namespace IfoodMercado
{
    public static class IFoodAPIService
    {
        public static Config Config { get; private set; }

        public static void Init(Config config)
        {
            Config = config;
        }
    }
}