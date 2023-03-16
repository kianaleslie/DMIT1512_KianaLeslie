using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField] GameObject backGround;
    void Start()
    {
        Instantiate(backGround/*, new Vector3(0f, 0f, 2f), Quaternion.identity*/);
    }
}