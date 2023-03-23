using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourChange : MonoBehaviour
{
    //[SerializeField] GameObject ball;
    [SerializeField] GameObject scoringObject;
    [SerializeField] public int points;
    public float timer = 0;
    private void Start()
    {
        timer = 0f;
    }
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            scoringObject.GetComponent<Renderer>().material.color = Color.magenta;
        }
        else
        {
            scoringObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            timer = 0.5F;
        }
    }
}