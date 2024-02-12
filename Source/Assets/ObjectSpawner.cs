using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] GameObject coinPrefab;

    void Start() {
        SpawnObjects();
    }

    void SpawnObjects() {

        StartCoroutine(SpawnCoinsRoutine());
        StartCoroutine(SpawnObjectsRoutine());

        IEnumerator SpawnCoinsRoutine() {
            while (true) {
                yield return new WaitForSeconds(.35f);
                Instantiate(obstaclePrefab, new Vector3(Random.Range(-6, 6),20,0), Quaternion.identity);
            }
        }
        IEnumerator SpawnObjectsRoutine() {
            while (true) {
                yield return new WaitForSeconds(.65f);
                Instantiate(coinPrefab, new Vector3(Random.Range(-6, 6),20,0), Quaternion.identity);
            }
        }

    }

}
