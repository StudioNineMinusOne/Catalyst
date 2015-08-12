using System;

namespace Catalyst
{
	public class Game
	{
		private string userInput;
		private string[] inputSplit;

		//Every room in the game's number
		private enum room{
			Start = 0,
			//the following rooms will be used for testing
			WestOfStart = 1,
			NorthOfStart = 2,
			NorthWestOfStart = 3
		}

		//Data type that will hold player information
		private struct player{
			public room playerRoom; 
		}


		public Game (){
			//
		}

		void gameLoop(){
			//start of game loop
			while (true) {
				
			}//end of game loop
		}

		private void processUserInput(){
			inputSplit = userInput.Split ();
		}
	}
}

