
/*
BONUS
Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana. 
Potrebbe essere interessante creare una funzione chiamata indiciMedianaArray(int lunghezzaArray)
che vi restituisce l'indice della posizione mediana (che restituisca gli indici delle eventuali posizioni mediani)
e poi fare una funzione (StampaArrayMediana) che si occupa di fare tutto il lavoro con  la funzione precedente
e richiedendo direttamente l'intero array. Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. 
In questo caso vanno stampati i 2 elementi in centro alla vostra classifica. 
 */

//----------------- PROGRAMMA PRINCIPALE ----------------------

string[] ArrayFromUser = CreateArrayFromInput();

DisplayArrayLength(ArrayFromUser);

DisplayArrayElementsByIndex(ArrayFromUser);

DisplayArrayFirstPosition(ArrayFromUser);

DisplayArrayLastPosition(ArrayFromUser);

DisplayArrayMiddlePosition(ArrayFromUser);

//---------------------- FUNZIONI -----------------------------

//FUNZIONE PER CREARE ARRAY DA INPUT
string[] CreateArrayFromInput()
{
    Console.Write("How long should the list be? ");
    int ArrayLengthFromInput = int.Parse(Console.ReadLine());

    string[] array = new string[ArrayLengthFromInput];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Please insert position #{i + 1}  ");
        array[i] = Console.ReadLine();
    }
    return array;
}

//FUNZIONE PER CALCOLARE E STAMPARE LA LUNGHEZZA DELL'ARRAY
void DisplayArrayLength(string[] array)
{
    int ArrayLength = array.Length;
    Console.WriteLine($"There are {ArrayLength} elements in the list");
}

//FUNZIONE PER STAMAPARE GLI ELEMENTI DELL'ARRAY IN ORDINE DI INDICE CRESCENTE
void DisplayArrayElementsByIndex(string[] array)
{
    Console.WriteLine("This is your list:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{i + 1}) {array[i]}");
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

//FUNZIONE PER STAMPARE LE POSIZIONI MEDIANE DI UN ARRAY
void DisplayArrayMiddlePosition(string[] array)
{
    int ArrayLength = array.Length;
    int ArrayMiddlePosition = ArrayLength / 2;
    int ArrayMiddlePositionPari = ArrayMiddlePosition - 1;
    if (array.Length % 2 != 0)
    {
        //MIDDLE POSITION OF AN ARRAY IF DISPARI
        Console.WriteLine($"The middle position of the array is:");
        Console.WriteLine($"{ArrayMiddlePosition + 1}) {array[ArrayMiddlePosition]}");
    }
    else
    {
        //MIDDLE POSTIONS OF AN ARRAY IF PARI
        Console.WriteLine($"The middle positions of the array are:");
        Console.WriteLine($"{ArrayMiddlePositionPari + 1}) {array[ArrayMiddlePositionPari]}");
        Console.WriteLine($"{ArrayMiddlePosition + 1}) {array[ArrayMiddlePosition]}");
        ;
    }
}