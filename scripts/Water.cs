using UnityEngine;

public class Water : MonoBehaviour {

    private GameObject playerRef;
    private Vector3 WaterYpos;
    private float PlayerYpos;
    
    public void Start()
    {
        //start with saving the player positions
        playerRef = GameObject.FindGameObjectWithTag("Player");
        PlayerYpos = playerRef.transform.position.y;

    }


    public  void FixedUpdate()
    {
        //make the water follows the player where ever he goes but when he jumps calls the position y that has been saved in the start
      WaterYpos = new Vector3(playerRef.transform.position.x, PlayerYpos, playerRef.transform.position.z);
      this.transform.position = WaterYpos + new Vector3(-61f, -3.5f, -41.72f);

    }

}
