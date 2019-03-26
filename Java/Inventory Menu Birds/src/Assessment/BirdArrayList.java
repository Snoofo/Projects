
package Assessment;
import java.util.*;
import javax.swing.JOptionPane;

/**
 * <h1>Assessment 33126/06 Part 1</h1>
 * <p>
 * Generates an array of strings which can be viewed and modified.
 * 
 * @author Stefan Mazaleigue
 */
public class BirdArrayList {

	/**
	 * Runs the bird menu options and methods calls.
	 *
	 * @param args	not used.
	 */
	// 
	public static void main(String[] args) {

		// Declare data fields
		ArrayList<String> birdArray = newBirdArray();
		char response = ' ';
		String answer = "";
		
		do {
			// Menu selection
			answer = JOptionPane.showInputDialog(null, "- Menu Selection -"
					+ "\nPlease enter one of the following:"
					+ "\nS - Search for a bird"
					+ "\nA - Add a bird"
					+ "\nR - Remove a bird"
					+ "\nD - Display all birds"
					+ "\nQ - Quit",
					"Bird Collection Manager", JOptionPane.INFORMATION_MESSAGE);

			// Check for valid input
			try {
				if (Character.isLetter(answer.charAt(0))){
					response = Character.toUpperCase(answer.charAt(0));
					// Invokes method that matches user input
					switch (response){
						case 'S':
							searchArray(birdArray);
							break;
						case 'A':
							addToArray(birdArray);
							break;
						case 'R':
							deleteEntry(birdArray);
							break;
						case 'D':
							displayArray(birdArray);
							break;
						default:
							answer = "";
					}
				}
			}
			// Allow program to continue if user presses cancel button
			catch (NullPointerException e){
				System.out.println(e);
			}
			// Allow program to continue if user enter no value
			catch (StringIndexOutOfBoundsException e){
				System.out.println(e);
			}
		} while (response != 'Q');
	}

	/**
	 * Creates a new array of strings of length 5.
	 *
	 * @return ArrayList	An array of strings.
	 */
	private static ArrayList<String> newBirdArray() {
//		I added this in case it was meant to be an empty array of 5, wasn't sure
//		ArrayList<String> birdArray = new ArrayList<String>(5);
		ArrayList<String> birdArray = new ArrayList<String>(5);
		birdArray.add("Hawk");
		birdArray.add("Cockatoo");
		birdArray.add("Parrot");
		birdArray.add("Pigeon");
		birdArray.add("Kookaburra");
		return birdArray;
	}

	/**
	 * Removes a bird from the array.
	 *
	 * @param array		The array you want to remove a string from.
	 */
	private static void deleteEntry(ArrayList<String> array) {
		// Set window label
		String windowTitle = "\tBird Removal";
		// Check array is not empty
		if (array.size() > 0){
			boolean found = false;
			String answer = JOptionPane.showInputDialog(null, "Enter bird to delete",
					windowTitle, JOptionPane.INFORMATION_MESSAGE);
			// Check input is not empty before attempting to remove entry
			if (!answer.isEmpty()){
				char answerChar;
				// Check for matching name, ignoring case sensitivity
				for (int index = 0; index < array.size(); index++){
					if (answer.equalsIgnoreCase(array.get(index))){
						do {
							// Confirm deletion of string
						answer = JOptionPane.showInputDialog(null, "Are you sure you want to delete "
								+ array.get(index) + "?"
								+ "\nY to confirm or N to cancel",
								windowTitle, JOptionPane.QUESTION_MESSAGE);
						answerChar = Character.toUpperCase(answer.charAt(0));
						// Check if response is valid and to continue or cancel
						if (answerChar == 'Y'){
							array.remove(index);
							found = true;
						}
						else if (answerChar == 'N'){
							JOptionPane.showMessageDialog(null,"'" + array.get(index) + "' has not been removed",
									windowTitle, JOptionPane.INFORMATION_MESSAGE);
							found = true;
						}
						// Continue looping until valid answer is entered
						} while (answerChar != 'N' && answerChar != 'Y');
					}
				}

				if (found){
					displayArray(array);
				}
				else {
					JOptionPane.showMessageDialog(null, "That bird does not exist in the array",
							windowTitle , JOptionPane.WARNING_MESSAGE);
				}
			}
			else {
				JOptionPane.showMessageDialog(null, "No input detected",
						windowTitle , JOptionPane.WARNING_MESSAGE);
			}
		}
		else {
			JOptionPane.showMessageDialog(null, "The Bird collection is empty",
					windowTitle, JOptionPane.WARNING_MESSAGE);
		}
	}

