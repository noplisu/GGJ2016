using UnityEngine;
using System.Collections;

public class SkeletonShooting : MonoBehaviour {

    public float fireRate = 0;
    public float damage = 10;
    public float projectileSpeed = 500f;
    public LayerMask whatToHit;
    public Rigidbody2D projectile;
    
    Rigidbody2D instance;
    private Quaternion lookRotation;

    float timeToFire = 0;

    GameObject player;
    public float attackDistance = 1;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Hero");
    }
    
    void Update()
    {
        if (Time.time > timeToFire)
        {
            timeToFire = Time.time + 1 / fireRate;
            if(Vector3.Distance(transform.position, player.transform.position) <= attackDistance)
                Shoot();
        }
    }

    void Shoot()
    {
        GameObject hero = GameObject.FindGameObjectWithTag("Hero");
        Vector3 dir = hero.transform.position - transform.position;
        //lookRotation = Quaternion.LookRotation(dir);
        instance = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody2D;
        instance.AddForce(dir * projectileSpeed);

    }


}
