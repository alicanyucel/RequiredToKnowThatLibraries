using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.App.LiskovSubstitutionPrincipalGood
{
    public class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Has Called");
        }
    }
    public interface ITakePhoto
    {
        void TakePhoto();
    }

    public class IPhone : BasePhone, ITakePhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Taked Photo.");
        }
    }    
    public class Nokia : BasePhone
    {

    }
}
