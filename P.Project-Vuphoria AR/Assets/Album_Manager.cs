using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class Album_Manager : MonoBehaviour
{
    private Renderer rend;
    private Material[] mats;
    private int CurrentStrip;
    private int MaxStrip;

    public List<Material> List_Strips;

    void Awake()
    {
        CurrentStrip = 0;
        MaxStrip = 2;
        rend = GetComponent<Renderer>();
        mats = rend.materials;
        mats[1] = List_Strips[CurrentStrip];
        rend.materials = mats;
    }

	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        mats[1] = List_Strips[CurrentStrip];
        rend.materials = mats;
    }

    public void ForwardStrip()
    {
        if (CurrentStrip > MaxStrip)
        {
            CurrentStrip = 0;
        }

        if (CurrentStrip < MaxStrip)
        {
            CurrentStrip = CurrentStrip + 1;
        }
     }

    public void BackwardStrip()
    {
        if (CurrentStrip < 0)
        {
            CurrentStrip = MaxStrip;
        }

        if (CurrentStrip > 0)
        {
            CurrentStrip = CurrentStrip - 1;
        }
    }

    public void StartStrip()
    {
        CurrentStrip = 0;
    }

    public void LastStrip()
    {
        CurrentStrip = MaxStrip;
    }
}
