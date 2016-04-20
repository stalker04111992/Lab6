using System;
using System.Windows.Forms;

namespace Project_2
{
    public static class Exten
    {
        public static int GetIntValue(this DataGridViewCell cell)
        {
            return Int32.Parse(cell.Value?.ToString().Replace("+","").Replace("*","") ?? "-1");
        }
    }
}