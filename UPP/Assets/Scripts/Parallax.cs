using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] Transform follow;
    [SerializeField, Range(0f, 1f)] float parstr = 0.1f;
    [SerializeField] bool disableverticalparallax;
    Vector3 targetprev;

    void Start()
    {
        if (!follow)
        {
            follow = Camera.main.transform;
        }

        targetprev = follow.position;
    }

    void Update()
    {
        Vector3 delta = follow.position - targetprev;

        if (disableverticalparallax) delta.y = 0;

        targetprev = follow.position;

        transform.position += delta * parstr;
    }
}
