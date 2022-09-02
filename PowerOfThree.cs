namespace LeetCode
{
    /*
        Given an integer n, return true if it is a power of three. Otherwise, return false.

        An integer n is a power of three, if there exists an integer x such that n == 3x.

        Example 1:

        Input: n = 27
        Output: true
        Explanation: 27 = 33
        Example 2:

        Input: n = 0
        Output: false
        Explanation: There is no x where 3x = 0.
        Example 3:

        Input: n = -1
        Output: false
        Explanation: There is no x where 3x = (-1). 
     */

    internal class PowerOfThree
    {
        public static void Main()
        {
            PowerOfThree solution = new PowerOfThree();
            solution.IsPowerOfThree(16);
        }
        public bool IsPowerOfThree(int n)
        {
            decimal number = n;
            while (number / 3 >= 1)
            {
                number = number / 3;
            }
            if (number == 1m) return true;
            return false;
        }
    }
}
