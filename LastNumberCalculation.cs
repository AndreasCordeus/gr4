class LastNumberCalculation {

    public static bool ValidateSocialSecurityNumber(string personNummer) { 

        int sum = 0, d;
        string num = personNummer;
        int a = 0;

        for (int i = num.Length - 2; i >= 0; i--)
        {
            d = Convert.ToInt32(num.Substring(i, 1));

            if (a % 2 == 0) { d = d * 2; }

            if (d > 9) { d -= 9; }

            sum += d;
            a++;
        }

        if ((10 - ( sum % 10 ) == Convert.ToInt32(num.Substring(num.Length - 1)))) {

            // Clear();
            // WriteLine($"\n\n\t\tGiltigt Personnummer");
            
            // WriteLine($"\t\tSista siffran är: {(10 - ( sum % 10 ) % 10)}");
            return true;
        }

        else {
            // Clear();
            // WriteLine("\n\n\t\tFelaktigt Nummer!");
            return false;
        }
        
    }
    
}