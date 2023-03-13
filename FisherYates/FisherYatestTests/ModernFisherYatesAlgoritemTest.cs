using FisherYatesLibrary;
using Xunit;

namespace FisherYatestTests
{

    public class ModernFisherYatesAlgoritemTest
    {
        [Fact]
        public void Shuffle_int() {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var sss = ModernFisherYatesAlgoritem.Shuffle<int>(array);
            Console.WriteLine("SHUFFLE: {0}", string.Join(",", array));
        }


        [Fact]
        public void shuffle_string()
        {
            string[] array2 = { "bird", "frog", "cat" };
            var sss = ModernFisherYatesAlgoritem.Shuffle<string>(array2);
            Console.WriteLine("SHUFFLE: {0}", string.Join(",", array2));
        }
    }
}
