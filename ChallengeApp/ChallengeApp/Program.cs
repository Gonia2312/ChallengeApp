using System.ComponentModel.Design;

var name = "Ewa";
var age = 33;
var gender = "kobieta";


if (age == 33)
{
    if (name == "Ewa")
      Console.WriteLine("EWA LAT 33");
}

else if (age < 30)
{ 
if (gender == "kobieta" && age < 30)

    Console.WriteLine("KOBIETA PONIŻEJ 30 LAT");
else if (age < 18)
 if (gender != "kobieta"&& age < 18)
   
    Console.WriteLine("NIEPEŁNOLETNI MĘŻCZYZNA");
}
    

