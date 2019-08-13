using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(0f, 10f)] [SerializeField] float projectileSpeed = 2f;
    [SerializeField] float projectileDamage = 50f;

    void Update()
    {
        transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        var health = col.GetComponent<Health>();
        var attacker = col.GetComponent<Attacker>();
        
        if(attacker && health)
        {
            health.DealDamage(projectileDamage);
            Destroy(gameObject);
        }
        
    }
    

}
