// creo un array string contenente i miei piatti preferiti

string[] cibiPrefe = new string[] {
    "Carbonara",
    "Sushi",
    "Pizza",
    "Kebab",
    "Torta",
    "Torta salata",
    "Panzerotti",
    "Risotto allo zafferano",
    "Culurgiones",
    "Bimbini",
};

//lunghezza array
Console.WriteLine("lunghezza classifica: " + cibiPrefe.Length);

//Classifica con numerazione
for (int i = 0; i < cibiPrefe.Length; i++)
    Console.WriteLine(i+1 + " " + cibiPrefe[i]);

//Primo item array
var CiboprefeInAssoluto = cibiPrefe.First();
Console.WriteLine("Cibo preferito in assoluto: " + CiboprefeInAssoluto.ToString());

//Ultimo item array
var CiboprefeMaMeno =  cibiPrefe.Last();
Console.WriteLine("Cibo preferito ma meno: " + CiboprefeMaMeno.ToString());