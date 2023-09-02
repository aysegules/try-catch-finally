using System.Linq.Expressions;

internal class Program
{
    public static void Main(string[] args)
    {
        try//Hataya sebebiyet verme ihtimali olan kod bloklarini buraya yaziyoruz.
        {
            Console.WriteLine("Bir sayi giriniz:");
            int sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmis oldugunuz sayi:"+sayi);
        }
        catch (Exception ex)//Hata ile karsilasildiginda ne yapilacagini buraya yaziyoruz.
        {
            Console.WriteLine("Hata: "+ex.Message);
        }
        finally//Hata olsun veya olmasin mutlaka yapilmasini istedigimiz islemleri buraya yaziyoruz.
        {
            Console.WriteLine("İslem tamamlandi.");
        }

        try
        {
           //int a=int.Parse(null); //ArgumentException 
           //int b=int.Parse("test");//FormatException
           int c=int.Parse("-20000000000");//OverFlowException
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Bos deger girdiniz.");
            Console.WriteLine(ex.Message);
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Veri tipi uygun degil.");
            Console.WriteLine(ex.Message);
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("Cok kucuk ya da cok buyuk bir deger girdiniz.");
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Islem tamamlandi.");
        }
    }
}