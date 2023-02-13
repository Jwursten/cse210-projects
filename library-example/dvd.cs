public class DVD : Loanable
{
     private string _barcode;
    private string _title;
    private string _genre;
    
    public DVD(string title, string barcode, string genre)
    {
        _title = title;
        _barcode = barcode;
        _genre = genre;
    }

    public void ShowDVDDetails()
    {
        Console.WriteLine($"{_title}: {_genre} {_barcode}");
    }
}