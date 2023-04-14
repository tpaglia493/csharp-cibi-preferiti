
/*Nome repo: csharp-cibi-preferiti

La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
Il vostro cibo top (prima posizione della classifica)
Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
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


//---------------------- FUNZIONI -----------------------------

//FUNZIONE PER CALCOLARE E STAMPARE LA LUNGHEZZA DELL'ARRAY

void DisplayArrayLength(string[] array)
{ int ArrayLength = array.Length;
    Console.WriteLine($"Nella lista ci sono {ArrayLength} elementi");
}

//FUNZIONE PER STAMAPARE GLI ELEMENTI DELL'ARRAY IN ORDINE DI INDICE CRESCENTE
void DisplayArrayElementsByIndex(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Al {i+1}° posto: {array[i]}");
    }
}
