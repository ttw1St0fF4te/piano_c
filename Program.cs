namespace piano_c;
internal class Piano
{
    private static int[] BaseOctave;
    private static int[] FirstOctave = new int[] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
    private static int[] SecondOctave = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
    private static int[] ThirdOctave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
    static void Main(string[] args)
    {
        Console.WriteLine("F1, F2, F3 - Смена октав");
        Console.WriteLine("W, E, T, Y, U - Черные клавиши");
        Console.WriteLine("A, S, D, F, G, H, J - Белые клавиши");
        Console.WriteLine("Выберете октаву: ");
        ConsoleKeyInfo userKey;
        while (true)
        {
            userKey = Console.ReadKey(true);
            keyBinds(userKey);
        }
    }
    static void keyBinds(ConsoleKeyInfo key)
    {
        switch (key.Key)
        {
            case ConsoleKey.F1:
                Octave(FirstOctave);
                Console.Clear();
                Console.WriteLine("1 октава");
                break;
            case ConsoleKey.F2:
                Octave(SecondOctave);
                Console.Clear();
                Console.WriteLine("2 октава");
                break;
            case ConsoleKey.F3:
                Octave(ThirdOctave);
                Console.Clear();
                Console.WriteLine("3 октава");
                break;
            case ConsoleKey.Escape:
                Console.WriteLine("Чтобы выйти нажмите enter");
                Console.ReadLine();
                Environment.Exit(0);
                break;
            case ConsoleKey.A:
                userBeep(BaseOctave, 0);
                break;
            case ConsoleKey.W:
                userBeep(BaseOctave, 1);
                break;
            case ConsoleKey.S:
                userBeep(BaseOctave, 2);
                break;
            case ConsoleKey.E:
                userBeep(BaseOctave, 3);
                break;
            case ConsoleKey.D:
                userBeep(BaseOctave, 4);
                break;
            case ConsoleKey.F:
                userBeep(BaseOctave, 5);
                break;
            case ConsoleKey.T:
                userBeep(BaseOctave, 6);
                break;
            case ConsoleKey.G:
                userBeep(BaseOctave, 7);
                break;
            case ConsoleKey.Y:
                userBeep(BaseOctave, 8);
                break;
            case ConsoleKey.H:
                userBeep(BaseOctave, 9);
                break;
            case ConsoleKey.U:
                userBeep(BaseOctave, 10);
                break;
            case ConsoleKey.J:
                userBeep(BaseOctave, 11);
                break;
        }
    }
    static void userBeep(int[] o, int n)
    {
        Console.Beep(o[n], 200);
    }
    static void Octave(int[] userOctave)
    {
        BaseOctave = userOctave;
    }
}