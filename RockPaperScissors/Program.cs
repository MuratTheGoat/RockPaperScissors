/*
 * Created by SharpDevelop.
 * User: 0566353
 * Date: 3/12/2018
 * Time: 11:54 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace RockPaperScissors
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine(" Welcome to Rock, Paper, Scissors");
			Console.ReadLine();
			Console.WriteLine(" Make your choice:");
			gameFunc();
			Console.Write("Press any key to continue...");
			Cosnole.ReadKey(true);
		}
		
		public static void gameFunc()
		{
			Random rand = new Random
				
			string rock = "ROCK";
			string paper = "PAPER";
			string scissors = "SCISSORS";
			string choice = Console.ReadLine();
			
			int random = rand.Next( 1,4);
			choice = choice.ToUpper();
			
			switch (random)
			{
				case 1:
					if (choice == rock)
					{
						Console.WriteLine(choice + " <- you vs us ->" + rock + "./n");
						Console.WriteLine("It's a tie");
					}
					
				else if(choice == paper)
					{
						Console.WriteLine(choice + " <- you vs us ->" + rock + "./n");
						Console.WriteLine("You Win!");
					}
				else if (choice == scissors)
				{
						Console.WriteLine(choice + " <- you vs us ->" + rock + "./n");
						Console.WriteLine("You lose!");
				}
				
				else 
				{
					Console.WriteLine(choice + " IS NOT VALID.");
				}
				
				break;
				
			case 2:
				
				if (choice == paper)
					{
						Console.WriteLine(choice + " <- you vs us ->" + paper + "./n");
						Console.WriteLine("It's a tie");
					}
					
				else if(choice == rock)
					{
						Console.WriteLine(choice + " <- you vs us ->" + paper + "./n");
						Console.WriteLine("You Win!");
					}
				else if (choice == scissors)
				{
						Console.WriteLine(choice + " <- you vs us ->" + paper + "./n");
						Console.WriteLine("You lose!");
				}
				
				else 
				{
					Console.WriteLine(choice + " IS NOT VALID.");
				}
				
				break;
				
			default:
				
				if (choice == scissors)
					{
						Console.WriteLine(choice + " <- you vs us ->" + scissors + "./n");
						Console.WriteLine("It's a tie");
					}
					
				else if(choice == rock)
					{
						Console.WriteLine(choice + " <- you vs us ->" + scissors + "./n");
						Console.WriteLine("You Win!");
					}
				else if (choice == scissors)
				{
						Console.WriteLine(choice + " <- you vs us ->" + scissors + "./n");
						Console.WriteLine("You lose!");
				}
				
				else 
				{
					Console.WriteLine(choice + " IS NOT VALID.");
				}
				
				break;
				
			
				
		
			}
			
			Console.ReadLine();
			
		}
	}
}