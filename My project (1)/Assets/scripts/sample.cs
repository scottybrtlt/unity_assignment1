using UnityEngine;

public class sample : MonoBehaviour
{
   // Make box rotate at certain speed
   public GameObject boxObject;
   private float rotationSpeed;
   public Vector3 rotationCoord;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rotationSpeed = 0.5f;
        rotationCoord = boxObject.transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        rotationCoord = rotationCoord + new Vector3(0f, rotationSpeed, 0f);
        boxObject.transform.localEulerAngles = rotationCoord;
    }

    public void StopRotate(){
        rotationSpeed = 0;
    }

}
