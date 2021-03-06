using System;
using System.Text;

namespace SKILL
{
	public class GSkill3230Stub : GSkillStub
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
				skill.SetRatio(0.0f);
			}
		}
		public GSkill3230Stub()
			: base(3230)
		{
			occupation = 128;
			maxlevel = 6;
			maxlearn = 6;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 24;
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
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "白色情人节召唤兽用对F";
			nativename = "白色情人节召唤兽用对F";
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
		public override float GetRadius(GSkill skill)
		{
			return 7.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 6.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 5.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 12;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();

			/*
			if ( player.GetTmplid() == 42780 )
			d = 100.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetValue(((player_maxhp + 1)));
			victim.SetDirecthurt(true);
			*/
			return true;
		}
	}
	public class GSkill3230 : GSkill
	{
		public GSkill3230()
			: base(3230)
		{
			
		}
	}
	public class GSkill3231Stub : GSkillStub
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
		public GSkill3231Stub()
			: base(3231)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 14;
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
			SetAction(0,"鬼王宗_乾坤斩");
			SetAction(1,"青云门_乾坤斩");
			SetAction(2,"鬼王宗_乾坤斩");
			SetAction(3,"合欢派_乾坤斩");
			SetAction(4,"天音寺_乾坤斩");
			SetAction(5,"鬼道_乾坤斩");
			SetAction(6,"0");
			SetAction(7,"兽神_一击");
			SetAction(8,"狐妖_风鸣矢");
			SetAction(9,"0");
			SetAction(10,"怀光_浅袭");
			SetAction(11,"0");
			SetAction(12,"天华_初元音刃");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"鬼王宗_骑乘_乾坤斩");
			SetAction(19,"青云门_骑乘_乾坤斩");
			SetAction(20,"鬼王宗_骑乘_乾坤斩");
			SetAction(21,"合欢派_骑乘_乾坤斩");
			SetAction(22,"天音寺_骑乘_乾坤斩");
			SetAction(23,"鬼道_骑乘_乾坤斩");
			SetAction(24,"0");
			SetAction(25,"兽神_骑乘_一击");
			SetAction(26,"狐妖_骑乘_风鸣矢");
			SetAction(27,"0");
			SetAction(28,"怀光_骑乘_浅袭");
			SetAction(29,"0");
			SetAction(30,"天华_骑乘_初元音刃");
			name = "夺回金叶子";
			nativename = "夺回金叶子";
			icon = "追风咒.dds";
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
			return 12000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(101.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(3232.0f);
			victim.SetAmount(3233.0f);
			victim.SetValue(3234.0f);
			victim.SetSetcooldown(true);
			return true;
		}
	}
	public class GSkill3231 : GSkill
	{
		public GSkill3231()
			: base(3231)
		{
			
		}
	}
	public class GSkill3232Stub : GSkillStub
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
		public GSkill3232Stub()
			: base(3232)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 14;
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
			SetAction(0,"鬼王宗_乾坤斩");
			SetAction(1,"青云门_乾坤斩");
			SetAction(2,"鬼王宗_乾坤斩");
			SetAction(3,"合欢派_乾坤斩");
			SetAction(4,"天音寺_乾坤斩");
			SetAction(5,"鬼道_乾坤斩");
			SetAction(6,"0");
			SetAction(7,"兽神_一击");
			SetAction(8,"狐妖_风鸣矢");
			SetAction(9,"0");
			SetAction(10,"怀光_浅袭");
			SetAction(11,"0");
			SetAction(12,"天华_初元音刃");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"鬼王宗_骑乘_乾坤斩");
			SetAction(19,"青云门_骑乘_乾坤斩");
			SetAction(20,"鬼王宗_骑乘_乾坤斩");
			SetAction(21,"合欢派_骑乘_乾坤斩");
			SetAction(22,"天音寺_骑乘_乾坤斩");
			SetAction(23,"鬼道_骑乘_乾坤斩");
			SetAction(24,"0");
			SetAction(25,"兽神_骑乘_一击");
			SetAction(26,"狐妖_骑乘_风鸣矢");
			SetAction(27,"0");
			SetAction(28,"怀光_骑乘_浅袭");
			SetAction(29,"0");
			SetAction(30,"天华_骑乘_初元音刃");
			name = "夺回太极金丹";
			nativename = "夺回太极金丹";
			icon = "御空术.dds";
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
			return 12000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(101.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(3231.0f);
			victim.SetAmount(3233.0f);
			victim.SetValue(3234.0f);
			victim.SetSetcooldown(true);
			return true;
		}
	}
	public class GSkill3232 : GSkill
	{
		public GSkill3232()
			: base(3232)
		{
			
		}
	}
	public class GSkill3233Stub : GSkillStub
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
		public GSkill3233Stub()
			: base(3233)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 14;
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
			SetAction(0,"鬼王宗_乾坤斩");
			SetAction(1,"青云门_乾坤斩");
			SetAction(2,"鬼王宗_乾坤斩");
			SetAction(3,"合欢派_乾坤斩");
			SetAction(4,"天音寺_乾坤斩");
			SetAction(5,"鬼道_乾坤斩");
			SetAction(6,"0");
			SetAction(7,"兽神_一击");
			SetAction(8,"狐妖_风鸣矢");
			SetAction(9,"0");
			SetAction(10,"怀光_浅袭");
			SetAction(11,"0");
			SetAction(12,"天华_初元音刃");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"鬼王宗_骑乘_乾坤斩");
			SetAction(19,"青云门_骑乘_乾坤斩");
			SetAction(20,"鬼王宗_骑乘_乾坤斩");
			SetAction(21,"合欢派_骑乘_乾坤斩");
			SetAction(22,"天音寺_骑乘_乾坤斩");
			SetAction(23,"鬼道_骑乘_乾坤斩");
			SetAction(24,"0");
			SetAction(25,"兽神_骑乘_一击");
			SetAction(26,"狐妖_骑乘_风鸣矢");
			SetAction(27,"0");
			SetAction(28,"怀光_骑乘_浅袭");
			SetAction(29,"0");
			SetAction(30,"天华_骑乘_初元音刃");
			name = "夺回造化珠";
			nativename = "夺回造化珠";
			icon = "怒奔.dds";
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
			return 12000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(101.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(3231.0f);
			victim.SetAmount(3232.0f);
			victim.SetValue(3234.0f);
			victim.SetSetcooldown(true);
			return true;
		}
	}
	public class GSkill3233 : GSkill
	{
		public GSkill3233()
			: base(3233)
		{
			
		}
	}
	public class GSkill3234Stub : GSkillStub
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
		public GSkill3234Stub()
			: base(3234)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = false;
			dobless = true;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 14;
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
			SetAction(0,"鬼王宗_乾坤斩");
			SetAction(1,"青云门_乾坤斩");
			SetAction(2,"鬼王宗_乾坤斩");
			SetAction(3,"合欢派_乾坤斩");
			SetAction(4,"天音寺_乾坤斩");
			SetAction(5,"鬼道_乾坤斩");
			SetAction(6,"0");
			SetAction(7,"兽神_一击");
			SetAction(8,"狐妖_风鸣矢");
			SetAction(9,"0");
			SetAction(10,"怀光_浅袭");
			SetAction(11,"0");
			SetAction(12,"天华_初元音刃");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"鬼王宗_骑乘_乾坤斩");
			SetAction(19,"青云门_骑乘_乾坤斩");
			SetAction(20,"鬼王宗_骑乘_乾坤斩");
			SetAction(21,"合欢派_骑乘_乾坤斩");
			SetAction(22,"天音寺_骑乘_乾坤斩");
			SetAction(23,"鬼道_骑乘_乾坤斩");
			SetAction(24,"0");
			SetAction(25,"兽神_骑乘_一击");
			SetAction(26,"狐妖_骑乘_风鸣矢");
			SetAction(27,"0");
			SetAction(28,"怀光_骑乘_浅袭");
			SetAction(29,"0");
			SetAction(30,"天华_骑乘_初元音刃");
			name = "夺回功德香";
			nativename = "夺回功德香";
			icon = "风行者.dds";
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
			return 12000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 17.000000f;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(101.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(3231.0f);
			victim.SetAmount(3232.0f);
			victim.SetValue(3233.0f);
			victim.SetSetcooldown(true);
			return true;
		}
	}
	public class GSkill3234 : GSkill
	{
		public GSkill3234()
			: base(3234)
		{
			
		}
	}
	public class GSkill3235Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill3235Stub()
			: base(3235)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 1;
			doenchant = true;
			dobless = true;
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
			SetAction(0,"青云门_破魔剑气");
			SetAction(1,"青云门_破魔剑气");
			SetAction(2,"青云门_破魔剑气");
			SetAction(3,"青云门_破魔剑气");
			SetAction(4,"青云门_破魔剑气");
			SetAction(5,"鬼道_玉真诀");
			SetAction(6,"青云门_破魔剑气");
			SetAction(7,"兽神_雪琪之冰霜");
			SetAction(8,"狐妖_雪琪之冰霜");
			SetAction(9,"轩辕_雪琪之冰霜");
			SetAction(10,"怀光_雪琪之冰霜");
			SetAction(11,"兽神_雪琪之冰霜");
			SetAction(12,"天华_雪琪之冰霜");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"武器大师_刀闪");
			SetAction(16,"0");
			SetAction(17,"青云门_破魔剑气");
			SetAction(18,"青云门_骑乘_破魔剑气");
			SetAction(19,"青云门_骑乘_破魔剑气");
			SetAction(20,"青云门_骑乘_破魔剑气");
			SetAction(21,"青云门_骑乘_破魔剑气");
			SetAction(22,"青云门_骑乘_破魔剑气");
			SetAction(23,"鬼道_骑乘_玉真诀");
			SetAction(24,"青云门_骑乘_破魔剑气");
			SetAction(25,"兽神_骑乘_雪琪之冰霜");
			SetAction(26,"狐妖_骑乘_雪琪之冰霜");
			SetAction(27,"轩辕_骑乘_雪琪之冰霜");
			SetAction(28,"怀光_骑乘_雪琪之冰霜");
			SetAction(29,"兽神_骑乘_雪琪之冰霜");
			SetAction(30,"天华_骑乘_雪琪之冰霜");
			name = "雪韵淞情";
			nativename = "雪韵淞情";
			icon = "焚心厉雷.dds";
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
			return 900000;
		}
		public override float GetRadius(GSkill skill)
		{
			return 2.000000f;
		}
		public override float GetAttackdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 35.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 600.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(30000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetBuffid(5);
			victim.SetDecskilldamage(true);
			victim.SetProbability(120.0f);
			victim.SetTime(30000.0f);
			victim.SetBuffid(5);
			victim.SetValue(106.0f);
			victim.SetSubanti(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(12000.0f);
			victim.SetInvincible(true);
			return true;
		}
	}
	public class GSkill3235 : GSkill
	{
		public GSkill3235()
			: base(3235)
		{
			
		}
	}
	public class GSkill3236Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 200;
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

				player.SetPerform(1);
			}
		}
		public GSkill3236Stub()
			: base(3236)
		{
			occupation = 128;
			maxlevel = 999;
			maxlearn = 999;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "可调整单体眩晕";
			nativename = "可调整单体眩晕";
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
			return 400;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 19.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 18.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_res1 = player.GetRes1();

			victim.SetProbability(((player_res1 + 100)));
			victim.SetTime(6000.0f);
			victim.SetDizzy(true);
			return true;
		}
	}
	public class GSkill3236 : GSkill
	{
		public GSkill3236()
			: base(3236)
		{
			
		}
	}
	public class GSkill3237Stub : GSkillStub
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

				player.SetPerform(1);
			}
		}
		public GSkill3237Stub()
			: base(3237)
		{
			occupation = 128;
			maxlevel = 500;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 5;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
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
			SetAction(0,"0");
			SetAction(1,"0");
			SetAction(2,"0");
			SetAction(3,"0");
			SetAction(4,"0");
			SetAction(5,"0");
			SetAction(6,"0");
			SetAction(7,"0");
			SetAction(8,"0");
			SetAction(9,"0");
			SetAction(10,"0");
			SetAction(11,"0");
			SetAction(12,"0");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"0");
			SetAction(19,"0");
			SetAction(20,"0");
			SetAction(21,"0");
			SetAction(22,"0");
			SetAction(23,"0");
			SetAction(24,"0");
			SetAction(25,"0");
			SetAction(26,"0");
			SetAction(27,"0");
			SetAction(28,"0");
			SetAction(29,"0");
			SetAction(30,"0");
			name = "可调海外召唤祝福";
			nativename = "可调海外召唤祝福";
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
		public override float GetRadius(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 4.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 1.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 7.0f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 6;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(120000.0f);
			victim.SetBuffid(2);
			victim.SetValue(zrand(100));
			victim.SetAddattack(true);
			victim.SetProbability(((16 * skill_level)));
			victim.SetTime(120000.0f);
			victim.SetBuffid(5);
			victim.SetValue(zrand(100));
			victim.SetAdddefence(true);
			victim.SetProbability(((16 * skill_level)));
			victim.SetTime(120000.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(5);
			victim.SetInccrithurt(true);
			victim.SetProbability(((14 * skill_level)));
			victim.SetTime(120000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(5);
			victim.SetIncdrugeffect(true);
			return true;
		}
	}
	public class GSkill3237 : GSkill
	{
		public GSkill3237()
			: base(3237)
		{
			
		}
	}
	public class GSkill3238Stub : GSkillStub
	{
		public GSkill3238Stub()
			: base(3238)
		{
			occupation = 129;
			maxlevel = 99;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 13;
			timetype = 0;
			targettype = 0;
			rangetype = 5;
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
			name = "海外任务奖励4状态";
			nativename = "海外任务奖励4状态";
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
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();
			int				skill_level = skill.GetLevel();

			/*
			if ( skill_level == 1 )
			d = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(1800000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(7);
			victim.SetAmount(1.0f);
			if ( player_maxhp * 0.01f * 900.0f <= 2000.0f )
			{
			v34 = player_maxhp * 0.01f * 900.0f;
			}
			else
			{
			v34 = 2000.0f;
			}
			victim.SetValue(v34);
			victim.SetHpgen(true);
			if ( skill_level == 2 )
			v33 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(1800000.0f);
			victim.SetBuffid(7);
			victim.SetAmount(1.0f);
			if ( player_maxmp * 0.01f * 900.0f <= 2000.0f )
			{
			v32 = player_maxmp * 0.01f * 900.0f;
			}
			else
			{
			v32 = 2000.0f;
			}
			victim.SetValue(v32);
			victim.SetMpgen(true);
			if ( skill_level == 3 )
			v31 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(1800000.0f);
			victim.SetBuffid(7);
			victim.SetValue(99.0f);
			victim.SetAdddefence(true);
			if ( skill_level == 4 )
			v30 = 120.0f;
			else
			victim.SetProbability(0.0f);
			victim.SetTime(1800000.0f);
			victim.SetRatio(0.02f);
			victim.SetBuffid(7);
			victim.SetIncattack(true);
			*/
			return true;
		}
	}
	public class GSkill3238 : GSkill
	{
		public GSkill3238()
			: base(3238)
		{
			
		}
	}
	public class GSkill3239Stub : GSkillStub
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
		public GSkill3239Stub()
			: base(3239)
		{
			occupation = 129;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
			doenchant = true;
			dobless = false;
			autoattack = false;
			allowform = 0;
			credittype = 0;
			clearmask = 0;
			skill_limit = 14;
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
			SetAction(0,"鬼王宗_乾坤斩");
			SetAction(1,"青云门_乾坤斩");
			SetAction(2,"鬼王宗_乾坤斩");
			SetAction(3,"合欢派_乾坤斩");
			SetAction(4,"天音寺_乾坤斩");
			SetAction(5,"鬼道_乾坤斩");
			SetAction(6,"0");
			SetAction(7,"兽神_横行");
			SetAction(8,"狐妖_固元术");
			SetAction(9,"0");
			SetAction(10,"怀光_偷袭");
			SetAction(11,"0");
			SetAction(12,"天华_初元音刃");
			SetAction(13,"");
			SetAction(14,"");
			SetAction(15,"");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"鬼王宗_骑乘_乾坤斩");
			SetAction(19,"青云门_骑乘_乾坤斩");
			SetAction(20,"鬼王宗_骑乘_乾坤斩");
			SetAction(21,"合欢派_骑乘_乾坤斩");
			SetAction(22,"天音寺_骑乘_乾坤斩");
			SetAction(23,"鬼道_骑乘_乾坤斩");
			SetAction(24,"0");
			SetAction(25,"兽神_骑乘_横行");
			SetAction(26,"狐妖_骑乘_固元术");
			SetAction(27,"0");
			SetAction(28,"怀光_骑乘_偷袭");
			SetAction(29,"0");
			SetAction(30,"天华_骑乘_初元音刃");
			name = "神秘一击";
			nativename = "神秘一击";
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
			return 3000;
		}
		public override int GetEnmity(GSkill skill)
		{
			return 1;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 11.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetTmplid() != 42891
			&& (v3 = player, GNET::PlayerWrapper::GetTmplid(v3) != 50812) )
			d = 0.0f;
			else
			victim.SetProbability(100.0f);
			victim.SetValue(9999.0f);
			victim.SetDirecthurt(true);
			*/
			return true;
		}
	}
	public class GSkill3239 : GSkill
	{
		public GSkill3239()
			: base(3239)
		{
			
		}
	}
}
