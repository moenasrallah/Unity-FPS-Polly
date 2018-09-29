using UnityEngine;
using System.Collections;

public class skullAI : MonoBehaviour {

	public Transform target;
	public int moveSpeed = 3;
	public int rotationSpeed = 3;

	public Transform myTransform;


	public void Awake()
	{
		myTransform = transform;
	}


	void Update()
	{
        //rotate to look at the player
        transform.LookAt(target);

	}
}
