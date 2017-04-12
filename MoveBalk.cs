using UnityEngine;
using System.Collections;

public class MoveBalk : MonoBehaviour {
	public Vector3 startPositie;
	float xSpeed;
	// Use this for initialization
	void Start () {

		transform.position = startPositie;
		xSpeed = 0.03f;
	}

	void OnMouseDown()
	{
		Destroy(this.gameObject);
	}

	// Update is called once per frame



	void Update () {
		transform.Translate (0, 0, xSpeed);


	}
}
