using UnityEngine;
using System.Collections;

public class EnemyCarMove : MonoBehaviour {

	public float speed = 8f;

	// Use this for initialization
	void EnemyCarMoveStart() {
	
	}
	
	// Update is called once per frame
	void EnemyCarMoveUpdate() {

		transform.Translate (new Vector3(0,1,0) * speed * Time.deltaTime);
	}
}
