/*
 * 金庸群侠传3D重制版
 * https://github.com/jynew/jynew
 *
 * 这是本开源项目文件头，所有代码均使用MIT协议。
 * 但游戏内资源和第三方插件、dll等请仔细阅读LICENSE相关授权协议文档。
 *
 * 金庸老先生千古！
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jyx2
{
    //战斗行动指令
    public class BattleAction
    {
        //移动到的坐标
        public BattleBlockVector MoveTo;

        //使用技能
        public BattleZhaoshiInstance Skill;

        //技能释放点
        public BattleBlockVector SkillTo;
    }
}
