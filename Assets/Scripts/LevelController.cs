using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public GameObject world1;
    public GameObject world2;
    bool Active = true;
    void Start()
    {
        world2.SetActive(true);
        world1.SetActive(false);

    }


    void Update()
    {
        
    }
    public void ActiveWorld() 
    {
        if (Active == true)
        {
            world2.SetActive(true);
            world1.SetActive(false);
            Active = false;
        }
        else
        {
            world2.SetActive(false);
            world1.SetActive(true);

            Active = true;
        }
        }
}
