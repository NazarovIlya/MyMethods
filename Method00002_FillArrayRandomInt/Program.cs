

void FillArrayRandomInt(int[] array, int minIntervalValue, int maxIntervalValue)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minIntervalValue, maxIntervalValue + 1);
    }
}
