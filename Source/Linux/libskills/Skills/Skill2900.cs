using System;
using System.Text;

namespace SKILL
{
	public class GSkill2900Stub : GSkillStub
	{
		public GSkill2900Stub()
			: base(2900)
		{
			occupation = 51;
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
			name = "音律：商";
			nativename = "音律：商";
			icon = "商.dds";
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
			skill_class = 8;
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
			float			skill_tianhua1 = skill.GetTianhua1();

			victim.SetProbability(120.0f);
			victim.SetTime((skill_tianhua1 * 5000.0f));
			victim.SetRatio(0.2f);
			victim.SetBuffid(1);
			victim.SetSlow(true);
			return true;
		}
	}
	public class GSkill2900 : GSkill
	{
		public GSkill2900()
			: base(2900)
		{
			
		}
	}
	public class GSkill2901Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 0;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();

				player.SetPerform(1);
			}
		}
		public GSkill2901Stub()
			: base(2901)
		{
			occupation = 51;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 1;
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
			name = "音律：角";
			nativename = "音律：角";
			icon = "角.dds";
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
			skill_class = 8;
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
			float			skill_tianhua1 = skill.GetTianhua1();

			victim.SetTime(18000.0f);
			victim.SetBuffid(0);
			victim.SetValue((skill_tianhua1 * 30.0f));
			victim.SetSubantiwrap(true);
			return true;
		}
	}
	public class GSkill2901 : GSkill
	{
		public GSkill2901()
			: base(2901)
		{
			
		}
	}
	public class GSkill2902Stub : GSkillStub
	{
		public GSkill2902Stub()
			: base(2902)
		{
			occupation = 51;
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
			name = "音律：清角";
			nativename = "音律：清角";
			icon = "清角.dds";
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
			skill_class = 8;
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
			float			skill_tianhua1 = skill.GetTianhua1();

			victim.SetProbability((skill_tianhua1 * 110.0f));
			victim.SetTime(6000.0f);
			victim.SetSilent(true);
			return true;
		}
	}
	public class GSkill2902 : GSkill
	{
		public GSkill2902()
			: base(2902)
		{
			
		}
	}
	public class GSkill2903Stub : GSkillStub
	{
		public GSkill2903Stub()
			: base(2903)
		{
			occupation = 51;
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
			name = "音律：徵";
			nativename = "音律：徵";
			icon = "徵.dds";
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
			skill_class = 8;
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
			float			skill_tianhua1 = skill.GetTianhua1();

			victim.SetProbability((skill_tianhua1 * 120.0f));
			victim.SetTime(3000.0f);
			victim.SetDizzy(true);
			return true;
		}
	}
	public class GSkill2903 : GSkill
	{
		public GSkill2903()
			: base(2903)
		{
			
		}
	}
	public class GSkill2904Stub : GSkillStub
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
		public GSkill2904Stub()
			: base(2904)
		{
			occupation = 151;
			maxlevel = 14;
			maxlearn = 14;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
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
			SetAction(0,"鬼王宗_破甲");
			SetAction(1,"青云门_破甲");
			SetAction(2,"鬼王宗_破甲");
			SetAction(3,"合欢派_破甲");
			SetAction(4,"天音寺_破甲");
			SetAction(5,"鬼道_破甲");
			SetAction(6,"青云门_破甲");
			SetAction(7,"兽神_破甲");
			SetAction(8,"狐妖_破甲");
			SetAction(9,"兽神_破甲");
			SetAction(10,"怀光_破甲");
			SetAction(11,"0");
			SetAction(12,"天花_破甲");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"元素大师_破甲");
			SetAction(16,"元素大师_破甲");
			SetAction(17,"");
			SetAction(18,"鬼王宗_骑乘_破甲");
			SetAction(19,"青云门_骑乘_破甲");
			SetAction(20,"鬼王宗_骑乘_破甲");
			SetAction(21,"合欢派_骑乘_破甲");
			SetAction(22,"天音寺_骑乘_破甲");
			SetAction(23,"鬼道_骑乘_破甲");
			SetAction(24,"鬼王宗_骑乘_破甲");
			SetAction(25,"兽神_骑乘_破甲");
			SetAction(26,"狐妖_骑乘_破甲");
			SetAction(27,"兽神_骑乘_破甲");
			SetAction(28,"怀光_骑乘_破甲");
			SetAction(29,"0");
			SetAction(30,"天花_骑乘_破甲");
			name = "只手遮天";
			nativename = "只手遮天";
			icon = "只手遮天.dds";
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

			return player_range + 8.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 7.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 9.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 2000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			if ( skill_level == 1 )
			v10 = 0.008000999999999999f;
			else
			v10 = 0.0f;
			if ( skill_level == 2 )
			v11 = v10 + 0.013001f;
			else
			v11 = v10 + 0.0f;
			if ( skill_level == 3 )
			v12 = v11 + 0.018001f;
			else
			v12 = v11 + 0.0f;
			if ( skill_level == 4 )
			v13 = v12 + 0.023001f;
			else
			v13 = v12 + 0.0f;
			if ( skill_level == 5 )
			v14 = v13 + 0.047001f;
			else
			v14 = v13 + 0.0f;
			if ( skill_level == 6 )
			v15 = v14 + 0.055001f;
			else
			v15 = v14 + 0.0f;
			if ( skill_level == 7 )
			v16 = v15 + 0.063001f;
			else
			v16 = v15 + 0.0f;
			if ( skill_level == 8 )
			v17 = v16 + 0.081001f;
			else
			v17 = v16 + 0.0f;
			if ( skill_level == 9 )
			v18 = v17 + 0.089001f;
			else
			v18 = v17 + 0.0f;
			if ( skill_level == 10 )
			v19 = v18 + 0.097001f;
			else
			v19 = v18 + 0.0f;
			if ( skill_level == 11 )
			v20 = v19 + 0.105001f;
			else
			v20 = v19 + 0.0f;
			if ( skill_level == 12 )
			v21 = v20 + 0.113001f;
			else
			v21 = v20 + 0.0f;
			if ( skill_level == 13 )
			v22 = v21 + 0.141001f;
			else
			v22 = v21 + 0.0f;
			if ( skill_level == 14 )
			v9 = v22 + 0.16001f;
			else
			victim.SetRatio((v22 + 0.0f));
			victim.SetBuffid(9);
			victim.SetDecskilldodge(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(300000.0f);
			victim.SetRatio(2905.0f);
			victim.SetAmount(2905.0f);
			victim.SetValue(2905.0f);
			victim.SetSetcooldown(true);
			return true;
		}
	}
	public class GSkill2904 : GSkill
	{
		public GSkill2904()
			: base(2904)
		{
			
		}
	}
	public class GSkill2905Stub : GSkillStub
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
		public GSkill2905Stub()
			: base(2905)
		{
			occupation = 151;
			maxlevel = 14;
			maxlearn = 14;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
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
			SetAction(0,"鬼王宗_破甲");
			SetAction(1,"青云门_破甲");
			SetAction(2,"鬼王宗_破甲");
			SetAction(3,"合欢派_破甲");
			SetAction(4,"天音寺_破甲");
			SetAction(5,"鬼道_破甲");
			SetAction(6,"0");
			SetAction(7,"兽神_破甲");
			SetAction(8,"狐妖_破甲");
			SetAction(9,"0");
			SetAction(10,"怀光_破甲");
			SetAction(11,"0");
			SetAction(12,"天华_破甲");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"元素大师_破甲");
			SetAction(16,"元素大师_破甲");
			SetAction(17,"");
			SetAction(18,"鬼王宗_骑乘_破甲");
			SetAction(19,"青云门_骑乘_破甲");
			SetAction(20,"鬼王宗_骑乘_破甲");
			SetAction(21,"合欢派_骑乘_破甲");
			SetAction(22,"天音寺_骑乘_破甲");
			SetAction(23,"鬼道_骑乘_破甲");
			SetAction(24,"0");
			SetAction(25,"兽神_骑乘_破甲");
			SetAction(26,"狐妖_骑乘_破甲");
			SetAction(27,"0");
			SetAction(28,"怀光_骑乘_破甲");
			SetAction(29,"0");
			SetAction(30,"天华_骑乘_破甲");
			name = "暗无天日";
			nativename = "暗无天日";
			icon = "暗无天日.dds";
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

			return player_range + 8.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 7.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 9.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 2000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			if ( skill_level == 1 )
			v10 = 0.008000999999999999f;
			else
			v10 = 0.0f;
			if ( skill_level == 2 )
			v11 = v10 + 0.013001f;
			else
			v11 = v10 + 0.0f;
			if ( skill_level == 3 )
			v12 = v11 + 0.018001f;
			else
			v12 = v11 + 0.0f;
			if ( skill_level == 4 )
			v13 = v12 + 0.023001f;
			else
			v13 = v12 + 0.0f;
			if ( skill_level == 5 )
			v14 = v13 + 0.047001f;
			else
			v14 = v13 + 0.0f;
			if ( skill_level == 6 )
			v15 = v14 + 0.055001f;
			else
			v15 = v14 + 0.0f;
			if ( skill_level == 7 )
			v16 = v15 + 0.063001f;
			else
			v16 = v15 + 0.0f;
			if ( skill_level == 8 )
			v17 = v16 + 0.081001f;
			else
			v17 = v16 + 0.0f;
			if ( skill_level == 9 )
			v18 = v17 + 0.089001f;
			else
			v18 = v17 + 0.0f;
			if ( skill_level == 10 )
			v19 = v18 + 0.097001f;
			else
			v19 = v18 + 0.0f;
			if ( skill_level == 11 )
			v20 = v19 + 0.105001f;
			else
			v20 = v19 + 0.0f;
			if ( skill_level == 12 )
			v21 = v20 + 0.113001f;
			else
			v21 = v20 + 0.0f;
			if ( skill_level == 13 )
			v22 = v21 + 0.141001f;
			else
			v22 = v21 + 0.0f;
			if ( skill_level == 14 )
			v9 = v22 + 0.16001f;
			else
			victim.SetRatio((v22 + 0.0f));
			victim.SetBuffid(9);
			victim.SetDecskillaccu(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(300000.0f);
			victim.SetRatio(2904.0f);
			victim.SetAmount(2904.0f);
			victim.SetValue(2904.0f);
			victim.SetSetcooldown(true);
			return true;
		}
	}
	public class GSkill2905 : GSkill
	{
		public GSkill2905()
			: base(2905)
		{
			
		}
	}
	public class GSkill2906Stub : GSkillStub
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
		public GSkill2906Stub()
			: base(2906)
		{
			occupation = 151;
			maxlevel = 12;
			maxlearn = 12;
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
			SetAction(0,"鬼王宗_散尽");
			SetAction(1,"青云门_散尽");
			SetAction(2,"鬼王宗_散尽");
			SetAction(3,"合欢派_散尽");
			SetAction(4,"天音寺_散尽");
			SetAction(5,"鬼道_散尽");
			SetAction(6,"鬼王宗_散尽");
			SetAction(7,"兽神_散尽");
			SetAction(8,"狐妖_散尽");
			SetAction(9,"兽神_散尽");
			SetAction(10,"怀光_散尽");
			SetAction(11,"0");
			SetAction(12,"天华_散尽");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"元素大师_散尽");
			SetAction(16,"元素大师_散尽");
			SetAction(17,"");
			SetAction(18,"鬼王宗_骑乘_散尽");
			SetAction(19,"青云门_骑乘_散尽");
			SetAction(20,"鬼王宗_骑乘_散尽");
			SetAction(21,"合欢派_骑乘_散尽");
			SetAction(22,"天音寺_骑乘_散尽");
			SetAction(23,"鬼道_骑乘_散尽");
			SetAction(24,"鬼王宗_骑乘_散尽");
			SetAction(25,"兽神_骑乘_散尽");
			SetAction(26,"狐妖_骑乘_散尽");
			SetAction(27,"兽神_骑乘_散尽");
			SetAction(28,"怀光_骑乘_散尽");
			SetAction(29,"0");
			SetAction(30,"天华_骑乘_散尽");
			name = "运筹帷幄";
			nativename = "运筹帷幄";
			icon = "运筹帷幄.dds";
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

			return player_range + 8.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 7.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 9.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 2000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetTime(30000.0f);
			victim.SetBuffid(9);
			if ( skill_level == 1 )
			v56 = 40;
			else
			v56 = 0;
			if ( skill_level == 2 )
			v57 = v56 + 50;
			else
			v57 = v56;
			if ( skill_level == 3 )
			v58 = v57 + 60;
			else
			v58 = v57;
			if ( skill_level == 4 )
			v59 = v58 + 70;
			else
			v59 = v58;
			if ( skill_level == 5 )
			v60 = v59 + 80;
			else
			v60 = v59;
			if ( skill_level == 6 )
			v61 = v60 + 100;
			else
			v61 = v60;
			if ( skill_level == 7 )
			v62 = v61 + 110;
			else
			v62 = v61;
			if ( skill_level == 8 )
			v63 = v62 + 120;
			else
			v63 = v62;
			if ( skill_level == 9 )
			v64 = v63 + 130;
			else
			v64 = v63;
			if ( skill_level == 10 )
			v65 = v64 + 140;
			else
			v65 = v64;
			if ( skill_level == 11 )
			v66 = v65 + 180;
			else
			v66 = v65;
			if ( skill_level == 12 )
			d = (v66 + 220);
			else
			victim.SetValue(v66);
			victim.SetSubantidizzy(true);
			victim.SetTime(30000.0f);
			victim.SetBuffid(9);
			if ( skill_level == 1 )
			v44 = 40;
			else
			v44 = 0;
			if ( skill_level == 2 )
			v45 = v44 + 50;
			else
			v45 = v44;
			if ( skill_level == 3 )
			v46 = v45 + 60;
			else
			v46 = v45;
			if ( skill_level == 4 )
			v47 = v46 + 70;
			else
			v47 = v46;
			if ( skill_level == 5 )
			v48 = v47 + 80;
			else
			v48 = v47;
			if ( skill_level == 6 )
			v49 = v48 + 100;
			else
			v49 = v48;
			if ( skill_level == 7 )
			v50 = v49 + 110;
			else
			v50 = v49;
			if ( skill_level == 8 )
			v51 = v50 + 120;
			else
			v51 = v50;
			if ( skill_level == 9 )
			v52 = v51 + 130;
			else
			v52 = v51;
			if ( skill_level == 10 )
			v53 = v52 + 140;
			else
			v53 = v52;
			if ( skill_level == 11 )
			v54 = v53 + 180;
			else
			v54 = v53;
			if ( skill_level == 12 )
			v43 = (v54 + 220);
			else
			victim.SetValue(v54);
			victim.SetSubantisilent(true);
			victim.SetTime(30000.0f);
			victim.SetBuffid(9);
			if ( skill_level == 1 )
			v32 = 40;
			else
			v32 = 0;
			if ( skill_level == 2 )
			v33 = v32 + 50;
			else
			v33 = v32;
			if ( skill_level == 3 )
			v34 = v33 + 60;
			else
			v34 = v33;
			if ( skill_level == 4 )
			v35 = v34 + 70;
			else
			v35 = v34;
			if ( skill_level == 5 )
			v36 = v35 + 80;
			else
			v36 = v35;
			if ( skill_level == 6 )
			v37 = v36 + 100;
			else
			v37 = v36;
			if ( skill_level == 7 )
			v38 = v37 + 110;
			else
			v38 = v37;
			if ( skill_level == 8 )
			v39 = v38 + 120;
			else
			v39 = v38;
			if ( skill_level == 9 )
			v40 = v39 + 130;
			else
			v40 = v39;
			if ( skill_level == 10 )
			v41 = v40 + 140;
			else
			v41 = v40;
			if ( skill_level == 11 )
			v42 = v41 + 180;
			else
			v42 = v41;
			if ( skill_level == 12 )
			v31 = (v42 + 220);
			else
			victim.SetValue(v42);
			victim.SetSubantiwrap(true);
			victim.SetTime(30000.0f);
			victim.SetBuffid(9);
			if ( skill_level == 1 )
			v20 = 40;
			else
			v20 = 0;
			if ( skill_level == 2 )
			v21 = v20 + 50;
			else
			v21 = v20;
			if ( skill_level == 3 )
			v22 = v21 + 60;
			else
			v22 = v21;
			if ( skill_level == 4 )
			v23 = v22 + 70;
			else
			v23 = v22;
			if ( skill_level == 5 )
			v24 = v23 + 80;
			else
			v24 = v23;
			if ( skill_level == 6 )
			v25 = v24 + 100;
			else
			v25 = v24;
			if ( skill_level == 7 )
			v26 = v25 + 110;
			else
			v26 = v25;
			if ( skill_level == 8 )
			v27 = v26 + 120;
			else
			v27 = v26;
			if ( skill_level == 9 )
			v28 = v27 + 130;
			else
			v28 = v27;
			if ( skill_level == 10 )
			v29 = v28 + 140;
			else
			v29 = v28;
			if ( skill_level == 11 )
			v30 = v29 + 180;
			else
			v30 = v29;
			if ( skill_level == 12 )
			v19 = (v30 + 220);
			else
			victim.SetValue(v30);
			victim.SetSubantisleep(true);
			*/
			return true;
		}
	}
	public class GSkill2906 : GSkill
	{
		public GSkill2906()
			: base(2906)
		{
			
		}
	}
	public class GSkill2907Stub : GSkillStub
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
		public GSkill2907Stub()
			: base(2907)
		{
			occupation = 151;
			maxlevel = 10;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
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
			SetAction(0,"鬼王宗_猛击");
			SetAction(1,"青云门_猛击");
			SetAction(2,"鬼王宗_猛击");
			SetAction(3,"合欢派_猛击");
			SetAction(4,"天音寺_猛击");
			SetAction(5,"鬼道_猛击");
			SetAction(6,"0");
			SetAction(7,"兽神_猛击");
			SetAction(8,"狐妖_猛击");
			SetAction(9,"0");
			SetAction(10,"怀光_猛击");
			SetAction(11,"0");
			SetAction(12,"天华_猛击");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"元素大师_猛击");
			SetAction(16,"元素大师_猛击");
			SetAction(17,"");
			SetAction(18,"鬼王宗_骑乘_猛击");
			SetAction(19,"青云门_骑乘_猛击");
			SetAction(20,"鬼王宗_骑乘_猛击");
			SetAction(21,"合欢派_骑乘_猛击");
			SetAction(22,"天音寺_骑乘_猛击");
			SetAction(23,"鬼道_骑乘_猛击");
			SetAction(24,"0");
			SetAction(25,"兽神_骑乘_猛击");
			SetAction(26,"狐妖_骑乘_猛击");
			SetAction(27,"0");
			SetAction(28,"怀光_骑乘_猛击");
			SetAction(29,"0");
			SetAction(30,"天华_骑乘_猛击");
			name = "在劫难逃";
			nativename = "在劫难逃";
			icon = "在劫难逃.dds";
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

			return player_range + 8.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 7.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 9.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 2000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			if ( skill_level == 1 )
			v10 = 0.01001f;
			else
			v10 = 0.0f;
			if ( skill_level == 2 )
			v11 = v10 + 0.03001f;
			else
			v11 = v10 + 0.0f;
			if ( skill_level == 3 )
			v12 = v11 + 0.05001f;
			else
			v12 = v11 + 0.0f;
			if ( skill_level == 4 )
			v13 = v12 + 0.08001f;
			else
			v13 = v12 + 0.0f;
			if ( skill_level == 5 )
			v14 = v13 + 0.10001f;
			else
			v14 = v13 + 0.0f;
			if ( skill_level == 6 )
			v15 = v14 + 0.12001f;
			else
			v15 = v14 + 0.0f;
			if ( skill_level == 7 )
			v16 = v15 + 0.14001f;
			else
			v16 = v15 + 0.0f;
			if ( skill_level == 8 )
			v17 = v16 + 0.16001f;
			else
			v17 = v16 + 0.0f;
			if ( skill_level == 9 )
			v18 = v17 + 0.20001f;
			else
			v18 = v17 + 0.0f;
			if ( skill_level == 10 )
			v9 = v18 + 0.25001f;
			else
			victim.SetRatio((v18 + 0.0f));
			victim.SetBuffid(9);
			victim.SetIncfatalratio(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(300000.0f);
			victim.SetRatio(2908.0f);
			victim.SetAmount(2908.0f);
			victim.SetValue(2908.0f);
			victim.SetSetcooldown(true);
			return true;
		}
	}
	public class GSkill2907 : GSkill
	{
		public GSkill2907()
			: base(2907)
		{
			
		}
	}
	public class GSkill2908Stub : GSkillStub
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
		public GSkill2908Stub()
			: base(2908)
		{
			occupation = 151;
			maxlevel = 10;
			maxlearn = 10;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
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
			SetAction(0,"鬼王宗_猛击");
			SetAction(1,"青云门_猛击");
			SetAction(2,"鬼王宗_猛击");
			SetAction(3,"合欢派_猛击");
			SetAction(4,"天音寺_猛击");
			SetAction(5,"鬼道_猛击");
			SetAction(6,"鬼王宗_猛击");
			SetAction(7,"兽神_猛击");
			SetAction(8,"狐妖_猛击");
			SetAction(9,"兽神_猛击");
			SetAction(10,"怀光_猛击");
			SetAction(11,"0");
			SetAction(12,"天华_猛击");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"元素大师_猛击");
			SetAction(16,"元素大师_猛击");
			SetAction(17,"");
			SetAction(18,"鬼王宗_骑乘_猛击");
			SetAction(19,"青云门_骑乘_猛击");
			SetAction(20,"鬼王宗_骑乘_猛击");
			SetAction(21,"合欢派_骑乘_猛击");
			SetAction(22,"天音寺_骑乘_猛击");
			SetAction(23,"鬼道_骑乘_猛击");
			SetAction(24,"鬼王宗_骑乘_猛击");
			SetAction(25,"兽神_骑乘_猛击");
			SetAction(26,"狐妖_骑乘_猛击");
			SetAction(27,"兽神_骑乘_猛击");
			SetAction(28,"怀光_骑乘_猛击");
			SetAction(29,"0");
			SetAction(30,"天华_骑乘_猛击");
			name = "空前绝后";
			nativename = "空前绝后";
			icon = "空前绝后.dds";
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

			return player_range + 8.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 7.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 9.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 2000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			if ( skill_level == 1 )
			v10 = 0.01001f;
			else
			v10 = 0.0f;
			if ( skill_level == 2 )
			v11 = v10 + 0.03001f;
			else
			v11 = v10 + 0.0f;
			if ( skill_level == 3 )
			v12 = v11 + 0.05001f;
			else
			v12 = v11 + 0.0f;
			if ( skill_level == 4 )
			v13 = v12 + 0.08001f;
			else
			v13 = v12 + 0.0f;
			if ( skill_level == 5 )
			v14 = v13 + 0.10001f;
			else
			v14 = v13 + 0.0f;
			if ( skill_level == 6 )
			v15 = v14 + 0.12001f;
			else
			v15 = v14 + 0.0f;
			if ( skill_level == 7 )
			v16 = v15 + 0.14001f;
			else
			v16 = v15 + 0.0f;
			if ( skill_level == 8 )
			v17 = v16 + 0.16001f;
			else
			v17 = v16 + 0.0f;
			if ( skill_level == 9 )
			v18 = v17 + 0.20001f;
			else
			v18 = v17 + 0.0f;
			if ( skill_level == 10 )
			v9 = v18 + 0.25001f;
			else
			victim.SetRatio((v18 + 0.0f));
			victim.SetBuffid(9);
			victim.SetDeccritrate(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(300000.0f);
			victim.SetRatio(2907.0f);
			victim.SetAmount(2907.0f);
			victim.SetValue(2907.0f);
			victim.SetSetcooldown(true);
			return true;
		}
	}
	public class GSkill2908 : GSkill
	{
		public GSkill2908()
			: base(2908)
		{
			
		}
	}
	public class GSkill2909Stub : GSkillStub
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
		public GSkill2909Stub()
			: base(2909)
		{
			occupation = 151;
			maxlevel = 7;
			maxlearn = 7;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 0;
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
			SetAction(0,"鬼王宗_燃烧");
			SetAction(1,"青云门_燃烧");
			SetAction(2,"鬼王宗_燃烧");
			SetAction(3,"合欢派_燃烧");
			SetAction(4,"天音寺_燃烧");
			SetAction(5,"鬼道_燃烧");
			SetAction(6,"鬼王宗_燃烧");
			SetAction(7,"兽神_燃烧");
			SetAction(8,"狐妖_燃烧");
			SetAction(9,"兽神_燃烧");
			SetAction(10,"怀光_燃烧");
			SetAction(11,"0");
			SetAction(12,"天华_燃烧");
			SetAction(13,"0");
			SetAction(14,"0");
			SetAction(15,"元素大师_燃烧");
			SetAction(16,"元素大师_燃烧");
			SetAction(17,"");
			SetAction(18,"鬼王宗_骑乘_燃烧");
			SetAction(19,"青云门_骑乘_燃烧");
			SetAction(20,"鬼王宗_骑乘_燃烧");
			SetAction(21,"合欢派_骑乘_燃烧");
			SetAction(22,"天音寺_骑乘_燃烧");
			SetAction(23,"鬼道_骑乘_燃烧");
			SetAction(24,"鬼王宗_骑乘_燃烧");
			SetAction(25,"兽神_骑乘_燃烧");
			SetAction(26,"狐妖_骑乘_燃烧");
			SetAction(27,"兽神_骑乘_燃烧");
			SetAction(28,"怀光_骑乘_燃烧");
			SetAction(29,"0");
			SetAction(30,"天华_骑乘_燃烧");
			name = "万劫不复";
			nativename = "万劫不复";
			icon = "万劫不复.dds";
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

			return player_range + 8.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 7.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 9.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 2000.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();
			int				skill_level = skill.GetLevel();

			/*
			victim.SetProbability(100.0f);
			victim.SetTime(30000.0f);
			if ( skill_level == 1 )
			v10 = 0.10001f;
			else
			v10 = 0.0f;
			if ( skill_level == 2 )
			v11 = v10 + 0.20001f;
			else
			v11 = v10 + 0.0f;
			if ( skill_level == 3 )
			v12 = v11 + 0.40001f;
			else
			v12 = v11 + 0.0f;
			if ( skill_level == 4 )
			v13 = v12 + 0.60001f;
			else
			v13 = v12 + 0.0f;
			if ( skill_level == 5 )
			v14 = v13 + 0.90001f;
			else
			v14 = v13 + 0.0f;
			if ( skill_level == 6 )
			v15 = v14 + 1.20001f;
			else
			v15 = v14 + 0.0f;
			if ( skill_level == 7 )
			v9 = v15 + 1.50001f;
			else
			victim.SetRatio((v15 + 0.0f));
			victim.SetBuffid(9);
			victim.SetIncfatalhurt(true);
			*/
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(300000.0f);
			victim.SetRatio(2910.0f);
			victim.SetAmount(2910.0f);
			victim.SetValue(2910.0f);
			victim.SetSetcooldown(true);
			return true;
		}
	}
	public class GSkill2909 : GSkill
	{
		public GSkill2909()
			: base(2909)
		{
			
		}
	}
}
