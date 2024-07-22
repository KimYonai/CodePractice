using System.Runtime.CompilerServices;

namespace OOPPractice
{
    internal class Program
    {
        class Character
        {
           public int level = 1;
           public int hp = 100;
           public int speed = 10;
           public int characterAttack = 30;

            public void TakeDamage(int damage)
            {
                Console.WriteLine($"캐릭터가 {damage}만큼 데미지를 받았다.");
                hp -= damage;
                Console.WriteLine($"캐릭터의 체력은 {hp}남았다.");

                if (hp <= 0)
                {
                    Die();
                }
            }

            private void Die()
            {
                Console.WriteLine("You Died");
            }
        }

        
        class Monster
        {
            public int monsterLevel = 1;
            public int monsterHp = 70;
            public int monsterSpeed = 15;
            public int monsterAttack = 20;

            public void GiveDamage(int damage)
            {
                Console.WriteLine($"캐릭터가 적에게 {damage}만큼 데미지를 입혔다.");
                monsterHp -= damage;
                Console.WriteLine($"몬스터의 체력은 {monsterHp}남았다.");
            }
        }

        
        public void CharacterMove(int distance)
        {
            char key = 'w';

            switch (key)
            {
                case 'w':
                    Console.WriteLine($"캐릭터가 전방으로 {distance}만큼 이동했습니다.");
                    break;
                case 's':
                    Console.WriteLine($"캐릭터가 후방으로 {distance}만큼 이동했습니다.");
                    break;
            }
        }

        public void CharacterRotation(int rotation)
        {
            char key = 'q';

            switch (key)
            {
                case 'q':
                    Console.WriteLine($"캐릭터가 좌측으로 {rotation}만큼 회전했습니다.");
                    break;
                case 'e':
                    Console.WriteLine($"캐릭터가 우측으로 {rotation}만큼 회전했습니다.");
                    break;
            }
        }

        
        static void Main(string[] args)
        {
            Character user = new Character();

            Monster stump = new Monster();
            Monster croco = new Monster();
        }
    }
}
