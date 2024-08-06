
namespace CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();

            cookie["name"] = "siva";

            Console.WriteLine(cookie["name"]);
        }
    }
}
