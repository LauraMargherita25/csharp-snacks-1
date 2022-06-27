// See https://aka.ms/new-console-template for more information

// Snack 5) chiedi all'uente di inserire un numero se è pari stampa se è dispari stampa il numero successivo

Console.WriteLine("scrivi un numero");
int numeroUtente = int.Parse(Console.ReadLine());
if (numeroUtente % 2 == 0)
{
    Console.WriteLine(numeroUtente);
}
else
{
    Console.WriteLine("scrivi un numero");
};

// Snack 4) calcola somma e media.
//int sum = 0;
//double avg;
//for (int i = 1; i <= 10; i++)
//{

//    int numeroUtente = int.Parse(Console.ReadLine());
//    sum += numeroUtente;
//}
//avg = sum / 10.0;
//Console.Write("La somma : {0}/n la media: {1}", sum,avg);


// Snack 3) Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.

//int sum = 0;

//for (int i = 1; i <= 10; i++)
//{

//    int numeroUtente = int.Parse(Console.ReadLine());
//    sum += numeroUtente;
//}
//Console.Write("La somma : {0} " + sum);