using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        if(EventSystem.current.currentSelectedGameObject.tag == "Respawn")
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }


}
