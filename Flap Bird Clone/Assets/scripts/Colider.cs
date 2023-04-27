using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colider : MonoBehaviour
{   
    //crio uma referencia para o script de pontuação
    public logicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        //vai procurar pelo primeiro objeto em cena com a tag logic. em seguida pega o componente
        //agora eu posso usar os metodos do script que estiverem em logic aqui no script de colisao
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.layer == 3) {

            //funcao que esta no script de pontuação sendo chamado
            logic.addScore(1);
        }
    }
}
