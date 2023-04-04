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
};

//lunghezza array
var lunghezzaArray = cibiPrefe.Length;
Console.WriteLine("lunghezza classifica: " + lunghezzaArray);

//Classifica con numerazione
for (int i = 0; i < cibiPrefe.Length; i++)
    Console.WriteLine(i+1 + " " + cibiPrefe[i]);

//Primo item array
var CiboprefeInAssoluto = cibiPrefe.First();
Console.WriteLine("Cibo preferito in assoluto: " + CiboprefeInAssoluto.ToString());

//Ultimo item array
var CiboprefeMaMeno =  cibiPrefe.Last();
Console.WriteLine("Cibo preferito ma meno: " + CiboprefeMaMeno.ToString());


//Se l'array è pari allora prendi l'elemento di mezzo
if (lunghezzaArray % 2 == 0)
{
    var mid = lunghezzaArray / 2;
    Console.WriteLine("Cibo preferito di mezzo: " + cibiPrefe[mid]);
}
//Se l'array è dispari allora prendi i due elementi di mezzo e li metti in un array
else
{
    var mid = lunghezzaArray / 2;
    Console.WriteLine("Cibi preferiti di mezzo: " + cibiPrefe[mid - 1] + " e " + cibiPrefe[mid]);
}

