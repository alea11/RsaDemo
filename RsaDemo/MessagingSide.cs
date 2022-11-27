using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RsaDemo
{
    /// <summary>
    /// сторона обмена сообщениями
    /// </summary>
    class MessagingSide
    {         

        // результирующий ключ
        private ulong _key { get; set; }


        // детали алгоритма, их общедоступность не нужна (или даже недопустима), свойства выведены наружу только для того чтобы отобразить на форме примера
        public ulong Key { get; private set; }
        public ulong K{ get; private set; }
        public ulong GS { get; private set; }



        /// <summary>
        /// Инициирование обмена, генерация ключа (эквивалентного ключу на другой стороне) для последующего обмена зашифрованными сообщениями
        /// </summary>
        /// <param name="other">адресат</param>
        /// <param name="p">параметр шифрования, модуль - простое число (большое)</param>
        /// <param name="g">параметр обмена, один из первообразных корней от p</param>
        public void CreateSession(MessagingSide other, ulong p, ulong g)
        {
            // свой секретный ключ, случайное число
            ulong k = MathOperations.ULongRandom(p, 123);

            // свой вариант шифрования G
            ulong selfGs = MathOperations.Pow(g, k, p);

            // инициация сессии, передача параметров и получение от адресата его варианта шифрования G
            ulong gs = other.OnRequest(p, g, selfGs);

            // расчитываем ключ для обмена сообщениями
            _key = MathOperations.Pow(gs, k, p);

            //только для отображения
            Key = _key;
            K = k;
            GS = selfGs;
        }

        /// <summary>
        /// Обработка запроса формировани сеанса, генерация ключа (эквивалентного ключу на другой стороне) для последующего обмена зашифрованными сообщениями
        /// </summary>
        /// <param name="p">параметр шифрования, модуль - простое число (большое)</param>
        /// <param name="g">параметр обмена, один из первообразных корней от p</param>
        /// <param name="gs">зашифрованный G от запрашивающей стороны</param>
        /// <returns>Возвращаем зашифрованный G нашим ключом</returns>
        public ulong OnRequest(ulong p, ulong g, ulong gs)
        {
            // свой секретный ключ, случайное число
            ulong k = MathOperations.ULongRandom(p, 555);
            
            // расчитываем ключ для обмена сообщениями
            _key = MathOperations.Pow(gs, k, p);

            // свой вариант шифрования G
            ulong selfGs = MathOperations.Pow(g, k, p);

            //только для отображения
            Key = _key;
            K = k;
            GS = selfGs;

            return selfGs;
        }

        public ulong Encrypt(ulong msg)
        {
            return msg ^ _key;
        }

        public ulong Decrypt(ulong msg)
        {
            return msg ^ _key;
        }

        
    }
}
