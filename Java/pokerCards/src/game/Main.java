package game;

public class Main {

	public static void main(String args[]) {
		
		// Set the state of the game object
		Game game = new Game();
		Table table = game.getTable();
		boolean running = true;
		while (running) {
			switch (Gameio.getMenuInput()) {
			case 1:
				Gameio.displayDeck(table);
				break;
			case 2:
				game.getTable().resetDeck();
				break;
			case 3:
				// Starts the game engine
				game = new Game();
				GameEngine.playGame(game);
				break;
			case 4:
				Gameio.displayShuffle();
				table.shuffle();
				break;
			case 5:
				Gameio.displaySorting();
				table.sortDeck();
				break;
			case 6:
				running = false;
				break;
			}
		}
		
	}
}
