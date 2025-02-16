string[] bc = ["", "Taş", "Kağıt", "Makas"];
Console.WriteLine("Taş-Kağıt-Makas Oyununa Hoşgeldiniz!\n");
int pcPoints = 0;
int playerPoints = 0;
bool state = true;
while (state)
{
    try
    {
        if(pcPoints>=10)
        {
            Console.WriteLine("Bilgisayar Kazandı");
            state = false;
            break;
        }

        if (playerPoints>=10)
        {
            Console.WriteLine("Oyuncu Kazandı");
            state = false;
            break;
        }

        Console.WriteLine("\nBir Seçim Yapınız: \n\t0 - Çıkış\n\t1 - Taş\n\t2 - Kağıt\n\t3 - Makas");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input is < 0 or >= 4)
        {
            throw new Exception();
        }

        if (input == 0)
        {
            state = false;
            Console.WriteLine("\nOyundan Çıkış Yapıldı.");
            Console.WriteLine("Bilgisayar Puanı: {0}  -  Oyuncu Puanı: {1}", pcPoints, playerPoints);
            break;
            
        }
        Random random = new Random();
        int pcChoice = random.Next(1, 4);

        if (pcChoice == 1)
        {
            if (input == 2)
            {
                playerPoints++;
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("\nSiz Kazandınız!");
                Console.WriteLine("Bilgisayar Puanı: {0}  -  Oyuncu Puanı: {1}", pcPoints, playerPoints);
                Console.WriteLine("\nBilgisayarın Seçimi: {0}, Sizin Seçiminiz: {1} ", bc[pcChoice], bc[input]);
            }
            else if (input == 3)
            {
                pcPoints++;
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("\nBilgisayar Kazandı!");
                Console.WriteLine("Bilgisayar Puanı: {0}  -  Oyuncu Puanı: {1}",pcPoints,playerPoints);
                Console.WriteLine("\nBilgisayarın Seçimi: {0}, Sizin Seçiminiz: {1} ", bc[pcChoice], bc[input]);
            }
            else
            {
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("\nBerabere Kaldınız!");
                Console.WriteLine("Bilgisayar Puanı: {0}  -  Oyuncu Puanı: {1}", pcPoints, playerPoints);
                Console.WriteLine("\nBilgisayarın Seçimi: {0}, Sizin Seçiminiz: {1} ", bc[pcChoice], bc[input]);
            }
        }

        else if (pcChoice == 2)
        {
            if (input == 1)
            {
                pcPoints++;
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("\nBilgisayar Kazandı!");
                Console.WriteLine("Bilgisayar Puanı: {0}  -  Oyuncu Puanı: {1}", pcPoints, playerPoints);
                Console.WriteLine("\nBilgisayarın Seçimi: {0}, Sizin Seçiminiz: {1} ", bc[pcChoice], bc[input]);
            }
            else if (input == 3)
            {
                playerPoints++;
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("\nSiz Kazandınız!");
                Console.WriteLine("Bilgisayar Puanı: {0}  -  Oyuncu Puanı: {1}", pcPoints, playerPoints);
                Console.WriteLine("\nBilgisayarın Seçimi: {0}, Sizin Seçiminiz: {1} ", bc[pcChoice], bc[input]);
            }
            else
            {
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("\nBerabere Kaldınız!");
                Console.WriteLine("Bilgisayar Puanı: {0}  -  Oyuncu Puanı: {1}", pcPoints, playerPoints);
                Console.WriteLine("\nBilgisayarın Seçimi: {0}, Sizin Seçiminiz: {1} ", bc[pcChoice], bc[input]);
            }
        }
        else if (pcChoice == 3)
        {
            if (input == 1)
            {
                playerPoints++;
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("\nSiz Kazandınız!");
                Console.WriteLine("Bilgisayar Puanı: {0}  -  Oyuncu Puanı: {1}", pcPoints, playerPoints);
                Console.WriteLine("\nBilgisayarın Seçimi: {0}, Sizin Seçiminiz: {1} ", bc[pcChoice], bc[input]);
            }
            else if (input == 2)
            {
                pcPoints++;
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("\nBilgisayar Kazandı!");
                Console.WriteLine("Bilgisayar Puanı: {0}  -  Oyuncu Puanı: {1}", pcPoints, playerPoints);
                Console.WriteLine("\nBilgisayarın Seçimi: {0}, Sizin Seçiminiz: {1} ", bc[pcChoice], bc[input]);
            }
            else
            {
                Console.WriteLine("\n---------------------------------------------");
                Console.WriteLine("\nBerabere Kaldınız!");
                Console.WriteLine("Bilgisayar Puanı: {0}  -  Oyuncu Puanı: {1}", pcPoints, playerPoints);
                Console.WriteLine("\nBilgisayarın Seçimi: {0}, Sizin Seçiminiz: {1} ", bc[pcChoice], bc[input]);
            }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Yanlış Girdi Tekrar Deneyin.");
    }
}