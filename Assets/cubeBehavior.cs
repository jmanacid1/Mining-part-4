using UnityEngine;
using System.Collections;

public class cubeBehavior : MonoBehaviour {
	public GameController gameController;
	public cubeType myType;
	void OnMouseDown() {
		Destroy (gameObject);
		if (myType == cubeType.Bronze) {
			gameController.bronzeCubeCount--;
			gameController.totalPoints += gameController.bronzePoints;
		}
		if (myType == cubeType.Silver) {
			gameController.silverCubeCount--;
			gameController.totalPoints += gameController.silverPoints; 

		}
		if (myType == cubeType.Gold) {
			gameController.goldCubeCount--;
			gameController.totalPoints += gameController.goldPoints;
		}
	


	}
			
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
