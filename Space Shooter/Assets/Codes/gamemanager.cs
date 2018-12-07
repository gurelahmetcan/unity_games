using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class gamemanager : MonoBehaviour {

    public GameObject Asteroid;
    public Vector3 randomPos;
    public float startwait;
    public float createwait;
    public float loopwait;
    public Text text;
    bool gameovercheck = false;
    bool restartcheck = false;
    public Text gameovertext;
    public Text restarttext;

    int Score;

	void Start ()
    {
        Score = 0;
        text.text = "score = " + Score;
        Score = 0;
        StartCoroutine(create());
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && restartcheck)
        {
            SceneManager.LoadScene("Level 1");
        }
    }
    IEnumerator create()
    {
        yield return new WaitForSeconds(startwait);
        while (true)
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
                Instantiate(Asteroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(createwait);

            }
            if (gameovercheck)
            {
                restarttext.text = "Press R to Restart";
                restartcheck = true;
                break;
            }

            yield return new WaitForSeconds(loopwait);        
        }

    }

    public void addScore(int newscore)
    {
        Score += newscore;
        text.text = "score = " + Score;
    }
    public void gameover()
    {
        gameovertext.text = "GAME OVER";
        gameovercheck = true;

    }
	
}
