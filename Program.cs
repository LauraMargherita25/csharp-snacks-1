// See https://aka.ms/new-console-template for more information



// Snack11)
// Dare la possibilità di inserire due parole.
// Verificare tramite una funzione che le due parole abbiano la stessa lunghezza.
// Se hanno la stessa lunghezza, stamparle entrambe,altrimenti stampare la più lunga delle due

string userWord1;
string userWord2;

Console.Write("Write first word:");
userWord1 = Console.ReadLine();

Console.Write("Write second word:");
userWord2 = Console.ReadLine();

void SameLangth (string ward1, string ward2)
{
    if (ward1.Length == ward2.Length)
    {
        Console.WriteLine("{0} = {1}", ward1,ward2);
    }
    else
    {
        if (ward1.Length > ward2.Length)
        {
            Console.WriteLine (ward1);
        } else
        {
            Console.WriteLine (ward2);
        }
    }
}

SameLangth(userWord1, userWord2);


// Snack 10)
//Fai inserire un numero all'utente che chiameremo N
//Genera N array ognuno formato da 10 num rnd da 1 a 100
//Ogni volta che ne crei uno stampalo a schermo
//int N = int.Parse(Console.ReadLine());
//int[] array;

//for (int nArray = 0; nArray < N; nArray++)
//{
//    array = new int[10];
//    for (int i = 0; i < array.Length; i++)
//    {
//        array[i] = new Random().Next(1, 101);
//        Console.Write("{0}", array[i] );
//    }

//}


// Snack 5) chiedi all'uente di inserire un numero se è pari stampa se è dispari stampa il numero successivo
//Console.WriteLine("scrivi un numero");
//int numeroUtente = int.Parse(Console.ReadLine());
//if (numeroUtente % 2 == 0)
//{
//    Console.WriteLine(numeroUtente);
//}
//else
//{
//    Console.WriteLine(numeroUtente+1);
//};


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