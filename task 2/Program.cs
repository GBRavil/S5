double [] num = new double [4];
Console.WriteLine("Введите координаты фигуры (x1) (x2) (x3) (x4)");
num[0] = Convert.ToDouble(Console.ReadLine());
num[1] = Convert.ToDouble(Console.ReadLine());
num[2] = Convert.ToDouble(Console.ReadLine());
num[3] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Координаты фигуры ({num[0]}) ({num[1]}) ({num[2]}) ({num[3]})");
Console.WriteLine("Введите коэффициент масштабирования (k) на выбор 2 или 4 или 0,5");
double k = Convert.ToDouble(Console.ReadLine());
for(int i = 0; i < num.Length; i++) {
    num[i] = num[i] * k;
}
Console.WriteLine($"Координаты фигуры при k = {k} получаем ({num[0]}) ({num[1]}) ({num[2]}) ({num[3]})");