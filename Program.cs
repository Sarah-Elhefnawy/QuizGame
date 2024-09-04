namespace QuizGame
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] questions = new string[3]
			{
				"1. What is the capital of Italy?",
				"2. What is the red planet?",
				"3. What is the largest animal?"
			};

			string[] answers = new string[3]
			{
				"Rome",
				"Mars",
				"Whale"
			};

			int correctAnswers = 0;

			Console.WriteLine("Welcome to the game");
			Console.WriteLine("--------------------------");
			Console.WriteLine("Please answer the following questions: ");

			for (int i = 0; i < questions.Length; i++)
			{
				Console.WriteLine(questions[i]);

				string userAnswer = Console.ReadLine();
				try
				{
					bool result = IsTheAnswerCorrect(userAnswer, answers[i]);

					if (result)
					{
						Console.WriteLine("Correct answer!");
						correctAnswers++;
					}
					else
						Console.WriteLine($"Sorry, incorrect answer!. The correct answer is {answers[i]}");
				}
				catch(Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
				
			}

			Console.WriteLine("Quiz completed. Thank you for playing!!");
			Console.WriteLine($"Your score is {correctAnswers} of {questions.Length}");

		}

		private static bool IsTheAnswerCorrect(string userInput, string correctAnswer)
		{
			if (string.IsNullOrEmpty(userInput))
				throw new Exception("Answer can't be empty");

			if (userInput == correctAnswer)
				return true;
			else
			    return false;
		}
	}
}
