using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shreader : MonoBehaviour
{
    //runs whenever other-Object triggers the shreadder
    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        Destroy(otherObject.gameObject);
    }

}
