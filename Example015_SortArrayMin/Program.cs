//Алгоритм сортировки массива методов выбора (минимального значения)

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1, 0};

void PrintArray(int[] array)//вывод искходного массива в терминал
{
  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
    Console.Write(array[i]);
  }
  Console.WriteLine();
}

void SelectionSort (int[] array)
{
  for (int i = 0; i < array.Length-1; i++)
  {
    int minPosition = i;
    for (int j = i+1; j < array.Length; j++)
    {
      if (array[j] < array[minPosition])
      {
        minPosition = j;
      }
    }
    int temp = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temp;
  }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);