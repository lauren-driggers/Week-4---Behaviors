using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator1 : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;

    // Start is called before the first frame update
    void Start()
    {
        //objectToActivate.GetComponent<MoveObject>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        objectToActivate.GetComponent<MoveObjectRotate>().enabled = true;
    }
}
