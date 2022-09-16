using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;
    [SerializeField] GameObject objectToActivateTwo;

    // Start is called before the first frame update
    void Start()
    {
        //objectToActivate.GetComponent<MoveObject>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other) {
        objectToActivate.GetComponent<MoveObjectDoor>().enabled = true;
        objectToActivateTwo.GetComponent<MoveObjectDoor>().enabled = true;
    }

    private void OnTriggerExit(Collider other) {
        objectToActivate.GetComponent<MoveObjectDoor>().enabled = false;
        objectToActivateTwo.GetComponent<MoveObjectDoor>().enabled = false;
    }
}
