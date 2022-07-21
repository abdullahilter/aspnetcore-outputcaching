namespace dotnet7_outputcache;

public interface ICustomerService
{
    Task<Customer> CreateAsync(CustomerDto customerDto);

    Task<Customer> GetAsync(Guid id);

    Task<List<Customer>> GetAllAsync(string name);

    Task<Customer> UpdateAsync(Guid id, CustomerDto customerDto);

    Task DeleteAsync(Guid id);
}