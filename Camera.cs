using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	public GameObject Player;
	Vector3 shouldPos;

	void Update () 
	{
		shouldPos = Vector3.Lerp (gameObject.transform.position, Player.transform.position, Time.deltaTime);
		gameObject.transform.position = new Vector3 (shouldPos.x, 1, shouldPos.z);
	}
}
