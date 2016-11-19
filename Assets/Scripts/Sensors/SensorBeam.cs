using UnityEngine;

public class SensorBeam : MonoBehaviour {
    public Color normalColor;
    public Color triggeredColor;

    private int collisions = 0;

	// Use this for initialization
	private void Start ()
    {

        MeshRenderer[] renderers = GetComponentsInChildren<MeshRenderer>();

        for (int i = 0; i < renderers.Length; i++)
        {
            renderers[i].material.color = normalColor;
        }
    }

    // Update is called once per frame
    private void Update ()
    {
	
	}

    private void OnTriggerEnter(Collider other)
    {
        MeshRenderer[] renderers = GetComponentsInChildren<MeshRenderer>();
        if(collisions++ == 0)
        {
            for (int i = 0; i < renderers.Length; i++)
            {
                renderers[i].material.color = triggeredColor;
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        MeshRenderer[] renderers = GetComponentsInChildren<MeshRenderer>();
        if(--collisions == 0)
        {
            for (int i = 0; i < renderers.Length; i++)
            {
                renderers[i].material.color = normalColor;
            }

        }
    }

}
