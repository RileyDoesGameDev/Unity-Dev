using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   [Range(1,10)] public float speed = 2;

    public GameObject prefab;

    private void Awake()
    {
      

    }
    void Start()
    {
      
    }

   
    void Update()
    {
        Vector3 position = transform.position;
        Vector3 velocity = Vector3.zero;

        velocity.x = Input.GetAxis("Horizontal");
        velocity.z = Input.GetAxis("Vertical");
        transform.position += velocity * speed * Time.deltaTime;

        if(Input.GetKey(KeyCode.Space))
        {
            Instantiate(prefab, transform.position + Vector3.up,Quaternion.identity);


        }

      //  if(Input.GetButton("Fire1"))
      //  {
        //position.y += 1 *  Time.deltaTime;

       // }
        //transform.position = position;
    }
}
