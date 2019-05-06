using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEntity
{
    public partial class Car
    {
        public override string ToString()
        {
            return string.Format("{0} is a {1} {2} with ID {3}",
                this.CarName ?? "**No Name**",
                this.Color, this.Make, this.CarID);
        }

        void OnCarNicknameChanging(global::System.String value)
        {
            Console.WriteLine("\t-> Changing name to: {0}", value);
        }

        void OnCarNicknameChanged()
        {
            Console.WriteLine("\t-> Name of car has been changed");
        }
    }    
}
