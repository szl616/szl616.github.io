using UnityEngine;
using System.Collections;

public class ExplosiveBarrel : MonoBehaviour {
   
    public float radius = 5.0F;
    public float power = 10.0F;
    public Vector3 startPosition;
    private bool triggeredExplosion = false;
    public float triggeredPositionChange = 0.1F;

    private AudioSource AS;
    void Start()
    {
        AS = GetComponent<AudioSource>();
        Invoke("GetPosition", 2);
       // InvokeRepeating("CheckIfMoved", 2.5F, 1F);
    }

    void Update()
    {
        
       
    }
       void GetPosition()
    {
        startPosition = transform.position;
    }
    
    void CheckIfMoved()
    {

        if (Vector3.Distance(startPosition, transform.position) > triggeredPositionChange && !triggeredExplosion)
        {
            triggeredExplosion = true;
        }
    }

    void OnCollisionEnter (Collision col)
    {
        //if(col.gameObject.tag == "Player" || triggeredExplosion)
        {
            Explode();
            PlaySoundEffect();
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Collider>().enabled = false;
        }
    }

    void Explode ()
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            if (hit.gameObject.tag == "Player" && Vector3.Distance(explosionPos, hit.transform.position) < radius*0.6) 
            {
                hit.gameObject.GetComponent<Renderer>().enabled = false;
                hit.enabled = false;
                hit.GetComponent<Rigidbody>().isKinematic = true;
                hit.GetComponent<Rigidbody>().useGravity = false;
                

            }
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 3.0F);

            if (hit.gameObject.tag == "Player")
                hit.GetComponent<Rigidbody>().AddExplosionForce(power * 6, explosionPos, radius, 3.0F);
        }
    }

void PlaySoundEffect()
    {
        AS.pitch = Random.RandomRange(0.9F, 1.1F);
        AS.Play();

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }

}
