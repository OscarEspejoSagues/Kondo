using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controls : MonoBehaviour {
    public GameObject bullet;
    public GameObject point;
    public Text LeftText;
    public Text RightText;
    TextRandomizer textscriptLeft;
    TextRandomizer textscriptRight;
    BulletScript bulletscript;


    // Use this for initialization
    void Start () {
        textscriptLeft = LeftText.GetComponent<TextRandomizer>();
        textscriptRight = RightText.GetComponent<TextRandomizer>();
        bulletscript = bullet.GetComponent<BulletScript>();
    }
	
	// Update is called once per frame
	void Update () {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y,dir.x)*Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle-90,Vector3.forward);
        if (Input.GetMouseButtonDown(0))
        {
            if (textscriptLeft.good == 1)
            {
                bulletscript.BadOne = false;
                Instantiate(bullet, point.transform.position, point.transform.rotation);
            }else
            {
                bulletscript.BadOne = true;
                Instantiate(bullet, point.transform.position, point.transform.rotation);
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (textscriptLeft.good == 1)
            {
                bulletscript.BadOne = false;
                Instantiate(bullet, point.transform.position, point.transform.rotation);
            }
            else
            {
                bulletscript.BadOne = true;
                Instantiate(bullet, point.transform.position, point.transform.rotation);
            }
        }
    }
}
