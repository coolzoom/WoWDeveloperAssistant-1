﻿using System.Collections.Generic;
using WoWDeveloperAssistant.Misc;

namespace WoWDeveloperAssistant.Core_Script_Templates
{
    public static class Hooks
    {
        public static Dictionary<string, string> creatureHookDictionary = new Dictionary<string, string>
        {
            { "IsSummonedBy",      Utils.AddSpacesCount(12) + "void IsSummonedBy(Unit* p_Summoner) override" + "\n" + Utils.AddSpacesCount(12) + "{" + "\n" +  Utils.AddSpacesCount(16) + "m_SummonerGuid = p_Summoner->GetObjectGuid();" + "\n" + Utils.AddSpacesCount(12) + "}" },
            { "QuestAccept",       Utils.AddSpacesCount(12) + "void sQuestAccept(Player* p_Player, Quest const* p_Quest) override" + "\n" + Utils.AddSpacesCount(12) + "{" + "\n" +  Utils.AddSpacesCount(16) + "\n" + Utils.AddSpacesCount(12) + "}" },
            { "QuestReward",       Utils.AddSpacesCount(12) + "void sQuestReward(Player* p_Player, Quest const* p_Quest, uint32 /*p_Option*/) override" + "\n" + Utils.AddSpacesCount(12) + "{" + "\n" +  Utils.AddSpacesCount(16) + "\n" + Utils.AddSpacesCount(12) + "}" },
            { "GossipSelect",      Utils.AddSpacesCount(12) + "void sGossipSelect(Player* p_Player, uint32 /*p_Sender*/, uint32 p_Action) override" + "\n" + Utils.AddSpacesCount(12) + "{" + "\n" +  Utils.AddSpacesCount(16) + "\n" + Utils.AddSpacesCount(12) + "}" },
            { "GossipHello",       Utils.AddSpacesCount(12) + "void sGossipHello(Player* p_Player) override" + "\n" + Utils.AddSpacesCount(12) + "{" + "\n" +  Utils.AddSpacesCount(16) + "\n" + Utils.AddSpacesCount(12) + "}" },
            { "MoveInLineOfSight", Utils.AddSpacesCount(12) + "void MoveInLineOfSight(Unit* p_Who) override" + "\n" + Utils.AddSpacesCount(12) + "{" + "\n" +  Utils.AddSpacesCount(16) + "\n" + Utils.AddSpacesCount(12) + "}" },
            { "DoAction",          Utils.AddSpacesCount(12) + "void DoAction(int32 const p_Action) override" + "\n" + Utils.AddSpacesCount(12) + "{" + "\n" +  Utils.AddSpacesCount(16) + "\n" + Utils.AddSpacesCount(12) + "}" },
            { "SetData",           Utils.AddSpacesCount(12) + "void SetData(uint64 /*p_Type*/, uint32 /*p_Value*/) override" + "\n" + Utils.AddSpacesCount(12) + "{" + "\n" +  Utils.AddSpacesCount(16) + "\n" + Utils.AddSpacesCount(12) + "}" },
            { "SpellHit",          Utils.AddSpacesCount(12) + "void SpellHit(Unit* p_Caster, SpellInfo const* p_Spell) override" + "\n" + Utils.AddSpacesCount(12) + "{" + "\n" +  Utils.AddSpacesCount(16) + "\n" + Utils.AddSpacesCount(12) + "}" },
            { "OnSpellCasted",     Utils.AddSpacesCount(12) + "void OnSpellCasted(SpellInfo const* p_SpellInfo) override" + "\n" + Utils.AddSpacesCount(12) + "{" + "\n" +  Utils.AddSpacesCount(16) + "\n" + Utils.AddSpacesCount(12) + "}" },
            { "PassengerBoarded",  Utils.AddSpacesCount(12) + "void PassengerBoarded(Unit* p_Passenger, int8 /*p_SeatID*/, bool p_Apply) override" + "\n" + Utils.AddSpacesCount(12) + "{" + "\n" +  Utils.AddSpacesCount(16) + "\n" + Utils.AddSpacesCount(12) + "}" },
            { "MovementInform",    Utils.AddSpacesCount(12) + "void MovementInform(uint32 /*p_Type*/, uint64 p_PointId) override" + "\n" + Utils.AddSpacesCount(12) + "{" + "\n" +  Utils.AddSpacesCount(16) + "\n" + Utils.AddSpacesCount(12) + "}" },
            { "Reset",             Utils.AddSpacesCount(12) + "void Reset() override" + "\n" + Utils.AddSpacesCount(12) + "{" + "\n" +  Utils.AddSpacesCount(16) + "\n" + Utils.AddSpacesCount(12) + "}" },
            { "EnterCombat",       Utils.AddSpacesCount(12) + "void EnterCombat(Unit* /*p_Victim*/) override" + "\n" + Utils.AddSpacesCount(12) + "{" + "\n" +  Utils.AddSpacesCount(16) + "\n" + Utils.AddSpacesCount(12) + "}" },
            { "DamageTaken",       Utils.AddSpacesCount(12) + "void DamageTaken(Unit* /*p_Attacker*/, uint32& /*p_Damage*/, SpellInfo const* /*p_SpellInfo*/) override" + "\n" + Utils.AddSpacesCount(12) + "{" + "\n" +  Utils.AddSpacesCount(16) + "\n" + Utils.AddSpacesCount(12) + "}" },
            { "JustDied",          Utils.AddSpacesCount(12) + "void JustDied(Unit* /*p_Killer*/) override" + "\n" + Utils.AddSpacesCount(12) + "{" + "\n" +  Utils.AddSpacesCount(16) + "\n" + Utils.AddSpacesCount(12) + "}" },
            { "UpdateAI",          Utils.AddSpacesCount(12) + "void UpdateAI(uint32 const /*p_Diff*/) override" + "\n" + Utils.AddSpacesCount(12) + "{" + "\n" +  Utils.AddSpacesCount(16) + "\n" + Utils.AddSpacesCount(12) + "}" }
        };
    }
}
