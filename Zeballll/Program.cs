internal class Program
{
    private static Character player;

    static void Main(string[] args)
    {
        Setting();
        Intro();
    }

    static void Setting()
    {
        // 캐릭터 정보 세팅
        player = new Character("Jamnini", "도적", 279, 2763, 37, 420, 1000);

        // 아이템 정보 세팅
    }

    static void Intro()
    {
        Console.Clear();

        Console.WriteLine("커닝시티에 오신 것을 환영합니다");
        Console.WriteLine("파티퀘스트 '첫번째 동행' 에 들어가기 전 활동을 하실 수 있습니다.");
        Console.WriteLine();
        Console.WriteLine("1. 상태보기");
        Console.WriteLine("2. 인벤토리");
        Console.WriteLine("3. 상점가기");
        Console.WriteLine();
        Console.WriteLine("원하시는 행동을 입력해주세요.");

         int input = CheckValidInput(1, 2, 3);
        switch (input)
        {
            case 1:
                Info();
                break;

            case 2:
                Inventory();
                break;

            case 3:
                Shop();
                break;
        }
    }

    static void Info()
    {
        Console.Clear();

        Console.WriteLine("상태보기");
        Console.WriteLine("캐릭터의 능력치를 표시합니다.");
        Console.WriteLine();
        Console.WriteLine($"Lv.{player.Level}");
        Console.WriteLine($"{player.Name}({player.Job})");
        Console.WriteLine($"공격력 :{player.Atk}");
        Console.WriteLine($"방어력 : {player.Def}");
        Console.WriteLine($"체력 : {player.Hp}");
        Console.WriteLine($"Gold : {player.Gold} G");
        Console.WriteLine();
        Console.WriteLine("0. 나가기");

        int input = CheckValidInput(0, 0);
        switch (input)
        {
            case 0:
                Intro();
                break;
        }
    }

    static void Inventory()
    {
        Console.Clear();
        Console.WriteLine("제네시스 가즈");
        Console.WriteLine("파사부");
        Console.WriteLine();
        Console.WriteLine("0. 나가기");

        int input = CheckValidInput(0, 0);
        switch (input)
        {
            case 0:
                Intro();
                break;
        }
    }
    static void Shop()
    {
        Console.Clear();
        Console.WriteLine("상점에 오신 것을 환영합니다");
        Console.WriteLine("아래에 물품을 확인 할 수 있습니다");
        Console.WriteLine();
        Console.WriteLine("1. 리스트레인트링");
        Console.WriteLine("2. 뇌전수리검");
        Console.WriteLine();
        Console.WriteLine("0. 나가기");

        int input = CheckValidInput(0, 0);
        switch (input)
        {
            case 0:
                Intro();
                break;
        }
    }

    static int CheckValidInput(params int[] validChoices)
    {
        while (true)
        {
            string input = Console.ReadLine();

            bool parseSuccess = int.TryParse(input, out var ret);
            if (parseSuccess && validChoices.Contains(ret))
            {
                return ret;
            }

            Console.WriteLine("잘못된 입력입니다.");
        }
    }
}


public class Character
{
    public string Name { get; }
    public string Job { get; }
    public int Level { get; }
    public int Atk { get; }
    public int Def { get; }
    public int Hp { get; }
    public int Gold { get; }

    public Character(string name, string job, int level, int atk, int def, int hp, int gold)
    {
        Name = name;
        Job = job;
        Level = level;
        Atk = atk;
        Def = def;
        Hp = hp;
        Gold = gold;
    }
}