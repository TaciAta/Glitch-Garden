using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    float walkSpeed = 0.69f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed)
    {
        walkSpeed = speed;
    }
}
