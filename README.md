Grupp 4.

För att testa lokalt följ nedan steg:

1.  Använd Gitbash eller liknande för att klona ner projektet med kommando git clone https://github.com/AndreasCordeus/Gr4.git alternativt ladda ner Zip genom att trycka på den gröna "Code" rutan i github och Download Zip.
    Öppna mappen med Visual studio eller Visual studio code.
2. Programmet kommer säga att det saknas saker för att köra, välj bara "yes" i rutan nere i högra hörnet så byggs dessa delar.
3.  Kör programmet genom terminalen genom att skriva "Dotnet run".
4.  Programmet kommer nu i terminalen be dig skriva in ett personnummer för att sedan testa om det stämmer.

För att testa via docker följ nedan steg:
1. Använd gitbash eller liknande för att klona ner projektet, docker behöver även köras i bakgrunden.
2. I gitbash skriv: docker pull andreascordeus/gr4-docker
3. När nedladdningen är klar skriv docker images i Gitbash för att se att projektet finns.
4. För att nu kunna köra behöver man skriva in: winpty docker run -it andreascordeus/gr4-docker



Hur svenska personnummer fungerar:

Svenska personnummer har en kontrollsiffra som sista siffra alltså det som nummer 0 står för här: xxxxxx-xxx0 Denna siffra kan räknas ut genom att använda "Luhn-algoritmen" som funkar enligt nedan:

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

Git-actions körs på två olika personnummer, ett som är riktigt och ett som är falskt.
