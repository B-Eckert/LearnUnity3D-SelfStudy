using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int collideCounter = 0;
    public Rigidbody playerPhysics;
    public float moveForce = 15000;
    // Start is called before the first frame update
    void Start()
    {
      playerPhysics = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision hit){
      if(hit.collider.tag != "Terrain"){
        collideCounter++;
      }
      Debug.Log(collideCounter);
    }
    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate(){
      // MOVEMENT
      if(Input.GetKey("w")){
          playerPhysics.AddForce(0,0, moveForce * Time.deltaTime);
      }
      if(Input.GetKey("s")){
          playerPhysics.AddForce(0,0, -moveForce * Time.deltaTime);
      }
      if(Input.GetKey("a")){
        playerPhysics.AddForce(-moveForce * Time.deltaTime,0, 0);
      }
      if(Input.GetKey("d")){
        playerPhysics.AddForce(moveForce * Time.deltaTime,0, 0);
      }

      if(playerPhysics.position.y < -10){
          FindObjectOfType<GameManager>().GameEnd();
      }
    }
}
