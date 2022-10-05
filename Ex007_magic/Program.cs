// 1. Определить три точки
// 2. Выбрать две любых
// 3. Найти середину
// 4. Поставить точку
// 5. Выбрать случайную вершину треугольника
// 6. Соединить её с полученной на 4 шаге точкой
// 7. Перейти к шагу 3
// 8. Шаги 3-7 построить 9, 28, 31 раз

Console.Clear();
// Console.Set.CursorPosition(10,4);   - команда рисования, цифры обозначают отступ от левого и верхнего края соответственно
// Console.WriteLine("+");   - рисование плюсиками

int xa = 40;
int ya = 1;
int xb = 1;
int yb = 30;
int xc = 80;
int yc = 30;

Console.Set.CursorPosition(xa, ya);
Console.WriteLine("+");

Console.Set.CursorPosition(xb, yb);
Console.WriteLine("+");

Console.Set.CursorPosition(xс, yс);
Console.WriteLine("+");

int x = xa, y = xb;
int count = 0;
while(count < 10000)
{
    int what = new Random().Next(0, 3);
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
        x = (x + xс) / 2;
        y = (y + yс) / 2;
    }
    Console.CursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;
}










