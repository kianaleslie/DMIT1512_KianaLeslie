using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField] GameObject backGround;
    GameObject bg;
    void Start()
    {
        Camera cam = Camera.main;
        bg = Instantiate(backGround, new Vector3(0f, 0f, 2f), Quaternion.identity);
    }
}