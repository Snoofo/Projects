import java.util.ArrayList;

public class Room {
	
	private String description = "There is a long, dark corridor with a door at the end.";
	private int numDoors = 1;
	int roomNumber = 0;
	int descMax = 4;

	private ArrayList<String> descriptions = new ArrayList<String>(descMax);
	private ArrayList<Creature> monsters = new ArrayList<Creature>();

	public Room() {
	}

	public Room(String desc) {
		description = desc;
		numDoors = (int)(1 + (Math.random() * 3));
	}

	public Room(int roomCount) {
		int randomDesc = (int)(1 + (Math.random() * descMax));
		description = descriptions.get(randomDesc);
		numDoors = (int)(1 + (Math.random() * 3));
		
	}

	public String description() {
		return description;
	}

	public int getNumDoors() {
		return numDoors;
	}
	
	public int getRoomNumber() {
		return roomNumber;
	}
	
	public String getMonsters(){
		String monsterDesc = "";
		int arrayLength = monsters.size();
		for (int i = 0; i < arrayLength; i++){
			monsterDesc += monsters.get(i).getName();
			if (i + 1 < arrayLength){
				monsterDesc += " and a ";
			}
		}
		return monsterDesc;
	}

}
