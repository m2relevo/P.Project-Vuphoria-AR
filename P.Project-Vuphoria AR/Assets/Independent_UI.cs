using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Independent_UI : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
    public void Appclose()
    {
        Application.Quit();
    }

    public void AppRestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
