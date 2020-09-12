using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDrag : MonoBehaviour

{

    private Vector3 mOffset;
    public Camera Cameraforpacking;



    private float mZCoord;



    void OnMouseDown()

    {

        mZCoord = Cameraforpacking.WorldToScreenPoint(

            gameObject.transform.position).z;



        // Store offset = gameobject world pos - mouse world pos

        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();

    }



    private Vector3 GetMouseAsWorldPoint()

    {

        // Pixel coordinates of mouse (x,y)

        Vector3 mousePoint = Input.mousePosition;
       


        // z coordinate of game object on screen

        mousePoint.z = mZCoord;



        // Convert it to world points

        return Cameraforpacking.ScreenToWorldPoint(mousePoint);

    }



    void OnMouseDrag()

    {

        transform.position = GetMouseAsWorldPoint() + mOffset;

    }

}