// See https://aka.ms/new-console-template for more information
//Scrivete nel vostro programma principale Program.cs le seguenti funzioni di base:
/*void StampaArrayInteri(int[] array): che preso un array di numeri interi, 
 * stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]”. 
 * Potete prendere quella fatta in classe questa mattina
int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)
int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
Una volta completate queste funzioni di utilità di base, e dato il seguente array di numeri [2, 6, 7, 5, 3, 9]
già dichiarato nel vostro codice, si vogliono utilizzare le funzioni per:
Stampare l’array di numeri fornito a video
Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
Stampare la somma di tutti i numeri
Stampare la somma di tutti i numeri elevati al quadrati */



int[] arrayNumeri = { 2, 6, 7, 5, 3, 9 };
StampaArrayInteri(arrayNumeri);


int[] arrayDiNumeriAlQuadrato = QuadratoArrayNumeri(arrayNumeri);

Console.WriteLine("Array di numeri al quadrato: ");
StampaArrayInteri(arrayDiNumeriAlQuadrato);


Console.WriteLine("Array di numeri originale: ");
StampaArrayInteri(arrayNumeri);

//somma 

Console.WriteLine(SommaArrayNumeri(arrayNumeri));




Console.WriteLine(SommaArrayNumeri(arrayDiNumeriAlQuadrato));








Console.WriteLine(SommaArrayNumeri(arrayNumeri));



//-------------------------------Funzioni------------------------------

//Funzione stampa array 
void StampaArrayInteri(int[] arrayInteri)
{
    Console.Write("[");

    for (int i = 0; i < arrayInteri.Length; i++)
    {
        if (i == arrayInteri.Length - 1)
            Console.Write(arrayInteri[i]);
        else { Console.Write(arrayInteri[i] + ", "); }
    }



    Console.WriteLine("]");
}

// Funzione stampa il quadrato 
int[] QuadratoArrayNumeri(int[] arrayNumeri)
{
    
    int[] copiaArray = (int[])arrayNumeri.Clone();
    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = copiaArray[i] * 2;
       
    }
    return copiaArray;

}

//Funzione Stampa somma array 

int  SommaArrayNumeri(int[] arrayNumeri)
{
    int somma = 0;

    for (int i = 0; i <= arrayNumeri.Length - 1; i = i + 1)
    {
        somma += arrayNumeri[i];

    }
    return somma; 
}

//Funzione stampa somma copia array 
int[] StampaSommaArrayNumeriQuadrato(int[] arrayNumeri)
{
    int somma = 0;
    int[] copiaArraySomma = (int[])arrayNumeri.Clone();
    for (int i = 0; i <= copiaArraySomma.Length - 1; i = i + 1)
    {
        somma = somma + (copiaArraySomma[i] *2) ;
       
    }
    Console.WriteLine("La somma vale: " + somma);
    return copiaArraySomma;
  
}




//Funzione che da il quadrato di un numero passato come parametro.
/*
double QuadratoDiUnNumero(double numero)
{
   
    return Math.Pow( numero, 2);

}  */

//Funzione somma array 

/* int sum = 0;
foreach (int item in arrayNumeri)
{
    sum += item;
}

Console.WriteLine(sum); */



