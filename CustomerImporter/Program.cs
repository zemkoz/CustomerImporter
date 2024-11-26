// See https://aka.ms/new-console-template for more information

using CustomerImporter.Model;

var customer = new Customer("John","", "Doe", 
    "john.doe@datagroup.de", "123456", Customer.CustomerStatus.NORMAL);

Console.WriteLine(customer);