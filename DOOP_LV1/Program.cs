using System;

namespace DOOP_LV1
{
    class Program
    {
        static void Main(string[] args)
        {


            Notes  notes = new Notes();           Notes notes1 = new Notes("Biljeska", "Ivan",2);
            Notes notes2 = new Notes("biljeska2", "Ivo");
            notes2.setPertinence(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(notes.ToString());
            Console.WriteLine(notes1.ToString());
            Console.WriteLine(notes2.ToString());
            Console.WriteLine(notes.Author);
            Console.WriteLine(notes.Pertinence);
            Console.WriteLine(notes.Text);
            Console.WriteLine(notes1.Author);
            Console.WriteLine(notes1.Pertinence);
            Console.WriteLine(notes1.Text);
            Console.WriteLine(notes2.Author);
            Console.WriteLine(notes2.Pertinence);
            Console.WriteLine(notes2.Text);
            Notes time = new TimeNotes();
            Console.WriteLine(time.ToString());



        }
    }
}
