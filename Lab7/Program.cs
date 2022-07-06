namespace Lab{
    class program{
        static void Main(String[] args){
             

             Animal [] grandAnimals = {new Dog(), new Frog(), new Cat(), new Kitten(), new Tomcat()};
             grandAnimals[0].name = "BigDog";
             grandAnimals[0].age = 6;
             grandAnimals[0].gender = "Male";

             grandAnimals[1].name = "Jumper";
             grandAnimals[1].age = 4;
             grandAnimals[1].gender = "Male";

             grandAnimals[2].name = "Alita";
             grandAnimals[2].age = 7;
             grandAnimals[2].gender = "Female";

             grandAnimals[3].name = "Manny";
             grandAnimals[3].age = 2;
             grandAnimals[3].gender = "Male";            

             grandAnimals[4].name = "Tom";
             grandAnimals[4].age = 8;
             grandAnimals[4].gender = "Male";


            foreach(Animal creature in grandAnimals){
                Console.WriteLine("Hey there, I'm " + creature.name + ", " + creature.age + " yrs old, and yeah I'm a " + creature.gender);
                creature.sound();
            }
        }

    }


    abstract class Animal{
       public string name = "";
        public  int age;
        public string gender= "";

        public virtual void sound() {

        } 
    }

    class Dog : Animal{
        override public void sound(){
            Console.WriteLine("Bark: woof, woof");
       }
    }

    class Frog : Animal{
        override public void sound(){
            Console.WriteLine("Ribbet Ribbet");
       }
    }

    class Cat : Animal{
        override public void sound(){
            Console.WriteLine("Meow Meow");
       }
    }

    class Kitten : Animal{
        override public void sound(){
            Console.WriteLine("purr prr");
       }
    }

    class Tomcat : Animal{
        override public void sound(){
            Console.WriteLine("Meooowww Meeeoowww");
       }
    }
}