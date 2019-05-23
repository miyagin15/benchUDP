
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public GameObject obj;
    // カウンター
    private int counter = 0;

    // Use this for initialization
    void Start()
    {
        // 最初の位置を設定
        obj.transform.position = new Vector3(0.0f, 3.0f, 5.0f);
    }

    public void OnClick()
    {
        // クリックでカウントアップ
        counter++;

        // カウントアップに応じて位置を変える
        if (counter % 4 == 0)
        {
            obj.transform.position = new Vector3(1.0f, 1.0f, 1.0f);
        }
        else if (counter % 4 == 1)
        {
            obj.transform.position = new Vector3(-1.0f, -1.0f, 1.0f);
        }
        else if (counter % 4 == 2)
        {
            obj.transform.position = new Vector3(-1.0f, 3.0f, -1.0f);
        }
        else if (counter % 4 == 3)
        {
            obj.transform.position = new Vector3(-1.0f, 1.0f, 1.0f);
        }
    }
}