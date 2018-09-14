using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {

    public TextMesh infoText;
    public Pin[] pins;
    public Player player;
    public float evaluationTime = 10f;

    private float gameTimer = 0f;
    private bool evaluating = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!evaluating)
        {
            if (player.holding)
            {
                infoText.text = "Throw the Bowling Ball!";
            }
            else
            {
                evaluating = true;
                gameTimer = evaluationTime;
            }
        }
        else
        {
            gameTimer -= Time.deltaTime;
            if(gameTimer <= 0f)
            {
                int score = 0;
                
                for(int i = 0; i < pins.Length; i++)
                {
                    if(pins[i] == null)
                    {
                        score++;
                    }
                }

                infoText.text = "Your Score: " + score;
            }

            if(gameTimer <= -3f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        
	}
}
