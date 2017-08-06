using System.Collections;
using System.Collections.Generic;
using NewtonVR;
using UnityEngine;

public class GiveItem : MonoBehaviour
{
    [SerializeField]
    private GameObject itemToGive;

    [SerializeField]
    private NVRButton button;

    [SerializeField]
    private GameObject deliveryObject;

    // Use this for initialization
    void Start() {}

    // Update is called once per frame
    void Update()
    {

        if (button.ButtonDown)
        {
            GameObject.Instantiate(itemToGive, deliveryObject.transform.position, deliveryObject.transform.rotation);

        }
    }
}
