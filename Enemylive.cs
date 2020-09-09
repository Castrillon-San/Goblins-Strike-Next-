using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemylive : MonoBehaviour
{
    private int life = 5;
    EnemyWaves wavesCode;
    private GameObject GameController;

    private void Start()
    {
        GameController = GameObject.Find("GAME CONTROLLER");
        wavesCode = GameController.GetComponent<EnemyWaves>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            GetDamage(10);
        }
    }

    public void GetDamage(int damage)
    {
        life = life - damage;
        if (life<=0)
        {
            //Animación de muerte
            Destroy(gameObject);

            wavesCode.AliveCount();
            
            /*if(wavesCode.currentAliveEnemies<=0)
            {
                StartCoroutine(wavesCode.WaveWaiter());
            }*/
        }
    }

}
