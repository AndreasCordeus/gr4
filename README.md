Grupp 4.

För att testa lokalt följ nedan steg:

1.  Använd Gitbash eller liknande för att klona ner projektet med kommando git clone https://github.com/AndreasCordeus/Grupp4.git alternativt ladda ner Zip genom att trycka på den gröna "Code" rutan i github och Download Zip.
    Öppna mappen med Visual studio eller Visual studio code.
2.  Kör programmet genom terminalen genom att skriva "Dotnet run".
3.  Programmet kommer nu i terminalen be dig skriva in ett personnummer för att sedan testa om det stämmer.



Hur svenska personnummer fungerar:

Den näst sista siffran i ett svensk personnummer alltså: xxxxxx-xx0x där 0:an representerar den siffra bestämmer kön på personen. Är det ett jämnt nummer är personen en kvinna, ett udda nummer är personen en man.

Svenska personnummer har även en kontrollsiffra som sista siffra alltså det som nummer 0 står för här: xxxxxx-xxx0 Denna siffra kan räknas ut genom att använda "Luhn-algoritmen" som funkar enligt nedan:

Exempel för personnumret 811218-987f:

8 1 1 2 1 8 9 8 7
2 1 2 1 2 1 2 1 2
^ ^ ^ ^ ^ ^ ^ ^ ^ 
16 1 2 2 2 8 18 8 14

Produkterna ska sedan splittras upp och adderas.

(1+6)+1+2+2+2+8+(1+8)+8+(1+4) = 44 Siffrorna inom parantes är de som splittrats upp.

Denna summa subtraheras från närmast högre tiotal, eller från sig självt om den är jämnt delbar med 10. Detta kan beskrivas som en modulus 10-operation: (10 - (44 % 10)) % 10 = 6

Kontrollsiffran f är alltså 6 och hela personnumret blir 811218-9876.

Vårt program genomför kontrollen av kontrollsiffran genom att köra Luhn algoritmen på ett inmatat personnummer, är personnumret inte korrekt kommer programmet be dig att köra igen.