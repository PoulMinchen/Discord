using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainin7
{
    class Program
    {
        static void Main(string[] args)
        {
            User up = new User();
            up[0] = new Name { namae = "Vasya" };
            up[2] = new Name { namae = "Jenya" };

            Name nam = up[0];
            Name nam2 = up[2];
            Console.WriteLine($"{nam?.namae} \n{nam2.namae}\n");

            Client cl = new Client();
            cl["Name"] = "Alice";
            cl["telnum"] = "+7-124-15-16-1";
            cl["email"] = "asma@gm.co";

            Console.WriteLine(cl.Name+" "+cl.telnum+" "+cl.email);
            Console.ReadLine();

        }
    }

    class Name
    {
        public string namae { get; set; }

    }

    class User
    {
        Name[] name;

        public int Age { get; set; }
        public User()
        {
            name = new Name[5];
        }
        public Name this[int index]
        {
            get
            {
                return name[index];
            }

            set
            {
                name[index] = value;
            }
        }

    }

    class Client
    {
        public string email { get; set; }
        public string Name { get; set; }
        public string telnum { get; set; }
        
        public string this[string prop]
        {
           get
            {
                switch(prop)
                {
                    case "Name": return "Mr/Mrs" + Name;
                    case "email":return email;
                    case "telnum":return telnum;
                    default:return null;


                }
            }

            set
            {
                switch (prop)
                {
                    case "Name": Name = value;break;
                    case "email": email=value;break;
                    case "telnum": telnum=value;break;
                    


                }
            }
        }

    }



}
