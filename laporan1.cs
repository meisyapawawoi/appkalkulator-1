using System;

//Declaration
//Bye Aldio
public class laporan
{
    string nama;
    string asal;
    string hobby;
    
    //declarasi dari class
    public laporan(string nama, string asal, string hobby)
    {
        this.nama = nama;
        this.asal = asal;
        this.hobby = hobby;
    }
    
    private string NewMethod()
    {
        return GetAsal();
    }
    
    
    //property 1
    public string GetNama()
    {
        return nama;
    }
    
    //property 2
    public string GetAsal()
    {
        return asal;
    }
    
    //property 3
    public string GetHobby()
    {
        return hobby;
    }
    
    
    //Method 1
    public string toString()
    {
        return "Haloo nama saya "+ this.GetAsal()
            + this.GetNama() + "\nhobby saya adalah dan umur saya adalah " + ", " + this.GetHobby();
    }
	 //Main Method
	 public static void Main(String[] args)
	 {
		 //creating object
		 laporan Aldio
		 = new laporan ("Aldio Rasmana Daeng Taleba", "palangkaraya", "touring" ); 
		 Console.WriteLine();
	 }
}