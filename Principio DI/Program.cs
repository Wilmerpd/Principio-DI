//El programa principal demostrará cómo funciona la inyección de dependencias con las clases definidas.
// Crear la instancia del repositorio de clientes concreto
using Principio_DI;

ICustomerRepository customerRepository = new CustomerRepository();

// Inyectar el repositorio en el servicio
CustomerService customerService = new CustomerService(customerRepository);

// Agregar o actualizar clientes
customerService.AddOrUpdateCustomer(1, "Wilmer Diaz", "Wilmer.do@example.com");
customerService.AddOrUpdateCustomer(2, "Jane Smith", "jane.smith@example.com");

// Mostrar información de clientes
customerService.DisplayCustomer(1);
customerService.DisplayCustomer(2);

// Actualizar cliente existente
customerService.AddOrUpdateCustomer(1, "Wilmer Diaz Updated", "Wilmer.do.updated@example.com");

// Mostrar información actualizada de clientes
customerService.DisplayCustomer(1);