﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSave : MonoBehaviour
{
    // Start is called before the first frame update
    private string[] text = new string[9] { "干扰装置（level 1）：10s内不会受到装置作用范围内怪物的伤害\n装置CD：20步\n建造消耗：1芯片+100物资+100电力",
                                            "干扰装置（level 2）：10s内不会受到装置作用范围内怪物的伤害，作用范围扩大6格\n装置CD：20步\n建造消耗：1芯片+100物资+100电力",
                                            "干扰装置（level 3）：10s内不会受到装置作用范围内怪物的伤害，作用范围扩大6格\n装置CD：20步\n建造消耗：1芯片+100物资+100电力",
                                            "克隆装置（level 1）：20s内使选定格子资源增加1倍，若含有怪物则数量同样增加；当前等级可克隆1次\n装置CD：16步\n建造消耗：1芯片+140物资+60电力",
                                            "克隆装置（level 2）：20s内使选定格子资源增加1倍，若含有怪物则数量同样增加；当前等级可克隆2次（可选择同一格子）\n装置CD：16步\n建造消耗：1芯片+140物资+60电力",
                                            "克隆装置（level 3）：20s内使选定格子资源增加1倍，若含有怪物则数量同样增加；当前等级可克隆3次（可选择同一格子）\n装置CD：16步\n建造消耗：1芯片+140物资+60电力",
                                            "探测装置（level 1）：可在物资/电力/医疗包/芯片/怪物中选择任一类型格子进行探测，当前等级持续时间为10s\n装置CD：25步\n建造消耗：1芯片+60物资+140电力",
                                            "探测装置（level 2）：可在物资/电力/医疗包/芯片/怪物中选择任一类型格子进行探测，当前等级持续时间为20s\n装置CD：25步\n建造消耗：1芯片+60物资+140电力",
                                            "探测装置（level 3）：可在物资/电力/医疗包/芯片/怪物中选择任一类型格子进行探测，当前等级持续时间为30s\n装置CD：25步\n建造消耗：1芯片+60物资+140电力"};
    public string gettext(int num)
    {
        int x = num % 3, y = num / 3;
        return text[x*3+y];
    }
}