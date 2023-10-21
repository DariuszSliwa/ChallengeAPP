var name = "Ewa";
var gender = "woman";
var age = 33;

if (gender == "woman" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}

else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}

else if (gender == "man" && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}

else
{
    Console.WriteLine("Nieprawidłowe dane");
}