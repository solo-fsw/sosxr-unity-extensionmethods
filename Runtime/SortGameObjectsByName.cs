using System.Collections;
using UnityEngine;


namespace SOSXR.Extensions
{
    public class SortGameObjectsByName : IComparer
    {
        // Calls CaseInsensitiveComparer.Compare on the name string.
        int IComparer.Compare(object x, object y)
        {
            return new CaseInsensitiveComparer().Compare(((GameObject) x)?.name, ((GameObject) y)?.name);
        }
    }
}