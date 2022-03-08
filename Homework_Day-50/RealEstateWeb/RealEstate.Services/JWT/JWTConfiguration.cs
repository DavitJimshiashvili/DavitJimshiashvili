namespace RealEstateW.Services.JWT
{
    public class JWTConfiguration
    {
        public string Secret { get; set; }
        public int ExpirationTime { get; set; }
    }
}
