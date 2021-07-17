using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {



    private float speed = 30f;
    public GameObject ballPreFab;
    public Vector2 launchDirection = new Vector2(1, 4);
    private Vector3 balloffset;
    Rigidbody2D rb2d;
	// Update is called once per frame
    private void Start()
    {
        Ball ball = GetComponentInChildren<Ball>();
        balloffset = ball.transform.position - transform.position;
    }
    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
	void Update () {
        rb2d.velocity = new Vector2(Input.GetAxis("Horizontal")*speed, 0);

        if (transform.childCount > 0 && Input.GetButtonDown("Jump"))
        {
            Ball ball = GetComponentInChildren<Ball>();
            ball.Lunch(launchDirection);
        }

        if(Input.GetButtonDown("Fire1"))
        {
            ResetBall();
        }

	}

    public void ResetBall()
    {
        Ball ball = Instantiate(ballPreFab, transform).GetComponent<Ball>();
        ball.transform.position = transform.position + balloffset;
    }
}
