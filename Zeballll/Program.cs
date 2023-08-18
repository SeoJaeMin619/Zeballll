using System.Reflection;
using System;

class Program
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
            player = new Character("Jamnini", "돚거", 279, 2763, 37, 420, 1000);

            // 아이템 정보 세팅
        }

        static void Intro()
        {
            Console.WriteLine();

            Console.WriteLine("커닝시티에 오신것을 환영합니다");
            Console.WriteLine("파티퀘스트 '첫번째동행' 에 들어가기 전 활동을 할 수 있습니다");
            Console.WriteLine();
            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
        }

    public void Character()
    //왜 캐릭터 인식을 못하지 . . .???
    { 
        public string Name { get; }
        public string Job { get; }
        public int Level { get; }
        public int Atk { get; }
        public int Def { get; }
        public int Hp { get; }
        public int Gold { get; }
    }
}

    //인트로 클래스
    //캐릭정보창을 갈수있게 하자

    //캐릭정보창 클래스

    //강화(?) 클래스




