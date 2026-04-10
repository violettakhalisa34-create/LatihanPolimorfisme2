Ewallet ewallet = new Ewallet();
KartuKredit kartuKredit = new KartuKredit();

Console.WriteLine("---simulasi Checkout---");
Console.WriteLine("pilhan metode :");
Console.WriteLine("1. Bank Transfer \n2. E-wallet \n3. kartu kredit");
Console.Write("Pilihan anda (1/2/3): ");
string pilihan = Console.ReadLine();

switch (pilihan)
{
    case "1":
        BankTransfer bankTransfer = new BankTransfer();
        bankTransfer.Bayar(100000);
        break;
    case "2":
        Ewallet eWallet = new Ewallet();
        ewallet.Bayar(100000);
        break;
    case "3":
        KartuKredit KartuKredit = new KartuKredit();
        ewallet.Bayar(100000);
        break;
    default:
        Console.WriteLine("Pilihan invalid!");
        break;
}

class MetodePembayaran
{
    public virtual void Bayar(int jumlah)
    {
        Console.WriteLine("Segera lakukan pembayaran sebesar Rp {jumlah}");
    }
}

class BankTransfer : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"silahkan transfer sejumlah {jumlah} ke nomer rekening 12345678");
    }
} 

class Ewallet : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"saldo terpotong sejumlah Rp {jumlah}");
    }
}

class KartuKredit : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Transfer sejumlah Rp {jumlah} berhasil dilakukan");
        base.Bayar(jumlah);
    }
}