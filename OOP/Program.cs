
//Gerçek kişi

using OOP;

Individual individual = new Individual();
individual.Id = 1;
individual.CustomerNumber = "12345";
individual.Name = "Engin";
individual.Surname = "Demir";
individual.TC = "12345678910";

//Tüzel kişi

Coorporate coorporate = new Coorporate();
coorporate.Id = 2;
coorporate.CustomerNumber = "54321";
coorporate.CompanyName = "Kodlama.io";
coorporate.TaxNumber = "1234567890";


Customer customer1 = new Individual();
Customer customer2 = new Coorporate();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);
customerManager.Add(coorporate);
customerManager.Add(individual);