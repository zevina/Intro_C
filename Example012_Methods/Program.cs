//Виды методов (функций):

//1 вид

void  Method1()
{
  Console.WriteLine("Зевина Лена");
}

Method1();

//2 вид

void Method21(string msg)
{
  Console.WriteLine(msg);
}

Method21("Метод 2.1");



void Method22(string msg, int count)
{
  int i = 0;
  while (i < count)
  {
    Console.WriteLine(msg);
    i++;
  }
}

Method22(msg: "Метод 2.2", count: 3);


//3 вид

int Method3()
{
  return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);

//4 вид

string Method4(int count2, string text)
{
  int i = 0;
  string result = String.Empty;
  while (i < count2)
  {
    result = result + text;
    i++;
  }
  return result;
}

string res = Method4(10, "Z ");
Console.WriteLine(res);