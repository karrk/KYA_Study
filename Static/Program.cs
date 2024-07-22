namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    //과제 1. 계산기 클래스 만들기
    //주어진 조건을 만족하는 클래스를 설계하시오.
    //클래스 내 연산에 관련된 메서드는 static 으로 프로그램 전역에서 사용할 수 있어야 합니다.
    //요구 사항:
    //클래스 이름
    //MyCalculator
    //메서드:
    //Add: 두 개의 숫자를 받아 그 합을 반환합니다.
    //Subtract: 두 개의 숫자를 받아 첫 번째에서 두 번째를 뺀 결과를 반환합니다.
    //Multiply: 두 개의 숫자를 받아 그 곱을 반환합니다.
    //Divide: 두 개의 숫자를 받아 첫 번째를 두 번째로 나눈 결과를 반환합니다. 0으로 나누는 경우에는 적절한 에러 메시지를 반환해야 합니다.
    //Squared: 첫 번째 숫자를 기준으로 두 번째 숫자만큼 제곱하는 기능을 추가합니다.
    //입력과 반환 값:
    //모든 메서드는 두 개의 double 타입 입력을 받고, 결과도 double 타입으로 반환해야 합니다.
    //에러 처리:
    //Divide 메서드에서 0으로 나눌 경우, 콘솔에 에러 발생텍스트를 출력해야 합니다
    //제출 형태
    //.cs(C# 소스코드)

    public static class MyCalculator
    {
        public static int Add(int m_num1, int m_num2)
        {
            return m_num1 + m_num2;
        }

        public static int Subtract(int m_num1, int m_num2)
        {
            return m_num1 - m_num2;
        }

        public static int Multiply(int m_num1, int m_num2)
        {
            return m_num1 * m_num2;
        }

        public static float Divide(int m_num1, int m_num2)
        {
            if(m_num2 == 0)
            {
                Console.WriteLine("0으로 나눌수 없습니다.");
                return 0;
            }

            return (float)m_num1 / m_num2;
        }

        public static int Squared(int m_num1, int m_num2)
        {
            return (int)Math.Pow(m_num1, m_num2);
        }
    }
}
