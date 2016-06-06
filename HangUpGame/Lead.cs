/*
 * 由SharpDevelop创建。
 * 用户： OuJun
 * 日期: 2016/5/17
 * 时间: 19:48
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Threading;
using HangUpGame.Equipment.Head;
using HangUpGame.Equipment.Weapon;
using HangUpGame.Monster;
using System.ComponentModel;

namespace HangUpGame
{
    /// <summary>
    /// Description of Lead.
    /// </summary>
    public class Lead : INotifyPropertyChanged
    {
        #region 主角属性
        private string _Name = "兔子宝宝";
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name
        {
            set
            {
                if (value != _Name)
                {
                    _Name = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
                }
            }
            get
            {
                return _Name;
            }
        }
        private Int64 _Age = 0;
        /// <summary>
        /// 年龄
        /// </summary>
        public Int64 Age
        {
            set
            {
                _Age = value;
                this.CurrentBlood += (Int64)(_Age * 0.75);
                this.TotaleBlood += (Int64)(_Age * 0.75);
                this.AttackMin += (Int64)(_Age * 0.5);
                this.AttackMax += (Int64)(_Age * 0.5);
            }
            get
            {
                return _Age;
            }
        }
        private Int64 _Level = 0;
        /// <summary>
        /// 等级
        /// </summary>
        public Int64 Level
        {
            set
            {
                _Level = value;
                this.CurrentBlood += (Int64)(_Level * 0.75);
                this.TotaleBlood += (Int64)(_Level * 0.75);
                this.AttackMin += (Int64)(_Level * 0.5);
                this.AttackMax += (Int64)(_Level * 0.5);
            }
            get
            {
                return _Level;
            }
        }
        private Int64 _CurrentXP = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 当前经验值
        /// </summary>
        public Int64 CurrentXP
        {
            set
            {
                _CurrentXP += value;
                if (_CurrentXP >= UpgradeXP)
                {
                    Level += 1;
                    _CurrentXP = 0;
                    UpgradeXP *= 2;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UpgradeXP)));
                }
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentXP)));
            }
            get { return _CurrentXP; }
        }
        /// <summary>
        /// 升级需要的经验值
        /// </summary>
        public Int64 UpgradeXP { set; get; }
        private Int64 _CurrentBlood;
        /// <summary>
        /// 当前血量
        /// </summary>
        public Int64 CurrentBlood
        {
            set
            {
                if (value != _CurrentBlood)
                {
                    _CurrentBlood = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentBlood)));
                }
            }
            get
            {
                return _CurrentBlood;
            }
        }
        private Int64 _TotaleBlood;
        /// <summary>
        /// 总血量
        /// </summary>
        public Int64 TotaleBlood
        {
            set
            {
                if (value != _TotaleBlood)
                {
                    _TotaleBlood = value;

                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TotaleBlood)));
                }
            }
            get
            {
                return _TotaleBlood;
            }
        }
        /// <summary>
        /// 最小攻击力
        /// </summary>
        public Int64 AttackMin { set; get; }
        /// <summary>
        /// 最大攻击力
        /// </summary>
        public Int64 AttackMax { set; get; }
        /// <summary>
        /// 是否遭遇怪物
        /// </summary>
        public bool IsHadMet { set; get; }
        /// <summary>
        /// 暴击率
        /// </summary>
        public double CritChance { set; get; }
        #endregion
        #region 装备
        /// <summary>
        /// 头部防具
        /// </summary>
        public IHead head { set; get; }
        public IWeapon weapon { set; get; }
        #endregion
        /// <summary>
        /// 主角出生了
        /// </summary>
        /// <param name="LeadName">给主角一个名字</param>
        public Lead(string LeadName)
        {
            if (!string.IsNullOrWhiteSpace(LeadName)) this.Name = LeadName;
            this.Age = 0;
            this.AttackMin = 1;
            this.AttackMax = 5;
            this.CurrentXP = 0;
            this.UpgradeXP = 1000;
            this.TotaleBlood = this.CurrentBlood = 10;
            this.IsHadMet = false;
            this.CritChance = 1.0;

            this.head = new BaseHead();
            this.SetWeapon(new BaseWeapon());
        }
        public void Attacked(Int64 attack)
        {
            this.CurrentBlood -= attack;
        }
        /// <summary>
        /// 装备武器
        /// </summary>
        /// <param name="weapon"></param>
        public void SetWeapon(IWeapon weapon)
        {
            this.AttackMin += weapon.MinAttack;
            this.AttackMax += weapon.MaxAttack;
            this.CritChance += weapon.CritChance;
        }
        public void AddXP(Int64 xpValue)
        {
            CurrentXP = xpValue;
        }
        public void Harvest(IMonster monster)
        {
            CurrentXP = monster.DropXP;
        }
    }
}
