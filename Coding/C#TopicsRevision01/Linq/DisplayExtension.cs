namespace Linq
{
    internal static class DisplayExtension
    {
        public static void Display<T>(this IEnumerable<T> _item)
        {

            foreach (var item in _item)
            {
                Console.WriteLine(item);
            }
        }

    }
}
