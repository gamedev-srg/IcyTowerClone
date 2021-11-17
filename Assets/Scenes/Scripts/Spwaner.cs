// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Spwaner : MonoBehaviour
// {
//     [SerializeField] GameObject prefabToSpawn;
//     [SerializeField] float minTimeBetweenSpawns = 1f;
//     [SerializeField] float maxTimeBetweenSpawns = 3f;
//     private Vector3 screenBounds;
//     private float maxXDistance = 2f;
//     // Start is called before the first frame update
//     void Start()
//     {
//         this.StartCoroutine(SpawnRoutine());
//         screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
//     }
//     void update(){
//         GameObject plat = GameObject.Find("Platform(Clone)");
//          if(plat.transform.position.x < screenBounds.x * 2){
//             Destroy(plat);
//         }
//     }
//     private IEnumerator SpawnRoutine()
//     {
//         while (true)
//         {
//             float timeBetweenSpawns = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
//             yield return new WaitForSeconds(timeBetweenSpawns);
//             float xD = Random.Range(this.transform.position.x-maxXDistance, +maxXDistance);
//             float yD=  Random.Range(this.transform.position.y+maxXDistance, +maxXDistance);
//             Vector3 positionOfSpawnedObject = new Vector3(Mathf.Clamp(this.transform.position.x,-xD,xD),Mathf.Clamp(this.transform.position.x,-yD,yD),transform.position.z);
//             GameObject newObject = Instantiate(prefabToSpawn.gameObject, positionOfSpawnedObject, Quaternion.identity);
//             if(newObject.tag == "p2"){
//                 // newObject.GetComponent<eMover>().SetMovment(speed);
//             }
            
//         }
//     }
// }
