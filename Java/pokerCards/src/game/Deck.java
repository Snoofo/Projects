package game;

import java.util.Random;
/**
 * Class representing a deck of cards. Uses a primitive array of
 * type Card with default size of 52 (standard playing card deck)
 * 
 * @author snoof
 *
 */
public class Deck {
	
	private Card[] cards;
	private boolean jokers = false;
	private int deckSize = 52;
	

	/**
	 * Creates a new deck object with default size of 52.
	 * All cards starting from 1 of Diamonds to Ace of Clubs.
	 * 
	 * @param joker True to include jokers: false to discard.
	 * If true, adds 2 jokers to the bottom of the deck
	 */
	public Deck(boolean joker) {
		if (joker) {
			jokers = true;
			deckSize += 2;
		}
		cards = new Card[deckSize];
		int suit = 0;
		int index = 0;
		while (suit < 4) {
			int face = 2;
			while (face <= 14) {
				cards[index] = new Card(suit, face);
				++face;
				++index;
			}
			++suit;
		}
		if (joker) {
			cards[52] = new Card(1, 0);
			cards[53] = new Card(3, 0);
		}
	}
	
	/**
	 * Shuffles the current deck. Creates a new empty array
	 * of size length of current deck.
	 * <p>
	 * Loops sequentially through current deck and randomly
	 * selects an index to fill the new array until it finds
	 * an empty element to set.
	 */
	public void shuffle() {
		Random rand = new Random();
		Card[] temp = new Card[cards.length];
		for (int i = 0; i < cards.length; ++i) {
			boolean empty = true;
			while (empty) {
				int index = rand.nextInt(cards.length);
				if (temp[index] == null) {
					temp[index] = cards[i];
					empty = false;
				}
			}
		}
		for (int i = 0; i < cards.length; ++i) {
			cards[i] = new Card(temp[i].getSuit(), temp[i].getFace());
		}
	}

	/**
	 * Sorts the deck from Diamonds, Hearts, Spades, Clubs 
	 */
	public void sortDeck() {
		Card.sortCards(cards);
	}
	/**
	 * @return Returns an integer of the current size of the deck
	 */
	public int deckSize() {
		return deckSize;
	}
	
	public String toString() {
		String string = "";
		for (int i = 1; i <= cards.length; ++i) {
			string += "[" + cards[i-1].toString() + "]";
			if (i % 5 == 0) {
				string += "\n";
			}
			else {
				string += " ";
			}
		}
		return string;
	}

	/**
	 * Used to get a given hand size from the deck.
	 * Takes the first x elements from the deck and
	 * sets the current deck to a new array without
	 * those elements.
	 * 
	 * @param size the size of the hand to return
	 * @return Returns an array of type Card of param size
	 */
	public Card[] getHand(int size) {
		if (cards.length < size) {
			Gameio.displayInsufficentDeckSize(cards.length);
			return null;
		}
		Card[] hand = new Card[size];
		for (int i = 0; i < size; ++i) {
			hand[i] = cards[i];
		}
		Card[] temp = new Card[cards.length - size];
		for (int i = 0; i < temp.length; ++i) {
			temp[i] = cards[i + size];
		}
		cards = temp;
		return hand;
	}

}
