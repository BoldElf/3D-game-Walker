using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Touch : MonoBehaviour
{
    [SerializeField] private int layerMask;
    [SerializeField] private GameObject button;
    [SerializeField] private buttonElevator obj;

    public UnityAction buttonElevator;

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Camera.main.transform.forward + new Vector3(0,0.7f,0), out hit, Mathf.Infinity))
        {
            if(hit.collider.gameObject.layer == layerMask)
            {
                if(Input.GetKeyDown(KeyCode.E))
                {
                    buttonElevator?.Invoke();
                }
            }
            Debug.DrawRay(transform.position, Camera.main.transform.forward * hit.distance, Color.yellow);
        }
    }
}
