using System;
using System.Text;

namespace SKILL
{
	public class GSkill1690Stub : GSkillStub
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
		public GSkill1690Stub()
			: base(1690)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
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
			SetAction(0,"??????_?˻???????");
			SetAction(1,"??????_?˻???????");
			SetAction(2,"??????_?˻???????");
			SetAction(3,"??????_?˻???????");
			SetAction(4,"??????_?˻???????");
			SetAction(5,"??????_?˻???????");
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
			SetAction(18,"??????_????_?˻???????");
			SetAction(19,"??????_????_?˻???????");
			SetAction(20,"??????_????_?˻???????");
			SetAction(21,"??????_????_?˻???????");
			SetAction(22,"??????_????_?˻???????");
			SetAction(23,"??????_????_?˻???????");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "?˻????𣺰?";
			nativename = "?˻????𣺰?";
			icon = "?˻???????.dds";
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
			skill_class = 2;
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
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 12.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1500.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(120.0f);
			victim.SetTime(((30000 * norm(player_maxmp / (4 * player_mp + 1)) + 30100)));
			victim.SetBuffid(0);
			victim.SetValue(((4 * player_level * (norm(player_maxhp / (2 * player_hp + 1)) + 1))));
			victim.SetSubdefence(true);
			victim.SetProbability(100.0f);
			victim.SetTime(16100.0f);
			victim.SetRatio(0.25099999f);
			victim.SetBuffid(0);
			victim.SetDecskillaccu(true);
			return true;
		}
	}
	public class GSkill1690 : GSkill
	{
		public GSkill1690()
			: base(1690)
		{
			
		}
	}
	public class GSkill1691Stub : GSkillStub
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
		public GSkill1691Stub()
			: base(1691)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
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
			SetAction(0,"??????_?ù???ʥ??");
			SetAction(1,"??????_?ù???ʥ??");
			SetAction(2,"??????_?ù???ʥ??");
			SetAction(3,"??????_?ù???ʥ??");
			SetAction(4,"??????_?ù???ʥ??");
			SetAction(5,"??????_?ù???ʥ??");
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
			SetAction(18,"??????_????_?ù???ʥ??");
			SetAction(19,"??????_????_?ù???ʥ??");
			SetAction(20,"??????_????_?ù???ʥ??");
			SetAction(21,"??????_????_?ù???ʥ??");
			SetAction(22,"??????_????_?ù???ʥ??");
			SetAction(23,"??????_????_?ù???ʥ??");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "?ù?ʥ?죺??";
			nativename = "?ù?ʥ?죺??";
			icon = "?ù???ʥ??.dds";
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
			skill_class = 2;
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
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 900.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 40;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();

			victim.SetTime(((10000 * norm((2 * player_mp) / (player_maxmp + 1)) + 30100)));
			victim.SetRatio(0.33000001f);
			victim.SetAmount(9999999.0f);
			victim.SetDechurt(true);
			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue((((norm(player_maxhp / (4 * player_hp + 1))) * player_hp)));
			victim.SetHeal(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(16100.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(0);
			victim.SetIncskilldamage(true);
			return true;
		}
	}
	public class GSkill1691 : GSkill
	{
		public GSkill1691()
			: base(1691)
		{
			
		}
	}
	public class GSkill1692Stub : GSkillStub
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
				int				player_level = player.GetLevel();

				skill.SetRatio(1.2f);
				skill.SetPlus(((12 * player_level)));
				player.SetPerform(1);
			}
		}
		public GSkill1692Stub()
			: base(1692)
		{
			occupation = 146;
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
			dobless = true;
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
			SetAction(0,"??????_̫????????");
			SetAction(1,"??????_̫????????");
			SetAction(2,"??????_̫????????");
			SetAction(3,"??????_̫????????");
			SetAction(4,"??????_̫????????");
			SetAction(5,"??????_̫????????");
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
			SetAction(18,"??????_????_̫????????");
			SetAction(19,"??????_????_̫????????");
			SetAction(20,"??????_????_̫????????");
			SetAction(21,"??????_????_̫????????");
			SetAction(22,"??????_????_̫????????");
			SetAction(23,"??????_????_̫????????");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "̫?????䣺??";
			nativename = "̫?????䣺??";
			icon = "̫????????.dds";
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
			skill_class = 2;
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

			return player_range + 7.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 11.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1200.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(100.0f);
			victim.SetTime(8000.0f);
			victim.SetBuffid(0);
			victim.SetAmount(0.0f);
			victim.SetValue((player_maxmp * 0.75f));
			victim.SetMpleak(true);
			victim.SetProbability(50.0f);
			victim.SetTime(8100.0f);
			victim.SetDiet(true);
			victim.SetProbability(120.0f);
			victim.SetTime(8100.0f);
			victim.SetRatio(0.0f);
			victim.SetBuffid(9);
			victim.SetFrozen(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();

			victim.SetProbability(100.0f);
			victim.SetTime(100.0f);
			victim.SetBuffid(0);
			victim.SetAmount(0.0f);
			victim.SetValue((player_hp * 0.15f));
			victim.SetMpgen(true);
			return true;
		}
	}
	public class GSkill1692 : GSkill
	{
		public GSkill1692()
			: base(1692)
		{
			
		}
	}
	public class GSkill1693Stub : GSkillStub
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

				skill.SetRatio(1.1f);
				player.SetPerform(1);
			}
		}
		public GSkill1693Stub()
			: base(1693)
		{
			occupation = 146;
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
			SetAction(0,"??????_???????ٻ?");
			SetAction(1,"??????_???????ٻ?");
			SetAction(2,"??????_???????ٻ?");
			SetAction(3,"??????_???????ٻ?");
			SetAction(4,"??????_???????ٻ?");
			SetAction(5,"??????_???????ٻ?");
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
			SetAction(18,"??????_????_???????ٻ?");
			SetAction(19,"??????_????_???????ٻ?");
			SetAction(20,"??????_????_???????ٻ?");
			SetAction(21,"??????_????_???????ٻ?");
			SetAction(22,"??????_????_???????ٻ?");
			SetAction(23,"??????_????_???????ٻ?");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "???????٣???";
			nativename = "???????٣???";
			icon = "???????ٻ?.dds";
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
			skill_class = 2;
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

			return player_range + 7.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 11.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1200.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();
			int				player_maxhp = player.GetMaxhp();
			int				player_mp = player.GetMp();
			int				player_maxmp = player.GetMaxmp();

			victim.SetProbability(100.0f);
			victim.SetTime(((48000 / ((norm(player_maxmp / (2 * player_mp + 1)) + 1) * (norm(player_maxhp / (2 * player_hp + 1)) + 1)))));
			victim.SetBuffid(0);
			victim.SetAmount(((player_maxmp + player_maxhp) * 0.5f));
			victim.SetValue(0.0f);
			victim.SetHpleak(true);
			victim.SetProbability(75.0f);
			victim.SetTime(16100.0f);
			victim.SetRatio(1.5f);
			victim.SetBuffid(0);
			victim.SetDeccrithurt(true);
			return true;
		}
	}
	public class GSkill1693 : GSkill
	{
		public GSkill1693()
			: base(1693)
		{
			
		}
	}
	public class GSkill1694Stub : GSkillStub
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
				int				player_res1 = player.GetRes1();

				player.SetVar1(player_res1);
				player.SetPerform(1);
			}
		}
		public GSkill1694Stub()
			: base(1694)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
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
			SetAction(0,"??????_??Х");
			SetAction(1,"??????_??Х");
			SetAction(2,"??????_??Х");
			SetAction(3,"??????_??Х");
			SetAction(4,"??????_??Х");
			SetAction(5,"??????_??Х");
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
			SetAction(18,"??????_????_??Х");
			SetAction(19,"??????_????_??Х");
			SetAction(20,"??????_????_??Х");
			SetAction(21,"??????_????_??Х");
			SetAction(22,"??????_????_??Х");
			SetAction(23,"??????_????_??Х");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "??Х????";
			nativename = "??Х????";
			icon = "??Х.dds";
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
			skill_class = 0;
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
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1100.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_var1 = player.GetVar1();

			victim.SetProbability((player_var1 <= 600)?600.0f:player_var1);
			victim.SetTime(((6000 * norm(zrand(100) / 75) + 6100)));
			victim.SetDizzy(true);
			victim.SetProbability(100.0f);
			victim.SetTime(((9000 * norm(zrand(100) / 75) + 9100)));
			victim.SetRatio(0.1f);
			victim.SetBuffid(0);
			victim.SetDecdefence(true);
			victim.SetProbability(100.0f);
			victim.SetTime(16100.0f);
			victim.SetRatio(0.25099999f);
			victim.SetBuffid(0);
			victim.SetDecskillaccu(true);
			return true;
		}
	}
	public class GSkill1694 : GSkill
	{
		public GSkill1694()
			: base(1694)
		{
			
		}
	}
	public class GSkill1695Stub : GSkillStub
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
		public GSkill1695Stub()
			: base(1695)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
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
			SetAction(0,"??????_?κ?");
			SetAction(1,"??????_?κ?");
			SetAction(2,"??????_?κ?");
			SetAction(3,"??????_?κ?");
			SetAction(4,"??????_?κ?");
			SetAction(5,"??????_?κ?");
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
			SetAction(18,"??????_????_?κ?");
			SetAction(19,"??????_????_?κ?");
			SetAction(20,"??????_????_?κ?");
			SetAction(21,"??????_????_?κ?");
			SetAction(22,"??????_????_?κ?");
			SetAction(23,"??????_????_?κ?");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "?κΣ???";
			nativename = "?κΣ???";
			icon = "?κ?.dds";
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
			skill_class = 0;
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
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 800.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(100.0f);
			victim.SetTime(15100.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(0);
			victim.SetIncattack(true);
			victim.SetTime(15100.0f);
			victim.SetValue(((20 * norm(zrand(100) / 75) + 20)));
			victim.SetBlessed(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(16100.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(0);
			victim.SetIncskilldamage(true);
			return true;
		}
	}
	public class GSkill1695 : GSkill
	{
		public GSkill1695()
			: base(1695)
		{
			
		}
	}
	public class GSkill1696Stub : GSkillStub
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
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(0.5f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(0.69999999f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState4 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(0.89999998f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState5 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(1.1f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState6 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(1.3f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState7 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(1.5f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState8 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(1.7f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState9 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(1.9f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState10 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 600;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();
				int				player_maxhp = player.GetMaxhp();
				int				player_mp = player.GetMp();
				int				player_maxmp = player.GetMaxmp();

				skill.SetRatio(2.0999999f);
				skill.SetPlus((norm((2 * player_mp) / (player_maxmp + 1)) * (player_mp * 0.01f) + (norm((2 * player_hp) / (player_maxhp + 1)) * (player_hp * 0.01f))));
				player.SetPerform(1);
			}
		}
		public GSkill1696Stub()
			: base(1696)
		{
			occupation = 146;
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
			SetAction(0,"??????_?ű?");
			SetAction(1,"??????_?ű?");
			SetAction(2,"??????_?ű?");
			SetAction(3,"??????_?ű?");
			SetAction(4,"??????_?ű?");
			SetAction(5,"??????_?ű?");
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
			SetAction(18,"??????_????_?ű?");
			SetAction(19,"??????_????_?ű?");
			SetAction(20,"??????_????_?ű?");
			SetAction(21,"??????_????_?ű?");
			SetAction(22,"??????_????_?ű?");
			SetAction(23,"??????_????_?ű?");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "?ű䣺??";
			nativename = "?ű䣺??";
			icon = "?ű?.dds";
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
			skill_class = 0;
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
			AddState(new GState6());
			AddState(new GState7());
			AddState(new GState8());
			AddState(new GState9());
			AddState(new GState10());
		}
		public override int GetExecutetime(GSkill skill)
		{
			return 6000;
		}
		public override int GetCooldowntime(GSkill skill)
		{
			return 360000;
		}
		public override float GetPraydistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 18.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 24.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 305.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(10.0f);
			victim.SetTime(16100.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(0);
			victim.SetDeccrithurt(true);
			return true;
		}
	}
	public class GSkill1696 : GSkill
	{
		public GSkill1696()
			: base(1696)
		{
			
		}
	}
	public class GSkill1697Stub : GSkillStub
	{
		public class GState1 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 400;
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
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();

				player.SetHp((player_hp * 0.75f));
				skill.SetRatio(2.0f);
				skill.SetCrit(0.5f);
				player.SetPerform(1);
			}
			public override bool Cancel(GSkill skill)
			{
				return true;
			}
		}
		public class GState3 : GState
		{
			public override int GetTime(GSkill skill)
			{
				return 800;
			}
			public override void Calculate(GSkill skill)
			{
				GPlayerWrapper	player = skill.GetPlayer();
				int				player_hp = player.GetHp();

				player.SetHp((player_hp * 0.75f));
				skill.SetCrit(0.5f);
				skill.SetRatio(1.0f);
				player.SetPerform(0);
			}
		}
		public GSkill1697Stub()
			: base(1697)
		{
			occupation = 146;
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
			dobless = true;
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
			SetAction(0,"??????_?շ?");
			SetAction(1,"??????_?շ?");
			SetAction(2,"??????_?շ?");
			SetAction(3,"??????_?շ?");
			SetAction(4,"??????_?շ?");
			SetAction(5,"??????_?շ?");
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
			SetAction(18,"??????_????_?շ?");
			SetAction(19,"??????_????_?շ?");
			SetAction(20,"??????_????_?շ?");
			SetAction(21,"??????_????_?շ?");
			SetAction(22,"??????_????_?շ?");
			SetAction(23,"??????_????_?շ?");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "?շ?????";
			nativename = "?շ?????";
			icon = "?շ?.dds";
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
			skill_class = 0;
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

			return player_range + 6.0f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 2.0f;
		}
		public override float GetEffectdistance(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			float			player_range = player.GetRange();

			return player_range + 8.0f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1100.000000f;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetProbability(25.0f);
			victim.SetTime(8100.0f);
			victim.SetDiet(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();
			int				skill_level = skill.GetLevel();

			victim.SetTime(6100.0f);
			victim.SetRatio((player_level * 0.002f + 0.5f));
			victim.SetAmount(((1600 * player_level * skill_level)));
			victim.SetDechurt(true);
			return true;
		}
	}
	public class GSkill1697 : GSkill
	{
		public GSkill1697()
			: base(1697)
		{
			
		}
	}
	public class GSkill1698Stub : GSkillStub
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
		public GSkill1698Stub()
			: base(1698)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 3;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
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
			SetAction(0,"??????_??ħ????");
			SetAction(1,"??????_??ħ????");
			SetAction(2,"??????_??ħ????");
			SetAction(3,"??????_??ħ????");
			SetAction(4,"??????_??ħ????");
			SetAction(5,"??????_??ħ????");
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
			SetAction(18,"??????_????_??ħ????");
			SetAction(19,"??????_????_??ħ????");
			SetAction(20,"??????_????_??ħ????");
			SetAction(21,"??????_????_??ħ????");
			SetAction(22,"??????_????_??ħ????");
			SetAction(23,"??????_????_??ħ????");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "??ħ????????";
			nativename = "??ħ????????";
			icon = "??ħ????.dds";
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
			skill_class = 3;
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
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1150.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_level = player.GetLevel();

			victim.SetProbability(100.0f);
			victim.SetTime(15100.0f);
			victim.SetBuffid(0);
			victim.SetAmount((((30 * player_level) - 15 * norm(zrand(100) / 85) * player_level)));
			victim.SetValue(((99 * player_level)));
			victim.SetSubhp(true);
			victim.SetProbability(100.0f);
			victim.SetTime(15100.0f);
			victim.SetBuffid(0);
			victim.SetAmount((((30 * player_level) - 15 * norm(zrand(100) / 85) * player_level)));
			victim.SetValue(((99 * player_level)));
			victim.SetSubmp(true);
			victim.SetProbability(100.0f);
			victim.SetTime(16100.0f);
			victim.SetRatio(0.25099999f);
			victim.SetBuffid(0);
			victim.SetDecskillaccu(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	player = skill.GetPlayer();
			GPlayerWrapper	victim = skill.GetVictim();
			int				player_hp = player.GetHp();

			victim.SetProbability(100.0f);
			victim.SetRatio(0.0f);
			victim.SetValue(player_hp);
			victim.SetHeal(true);
			victim.SetProbability(100.0f);
			victim.SetBuffid(2);
			victim.SetAmount(99.0f);
			victim.SetValue(99.0f);
			victim.SetExorcism(true);
			return true;
		}
	}
	public class GSkill1698 : GSkill
	{
		public GSkill1698()
			: base(1698)
		{
			
		}
	}
	public class GSkill1699Stub : GSkillStub
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
		public GSkill1699Stub()
			: base(1699)
		{
			occupation = 146;
			maxlevel = 1;
			maxlearn = 1;
			eventflag = 0;
			spcost = 1;
			reborncount = 0;
			type = 2;
			timetype = 0;
			targettype = 0;
			rangetype = 2;
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
			SetAction(0,"??????_????????");
			SetAction(1,"??????_????????");
			SetAction(2,"??????_????????");
			SetAction(3,"??????_????????");
			SetAction(4,"??????_????????");
			SetAction(5,"??????_????????");
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
			SetAction(18,"??????_????_????????");
			SetAction(19,"??????_????_????????");
			SetAction(20,"??????_????_????????");
			SetAction(21,"??????_????_????????");
			SetAction(22,"??????_????_????????");
			SetAction(23,"??????_????_????????");
			SetAction(24,"");
			SetAction(25,"");
			SetAction(26,"");
			SetAction(27,"");
			SetAction(28,"");
			SetAction(29,"");
			SetAction(30,"");
			name = "???????⣺??";
			nativename = "???????⣺??";
			icon = "????????.dds";
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
			skill_class = 3;
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
		public override float GetRadius(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetPraydistance(GSkill skill)
		{
			return 25.000000f;
		}
		public override float GetCastdistance(GSkill skill)
		{
			return 10.000000f;
		}
		public override float GetMpcost(GSkill skill)
		{
			return 1100.000000f;
		}
		public override int GetCoverage(GSkill skill)
		{
			return 25;
		}
		public override bool StateAttack(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(30100.0f);
			victim.SetRatio(1.0f);
			victim.SetBuffid(0);
			victim.SetIncanti(true);
			victim.SetProbability(100.0f);
			victim.SetTime(12100.0f);
			victim.SetBuffid(0);
			victim.SetValue(9999.0f);
			victim.SetAdddefence(true);
			victim.SetProbability(100.0f);
			victim.SetClearwrap(true);
			return true;
		}
		public override bool BlessMe(GSkill skill)
		{
			GPlayerWrapper	victim = skill.GetVictim();

			victim.SetTime(16100.0f);
			victim.SetRatio(0.1f);
			victim.SetBuffid(0);
			victim.SetIncskilldamage(true);
			victim.SetProbability(100.0f);
			victim.SetBuffid(3);
			victim.SetAmount(99.0f);
			victim.SetValue(99.0f);
			victim.SetExorcism(true);
			return true;
		}
	}
	public class GSkill1699 : GSkill
	{
		public GSkill1699()
			: base(1699)
		{
			
		}
	}
}
