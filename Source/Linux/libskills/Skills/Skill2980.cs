using System;
using System.Text;

namespace SKILL
{
	public class GSkill2980Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill2980Stub()
			: base(2980)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 23;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"??????_??ľ??");
			SetAction(1,"??????_????????");
			SetAction(2,"??????_??ľ??");
			SetAction(3,"?ϻ???_????");
			SetAction(4,"??????_?׽");
			SetAction(5,"????_Ǭ??ն");
			SetAction(6,"0");
			SetAction(7,"????_????");
			SetAction(8,"????_??Ԫ??");
			SetAction(9,"0");
			SetAction(10,"????_͵Ϯ");
			SetAction(11,"0");
			SetAction(12,"?컪_????");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"??????_????_??ľ??");
			SetAction(19,"??????_????_????????");
			SetAction(20,"??????_????_??ľ??");
			SetAction(21,"?ϻ???_????_????");
			SetAction(22,"??????_????_?׽");
			SetAction(23,"????_????_Ǭ??ն");
			SetAction(24,"0");
			SetAction(25,"????_????_????");
			SetAction(26,"????_????_??Ԫ??");
			SetAction(27,"0");
			SetAction(28,"????_????_͵Ϯ");
			SetAction(29,"0");
			SetAction(30,"?컪_????_????");
			name = "????????";
			nativename = "????????";
			icon = "";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1800000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 27.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(40882.0f);
			victim.SetCreateitem(true);
			victim.SetTime(500.0f);
			victim.SetInvincible(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(40892.0f);
			victim.SetCreateitem(true);
			victim.SetProbability(100.0f);
			victim.SetTime(1800000.0f);
			victim.SetRatio(2978.0f);
			victim.SetAmount(2982.0f);
			victim.SetValue(2984.0f);
			victim.SetSetcooldown(true);
			return true;
		}
	}
	public class GSkill2980 : GSkill
	{
		public GSkill2980()
			: base(2980)
		{
			
		}
	}
	public class GSkill2981Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill2981Stub()
			: base(2981)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 23;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"??????_??ľ??");
			SetAction(1,"??????_????????");
			SetAction(2,"??????_??ľ??");
			SetAction(3,"?ϻ???_????");
			SetAction(4,"??????_?׽");
			SetAction(5,"????_Ǭ??ն");
			SetAction(6,"0");
			SetAction(7,"????_????");
			SetAction(8,"????_??Ԫ??");
			SetAction(9,"0");
			SetAction(10,"????_͵Ϯ");
			SetAction(11,"0");
			SetAction(12,"?컪_????");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"??????_????_??ľ??");
			SetAction(19,"??????_????_????????");
			SetAction(20,"??????_????_??ľ??");
			SetAction(21,"?ϻ???_????_????");
			SetAction(22,"??????_????_?׽");
			SetAction(23,"????_????_Ǭ??ն");
			SetAction(24,"0");
			SetAction(25,"????_????_????");
			SetAction(26,"????_????_??Ԫ??");
			SetAction(27,"0");
			SetAction(28,"????_????_͵Ϯ");
			SetAction(29,"0");
			SetAction(30,"?컪_????_????");
			name = "??????Ů";
			nativename = "??????Ů";
			icon = "";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1800000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 27.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(40883.0f);
			victim.SetCreateitem(true);
			victim.SetTime(500.0f);
			victim.SetInvincible(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(40892.0f);
			victim.SetCreateitem(true);
			victim.SetProbability(100.0f);
			victim.SetTime(1800000.0f);
			victim.SetRatio(2979.0f);
			victim.SetAmount(2983.0f);
			victim.SetValue(2985.0f);
			victim.SetSetcooldown(true);
			return true;
		}
	}
	public class GSkill2981 : GSkill
	{
		public GSkill2981()
			: base(2981)
		{
			
		}
	}
	public class GSkill2982Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill2982Stub()
			: base(2982)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 23;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"??????_??ľ??");
			SetAction(1,"??????_????????");
			SetAction(2,"??????_??ľ??");
			SetAction(3,"?ϻ???_????");
			SetAction(4,"??????_?׽");
			SetAction(5,"????_Ǭ??ն");
			SetAction(6,"0");
			SetAction(7,"????_????");
			SetAction(8,"????_??Ԫ??");
			SetAction(9,"0");
			SetAction(10,"????_͵Ϯ");
			SetAction(11,"0");
			SetAction(12,"?컪_????");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"??????_????_??ľ??");
			SetAction(19,"??????_????_????????");
			SetAction(20,"??????_????_??ľ??");
			SetAction(21,"?ϻ???_????_????");
			SetAction(22,"??????_????_?׽");
			SetAction(23,"????_????_Ǭ??ն");
			SetAction(24,"0");
			SetAction(25,"????_????_????");
			SetAction(26,"????_????_??Ԫ??");
			SetAction(27,"0");
			SetAction(28,"????_????_͵Ϯ");
			SetAction(29,"0");
			SetAction(30,"?컪_????_????");
			name = "???꿨??";
			nativename = "???꿨??";
			icon = "";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1800000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 27.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(40884.0f);
			victim.SetCreateitem(true);
			victim.SetTime(500.0f);
			victim.SetInvincible(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(40892.0f);
			victim.SetCreateitem(true);
			victim.SetProbability(100.0f);
			victim.SetTime(1800000.0f);
			victim.SetRatio(2978.0f);
			victim.SetAmount(2980.0f);
			victim.SetValue(2984.0f);
			victim.SetSetcooldown(true);
			return true;
		}
	}
	public class GSkill2982 : GSkill
	{
		public GSkill2982()
			: base(2982)
		{
			
		}
	}
	public class GSkill2983Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill2983Stub()
			: base(2983)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 23;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"??????_??ľ??");
			SetAction(1,"??????_????????");
			SetAction(2,"??????_??ľ??");
			SetAction(3,"?ϻ???_????");
			SetAction(4,"??????_?׽");
			SetAction(5,"????_Ǭ??ն");
			SetAction(6,"0");
			SetAction(7,"????_????");
			SetAction(8,"????_??Ԫ??");
			SetAction(9,"0");
			SetAction(10,"????_͵Ϯ");
			SetAction(11,"0");
			SetAction(12,"?컪_????");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"??????_????_??ľ??");
			SetAction(19,"??????_????_????????");
			SetAction(20,"??????_????_??ľ??");
			SetAction(21,"?ϻ???_????_????");
			SetAction(22,"??????_????_?׽");
			SetAction(23,"????_????_Ǭ??ն");
			SetAction(24,"0");
			SetAction(25,"????_????_????");
			SetAction(26,"????_????_??Ԫ??");
			SetAction(27,"0");
			SetAction(28,"????_????_͵Ϯ");
			SetAction(29,"0");
			SetAction(30,"?컪_????_????");
			name = "???꿨Ů";
			nativename = "???꿨Ů";
			icon = "";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1800000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 27.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(40885.0f);
			victim.SetCreateitem(true);
			victim.SetTime(500.0f);
			victim.SetInvincible(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(40892.0f);
			victim.SetCreateitem(true);
			victim.SetProbability(100.0f);
			victim.SetTime(1800000.0f);
			victim.SetRatio(2979.0f);
			victim.SetAmount(2981.0f);
			victim.SetValue(2985.0f);
			victim.SetSetcooldown(true);
			return true;
		}
	}
	public class GSkill2983 : GSkill
	{
		public GSkill2983()
			: base(2983)
		{
			
		}
	}
	public class GSkill2984Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill2984Stub()
			: base(2984)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 23;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"??????_??ľ??");
			SetAction(1,"??????_????????");
			SetAction(2,"??????_??ľ??");
			SetAction(3,"?ϻ???_????");
			SetAction(4,"??????_?׽");
			SetAction(5,"????_Ǭ??ն");
			SetAction(6,"0");
			SetAction(7,"????_????");
			SetAction(8,"????_??Ԫ??");
			SetAction(9,"0");
			SetAction(10,"????_͵Ϯ");
			SetAction(11,"0");
			SetAction(12,"?컪_????");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"??????_????_??ľ??");
			SetAction(19,"??????_????_????????");
			SetAction(20,"??????_????_??ľ??");
			SetAction(21,"?ϻ???_????_????");
			SetAction(22,"??????_????_?׽");
			SetAction(23,"????_????_Ǭ??ն");
			SetAction(24,"0");
			SetAction(25,"????_????_????");
			SetAction(26,"????_????_??Ԫ??");
			SetAction(27,"0");
			SetAction(28,"????_????_͵Ϯ");
			SetAction(29,"0");
			SetAction(30,"?컪_????_????");
			name = "???˿???";
			nativename = "???˿???";
			icon = "";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1800000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 27.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(40886.0f);
			victim.SetCreateitem(true);
			victim.SetTime(500.0f);
			victim.SetInvincible(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(40892.0f);
			victim.SetCreateitem(true);
			victim.SetProbability(100.0f);
			victim.SetTime(1800000.0f);
			victim.SetRatio(2978.0f);
			victim.SetAmount(2980.0f);
			victim.SetValue(2982.0f);
			victim.SetSetcooldown(true);
			return true;
		}
	}
	public class GSkill2984 : GSkill
	{
		public GSkill2984()
			: base(2984)
		{
			
		}
	}
	public class GSkill2985Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill2985Stub()
			: base(2985)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 23;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"??????_??ľ??");
			SetAction(1,"??????_????????");
			SetAction(2,"??????_??ľ??");
			SetAction(3,"?ϻ???_????");
			SetAction(4,"??????_?׽");
			SetAction(5,"????_Ǭ??ն");
			SetAction(6,"0");
			SetAction(7,"????_????");
			SetAction(8,"????_??Ԫ??");
			SetAction(9,"0");
			SetAction(10,"????_͵Ϯ");
			SetAction(11,"0");
			SetAction(12,"?컪_????");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"??????_????_??ľ??");
			SetAction(19,"??????_????_????????");
			SetAction(20,"??????_????_??ľ??");
			SetAction(21,"?ϻ???_????_????");
			SetAction(22,"??????_????_?׽");
			SetAction(23,"????_????_Ǭ??ն");
			SetAction(24,"0");
			SetAction(25,"????_????_????");
			SetAction(26,"????_????_??Ԫ??");
			SetAction(27,"0");
			SetAction(28,"????_????_͵Ϯ");
			SetAction(29,"0");
			SetAction(30,"?컪_????_????");
			name = "???˿?Ů";
			nativename = "???˿?Ů";
			icon = "";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1800000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 27.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(40887.0f);
			victim.SetCreateitem(true);
			victim.SetTime(500.0f);
			victim.SetInvincible(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(40892.0f);
			victim.SetCreateitem(true);
			victim.SetProbability(100.0f);
			victim.SetTime(1800000.0f);
			victim.SetRatio(2979.0f);
			victim.SetAmount(2981.0f);
			victim.SetValue(2983.0f);
			victim.SetSetcooldown(true);
			return true;
		}
	}
	public class GSkill2985 : GSkill
	{
		public GSkill2985()
			: base(2985)
		{
			
		}
	}
	public class GSkill2986Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetVar1(zrand(100));
				player.SetPerform(1);
			}
		}
		public GSkill2986Stub()
			: base(2986)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 23;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"??????_??ľ??");
			SetAction(1,"??????_????????");
			SetAction(2,"??????_??ľ??");
			SetAction(3,"?ϻ???_????");
			SetAction(4,"??????_?׽");
			SetAction(5,"????_Ǭ??ն");
			SetAction(6,"0");
			SetAction(7,"????_????");
			SetAction(8,"????_??Ԫ??");
			SetAction(9,"0");
			SetAction(10,"????_͵Ϯ");
			SetAction(11,"0");
			SetAction(12,"?컪_????");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"??????_????_??ľ??");
			SetAction(19,"??????_????_????????");
			SetAction(20,"??????_????_??ľ??");
			SetAction(21,"?ϻ???_????_????");
			SetAction(22,"??????_????_?׽");
			SetAction(23,"????_????_Ǭ??ն");
			SetAction(24,"0");
			SetAction(25,"????_????_????");
			SetAction(26,"????_????_??Ԫ??");
			SetAction(27,"0");
			SetAction(28,"????_????_͵Ϯ");
			SetAction(29,"0");
			SetAction(30,"?컪_????_????");
			name = "???ؿ?";
			nativename = "???ؿ?";
			icon = "";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 1800000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 22.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 27.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();

			/*
			if ( player_var1 > 84 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			if ( player_var1 <= 48 )
			v21 = 40888.0f;
			else
			victim.SetValue(40889.0f);
			victim.SetCreateitem(true);
			if ( player_var1 <= 84 )
			v20 = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			if ( player_var1 <= 96 )
			v19 = 40890.0f;
			else
			victim.SetValue(40891.0f);
			victim.SetCreateitem(true);
			victim.SetTime(500.0f);
			victim.SetInvincible(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(40892.0f);
			victim.SetCreateitem(true);
			if ( zrand(100) > 20 )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetRatio(0.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(40920.0f);
			victim.SetCreateitem(true);
			*/
			return true;
		}
	}
	public class GSkill2986 : GSkill
	{
		public GSkill2986()
			: base(2986)
		{
			
		}
	}
	public class GSkill2987Stub : GSkillStub
	{
		public GSkill2987Stub()
			: base(2987)
		{
			occupation = 129;
			maxlevel = 4;
			maxlearn = 4;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 13;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 0;
			succeedskillcolornum = 0;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"");
			SetAction(1,"");
			SetAction(2,"");
			SetAction(3,"");
			SetAction(4,"");
			SetAction(5,"");
			SetAction(6,"");
			SetAction(7,"");
			SetAction(8,"");
			SetAction(9,"");
			SetAction(10,"");
			SetAction(11,"");
			SetAction(12,"");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"");
			SetAction(19,"");
			SetAction(20,"");
			SetAction(21,"");
			SetAction(22,"");
			SetAction(23,"");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "??Ϧ???buff";
			nativename = "??Ϧ???buff";
			icon = "";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			if ( skill_level == 1 )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(7200000.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(4);
			victim.SetIncattack(true);
			if ( skill_level == 2 )
			v23 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(7200000.0f);
			victim.SetRatio(0.050000001f);
			victim.SetBuffid(4);
			victim.SetIncdefence(true);
			if ( skill_level == 3 )
			t = 7200000.0f;
			else
			victim.SetTime(0.0f);
			victim.SetRatio(0.02001f);
			victim.SetInccritrate(true);
			if ( skill_level == 4 )
			v21 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(7200000.0f);
			victim.SetRatio(0.1001f);
			victim.SetBuffid(4);
			victim.SetInccrithurt(true);
			*/
			return true;
		}
	}
	public class GSkill2987 : GSkill
	{
		public GSkill2987()
			: base(2987)
		{
			
		}
	}
	public class GSkill2988Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 500;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill2988Stub()
			: base(2988)
		{
			occupation = 152;
			maxlevel = 4;
			maxlearn = 4;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 8;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 7;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"??????_Ǭ??ն");
			SetAction(1,"??????_Ǭ??ն");
			SetAction(2,"??????_Ǭ??ն");
			SetAction(3,"?ϻ???_Ǭ??ն");
			SetAction(4,"??????_Ǭ??ն");
			SetAction(5,"0");
			SetAction(6,"????_Ǭ??ն");
			SetAction(7,"????_????");
			SetAction(8,"????_??Ԫ??");
			SetAction(9,"0");
			SetAction(10,"????_͵Ϯ");
			SetAction(11,"????_????");
			SetAction(12,"?컪_??Ԫ????");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"0");
			SetAction(16,"0");
			SetAction(17,"??????_Ǭ??ն");
			SetAction(18,"??????_????_Ǭ??ն");
			SetAction(19,"??????_????_Ǭ??ն");
			SetAction(20,"??????_????_Ǭ??ն");
			SetAction(21,"?ϻ???_????_Ǭ??ն");
			SetAction(22,"??????_????_Ǭ??ն");
			SetAction(23,"0");
			SetAction(24,"????_????_Ǭ??ն");
			SetAction(25,"????_????_????");
			SetAction(26,"????_????_??Ԫ??");
			SetAction(27,"0");
			SetAction(28,"????_????_͵Ϯ");
			SetAction(29,"????_????_????");
			SetAction(30,"?컪_????_??Ԫ????");
			name = "????ԭ??";
			nativename = "????ԭ??";
			icon = "";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 4.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(120.0f);
			victim.SetRatio(419.0f);
			victim.SetAmount(420.0f);
			victim.SetValue(419.0f);
			victim.SetCleartransform(true);
			victim.SetProbability(120.0f);
			victim.SetRatio(421.0f);
			victim.SetAmount(422.0f);
			victim.SetValue(421.0f);
			victim.SetCleartransform(true);
			victim.SetProbability(120.0f);
			victim.SetTime(1800000.0f);
			victim.SetRatio(1.0f);
			victim.SetAmount(1.0f);
			victim.SetValue(((skill_level + 418)));
			victim.SetTransform(true);
			return true;
		}
	}
	public class GSkill2988 : GSkill
	{
		public GSkill2988()
			: base(2988)
		{
			
		}
	}
	public class GSkill2989Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPray(1);
			}
		}
		public class GState2 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 200;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				skill.SetRatio(0.0f);
				player.SetPerform(1);
			}
		}
		public GSkill2989Stub()
			: base(2989)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 0;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = true;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 0;
			skillelemsnum = 0;
			skillelemsfactor = 0.000000f;
			serialskill = 0;
			charge = 0;
			chargedist = 0.000000f;
			succeedskillcolor = 1;
			succeedskillcolornum = 1;
			comboskill = 0;
			need_item = false;
			item1_id = -1;
			item1_num = 0;
			item2_id = -1;
			item2_num = 0;
			item_relation = 0;
			weapon_limit = -1;
			SetAction(0,"??????_Ǭ??ն");
			SetAction(1,"??????_Ǭ??ն");
			SetAction(2,"??????_Ǭ??ն");
			SetAction(3,"?ϻ???_Ǭ??ն");
			SetAction(4,"??????_Ǭ??ն");
			SetAction(5,"????_Ǭ??ն");
			SetAction(6,"0");
			SetAction(7,"????_һ??");
			SetAction(8,"????_????ʸ");
			SetAction(9,"0");
			SetAction(10,"????_ǳϮ");
			SetAction(11,"0");
			SetAction(12,"?컪_??Ԫ????");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"??????_????_Ǭ??ն");
			SetAction(19,"??????_????_Ǭ??ն");
			SetAction(20,"??????_????_Ǭ??ն");
			SetAction(21,"?ϻ???_????_Ǭ??ն");
			SetAction(22,"??????_????_Ǭ??ն");
			SetAction(23,"????_????_Ǭ??ն");
			SetAction(24,"0");
			SetAction(25,"????_????_һ??");
			SetAction(26,"????_????_????ʸ");
			SetAction(27,"0");
			SetAction(28,"????_????_ǳϮ");
			SetAction(29,"0");
			SetAction(30,"?컪_????_??Ԫ????");
			name = "??????????";
			nativename = "??????????";
			icon = "ʧ????.dds";
			SetTalent(0,0);
			SetTalent(1,0);
			SetTalent(2,0);
			SetTalent(3,0);
			SetTalent(4,0);
			SetTalent(5,0);
			SetTalent(6,0);
			SetTalent(7,0);
			talent_size = 0;
			talent_type = 0;
			use_proficiency = false;
			inc_proficiency = 0;
			preskillnum = 0;
			cycle = false;
			cyclemode = 0;
			cyclegfx = "";
			skill_class = -2;
			guide = false;
			summon_id = 0;
			trigger = false;
			conbutton_sub = false;
			isBabySkill = false;
			castInPreSkill = false;
			preCastSkillId = 0;
			darkLightType = 0;
			followskill = 0;
			targetcnt = 0;
			excludemonstercnt = 0;

			AddState(new GState1());
			AddState(new GState2());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 1000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetTmplid() == 41014 )
			d = 800.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(6000.0f);
			victim.SetDizzy(true);
			if ( player.GetTmplid() == 41007 )
			v12 = 100.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetValue(((zrand(500) + 250)));
			victim.SetDirecthurt(true);
			*/
			return true;
		}
	}
	public class GSkill2989 : GSkill
	{
		public GSkill2989()
			: base(2989)
		{
			
		}
	}
}
