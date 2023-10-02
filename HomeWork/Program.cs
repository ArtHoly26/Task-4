using HomeWork;
Person tom = new Person("Tom", 25);
Person bob = new Person("Bob", 16);
bool tomIsValid = ValidateUser(tom);    
bool bobIsValid = ValidateUser(bob);    

Console.WriteLine($"Проверка Тома: {tomIsValid}");
Console.WriteLine($"Проверка Боба: {bobIsValid}");

bool ValidateUser(Person person)
{
Type type = typeof(Person);
object[] attributes = type.GetCustomAttributes(false);

foreach (Attribute attr in attributes)
{

if (attr is AgeValidationAttribute ageAttribute)

return person.Age >= ageAttribute.Age;
}
return true;
}


