using System;

namespace Chess
{
	class Program
	{
		static void Main(string[] args)
		{
			char[,] board = new char[8,8];
		}

		static bool ChoiceOfFigure(int figureToInt, string coordinatesFigureBefore, string coordinatesFigureAfter)
		{
			int sum = Math.Abs(coordinatesFigureAfter[0] - coordinatesFigureBefore[0]) + Math.Abs(coordinatesFigureAfter[1] - coordinatesFigureBefore[1]);
			switch (figureToInt)
			{
				case 1:
					return CheckingTheKingMovement(sum, coordinatesFigureBefore, coordinatesFigureAfter);
				case 2:
					return CheckingTheQueenMovement(sum, coordinatesFigureBefore, coordinatesFigureAfter);
				case 3:
					return CheckingTheRookMovement(coordinatesFigureBefore, coordinatesFigureAfter);
				case 4:
					return CheckingTheElephantMovement(sum, coordinatesFigureBefore, coordinatesFigureAfter);
				case 5:
					return CheckingTheHorseMovement(sum, coordinatesFigureBefore, coordinatesFigureAfter);
				case 6:
					return CheckingThePawnMovement(coordinatesFigureBefore, coordinatesFigureAfter);
				default:
					return false;
			}
		}


		static bool CheckingTheKingMovement(int sum, string coordinatesFigureBefore, string coordinatesFigureAfter)
		{
			return (sum == 1 || (Math.Abs(coordinatesFigureAfter[0] - coordinatesFigureBefore[0]) == 1 && Math.Abs(coordinatesFigureAfter[1] - coordinatesFigureBefore[1]) == 1));
		}

		static bool CheckingTheQueenMovement(int sum, string coordinatesFigureBefore, string coordinatesFigureAfter)
		{
			return (sum % 2 == 0 || coordinatesFigureAfter[0] == coordinatesFigureBefore[0] || coordinatesFigureAfter[1] == coordinatesFigureBefore[1]);
		}

		static bool CheckingTheRookMovement(string coordinatesFigureBefore, string coordinatesFigureAfter)
		{
			return (coordinatesFigureAfter[0] == coordinatesFigureBefore[0] || coordinatesFigureAfter[1] == coordinatesFigureBefore[1]);
		}

		static bool CheckingTheElephantMovement(int sum, string coordinatesFigureBefore, string coordinatesFigureAfter)
		{
			return (sum % 2 == 0 && (coordinatesFigureAfter[0] - coordinatesFigureBefore[0]) != 0 && (coordinatesFigureAfter[1] - coordinatesFigureBefore[1]) != 0);
		}

		static bool CheckingTheHorseMovement(int sum, string coordinatesFigureBefore, string coordinatesFigureAfter)
		{
			return (sum == 3 && (coordinatesFigureAfter[0] - coordinatesFigureBefore[0]) != 0 && (coordinatesFigureAfter[1] - coordinatesFigureBefore[1]) != 0);
		}

		static bool CheckingThePawnMovement(string coordinatesFigureBefore, string coordinatesFigureAfter)
		{
			int sum = coordinatesFigureAfter[1] - coordinatesFigureBefore[1];
			return ((coordinatesFigureBefore[0] == coordinatesFigureAfter[0]) && (sum == 1 || (coordinatesFigureBefore[1] == 50 && sum == 2)));
		}
	}
}
