/*
 * Stefan Mazaleigue
 * A text adventure game
 * 09/2016
 */

import java.util.ArrayList;

import javax.swing.JOptionPane;

public class Game {
	public static void main(String[] args){
		
		//declare variables
		String input;
		char inputChar = 0;
		int roomCount = 0;
		boolean running = true;
		ArrayList<Room> rooms = new ArrayList<Room>(10);
		rooms.add(new Room("The room"));

		JOptionPane.showMessageDialog(null, "Welcome to the dungeon ");
		input = JOptionPane.showInputDialog(null, "Enter your characters name:");
		Player player = new Player(input);
		JOptionPane.showMessageDialog(null, "As you enter the dungeon,"
				+ " a sense of darkness surrounds you...");
		
		while (running){
			input = JOptionPane.showInputDialog(null, rooms.get(roomCount).description() + "\nLook out! "
					+ "A " + rooms.get(roomCount).getMonsters() + " are coming at you!\nWhat do you do?"
					+ "\nF - Fight monster(s)"
					+ "\nD - Run past monsters through the door (May take some damage)"
					+ "\nR - Run away! (Leave the dungeon)");
			try {
				inputChar = Character.toUpperCase(input.charAt(0));
			}
			catch (Exception e){
				System.out.println(e);
			}
			
			switch (inputChar){
			case 'F':
				player.fight(player, rooms.get(roomCount));
				break;
			case 'D':
				player.run();
				roomCount++;
				rooms.add(new Room(roomCount));
				break;
			case 'R':
				JOptionPane.showMessageDialog(null, "You flee the dungeon in fear,\n"
						+ "hoping that whatever horrors were in there never escape...");
				running = false;
				break;
			default:
				JOptionPane.showMessageDialog(null, "Please enter a valid response.");
			}
		}
	}

}
