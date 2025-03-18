using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Diagnostics;
using JetBrains.Annotations;

public class PlayerAimWeapon : MonoBehaviour
{
    public static Vector3 GetMouseWorldPosition()
    {
        Vector3 vec = GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);
        vec.z = 0f;
        return vec; 
    }
    public static Vector3 GetMouseWorldPositionWithZ()
    {
        return GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);

    }
    public static Vector3 GetMouseWorldPositionWithZ(Camera worldCamera)
    {
        return GetMouseWorldPositionWithZ(Input.mousePosition, Camera.main);

    }
    public static Vector3 GetMouseWorldPositionWithZ(Vector3 screenPosition, Camera worldCamera)
    {
        Vector3 worldposition = worldCamera.ScreenToWorldPoint(screenPosition);
        return worldposition;
    }


    private Transform aimTransform;

    private void Awake()
    {
        aimTransform = transform.Find("Aim");
    }

    private void Update()
    {
        /*Vector3 mousePosition = GetMouseWorldPosition();

        Vector3 aimDirection = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        aimTransform.eulerAngles = new Vector3(0, 0, angle);
        Debug.Log(angle);*/

        

       
        aimTransform.position = GetMouseWorldPosition();
      

    }
}
