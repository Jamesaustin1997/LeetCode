using System.Collections.Generic;

namespace LeetCode
{
    internal class RansomNote
    {

        /*
               Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

                Each letter in magazine can only be used once in ransomNote.

                Example 1:

                Input: ransomNote = "a", magazine = "b"
                Output: false
                Example 2:

                Input: ransomNote = "aa", magazine = "ab"
                Output: false
                Example 3:

                Input: ransomNote = "aa", magazine = "aab"
                Output: true 
         */


        public static void Main()
        {
            RansomNote ransomNote = new RansomNote();
            ransomNote.CanConstruct("aa", "aab");
        }

        public bool CanConstruct(string ransomNote, string magazine)
        {
            IDictionary<char, int> magazineMap = new Dictionary<char, int>();
            foreach (var c in magazine)
            {
                if (!magazineMap.ContainsKey(c))
                {
                    magazineMap[c] = 0;
                }

                magazineMap[c]++;
            }

            foreach (var rc in ransomNote)
            {
                if (!magazineMap.ContainsKey(rc) || magazineMap[rc] == 0)
                {
                    return false;
                }

                magazineMap[rc]--;
            }

            return true;
        }
    }
