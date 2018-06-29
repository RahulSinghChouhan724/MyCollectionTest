using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MycollectionTest
{
    public class Person
    {
        public string UserId { get; set; }
        public string Pname { get; set; }
        public int Age { get; set; }
        public int RollNo { get; set; }
    }
   
    //use when you have to pass value to other vaiable of other function.
    /*
{
    get { return UserId; }
    set { UserId = value; }
}

public string PName
{
    get { return PName; }
    set { PName = value; }
}
public int RollNo        {
    get { return RollNo; }
    set { RollNo = value; }
}
public int Age
{
    get { return Age; }
    set { Age = value; }
}
*/

}

