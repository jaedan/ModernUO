using System.Collections.Generic;
using Server.Items;

namespace Server.Mobiles
{
    public class Farmer : BaseVendor
    {
        private readonly List<SBInfo> m_SBInfos = new List<SBInfo>();

        [Constructible]
        public Farmer() : base("the farmer")
        {
            SetSkill(SkillName.Lumberjacking, 36.0, 68.0);
            SetSkill(SkillName.TasteID, 36.0, 68.0);
            SetSkill(SkillName.Cooking, 36.0, 68.0);
        }

        public Farmer(Serial serial) : base(serial)
        {
        }

        protected override List<SBInfo> SBInfos => m_SBInfos;

        public override VendorShoeType ShoeType => VendorShoeType.ThighBoots;

        public override void InitSBInfo()
        {
            m_SBInfos.Add(new SBFarmer());
        }

        public override int GetShoeHue() => 0;

        public override void InitOutfit()
        {
            base.InitOutfit();

            AddItem(new WideBrimHat(Utility.RandomNeutralHue()));
        }

        public override void Serialize(IGenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0); // version
        }

        public override void Deserialize(IGenericReader reader)
        {
            base.Deserialize(reader);

            var version = reader.ReadInt();
        }
    }
}
