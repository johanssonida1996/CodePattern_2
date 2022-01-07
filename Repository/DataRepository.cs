using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Repository
{
    public class DataRepository: IDataRepository
    {
        public SimulatedDatabase Db { get; set; }
        public DataRepository()
        {
            Db = new SimulatedDatabase();
        }

        public string Load(string v)
        {
            return Db.Load(v);
        }

        public string GetAnimal()
        {
            return Db.GetAnimal();
        }

        public string GetCustomer()
        {
            return Db.GetCustomer();
        }

        public string GetData()
        {
            
            return Db.GetData();
        }

        public void Save(string data)
        {
            Db.Save(data);
        }
    }
}
