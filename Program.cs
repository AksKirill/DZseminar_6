// // Задача 41 Вводится М чисел. посчитать сколько из них больше 0

//  Console.Write("Введите, сколько будет элементов в массиве: ");
//  int M=Convert.ToInt32(Console.ReadLine());
//   int[] numArr=new int[M];
//   int num=0;
 
//   for (int i=0; i<M; i++) {
//      Console.Write("Введите элемент массива номер " +(i+1) +": ");
//      numArr[i]=Convert.ToInt32(Console.ReadLine());
//      if (numArr[i]>0) {num++;}
//  }
//   Console.WriteLine("Положительных элементов массива: " +num);

 ///////////////////////////////////////////////////////////////////////
 // Задача 43 Найдите точку пересечения двух прямых y=k1x+b1 y=k2x+b2
Console.Write("Введите коэффициент k1 первой прямой y=k1x+b1: ");
  double k1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент b1 первой прямой y=k1x+b1: ");
  double b1=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент k2 второй прямой y=k2x+b2: ");
  double k2=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите коэффициент b2 второй прямой y=k2x+b2: ");
  double b2=Convert.ToInt32(Console.ReadLine());

double y=(b1*k2-b2*k1)/(k2-k1);
double x=(y-b1)/k1;

 Console.WriteLine("Точка пересечения: (" +x +"; " +y +")");
// y=k1((y-b2)/k2)+b1
// yk2=k1(y-b2)+b1k2
// y(k2-k1)=b1k2-b2k10

