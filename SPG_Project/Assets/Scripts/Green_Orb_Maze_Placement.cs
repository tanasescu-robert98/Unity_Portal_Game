using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_Orb_Maze_Placement : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Green_Orb;
    void Start()
    {
        int[] positions = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        int randValue = Random.Range(0, positions.Length);
        int final_position = positions[randValue];

        switch (final_position)
        {
            case 1: 
                Green_Orb.transform.position = new Vector3(54.5400009f, 48.2999992f, 2720.6001f);
                break;
            case 2: 
                Green_Orb.transform.position = new Vector3(54.5400009f, 48.2999992f, 2720.6001f);
                break;
            case 3:
                Green_Orb.transform.position = new Vector3(135.699997f, 48.2999992f, 2769.3999f);
                break;
            case 4:
                Green_Orb.transform.position = new Vector3(41.4000015f, 48.2999992f, 2769.3999f);
                break;
            case 5:
                Green_Orb.transform.position = new Vector3(41.4000015f, 48.2999992f, 2830.30005f);
                break;
            case 6:
                Green_Orb.transform.position = new Vector3(135.100006f, 48.2999992f, 2830.30005f);
                break;
            case 7:
                Green_Orb.transform.position = new Vector3(125.099998f, 48.2999992f, 2885.5f);
                break;
            case 8:
                Green_Orb.transform.position = new Vector3(55.2000008f, 48.2999992f, 2885.5f);
                break;
        }
    }
}
