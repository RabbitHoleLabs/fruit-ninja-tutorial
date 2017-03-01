using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Rigidbody))]
public class SwordCutter : MonoBehaviour {

	public Material capMaterial;

    void OnCollisionEnter(Collision collision)
    {
        GameObject victim = collision.collider.gameObject;

        GameObject[] pieces = BLINDED_AM_ME.MeshCut.Cut(victim, transform.position, transform.right, capMaterial);

        if (!pieces[1].GetComponent<Rigidbody>())
            pieces[1].AddComponent<Rigidbody>();

        Destroy(pieces[1], 1);
    }

}
