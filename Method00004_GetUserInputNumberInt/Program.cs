
string[] GetUserInputNumbersString(string userInputNumberString)
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
    int[] userNumberInt = new int[userNumberString.Length];
    for (int i = 0; i < userNumberString.Length; i++)
    {
        userNumberInt[i] = Convert.ToInt32(stringArray[i]);
    }
    return userNumberInt;
}

string[] inputString = GetUserInputNumbersString("Enter any integer: ");
int[] inputInt = ConvertUserInputNumbersInt(inputString);