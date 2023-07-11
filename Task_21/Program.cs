// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void Coordinate(double Ax, double Ay, double Az, double Bx, double By, double Bz)
{
    double A = Bx - Ax;
    double B = By - Ay;
    double C = Bz - Az;
    double length = Math.Sqrt(A * A + B * B + C * C);
    Console.WriteLine("-> " + Math.Round(length, 2));
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Ax = GetInput("Введите координаты X точки А: ");
int Ay = GetInput("Введите координаты Y точки А: ");
int Az = GetInput("Введите координаты Z точки А: ");
int Bx = GetInput("Введите координаты X точки B: ");
int By = GetInput("Введите координаты Y точки В: ");
int Bz = GetInput("Введите координаты Z точки А: ");

Coordinate(Ax, Ay, Az, Bx, By, Bz);