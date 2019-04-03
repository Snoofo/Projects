package game;

import java.util.ArrayList;

/**
 * Card class to replicate a card that has a face and a suit.
 * Default suits are 0 = Diamonds, 1 = Hearts, 2 = Spades and 3 = Clubs.
 * Face values start at 2 up to 14.
 * 2-10 represent themselves, 11 = Jack, 12 = Queen, 13 = King, 1 = Ace
 * 
 * @author snoof
 *
 */
public class Card {
	
	private int suit;
	private int face;
	// predefined 'enums' for suit values
	String[] suits = {"Diamonds", "Hearts", "Spades", "Clubs"};
	
	public Card(int suit, int face) {
		this.suit = suit;
		this.face = face;
	}

	public Card(int idx, int suit, int face) {
		
		this.suit = suit;
		this.face = face;
	}
	
	/**
	 * Used to get the suit value of the card object
	 * 
	 * @return an integer representing the suit
	 * 0 = Diamonds, 1 = Hearts, 2 = Spades and 3 = Clubs
	 */
	public int getSuit() {
		return suit;
	}
	
	/**
	 * Used to get the face value of the card object
	 * 
	 * @return an integer representing the face value.
	 * 2-10 represent themselves, 11 = Jack, 12 = Queen, 13 = King, 1 = Ace
	 */
	public int getFace() {
		return face;
	}

	/**
	 * Sorts the deck from Diamonds, Hearts, Spades, Clubs 
	 * using selection sort.
	 * 
	 * @param cards a primitive array of Card objects to sort
	 */
	public static void sortCards(Object[] cards) {
		int index = 1;
		while (index < cards.length) {
			Card temp = (Card)cards[index];
			int swap = index - 1;
			while (swap >= 0 && temp.compareTo((Card)cards[swap]) < 0) {
				cards[swap + 1] = cards[swap];
				--swap;
			}
			cards[swap + 1] = temp;
			++index;
		}
	}
	
	public static void sortByFace(Object[] finalHand) {

//		int index = 1;
//		while (index < finalHand.size()) {
//			Card temp = finalHand.get(index);
//			int swap = index - 1;
//			while (swap >= 0 && temp.compareToFace(finalHand.get(swap)) < 0) {
//				finalHand.set(swap +1, finalHand.get(swap));
//				--swap;
//			}
//			finalHand.set(swap + 1, temp);
//			++index;
//		}
		int index = 1;
		while (index < finalHand.length) {
			Card temp = (Card)finalHand[index];
			int swap = index - 1;
			while (swap >= 0 && temp.compareToFace((Card)finalHand[swap]) < 0) {
				finalHand[swap + 1] = finalHand[swap];
				--swap;
			}
			finalHand[swap + 1] = temp;
			++index;
		}
	}
	
	public String toString() {
		if (face > 10) {
			if (face == 11) {
				return "J of " + suits[suit];
			}
			if (face == 12) {
				return "Q of " + suits[suit];
			}
			if (face == 13) {
				return "K of " + suits[suit];
			}
			if (face == 14) {
				return "A of " + suits[suit];
			}
		}
		return face + " of " + suits[suit];
	}

	/**
	 * Overrides the Object.compareTo method to compare two cards.
	 * Compares the calling card to the parameter card and returns a value
	 * based on the calling card to the parameter.
	 * @param card supply a card object to compare the calling card object to.
	 * @return -1 if the calling card is smaller than the comparing card, 1 if
	 * the calling card is larger or 0 if they are equal
	 */
	
	public int compareTo(Card card) {
		if (this.suit < card.getSuit()) {
			return - 1;
		}
		else if (this.suit > card.getSuit()) {
			return 1;
		}
		else if (this.face < card.getFace()) {
			return - 1;
		}
		else if (this.face == card.getFace()) {
			return 0;
		}
		else
			return 1;
	}
	
	public int compareToFace(Card card) {
		if (this.face < card.getFace()) {
			return - 1;
		}
		else if (this.face == card.getFace()) {
			return 0;
		}
		else
			return 1;
	}
}
