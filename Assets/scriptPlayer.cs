using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptPlayer : MonoBehaviour {

    public float velocidade = 50;
    private Rigidbody2D rbd;

    private float altura;

    // Use this for initialization
    void Start () {
        rbd = GetComponent<Rigidbody2D>();
        altura = Camera.main.orthographicSize;
    }
	
	// Update is called once per frame
	void Update () {

        float y = Input.GetAxis("Vertical");
        rbd.velocity = new Vector2(rbd.velocity.x, y * velocidade);

        if (transform.position.y > altura + 1)
        {
            transform.position = new Vector2(transform.position.x, -altura);
        }
        else if (transform.position.y < -altura)
        {
            transform.position = new Vector2(transform.position.x, altura);
        }

    }
}
