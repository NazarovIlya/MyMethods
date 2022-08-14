﻿
int[] GetUserInputNumbersString(string userInputNumberString)
{
    Console.WriteLine(userInputNumberString);
    string[] stringArray = Console.ReadLine().Split(",");
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i] == string.Empty || stringArray[i] == " "
            || Convert.ToInt32(stringArray[i]) == null)
        {
            Console.WriteLine("Ошибка ввода данных. Попробуйте еще раз запустить программу и ввести данные корректно.");
            Environment.Exit(0);
        }
    }
    return stringArray;
}

int[] ConvertUserInputNumbersInt(string[] userNumberString)
{
    int[] numberArray = new int[stringArray.Length];
    for (int i = 0; i < numberArray.Length; i++)
    {
        numberArray[i] = Convert.ToInt32(stringArray[i]);
    }
    return numberArray;
}

string[] inputString = GetUserInputNumbersString("Enter any integer: ");
int[] inputInt = ConvertUserInputNumbersInt(inputString);