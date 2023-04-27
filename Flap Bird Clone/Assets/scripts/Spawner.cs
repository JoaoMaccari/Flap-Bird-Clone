using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 1;

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

        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        //o instantiate realiza o spawn de um objeto em cena
        //tenho que passar qual objeto quero instanciar e em qual posicao ele vai aparecer
        //Nesse caso vai instanciar o objeto sempre no mesmo lugar
        //Instantiate(pipe, transform.position, transform.rotation);


        //ao instanciar eu crio um novo vetor passando as posições onde deve spawnar no eixo X, usando de forma randomica
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        
    }
}
