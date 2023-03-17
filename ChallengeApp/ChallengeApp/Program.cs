using System.ComponentModel.Design;

var name = "Ewa";
var age = 33;
var gender = "kobieta";


if (age == 33 && name == "Ewa")
{

    Console.WriteLine("EWA LAT 33");
}

else if (age < 30 && gender == "kobieta")
{
    Console.WriteLine("KOBIETA PONIŻEJ 30 LAT");

}

else if (gender != "kobieta" && age < 18)

{
    Console.WriteLine("NIEPEŁNOLETNI MĘŻCZYZNA");
}


