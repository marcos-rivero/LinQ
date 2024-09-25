namespace Linq
{
    public static class ExtensionLinq
    {
        public static IEnumerable<T> Filtro<T>(this IEnumerable<T> source, Func<T, bool> predicado)
        {
            List<T> result = new List<T>();
            foreach(T item in source)
            {
                if (predicado(item))
                {
                    result.Add(item);
                }                
            }
            return result;
        }
    }
}
