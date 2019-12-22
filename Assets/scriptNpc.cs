using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptNpc : MonoBehaviour {

    private Rigidbody2D rbd;

    public float velocidade = 30;
    private float largura;
    private float altura;

    // Use this for initialization
    void Start () {

        rbd = GetComponent<Rigidbody2D>();

        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag.Equals("Player"))
        {
            Destroy(col.gameObject);
        }

        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update () {

        rbd.velocity = new Vector2(-velocidade, 0);

        if (transform.position.x < -largura)
        {
            Destroy(this.gameObject);
        }

    }
}
