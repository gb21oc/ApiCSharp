namespace Api.Domain.Security
{
    public class TokenConfigurations
    {
        public string Audicence { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }
}