

int[] CreateArrayRandomInt(int arrayLength, int minIntervalValue, int maxIntervalValue)
{
    Random rnd = new Random();
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minIntervalValue, maxIntervalValue + 1);
    }
    return array;
}
