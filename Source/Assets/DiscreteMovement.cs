using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiscreteMovement : MonoBehaviour
{
    [SerializeField] SpriteRenderer sr;
    [SerializeField] int coinCount = 0;

    Rigidbody2D rb;
    [SerializeField] LayerMask obstacleMask;
    [SerializeField] LayerMask coinMask;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    public void IncrementPosition(Vector3 direction) {
        rb.velocity = direction;
    }

    public void OnTriggerEnter2D(Collider2D obj) {

        if ( Physics2D.OverlapCircleAll(transform.position, .75f, obstacleMask).Length > 0 ) {
            // game lost, to fail screen
            Debug.Log("Game Lost");
            SceneManager.LoadScene("MainMenu");
        }

    }

    public void PickupCoin() {
        GetComponent<AudioSource>().Play();
    }

    public void IncrementCoinCount()
    {
        this.coinCount += 1;
        Debug.Log("Coin collected");
        GameObject.Find("CoinCounter").GetComponent<CoinCounter>().AddCoin();
    }
}
