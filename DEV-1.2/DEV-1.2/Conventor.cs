﻿

namespace DEV_1._2
{
    class Conventor
    {
        private string _inputString;
        private int _baseSystem;

        public Conventor(string inputString, int baseSystem)
        {
            _inputString = inputString;
            _baseSystem = baseSystem;
        }
        public string ConvertToAnotherSystem()
        {
            string result = string.Empty;
            int number = int.Parse(_inputString);
            do
            {
                result = GetSystemMoreThanTen(number % _baseSystem) + result;
                number = number / _baseSystem;

            }
            while (number > 0);
            return result;
        }
        private string GetSystemMoreThanTen(int baseSystem)
        {
            char[] baseChars = new char[] { '0','1','2','3','4','5','6','7','8','9',
            'A','B','C','D','E','F','G','H','I'};
            if ( baseSystem >= 10)
            {
                return baseChars[baseSystem - 10].ToString();
            }
            return baseSystem.ToString();
        }
   
    }
}