using UserRegistration.Data.Scaffolded;
using UserRegistrationApp;

using UserRegistrationContext context = new UserRegistrationContext();

People people = new People()
{
    Name = "Nittish",
    Email="nittishindia@gmail.com"
};
context.Add(people);
context.SaveChanges();