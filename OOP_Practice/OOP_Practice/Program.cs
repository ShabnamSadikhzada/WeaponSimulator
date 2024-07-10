using OOP_Practice.Models;

namespace OOP_Practice;

public class Program
{
    static void Main(string[] args)
    {
        Gun gun = new Gun("ak47", -5, 100, 2);
        //gun.Avtomat(5);
        gun.TektekAtis(5);

    }
}
