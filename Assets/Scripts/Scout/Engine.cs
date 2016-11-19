using UnityEngine;
using System.Collections;

public class Engine : MonoBehaviour {

    public string m_engineAxisName;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float v = Input.GetAxis(m_engineAxisName) * 10000f;
        GetComponent<Rigidbody>().AddTorque(transform.right * v);
    }
}
