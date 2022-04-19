using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DynamicBox.EventManagement;

public class Object2 : MonoBehaviour
{
    public int id;

    #region Events
    private void OnEnable()
    {
        EventManager.Instance.AddListener<BlablaEvent>(OnBlablaHandler);
    }

    private void OnDisable()
    {
        EventManager.Instance.RemoveListener<BlablaEvent>(OnBlablaHandler);
    }

    private void OnBlablaHandler(BlablaEvent eventDetails)
    {
        if(eventDetails.ID == id)
        {
            RandomMethod2();
        }
    }
    #endregion

    private void RandomMethod2()
    {
        Debug.Log("Called");
    }
}
