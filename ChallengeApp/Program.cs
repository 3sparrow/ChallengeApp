string name = "Ewa";
var sex = "men" ;
int age = 33;

if
    (sex == "women" && age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
else if 
    (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
else if (sex == "men" && age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
else if (age > 65)
    {
        Console.WriteLine("Człowiek na emeryturze");
    }
