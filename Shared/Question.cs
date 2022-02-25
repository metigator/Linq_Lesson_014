using System.Collections.Generic; 

namespace Shared
{
    public class Question
    { 
        public string Title { get; set; }
        public List<Choice> Choices { get; set; } = new(); 
        public int CorrectAnswer { get; set; }

        public int Marks { get; set; }

        public override string ToString()
        {
            var choices = "";

            foreach (var item in Choices)
            {
                choices += $"\n\t{item.Order}) {item.Description}";
            }

            return $"{Title} [{Marks} marks]" +
                   $"{choices}";


        }
    }
}
