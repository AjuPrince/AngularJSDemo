using System.Collections.Generic;
using AngularJSDemo.Models;

namespace AngularJSDemo.Entities
{
    public class MobilePhoneEntity
    {
        public IEnumerable<MobilePhone> MobilePhone =>
          new List<MobilePhone>
            {
                {new MobilePhone() { ID = 1, Name = "华为" }},
                {new MobilePhone() { ID = 2, Name = "苹果" }},
                {new MobilePhone() { ID = 3, Name = "小米" }},
                {new MobilePhone() { ID = 4, Name = "中兴" }}
            };
    }
}
