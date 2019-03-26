
public class Creature {

	protected int maxHealth, attackPower;
	protected int currentHP;
	protected String name = "Unknown";
	
	public Creature(){}

	public Creature(String name, int maxHealth, int attack){
		this.name = name;
		this.attackPower = attack;
		this.maxHealth = maxHealth;
		this.currentHP = maxHealth;
	}
	
	public void setName(String name){
		this.name = name;
	}
	
	public String getName() {
		return name;
	}

	public int getMaxHealth() {
		return maxHealth;
	}
	
	public int getCurrentHP() {
		return currentHP;
	}
	
	public void setCurrentHP(int HP) {
		this.currentHP = HP;
	}
}
