using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosiondelete : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject,3);
	}
}