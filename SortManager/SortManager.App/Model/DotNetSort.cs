using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManager.App.Model;

public class DotNetSort : AbstractSort
{
    public override int[] SortArray(int[] array)
    {
        Array.Sort(array);

        return array;
    }
}