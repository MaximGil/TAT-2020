using System;

namespace DEV_1
{
    public class SequenceLength
    {
        private string _inputString;


        public SequenceLength(string inputString)
        {
            if (inputString == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                _inputString = inputString;
            }
        }
        /// <summary>
        /// Get the maximum character count
        /// </summary>
        /// <returns> Maximal sequence count </returns>
        public int SequenceGetCounter()
        {
            int max = 0;
            int i = 0;
            char[] symbols = _inputString.ToCharArray();
            while (i < symbols.Length)
            {

                int sequenceLength = GetSequenceLength(i, symbols);
                if (sequenceLength > max)
                    max = sequenceLength;

                i += sequenceLength;
            }
            return max;
        }

        public override string ToString()
        {
            return $"Max sequence is : {SequenceGetCounter()}";
        }
        /// <summary>
        ///    Get the number of consecutive non-identical characters
        /// </summary>
        /// <param name="from"></param>
        /// <param name="symbols"></param>
        /// <returns></returns>
        public int GetSequenceLength(int from, char[] symbols)
        {
            int count = 1;
            char target = symbols[from];

            for (int i = from + 1; i < symbols.Length; i++)
            {
                if (target != symbols[i])
                    count++;
                else
                {
                    return count;
                }
            }
            return count;
        }
    }
}
