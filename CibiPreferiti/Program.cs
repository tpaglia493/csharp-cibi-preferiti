
/*Nome repo: csharp-cibi-preferiti
Cercate per ogni richiesta che viene fatta di preparare le rispettive funzioni  e di usarle nel vostro programma principale!
Le modalità di consegna sono le solite: repo GitHub, commit e push
BONUS
Chiedere all'utente quanti cibi preferiti ha, e farglieli inserite da input della Console nell'array.
Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana. 
Potrebbe essere interessante creare una funzione chiamata indiciMedianaArray(int lunghezzaArray)
che vi restituisce l'indice della posizione mediana (che restituisca gli indici delle eventuali posizioni mediani)
e poi fare una funzione (StampaArrayMediana) che si occupa di fare tutto il lavoro con  la funzione precedente
e richiedendo direttamente l'intero array. Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. 
In questo caso vanno stampati i 2 elementi in centro alla vostra classifica. 
 */

//----------------- PROGRAMMA PRINCIPALE ----------------------

string[] FavouriteFoods = { "Crépes", "Carbonara", "Risotto alla crema di scampi", "Fettuccine al tartufo", "Pizza", "Hamburger" };

DisplayArrayLength(FavouriteFoods);

Console.WriteLine("La classifica è la seguente:");

DisplayArrayElementsByIndex(FavouriteFoods);

DisplayArrayFirstPosition(FavouriteFoods);

DisplayArrayLastPosition(FavouriteFoods);


//---------------------- FUNZIONI -----------------------------

//FUNZIONE PER CALCOLARE E STAMPARE LA LUNGHEZZA DELL'ARRAY

void DisplayArrayLength(string[] array)
{ int ArrayLength = array.Length;
    Console.WriteLine($"There are {ArrayLength} elements in the list");
}

//FUNZIONE PER STAMAPARE GLI ELEMENTI DELL'ARRAY IN ORDINE DI INDICE CRESCENTE
void DisplayArrayElementsByIndex(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i+1}) {array[i]}");
    }
}

//FUNZIONE PER STAMPARE LA PRIMA POSIZIONE DELL'ARRAY
void DisplayArrayFirstPosition(string[] array)
{
    Console.WriteLine($"The first position in the array is: {array[0]}");
}

//FUNZIONE PER STAMPARE L'ULTIMA POSIZIONE DELL'ARRAY
void DisplayArrayLastPosition(string[] array)
{
    int ArrayLastPosition = array.Length - 1;
    Console.WriteLine($"The last position in the array is: {array[ArrayLastPosition]}");
}