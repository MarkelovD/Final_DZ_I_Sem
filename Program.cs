string[] InputMass = { "Destiny", "*_*", "GoW", "xyz", "Markelov", "Tor", "GB", "posible", "451" };
int Size_txt = 3; //переменная хранящая условие задачи
int LengthNewMass = LengthSortMass(InputMass);

// заполение нового массива
string[] SortMass = new string[LengthNewMass];

TransferValue(InputMass, SortMass);
PrintInputMass(InputMass);
Console.WriteLine();
PrintSortMass(SortMass);



// блок методов

//нахождение размера массива с результатом выборки
int LengthSortMass(string[] InputMass)
{
    int LengthMass = 0;
    foreach (string i in InputMass)
    {
        string name = i;
        if (name.Length <= Size_txt)
        {
            LengthMass++;
        }
    }
    return LengthMass;
}

// метод заполнения массива
void TransferValue(string[] InputMass, string[] SortMass)
{
    for (int m = 0; m < LengthNewMass;) // проход по элементам выходного массива
    {
        for (int j = 0; j < InputMass.Length; j++)// проход по элементам входного массива
        {
            if (InputMass[j].Length <= Size_txt)
            {
                SortMass[m] = InputMass[j];
                m++;
            }
        }
    }
}

// метод вывода нового массива
void PrintInputMass(string[] InputMass)
{
    Console.Write("заданный массив: [");
    for (int k = 0; k < InputMass.Length; k++)
    {
        Console.Write(InputMass[k] + " ");
    }
    Console.Write("]");
}

// метод вывода нового массива
void PrintSortMass(string[] SortMass)
{
    Console.Write("массив с результатами: [");
    for (int k = 0; k < SortMass.Length; k++)
    {
        Console.Write(SortMass[k] + " ");
    }
    Console.Write("]");
}