namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monster monster = new Monster();
            PlayerCharacter player = new PlayerCharacter();

            CharacterManager manager = new CharacterManager();

            manager.Move(player);
            manager.Attack(player, monster);

        }
    }

    //과제 1.
    //Chracter
    //클래스 선언하기
    //Chracter 클래스를 선언하고, 클래스가 가져야 할 필드와 메서드는 아래와 같다.
    
    //필드
    //레벨
    //체력
    //이동 속도
    //공격력

    //메서드
    //전진
    //후진
    //좌회전(90도)
    //우회전(90도)
    //공격
    //피격

    //제출 형태
    //C# 콘솔 프로젝트
    //개인 과제용 Git Repository 디렉토리 생성 후 Push
    //디렉토리 이름 : 내 제출일 6자(Ex> 240619)

    public class Character
    {
        public int _level;
        public int _hp;
        public float _speed;
        public float _power;

        public void MoveToForward()
        {
            Console.WriteLine($"{_speed} 속도로 전진");
        }

        public void MoveToBackward()
        {
            Console.WriteLine($"{_speed} 속도로 후진");
        }

        public void TurnRight()
        {
            Console.WriteLine("90도로 좌회전 합니다.");
        }

        public void TurnLeft()
        {
            Console.WriteLine("90도로 우회전 합니다.");
        }

        public void Attack()
        {
            Console.WriteLine($"{_power} 힘으로 공격합니다.");
        }

        public void OnDamage(float m_damage)
        {
            Console.WriteLine($"{m_damage} 힘으로 피격받습니다.");
        }
    }

    //과제 2. 몬스터와 플레이어 클래스 선언하기
    //과제 1의 Character를 상속받는 Monster, PlayerCharacter 클래스 생성하기
    //플레이어와 몬스터는 필드를 개별적으로 변경할 수 있어야 한다.

    public class Monster : Character
    {
        public string _dropItem;
    }

    public class PlayerCharacter : Character
    {
        public string _id;
        public string _weapon;
    }

    //과제 3. 몬스터와 플레이어를 관리하는
    //CharacterManager
    //클래스 생성하기
    //몬스터와 플레이어를 하나의 타입으로 관리할 수 있는 CharacterManager 클래스를 선언한다.
    //이 때, Main 함수 내에서 CharacterManager의 인스턴스를 생성하고, 몬스터와 플레이어의 행동을 관리할 수 있어야 한다.

    public class CharacterManager
    {
        public void Move(Character m_c1)
        {
            m_c1.MoveToBackward();
        }

        public void Attack(Character m_c1, Character m_c2)
        {
            m_c1.Attack();
            m_c2.OnDamage(m_c1._power);
        }
    }
}
