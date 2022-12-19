int[] array = {15, 27, 610, 46, 52, 610, 78, 82};

int n = array.Length;
int find = 610;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //Made so that it finds only one particle of the array
    }
    index++;
}