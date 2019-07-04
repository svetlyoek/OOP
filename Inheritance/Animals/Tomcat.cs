namespace Animals
{
    public class Tomcat : Cat
    {
        private const string tomcat = "male";
        public Tomcat(string name, int age)
            : base(name, age, tomcat)
        {
        }

        public override string ProduceSound()
        {
            return "MEOW";
        }


    }
}
