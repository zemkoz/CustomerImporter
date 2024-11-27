using CustomerImporter.Repository.Mapper;
using Customer = CustomerImporter.Model.Customer;

namespace CustomerImporter.Repository;

public class CustomerRepository(WebshopSoapApiClient webshopSoapApiClient)
{
    public async Task<List<Customer>> GetCustomers()
    {
        var response = await webshopSoapApiClient.GetCustomers();
        return response.Body.Response.CRMCustomerData.Customers
            .Select(CustomerMapper.ToCustomer)
            .ToList();
    }
}