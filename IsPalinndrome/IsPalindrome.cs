public static class IsPalindrome
{
  public static void Main(char[] args) {
    Console.WriteLine(isPalindromeService.IsPalindrome(123));
    Console.WriteLine(isPalindromeService.IsPalindrome(121));
    Console.WriteLine(isPalindromeService.IsPalindrome(121));
  }

  public static bool IsPalindrome(int x)
  {
    if (x < 10)
    {
        return true;
    }

    if (x % 10 == 0)
    {
        return false;
    }

    int reversedHalf = 0;

    while (x > reversedHalf)
    {
        reversedHalf = reversedHalf * 10 + x % 10;
        x /= 10;
    }

    return x == reversedHalf / 10;
  } 
}