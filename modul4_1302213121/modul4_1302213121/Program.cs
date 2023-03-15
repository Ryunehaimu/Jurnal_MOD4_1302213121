// See https://aka.ms/new-console-template for more information
using modul4_1302213121;

public class Program
{
    static void Main()
    {
        Console.Write("Buah Memiliki Kode");
        Console.WriteLine(Kode_Buah.getkodebuah(Kode_Buah.buah.Apel));
        Console.Write("Buah Memiliki Kode");
        Console.WriteLine(Kode_Buah.getkodebuah(Kode_Buah.buah.Paprika));

        PosisiKarakterGame posisi = new PosisiKarakterGame();
        Console.WriteLine(posisi.currentStat);
        if (posisi.currentStat == PosisiKarakterGame.posisi.Berdiri)
        {
            Console.WriteLine("posisi standby");
        } else if (posisi.currentStat == PosisiKarakterGame.posisi.Tengkurap){
            Console.WriteLine("posisi istirahat");
        }
        posisi.activateTrigger_1302213121(PosisiKarakterGame.Trigger.Tombol_S);
        posisi.activateTrigger_1302213121(PosisiKarakterGame.Trigger.Tombol_S);
        if (posisi.currentStat == PosisiKarakterGame.posisi.Berdiri)
        {
            Console.WriteLine("posisi standby");
        }
        else if (posisi.currentStat == PosisiKarakterGame.posisi.Tengkurap){
            Console.WriteLine("posisi istirahat");
        }
    }
}

