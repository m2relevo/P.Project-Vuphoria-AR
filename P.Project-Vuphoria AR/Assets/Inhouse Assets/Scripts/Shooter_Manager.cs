using UnityEngine;
using System.Collections;

public class Shooter_Manager : MonoBehaviour
{
    public GameObject Target;

	// Use this for initialization
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (GameObject.FindGameObjectWithTag("Target") == null)
        {
            float targetX = Random.Range(0f, 0.5f);
            float targetY = Random.Range(0f, 0.5f);
            float targetZ = Random.Range(0f, 0.5f);

            GameObject NewTarget = (GameObject)Instantiate(Target);
            NewTarget.transform.parent = this.gameObject.transform;
            NewTarget.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            NewTarget.transform.localPosition = new Vector3(targetX, targetY, targetZ);
        }
	}
}
