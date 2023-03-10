using UnityEngine;

public class Controller : MonoBehaviour
{
    private Vector3 offset;
    public Collider cube;

    bool drag = false;

    private void Start()
    {
        cube = GetComponent<Collider>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BlueWall" || collision.gameObject.tag == "RedWall")
        {
            drag = false;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            drag = false;
        }

        if (Input.GetMouseButtonDown(0))
        {
            drag = true;
        }

        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100f)) 
        {
            if (drag)
            {
                if (hit.collider == cube)
                {
                    Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5f);
                    hit.collider.gameObject.transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
                }
            }
        }      
    }
}
