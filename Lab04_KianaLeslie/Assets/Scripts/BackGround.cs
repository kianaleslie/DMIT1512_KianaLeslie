using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField] GameObject bg;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(bg, new Vector3(0f, 0f, 2f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}