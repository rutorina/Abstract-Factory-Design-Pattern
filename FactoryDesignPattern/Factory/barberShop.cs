using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class BarberHairCut : AHairCut
    {
        public override void show()
        {
            listBox.Items.Add("BarberHairCut was created successfully");
        }
        public override void MakeService(int newLength)
        {
            listBox.Items.Add($"BarberHairCut was performed, new length - {newLength}");
        }
    }

    public class BarberStyling : AStyling
    {
        public override void show()
        {
            listBox.Items.Add("BarberStyling was created successfully");
        }
        public override void MakeService(string newStyle)
        {
            listBox.Items.Add($"BarberStyling was performed, new style - {newStyle}");
        }
    }

    public class BarberHairCare : AHairCare
    {
        public override void show()
        {
            listBox.Items.Add("BarberHaitCare was created successfully");
        }
        public override void MakeService(string procedure)
        {
            listBox.Items.Add($"BarberHairCare procedyre{procedure} was performed");
        }
    }

    class barberShop : ABeautyShop
    {
        public override AHairCut CreateHairCut()
        {
            return new BarberHairCut();
        }

        public override AStyling CreateStyling()
        {
            return new BarberStyling();
        }

        public override AHairCare CreateHairCare()
        {
            return new BarberHairCare();
        }
    }
}
