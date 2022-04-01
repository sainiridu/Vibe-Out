using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExtraCubes : MonoBehaviour
{

    public int missedCubes = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RedCube") || other.gameObject.CompareTag("BlueCube"))
        {
            missedCubes++;
            Destroy(other.transform.parent.gameObject, 5f);
        }
    }
}
