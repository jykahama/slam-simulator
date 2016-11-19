using UnityEngine;

public class VehicleCamera : MonoBehaviour {
    public Camera m_camera;
    public GameObject m_target;

    private Vector3 offset = new Vector3(-4, 5, -15);
    private Vector3 velocity;
    private Quaternion rotOffset = Quaternion.Euler(110, 15, 5);
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        m_camera.transform.position = Vector3.SmoothDamp(m_camera.transform.position, m_target.transform.position + offset, ref velocity, 0.1f);
//        m_camera.transform.position = m_target.transform.position + offset;
        //m_camera.transform.rotation = m_target.transform.rotation * rotOffset;
//        m_camera.transform.rotation = Quaternion.Slerp(m_camera.transform.rotation, m_target.transform.rotation * rotOffset, 0.9f);
    }
}
