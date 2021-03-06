--[[
***本脚本主要对法宝附加人物技能（非法宝技能）进行处理***
法宝通用数据
ZLuaTal_SkillSetInit()    ---设置选取法宝附加技能的部分原则

法宝个体数据
ZLuaTal_Talisman_Trans_ID(Temp_TalismanID)  ---根据传入的法宝ID取得职业和法宝品阶信息
ZLuaTal_Talisman_Skill_Info(Player_Prof,Talisman_Lvl,origin)  	---根据法宝职业需求和法宝品阶决定附加技能和附加技能出现的法宝级别

功能类
ZLuaTal_CheckIsNumberTable(ANumTable,Numr_Min)     	 	---检验一个Table是否为Number组成的table，且最小为Numr_Min
ZLuaTal_Chance_Norm(n1)                             	---对一个table（概率序列）中的数进行概率归一化
ZLuaTal_Get_RanPoint(s1)                            	---随机在一个概率序列s1中选取一个数并返回位置信息
ZLuaTal_Make_AllChoise(t,prof,Temp_TalismanID,origin)                           	---按照ZLuaTal_SkillSetInit()中的设定在t序列中选数并返回选择的数
ZLuaTal_FindSkillReqInfo(t,ts)                          ---在ts序列中寻找t，并返回t对应的位置
--]]
-------------------------------------------------------------------------------- 
function ZLuaTal_SkillSetInit()
	local MaxSameSkillColu=1 	-----同一种可能的最大出现次数
	local MaxSkillChoise=6  	-----需要从序列中选取的目标个数,<=30 
	local SameNum=1           	-----同一种可能的当前出现次数初值
	local SkillLearnDelay=3 	-----技能出现可能延迟的法宝阶数 0时没有延迟，N代表0,...N-1
	local MaxPosLvl=30				-----法宝可能的最大级别
	return MaxSameSkillColu,MaxSkillChoise,SameNum,SkillLearnDelay,MaxPosLvl 
