using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallSize : MonoBehaviour
{
    public GameObject Player;
    public Dropdown PlayerSize;
    private float size = 1.0f;

    public void ChangeSize ()
    {
        switch(PlayerSize.value)
        {
            case 1:
                size = 2.0f;
                break;
            case 2:
                size = 3.0f;
                break;
            default:
                size = 1.0f;
                break;
        }
    Player.transform.localScale = new Vector3(size,size,size);
    Player.transform.localPosition = new Vector3(Player.transform.localPosition.x, 0.5f * size,
    Player.transform.localPosition.z);
    }
}
