using System.Collections.Generic;
using AngularJSDemo.Models;

namespace AngularJSDemo.Entities
{
    public class CarEntity
    {
        public IEnumerable<Car> Cars() => new List<Car>
        {
                {new Car() { ID = 1, Name = "玛莎拉蒂",Selected=false }},
                {new Car() { ID = 2, Name = "奔驰" ,Selected=false }},
                {new Car() { ID = 3, Name = "宝马" ,Selected=true }},
                {new Car() { ID = 4, Name = "保时捷",Selected=false  }}
        };
    }
}