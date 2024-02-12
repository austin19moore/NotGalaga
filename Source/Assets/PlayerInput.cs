using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] DiscreteMovement PlayerCharacter;

    void Update()
    {
        Vector3 input = new(0, 0, 0);

        if (Input.GetKey(KeyCode.A)) {
            input.x = -4;
        } else if (Input.GetKey(KeyCode.D)) {
            input.x = 4;
        }

        PlayerCharacter.IncrementPosition(input);

    }
}
