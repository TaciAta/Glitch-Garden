using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSucceess : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        FindObjectOfType<LifeDisplay>().DecreasePlayerLife(1);
        Destroy(collider.gameObject, 1f);
    }
}
