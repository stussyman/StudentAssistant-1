﻿namespace StudentAssistant.Backend.Models.ConfigurationModels
{
    public class ParityOfTheWeekConfigurationModel
    {
        public int StartLearningYear { get; set; }

        public static ParityOfTheWeekConfigurationModel GetConfigurationValues()
        {
            var result = new ParityOfTheWeekConfigurationModel
            {
                StartLearningYear = 2016
            };

            return result;
        }
    }
}