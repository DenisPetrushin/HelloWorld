using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooking : MonoBehaviour
{
    public int health = 10;
    public int level = 1;
    public int speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        print(health);
        health += level;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
