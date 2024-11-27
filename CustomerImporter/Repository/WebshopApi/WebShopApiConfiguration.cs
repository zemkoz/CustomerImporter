namespace CustomerImporter;

public class WebShopApiConfiguration
{
    public WebShopApiConfiguration()
    {
        ApiUrl = Environment.GetEnvironmentVariable("WEBSHOP_API_URL")
                 ?? throw new InvalidOperationException("The environment variable 'WEBSHOP_API_URL' is not defined.");
        ClientId = Environment.GetEnvironmentVariable("WEBSHOP_API_CLIENT_ID")
                   ?? throw new InvalidOperationException(
                       "The environment variable 'WEBSHOP_API_CLIENT_ID' is not defined.");
        ClientSecret = Environment.GetEnvironmentVariable("WEBSHOP_API_CLIENT_SECRET")
                       ?? throw new InvalidOperationException(
                           "The environment variable 'WEBSHOP_API_CLIENT_SECRET' is not defined.");

    }
    
    public string ApiUrl { get; private set; } 
    public string ClientId { get; private set; }
    public string ClientSecret { get; private set; }
}