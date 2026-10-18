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

// Задание 5
// int[] numbers = new int[5];
// Console.WriteLine("Введите 5 целых чисел: ");
// for (int i = 0; i < numbers.Length; i++)
// {
//     numbers[i] = int.Parse(Console.ReadLine());
// }
// Console.WriteLine("В обратном порядке:");
// for (int i = numbers.Length - 1; i >= 0; i--)
// {
//     Console.Write(numbers[i] + " ");
// }
// Console.WriteLine();
// int Count = 0;
// foreach (int n in numbers)
// {
//     if (n % 2 == 0) Count++;
// }
// Console.WriteLine($"Чётных: {Count}");
//

// Задание 6
// string[] names = { "Анна", "Игорь", "Мария", "Олег", "Ольга" };
// Console.Write("Введите имя: ");
// string search = Console.ReadLine();
// int count = -1;
// for (int i = 0; i < names.Length; i++)
// {
//     if (names[i] == search)
//     {
//         count = i;
//         break;
//     }
// }
// Console.WriteLine(count >= 0 ? $"Позиция: {count}" : "Не найдено");




// Задача7 "Журнал оценок"
// int[] students_grades = new int[8];
// Console.WriteLine("Введите 8 оценок от 2 до 5 через Enter:");

// for (int i = 0; i < students_grades.Length; i++)
// {
//     Console.Write($"Оценка {i + 1}: ");
//     int grade = int.Parse(Console.ReadLine());

//     if (grade >= 2 && grade <= 5)
//     {
//         students_grades[i] = grade;
//     }
//     else
//     {
//         Console.WriteLine("Оценка должна быть от 2 до 5");
//         i--;
//     }
// }

// Console.Write("Оценки: ");
// foreach (int grade in students_grades)
// {
//     Console.Write(grade + " ");
// }
// Console.WriteLine();

// int sum = 0;
// foreach (int grade in students_grades) sum += grade;
// double averageGrade = (double)sum / students_grades.Length;
// Console.WriteLine($"Средняя оценка: {averageGrade}");

// int max = students_grades[0];
// int min = students_grades[0];
// for (int i = 1; i < students_grades.Length; i++)
// {
//     if (students_grades[i] > max) max = students_grades[i];
//     if (students_grades[i] < min) min = students_grades[i];
// }
// Console.WriteLine($"Наибольшая оценка: {max}");
// Console.WriteLine($"Наименьшая оценка: {min}");

// int countOfTwos = 0;
// int countOfFives = 0;
// foreach (int grade in students_grades)
// {
//     if (grade == 2) countOfTwos++;
//     if (grade == 5) countOfFives++;
// }
// Console.WriteLine($"Двоек: {countOfTwos}");
// Console.WriteLine($"Пятерок: {countOfFives}");

// if (averageGrade >= 4.5)
//     Console.WriteLine("Отличник");
// else if (averageGrade >= 3.5)
//     Console.WriteLine("Хорошист");
// else
//     Console.WriteLine("Есть над чем поработать");


// Доп задание
// int[] arr = { 1, 2, 3, 4, 5, 6 };
//  for (int i = 0; i < arr.Length / 2; i++)
//  {
//      int arrr = arr[i];
//      arr[i] = arr[arr.Length - 1 - i];
//      arr[arr.Length - 1 - i] = arrr;
// }
// foreach (int j in arr) Console.Write(j + " ");
// Console.WriteLine();