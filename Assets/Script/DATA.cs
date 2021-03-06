﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class DATA
{
	public int index; //인덱스

	public DATA (List<string> strList)
	{
		index = INT(strList [0]); 
	}

	public static bool BOOL (string str)
	{
		if (string.IsNullOrEmpty(str) || str[0] == '0' || str == "OFF") {
			return false;
		} else if (str[0] == '1' || str == "ON") {
			return true;
		}
		Debug.Log ("BOOL return false!!; " + str);
		return false;
	}

	public static int INT (string str)
	{
		int toReturn;
		int.TryParse (str, out toReturn);
		return toReturn;
	}
}

public class DATA_ACT : DATA
{
	public string name; //행동명
	public bool isItemNeed; //아이템필요유무
	public bool isBasic; //기본 행동

	public DATA_ACT (List<string> strList) : base(strList)
	{
		name = strList [1];
		isItemNeed = BOOL (strList [2]);
		isBasic = BOOL (strList [3]);
		Debug.Log ("DATA_ACT : " +index+" "+ name + " " + isItemNeed + " " + isBasic);
	}
}
	
public class DATA_ITEM : DATA
{
	public string name; //아이템명
	public bool isBasic; //기본 아이템

	public DATA_ITEM (List<string> strList) : base(strList)
	{
		name = strList [1];
		isBasic = BOOL (strList [2]);
	}
}

public class DATA_INFO : DATA
{
	public string discription; //정보스트링

	public DATA_INFO (List<string> strList) : base(strList)
	{
		discription = strList [1];
	}
}
	
public class DATA_ACT_ITEM_COMBINATION : DATA
{
	public int actID;
	public int itemID;
	public int conditionSwitch1ID;
	public bool conditionSwitch1State;
	public int rewardKind;
	public int rewardID;
	public string discription;
	public string imgName;
	public int resultSwitchID;

	public DATA_ACT_ITEM_COMBINATION (List<string> strList) : base(strList)
	{
		actID = INT(strList [1]);
		itemID = INT(strList [2]);
		conditionSwitch1ID = INT(strList [3]);
		conditionSwitch1State = BOOL(strList [4]);
		rewardKind = INT(strList [5]);
		rewardID = INT(strList [6]);
		discription = strList [7];
		imgName = strList [8];
		resultSwitchID = INT(strList [9]);
	}
}

public class DATA_INFO_COMBINATION : DATA
{
	public int combInfo1ID;
	public int combInfo2ID;
	public int rewardKind;
	public int rewardID;
	public string discription;

	public DATA_INFO_COMBINATION (List<string> strList) : base(strList)
	{
		combInfo1ID = INT(strList [1]);
		combInfo2ID = INT(strList [2]);
		rewardKind = INT(strList [3]);
		rewardID = INT(strList [4]);
		discription = strList [5];
	}
}