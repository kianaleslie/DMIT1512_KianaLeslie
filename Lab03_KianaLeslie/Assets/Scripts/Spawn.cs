using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ball.transform.position = new Vector3(2.35f, -1.58f);
    }
}
