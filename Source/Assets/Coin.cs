using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] LayerMask despawnMask;
    [SerializeField] LayerMask playerMask;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnTriggerEnter2D(Collider2D obj) {

        if ( Physics2D.OverlapCircleAll(transform.position, 1.5f, despawnMask).Length > 0 ) {
            // despawn object
            Destroy(gameObject);
        }
        
        // might be buggy/needing rework
        if ( Physics2D.OverlapCircleAll(transform.position, 1.5f, playerMask).Length > 0 ) {
            // despawn object
            GameObject.Find("PlayerCharacter").GetComponent<DiscreteMovement>().IncrementCoinCount();
            GameObject.Find("CoinCounter").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }

    }

    public void RemoveCoin() {
        Destroy(gameObject);
    }

}
