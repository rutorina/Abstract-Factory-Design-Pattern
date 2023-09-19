using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryDesignPattern
{
    public abstract class AHairCut
    {
        public ListBox listBox;

        public abstract void show();
        public abstract void MakeService(int newLength);
    }

    public abstract class AStyling
    {
        public ListBox listBox;

        public abstract void show();
        public abstract void MakeService(string newStyle);
    }

    public abstract class AHairCare
    {
        public ListBox listBox;

        public abstract void show();
        public abstract void MakeService(string procedure);
    }

    public abstract class ABeautyShop
    { 
        public abstract AHairCut CreateHairCut();
        public abstract AStyling CreateStyling();
        public abstract AHairCare CreateHairCare();
    }
}
