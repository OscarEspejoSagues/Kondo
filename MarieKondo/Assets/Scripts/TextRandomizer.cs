
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextRandomizer : MonoBehaviour {

    public string[] goodOnes;
    public string[] badOnes;
    int good, stringToChoose;
    Text myText;


	// Use this for initialization
	void Start () {
        myText = gameObject.GetComponent<Text>();
        SelectQuote();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SelectQuote () {
        good = Mathf.RoundToInt(Random.value);
        if(good == 1)
        {
            stringToChoose = Random.Range(0, goodOnes.Length);
            myText.text = goodOnes[stringToChoose];
        }
        else
        {
            stringToChoose = Random.Range(0, badOnes.Length);
            myText.text = badOnes[stringToChoose];
        }
    }
}
