//La clase CustomerService dependerá de la interfaz ICustomerRepository en lugar de una implementación concreta.
//Utilizamos Inyección de Dependencias por Constructor.

namespace Principio_DI
{
    public class CustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        // Inyección de dependencia a través del constructor
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void AddOrUpdateCustomer(int id, string name, string email)
        {
            Customer customer = _customerRepository.GetCustomerById(id);

            if (customer != null)
            {
                // Actualizar el cliente
                customer.Name = name;
                customer.Email = email;
                _customerRepository.SaveCustomer(customer);
            }
            else
            {
                // Agregar un nuevo cliente
                customer = new Customer { Id = id, Name = name, Email = email };
                _customerRepository.SaveCustomer(customer);
            }
        }

        public void DisplayCustomer(int id)
        {
            Customer customer = _customerRepository.GetCustomerById(id);
            if (customer != null)
            {
                Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}, Email: {customer.Email}");
            }
        }
    }
}
