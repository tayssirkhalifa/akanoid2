using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health1 : MonoBehaviour {

    public int health = 1;
   public GameSession ui;

    public int ScoreValue = 10;


    private void Start()
    {
        ui = GameObject.FindWithTag("ui").GetComponent<GameSession>();
    }

  
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            health--;
            if (health <= 0)
            {
                ui.IncreaseScore(ScoreValue);
                    Destroy(gameObject);
                
            }

        }
    }
}
