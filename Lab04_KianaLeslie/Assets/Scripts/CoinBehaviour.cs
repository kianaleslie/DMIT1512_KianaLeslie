using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour, ICollectable
{
    public int Value => 1;
    public CollectableType Type => CollectableType.Money;

    private SpriteRenderer sprite;
    private Collider2D boundingBox;

    public int Collect()
    {
        sprite.enabled = false;
        boundingBox.enabled = false;
        return Value;
    }
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {

    }
}