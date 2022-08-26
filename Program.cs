// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int akkermanFunction = Akk(m, n);

Console.Write($"Функция Аккермана = {akkermanFunction} ");

int Akk(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akk(m - 1, 1);
  else return Akk(m - 1, Akk(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}