	/**
	 * Adds a bird to the array.
	 *
	 * @param array		An array to add a string to.
	 */
	private static void addToArray(ArrayList<String> array) {
		// Set window label
		String windowTitle = "\tBird Entry";
		boolean valid = true;
		String answer = JOptionPane.showInputDialog(null, "Enter bird name:",
				windowTitle, JOptionPane.INFORMATION_MESSAGE);
		// Check input is not empty before adding entry
		if(!answer.isEmpty()){
			// Loop through all array elements to find match with input
			for (int index = 0; index < array.size(); index++){
				if (answer.equalsIgnoreCase(array.get(index))){
					JOptionPane.showMessageDialog(null, "That bird already exists!",
							windowTitle, JOptionPane.WARNING_MESSAGE);
					valid = false;
				}
			}
			if (valid){
				array.add(answer);
			}
		}
		else {
			JOptionPane.showMessageDialog(null, "No input was recorded",
					windowTitle, JOptionPane.WARNING_MESSAGE);
		}
		displayArray(array);
	}

	/**
	 * Searches an array for a matching string.
	 *
	 * @param array		An array of strings to be searched.
	 */
	// Searches for a bird in the array
	private static void searchArray(ArrayList<String> array) {
		// Set window label
		String windowTitle = "\tBird Finder";
		// Check array is not empty
		if (array.size() > 0){
			int mid, low = 0, high = array.size();
			String searchValue;
			String upperCaseValue;
			boolean found = false;
			searchValue = JOptionPane.showInputDialog(null, "Enter bird to search for:",
					windowTitle, JOptionPane.INFORMATION_MESSAGE);
			// Sort array if it has more than one element
			if (array.size() > 1){
			Collections.sort(array);
			}
			// Perform a binary search for a string in the array
			while (!found){
				mid = (high + low) / 2;
				searchValue = searchValue.toUpperCase();
				upperCaseValue = array.get(mid).toUpperCase();
				if (searchValue.compareTo(upperCaseValue) == 0){
					JOptionPane.showMessageDialog(null, "'"+ array.get(mid)
						+ "' was found at index " + mid,
						windowTitle, JOptionPane.INFORMATION_MESSAGE);
					found = true;
				}
				else {
					if (high - low < 2) {
						JOptionPane.showMessageDialog(null,"'" + searchValue + "' was not found.",
								windowTitle, JOptionPane.INFORMATION_MESSAGE);
						found = true;
					}
					else {
						if(searchValue.compareTo(upperCaseValue) > 0){
							low = mid;
						}
						else {
							high = mid;
						}
					}
				}
			}
		}
		else {
			// Show message if array is empty
			JOptionPane.showMessageDialog(null, "The Bird collection is empty",
					windowTitle, JOptionPane.WARNING_MESSAGE);
		}
	}

	/**
	 * Displays all strings in an array.
	 *
	 * @param array		An array of strings to be displayed.
	 */
	// Displays a list of strings in a message box
	private static void displayArray(ArrayList<String> array) {
		// Set window label
		String windowTitle = "\tBird Collection";
		// Check array is not empty
		if (array.size() > 0){
			String output = "";
			int numbering = 1;
			for (String name: array){
				if (name != null){
					// Concatenate each entry found
					output += numbering + " - " + name + "\n";
					numbering++;
				}
			}
			// Display complete list of strings in the array
			JOptionPane.showMessageDialog(null, " - List of all birds -\n" + output,
					windowTitle, JOptionPane.INFORMATION_MESSAGE);
		}
		else {
			// Display message if list is empty
			JOptionPane.showMessageDialog(null, "The Bird collection is empty",
					windowTitle, JOptionPane.WARNING_MESSAGE);
		}
	}
}
