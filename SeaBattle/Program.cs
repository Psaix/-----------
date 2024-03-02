//Преобразуем первую входящую строку в целочисленное значение. Это значение является количеством последующих входных строк с кораблями.
int amountOfShips = int.Parse(Console.ReadLine());

//Инициализируем массив строк для вывода ответов. Количество ответов равно количеству строк с кораблями.
string [] answers = new string[amountOfShips];

//Создаем цикл для обработки каждой строки с кораблями.
for(int i = 0; i < amountOfShips; i++)
    {
        //Считываем строку и создаем из нее массив символов одновременно убирая из него пробелы.
        char [] ship = (Console.ReadLine().Replace(" ", "")).ToCharArray();

        //Инициализируем переменные для всех типов кораблей.
        var oneDeck = 0;
        var twoDeck = 0;
        var threeDeck = 0;
        var fourDeck = 0;

        //Создаем цикл для массива символов.При нахождении соответствующего символа, значения корабля увеличивается на 1.
        foreach(char element in ship)
        {
            if(element == '1')
            {
                oneDeck++;
            }
            if(element == '2')
            {
                twoDeck++;
            }
            if(element == '3')
            {
                threeDeck++;
            }
            if(element == '4')
            {
                fourDeck++;
            }
        }

        //По завершении цикла для массива символов, добавляем в массив строк соответствующую строку с ответом.
        //Если количество кораблей соответствует правилам, добавляем "YES". В остальных случаях добавляем "NO".
        if(oneDeck == 4 && twoDeck == 3 && threeDeck == 2 && fourDeck == 1)
        {
            answers[i] = ("YES");
        }
        else
        {
            answers[i] = ("NO");
        }
    }

    //Выводим все элементы массива строк в терминал.
    foreach(string element in answers)
    {
        Console.WriteLine(element);
    }