// See https://aka.ms/new-console-template for more information

// Snack 3) Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.

int sum = 0;

for (int i = 1; i <= 10; i++)
{

    int numeroUtente = int.Parse(Console.ReadLine());
    sum += numeroUtente;
}
Console.Write("La somma : {0} " + sum);