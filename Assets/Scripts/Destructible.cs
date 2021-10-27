using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject destroyedVase;
    
    void OnMouseDown() {


        Instantiate(destroyedVase, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
