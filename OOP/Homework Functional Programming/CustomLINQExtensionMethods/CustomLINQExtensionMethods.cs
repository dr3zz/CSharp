namespace CustomLINQExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public static class CustomLinqExtensionMethods
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var result = new List<T>();
            collection.ToList().ForEach(
                x =>
                {
                    if (!predicate(x))
                    {
                        result.Add(x);
                    }
                });
                        return result as IEnumerable<T>;
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count)
        {
            var result = collection.ToList();
            for (int i = 1; i < count; i++)
            {
                result.AddRange(collection);
            }

            return result as IEnumerable<T>;
        }

        public static IEnumerable<string> WhereEndsWith(
            this IEnumerable<string> collection,
            IEnumerable<string> suffixes)
        {
            var result = new List<string>();
            suffixes.ToList().ForEach(y =>
             {
                 collection.ToList().ForEach(x =>
                 {
                     if (x.EndsWith(y))
                     {
                         result.Add(x);
                     }
                 });
             });
            return result as IEnumerable<string>;
        }
    }
}