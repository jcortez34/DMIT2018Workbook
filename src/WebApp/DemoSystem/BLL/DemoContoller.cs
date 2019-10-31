using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoSystem.Entities;

namespace DemoSystem.BLL
{
    [DataObject]
    public class DemoContoller
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Person> ListPeople()
        {
            using (var context = new DemoContext())
            {
                return context.People.ToList();
            }
        }
    }
}
