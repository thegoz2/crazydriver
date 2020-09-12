using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDrag : MonoBehaviour

{

    private Vector3 mOffset;


    private float mZCoord;
    public Camera PickUpObjectCamera;



    void OnMouseDown()

    {

        mZCoord = PickUpObjectCamera.WorldToScreenPoint(gameObject.transform.position).z;



        // Store offset = gameobject world pos - mouse world pos

        mOffset = GetMouseAsWorldPoint();

    }



    private Vector3 GetMouseAsWorldPoint()

    {

        // Pixel coordinates of mouse (x,y)

        Vector3 mousePoint = Input.mousePosition;
       


        // z coordinate of game object on screen

        mousePoint.z = PickUpObjectCamera.nearClipPlane;
        Debug.LogError(mZCoord);



        // Convert it to world points

        return PickUpObjectCamera.ScreenToWorldPoint(mousePoint);

    }



    void OnMouseDrag()

    {

        transform.position = GetMouseAsWorldPoint() + mOffset;

    }

}