using UnityEngine;
using System.Collections;

public class CameraLerp : MonoBehaviour {
    public Transform target;
    public float speed = 10f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        float x = Mathf.Lerp(transform.position.x, target.position.x, Time.deltaTime * speed);
        float y = Mathf.Lerp(transform.position.y, target.position.y, Time.deltaTime * speed);
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
