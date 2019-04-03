package game;

/**
 * Class Player which holds a Hand object and the players name.
 * 
 * @author snoof
 *
 */
public class Player {
	
	private String name = "";
	private Hand hand;
	
	/**
	 * Default constructor with name Snoof
	 */
	public Player() {
		this.name = "Snoof";
	}
	
	public Player(String name) {
		this.name = name;
	}
	
	/**
	 * Sets the players hand to the given array of cards
	 * 
	 * @param cards an array of card objects to be set as the players hand
	 */
	public void dealHand(Card[] cards) {
		hand = new Hand(cards);
	}
	
	/**
	 * Gets the calling players hand.
	 * 
	 * @return a reference to the players Hand object
	 */
	public Hand getHand() {
		return hand;
	}
	
	/**
	 * Gets the calling players name.
	 * 
	 * @return string of the players name
	 */
	public String getName() {
		return name;
	}
	
	
	/**
	 * Displays the players hand using the given Gameio module
	 */
	public void displayHand() {
		Gameio.displayHand(hand);
	}
	
	/**
	 * Adds a card to calling players hand.
	 * 
	 * @param card the card object to be added to the players hand.
	 */
	public void addCard(Card card) {
		hand.addCard(card);
	}
	
	/**
	 * Removes a card from the calling players hand at the given index.
	 * 
	 * @param idx the index of the card to remove. Constraint: > 0 and
	 * < hand.size() -1 
	 */
	public void removeCard(int idx) {
		if (idx >= 0 && idx < hand.size()) {
			hand.remove(idx);
		}
	}

	
	/**
	 * Creates a new array from the players current hand excluding the card at the given index
	 * of the current hand.
	 * 
	 * @param idx the index to the current hand array to be removed.
	 */
//	old version using primitive arrays for practice
//	public void removeCard(int idx) {
//		Card[] temp = new Card[hand.length-1];
//		for (int i = 0 ; i < hand.length; ++i) {
//			if (i == idx) {
//				++i;
//			}
//			temp[i] = hand[i];
//		}
//		hand = temp;
//	}
}
