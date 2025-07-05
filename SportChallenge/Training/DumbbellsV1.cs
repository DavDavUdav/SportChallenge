using SportChallenge.DataBase;
using SportChallenge.Extensions;
using SportChallenge.Models.Sport;
using SportChallenge.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;

namespace SportChallenge.Training
{
    internal class DumbbellsV1 : SportsExerciseBase
    {
        protected override SportType SportType => SportType.DumbbellsV1;

        public DumbbellsV1(UnitOfWork unitOfWork, NotificationService notificationController) : base(unitOfWork, notificationController)
        {
        }

        public override bool HaveFreeTraining()
            => true;

        public override InlineKeyboardMarkup GetMenuButtons()
            => new InlineKeyboardMarkup(new[]
            {
            new[]
            {
                InlineKeyboardButton.WithCallbackData("Свободный", ParserButtons.SerializeSportMenuButton(SportType, Constants.Free)),
            }
            });
    }
}
