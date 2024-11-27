using CustomerImporter.Model;

namespace CustomerImporter.Repository.Mapper;

public static class CustomerMapper
{
    public static Customer ToCustomer(Soap.Response.CRMCustomer crmCustomer)
    {
        var customerStatus = crmCustomer.Status switch
        {
            "N" => Customer.CustomerStatus.NORMAL,
            "R" => Customer.CustomerStatus.REMOVED,
            _ => throw new ArgumentException($"Customer has unexpected status value: {crmCustomer.Status}"),
        };
        
        return new Customer(
                crmCustomer.FirstName,
                crmCustomer.MiddleInitial,
                crmCustomer.LastName,
                crmCustomer.EMail,
                crmCustomer.SapId,
                customerStatus
        );
    }
}