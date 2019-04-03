package game;

/**
 * Class Game holds a Table object, an array of Players,
 * a Deck object and a control state of isPlaying.
 * Has a default number of players of 1 and keeps track
 * of players turn with a reference to the current players
 * index. The winner variable is also an index to the player
 * array.
 * @author snoof
 *
 */
public class Game {
	
	private Deck deck;
	private Player[] players;
	private Table table;
	private boolean playing = true;
	private int NUM_PLAYERS = 1;
	private int playersTurn = 0;
	private int winner;

	/*
	 * Default constructor: creates a 2 player, 52 card deck game
	 * and initializes a new table object.
	 */
	public Game() {
		deck = new Deck(false);
		deck.shuffle();
		players = new Player[NUM_PLAYERS];
		for (int i = 0; i < players.length; ++i) {
			this.players[i] = new Player();
		}
		table = new Table(players, deck);
	}

	/*
	 * Two arg constructor: creates a game with provided number of players
	 * and whether or not to include jokers
	 * 
	 * @param num int Number of players
	 * @param jokers boolean True to include jokers, False otherwise
	 */
	public Game(int num, int handSize, boolean jokers) {
		deck = new Deck(jokers);
		players = new Player[num];
		for (int i = 0; i < players.length; ++i) {
			this.players[i] = new Player();
		}
	}

//	/**
//	 * @return Returns the current state of the game's deck object
//	 */
//	public Deck getDeck() {
//		return deck;
//	}
//	
//	/*
//	 * @return Returns a newly instantiated deck with default no jokers
//	 */
//	public Deck newDeck() {
//		return new Deck(false);
//	}
//	
//	/**
//	 * Resets the current deck to a newly instantiated one
//	 */
//	public void resetDeck() {
//		this.deck = new Deck(false);
//	}
//
//	public void shuffle() {
//		this.deck.shuffle();
//	}
//
//	public void sortDeck() {
//		this.deck.sortDeck();
//	}

	/**
	 * Used to get a reference to the games Table object
	 * 
	 * @return the current state of the table
	 */
	public Table getTable() {
		return table;
	}

	/**
	 * @return Returns a boolean: True for running, False otherwise
	 */
	public boolean isPlaying() {
		return playing;
	}

	/**
	 * Sets whether the game is playing(true) or not(false)
	 * 
	 * @param flag True to indicate playing or False otherwise
	 */
	public void setPlaying(boolean flag) {
		this.playing = flag;
	}
	
	/**
	 * Used to get a player by players turn position. The value
	 * is converted to the index of that player.
	 * 
	 * @param player the player to return (index of +1)
	 * @return the player object of the given index -1
	 */
	public Player getPlayer(int player) {
		if (player < 1 || player > NUM_PLAYERS +1) {
			return players[0];
		}
		return players[player-1];
	}

	/**
	 * Used to get the current players turn.
	 * 
	 * @return the index of the current player +1 to represent
	 * a logical number
	 */
	public int getPlayersTurn() {
		return playersTurn+1;
	}

	/**
	 * Changes the players turn to the given index to the
	 * players array. If index does not exists, playersTurn is
	 * set to 0.
	 * 
	 * @param playersTurn an integer between 0 and number of players -1
	 */
	public void setPlayersTurn(int playersTurn) {
		if (playersTurn > NUM_PLAYERS || playersTurn < 0) {
			playersTurn = 0;
		}
		this.playersTurn = playersTurn-1;
	}

	// Implement for multiple player game...
	public void decideWinner() {
		winner = 0;
	}

	public void bestScore() {
		//
		int score = players[0].getHand().getScore(table.getFlop().toArray(new Card[table.getFlop().size()]));
		Gameio.displayScore(score, players[0].getName());
	}

}
