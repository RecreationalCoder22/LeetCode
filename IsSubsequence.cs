

namespace susequence
{


    class IsSubsequence
    {
        /// ACCEPTED BUT TIME COMPLEXITY IS VERY BAD 
        public  static bool IsSubsequence(string s, string t)
        {
            int j = 0;
            bool pos = false;
            if (s.Length > t.Length || (s=="" || t==""))
                return false;
            for (int i = 0; i < s.Length; i++)
            {
                pos = false;
                while (j < t.Length)
                {
                   
                    if (s[i] == t[j])
                    {
                        pos = true;
                        j++;
                        break;
                    }
                    j++;
                    
                }
                if (j == t.Length && pos == false)
                    return false;
           
            }
            return pos;
        }
        //ACCEPTED MUCH BETTER TIME COMPLEXITY
        public static bool IsSubsequence2(string s, string t)
        {
            int j = 0;

            if (s.Length > t.Length )
                return false;
            if (s == "")
                return true;
            for (int i = 0; i < t.Length && j<s.Length; i++)
            {
                if (t[j] == s[i])
                    j++;
            }
            return (j == t.Length);
        }
        static void Main(string[] args)
        {
            IsSubsequence("acb", "ahbgdc");
        }
    }
}
