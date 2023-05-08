using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.App.LiskovSubstitutionPrincipalBad
{
    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Has Called");
        }
        public abstract void TakePhoto();
    }

    public class IPhone : BasePhone
    {
        public override void TakePhoto()
        {
            Console.WriteLine("Taked Photo.");
        }
    }    
    public class Nokia : BasePhone
    {
        public override void TakePhoto()
        {
            throw new NotImplementedException();
        }
    }
}
