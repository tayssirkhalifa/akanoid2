using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private float speed = 15f;
    Rigidbody2D rb2D;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    public void Lunch(Vector2 direction)
    {
        transform.parent = null;
        rb2D.simulated = true;
        rb2D.velocity = direction.normalized * speed;
    }
    public void Catch(Transform parent)
    {
        transform.parent = parent;
        rb2D.simulated = false;
        rb2D.velocity = Vector2.zero;
    }
	// Update is called once per frame
	void Update () {
        rb2D.velocity=rb2D.velocity.normalized* speed;
	}
}
