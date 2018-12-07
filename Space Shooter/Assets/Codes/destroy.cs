using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerexplosion;

    GameObject gamemanager;
    gamemanager control;

    void Start()
    {
        gamemanager = GameObject.FindGameObjectWithTag("GM");
        control = gamemanager.GetComponent<gamemanager>();
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag != "border")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            Instantiate(explosion, transform.position, transform.rotation);
            control.addScore(10);
        }
        
        if(col.tag == "Player")
        {
            Instantiate(playerexplosion, col.transform.position, col.transform.rotation);
            control.gameover();
        }

        
    }
}
