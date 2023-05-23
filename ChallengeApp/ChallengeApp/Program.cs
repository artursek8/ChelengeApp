// Kobietra poniżej 30 lat
// Ewa, lat 33
//Niepełnoletni mężczyzna 

string Name = "Ewa";
int Age = 33;
string Gender = "Kobieta";

if ( Name == "Ewa" && Age == 33)
{ 
    Console.WriteLine( "Ewa, lat 33" );
}
if ( Gender == "Kobieta" && Age > 30 )
{
    Console.WriteLine( "Kobieta poniżej 30 lat" );
}
if (!(Gender == "Kobieta" && Age < 18))
{
    Console.WriteLine("Niepełnoletni Meżczyzna");
}
if (!(Gender == "Kobieta" && Name == "Ewa" && Age >33 ))
{
    Console.WriteLine ( "100 letni Marek" );
}
