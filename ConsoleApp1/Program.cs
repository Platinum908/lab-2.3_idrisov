//2.3 Высокий уровень #22

Console.Write("Введите x: ");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите вариант параметра 1 || 2 || 3: ");
int num = int.Parse(Console.ReadLine());
double a, b, z, y;
switch(num){
    case 1: a = 0.3;b = 0.9; z = Math.Sin(Math.Pow(x, 2));
        if (x < a) {y = a + b * x + Math.Pow(Math.Sin(z*(Math.Pow(x,3.5))), 2);}
        else if(a <= x && x <= Math.Pow(b, 2)) { y = a + Math.Log(Math.Abs(a * b - z * Math.Pow(x, 3))) + Math.Log(x); }
        else if(x>Math.Pow(b, 2)) { y = Math.Sqrt(Math.Abs(a + Math.Tan(z * x))) + b * Math.Sin(x); }
        break;
    case 2:
        a = 4.3; b = 3.15; z = Math.Sin(Math.Pow(x, 3));
        if (x < a) { y = a + b * x + Math.Pow(Math.Sin(z * (Math.Pow(x, 3.5))), 2); }
        else if (a <= x && x <= Math.Pow(b, 2)) { y = a + Math.Log(Math.Abs(a * b - z * Math.Pow(x, 3))) + Math.Log(x); }
        else if (x > Math.Pow(b, 2)) { y = Math.Sqrt(Math.Abs(a + Math.Tan(z * x))) + b * Math.Sin(x); }
        break;
    case 3:
        a = 6.5; b = 3.5; z = Math.Pow(Math.Sin(x), 2);
        if (x < a) { y = a + b * x + Math.Pow(Math.Sin(z * (Math.Pow(x, 3.5))), 2); }
        else if (a <= x && x <= Math.Pow(b, 2)) { y = a + Math.Log(Math.Abs(a * b - z * Math.Pow(x, 3))) + Math.Log(x); }
        else if (x > Math.Pow(b, 2)) { y = Math.Sqrt(Math.Abs(a + Math.Tan(z * x))) + b * Math.Sin(x); }
        break;
        default:break;
}