using System;
using System.Globalization;
using modul8_1302220031;

internal class Program
{
    private static void Main(string[] args)
    {
        BankTransferConfig config = new BankTransferConfig().loadData();

        Console.WriteLine(config.lang);
        Console.WriteLine("Please insert the amount of money to transfer:");
        int money = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        if (config.transfer != 0)
        {
            if (uang <= 25000000)
            {
                Console.WriteLine("6500");
            }
            else
            {
                Console.WriteLine("15000");
            }
        }

        Console.WriteLine("Select transfer method:" + "\n");
        Console.WriteLine("1. RTO(real-time)");
        Console.WriteLine("2. SKN");
        Console.WriteLine("3. RTGS");
        Console.WriteLine("4. BI FAST");
        int methods = int.Parse(Console.ReadLine());

        Console.WriteLine("\n" + "Please type " + config.confirmation + " to confirm the transaction");
        string confirm = Console.ReadLine();
        if (confirm == "yes")
        {
            Console.WriteLine("Transfer is completed");
        }
        else {
            Console.WriteLine("Transfer is cancelled");
        }


        //Merubah Menjadi Bahasa Indonesia
        config.UbahBahasa();


        Console.WriteLine(config.lang);
        Console.WriteLine("Masukan jumlah uang yang akan di-transfer:");
        int uang = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        if (config.transfer != 0)
        {
            if (uang <= 25000000)
            {
                Console.WriteLine("6500");
            }
            else
            {
                Console.WriteLine("15000");
            }
        }

        Console.WriteLine("Pilih metode transfer:" + "\n");
        Console.WriteLine("1. RTO(real-time)");
        Console.WriteLine("2. SKN");
        Console.WriteLine("3. RTGS");
        Console.WriteLine("4. BI FAST");
        int metode = int.Parse(Console.ReadLine());

        Console.WriteLine("\n" + "Ketik " + config.confirmation + " untuk mengonfirmasi transaksi");
        string konfirmasi = Console.ReadLine();
        if (confirm == "ya")
        {
            Console.WriteLine("Proses transfer berhasil");
        }
        else
        {
            Console.WriteLine("Transfer dibatalkan");
        }
    }
}