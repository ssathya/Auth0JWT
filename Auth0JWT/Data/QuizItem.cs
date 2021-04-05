using System.Collections.Generic;

namespace Auth0JWT.Data
{
	public class QuizItem
    {
		public QuizItem() => Choices = new List<string>();
		public string Question { get; set; }
		public List<string> Choices { get; set; }
		public int AnswerIndex { get; set; }
		public int Score { get; set; }
	}
	
}
