using UnityEngine;
using System.Collections;

public class ProjectileCollision : MonoBehaviour {

    public int dmg;
    AudioSource audio;
    public GameObject explosion;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

	IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collision");
        if (collision.transform.GetComponent<MonsterHealth>() != null)
        {
            Debug.Log("Monster was hurt by: " + dmg + " dmg.");
            collision.gameObject.GetComponent<MonsterHealth>().Hurt(dmg);
        }
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;
        yield return new WaitForSeconds(audio.clip.length);
        Destroy(this.gameObject);
    }
}
