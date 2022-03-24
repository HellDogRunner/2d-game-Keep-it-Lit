using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    public Transform followTransform;
    public BoxCollider2D mapBounds;

    public float xMin = 0, xMax = 37, yMin = 0, yMax = 0;
    private float camY, camX, camZ;
    private float camOrthsize;
    private float cameraRatio;
    public Camera mainCam;
    private Vector3 smoothPos;
    public float smoothSpeed = 0.5f;

    private void Start()
    {
        camOrthsize = 5;
        cameraRatio = (xMax + camOrthsize) / 2.0f;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        camY = Mathf.Clamp(followTransform.position.y, yMin, yMax);
        camX = Mathf.Clamp(followTransform.position.x, xMin, xMax);
        camZ = Mathf.Clamp(followTransform.position.z - 10, -10, 0);
        smoothPos = Vector3.Lerp(this.transform.position, new Vector3(camX, camY, camZ), smoothSpeed);
        this.transform.position = smoothPos;


    }
}
