using System;

namespace Quiz
{
	class Program
	{
		static void Main(string[] args)
		{
			var totalScore = 0;
			var Incorrect = 0;

			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("---------SIMPLE MULTIPLE CHOICE QUIZ GAME-----------");
			Console.WriteLine("---------MAKE SURE YOU ANSWER ALL THE QUESTIONS-----");
			Console.WriteLine("----------------------------------------------------");

			Console.WriteLine("Student Name: ");
			var name = Console.ReadLine();
			Console.WriteLine("Student Number: ");
			var number = Console.ReadLine();

			// Q1
			Console.Write("To answer the question type A,B,C," + "\n");
			Console.WriteLine("----------------------------------------------------");
			Console.Write("1. What has to be broken before you can use it?\n");
			Console.WriteLine("A. Glow Stick");
			Console.WriteLine("B. An Egg");
			Console.WriteLine("C. Can of Coke");
			Console.WriteLine("----------------------------------------------------");

			var entry1 = Console.ReadLine();

			if (entry1 == "B" || entry1 == "b")
			{
				totalScore += 1;
			}
			else
			{
				Incorrect += 1;
			}

			// Q2
			Console.WriteLine("----------------------------------------------------");
			Console.Write("2. What is always in front of you but can’t be seen?\n");
			Console.WriteLine("A. The Future");
			Console.WriteLine("B. A Ghost");
			Console.WriteLine("C. Internet");
			Console.WriteLine("----------------------------------------------------");


			var entry2 = Console.ReadLine();

			if (entry2 == "A" || entry2 == "a")
			{
				totalScore += 1;
			}
			else
			{
				Incorrect += 1;
			}

			// Q3
			Console.WriteLine("----------------------------------------------------");
			Console.Write("3. What gets wet while drying?\n");
			Console.WriteLine("A. Dishes");
			Console.WriteLine("B. A Car");
			Console.WriteLine("C. A Towel");
			Console.WriteLine("----------------------------------------------------");


			var entry3 = Console.ReadLine();

			if (entry3 == "C" || entry3 == "c")
			{
				totalScore += 1;
			}
			else
			{
				Incorrect += 1;
			}

			// Q4
			Console.WriteLine("----------------------------------------------------");
			Console.Write("4.  The more of this there is, the less you see. What is it?\n");
			Console.WriteLine("A. Dust");
			Console.WriteLine("B. Fog");
			Console.WriteLine("C. Darkness");
			Console.WriteLine("----------------------------------------------------");


			var entry4 = Console.ReadLine();

			if (entry4 == "C" || entry4 == "c")
			{
				totalScore += 1;
			}
			else
			{
				Incorrect += 1;
			}

			// Q5
			Console.WriteLine("----------------------------------------------------");
			Console.Write("5.What invention lets you look right through a wall? \n");
			Console.WriteLine("A. A Door");
			Console.WriteLine("B. A Window");
			Console.WriteLine("C. A Sliding Door");
			Console.WriteLine("----------------------------------------------------");


			var entry5 = Console.ReadLine();

			if (entry5 == "B" || entry5 == "b")
			{
				totalScore += 1;
			}
			else
			{
				Incorrect += 1;
			}


			// Q6
			Console.WriteLine("----------------------------------------------------");
			Console.Write("6. What has legs, but doesn’t walk?\n");
			Console.WriteLine("A. A Chair");
			Console.WriteLine("B. A Table");
			Console.WriteLine("C. A Snake");
			Console.WriteLine("----------------------------------------------------");


			var entry6 = Console.ReadLine();

			if (entry6 == "B" || entry6 == "b")
			{
				totalScore += 1;
			}
			else
			{
				Incorrect += 1;
			}

			// Q7
			Console.WriteLine("----------------------------------------------------");
			Console.Write("7. What runs all around a backyard, yet never moves\n");
			Console.WriteLine("A. A Wall");
			Console.WriteLine("B. A Fence");
			Console.WriteLine("C. A Pot");
			Console.WriteLine("----------------------------------------------------");


			var entry7 = Console.ReadLine();

			if (entry7 == "B" || entry7 == "b")
			{
				totalScore += 1;
			}
			else
			{
				Incorrect += 1;
			}

			// Q8
			Console.WriteLine("----------------------------------------------------");
			Console.Write("8. What building has the most stories?\n");
			Console.WriteLine("A. A Library");
			Console.WriteLine("B. The leaning tower of Piza");
			Console.WriteLine("C. The Murj Khalifa building");
			Console.WriteLine("----------------------------------------------------");


			var entry8 = Console.ReadLine();

			if (entry8 == "A" || entry8 == "a")
			{
				totalScore += 1;
			}
			else
			{
				Incorrect += 1;
			}

			// Q9
			Console.WriteLine("----------------------------------------------------");
			Console.Write("9. There is a tree on the mountain WHAT is his name?\n");
			Console.WriteLine("A. Tree");
			Console.WriteLine("B. Oak Tree");
			Console.WriteLine("C. What");
			Console.WriteLine("----------------------------------------------------");


			var entry9 = Console.ReadLine();

			if (entry9 == "C" || entry9 == "c")
			{
				totalScore += 1;
			}
			else
			{
				Incorrect += 1;
			}

			// Q10
			Console.WriteLine("----------------------------------------------------");
			Console.Write("10. What is 3/7 chicken, 2/3 cat and 2/4 goat?\n");
			Console.WriteLine("A. Baby Chicken");
			Console.WriteLine("B. Baby cat");
			Console.WriteLine("C. Chicago");
			Console.WriteLine("----------------------------------------------------");


			var entry10 = Console.ReadLine();

			if (entry10 == "C" || entry10 == "c")
			{
				totalScore += 1;
			}
			else
			{
				Incorrect += 1;
			}

			Console.WriteLine("Student Name: " + name);
			Console.WriteLine("Student Number: " + number);
			Console.Write("Number of questions correct: " + totalScore + "\n");
			Console.Write("Number of questions incorrect: " + Incorrect + "\n");
			Console.WriteLine("Thank you for taking this quizz");

		}
	}
}