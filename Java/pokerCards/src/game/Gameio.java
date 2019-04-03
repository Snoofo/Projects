package game;

import java.util.ArrayList;
import java.util.Scanner;

/**
 * The input/output module for the game.
 * Controls all input validation and all output is
 * performed here. Currently output is set to the
 * standard output stream. (System.out)
 * 
 * @author snoof
 *
 */
public class Gameio {

	/**
	 * Displays a predefined menu options list showing the currently
	 * accepted inputs.
	 */
	private static void displayMenu() {
		String display = "******************\n"
				+ "Welcome to poker!\n"
				+ "*****************\n"
				+ "Please make a selection\n"
				+ "c - Show cards\n"
				+ "p - Play\n"
				+ "n - New game\n"
				+ "s - Shuffle\n"
				+ "r - Sort deck\n"
				+ "e - Exit\n";
		System.out.print(display);
	}
	
	/**
	 * Use to retrieve the users input. Will only accept values defined in
	 * the Gameio.validInput() method
	 * 
	 * @return returns a string of the players input.
	 */
	public static int getMenuInput() {
		String input = "";
		int result;
		Scanner sc = new Scanner(System.in);
		displayMenu();
		input = sc.next();
		while (!Gameio.validMenuInput(input)) {
			System.out.println("Invalid Entry!\n");
			displayMenu();
			input = sc.next();
		}
		switch(input) {
			case "c":
				result = 1;
				break;
			case "n":
				result = 2;
				break;
			case "p":
				result = 3;
				break;
			case "s":
				result = 4;
				break;
			case "r":
				result = 5;
				break;
			case "e":
				result = 6;
				break;
			default:
				result = -1;
		}
		return result;
	}

	/**
	 * Used to determine valid input during the menu phase.
	 * Currently accepts 'c', 'p', 'n', 's', 'r' and 'e'.
	 * @param input
	 * @return
	 */
	private static boolean validMenuInput(String input) {
		if (input.equalsIgnoreCase("c") || input.equalsIgnoreCase("p")
				|| input.equalsIgnoreCase("n") || input.equalsIgnoreCase("s")
				|| input.equalsIgnoreCase("r") || input.equalsIgnoreCase("e")) {
			return true;
		}
		return false;
	}
	
	/**
	 * Retrieves input from user and returns a value between 1-3 depending
	 * on the users input.
	 * 
	 * @return an integer between 1-3 corresponding to the matching input char
	 */
	public static int getTurnInput() {
		String input = "";
		int result;
		Scanner sc = new Scanner(System.in);
		displayTurnChoice();
		input = sc.next();
		while (!Gameio.validTurnInput(input)) {
			System.out.println("Invalid Entry!\n");
			displayTurnChoice();
			input = sc.next();
		}
		switch(input.toLowerCase()) {
			case "b":
				result = 1;
				break;
			case "c":
				result = 2;
				break;
			case "f":
				result = 3;
				break;
			default:
				result = -1;
		}
		return result;
	}

	private static void displayTurnChoice() {
		String display = "Bet (b), Check (c) or Fold (f)? ";
		System.out.print(display);
	}

	/**
	 * Used to determine valid input during the turn phase.
	 * Currently accepts 'b', 'c' and 'f'.
	 * 
	 * @param input a string taken from user input
	 * @return true if input is valid, false otherwise.
	 */
	private static boolean validTurnInput(String input) {
		if (input.equalsIgnoreCase("b") || input.equalsIgnoreCase("c")
				|| input.equalsIgnoreCase("f")) {
			return true;
		}
		return false;
	}

	public static void displayDeck(Table table) {
		System.out.println(table.getDeck().toString());
	}

	public static void displayShuffle() {
		System.out.println("Shuffling....\n");
	}

	public static void displaySorting() {
		System.out.println("Sorting deck....\n");
	}

	public static void displayHand(Hand hand) {
		String display = "Your hand:\n";
		for (int i = 0; i < hand.size(); ++i) {
			display += "[" + hand.getCard(i) + "]";
			if (i < hand.size()-1) {
				display += " ";
			}
		}
		System.out.println(display + "\n");
	}

	public static void displayInsufficentDeckSize(int size) {
		System.out.println("There are only " + "cards left in the deck!");
	}

	public static void displayCardsRemaining(int size) {
		System.out.println("There are " + "cards remaining");
	}

	public static void displayTable(Table table) {
		displayFlop(table.getFlop());
	}

	public static void displayFlop(ArrayList<Card> hand) {
		String display = "\nDeal: ";
		for (int i = 0; i < hand.size(); ++i) {
			display += "[" + hand.get(i) + "]";
			if (i < hand.size()-1) {
				display += " ";
			}
		}
		System.out.println(display + "\n");
	}

	public static void getBet() {
		System.out.println("Get bet");
	}

	public static void checkBet() {
		System.out.println("Check bet");
	}

	public static void fold() {
		System.out.println("Folding...");
	}

	public static boolean stillPlaying() {
		String input = "";
		Scanner sc = new Scanner(System.in);
		System.out.println("Do you want to deal again? ");
		input = sc.next();
		if (input.toLowerCase().equals("y")) {
			return true;
		}
		return false;
	}

	public static void displayScore(int score, String name) {
		System.out.println(name + "'s score is " + score);
	}
}
