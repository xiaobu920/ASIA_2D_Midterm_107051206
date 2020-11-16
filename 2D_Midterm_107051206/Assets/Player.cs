using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // 儲存資料
    // 修飾詞 類型 名稱 (指定 值)；
    public GameObject final;
    // 道具數量
    public Text textCount;
    // 數量
    public int count;


    // collision 儲存碰到物件的資訊


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if(條件) { 條件成立時會執行的程式區塊 }
        // 如果碰到物件的名稱是傳送門就...
        print("角色碰到傳送門");

        if (collision.name == "傳送門")
        {
            final.SetActive(true);  
        }

    }
}