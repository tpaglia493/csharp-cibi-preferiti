
//----------------- PROGRAMMA PRINCIPALE ----------------------

using System;

string[] ArrayFromUser = CreateArrayFromInput();

DisplayArrayLength(ArrayFromUser);

DisplayArrayElementsByIndex(ArrayFromUser);

DisplayArrayFirstPosition(ArrayFromUser);

DisplayArrayLastPosition(ArrayFromUser);

DisplayArrayMiddlePositions(ArrayFromUser);

//---------------------- FUNZIONI -----------------------------

//FUNZIONE PER CREARE ARRAY DA INPUT
string[] CreateArrayFromInput()
{
    int ArrayLengthFromInput;
    string[] array;

    Console.Write("How long should the list be? ");
 
        try
        {
            ArrayLengthFromInput = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine("Please insert a number ");
            Console.Write("How long should the list be? ");
            ArrayLengthFromInput = int.Parse(Console.ReadLine());
        }
        
    

    array = new string[ArrayLengthFromInput];

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
void DisplayArrayMiddlePositions(string[] array)
{
    int ArrayLength = array.Length;
    int ArrayMiddlePosition = ArrayLength / 2;
    int ArrayMiddlePositionEven = ArrayMiddlePosition - 1;
    if (array.Length % 2 != 0)
    {
        //MIDDLE POSITION OF AN ARRAY IF ODDS
        Console.WriteLine($"The middle position of the array is:");
        Console.WriteLine($"{ArrayMiddlePosition + 1}) {array[ArrayMiddlePosition]}");
    }
    else
    {
        //MIDDLE POSTIONS OF AN ARRAY IF EVEN
        Console.WriteLine($"The middle positions of the array are:");
        Console.WriteLine($"{ArrayMiddlePositionEven + 1}) {array[ArrayMiddlePositionEven]}");
        Console.WriteLine($"{ArrayMiddlePosition + 1}) {array[ArrayMiddlePosition]}");
        ;
    }
}

