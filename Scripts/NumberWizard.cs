using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
	
	void Start () {
		StartGame();
		}
	void StartGame() {
		max = 1000;
		min = 1;
		guess=500;
		
		print("================================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head but do not tell me");
		
		print ("The highest number you can choose is " +max);
		print ("The lowest number you can choose is " +min);
		
		print ("Is the number higher or lower than ?"+ guess);
		print("Up = higher, down = lower, return = equal");
		max= max + 1;
		}
	
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
		// print("up arrow pressed");
		min= guess;
		NextGuess();
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
		print("down arrow pressed");
		max=guess;
		NextGuess();
    	}
    	if (Input.GetKeyDown(KeyCode.Return)) {
    	print("Ha! I figured it out");
    	StartGame();
    	}
    }
	void NextGuess(){
		guess= (max+min)/2;
		print("higher or lower than "+ guess);
		print("Up = higher, down = lower, return = equal");
		}
	}