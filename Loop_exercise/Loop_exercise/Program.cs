// See https://aka.ms/new-console-template for more information

// 1. Nhap so nguyen n. Tinh n!

Console.WriteLine("n = ");
int n = int.Parse(Console.ReadLine());

int factorial = 1;
    for (int i = 1; i <= n; i++)
    {
        factorial *= i;
    }
    Console.WriteLine("Factorial of " + n + " is " + factorial);


// 2. Nhap so nguyen n
//    a. Kiem tra n co phai so nguyen to khong
//    b. Hien thi tat ca cac so nguyen to trong khoang 1 den n
bool prime = true;
if (n < 2)
{
    prime = false;
}
for (int i = 2; i < n / 2; i++)
{
    if (n % i == 0)
    {
        prime = false;
        break;
    }
}
if (prime)
{
    Console.WriteLine(n + " is a prime");
}
else
{
    Console.WriteLine(n + " is not a prime");
}



// 3. Nhap so nguyen n (n > 10). Hien thi day Fibonacci co do dai n
int firstN = 0, secondN = 1, nextN;
Console.WriteLine("Fibonacci: " +firstN + " " + secondN + " ");
for (int i = 2; i < n; i++)
{
    nextN = firstN + secondN;
    Console.WriteLine(nextN + " ");
    firstN = secondN;
    secondN = nextN;
}