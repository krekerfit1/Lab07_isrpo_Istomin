//задание1.1

// string[] days = {"пн", "вт", "ср", "чт", "пт", "сб", "вс"};

// for (int i = days.Length -1 ; i>=0; i--)
// {
//     Console.WriteLine($"{i}: ");
// }


//задание1.2
//  double[]  temperatures = {-4.5, -2.3, 0.0, 1.5, 3.2, 5.0, 7.8, 10.1, 12.5, 15.0};

//  foreach (double temp in temperatures)
//  {
//      Console.WriteLine($"Температура: {temp}°C");
//  }
//  Console.WriteLine();

//Задание 2

// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// int count = 0;
// foreach (int price in prices)
// {
//     sum += price;
//     if (price > 100)
//     {
//         count+=1;
//     }
// }

// double average = (double)sum / prices.Length;
// Console.WriteLine($"Сумма: {sum}, Среднее: {average}, Количество товаров дороже 100: {count}");

//пример

// int[] numbers = { 7,-2,15,4,9 };
// int max= numbers[0];

// for (int i = 1; i<numbers.Length; i++)
// {
//     if (numbers[i] > max)
//     {
//         max = numbers[i];
//     }
// }
// Console.WriteLine($"Максимальное значение: {max}");

//Задание 3

// int[] prices = { 120, 45, 300, 80, 15, 210 };

// int minPrice = prices[0];
// int maxPrice = prices[0];
// int maxIndex = 0;

// for (int i = 0; i < prices.Length; i++)
// {
//     if (prices[i] < minPrice)
//     {
//         minPrice = prices[i];
//     }

//     if (prices[i] > maxPrice)
//     {
//         maxPrice = prices[i];
//         maxIndex = i;
//     }
// }

// Console.WriteLine($"Минимальная цена: {minPrice}"); 
// Console.WriteLine($"Индекс самого дорогого товара: {maxIndex}"); 


//задание 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };

// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//     {
//         balance[i] = 0;
//     }
// }

// foreach (int n in balance)
// {
//     Console.WriteLine(n);
// }