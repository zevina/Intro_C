//             0   1   2  3   4   5   6  7
int[] array = {1, 52, 68, 4, 45, 68, 47, 8};

int n = array.Length;
int find = 68;

int index = 0;
while (index < n)
{
  if (array[index] == find)
  {
    System.Console.WriteLine(index);
    break;
  }
  index++;
}