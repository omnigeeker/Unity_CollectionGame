using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    public static int CoinCount = 0;

    void Awake()
    {
        ++Coin.CoinCount;
    }

    private void OnTriggerEnter(Collider col)
    {
        Debug.Log("Entered Collider");
        if (col.CompareTag("Player"))
            Destroy(gameObject);
    }

    private void OnDestroy()
    {
        --Coin.CoinCount;
        if (Coin.CoinCount <= 0)
        {
            // Win
            GameObject Timer = GameObject.Find("LevelTimer");
            Destroy(Timer);
            GameObject[] FireworkSystems = GameObject.FindGameObjectsWithTag("Fireworks");
            foreach (GameObject GO in FireworkSystems)
                GO.GetComponent<ParticleSystem>().Play();
        }
    }
}
