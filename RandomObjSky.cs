using UnityEngine;
using System.Collections;

public class RandomObjSky : MonoBehaviour {
	public Transform bird1,bird2,bird3,bird4,bird5;
	public int sec;
	int choose;
	public float spawnx;
	int seconds;

	// Use this for initialization
	void Start () {
		InvokeRepeating("spawn",1,sec);
	}
	
	// Update is called once per frame
	void Update () {
		choose = Random.Range (1, 5);
		 if (choose == 1) {
			Vector3 position = bird1.position;
			position.y = Random.Range (2, 4);
			position.x = spawnx;
			GameObject.Instantiate (bird1, position, Quaternion.identity);
		}
		else if (choose == 2) {
			Vector3 position = bird2.position;
			position.y = Random.Range (2, 4);
			position.x = spawnx;
			GameObject.Instantiate (bird2, position, Quaternion.identity);
		}
		else if (choose == 3) {
			Vector3 position = bird3.position;
			position.y = Random.Range (2, 4);
			position.x = spawnx;
			GameObject.Instantiate (bird3, position, Quaternion.identity);
		}
		else if (choose == 4) {
			Vector3 position = bird4.position;
			position.y = Random.Range (2, 4);
			position.x = spawnx;
			GameObject.Instantiate (bird4, position, Quaternion.identity);
		}
		else if (choose == 5) {
			Vector3 position = bird5.position;
			position.y = Random.Range (2, 4);
			position.x = spawnx;
			GameObject.Instantiate (bird5, position, Quaternion.identity);
		}
	}
}
