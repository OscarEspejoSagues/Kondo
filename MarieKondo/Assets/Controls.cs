using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {
    public GameObject bullet;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y,dir.x)*Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle-90,Vector3.forward);
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet,transform.position,transform.rotation);
        }
    }
}
