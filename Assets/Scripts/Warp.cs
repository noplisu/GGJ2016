using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {

    public Transform warp_target;

    IEnumerator OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Fade instance = Fade.getInstance();
            if(instance != null)
            {
                instance.invoke();
            }
            yield return new WaitForSeconds(1);
            other.transform.position = warp_target.position;
            Camera.main.transform.position = new Vector3(warp_target.position.x, warp_target.position.y, -10);
        }
    }
}
