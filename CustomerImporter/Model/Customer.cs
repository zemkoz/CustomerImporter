namespace CustomerImporter.Model;

public record Customer(
    string FirstName,
    string MiddleInitial,
    string LastName,
    string EMail,
    string SapId,
    Customer.CustomerStatus Status = Customer.CustomerStatus.NORMAL) 
{
    public enum CustomerStatus
    {
        NORMAL,
        REMOVED
    }
}
