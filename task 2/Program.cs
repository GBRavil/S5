//Написать программу масштабирования фигуры
double [] num = new double [4];
Console.WriteLine("Введите координаты фигуры (x1) (x2) (x3) (x4)");
num[0] = Convert.ToDouble(Console.ReadLine());
num[1] = Convert.ToDouble(Console.ReadLine());
num[2] = Convert.ToDouble(Console.ReadLine());
num[3] = Convert.ToDouble(Console.ReadLine());
Str(num);
Console.WriteLine("Введите коэффициент масштабирования (k) на выбор 2 или 4 или 0,5");
double k = Convert.ToDouble(Console.ReadLine());
for(int i = 0; i < num.Length; i++) {
    num[i] = num[i] * k;
}
Console.WriteLine($"При k = {k}");
Str(num);
void Str (double [] n) {
    string r1 = string.Format("{0:f1}", n[0]);
    string r2 = string.Format("{0:f1}", n[1]);
    string r3 = string.Format("{0:f1}", n[2]);
    string r4 = string.Format("{0:f1}", n[3]);
    Console.WriteLine($"Координаты фигуры ({r1}) ({r2}) ({r3}) ({r4})");
}