

using System;

namespace DEV_1._2
{
    public class Converter
    {
        private string _inputString;
        private int _baseSystem;
        readonly int minBaseSystem = 2;
        readonly int maxBaseSystem = 20;
        readonly int decimalBaseSystem = 10;
        readonly char[] baseChars = new char[] { '0','1','2','3','4','5','6','7','8','9',
            'A','B','C','D','E','F','G','H','I'};

        public Converter(string inputString, int baseSystem)
        {
            CheckNullOrEmptyString(inputString);
            CheckMaxIntValue(inputString);
            CheckNegativeOfNonDigitString(inputString);
            _inputString = inputString;
            if (baseSystem < minBaseSystem || baseSystem > maxBaseSystem)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                _baseSystem = baseSystem;
            }
        }
        /// <summary>
        /// get input string and baseSystem and convert her in another сalculus system
        /// </summary>
        /// <returns> string in another calculus system</returns>
        public string ConvertToAnotherSystem()
        {
            string convertString = string.Empty;
            int inputNumber = int.Parse(_inputString);
            do
            {
                convertString = GetIntToString(inputNumber % _baseSystem) + convertString;
                inputNumber = inputNumber / _baseSystem;
            }
            while (inputNumber > 0);
            return convertString;
        }
        /// <summary>
        /// 
        ///convert int character to string
        /// </summary>
        /// <param name="baseSystem">char to convert</param>
        /// <returns> convert  string</returns>
        private string GetIntToString(int baseSystem)
        {

            if (baseSystem >= decimalBaseSystem)
            {
                return baseChars[baseSystem - decimalBaseSystem].ToString();
            }
            return baseSystem.ToString();
        }
        /// <summary>
        /// check input string which should not equal "null" 
        /// </summary>
        /// <param name="inputString"> input value</param>
        private void CheckNullOrEmptyString(string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
            {
                throw new ArgumentNullException();
            }

        }
        /// <summary>
        /// check maximal int value
        /// </summary>
        /// <param name="number"> input string</param>
        private void CheckMaxIntValue(string number)
        {
            int maxValue;
            if (!(int.TryParse(number, out maxValue)))
            {
                throw new OverflowException();
            }
        }
        /// <summary>
        /// check string
        /// </summary>
        /// <param name="number">input value</param>
        private void CheckNegativeOfNonDigitString(string number)
        {
            char[] array = number.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if ((i == 0 && array[i] == '-') || !(Char.IsDigit(array[i])))
                {
                    throw new FormatException();
                }
            }
        }
    }
}

