namespace HW2_Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Угол а задан в градусах, минутах и секундах. Найти его величину в радианах. 
             * Значения минут и секунд должны быть в пределах. Если секунды превышают 60, 
             * они пересчитываются в минуты.
             * если угол вводится > 360; > 60'; > 60''; то 
             * 30 15'36'' = 0,528
             * 43 12'22'' = 0,754
             * 480 12'22'' = 8,381
             * -120 10'20'' = -2.097 [ -(120 + 10/60 + 20/3600)]
             */
            int d = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("angle in degrees is {0} {1}'{2}''", d, m, s);

            // Угол, заданный в градусах, минутах и секундах, переводится в десятичные градусы
            // полученное значение часто преобразуют в радианы
            double sign = Math.Sign(d);
            double grad = d + sign * (m / 60.0 + s / 3600.0);
            
            double rad = grad * Math.PI / 180.0;
            Console.WriteLine("angle in radians is {0}", rad);
        }
    }
}
