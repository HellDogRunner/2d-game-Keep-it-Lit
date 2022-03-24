using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{

      public Transform character;

    public void SetPos(Transform obj) {

        Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < character.position.x + 3 && Camera.main.ScreenToWorldPoint(Input.mousePosition).x > character.position.x - 3)
            if (Camera.main.ScreenToWorldPoint(Input.mousePosition).y < character.position.y + 4 && Camera.main.ScreenToWorldPoint(Input.mousePosition).y > character.position.y)
            {
                obj.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, Camera.main.ScreenToWorldPoint(Input.mousePosition).z + 10);
            }

    }
}
