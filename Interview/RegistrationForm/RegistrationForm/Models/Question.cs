using System.Collections.Generic;

namespace RegistrationForm.Models
{
    public class Question
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int QuestionValueAnswerId { get; set; }

        public List<QuestionValue> QuestionValues { get; set; }
    }
}
