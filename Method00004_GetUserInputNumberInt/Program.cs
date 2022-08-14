
string[] GetUserInputNumbersString(string userInputTextString)
{
    Console.WriteLine(userInputTextString);
    string[] userInputString = Console.ReadLine().Split(",");
    return userInputString;
}

string[] CheckUserInputToInt(string[] userInputString)
{
    for (int i = 0; i < userInputString.Length; i++)
    {
        if (userInputString[i] == string.Empty || userInputString[i] == " "
            || Convert.ToInt32(userInputString[i]) == null)
        {
            Console.WriteLine("Ошибка ввода данных. Попробуйте еще раз запустить программу и ввести данные корректно.");
            Environment.Exit(0);
        }
    }
    return userInputString;
}

int[] ConvertUserInputNumbersInt(string[] userNumberString)
{
    int[] userNumberInt = new int[userNumberString.Length];
    for (int i = 0; i < userNumberString.Length; i++)
    {
        userNumberInt[i] = Convert.ToInt32(userNumberString[i]);
    }
    return userNumberInt;
}

string[] inputString = GetUserInputNumbersString("Enter any integer: ");
inputString = CheckUserInputToInt(inputString);
int[] inputInt = ConvertUserInputNumbersInt(inputString);

//! it was a single method
// int[] GetUserInputNumbersInt(string userInputNumberString)
// {
//     Console.WriteLine(userInputNumberString);
//     string[] stringArray = Console.ReadLine().Split(",");
//     int[] numberArray = new int[stringArray.Length];
//     for (int i = 0; i < numberArray.Length; i++)
//     {
//         if (stringArray[i] == string.Empty || stringArray[i] == " "
//             || Convert.ToInt32(stringArray[i]) == null)
//         {
//             Console.WriteLine("Ошибка ввода данных. Попробуйте еще раз запустить программу и ввести данные корректно.");
//             Environment.Exit(0);
//         }
//         else numberArray[i] = Convert.ToInt32(stringArray[i]);
//     }
//     return numberArray;
// }