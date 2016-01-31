using UnityEngine;
using System.Collections;

public class EnemyMoving : MonoBehaviour {

    Transform heroTransition;
    Transform enemyTransform;
    Vector3 movement;
    Animator anim;
    public float maxDistance;
    public float attackDistance;
    public float speed;
    private float distance;
    public bool isMoving;

    void Awake () {
        anim = GetComponent<Animator>();
        heroTransition = GameObject.FindGameObjectWithTag("Hero").transform;
        enemyTransform = transform;
    }
	
	void Update () {
        Move();
        Animate();
    }

    void Move()
    {

        isMoving = (movement.x != 0 || movement.y != 0);
        distance = Vector3.Distance(heroTransition.position, enemyTransform.position);
        movement.Set(0, 0, 0);

        if (distance < attackDistance)
        {
            

            if (distance > maxDistance)
            {
                movement = heroTransition.position - enemyTransform.position;
                movement = movement.normalized;
                enemyTransform.position += movement * speed * Time.deltaTime;
            }
        }
    }

    void Animate()
    {
        if (anim != null)
        {
            if (movement.x != 0 || movement.y != 0)
            {
                anim.SetFloat("movingH", getDirection(movement.x));
                anim.SetFloat("movingV", getDirection(movement.y));
                //anim.SetBool("isMoving", true);
            }
            else
            {
                //anim.SetBool("isMoving", false);
            }
        }
    }

    int getDirection(float value)
    {
        if(value > 0)
        {
            return 1;
        }else if(value < 0)
        {
            return -1;
        }
        return 0;
    }
}
