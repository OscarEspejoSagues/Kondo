using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour {

    [HideInInspector]
    public bool sparksJoy = false;

    public SpriteRenderer faceImg;

    public float speed = 0.01f;

    int expresion;

    // Use this for initialization
    void Start()
    {
        expresion = Random.Range(0, 7);

        if (expresion < 3)
            sparksJoy = true;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - speed, this.transform.position.y);
    }

    public void getHit(bool sparkBullet)
    {
        if (expresion == 6)
        {
            expresion = Random.Range(0, 7);

            if (expresion < 3)
                sparksJoy = true;
        }
        else
        {
            if (sparkBullet == sparksJoy)
            {
                //++ points
            }
            else
            {
                //-- points
            }
            Destroy(this);
        }
    }

    public void OnDestroy()
    {
        //spawn preaty FXs and shit (diferent destruction depending on how?)
    }

}
