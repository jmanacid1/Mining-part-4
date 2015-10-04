using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public GameObject cubePrefab;
	float spawnFrequency = 3.0f;
	float timeToAct = 0.0f;
	float spawnSilverTime = 12.0f;
	float stopSpawningTime = 6.0f;
	public int bronzePoints = 1;
	public int silverPoints = 10;
	public int goldPoints = 100;
	public int totalPoints;
	public int bronzeCubeCount;
	public int silverCubeCount;
	public int goldCubeCount;
	bool recentlySpwanedGold;

	
	// Use this for initialization
	void Start () {
		timeToAct += spawnFrequency;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= timeToAct){
			GameObject myCube = (GameObject) Instantiate(cubePrefab,
			                                             new Vector3(Random.Range(-9f, 9f), Random.Range(-3f, 5f), 0),
			                                             Quaternion.identity);

			timeToAct += spawnFrequency;
			
			myCube.GetComponent <cubeBehavior>().gameController = this;
			if (bronzeCubeCount == 2 && silverCubeCount == 2 && recentlySpwanedGold == false) {
			myCube.GetComponent<Renderer> ().material.color = Color.yellow;
			myCube.GetComponent <cubeBehavior> ().myType = cubeType.Gold;
			recentlySpwanedGold = true;
				goldCubeCount++;
		} else if (bronzeCubeCount >= 4) {
			myCube.GetComponent<Renderer> ().material.color = Color.white;
				myCube.GetComponent <cubeBehavior> ().myType = cubeType.Silver;
				recentlySpwanedGold = false;
				silverCubeCount++;
		} else {
			myCube.GetComponent<Renderer>().material.color = Color.red;
				myCube.GetComponent <cubeBehavior> ().myType = cubeType.Bronze;
				recentlySpwanedGold = false;
				bronzeCubeCount++;
		}
	
		}

		
		
	}
}
