public class SortArray 
{
    const int _height = 4;
    const int _width = 9;

    private static char[,] _array = new char[_height, _width];

    private static void Main(string[] args)
    {
        Console.WriteLine("Случайно заполненный массив");
        RandomFillArray();
        PaintArray();

        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Отсортированный массив");
        SortingArray();
        PaintArray();

        Console.ReadKey();
    }

    private static void RandomFillArray()
    {
        int space = _height;
        int starsCount = 1;

        for (int i = 0; i < _height; i++)
        {
            int currentStarsCout = 0;

            for (int j = 0; j < _width; j++)
            {
                if (currentStarsCout != starsCount)
                {
                    var rand = new Random();

                    if (_width - j > starsCount - currentStarsCout)
                    {
                        if (rand.Next(0, 2) == 0)
                        {
                            _array[i, j] = '-';
                        }
                        else
                        {
                            _array[i, j] = '*';
                            currentStarsCout++;
                        }
                    }
                    else
                    {
                        _array[i, j] = '*';
                        currentStarsCout++;
                    }
                }
                else
                {
                    _array[i, j] = '-';
                }
            }
            space--;
            starsCount += 2;
        }
    }

    private static void SortingArray()
    {
        int space = _height;

        for (int i = 0; i < _height; i++)
        {
            for (int j = 0; j < _width; j++)
            {
                if (j < space || j > (_width - 1) - space)
                {
                    if (_array[i, j] == '*')
                        _array[i, j] = '-';
                }
                else
                {
                    if (_array[i, j] == '-')
                        _array[i, j] = '*';
                }
            }

            space--;
        }
    }

    private static void PaintArray() 
    {
        for (int i = 0; i < _array.GetLength(0); i++)
        {
            for (int j = 0; j < _array.GetLength(1); j++)
            {
                Console.Write(_array[i, j]);
            }

            Console.WriteLine();
        }
    }
}
