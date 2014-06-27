namespace XeroApi.Model
{
    public class Setup : EndpointModelBase
    {
        public Account[] Accounts { get; set; }
        public ConversionDate ConversionDate { get; set; }
        public ConversionBalance[] ConversionBalances { get; set; }
    }

    public class Setups : ModelList<Setup>
    {
    }
}