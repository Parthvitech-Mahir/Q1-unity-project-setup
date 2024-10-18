using UnityEngine;

public class GrabObject : MonoBehaviour
{
    private OVRGrabbable grabbable;
    private OVRGrabber grabber;

    void Start()
    {
        grabbable = GetComponent<OVRGrabbable>();
        grabber = grabbable.grabbedBy;
    }

    void Update()
    {
        if (grabbable.isGrabbed)
        {
            // Perform actions when the object is grabbed
        }
    }
}
