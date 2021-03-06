using System;
using System.Text;

namespace SKILL
{
	public class GSkill3900Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
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
		public GSkill3900Stub()
			: base(3900)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 0;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 5;
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
			name = "五年之庆";
			nativename = "五年之庆";
			icon = "疗伤.dds";
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
			return 60000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(14400000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(720000.0f);
			victim.SetHpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(14400000.0f);
			victim.SetBuffid(1);
			victim.SetAmount(0.0f);
			victim.SetValue(1440000.0f);
			victim.SetMpgen(true);
			return true;
		}
	}
	public class GSkill3900 : GSkill
	{
		public GSkill3900()
			: base(3900)
		{
			
		}
	}
	public class GSkill3901Stub : GSkillStub
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
		public GSkill3901Stub()
			: base(3901)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"技能攻击3");
			SetAction(1,"技能攻击3");
			SetAction(2,"技能攻击3");
			SetAction(3,"技能攻击3");
			SetAction(4,"技能攻击3");
			SetAction(5,"技能攻击3");
			SetAction(6,"技能攻击3");
			SetAction(7,"技能攻击3");
			SetAction(8,"技能攻击3");
			SetAction(9,"技能攻击3");
			SetAction(10,"技能攻击3");
			SetAction(11,"技能攻击3");
			SetAction(12,"技能攻击3");
			SetAction(13,"技能攻击3");
			SetAction(14,"技能攻击3");
			SetAction(15,"技能攻击3");
			SetAction(16,"");
			SetAction(17,"");
			SetAction(18,"技能攻击3");
			SetAction(19,"技能攻击3");
			SetAction(20,"技能攻击3");
			SetAction(21,"技能攻击3");
			SetAction(22,"技能攻击3");
			SetAction(23,"技能攻击3");
			SetAction(24,"技能攻击3");
			SetAction(25,"技能攻击3");
			SetAction(26,"技能攻击3");
			SetAction(27,"技能攻击3");
			SetAction(28,"技能攻击3");
			SetAction(29,"技能攻击3");
			SetAction(30,"技能攻击3");
			name = "打倒怪叔叔";
			nativename = "打倒怪叔叔";
			icon = "捕快.dds";
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
			return 2000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 4000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 30.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( player.GetTmplid() != 52260
			|| (v3 = player, GNET::PlayerWrapper::GetRes1(v3) > 1999) )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetValue(5000.0f);
			victim.SetDirecthurt(true);
			*/
			return true;
		}
	}
	public class GSkill3901 : GSkill
	{
		public GSkill3901()
			: base(3901)
		{
			
		}
	}
	public class GSkill3902Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 100;
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
				return 100;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill3902Stub()
			: base(3902)
		{
			occupation = 128;
			maxlevel = 1;
			maxlearn = 0;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
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
			name = "水球大战_玩家的水球";
			nativename = "水球大战_玩家的水球";
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
			return 200;
		}
		public override float GetRadius(GSkill skill)
		{
			return 5.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();

			/*
			if ( (player.GetTmplid() <= 52201
			|| (v3 = player, GNET::PlayerWrapper::GetTmplid(v3) > 52205))
			&& (v4 = player, GNET::PlayerWrapper::GetTmplid(v4) != 52340) )
			d = 0.0f;
			else
			victim.SetProbability(120.0f);
			victim.SetValue(10000.0f);
			victim.SetDirecthurt(true);
			*/
			return true;
		}
	}
	public class GSkill3902 : GSkill
	{
		public GSkill3902()
			: base(3902)
		{
			
		}
	}
	public class GSkill3903Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1600;
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
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(0);
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();

				player.SetHp(((player_hp - 1000000)));
				player.SetPerform(0);
			}
		}
		public class GState5 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 1000;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(0);
			}
		}
		public GSkill3903Stub()
			: base(3903)
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
			rangetype = 6;
			doenchant = false;
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
			SetAction(0,"青云门_霜天雪舞");
			SetAction(1,"青云门_霜天雪舞");
			SetAction(2,"青云门_霜天雪舞");
			SetAction(3,"青云门_霜天雪舞");
			SetAction(4,"青云门_霜天雪舞");
			SetAction(5,"青云门_霜天雪舞");
			SetAction(6,"青云门_霜天雪舞");
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
			name = "火雨术";
			nativename = "火雨术";
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
			AddState(new GState3());
			AddState(new GState4());
			AddState(new GState5());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 5000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 200;
		}
		public override float GetRadius(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 16.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 13.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 21.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 6;
		}
	}
	public class GSkill3903 : GSkill
	{
		public GSkill3903()
			: base(3903)
		{
			
		}
	}
	public class GSkill3904Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
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
		public GSkill3904Stub()
			: base(3904)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			SetAction(0,"鬼王宗_回春");
			SetAction(1,"青云门_回春");
			SetAction(2,"鬼王宗_回春");
			SetAction(3,"合欢派_回春");
			SetAction(4,"天音寺_回春");
			SetAction(5,"鬼道_回春");
			SetAction(6,"焚香谷_回春");
			SetAction(7,"兽神_回春");
			SetAction(8,"狐妖_回春");
			SetAction(9,"轩辕_回春");
			SetAction(10,"怀光_回春");
			SetAction(11,"太昊_回春");
			SetAction(12,"天华_回春");
			SetAction(13,"灵夙_回春");
			SetAction(14,"英招_回春");
			SetAction(15,"元素大师_回春");
			SetAction(16,"元素大师_回春");
			SetAction(17,"归云_设置气血");
			SetAction(18,"鬼王宗_骑乘_回春");
			SetAction(19,"青云门_骑乘_回春");
			SetAction(20,"鬼王宗_骑乘_回春");
			SetAction(21,"合欢派_骑乘_回春");
			SetAction(22,"天音寺_骑乘_回春");
			SetAction(23,"鬼道_骑乘_回春");
			SetAction(24,"焚香谷_骑乘_回春");
			SetAction(25,"兽神_骑乘_回春");
			SetAction(26,"狐妖_骑乘_回春");
			SetAction(27,"轩辕_骑乘_回春");
			SetAction(28,"怀光_骑乘_回春");
			SetAction(29,"太昊_骑乘_回春");
			SetAction(30,"天华_骑乘_回春");
			name = "星语·血典";
			nativename = "星语·血典";
			icon = "神通_血典.dds";
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
			return 300000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxhp = player.GetMaxhp();
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(100.0f);
			victim.SetTime(10000.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(2);
			victim.SetAmount(0.0f);
			victim.SetValue((player_maxhp * 0.5f));
			victim.SetHpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(2);
			victim.SetAmount(0.0f);
			victim.SetValue((player_maxmp * 0.5f));
			victim.SetMpgen(true);
			victim.SetProbability(100.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(2);
			victim.SetAmount((player.GetMaxdp() * 0.5f));
			victim.SetValue(0.0f);
			victim.SetDivinityfury(true);
			return true;
		}
	}
	public class GSkill3904 : GSkill
	{
		public GSkill3904()
			: base(3904)
		{
			
		}
	}
	public class GSkill3905Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
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
		public GSkill3905Stub()
			: base(3905)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			SetAction(0,"鬼王宗_荆棘");
			SetAction(1,"青云门_荆棘");
			SetAction(2,"鬼王宗_荆棘");
			SetAction(3,"合欢派_荆棘");
			SetAction(4,"天音寺_荆棘");
			SetAction(5,"鬼道_荆棘");
			SetAction(6,"焚香_荆棘");
			SetAction(7,"兽神_荆棘");
			SetAction(8,"狐妖_荆棘");
			SetAction(9,"轩辕_荆棘");
			SetAction(10,"怀光_荆棘");
			SetAction(11,"太昊_荆棘");
			SetAction(12,"天华_荆棘");
			SetAction(13,"灵夙_荆棘");
			SetAction(14,"英招_荆棘");
			SetAction(15,"元素大师_荆棘");
			SetAction(16,"元素大师_荆棘");
			SetAction(17,"天音寺_荆棘");
			SetAction(18,"鬼王宗_骑乘_荆棘");
			SetAction(19,"青云门_骑乘_荆棘");
			SetAction(20,"鬼王宗_骑乘_荆棘");
			SetAction(21,"合欢派_骑乘_荆棘");
			SetAction(22,"天音寺_骑乘_荆棘");
			SetAction(23,"鬼道_骑乘_荆棘");
			SetAction(24,"焚香谷_骑乘_荆棘");
			SetAction(25,"兽神_骑乘_荆棘");
			SetAction(26,"狐妖_骑乘_荆棘");
			SetAction(27,"轩辕_骑乘_荆棘");
			SetAction(28,"怀光_骑乘_荆棘");
			SetAction(29,"太昊_骑乘_荆棘");
			SetAction(30,"天华_骑乘_荆棘");
			name = "星语·天目";
			nativename = "星语·天目";
			icon = "神通_天目.dds";
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
			return 360000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(12000.0f);
			victim.SetRatio(0.039999999f);
			victim.SetInccritrate(true);
			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetNingjin(true);
			return true;
		}
	}
	public class GSkill3905 : GSkill
	{
		public GSkill3905()
			: base(3905)
		{
			
		}
	}
	public class GSkill3906Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
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
		public GSkill3906Stub()
			: base(3906)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			SetAction(0,"鬼王宗_坚盾");
			SetAction(1,"青云门_坚盾");
			SetAction(2,"鬼王宗_坚盾");
			SetAction(3,"合欢派_坚盾");
			SetAction(4,"天音寺_坚盾");
			SetAction(5,"鬼道_坚盾");
			SetAction(6,"焚香谷_坚盾");
			SetAction(7,"兽神_坚盾");
			SetAction(8,"狐妖_坚盾");
			SetAction(9,"轩辕_坚盾");
			SetAction(10,"怀光_坚盾");
			SetAction(11,"太昊_坚盾");
			SetAction(12,"天华_坚盾");
			SetAction(13,"灵夙_坚盾");
			SetAction(14,"英招_坚盾");
			SetAction(15,"元素大师_坚盾");
			SetAction(16,"元素大师_坚盾");
			SetAction(17,"天音寺_坚盾");
			SetAction(18,"鬼王宗_骑乘_坚盾");
			SetAction(19,"青云门_骑乘_坚盾");
			SetAction(20,"鬼王宗_骑乘_坚盾");
			SetAction(21,"合欢派_骑乘_坚盾");
			SetAction(22,"天音寺_骑乘_坚盾");
			SetAction(23,"鬼道_骑乘_坚盾");
			SetAction(24,"焚香谷_骑乘_坚盾");
			SetAction(25,"兽神_骑乘_坚盾");
			SetAction(26,"狐妖_骑乘_坚盾");
			SetAction(27,"轩辕_骑乘_坚盾");
			SetAction(28,"怀光_骑乘_坚盾");
			SetAction(29,"太昊_骑乘_坚盾");
			SetAction(30,"天华_骑乘_坚盾");
			name = "星语·拔山";
			nativename = "星语·拔山";
			icon = "神通_拔山.dds";
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
			return 360000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetIncattack(true);
			victim.SetProbability(120.0f);
			victim.SetTime(12000.0f);
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetIncdefence(true);
			victim.SetTime(12000.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(1);
			victim.SetInchp(true);
			victim.SetTime(12000.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(1);
			victim.SetIncmp(true);
			return true;
		}
	}
	public class GSkill3906 : GSkill
	{
		public GSkill3906()
			: base(3906)
		{
			
		}
	}
	public class GSkill3907Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
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
		public GSkill3907Stub()
			: base(3907)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
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
			SetAction(0,"鬼王宗_燃烧");
			SetAction(1,"青云门_燃烧");
			SetAction(2,"鬼王宗_燃烧");
			SetAction(3,"合欢派_燃烧");
			SetAction(4,"天音寺_燃烧");
			SetAction(5,"鬼道_燃烧");
			SetAction(6,"焚香谷_燃烧");
			SetAction(7,"兽神_燃烧");
			SetAction(8,"狐妖_燃烧");
			SetAction(9,"轩辕_燃烧");
			SetAction(10,"怀光_燃烧");
			SetAction(11,"太昊_燃烧");
			SetAction(12,"天华_燃烧");
			SetAction(13,"灵夙_燃烧");
			SetAction(14,"英招_燃烧");
			SetAction(15,"元素大师_燃烧");
			SetAction(16,"元素大师_燃烧");
			SetAction(17,"天音寺_燃烧");
			SetAction(18,"鬼王宗_骑乘_燃烧");
			SetAction(19,"青云门_骑乘_燃烧");
			SetAction(20,"鬼王宗_骑乘_燃烧");
			SetAction(21,"合欢派_骑乘_燃烧");
			SetAction(22,"天音寺_骑乘_燃烧");
			SetAction(23,"鬼道_骑乘_燃烧");
			SetAction(24,"焚香谷_骑乘_燃烧");
			SetAction(25,"兽神_骑乘_燃烧");
			SetAction(26,"狐妖_骑乘_燃烧");
			SetAction(27,"轩辕_骑乘_燃烧");
			SetAction(28,"怀光_骑乘_燃烧");
			SetAction(29,"太昊_骑乘_燃烧");
			SetAction(30,"天华_骑乘_燃烧");
			name = "星语·镇灵";
			nativename = "星语·镇灵";
			icon = "神通_镇灵.dds";
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
			return 360000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 15.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 20.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(15000.0f);
			victim.SetRatio(0.30000001f);
			victim.SetBuffid(1);
			victim.SetWeak(true);
			victim.SetProbability(120.0f);
			victim.SetTime(15000.0f);
			victim.SetRatio(0.40000001f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			return true;
		}
	}
	public class GSkill3907 : GSkill
	{
		public GSkill3907()
			: base(3907)
		{
			
		}
	}
	public class GSkill3908Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
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
		public GSkill3908Stub()
			: base(3908)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			SetAction(0,"鬼王宗_狂风咒");
			SetAction(1,"青云门_逍遥游");
			SetAction(2,"鬼王宗_狂风咒");
			SetAction(3,"合欢派_浮光");
			SetAction(4,"天音寺_易筋经");
			SetAction(5,"鬼道_百鬼夜行");
			SetAction(6,"青云门_逍遥游");
			SetAction(7,"兽神_横行");
			SetAction(8,"狐妖_风行者");
			SetAction(9,"轩辕_加速");
			SetAction(10,"怀光_加速");
			SetAction(11,"太昊_加速");
			SetAction(12,"天华_奔雷");
			SetAction(13,"灵夙_加速");
			SetAction(14,"英招_加速");
			SetAction(15,"0");
			SetAction(16,"元素大师_速度汲取");
			SetAction(17,"归云_设置气血");
			SetAction(18,"鬼王宗_骑乘_狂风咒");
			SetAction(19,"青云门_骑乘_逍遥游");
			SetAction(20,"鬼王宗_骑乘_狂风咒");
			SetAction(21,"合欢派_骑乘_浮光");
			SetAction(22,"天音寺_骑乘_易筋经");
			SetAction(23,"鬼道_骑乘_百鬼夜行");
			SetAction(24,"青云门_骑乘_逍遥游");
			SetAction(25,"兽神_骑乘_横行");
			SetAction(26,"狐妖_骑乘_风行者");
			SetAction(27,"轩辕_骑乘_加速");
			SetAction(28,"怀光_骑乘_加速");
			SetAction(29,"太昊_骑乘_加速");
			SetAction(30,"天华_骑乘_奔雷");
			name = "星语·腾云";
			nativename = "星语·腾云";
			icon = "神通_腾云.dds";
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
			return 300000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(1);
			victim.SetValue(5.0f);
			victim.SetAddspeed(true);
			victim.SetProbability(120.0f);
			victim.SetTime(10000.0f);
			victim.SetBuffid(1);
			victim.SetValue(4.0f);
			victim.SetIncmountspeed(true);
			victim.SetProbability(120.0f);
			victim.SetClearslow(true);
			return true;
		}
	}
	public class GSkill3908 : GSkill
	{
		public GSkill3908()
			: base(3908)
		{
			
		}
	}
	public class GSkill3909Stub : GSkillStub
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
			public override bool Cancel(GSkill skill)
			{
				return true;
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
		public GSkill3909Stub()
			: base(3909)
		{
			occupation = 151;
			maxlevel = 1;
			maxlearn = 0;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
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
			SetAction(0,"鬼王宗_散尽");
			SetAction(1,"青云门_散尽");
			SetAction(2,"鬼王宗_散尽");
			SetAction(3,"合欢派_散尽");
			SetAction(4,"天音寺_散尽");
			SetAction(5,"鬼道_散尽");
			SetAction(6,"焚香谷_散尽");
			SetAction(7,"兽神_散尽");
			SetAction(8,"狐妖_散尽");
			SetAction(9,"轩辕_散尽");
			SetAction(10,"怀光_散尽");
			SetAction(11,"太昊_散尽");
			SetAction(12,"天华_散尽");
			SetAction(13,"灵夙_散尽");
			SetAction(14,"英招_散尽");
			SetAction(15,"元素大师_散尽");
			SetAction(16,"元素大师_散尽");
			SetAction(17,"归云_设置气血");
			SetAction(18,"鬼王宗_骑乘_散尽");
			SetAction(19,"青云门_骑乘_散尽");
			SetAction(20,"鬼王宗_骑乘_散尽");
			SetAction(21,"合欢派_骑乘_散尽");
			SetAction(22,"天音寺_骑乘_散尽");
			SetAction(23,"鬼道_骑乘_散尽");
			SetAction(24,"焚香谷_骑乘_散尽");
			SetAction(25,"兽神_骑乘_散尽");
			SetAction(26,"狐妖_骑乘_散尽");
			SetAction(27,"轩辕_骑乘_散尽");
			SetAction(28,"怀光_骑乘_散尽");
			SetAction(29,"太昊_骑乘_散尽");
			SetAction(30,"天华_骑乘_散尽");
			name = "星语·身外化身";
			nativename = "星语·身外化身";
			icon = "神通_身外化身.dds";
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
			return 240000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(120.0f);
			victim.SetAmount(20.0f);
			victim.SetCleardebuff(true);
			return true;
		}
	}
	public class GSkill3909 : GSkill
	{
		public GSkill3909()
			: base(3909)
		{
			
		}
	}
}
