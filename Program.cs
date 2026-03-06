using System;
RekeningBank newRekening = new RekeningBank("246810");

string pilihan;
double jumlah;

while (true)
{
    Console.Clear();

    Console.WriteLine("Selamat datang di ATM Moklet ");
    Console.WriteLine("1. Display Info Rekening");
    Console.WriteLine("2. Setor Uang");
    Console.WriteLine("3. Tarik Uang");
    Console.WriteLine("4. Keluar");
    Console.Write("Pilihan Anda: ");
    pilihan = Console.ReadLine();

    if (pilihan == "1")
    {
        newRekening.DisplayInfo();
    }
    else if (pilihan == "2")
    {
        Console.Write("\n Masukkan jumlah uang: Rp");
        jumlah = double.Parse(Console.ReadLine());

        newRekening.SetorUang(jumlah);
    }
    else if (pilihan == "3")
    {
        Console.Write("\n Masukkan jumlah uang yang ingin ditarik: Rp");
        jumlah = double.Parse(Console.ReadLine());

        newRekening.TarikUang(jumlah);
    }
    else if (pilihan == "4")
    {
        Console.WriteLine("Terima kasih telah menggunakan layanan ATM Moklet ");
        break;
    }
    else
    {
        Console.WriteLine("Pilihan anda salah");
    }

    Console.ReadLine();
}

public class RekeningBank
{
    private int _saldo;
    private string _noRekening;

    public double Saldo
    {
        get { return _saldo; }
        set
        {
            if (value >= 0) _saldo = (int)value;
            else Console.WriteLine("Nilai saldo tidak boleh negatif!!");
        }

    }

    public string NoRekening
    {
        get { return _noRekening; }
    }

    public RekeningBank(string norekening)
    {
        _saldo = 100000;
        _noRekening = norekening;
    }

    public void TarikUang(double jumlah)
    {
        if (jumlah > 0)
        {
            if (Saldo >= jumlah)
            {
                Saldo -= jumlah;
                Console.WriteLine("Berhasil tarik uang ");
            }
            else
            {
                Console.WriteLine("Saldo tidak mencukupi! ");
            }
        }
        else
        {
            Console.WriteLine("Jumlah uang tidak valid! ");
        }
    }

    public void SetorUang(double jumlah)
    {
        if (jumlah > 0)
        {
            Saldo += jumlah;
            Console.WriteLine("Berhasil setor uang ");
        }
        else
        {
            Console.WriteLine("Jumlah uang tidak valid! ");
        }


    }

    public void DisplayInfo()
    {
        Console.WriteLine("\n Display Info Rekening ");
        Console.WriteLine($"No. Rekening: {NoRekening} ");
        Console.WriteLine($"Saldo saat ini: Rp {Saldo} ");
    }
}