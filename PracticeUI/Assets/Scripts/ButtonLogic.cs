using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonLogic : MonoBehaviour
{
    public GameObject cube; //get GameObject Cube

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
       
    }




    public void DoReveal()
    {
        cube.SetActive(true); //make Cube visable
        Debug.Log("didReveal");
    }

    public void DoRotate()
    {
        Animation anim = cube.GetComponent<Animation>();//get the Animation component atteched to Cube
        anim.Play("Y+360", PlayMode.StopAll);           //play clip Y+360 of Animation component
        Debug.Log("didRotate");
    }




}