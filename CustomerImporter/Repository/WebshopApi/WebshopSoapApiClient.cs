using System.Net;
using System.Net.Http.Headers;
using System.Xml.Serialization;
using CustomerImporter.Soap.Response;

namespace CustomerImporter;

public class WebshopSoapApiClient(HttpClient httpClient, WebShopApiConfiguration webShopApiConfiguration)
{
    public async Task<SoapEnvelope> GetCustomers()
    {
        var authenticationString = $"{webShopApiConfiguration.ClientId}:{webShopApiConfiguration.ClientSecret}";
        var base64EncodedAuthenticationString =
            Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(authenticationString));
     
        var request = new HttpRequestMessage();
        request.Method = HttpMethod.Post;
        request.RequestUri =
            new Uri($"{webShopApiConfiguration.ApiUrl}/Customers/GetWebshopCustomersUpdate");
        request.Headers.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);

        var response = await httpClient.SendAsync(request);
        if (response.StatusCode != HttpStatusCode.OK)
        {
            throw new WebshopApiException("Webshop API returned an status code=${response.StatusCode}.");
        }
        
        using (var reader = new StringReader(await response.Content.ReadAsStringAsync()))
        {
            var serializer = new XmlSerializer(typeof(SoapEnvelope));
            return (SoapEnvelope) serializer.Deserialize(reader)!;
        }
    }
}