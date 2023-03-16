using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class GemBehaviour : MonoBehaviour, ICollectable
{
    public int Value => 0;
    public CollectableType Type => CollectableType.Gem;

    private SpriteRenderer sprite;
    private Collider2D boundingBox;

    public int Collect()
    {
        sprite.color = new Color(1, 1, 1, 0.2f);
        boundingBox.enabled = false;
        return Value;
    }
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        boundingBox = GetComponent<Collider2D>();
    }
    void Update()
    {
        
    }
}