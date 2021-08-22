using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01Deneme
{
    public class user
    {
        public string username="";
        public string password="";
        private user()
        {

        }
        private static user[] instance = null;
        public static user[] instance_()
        {
            if (instance == null)
            {
                instance = new user[10];
                for (int i = 0; i < 10; i++)
                {
                    instance[i] = new user();
                    instance[i].username = "";
                    instance[i].password = "";
                }
            }
                return instance; 
            
        }

    }
}
