using System.Collections.Generic;
using System.Text;
public static class Helpers{
    public static string ToString<T>(this IList<T> list, string joinString)
    {
        StringBuilder sb = new StringBuilder();
        foreach(T t in list){
            sb.Append(t.ToString() + joinString);
        }
        return sb.ToString();
    }
}