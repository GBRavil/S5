//Написать программу копирования массива
int [] num = {1,2,3,4};
Copy(num);
void Copy(int [] n1){
    Console.WriteLine($"Скопированный массив");
    int [] n2 = new int [n1.Length];
    for(int i = 0; i < n1.Length; i++) {
        n2[i] = n1[i];
        Console.Write($"{n2[i]} ");
    }
}