// "Kobieta poniżej 30 lat"
// "Ewa lat 33"
// "Niepełnoletni mężczyzna"

String Name = "Ewa";
int Age =33;
string Gender = "Kobieta";

if (Name == "Ewa" && Age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if (Gender == "Mężczyzna" && Age < 18)
{
    Console.WriteLine("Niepłnoletni Męższczyzna");
}
if (Age <30 && Gender == "Kobieta")
{
    Console.WriteLine("Kobieta poniżej 30");
}
