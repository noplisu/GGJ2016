using UnityEngine;
using System.Collections;

public class hurt : MonoBehaviour {
    bool invincibility;
    Health health;
    float blinkRate = 0.5f;
    Animator animator;

    void Start()
    {
        health = Health.getInstance();
        animator = GetComponentInParent<Animator>();
    }

    IEnumerator OnTriggerStay2D(Collider2D other)
    {
        if(!invincibility)
        {
            hurtPlayer damage = other.GetComponent<hurtPlayer>();
            if(damage)
            {
                invincibility = true;
                if (animator != null)
                    animator.SetTrigger("invincibility");
                health.health -= damage.amount;
                if(LayerMask.LayerToName(other.gameObject.layer) == "EnemyBullet")
                {
                    Destroy(other.gameObject);
                }
                yield return new WaitForSeconds(3);
                invincibility = false;
            }
        }
    }
}
