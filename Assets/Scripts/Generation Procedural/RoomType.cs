using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomType : MonoBehaviour
{
    public int _Type;

    public void RoomDestroy()
    {
        GameObject MyParent = GetComponentInParent<RootRoom>().gameObject;
        Destroy(MyParent);
    }

}
