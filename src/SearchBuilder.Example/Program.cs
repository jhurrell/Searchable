using System;

namespace SearchBuilder.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have already defined PersonSearchBuilder and let the framework define the defaults. Let's instantiate
            // an instance of PersonSearchBuilder and start working with it.
            var personBuilder = new PersonSearchBuilder();

            // The first thing we will need to do, is display the list of properties on Person that a user can select
            // to begin building a search term. In a console application, we could display or in a web UI, we could 
            // build a <select><option> list.
            Console.WriteLine("Here are the properties that can be selected for search:");
            foreach (var property in personBuilder.Properties)
            {
                Console.WriteLine("\t{0,-25} or {1}", property.Name, property.DisplayName);
            }

            // Let's assume the user selected LastName. Now we need to display the operators the user can choose next.
            // Again, these can be just dumped to the user or in a web UI, used to build a <select><option> list.
            Console.WriteLine("Here are the opertors that can use used to search on LastName:");
            var supportedOperators = personBuilder["LastName"].Operators;
            foreach(var op in supportedOperators)
            {
                Console.WriteLine("\t{0,-25} or {1,-32} or {2}", op.Name, op.DisplayName, op.Symbol);
            }

            // 
            personBuilder["LastName"]["BeginsWith"].Values.Add("HE");

            // All done.
            Console.WriteLine("All done");
            Console.Read();
        }
    }
}
