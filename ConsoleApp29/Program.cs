using ConsoleApp29.data;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            coursedbcontext coursedbcontext = new coursedbcontext();
            coursedbcontext.Database.Migrate();

        }
    }
}