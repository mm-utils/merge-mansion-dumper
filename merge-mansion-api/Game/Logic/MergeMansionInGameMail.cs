using Metaplay.Core.Model;
using GameLogic.Mail;
using System;
using Metaplay.Core.Forms;
using Metaplay.Core.Localization;
using System.Collections.Generic;
using GameLogic;
using GameLogic.Player.Rewards;
using Metaplay.Core;

namespace Game.Logic
{
    [MetaSerializableDerived(10)]
    [MetaReservedMembers(0, 80)]
    [MetaBlockedMembers(new int[] { 13 })]
    public class MergeMansionInGameMail : MergeMansionMailContents, IBroadcastMailMessage
    {
        private static int ShortTopicLimit;
        private static int ShortContentLimit;
        [MetaMember(1, (MetaMemberFlags)0)]
        [MetaValidateRequired]
        public LocalizedString ExcerptTopic { get; set; }

        [MetaMember(2, (MetaMemberFlags)0)]
        [MetaValidateRequired]
        [MetaFormTextArea]
        public LocalizedString ExcerptContent { get; set; }

        [MetaMember(3, (MetaMemberFlags)0)]
        [MetaValidateRequired]
        public LocalizedString FullTopic { get; set; }

        [MetaMember(4, (MetaMemberFlags)0)]
        [MetaValidateRequired]
        [MetaFormTextArea]
        public LocalizedString FullContent { get; set; }

        [MetaMember(5, (MetaMemberFlags)0)]
        public string ExcerptImageFile { get; set; }

        [MetaMember(6, (MetaMemberFlags)0)]
        public string FullImageFile { get; set; }

        [MetaFormFieldContext("AttachmentRewardList", true)]
        [MetaMember(7, (MetaMemberFlags)0)]
        public List<PlayerReward> Attachments { get; set; }

        [MetaMember(8, (MetaMemberFlags)0)]
        [MetaFormNotEditable]
        public long EndDay { get; set; }

        [MetaMember(9, (MetaMemberFlags)0)]
        [MetaFormNotEditable]
        public int BroadcastNo { get; set; }

        [MetaFormFieldCustomValidator(typeof(MergeMansionInGameMail.SocialMediaPlatformValidator))]
        [MetaMember(10, (MetaMemberFlags)0)]
        public List<SocialMediaPlatform> SocialMediaButtonsToShow { get; set; }

        [MetaMember(11, (MetaMemberFlags)0)]
        [MetaFormNotEditable]
        public MergeMansionInGameMailContentType ContentType { get; set; }

        [MetaMember(12, (MetaMemberFlags)0)]
        [MetaFormNotEditable]
        public string ContentExtra { get; set; }
        public override string TitleExcerpt { get; }
        public override string BodyExcerpt { get; }
        public override IEnumerable<PlayerReward> Rewards { get; }
        public override bool RewardsGivenInConsumeMail { get; }
        public int BroadcastId { get; }
        public bool TrackImpressions { get; }

        public MergeMansionInGameMail()
        {
        }

        public MergeMansionInGameMail(MetaGuid guid)
        {
        }

        public MergeMansionInGameMail(string messageTopic, string messageContent, List<PlayerReward> attachments, long endDay, LanguageId language, int broadcastId)
        {
        }

        public MergeMansionInGameMail(string messageTopic, string messageTopicExcerpt, string messageContent, string messageContentExcerpt, List<PlayerReward> attachments, long endDay, LanguageId language)
        {
        }

        public class SocialMediaPlatformValidator : MetaFormValidator<List<SocialMediaPlatform>>
        {
            public SocialMediaPlatformValidator()
            {
            }
        }
    }
}