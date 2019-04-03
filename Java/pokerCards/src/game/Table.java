package game;

import java.util.ArrayList;
import java.util.Arrays;

/**
 * Class table holds a deck object, an ArrayList of Cards and
 * a reference to players in game. Has a default hand size of 2
 * and flop size of 3.
 * @author snoof
 *
 */
public class Table {

	private int HAND_SIZE = 2; //Default hand size
	private int MAX_FLOP = 5;
	private int FLOP_SIZE = 3;
	private Player[] players;
	private Deck deck;
	private ArrayList<Card> flop = new ArrayList<Card>(); //Cards to be dealt
	
	/**
	 * Constructor for a table object. Takes a primitive array of Players
	 * and a Deck object.
	 * 
	 * @param players a primitive array of Player objects
	 * @param deck an previously instantiated Deck object
	 */
	public Table(Player[] players, Deck deck) {
		this.players = players;
		this.deck = deck;
	}

	/*
	 * Deals a new hand to all the players
	 */
	public void deal() {
		for (int i = 0; i < players.length; ++i) {
			this.players[i].dealHand(deck.getHand(HAND_SIZE));
		}
	}
	
	/**
	 * Used to get the current deck of the calling table.
	 * 
	 * @return the current deck object
	 */
	public Deck getDeck() {
		return deck;
	}
	
	/*
	 * @return Returns a newly instantiated deck with default no jokers
	 */
	public Deck newDeck() {
		return new Deck(false);
	}
	
	/**
	 * Resets the current deck to a newly instantiated one
	 */
	public void resetDeck() {
		this.deck = new Deck(false);
	}

	public void shuffle() {
		this.deck.shuffle();
	}

	public void sortDeck() {
		this.deck.sortDeck();
	}
	
	/**
	 * Used to get the currently dealt cards on the table.
	 * 
	 * @return an ArrayList of type Card of cards on the table
	 */
	public ArrayList<Card> getFlop() {
		return flop;
	}

	/**
	 * Instantiates the flop ArrayList with new ArrayList of type
	 * Card with default size of 3.
	 */
	public void dealFlop() {
		this.flop = new ArrayList<Card>(Arrays.asList(this.deck.getHand(FLOP_SIZE)));
	}

	public void addToFlop() {
		this.flop.addAll(Arrays.asList(this.deck.getHand(1)));
	}

	public boolean isRiver() {
		return this.flop.size() >= MAX_FLOP ? true : false;
	}
}
