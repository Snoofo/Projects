import javax.swing.JOptionPane;

public class Player extends Creature {

	public Player(String name) {
		super();
		this.name = name;
		this.maxHealth = 100;
		this.currentHP = this.maxHealth;
		this.attackPower = 10;
	}
	
	public void run(){
		double damage = super.getMaxHealth() / 5;
		double chance = 0.3;
		boolean hit = chance > Math.random() * 100;
		if (hit){
			super.currentHP -= (int)damage;
			JOptionPane.showMessageDialog(null, "A monsters lunges at you as you run past it,\n"
					+ "mauling the side of your back dealing 20% of your maximum life in damage!\n"
					+ "Entering the next room, you slam the door behind you...");
		}
		else {
			JOptionPane.showMessageDialog(null, "You run for door, narrowly escaping harm,\n"
					+ "enter the next room and slam the door behind you...");
		}
	}

	public void fight(Creature player, Room room) {
		
		
	}

}
