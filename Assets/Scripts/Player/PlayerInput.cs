using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Touch touch;

    public Vector3 GetTouchPosition()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                return Camera.main.ScreenToWorldPoint(touch.position);
            }
        }

        return Vector3.zero;
    }

    public Vector3 GetMousePosition()
    {
        if(Input.GetMouseButton(0))
        {
            return Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else
        {
            return Vector3.zero;
        }
    }




}
