package game;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.Map;

/**
 * Class Hand holds an ArrayList of type Card.
 * @author snoof
 *
 */

public class Hand {
	
	private static final int ROYAL_FLUSH = 100;
	private static final int STRAIGHT_FLUSH = 20;
	private static final int STRAIGHT = 5;
	private ArrayList<Card> cards = new ArrayList<Card>();
	
	/**
	 * Constructor for a hand object. Takes the given primative
	 * array and converts it to a new ArrayList of Card type.
	 * 
	 * @param hand an array of cards to create the hand
	 */
	public Hand(Card[] hand) {
		this.cards = new ArrayList<Card>(Arrays.asList(hand));
	}
	
	/**
	 * Inserts a card to the calling hand.
	 * 
	 * @param card a card object to be added to the hand
	 */
	public void addCard(Card card) {
		this.cards.add(card);
	}
	
	/**
	 * Gets a card at a given index in the hand.
	 * 
	 * @param idx the index for the card to return
	 * @return a reference to the card object at given index
	 */
	public Card getCard(int idx) {
		if (idx < 0 || idx >= cards.size()) {
			return null;
		}
		return cards.get(idx);
	}

	/**
	 * Removes a card from the calling hand at the given index.
	 * 
	 * @param idx index of the card to be removed
	 */
	public void remove(int idx) {
		cards.remove(idx);
	}
	
	/**
	 * Used to retrieve the size of the current hand
	 * 
	 * @return size of current hand
	 */
	public int size() {
		return cards.size();
	}
	
	
	public Card[] toArray() {
		return cards.toArray(new Card[cards.size()]);
	}

	/**
	 * Sets the logic in comparing two hands using standard
	 * poker rules. This decides the winning hand at the end of the game.
	 * It uses the Hand objects bestHand method to compare values.
	 * 
	 * @param hand2 the hand to compare the calling hand to.
	 * @return -1 if calling hand is lower value, 1 if calling
	 * hand is higher value and 0 if they are equal.
	 */
	public int compareTo(Hand hand2) {
		// TODO Auto-generated method stub
		return 0;
	}
	
	/**
	 * Used to evaluate the score of a hand. Takes a primitive array
	 * of Card objects to add to the calling hand to create a final hand
	 * to score. Follows standard poker hand rankings from a pair to
	 * Royal Flush. Scores are only based on a number higher than the
	 * next lowest hand. i.e. there is no pattern to the points returned.
	 * 
	 * @param deal an array of Card objects to be added
	 * @return the score based on hand only to be used in the compareTo
	 * method
	 */
	public int getScore(Card[] deal) {
		
		// Create a new ArrayList for the final hand
		ArrayList<Card> finalHand = new ArrayList<Card>();
		finalHand.addAll(this.cards);
		finalHand.addAll(Arrays.asList(deal));
		// Sort the final hand
		Card.sortByFace(finalHand.toArray());
		
		int lastIndex = finalHand.size()-1;
		if (isStraight(finalHand)) {
			if (isFlush(finalHand)) {
				if (finalHand.get(0).getFace() == 10) {
					return ROYAL_FLUSH + finalHand.get(0).getSuit();
				}
				// Adds score to STRAIGHT_FLUSH based on suit (14 is the highest face value))
				return STRAIGHT_FLUSH + (finalHand.get(lastIndex).getSuit() *14);
			}
			// Adds score to STRAIGHT base on face value of highest card
			return STRAIGHT + finalHand.get(lastIndex).getFace();// *finalHand.get(lastIndex).getSuit());
		}

		int count = 0;
		// fourOfaKind logic...
		Map<Integer, Integer> values = new HashMap<Integer, Integer>();
		int prev = 0;
		for (Card card: finalHand) {
			if (values.get(card.getFace()) == null ||
					values.get(card.getFace()) != prev) {
				values.put(card.getFace(), 1);
			}
			else {
				int add = values.get(card.getFace());
				values.replace(card.getFace(), add+1);
			}
			prev = values.get(card.getFace());
		}
		System.out.println(values);
//		int highest = 0;
//		for (Integer card : values.values()) {
//			if (card)
//		}
		return count;
	}

	/**
	 * Checks if all cards are the same suit
	 * @param hand
	 * @return
	 */
	private boolean isFlush(ArrayList<Card> hand) {
		// TODO Auto-generated method stub
		return false;
	}

	private boolean isStraight(ArrayList<Card> hand) {
		// TODO Auto-generated method stub
		return false;
	}
}
