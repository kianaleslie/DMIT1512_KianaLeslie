using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCoins : MonoBehaviour
{
    [SerializeField] private FloatSO coinSO;
    void Start()
    {
        coinSO.Value = 0;
    }
}