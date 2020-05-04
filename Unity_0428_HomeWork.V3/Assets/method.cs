using UnityEngine;
using UnityEngine.UI;

public class method : MonoBehaviour
{
    public monster Bat;
    public monster Slime;

    [Header ("戰鬥訊息")]
    public Text info;   //畫面中央訊息
    public Text boxL;   //蝙蝠加扣血訊息 
    public Text boxR;   //史萊姆加扣血訊息

    [Header ("血量資訊")]
    public Text BHP;  //扣加血資訊
    public Text SHP;  //扣加血資訊



    public void Update()
    {
        BHP.text = "蝙蝠血量 : " + Bat.Hp;      //血量資訊
        SHP.text = "史萊姆血量 : " + Slime.Hp;  //血量資訊
    }

    /// <summary>
    /// 蝙蝠攻擊
    /// </summary>
    public void BAtk()
    {
        Slime.Hp = Slime.Hp-Bat.Atk;
        info.text = "<color=#00FF01FF>史萊姆</color> - 受到了攻擊" + Bat .Atk+ "\n" + "<color=#00FF01FF>史萊姆</color> - 血量剩下" + Slime.Hp ;
        boxR.text = "-" + Bat.Atk;
        boxL.text = "";
    }

    /// <summary>
    /// 蝙蝠治癒
    /// </summary>
    public void BHeal()
    {
        Bat .Hp = Bat .Hp + Bat.Heal;
        info.text = "<color=#000000>蝙蝠</color> - 受到治療" + Bat.Heal + "\n" + "<color=#000000>蝙蝠</color> - 血量剩下" + Bat.Hp;
        boxR.text = "" ;
        boxL.text = "+" + Bat.Heal;
    }

    /// <summary>
    /// 史萊姆攻擊
    /// </summary>
    public void SAtk()
    {
        Bat.Hp = Bat.Hp - Slime.Atk;
        info.text = "<color=#000000>蝙蝠</color> - 受到了攻擊" + Slime.Atk + "\n" + "<color=#000000>蝙蝠</color> - 血量剩下" + Bat.Hp;
        boxR.text = "" ;
        boxL.text = "-" + Slime.Atk;
    }

    /// <summary>
    /// 史萊姆治癒
    /// </summary>
    public void SHeal()
    {
        Slime.Hp = Slime.Hp + Slime.Heal;
        info.text = "<color=#00FF01FF>史萊姆</color> - 受到治療" + Slime .Heal + "\n" + "<color=#00FF01FF>史萊姆</color> - 血量剩下" + Slime .Hp;
        boxR.text = "+" + Slime .Heal;
        boxL.text = "";
    }

}
