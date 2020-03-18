

using System;

namespace DEV_1._2
{
    public class Converter
    {
        private string _inputString;
        private int _baseSystem;


        public Converter(string inputString, int baseSystem)
        {
            _inputString = inputString;
            _baseSystem = baseSystem;
        }
        /// <summary>
        /// get input string and baseSystem and convert her in another сalculus system
        /// </summary>
        /// <returns> string in another calculus system</returns>
        public string ConvertToAnotherSystem()
        {
            string result = string.Empty;
            int number = int.Parse(_inputString);
            CheckInputValues(_inputString, _baseSystem);
            do
            {

                result = GetIntToString(number % _baseSystem) + result;
                number = number / _baseSystem;

            }
            while (number > 0);
            return result;
        }
        /// <summary>
        /// 
        ///convert int character to string
        /// </summary>
        /// <param name="baseSystem">char to convert</param>
        /// <returns> convert  string</returns>
        private string GetIntToString(int baseSystem)
        {
            char[] baseChars = new char[] { '0','1','2','3','4','5','6','7','8','9',
            'A','B','C','D','E','F','G','H','I'};
            if (baseSystem >= 10)
            {
                return baseChars[baseSystem - 10].ToString();
            }
            return baseSystem.ToString();
        }
        /// <summary>
        /// check the input system which should be more than 20 and less than 2
        /// </summary>
        /// <param name="baseSystem">input baseSystem</param>
        private void ValidBaseSystem(int baseSystem)
        {
            if (baseSystem < 2 || baseSystem > 20)
            {
                throw new IndexOutOfRangeException();
            }
        }
        /// <summary>
        /// check input string which should not equal "null" 
        /// </summary>
        /// <param name="inputString"> input value</param>
        private void CheckNullString(string inputString)
        {

            if (inputString == null)
            {
                throw new ArgumentNullException();
            }
        }
        /// <summary>
        /// check input string which should not be an empty
        /// </summary>
        /// <param name="inputString">input value</param>
        private void CheckEmptyString(string inputString)
        {

            if (inputString == string.Empty)
            {
                throw new FormatException();
            }
        }
        /// <summary>
        /// check maximal int value
        /// </summary>
        /// <param name="number"> input string</param>
        private void MaxIntValue(string number)
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <param name="value"></param>
        private void CheckInputValues(string number, int value)
        {
            CheckNullString(number);
            CheckEmptyString(number);
            ValidBaseSystem(value);
            MaxIntValue(number);
            CheckNegativeOfNonDigitString(number);
        }
    }
}

