using System.Text;

namespace Builder
{
    internal class Bread
    {
        public Flour Flour { get; set; }
        public Salt Salt { get; set; }
        public Additives Additives { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (Flour != null)
                stringBuilder.Append(Flour.Sort + "\n");
            
            if (Salt != null)
                stringBuilder.Append("Соль \n");
            
            if (Additives != null)
                stringBuilder.Append("Добавки: " + Additives.Name + " \n");

            return stringBuilder.ToString();
        }
    }
}