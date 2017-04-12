using UnityEngine;
using System.Collections;

public class Generation : MonoBehaviour {

	public GameObject Wall;
	public GameObject Road;
	public GameObject Grass;

	int firstRand;
	int secondRand;
	int disPlayer = 12;

	Vector3 intPos = new Vector3(0,0,0);

	void Update () 
	{
		if (Input.GetButtonDown ("up")) 
		{
			firstRand = Random.Range(1,1);
			if(firstRand == 1)
			{
				secondRand = Random.Range(1,8);
				for(int i= 0;i < secondRand;i++)
				{
					intPos = new Vector3(0,0,disPlayer);
					disPlayer += 1;
					GameObject GrassIns = Instantiate(Grass) as GameObject;
					GrassIns.transform.position = intPos;
				}
			}

		}

	}
}
