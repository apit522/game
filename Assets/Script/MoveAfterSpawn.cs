using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAfterSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public float tempo;
    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0f, tempo * Time.deltaTime, 0f);    
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
