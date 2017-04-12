using UnityEngine;
using System.Collections;

public class EnemyGeneration: MonoBehaviour {


	public GameObject Enemy;
	public GameObject EnemyMove;
	public GameObject EnemyMoveFast;
	public GameObject EnemyMoveSpeedy;
	public GameObject EnemyMoveSlow;
	public GameObject Niks;

	int firstRand;
	int secondRand;
	int disPlayer = 12;

	Vector3 intPos = new Vector3(0,0,0);

	void Update () 
	{
		if (Input.GetButtonDown ("up")) 
		{
			firstRand = Random.Range(1,4);
			if(firstRand == 1)
			{
				secondRand = Random.Range(1,8);
				for(int i= 0;i < secondRand;i++)
				{
					intPos = new Vector3(-4.46F,1,disPlayer);
					disPlayer += 1;
					GameObject EnemyMoveFastIns = Instantiate(EnemyMoveFast) as GameObject;
					EnemyMoveFastIns.transform.position = intPos;
				}
			}

			firstRand = Random.Range(1,4);
			if(firstRand == 2)
			{
				secondRand = Random.Range(1,8);
				for(int i= 0;i < secondRand;i++)
				{
					intPos = new Vector3(-1.46F,1,disPlayer);
					disPlayer += 1;
					GameObject EnemyMoveSpeedyIns = Instantiate(EnemyMoveSpeedy) as GameObject;
					EnemyMoveSpeedyIns.transform.position = intPos;
				}
			}

			firstRand = Random.Range(1,4);
			if(firstRand == 2)
			{
				secondRand = Random.Range(1,8);
				for(int i= 0;i < secondRand;i++)
				{
					intPos = new Vector3(-1.46F,1,disPlayer);
					disPlayer += 1;
					GameObject NiksIns = Instantiate(Niks) as GameObject;
					NiksIns.transform.position = intPos;
				}
			}



			firstRand = Random.Range(1,4);
			if(firstRand == 3)
			{
				secondRand = Random.Range(1,8);
				for(int i= 0;i < secondRand;i++)
				{
					intPos = new Vector3(1.46F,1,disPlayer);
					disPlayer += 1;
					GameObject EnemyMoveSlowIns = Instantiate(EnemyMoveSlow) as GameObject;
					EnemyMoveSlowIns.transform.position = intPos;
				}
			}
			firstRand = Random.Range(1,4);
			if(firstRand == 2)
			{
				secondRand = Random.Range(1,8);
				for(int i= 0;i < secondRand;i++)
				{
					intPos = new Vector3(3.46F,1,disPlayer);
					disPlayer += 1;
					GameObject EnemyMoveIns = Instantiate(EnemyMove) as GameObject;
					EnemyMoveIns.transform.position = intPos;
				}
			}
			firstRand = Random.Range(1,4);
			if(firstRand == 2)
			{
				secondRand = Random.Range(1,8);
				for(int i= 0;i < secondRand;i++)
				{
					intPos = new Vector3(0,1,disPlayer);
					disPlayer += 1;
					GameObject EnemyMoveIns = Instantiate(EnemyMove) as GameObject;
					EnemyMoveIns.transform.position = intPos;
				}
			}
			firstRand = Random.Range(1,5);
			if(firstRand == 4)
			{
				secondRand = Random.Range(1,2);
				for(int i= 0;i < secondRand;i++)
				{
					intPos = new Vector3(0,1,disPlayer);
					disPlayer += 1;
					GameObject EnemyMoveIns = Instantiate(EnemyMove) as GameObject;
					EnemyMoveIns.transform.position = intPos;
				}
			}

		}

	}
}
