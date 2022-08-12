

void ArrayReverse(int[] array)
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size - 1;
    while (index1 < index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
        index1++;
        index2--;
    }
}
