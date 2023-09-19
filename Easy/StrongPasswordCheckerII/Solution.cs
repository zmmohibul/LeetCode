namespace StrongPasswordCheckerII;

public class Solution {
    public bool StrongPasswordCheckerII(string password) {
        if (password.Length < 8)
        {
            return false;
        }

        var specialChars = new HashSet<char>(){'!','@','#','$','%','^','&','*','(',')','-','+'};
        var hasLowercase = false;
        var hasUppercase = false;
        var hasDigits = false;
        var hasSpecialChar = false;

        for (int i = 0; i < password.Length; i++)
        {
            if (i < password.Length - 1 && password[i] == password[i + 1])
            {
                return false;
            }

            if (password[i] >= 'a' && password[i] <= 'z')
            {
                hasLowercase = true;
            }
            else if (password[i] >= 'A' && password[i] <= 'Z')
            {
                hasUppercase = true;
            }
            else if (password[i] >= '0' && password[i] <= '9')
            {
                hasDigits = true;
            }
            else if (specialChars.Contains(password[i]))
            {
                hasSpecialChar = true;
            }
        }
        
        return hasLowercase && hasUppercase && hasDigits && hasSpecialChar;
    }
}