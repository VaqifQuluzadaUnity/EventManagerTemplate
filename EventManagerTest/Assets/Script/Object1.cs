using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DynamicBox.EventManagement;

public class Object1 : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RandomMethod();
        }
    }

    private void RandomMethod()
    {
        EventManager.Instance.Raise(new BlablaEvent(1));
    }
}
