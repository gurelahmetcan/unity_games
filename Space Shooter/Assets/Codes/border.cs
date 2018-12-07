using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class border : MonoBehaviour {

    public void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject); 
    }

  
}
