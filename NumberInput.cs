class UserInputs { 

    public static string? SocialSecurityNumberInput() { 

        bool loop1 = true;
        while (loop1) {

            WriteLine("\n\n\t\tSkriv in ett Personnummer");
            Write("\t\tFormat (YYMMDD0000)\t");

            try {

                string? personNummerInput = ReadLine();

                if(!string.IsNullOrWhiteSpace(personNummerInput) && IsDigitsOnly(personNummerInput)) { 
                    
                    loop1 = false;
                    return personNummerInput;
                    
                }

                else { throw new FormatException(); }

            }

            catch (FormatException) {
                Clear();
                WriteLine("\n\n\t\tFelaktig Input! ange endast siffror.");

            }
        }
        return null;
            
    }

    public static bool IsDigitsOnly(string str) 
    {
        foreach (char c in str)
        {
            if (c < '0' || c > '9') { 
                return false; 
            }
        }

        return true;

    }

}