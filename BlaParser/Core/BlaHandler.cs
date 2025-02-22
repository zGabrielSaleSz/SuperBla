using BlaParser.Model;
using System.Text;

namespace BlaParser.Core
{
    public static class BlaHandler
    {
        public static string ConcatenateBla(int amount)
        {
            if (amount == 0)
            {
                return BlaConstants.BLA;
            }
            StringBuilder builder = new StringBuilder();
            builder.Append(BlaConstants.BLA);
            for (int i = 0; i < amount; i++)
            {
                builder.Append(BlaConstants.BLA);
            }
            return builder.ToString();
        }

        public static int TakeBlaAmount(string row)
        {
            if (string.IsNullOrEmpty(row))
            { 
                throw new Exception($"Invalid {BlaConstants.BLA}");
            }
            return (row.Length / 3) - 1;
        }
    }
}
