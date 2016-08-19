using System.Collections;

namespace TelerikTest
{
    public static class IListExtensions
    {
        public static bool IsEmpty (this IList list)
        {
            return list == null || list.Count == 0;
        }
    }
}

