using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Tournament421_SemenovaOlesya
{
    public static class Navigations
    {
        public static Frame MyFrame { get; set; }
        public static void Next(Page page)
        {
            MyFrame?.Navigate(page);
        }
        public static void Back()
        {
            if (MyFrame?.CanGoBack == true)
                MyFrame?.GoBack();
        }
    }
}

