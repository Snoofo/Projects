import java.util.*;

// A game that is controlled by typing commands to the character to control the story

public class Run {

	public static void main(String[] args) {

		// System objects
		Scanner in = new Scanner(System.in);
		Random rand = new Random();
		
		// Enemy variables
		String[] enemies = {"Skeleton", "Zombie", "Warrior", "Diablo"};
		int maxEnemyHealth = 75;
		int maxEnemyAttack = 25;
		int monsterKills = 0;
		
		// Player variables
		final int MAX_HEALTH = 100; // Starting health
		int health = MAX_HEALTH;
		int attack = 50; // Players attack value
		int numHealthPots = 3;
		int healthPotHeal = 30;
		int healthPotDropChance = 50; // Percentage
		
		boolean running = true;
		
		System.out.println("Welcome to the Dungeon");
		
		// 
		GAME:
		while (running){
			System.out.println("--------------------------------------");
			
			// Instantiate enemy
			int enemyHealth = rand.nextInt(maxEnemyHealth);
			String enemy = enemies[rand.nextInt(enemies.length)];
			System.out.println("\t# A " + enemy + " has appeared! #\n");
			
			// Player choice menu
			while (enemyHealth > 0){
				System.out.println("\tYour HP: " + health);
				System.out.println("\t" + enemy + "'s HP: " + enemyHealth);
				System.out.println("\n\tWhat would you like to do?");
				System.out.println("\t1. Attack");
				System.out.println("\t2. Drink potion");
				System.out.println("\t3. Run");
				
				String input = in.nextLine();
				if (input.equalsIgnoreCase("1")){
					int damageDealt = rand.nextInt(attack);
					int damageTaken = rand.nextInt(maxEnemyAttack);
					
					enemyHealth -= damageDealt;
					health -= damageTaken;
					System.out.println("\t> You strike the " + enemy + " for "
							+ damageDealt + " damage.");
					System.out.println("\t> You received " + damageTaken + " in retaliation!");
					if (health < 1){
						System.out.println("\t> You've taken too much damage, you are too weak to go on!");
						break;
					}
				}
				else if (input.equals("2")){
					if (health < MAX_HEALTH){
						if (numHealthPots > 0){
							health += healthPotHeal;
							if (health > MAX_HEALTH){
								health = MAX_HEALTH;
							}
							numHealthPots-- ;
							System.out.println("\t> You drank a health pot, healing yourself for " + healthPotHeal + "."
									+ "\n\t> You now have " + health + " HP."
									+ "\n\t > You have " + numHealthPots + " health pots left.\n");
						}
						else {
							System.out.println("\t> You have no health pots left! Defeat enemies for a chance to get more");
						}
					}
					else {
						System.out.println("\t> You are at full HP. You don't need to use a health pot!\n");
					}
				}
				else if (input.equals("3")){
					System.out.println("\t> You run away from the " + enemy + "!");
					continue GAME;
				}
				else {
					System.out.println("\tInvalid command!");
				}
			}
			if (health < 1){
				System.out.println("\t> You limp out of the dungeon, weak from battle");
				break;
			}
			monsterKills++;
			System.out.println("--------------------------------------");
			System.out.println(" # " + enemy + " was defeated! #");
			System.out.println(" # You have " + health + " HP left. #");
			if (rand.nextInt(100) < healthPotDropChance){
				numHealthPots++ ;
				System.out.println(" # The " + enemy + " dropped a health pot! #"
						+ "\n # You now have " + numHealthPots + " health pot(s). #");
			}
			System.out.println("--------------------------------------");
			System.out.println("What would you like to do now?");
			System.out.println("1. Continue fighting");
			System.out.println("2. Exit dungeon");
			
			String input = in.nextLine();
			
			while (!input.equals("1") && !input.equals("2")){
				System.out.println("Invalid command!");
				input = in.nextLine();
			}
			
			if (input.equals("1")){
				System.out.println("You continue on your adventure!");
			}
			else {
				System.out.println("You exit the dungeon, successful from your adventure."
						+ "\nProud of the " + monsterKills + " monster(s) you slaughtered...");
				break;
			}
		}
		in.close();
		System.out.println("@@@@@@@@@@@@@@@@@@@@@@@@@");
		System.out.println("@@ THANKS FOR PLAYING! @@");
		System.out.println("@@@@@@@@@@@@@@@@@@@@@@@@@");
	}

}
