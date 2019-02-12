using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject objectPrefab;

    public Vector2 timerMinMax = new Vector2(0.5f, 1.6f);
    public Vector2 posMinMax;
    float timer = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Vector3 randomPos = new Vector3(Random.Range(posMinMax.x, posMinMax.y), this.transform.position.y);
            Instantiate(objectPrefab, randomPos, Quaternion.identity);
            randomTimer();
        }
    }

    void randomTimer()
    {
        timer = Random.Range(timerMinMax.x, timerMinMax.y);
    }

}
