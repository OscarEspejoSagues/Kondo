using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

    float speed = 2f;
    public bool BadOne = false;
    public Sprite BadSprite;
    // Use this for initialization
    public float TimeToLive = 1f;
    private void Start()
    {
        SpriteRenderer image = gameObject.GetComponent(typeof(SpriteRenderer)) as SpriteRenderer;
        Destroy(gameObject, TimeToLive);
        if (BadOne)
        {
            image.sprite = BadSprite;
            transform.localScale = new Vector3(1,1,1);
        }
    }

    // Update is called once per frame
    void Update () {
        transform.position += speed * transform.up;
	}
}
