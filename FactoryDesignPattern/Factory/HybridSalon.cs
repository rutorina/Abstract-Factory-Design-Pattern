using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class HybridHairCut : AHairCut
    {
        public override void show()
        {
            listBox.Items.Add("HybridHairCut was created successfully");
        }
        public override void MakeService(int newLength)
        {
            listBox.Items.Add($"HybridHairCut was performed, new length - {newLength}");
        }
    }

    public class HybridStyling : AStyling
    {
        public override void show()
        {
            listBox.Items.Add("HybridStyling was created successfully");
        }
        public override void MakeService(string newStyle)
        {
            listBox.Items.Add($"HybridStyling was performed, new style - {newStyle}");
        }
    }

    public class HybridHairCare : AHairCare
    {
        public override void show()
        {
            listBox.Items.Add("HybridHairCare was created successfully");
        }
        public override void MakeService(string procedure)
        {
            listBox.Items.Add($"HybridHairCare procedyre{procedure} was performed");
        }
    }

    class HybridSalon : ABeautyShop
    {
        public override AHairCut CreateHairCut()
        {
            return new HybridHairCut();
        }

        public override AStyling CreateStyling()
        {
            return new HybridStyling();
        }

        public override AHairCare CreateHairCare()
        {
            return new HybridHairCare();
        }
    }
}
