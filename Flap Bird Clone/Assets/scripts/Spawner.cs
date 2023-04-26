using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        }
        else {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe() {
        //o instantiate realiza o spawn de um objeto em cena
        //tenho que passar qual objeto quero instanciar e em qual posicao ele vai aparecer
        Instantiate(pipe, transform.position, transform.rotation);
        
    }
}
