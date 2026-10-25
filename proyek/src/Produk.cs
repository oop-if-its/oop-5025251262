
namespace Proyek;

public abstract class Produk
{
    private string nama;
    private decimal harga;
    private int stok;

    public string Nama
    {
        get { return nama; }
    }

    public decimal Harga
    {
        get { return harga; }
    }

    public int Stok
    {
        get { return stok; }
    }

    protected Produk(string nama, decimal harga, int stok)
    {
        this.nama = nama;
        this.harga = harga;
        this.stok = stok;
    }

    public abstract decimal HitungHarga(int jumlah);
}
