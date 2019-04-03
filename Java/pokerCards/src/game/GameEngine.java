package game;

/**
 * The game engine where all the game logic is done.
 * Loops through the game while the game state is true.
 * @author snoof
 *
 */
public class GameEngine {
	
	/**
	 * Starts the game loop.
	 * Runs until the game objects playing state is set to false
	 * 
	 * @param game takes a previously instantiated game object
	 */
	public static void playGame(Game game) {

		int playersTurn = game.getPlayersTurn();
		int input;
		Table table = game.getTable();
		Deck deck = table.getDeck();
		
		table.dealFlop();
		deck.shuffle();
		table.deal();
		
		while (game.isPlaying()) {
			Gameio.displayTable(game.getTable());
			game.getPlayer(playersTurn).displayHand();
			input = Gameio.getTurnInput();
			
			if (input == 3) {
				Gameio.fold();
				game.setPlaying(false);
			}
			else {
				if (input == 1) {
					Gameio.getBet();
				}
				else if (input == 2){
					Gameio.checkBet();
				}
				if (table.isRiver()) {
					game.bestScore();
					game.setPlaying(false);
					game.decideWinner();
				}
				table.addToFlop();
			}
			// ask to play again
			if (!game.isPlaying()) {
				if (Gameio.stillPlaying()) {
					game = new Game();
					table = game.getTable();
					deck = table.getDeck();
					
					table.dealFlop();
					deck.shuffle();
					table.deal();
				};
			}
		}
	}
}

//switch(Gameio.getTurnInput()) {
//case 1:
//	Gameio.getBet();
//	if (table.isRiver()) {
//		game.setPlaying(false);
//		game.decideWinner();
//	}
//	table.addToFlop();
//	break;
//case 2:
//	Gameio.checkBet();
//	if (table.isRiver()) {
//		game.setPlaying(false);
//		game.decideWinner();
//	}
//	table.addToFlop();
//	break;
//case 3:
//	Gameio.fold();
//	game.setPlaying(false);
//}
