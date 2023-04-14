
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