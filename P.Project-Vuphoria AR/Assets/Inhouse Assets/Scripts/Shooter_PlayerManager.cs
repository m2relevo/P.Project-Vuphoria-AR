using UnityEngine;
using System.Collections;

public class Shooter_PlayerManager : MonoBehaviour
{
	// Use this for initialization
	void Start ()
    {
	
	}

    void FixedUpdate()
    {
        Ray playerCrosshairs = Camera.main.ScreenPointToRay();
        RaycastHit hit;
    }

	// Update is called once per frame
	void Update ()
    {
	
	}
}
