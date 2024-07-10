using System.ComponentModel;

namespace OOP_Practice.Models;

public class Gun
{
    public string _nov;
    public string Nov
    {
        get
        {
            return _nov;
        }
        set
        {
            _nov = value;
        }
    }
    public int _gulleTutumu;
    public int GulleTutumu
    {
        get
        {
            return _gulleTutumu;
        }
        set
        {
            if (value > 0)
                _gulleTutumu = value;
            else 
                Console.WriteLine("error");
        }
    }
    public int _movcudgulle;
    public int MovcudGulle
    {
        get
        {
            return _movcudgulle;
        }
        set
        {
            if (value > 0)
                _movcudgulle = value;
            else
                Console.WriteLine("error");
            
        }
    }
    public int _millisaniyedeGulle;
    public int MillisaniyedeGulle
    {
        get
        {
            return _millisaniyedeGulle;
        }
        set
        {
            if (value > 0)
                _millisaniyedeGulle = value;
            else
                Console.WriteLine("error");
        }
    }

    public Gun(string nov, int tutum, int movcud, int saniyede)
    {
        Nov = nov;
        GulleTutumu = tutum;
        MovcudGulle = movcud;
        MillisaniyedeGulle = saniyede;
    }

    public void TektekAtis (int atisSayi)
    {
        if(atisSayi < 0)
        {
            Console.WriteLine("duzgun daxil edin");
            return;
        }
        int tmpTutum = GulleTutumu;
        while (atisSayi > 0)
        {
            atisSayi--;
            GulleTutumu--;
            Console.WriteLine($"\natis yerine yetirildi\nQalan atis sayi: {atisSayi}\nQalan gulle sayi: {GulleTutumu}");
            if (GulleTutumu == 0)
            {
                Console.WriteLine("silahda gulle bitmisdir, yeniden doldurmaq ucun 'R'-ya basiniz");
                string s = Console.ReadLine();

                if(s.Substring(0,1).ToLower() == "r")
                {
                    Console.WriteLine("Qiymetler:\n1 denesi 3$\n5 denesi 10$\n10 denesi 15$");

                    Console.WriteLine("\nodenisi edin: ");
                    int dollar = Convert.ToInt32(Console.ReadLine());
                    int elaveGulle = 0;
                    if(dollar < 10)
                    {
                        while(dollar > 3)
                        {
                            elaveGulle++;
                            dollar -= 3;
                        }
                    }
                    else if (dollar < 15)
                    {
                        while (dollar > 10)
                        {
                            elaveGulle += 5;
                            dollar -= 10;
                        }
                    }
                    else 
                    {
                        while (dollar > 15)
                        {
                            elaveGulle += 10;
                            dollar -= 15;
                        }
                    }

                    GulleTutumu += elaveGulle;
                    Console.WriteLine($"\nsilah yeniden dolduruldu, +{elaveGulle} gulle\nQaliq pulunuz: {dollar}");
                    MovcudGulle -= GulleTutumu;
                }
            }

            if (MovcudGulle == 0)
            {
                Console.WriteLine("gullemiz bitmisdir");
            }
        }
    }

    public void Avtomat (int millisaniye)
    {
        int gulleSayi = millisaniye * MillisaniyedeGulle;
        TektekAtis(gulleSayi);
    }
}
