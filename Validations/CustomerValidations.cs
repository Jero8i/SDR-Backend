using BackEnd;

namespace Backend;

public class CustomerValidations
{
    public static bool IsNull(Customer? c)
    {
        return c == null;
    }

    public static bool IsNewCustomer(Customer c)
    {
        return c.Id == null;
    }

    public static bool IsValid(Customer c)
    {
        // Necessary validations?
        return true;
    }

    public static bool IsPresent(List<Customer> customers, int Id)
    {
        Customer? c = customers.Find(x => x.Id == Id);
        return c != null;
    }

    public static Customer GetCustomer(List<Customer> customers, int Id)
    {
        return customers.Find(x => x.Id == Id);
    }
}