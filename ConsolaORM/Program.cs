using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaORM
{
    class Program
    {
        static void Main(string[] args)
        {
            using(mibdEntities bd= new mibdEntities())
            {
                var lista = bd.persona;

                foreach(var p in lista)
                {
                    Console.WriteLine(p.nombre);
                }
                Console.WriteLine("----------------");

                /*sexo s = new sexo();
                s.nombresexo = "no definido";
                bd.sexo.Add(s);
                bd.SaveChanges();
                Console.WriteLine("llego");*/

                /*persona per = new persona();
                per.nombre = "Lucia";
                per.edad = 18;
                per.idsexo = 2;
                bd.persona.Add(per);
                bd.SaveChanges();
                Console.WriteLine("llego");*/


                //var ps = bd.persona.All(n => n.nombre == "pepito");

                persona ps = bd.persona.Where(n => n.nombre == "pepito").First();
                /*ps.edad = 20;
                bd.Entry(ps).State = System.Data.Entity.EntityState.Modified;  editar
                bd.persona.Remove(ps);
                bd.SaveChanges();*/


                Console.WriteLine(ps.edad);

            }
            Console.Read();
        }
    }
}
