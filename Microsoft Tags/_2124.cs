namespace Microsoft_Tags;

public class _2124
{
    public bool CheckString(string s)
    {
        var aFound = false;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == 'a')
            {
                aFound = true;
                continue;
            }

            if (aFound && s[i]=='b')
            {
                return false;
            }
        }

        return true;
    }
}