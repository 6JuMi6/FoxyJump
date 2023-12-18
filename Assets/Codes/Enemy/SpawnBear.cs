using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBear : MonoBehaviour
{
    public float maxtime = 2f;
    float timer;
    public GameObject Bear;
    public float speed = 20;
    GameObject newBear;
    public float maxspeed = 1000;


    IEnumerator IncreaseGameSpeed()
    {
        yield return new WaitForSeconds(2);
        speed += 10;
    }

    private void Update()
    {
        Vector2 random = new Vector2(Random.Range(9f, 18f), -3.60f);

        timer += Time.deltaTime;

        if(speed < maxspeed)
        speed += 2f * Time.deltaTime;

        if (timer > maxtime)
        {
            GameObject newBear = Instantiate(Bear, random, transform.rotation);
            timer = 0;
            Destroy(newBear, 5f);
        }
        Destroy(newBear, 4f);
    }

    
}
