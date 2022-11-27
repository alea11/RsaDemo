using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsaDemo
{
    public class MathOperations
    {
        /// <summary>
        ///  Бинарное умножение по модулю 
        /// </summary>
        /// <param name="a">множитель (в диапазоне 0...m)</param>
        /// <param name="b">множитель (в диапазоне 0...m)</param>
        /// <param name="m">модуль</param>
        /// <returns>произведение (в диапазоне 0...m)</returns>
        public static ulong Mul(ulong a, ulong b, ulong m)
        {
            if (b == 0)
                return 0;
            if (b == 1)
                return a;
            if((b & 0x1) == 0)
            {
                ulong t = Mul(a, b>>1, m);
                return (t << 1) % m;
            }
            return (Mul(a, b - 1, m) + a) % m;
        }

        /// <summary>
        ///  Бинарное возведение в степень по модулю 
        /// </summary>
        /// <param name="a">основание (в диапазоне 0...m)</param>
        /// <param name="b">показатель степени (в диапазоне 0...m)</param>
        /// <param name="m">модуль</param>
        /// <returns>степень (в диапазоне 0...m)</returns>
        public static ulong Pow(ulong a, ulong b, ulong m)
        {
            if (b == 0)
                return 1;
            if ((b & 0x1) == 0)
            {
                ulong t = Pow(a, b >> 1, m);
                return Mul (t,t,m); //% m
            }
            return (Mul(Pow(a, b - 1, m), a, m)) ; //% m
        }

        /// <summary>
        /// Наибольший общий делитель (НОД) по алгоритму Евклида
        /// </summary>        
        public static ulong GCD(ulong a, ulong b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }

        /// <summary>
        /// Расширенный алгоритм Евклида - Наибольший общий делитель (НОД) и коэффициенты Безу
        /// </summary>  
        public static ulong ExtGCD(ulong a, ulong b, out long x, out long y)
        {
            if (b == 0)
            {
                x = 1;
                y = 0;
                return a;
            }
            ulong g = ExtGCD(b, a % b, out y, out x); // x и y - переставляются
            y = y - (long)(a / b) * x;
            return g;
        }

        /// <summary>
        /// Наименьшее общее кратное (НОК) - по НОД
        /// </summary>        
        public static ulong LCM(ulong a, ulong b)
        {
            if (a == 0 || b ==0)
                return 0;
            ulong g = GCD(a,b);
            return a * (b / g);
        }

        /// <summary>
        /// Обратное по модулю - по расширенному алгоритму Евклида для НОД
        /// </summary>
        /// <param name="a"></param>
        /// <param name="m"></param>
        public static ulong Inverse1(ulong a, ulong m) 
        {
            long x, y;
            ulong g = ExtGCD(a, m, out x, out y);
            if (g != 1)
            {
                //MessageBox.Show("выбранный открытый ключ E и функция Эйлера от m - не взаимопросты, нужно подобрать другой ключ, например простое число");
                return 0;
            }
            else
            {
                return x > 0 ? (ulong)x : (ulong)x + m;                
            }

        }

        

        /// <summary>
        /// Обратное по модулю m - по функции Эйлера
        /// </summary>
        /// <param name="a"></param>
        /// <param name="m"></param>
        /// <param name="f">ф-я Эйлера от m</param>
        public static ulong Inverse2(ulong a, ulong m, ulong f) 
        {            
            return Pow(a, f-1, m);
        }

        /// <summary>
        /// Функция проверки - является ли число первообразным корнем для простого p
        /// </summary>
        /// <param name="g">проверяемое число</param>
        /// <param name="p">простое число, модуль</param>
        /// <returns></returns>
        public static bool IsPrimitiveRootOfPrime(ulong g, ulong p)
        {
            // находим делители  p-1 , и для каждого делителя d проверяем g^v по модулю p. где v - произведение всех других делителей без d. Если 1 - то проверка не прошла.
            // т.е. приходим к результату 1 (что выполняется по малой теореме Ферма для простых p) - только при полном наборе делителей p-1, либо (при неудаче) возможно раньше 

            ulong a = p - 1;

            // убираем первый делитель  - 2 (при простом p >2     - p-1 - вседа четное)
            ulong num = a >>1 ;
            if (Pow(g, num, p) == 1)
                return false;
           
            // убираем степени 2
            while((num  & 0x1) != 0x1)
                num = num >> 1;


            // находим и проверяем другие делители (по одному, если кратные)
            ulong d = 3; // очередной потенциальный делитель
            while (num > 1) 
            {
                if(num % d == 0)
                {
                    if (Pow(g, a / d, p) == 1)
                        return false;

                    // убираем соответствующий множитель. многократно, если нужно
                    while (((num = (num / d)) %d) == 0)
                    { }
                }
                
                d += 2;                
            }
            
            return true;
        }

        public static ulong ULongRandom(ulong max, int? seed = null)
        {
            Random rnd = (seed == null) ? new Random() : new Random(seed.Value);

            ulong mask0 = 0xffff;
            ulong mask1 = 0xffffffff;
            ulong mask2 = 0xffffffffffff;

            int max0 = (int)(max & mask0);
            int max1 = (int)((max & mask1) >> 16);
            int max2 = (int)((max & mask2) >> 32);
            int max3 = (int)(max >> 48);

            return ((ulong)rnd.Next(max0)) | ((ulong)rnd.Next(max1) << 16) | ((ulong)rnd.Next(max2) << 32) | ((ulong)rnd.Next(max3) << 48);
        }

    }
}
