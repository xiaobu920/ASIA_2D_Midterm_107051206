using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject final;
    public Text textCount;
    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if { 條件成立時會執行的程式區塊 }
        // 如果碰到物件的名稱是傳送門就...
        print("角色碰到傳送門");
        if (collision.name == "傳送門")
        {
            final.SetActive(true);  
        }

        if (collision.tag == "草莓")
        {
            Destroy(collision.gameObject);
            count++;
            textCount.text = "草莓數量：" + count;
        }
    }
}