using UnityEngine;
using System.Collections;

public class MonsterHealth : MonoBehaviour {

    public int health;
	
    public void Hurt(int dmg)
    {
        this.health -= dmg;
        if(health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(this.gameObject);
    }
}
