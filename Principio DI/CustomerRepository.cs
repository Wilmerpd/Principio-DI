
//Definimos la interfaz ICustomerRepository con métodos para obtener y guardar clientes.
namespace Principio_DI
{
    public interface ICustomerRepository
    {
        Customer GetCustomerById(int id);
        void SaveCustomer(Customer customer);
        // Otros métodos de acceso a datos...
    }
    //Implementamos la clase CustomerRepository con métodos para obtener y guardar clientes.
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Dictionary<int, Customer> _customersDatabase = new Dictionary<int, Customer>();

        public Customer GetCustomerById(int id)
        {
            // Simulación de obtención de datos de una base de datos
            if (_customersDatabase.ContainsKey(id))
            {
                return _customersDatabase[id];
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.");
                return null;
            }
        }
        public void SaveCustomer(Customer customer)
        {
            // Simulación de guardar datos en una base de datos
            if (_customersDatabase.ContainsKey(customer.Id))
            {
                _customersDatabase[customer.Id] = customer;
                Console.WriteLine($"Cliente actualizado: {customer.Name}");
            }
            else
            {
                _customersDatabase.Add(customer.Id, customer);
                Console.WriteLine($"Cliente agregado: {customer.Name}");
            }
        }
    }
}

