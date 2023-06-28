//  Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int RandomNumbers(int rNumbers, int min, int max)
  {
  int[] randomNumber = new int[rNumbers];
  int sumElements = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumber.Length; i++ ){
      randomNumber[i] = new Random().Next(1, 1000);

      Console.Write(randomNumber[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumber[i];
      }
    }
  return sumElements;
  }
//_________________________________________________
Console.WriteLine($"Введи длину массива: ");
int rNumbers = Convert.ToInt32(Console.ReadLine()); 
int randomNumber =  RandomNumbers(rNumbers, 1, 10);
Console.WriteLine($"  Сумма элементов, стоящих на нечётных позициях: {randomNumber}");




