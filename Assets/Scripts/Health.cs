using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

    public float health = 1;
    public float maxHealth = 100;
    static Health instance;

    public static Health getInstance()
    {
        return instance;
    }

	// Use this for initialization
	void Start () {
        instance = this;
        health = maxHealth;
	}

    void Update()
    {
        if(health <= 0)
        {
            StartCoroutine("die");
        }
    }

    IEnumerator die()
    {
        Fade fade = Fade.getInstance();
        if(fade)
            fade.invoke();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
}
