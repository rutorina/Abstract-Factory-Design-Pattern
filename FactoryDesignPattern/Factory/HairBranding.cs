using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{

    public class BrandingHairCut : AHairCut
    {
        public override void show()
        {
            listBox.Items.Add("BrandingHairCut was created successfully");
        }
        public override void MakeService(int newLength)
        {
            listBox.Items.Add($"BrandingHairCut was performed, new length - {newLength}");
        }
    }

    public class BrandingStyling : AStyling
    {
        public override void show()
        {
            listBox.Items.Add("BrandingStyling was created successfully");
        }
        public override void MakeService(string newStyle)
        {
            listBox.Items.Add($"BrandingStyling was performed, new style - {newStyle}");
        }
    }

    public class BrandingHairCare : AHairCare
    {
        public override void show()
        {
            listBox.Items.Add("BrandingHairCare was created successfully");
        }
        public override void MakeService(string procedure)
        {
            listBox.Items.Add($"BrandingHairCare procedyre{procedure} was performed");
        }
    }

    class HairBranding : ABeautyShop
    {
        public override AHairCut CreateHairCut()
        {
            return new BrandingHairCut();
        }

        public override AStyling CreateStyling()
        {
            return new BrandingStyling();
        }

        public override AHairCare CreateHairCare()
        {
            return new BrandingHairCare();
        }
    }
}