end 
-------------------------------------------------------------------------------- 
---接受导入的法宝ID信息，转化为职业和法宝级别（相应人物级别档位）
function ZLuaTal_Talisman_Trans_ID(Temp_TalismanID,origin)
    if type(Temp_TalismanID)~="number" or type(origin)~="number" then return false,false end
    ----如果传入的不是number则返回false false
  local Temp_Player_Prof,Temp_Talisman_Lvl
	local Temp_TalismanSign=ZLuaTalAvailableTalismans()	----标志法宝ID的量
	
	if Temp_TalismanID==Temp_TalismanSign["NW_1_BaGuaShi"].tmplID then
	   Temp_Player_Prof=0
		 Temp_Talisman_Lvl=0
	elseif 	Temp_TalismanID==Temp_TalismanSign["QY_15_LiuHeJing"].tmplID then
	   Temp_Player_Prof=1
		 Temp_Talisman_Lvl=1
	elseif 	Temp_TalismanID==Temp_TalismanSign["GW_15_ZhuQueYin"].tmplID then
	   Temp_Player_Prof=2
		 Temp_Talisman_Lvl=1
	elseif 	Temp_TalismanID==Temp_TalismanSign["TY_15_LunHuiZhu"].tmplID then
	   Temp_Player_Prof=3
		 Temp_Talisman_Lvl=1
	elseif 	Temp_TalismanID==Temp_TalismanSign["HH_15_SheXinLing"].tmplID then
		 Temp_Player_Prof=4
		 Temp_Talisman_Lvl=1
	elseif 	Temp_TalismanID==Temp_TalismanSign["GD_15_XueYuGuPian"].tmplID then
		 Temp_Player_Prof=5
		 Temp_Talisman_Lvl=1
	elseif 	Temp_TalismanID==Temp_TalismanSign["QY_75_QiXingJian"].tmplID then
     Temp_Player_Prof=1
		 Temp_Talisman_Lvl=2
	elseif 	Temp_TalismanID==Temp_TalismanSign["GW_75_SiLingFan"].tmplID then
	   Temp_Player_Prof=2
		 Temp_Talisman_Lvl=2
	elseif 	Temp_TalismanID==Temp_TalismanSign["TY_75_JinGangChu"].tmplID then
	   Temp_Player_Prof=3
		 Temp_Talisman_Lvl=2
	elseif 	Temp_TalismanID==Temp_TalismanSign["HH_75_DuoQingHuan"].tmplID then
		 Temp_Player_Prof=4
		 Temp_Talisman_Lvl=2
	elseif 	Temp_TalismanID==Temp_TalismanSign["GD_75_PoSha"].tmplID then
		 Temp_Player_Prof=5
		 Temp_Talisman_Lvl=2
  elseif 	Temp_TalismanID==Temp_TalismanSign["QY_105_HuPoZhuLing"].tmplID then
		 Temp_Player_Prof=1
		 Temp_Talisman_Lvl=3
  elseif 	Temp_TalismanID==Temp_TalismanSign["GW_105_QianKunQingGuangJie"].tmplID then
		 Temp_Player_Prof=2
		 Temp_Talisman_Lvl=3 
  elseif 	Temp_TalismanID==Temp_TalismanSign["TY_105_RuYiQianKunDai"].tmplID then
		 Temp_Player_Prof=3
		 Temp_Talisman_Lvl=3 
  elseif 	Temp_TalismanID==Temp_TalismanSign["HH_105_QianMeiLian"].tmplID then
		 Temp_Player_Prof=4
		 Temp_Talisman_Lvl=3
	elseif 	Temp_TalismanID==Temp_TalismanSign["GD_105_QianDuGu"].tmplID then
		 Temp_Player_Prof=5
		 Temp_Talisman_Lvl=3
  elseif 	Temp_TalismanID==Temp_TalismanSign["GW_135_TianMoZhi"].tmplID then
		 Temp_Player_Prof=2
		 Temp_Talisman_Lvl=4
  elseif 	Temp_TalismanID==Temp_TalismanSign["QY_135_RuoXue"].tmplID then
		 Temp_Player_Prof=1
		 Temp_Talisman_Lvl=4 
  elseif 	Temp_TalismanID==Temp_TalismanSign["HH_135_BaJiYouLong"].tmplID then
		 Temp_Player_Prof=4
		 Temp_Talisman_Lvl=4 
  elseif 	Temp_TalismanID==Temp_TalismanSign["TY_135_LiuDaoShengMie"].tmplID then
		 Temp_Player_Prof=3
		 Temp_Talisman_Lvl=4
	elseif 	Temp_TalismanID==Temp_TalismanSign["GD_135_GuiQing"].tmplID then
		 Temp_Player_Prof=5
		 Temp_Talisman_Lvl=4
  elseif 	Temp_TalismanID==Temp_TalismanSign["US_75_ShanHeShan"].tmplID or
  			 	Temp_TalismanID==Temp_TalismanSign["US_45_ShenMuShai"].tmplID or 
  			 	Temp_TalismanID==Temp_TalismanSign["US_75_WanDuDing"].tmplID or
  			 	Temp_TalismanID==Temp_TalismanSign["US_75_LingLongTa"].tmplID or
  			 	Temp_TalismanID==Temp_TalismanSign["US_75_YuJingPing"].tmplID then
     Temp_Player_Prof=6
		 Temp_Talisman_Lvl=2
	elseif  Temp_TalismanID==Temp_TalismanSign["US_105_JinHuLu"].tmplID or
  		  	Temp_TalismanID==Temp_TalismanSign["US_105_JiuLongShenHuoZhao"].tmplID or
  		  	Temp_TalismanID==Temp_TalismanSign["US_105_YinYangJing"].tmplID or
  		  	Temp_TalismanID==Temp_TalismanSign["US_105_ZhenShanHeShan"].tmplID or
  		  	Temp_TalismanID==Temp_TalismanSign["US_105_LuoHunDeng"].tmplID then
     Temp_Player_Prof=6
		 Temp_Talisman_Lvl=3
	elseif 	Temp_TalismanID==Temp_TalismanSign["US_135_SheHun"].tmplID or
					Temp_TalismanID==Temp_TalismanSign["US_135_PanLongFan"].tmplID or 
					Temp_TalismanID==Temp_TalismanSign["US_135_WuLongLun"].tmplID or 	
					Temp_TalismanID==Temp_TalismanSign["US_135_FanTianYin"].tmplID or 	
					Temp_TalismanID==Temp_TalismanSign["US_135_ChangMingDeng"].tmplID or 	
  				Temp_TalismanID==Temp_TalismanSign["US_145_ShiXueZhu"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["US_145_ShiHun"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["foodtalisman"].tmplID then
     Temp_Player_Prof=6
		 Temp_Talisman_Lvl=4
  elseif  Temp_TalismanID==Temp_TalismanSign["ceshifeibao"].tmplID or
          Temp_TalismanID==Temp_TalismanSign["ceshixingxiang"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["feiafei"].tmplID then
  	 Temp_Player_Prof=7
		 Temp_Talisman_Lvl=1
	------任务模式给予的彩票飞剑
  elseif  Temp_TalismanID==Temp_TalismanSign["longxiang"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["yunsuo"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["yuruyi"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["biluo"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["hongfei"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["zimang"].tmplID or
  				Temp_TalismanID==Temp_TalismanSign["huiji"].tmplID then
  	 Temp_Player_Prof=7
		 Temp_Talisman_Lvl=1
	------任务给予的非彩票产出的飞剑
	elseif  Temp_TalismanID==Temp_TalismanSign["shuoguang"].tmplID or
	        Temp_TalismanID==Temp_TalismanSign["jueying"].tmplID or
	        Temp_TalismanID==Temp_TalismanSign["liudaolunhui"].tmplID or
	        Temp_TalismanID==Temp_TalismanSign["qingshuang"].tmplID or
	        Temp_TalismanID==Temp_TalismanSign["jueying2"].tmplID or
	        Temp_TalismanID==Temp_TalismanSign["shuoguang2"].tmplID then
  	 Temp_Player_Prof=7
		 Temp_Talisman_Lvl=0
	else
     return false,false
	end
	
	local a1Temptable={}    ----返回的技能数据1
	local a2Temptable={}    ----返回的技能数据2
	a1Temptable,a2Temptable= ZLuaTal_Talisman_Skill_Info(Temp_Player_Prof,Temp_Talisman_Lvl,origin)

	if ZLuaTal_CheckIsNumberTable(a1Temptable,0) and ZLuaTal_CheckIsNumberTable(a2Temptable,0) then
		return a1Temptable,a2Temptable
	else
	    return false,true
		----如果返回的值不是table或者table中有小于0的数，则返回false false
	end

end
--------------------------------------------------------------------------------
------根据法宝不同的职业、档位决定附加技能、附加技能出现法宝级别----------------
function ZLuaTal_Talisman_Skill_Info(Player_Prof,Talisman_Lvl,origin)
	---Player_Prof
	---shaoxia(0),qingyun(1),guiwang(2),tianyin(3),hehuan(4),guidao(5),suiji(6),feijian(7)
	---Talisman_Lvl
	---0(lvl=1),1(lvl=15),2(lvl=75),3(lvl=105),4(lvl=135),5(lvl=145)
	----对于Player_Prof=0时，Talisman_Lvl<=2 
	---math.randomseed(os.time())
	---math.random()
	---math.random()
	
	if type(Player_Prof)~="number" or type(Talisman_Lvl)~="number" or type(origin)~="number" then return end

	local MaxSameSkillColu 	-----同一种可能的最大出现次数
	local MaxSkillChoise  	-----需要从序列中选取的目标个数
	local SameNum           -----同一种可能的当前出现次数初值
	local SkillLearnDelay 	-----修习技能可能延迟的法宝阶数  0时没有延迟
	local MaxPosLvl					-----法宝可能出现的最大级别
	MaxSameSkillColu,MaxSkillChoise,SameNum,SkillLearnDelay,MaxPosLvl = ZLuaTal_SkillSetInit()


	local SkillExInfo={}  ----技能编号信息（模板号）

	---//新手法宝附加技能模板号信息
	SkillExInfo[1]={337,338,340,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[2]={337,338,354,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[3]={337,338,370,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[4]={337,338,385,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[5]={337,338,340,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[6]={337,338,354,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[7]={337,338,370,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[8]={337,338,385,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[9]={337,338,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[10]={337,338,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	---//青云门法宝附加技能模板号信息
	SkillExInfo[11]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[12]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[13]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[14]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[15]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[16]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[17]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[18]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[19]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	SkillExInfo[20]={370,369,371,372,373,374,375,376,377,378,379,380,381,382,383,886,887,888,889,890,891,892,904,905,0,0,0,0,0,0}
	---//鬼王宗法宝附加技能模板号信息
	SkillExInfo[21]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[22]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[23]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[24]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[25]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[26]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[27]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[28]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[29]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	SkillExInfo[30]={340,339,341,342,343,344,345,346,347,348,349,350,351,352,353,872,873,874,875,876,877,878,900,901,0,0,0,0,0,0}
	---//天音寺法宝附加技能模板号信息
	SkillExInfo[31]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[32]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[33]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[34]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[35]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[36]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[37]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[38]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[39]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
	SkillExInfo[40]={385,384,386,387,388,389,390,391,392,393,394,395,396,397,398,893,894,895,896,897,898,899,906,907,0,0,0,0,0,0}
    ---//合欢派门派法宝附加技能模板号信息
	SkillExInfo[41]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[42]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[43]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[44]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[45]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[46]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[47]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[48]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[49]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	SkillExInfo[50]={354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,879,880,881,882,883,884,885,902,903,0,0,0,0,0,0}
	---//鬼道法宝附加技能模板号信息
	SkillExInfo[51]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[52]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[53]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[54]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[55]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[56]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[57]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[58]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[59]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[60]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
---//飞剑附加技能模板号信息（凑数凑数）
	SkillExInfo[61]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[62]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[63]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[64]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[65]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[66]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[67]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[68]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[69]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	SkillExInfo[70]={1758,1759,1760,1761,1762,1763,1764,1765,1766,1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,0,0,0,0,0,0}
	---//飞剑附加技能模板号信息
	SkillExInfo[71]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[72]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[73]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[74]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[75]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[76]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[77]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[78]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[79]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillExInfo[80]={1922,1923,1924,1925,1926,1927,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	local SkillRanChance={}
	---//新手法宝附加技能出现概率信息
	SkillRanChance[1]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[2]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[3]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[4]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[5]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[6]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[7]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[8]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[8]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[10]={256,128,64,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
    ---//青云门法宝附加技能出现概率信息（15-20暂时，以下相应位置同）
	SkillRanChance[11]={512,448,384,320,256,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[12]={256,320,384,448,512,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[13]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[14]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[15]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[16]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[17]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[18]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[19]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	SkillRanChance[20]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	---//鬼王宗法宝附加技能出现概率信息
	SkillRanChance[21]={512,448,384,320,256,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[22]={256,320,384,448,512,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[23]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[24]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[25]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[26]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[27]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[28]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[29]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	SkillRanChance[30]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	---//天音寺法宝附加技能出现概率信息
	SkillRanChance[31]={512,448,384,320,256,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[32]={256,320,384,448,512,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[33]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[34]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[35]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[36]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[37]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[38]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[39]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	SkillRanChance[40]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	---//合欢派法宝附加技能出现概率信息
	SkillRanChance[41]={512,448,384,320,256,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[42]={256,320,384,448,512,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[43]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[44]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[45]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[46]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[47]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[48]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[49]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	SkillRanChance[50]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	---//鬼道法宝附加技能出现概率信息
	SkillRanChance[51]={512,448,384,320,256,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[52]={256,320,384,448,512,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[53]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[54]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[55]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[56]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[57]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[58]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[59]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	SkillRanChance[60]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	---//飞剑附加技能出现概率信息（凑数）
	SkillRanChance[61]={512,448,384,320,256,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[62]={256,320,384,448,512,64,64,64,64,64,16,16,16,16,16,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0}
	SkillRanChance[63]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[64]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,2,2,2,2,2,2,2,2,2,2,0,0,0,0,0}
	SkillRanChance[65]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[66]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,4,4,4,4,4,4,4,4,4,4,0,0,0,0,0}
	SkillRanChance[67]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[68]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,8,8,8,8,8,8,8,8,8,8,0,0,0,0,0}
	SkillRanChance[69]={64,64,64,64,64,128,128,128,128,128,128,192,256,320,384,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	SkillRanChance[70]={128,128,128,128,128,64,64,64,64,64,384,320,256,192,128,16,16,16,16,16,16,16,16,16,16,0,0,0,0,0}
	---//飞剑附加技能出现概率信息
	SkillRanChance[71]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}---quest
	SkillRanChance[72]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}---shop
	SkillRanChance[73]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}---npc
	SkillRanChance[74]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}---lottery
	SkillRanChance[75]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[76]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}---combine
	SkillRanChance[77]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[78]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[79]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	SkillRanChance[80]={0,512,16,256,8,256,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	
	local SkillRanChanceWhenOrigin={}
	SkillRanChanceWhenOrigin[1]={100,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
	
	local Skill_AddonInfo={}
    ---法宝可能附加所有技能模板号
	Skill_AddonInfo={337,338,0,
	339,340,341,342,343,344,345,346,347,348,349,350,351,352,353,
	354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,
	369,370,371,372,373,374,375,376,377,378,379,380,381,382,383,
	384,385,386,387,388,389,390,391,392,393,394,395,396,397,398,
	872,873,874,875,876,877,878,879,880,881,882,883,884,885,886,
	887,888,889,890,891,892,893,894,895,896,897,898,899,900,901,
	902,903,904,905,906,907,1758,1759,1760,1761,1762,1763,1764,1765,1766,
	1767,1768,1769,1770,1771,1772,1773,1774,1775,1776,1777,1778,1779,1780,1781,
	1922,1923,1924,1925,1926,1927}
	
	
  local Skill_ReqLvlInfo={}
	---法宝附加技能对应的法宝级别需求(Skill_AddonInfo一一对应）
	Skill_ReqLvlInfo={1,2,0,
  4,3,5,8,6,14,9,12,11,10,17,18,15,20,16,
	3,6,5,7,8,11,9,10,12,11,16,17,16,15,18,
	5,3,6,4,8,14,9,12,11,10,17,15,20,18,16,
	4,3,8,6,4,10,9,12,14,11,13,18,16,15,20,
	21,22,23,24,26,27,28,21,22,23,24,25,27,28,21,
	22,23,24,25,27,28,21,22,23,24,25,27,28,29,30,
	29,30,29,30,29,30,3,4,5,6,7,9,11,12,14,
	13,15,15,17,18,19,21,23,23,24,25,27,28,29,30,
	1,10,15,20,25,30}

  local RSkillExInfo_1={}    ----第一次选择的原始附加属性ID序列
	local RSkillExInfo_2={}    ----用于返回的附加属性ID序列
	local CSkillRanChance={}   ----选择的SkillExInfo[N]中的具体法宝技能序号
	local RSkillReqInfo={}     ----法宝技能需求法宝级别信息
  local ID_Choosed  		   ----随机的ID号码

	local Temp_Ran_NumA
	
	Temp_Ran_NumA=math.random()
	
	if Temp_Ran_NumA==0 then Temp_Ran_NumA=0.01 end
	if Player_Prof~=6 then     ----如果职业不为随机职业
			if Player_Prof==0 then 
					if origin==0 then		---origin:0 quest;1 shop;2 npc;3 lottery;5 combine
						ID_Choosed=Player_Prof*10+1
					else 
						ID_Choosed=Player_Prof*10+math.ceil(Temp_Ran_NumA*Talisman_Lvl*4)
			  	end
			elseif Player_Prof==7 then
				 ID_Choosed=Player_Prof*10+1+origin
			else 
					if origin==0 then 
						ID_Choosed=Player_Prof*10+1
			  	else
			    	ID_Choosed=Player_Prof*10+math.ceil(Temp_Ran_NumA*Talisman_Lvl*2)
					end 
			end 
	else
		ID_Choosed=math.ceil(Temp_Ran_NumA*5)*10+math.ceil(Temp_Ran_NumA*Talisman_Lvl*2)
		---如果鬼道加入，则为*5
	end

	if ID_Choosed>80 or ID_Choosed<1 then ID_Choosed=1 end

	RSkillExInfo_1=SkillExInfo[ID_Choosed]
	if Player_Prof~=6 and Player_Prof~=7 and Talisman_Lvl~=4 and origin==0 then 
		CSkillRanChance=ZLuaTal_Make_AllChoise(SkillRanChanceWhenOrigin[1],Player_Prof,Talisman_Lvl,origin)
    ---ZLuaTal_Special_Print(CSkillRanChance)    ---$$$$测试用$$$$-----
 	else
 		CSkillRanChance=ZLuaTal_Make_AllChoise(SkillRanChance[ID_Choosed],Player_Prof,Talisman_Lvl,origin)
 	end 
  
  local mm
	for mm=1,table.getn(CSkillRanChance) do

	    if CSkillRanChance[mm]==65536 then
	    		RSkillExInfo_2[mm]=0
					RSkillReqInfo[mm]=0
			else
				RSkillExInfo_2[mm]=RSkillExInfo_1[CSkillRanChance[mm]]
				if table.getn(Skill_AddonInfo)~=table.getn(Skill_ReqLvlInfo) then return end
				if SkillLearnDelay==0 or RSkillExInfo_2[mm]==0 or (Player_Prof~=6 and origin==0) or Player_Prof==7 then
					RSkillReqInfo[mm]= Skill_ReqLvlInfo[ZLuaTal_FindSkillReqInfo(RSkillExInfo_2[mm],Skill_AddonInfo)]
			  else
			    RSkillReqInfo[mm]= Skill_ReqLvlInfo[ZLuaTal_FindSkillReqInfo(RSkillExInfo_2[mm],Skill_AddonInfo)]+math.floor(math.random()*SkillLearnDelay)
				end
			end
			if RSkillReqInfo[mm]>MaxPosLvl then RSkillReqInfo[mm]=MaxPosLvl end
	end
	---ZLuaTal_Special_Print(RSkillExInfo_2)   	---$$$$测试用$$$$-----
	---ZLuaTal_Special_Print(RSkillReqInfo)		---$$$$测试用$$$$-----
	return ZLuaTal_SkillMakeSeq(RSkillExInfo_2, RSkillReqInfo)
end
--------------------------------------------------------------------------------

------------检查是否为一个数组成的table,table中,且最小不小于Numr_Min------------
function ZLuaTal_CheckIsNumberTable(ANumTable,Numr_Min)
	local tm
	if type(ANumTable)~="table" then return false end  
	if type(ANumTable)=="table" then
		for tm=1,table.getn(ANumTable) do 
			if type(ANumTable[tm])~="number" or ANumTable[tm]<Numr_Min then
				return false 
            end 
		end  
	end  
	return true
end 

----出现几率正态化--------------------------------------------------------------
function ZLuaTal_Chance_Norm(n1)
  if not ZLuaTal_CheckIsNumberTable(n1,0) then return end 
	local n1_size=table.getn(n1)
	local Total_Chance=0
	local i,m,k
	---先求和
	for i=1,n1_size do
   		Total_Chance=n1[i]+Total_Chance          
	end
 	---生成概率组序列
	local nx={}
	for k=1,n1_size do
		if k==1 then 
			nx[1]=n1[k]
		else
	   	nx[k]=n1[k]+nx[k-1]              
	  end
	end

	---再生产标准化的概率组序列
	local n2={}
     for m=1,n1_size do
     		if Total_Chance==0 then                 ---对于全0序列的处理，返回{1,0,0...}
			 		n2[m]=0
					n2[1]=1
				else
					n2[m]=nx[m]/ Total_Chance
				end
	 	 end
	---返回一个概率序列 
    ---ZLuaTal_Special_Print(n2)   				---$$$$测试用$$$$-----
	return n2
end
-------------------------------------------------------------------------------- 

----按照出现概率随机应该选取的位置----------------------------------------------
function ZLuaTal_Get_RanPoint(s1)
	if not ZLuaTal_CheckIsNumberTable(s1,0) then return end 
	local js,ron1
	ron1= math.random()                
	---print("---------------------------")     ---$$$$测试用$$$$-----
	---print("Now the random Num is:",ron1) 	---$$$$测试用$$$$-----
  local p1=ZLuaTal_Chance_Norm(s1)
	for js=1,table.getn(p1) do
          if ron1<=p1[js] then 
		    ---print("So We Choose:",js) 		---$$$$测试用$$$$-----
    	  		return js
		  		end
	end
	return 1
end

----按照上述原则选数------------------------------------------------------------
function ZLuaTal_Make_AllChoise(t,prof,Talisman_Lvl,origin)
  if not ZLuaTal_CheckIsNumberTable(t,0) then return end 
	
	local MaxSameSkillColu 	-----同一种可能的最大出现次数 
	local MaxSkillChoise  	-----需要从序列中选取的目标个数 
	local SameNum           -----同一种可能的当前出现次数初值 
	local SkillLearnDelay 	-----修习技能可能延迟的法宝阶数  0时没有延迟 
	local MaxPosLvl					-----法宝可能的最大级别
	MaxSameSkillColu,MaxSkillChoise,SameNum,SkillLearnDelay,MaxPosLvl = ZLuaTal_SkillSetInit()

	local kk,pp,qq
	local TrueSkillChoise		---实际选取的技能最大数量
	local SkillNumChanceList={} ---实际选取技能数目的概率序列
	local Mchoise={}
	
  if prof==7 then
  	local r = math.random()
    if origin==0 then
    	if Talisman_Lvl==0 then
     			Mchoise={2,4,6}
     	elseif Talisman_Lvl==1 then
     			if r < 0.4 then
     			    Mchoise={2,3,4,5,6}
    	    else
     			    Mchoise={2,3,4,6}
     	    end
     	end
    elseif origin==1 then
    	if r < 0.1 then
     			Mchoise={2,3,4,5,6}
    	elseif r < 0.5 then
     			Mchoise={2,3,4,6}
    	else
     	Mchoise={2,4,6}
     	end
    elseif origin==2 then
    	if r < 0.01 then
     			Mchoise={2,3,4,5,6}
    	elseif r < 0.1 then
     			Mchoise={2,3,4,6}
    	else
     	Mchoise={2,4,6}
     	end
    elseif origin==3 then
    	if r < 0.4 then
     			Mchoise={2,3,4,5,6}
    	else
     			Mchoise={2,3,4,6}
     	end
    else
    	Mchoise={2,4,6}
    end
  else
  	for kk=1,MaxSkillChoise do
   		SkillNumChanceList[kk]=2*kk*kk-42*kk+184
  	end
  	TrueSkillChoise=ZLuaTal_Get_RanPoint(SkillNumChanceList) 
  	for pp=1,TrueSkillChoise do
			Mchoise[pp]=ZLuaTal_Get_RanPoint(t)	
			if pp~=1 then 
				for qq=1,pp-1 do
					if Mchoise[pp]==Mchoise[qq] then 
						SameNum=SameNum+1
						if SameNum>MaxSameSkillColu then 
							Mchoise[pp]=65536 
							SameNum=1
						else 
						end 
					else 
					end 
				end
	  	end 
		end
	end
	---ZLuaTal_Special_Print(Mchoise)
	return Mchoise
end

----在table（ts）中寻找第一个t的位置号------------------------------------------
function ZLuaTal_FindSkillReqInfo(t,ts)
	if type(t)~="number" or type(ts)~="table" then return end
 	local jt
 	for jt=1,table.getn(ts) do
   		if ts[jt]==t then return jt end
  end
	return
end
----将a,b序列中a为0的项置后------------------------------------------------------
function ZLuaTal_SkillMakeSeq(a,b)
	if type(a)~="table" or type(b)~="table" then return a,b end 
	if table.getn(a)~=table.getn(b) then return a,b end 
	local xnum,ynum
	local c={}
	local d={}
	for xnum=1,table.getn(a) do
			c[xnum]=0
			d[xnum]=0	
	end 
	ynum=1
	for xnum=1,table.getn(a) do
		if a[xnum]~=0 then
			c[ynum]=a[xnum]
			d[ynum]=b[xnum]
			ynum=ynum+1
		end 
	end 	 	
	return c,d
end 