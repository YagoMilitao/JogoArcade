using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptRespawn : MonoBehaviour {

    public GameObject inimigo;

    private float altura;
    private float largura;

    // Use this for initialization
    void Start () {

        altura = Camera.main.orthographicSize;
        largura = altura * Camera.main.aspect;
        InvokeRepeating("respawn", 0.8f, 1);

    }

    private void respawn()
    {
        float posX = Random.Range(altura, -altura);
        Instantiate(inimigo, new Vector2(largura+1, posX), Quaternion.identity);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
