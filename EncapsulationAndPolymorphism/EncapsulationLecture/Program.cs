using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //PREGOVOR OT PONEDELNIK
            //What is inheritance? - Process na unasledqvane na danni. 
            //What is abstraction? - Razglejdame klas kato se abstrahirame ot izlishnite neshta i
            //izpolzwame samo vajnite neshta

            //Encapsulation - skrivane na danni. Modelirane na klasove po nachin koito skriva neshta koito ne sa nujni
            //Polymorphism - vseki klas ima nqkolko formi... kato List. What's the purpose?? - Za da izpolzvame edin klas zatova koeto ni trqbva

            ////14:17 zapochva pyyrvi slaid
            /// Encapsulation == hide(encapsulate) data behind constructors and properties
            /// All fields should be private. Its a good practice
            /// 
            //// Lets write some code
            /// 
            /// We wrote, so i take notes
            /// 
            /// List implementira IEnumerable, sledovatelno ako iskame da ne moje da se izpolzvat metodi 
            /// vyrhu opredelen list
            /// moje da vryshtame IEnumerable. Kolekciqta stava immutable 
            /// 
            /// 15:30 Polymorphism... Obektite sa mnogoformni basi princiole of OOP
            /// 
            /// Ima mnogo gotini neshta za preizpolzvane na kod chrez Polymorphism
            /// Razbrah abstraktnite klasove za kakvo sa
            /// 

            try
            {
                Person dankata = new Person(null, 26);
                Console.WriteLine(dankata);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }


        }
    }
}
