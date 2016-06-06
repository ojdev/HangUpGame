/*
 * 由SharpDevelop创建。
 * 用户： OuJun
 * 日期: 2016/5/17
 * 时间: 20:32
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HangUpGame
{

    /// <summary>
    /// Description of World.
    /// </summary>
    public partial class World : Form
    {
        private Timer Timeline { set; get; }
        private Lead lead = new Lead("");

        Int64 yes;
        Random rand = new Random(DateTime.Now.Millisecond);
        public World()
        {
            yes = Nature.BuildRandomNumber(1, Nature.EncounterProbability);
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
            //string.IsNullOrWhiteSpace(txtLeadName.Text) ? "兔子宝宝" : txtLeadName.Text
            txtLeadName.DataBindings.Add("Text", lead, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            TotaleBloodLabel.DataBindings.Add("Text", lead, "TotaleBlood", false, DataSourceUpdateMode.OnPropertyChanged);
            CurrentBloodLabel.DataBindings.Add("Text", lead, "CurrentBlood", false, DataSourceUpdateMode.OnPropertyChanged);
            CurrentXPLabel.DataBindings.Add("Text", lead, "CurrentXP", false, DataSourceUpdateMode.OnPropertyChanged);
            UpgradeXPLabel.DataBindings.Add("Text", lead, "UpgradeXP", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        void btnGoWorld_Click(object sender, EventArgs e)
        {
            this.Text = string.Format("{5}  |  Blood:{0}/{1}  |  Age:{2}  |		Level:{6}[{7}/{8}]		|  Attack:{3}/{4}", lead.CurrentBlood, lead.TotaleBlood,
                // disable once ConvertToLambdaExpression
                lead.Age,
                lead.AttackMin, lead.AttackMax, lead.Name,
                lead.Level, lead.CurrentXP, lead.UpgradeXP
            );
            Timeline = new Timer();
            Timeline.Interval = 100;
            Timeline.Tick += new EventHandler(TimeProcress);
            lbLog.Items.Add("上路吧！" + lead.Name + "\t\t日志显示为倒叙");
            Timeline.Start();
        }
        private void TimeProcress(object sender, EventArgs e)
        {
            if (Nature.ProcressingValue % yes == 0)
            {
                if (!lead.IsHadMet)
                {
                    Nature.HadMet(lead);
                    this.Invoke(new Action(() => lbLog.Items.Insert(0, "===========================================================================================")));
                    this.Invoke(new Action(() => lbLog.Items.Insert(0, "遇到了" + Nature.CurrentMonster.Name + "\t\t" + Nature.CurrentMonster.CurrentBlood + "/" + Nature.CurrentMonster.TotaleBlood)));
                    lead.IsHadMet = true;
                }
                else
                {
                    /**
					 * 敏捷决定谁先出手
					 **/
                    /**
					 * 你用力一击，对*造成了*点伤害，*[血量/血量;攻击/攻击]
					 * *对你造成了*点伤害,你[血量/血量;攻击/攻击]
					 * *被你打死了，掉落了[*，*，*]
					 * 你死亡了，然后被*{*****}了
					 **/
                    Int64 attack = Nature.Battle(lead);
                    if (!Nature.CurrectAttack)
                    {
                        if (lead.CurrentBlood > 0)
                        {
                            this.Invoke(new Action(() => lbLog.Items.Insert(0, "你用力一击，对[" + Nature.CurrentMonster.Name + "]造成了" + attack + "点伤害\t\t" + Nature.CurrentMonster.Name + "[" + (Nature.CurrentMonster.CurrentBlood > 0 ? Nature.CurrentMonster.CurrentBlood + "/" + Nature.CurrentMonster.TotaleBlood : "死亡") + "]")));
                        }
                        else
                        {
                            this.Invoke(new Action(() => lbLog.Items.Insert(0, "你被[" + Nature.CurrentMonster.Name + "]打死了，然后被奸尸了。")));
                            this.Invoke(new Action(() => lbLog.Items.Insert(0, "===========================================================================================")));
                            this.Invoke(new Action(() => lbLog.Items.Insert(0, "==========================================你被复活了========================================")));
                            this.Invoke(new Action(() => lbLog.Items.Insert(0, "==========================================你又上路了========================================")));
                            Nature.ProcressingValue++;
                            yes = Nature.BuildRandomNumber(1, Nature.EncounterProbability);
                            this.lead.IsHadMet = false;
                            lead.CurrentBlood = lead.TotaleBlood;
                        }
                    }
                    else
                    {
                        if (Nature.CurrentMonster.CurrentBlood > 0)
                        {
                            this.Invoke(new Action(() => lbLog.Items.Insert(0, "[" + Nature.CurrentMonster.Name + "]对你造成了" + attack + "点伤害\t\t你[" + (lead.CurrentBlood > 0 ? lead.CurrentBlood + "/" + lead.TotaleBlood : "死亡") + "]")));
                        }
                        else
                        {
                            this.Invoke(new Action(() => lbLog.Items.Insert(0, "[" + Nature.CurrentMonster.Name + "]被你打死了，只能掉经验。")));
                            lead.Harvest(Nature.CurrentMonster);
                            this.Invoke(new Action(() => lbLog.Items.Insert(0, "===========================================================================================")));
                            this.lead.IsHadMet = false;
                            yes = Nature.BuildRandomNumber(1, Nature.EncounterProbability);
                            Nature.ProcressingValue++;
                        }
                    }
                }
            }
            else
            {
                if (Nature.ProcressingValue % Nature.YearOfDay == 0)
                {
                    lead.Age++;
                }
                lead.AddXP(10);
                this.Invoke(new Action(() =>
                {
                    lbLog.Items.Insert(0, string.Format("无所事事的一天\t\tBlood:{0}/{1}\tAge:{2}\tAttack:{3}/{4}", lead.CurrentBlood, lead.TotaleBlood,
                        // disable once ConvertToLambdaExpression
                        lead.Age,
                        lead.AttackMin, lead.AttackMax));
                    this.Text = string.Format("{5}  |  Blood:{0}/{1}  |  Age:{2}  |		Level:{6}[{7}/{8}]		|  Attack:{3}/{4}", lead.CurrentBlood, lead.TotaleBlood,
                        // disable once ConvertToLambdaExpression
                        lead.Age,
                        lead.AttackMin, lead.AttackMax, lead.Name,
                        lead.Level, lead.CurrentXP, lead.UpgradeXP
                    );
                }));
                Nature.ProcressingValue++;
            }
        }
    }
}
