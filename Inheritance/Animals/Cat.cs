using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, int age, string gender)
           : base(name, age, gender)
        {
        }

        public override string ProduceSound()
        {
            return "Meow meow";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.GetType().Name);
            sb.AppendLine(base.ToString());

            return sb.ToString().TrimEnd();
        }
    }
}
