using CustomerImporter;
using CustomerImporter.Repository;

var httpClient = new HttpClient();
var webShopApiConfiguration = new WebShopApiConfiguration();
var webshopSoapApiClient = new WebshopSoapApiClient(httpClient,webShopApiConfiguration);
var customerRepository = new CustomerRepository(webshopSoapApiClient);

var customersList = await customerRepository.GetCustomers();
customersList.ForEach(Console.WriteLine);
