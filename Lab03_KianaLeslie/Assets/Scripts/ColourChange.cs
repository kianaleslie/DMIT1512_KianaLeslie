using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    //[SerializeField] GameObject ball;
    [SerializeField] GameObject scoringObject1;
    [SerializeField] GameObject scoringObject2;
    [SerializeField] GameObject scoringObject3;
    public float timer = 0;
    private void Start()
    {
        timer = 0.5f;
    }
    void Update()
    {
        if (timer > 0)
        {
            scoringObject1.GetComponent<Renderer>().material.color = Color.blue;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            scoringObject1.GetComponent<Renderer>().material.color = Color.magenta;
        }
        if (collision.gameObject.tag == "Ball")
        {
            scoringObject2.GetComponent<Renderer>().material.color = Color.green;
        }
        if (collision.gameObject.tag == "Ball")
        {
            scoringObject3.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}