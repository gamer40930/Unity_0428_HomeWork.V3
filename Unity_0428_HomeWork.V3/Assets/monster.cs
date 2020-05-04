using UnityEngine;
using UnityEngine.UI;

public class monster : MonoBehaviour
{
    /// <summary>
    /// 腳色數值設定
    /// </summary>
    [Header ("血量")]
    public float  Hp;
    [Header("攻擊力")]
    public float Atk;
    [Header("治癒力")]
    public float Heal;

    
    

    public void Update()
    {
        print( gameObject .name + "血量" +Hp); //當前血量測試
    }


}
