using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    public float MaxTime = 60f;

    [SerializeField]
    public float CountDown = 0;

	// Use this for initialization
	void Start () {
        CountDown = MaxTime;
	}
	
	// Update is called once per frame
	void Update () {
        CountDown -= Time.deltaTime;

        if (CountDown < 0)
        { 
            Coin.CoinCount = 0;
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
