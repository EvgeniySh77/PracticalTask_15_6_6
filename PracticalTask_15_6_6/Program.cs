namespace PracticalTask_15_6_6
{
	internal partial class Program
	{
		static void Main()
		{
			var classes = new[]
		   {
			   new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
			   new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
			   new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
		   };
			var allStudents = GetAllStudents(classes);

			Console.WriteLine(string.Join($" {Environment.NewLine}", allStudents));

			Console.ReadKey();
		}

		static string[] GetAllStudents(Classroom[] classes)
		{
			var allStudents = classes.SelectMany(c => c.Students).ToArray();

			return allStudents;
		}
	}	
}