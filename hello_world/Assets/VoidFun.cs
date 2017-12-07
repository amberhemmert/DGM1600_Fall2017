The void function does not return a value. 



10 Examples:


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidFun : MonoBehaviour {

public int laserBlast;

	// Use this for initialization
	void Start () {
	DeathStar(laserBlast);
	}

	
	// Update is called once per frame
	void Update () {
		
	}

	void DeathStar (int vent){
		print("That's no moon that's a space station");
		print(vent);
	if(vent == 1){
		print("Porkins misses his shot");
	}	
	else if(vent ==2 ){	
		print("Red leader tries run but is unsucessful");
	}
	else {
		print("Death star blows up");
	}
	}
}

public int laserBlast;

	// Use this for initialization
	void Start () {
	DeathStar(laserBlast);
	}

	
	// Update is called once per frame
	void Update () {
		
	}

	void DeathStar (int vent){
		print("That's no moon that's a space station");
		print(vent);
	if(vent == 1){
		print("Porkins misses his shot");
	}	
	else if(vent ==2 ){	
		print("Red leader tries run but is unsucessful");
	}
	else {
		print("Death star blows up");
	}
	}
}
