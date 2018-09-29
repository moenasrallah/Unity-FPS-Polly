using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud_Mover : MonoBehaviour {

    public GameObject[] CloudObjects; 
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        for (int i = 0; i < CloudObjects.Length; i++)
        {
            CloudObjects[i].transform.position = new Vector3(CloudObjects[i].transform.position.x + 0.08f, CloudObjects[i].transform.position.y, CloudObjects[i].transform.position.z);
        }
	}
}
