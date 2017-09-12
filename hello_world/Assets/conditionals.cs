using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditionals : MonoBehaviour {

public string stopLight = "Red";

void Start(){
	Main();
}
void Main(){

if(stopLight == "Red"){
	print("STOP! The light is Red!");
}
else if (stopLight == "Yellow"){
	print("Slow Down!)");
}
else if (stopLight == "Green"){
	print("Green means GO!");
}
else{
	print ("I don't know what you mean!");
}
}
}



