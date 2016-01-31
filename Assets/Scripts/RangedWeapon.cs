using UnityEngine;
using System.Collections;

public class RangedWeapon : MonoBehaviour {
    public float fireRate = 0;
    public float damage = 10;
    public float projectileSpeed = 500f;
    public LayerMask whatToHit;
    public KeyCode shootKey;
    public Rigidbody2D projectile;

    //GameObject instance;
    Rigidbody2D instance;

    float timeToFire = 0;
  
    
    // Use this for initialization
	void Awake () {
       

    }

    // Update is called once per frame
    void Update() {
        if (fireRate == 0)
        {
            if (Input.GetKeyDown(shootKey))
            {
                Shoot();
            }
        } else {
            if (Input.GetKeyDown(shootKey) && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / fireRate;
                Shoot();
            }
        }
    }

    void Shoot()
    {
        Hero hero = GetComponent<Hero>();
        int direction = hero.direction;
        if (direction == 0)
            ShootTop();
        else if (direction == 1)
            ShootLeft();
        else if (direction == 2)
            ShootBottom();
        else if (direction == 3)
            ShootRight();

    }

    void ShootLeft()
    {
        timeToFire = Time.time + 1/fireRate;
        instance = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody2D;
        instance.AddForce(transform.right * -projectileSpeed);
    }
    void ShootRight()
    {
        timeToFire = Time.time + 1/fireRate;
        instance = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody2D;
        instance.AddForce(transform.right * projectileSpeed);
    }

    void ShootTop()
    {
        timeToFire = Time.time + 1/fireRate;
        instance = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody2D;
        instance.AddForce(transform.up * projectileSpeed);
    }

    void ShootBottom()
    {
        timeToFire = Time.time + 1/fireRate;
        instance = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody2D;
        instance.AddForce(transform.up * -projectileSpeed);
    }
}
