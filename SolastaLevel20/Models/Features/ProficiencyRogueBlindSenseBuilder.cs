﻿using SolastaModApi;
using SolastaModApi.Extensions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionSenses;

namespace SolastaLevel20.Models.Features
{
    internal class ProficiencyRogueBlindSenseBuilder : BaseDefinitionBuilder<FeatureDefinitionSense>
    {
        const string ProficiencyRogueBlindSenseName = "ProficiencyRogueBlindSense";
        const string ProficiencyRogueBlindSensedGuid = "30c27691f42f4705985c638d38fadc21";

        protected ProficiencyRogueBlindSenseBuilder(string name, string guid) : base(SenseBlindSight2, name, guid)
        {
            Definition.GuiPresentation.Title = "Feature/&ProficiencyRogueBlindSenseTitle";
            Definition.GuiPresentation.Description = "Feature/&ProficiencyRogueBlindSenseDescription";
            Definition.GuiPresentation.SetHidden(false);
        }

        private static FeatureDefinitionSense CreateAndAddToDB(string name, string guid)
            => new ProficiencyRogueBlindSenseBuilder(name, guid).AddToDB();

        public static readonly FeatureDefinitionSense ProficiencyRogueBlindSense
            = CreateAndAddToDB(ProficiencyRogueBlindSenseName, ProficiencyRogueBlindSensedGuid);
    }
}