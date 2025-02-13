﻿using SolastaModApi;
using SolastaModApi.Extensions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionAdditionalDamages;

namespace SolastaLevel20.Models.Features
{
    internal class AdditionalDamagePaladinImprovedDivineSmiteBuilder : BaseDefinitionBuilder<FeatureDefinitionAdditionalDamage>
    {
        const string AdditionalDamagePaladinImprovedDivineSmiteName = "AdditionalDamagePaladinImprovedDivineSmite";
        const string AdditionalDamagePaladinImprovedDivineSmiteGuid = "d7dbc91bbe4842648787691097f6b2a1";

        protected AdditionalDamagePaladinImprovedDivineSmiteBuilder(string name, string guid) : base(AdditionalDamagePaladinDivineSmite, name, guid)
        {
            Definition.GuiPresentation.Title = "Feature/&PaladinImprovedDivineSmiteTitle";
            Definition.GuiPresentation.Description = "Feature/&PaladinImprovedDivineSmiteDescription";

            Definition.SetDamageAdvancement(RuleDefinitions.AdditionalDamageAdvancement.None);
            Definition.SetNotificationTag("ImprovedDivineSmite");
            Definition.SetTriggerCondition(RuleDefinitions.AdditionalDamageTriggerCondition.AlwaysActive);
            Definition.DiceByRankTable.Clear();
            Definition.FamiliesWithAdditionalDice.Clear();
        }

        private static FeatureDefinitionAdditionalDamage CreateAndAddToDB(string name, string guid)
            => new AdditionalDamagePaladinImprovedDivineSmiteBuilder(name, guid).AddToDB();

        public static readonly FeatureDefinitionAdditionalDamage AdditionalDamagePaladinImprovedDivineSmite
            = CreateAndAddToDB(AdditionalDamagePaladinImprovedDivineSmiteName, AdditionalDamagePaladinImprovedDivineSmiteGuid);
    }
}