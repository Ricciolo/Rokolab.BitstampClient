namespace Rokolab.BitstampClient.Models
{
    public class BalanceResponse
    {
        public double usd_balance { get; set; }
        public double btc_balance { get; set; }
        public double eur_balance { get; set; }
        public double usd_reserved { get; set; }
        public double btc_reserved { get; set; }
        public double eur_reserved { get; set; }
        public double usd_available { get; set; }
        public double btc_available { get; set; }
        public double eur_available { get; set; }
        public double fee { get; set; }
    }
}