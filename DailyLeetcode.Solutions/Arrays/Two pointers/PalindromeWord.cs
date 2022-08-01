namespace DailyLeetcode.Solutions
{
    public static class PalindromeWord
    {
        public static bool IsPalindrome(string word)
        {
            int left = 0, right = word.Length - 1;

            while (left < right)
                if (word[left--] != word[right--])
                    return false;

            return true;
        }
    }
}
