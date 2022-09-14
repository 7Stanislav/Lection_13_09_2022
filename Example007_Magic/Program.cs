Console.Clear();
//Console.Set.CursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 15, ya = 1,
    xb = 1, yb = 24,
    xc = 30, yc = 24;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = (xc) / 2; // Не понял, откуда взялись изначально величины и как они работают. Вместо строки 19 написал свою и добавил строку 20: указал координаты середины нижней стороны треугольника
int y = yc; // Коммент к строке 19

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3); // [0;3) 0 1 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}