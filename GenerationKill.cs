using UnityEngine;
using System.Collections;

public class GenerationKill2: MonoBehaviour {


	public GameObject Kill;

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
					intPos = new Vector3(-6.25F,0.38F,disPlayer);
					disPlayer += 1;
					GameObject KillIns = Instantiate(Kill) as GameObject;
					KillIns.transform.position = intPos;
				}
			}

		}

	}
}
