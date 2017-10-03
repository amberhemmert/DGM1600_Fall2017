using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicalop : MonoBehaviour {

	public string luke = "Jedi";

	public string vader ="Sith";

	public bool leia =true;

	public string darkSide = "Darth Maul";

	public string lightSide = "Obi Wan";






	// Use this for initialization
	void Start () {
		// if(luke == "Jedi" &&  vader =="Nanny"){
		// 	print("Vaders yo Nanny");
		// }
		// else if (luke =="Jawa"&& vader =="Sith"){	
		// 	print("Utini!");
		// }
		// else if (luke=="Jedi" && vader == "Sith"){
		// 	print("Noooo! That's not true!");	
		// }	

		// else{
		// 	print("The End");
		// }	
	// 	if(leia){
	// 		print("No, there is another!");
	// 	}
	// 	else if (!leia){
	// 	print ("Hurray! Now I can date Luke");
	// 	}
	// 	else
	// 	print("Han fired first!");
	// 
		if(lightSide == "Obi Wan" || darkSide == "Jar Jar Binks"){
			print("Meeza Evil Sith Lord");	
		}
		else if (lightSide == "Boba Fett" || darkSide == "Darth Maul"){
			print("As you wish, my master");
		}
		else{
			print("Not the younglings!");
		}
	}	


	// // Update is called once per frame
	void Update () {
	}
}
