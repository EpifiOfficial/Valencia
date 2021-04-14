using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public float lifeTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
     StartCoroutine(LifetimeParticle());   
    }

    // Update is called once per frame
    void Update(){   
    }
    public IEnumerator LifetimeParticle(){
        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }


}
