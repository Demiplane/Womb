using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Womb.Feats
{
    public class HardCodedFeatResolver : IFeatResolver
    {
        private static readonly IEnumerable<Feat> Feats = new HashSet<Feat>()
        {
            new Feat() { Id = Guid.Parse("{7A651B8C-0AC3-4300-902F-C52DB69A5023}"), Name = "Alert"},
            new Feat() { Id = Guid.Parse("{A1F163B4-9AAF-4885-AF1B-67A33C87A94C}"), Name = "Athlete"},
            new Feat() { Id = Guid.Parse("{29C491C0-7BE6-4131-A21D-EEC21809F545}"), Name = "Actor"},
            new Feat() { Id = Guid.Parse("{1B626BFC-2F3B-436F-8691-CA836533830C}"), Name = "Charger"},
            new Feat() { Id = Guid.Parse("{890EA8D1-EAD8-48FA-B071-0E689C7A1B44}"), Name = "Crossbow Expert"},
            new Feat() { Id = Guid.Parse("{FB4A6279-6A5F-48AC-A5F6-0F318BC7F6ED}"), Name = "Defensive Dueslist"},
            new Feat() { Id = Guid.Parse("{F7E322EA-EF78-41C7-9BB7-52CE8FFDEF16}"), Name = "Dual Wielder"},
            new Feat() { Id = Guid.Parse("{BBEA5B5B-0E04-4F8E-87A0-E2C330D7C027}"), Name = "Dungeon Delver"},
            new Feat() { Id = Guid.Parse("{2E0F6DBF-17D3-4B46-8199-E3A4A6DC482E}"), Name = "Durable"},
            new Feat() { Id = Guid.Parse("{36D11373-2789-4BDA-B274-ADAB47D30A00}"), Name = "Elemental Adept"},
            new Feat() { Id = Guid.Parse("{00CF97FB-2D8E-40B4-A829-0931F6B6A0FE}"), Name = "Grappler"},
            new Feat() { Id = Guid.Parse("{91542329-4277-4445-BD35-A1891F7E17A7}"), Name = "Great Weapon Master"},
            new Feat() { Id = Guid.Parse("{F73DDC89-C0CA-4230-B9B7-9D00C010B7DF}"), Name = "Gunslinger"},
            new Feat() { Id = Guid.Parse("{774C53BE-5BF3-429D-BC83-A6061E40BE28}"), Name = "Healer"},
            new Feat() { Id = Guid.Parse("{8AE5ACF1-C795-4F3F-958D-7E973DF758CD}"), Name = "Heavily Armored"},
            new Feat() { Id = Guid.Parse("{AC279180-E8C8-4CB3-9A6B-CB4A91047C59}"), Name = "Heavy Armor Master"},
            new Feat() { Id = Guid.Parse("{4E2B828F-5F53-4E19-9CD6-AB995FA986E0}"), Name = "Inspiring Leader"},
            new Feat() { Id = Guid.Parse("{83AEF326-5257-4BDA-963B-09AC4BEA74B0}"), Name = "Keen Leader"},
            new Feat() { Id = Guid.Parse("{EDEA63F1-0787-4ED9-90BF-9E50EE10776E}"), Name = "Lightly Armored"},
            new Feat() { Id = Guid.Parse("{F804BB40-7BAD-4D05-93BC-D50F6F3B5249}"), Name = "Linguist"},
            new Feat() { Id = Guid.Parse("{1AA38282-D29D-4E06-B843-48C7B281761F}"), Name = "Lucky"},
            new Feat() { Id = Guid.Parse("{66918807-F5DF-46B1-BC8F-73FDE53EB7D1}"), Name = "Mage Slayer"},
            new Feat() { Id = Guid.Parse("{FAAE715A-321F-45D8-9C11-079EE315DE50}"), Name = "Magic Initiate"},
            new Feat() { Id = Guid.Parse("{1D2BBB9D-6D60-4F14-A031-03B0A0734AA7}"), Name = "Martial Adept"},
            new Feat() { Id = Guid.Parse("{BCC29FA5-8CE1-4DAF-8E22-F0D279F77017}"), Name = "Medium Armor Master"},
            new Feat() { Id = Guid.Parse("{D35241BA-F87C-4CC2-B080-C83664F13393}"), Name = "Mobile"},
            new Feat() { Id = Guid.Parse("{BBF4A4EA-6E65-47EF-8EFB-F3DF0A1EF017}"), Name = "Moderatley Armored"},
            new Feat() { Id = Guid.Parse("{1CA2EF36-65B5-4CDF-BDFF-977A0519CE7B}"), Name = "Mobile"},
            new Feat() { Id = Guid.Parse("{084749E2-AB2F-421E-8B8A-8BE3CDF2F101}"), Name = "Moderately Armored"},
            new Feat() { Id = Guid.Parse("{F0875756-9FED-49DE-BAC7-E8BFD4E295E1}"), Name = "Mounted Combatant"},
            new Feat() { Id = Guid.Parse("{990B0E82-F51F-4D94-ABCE-AA205B3E1B51}"), Name = "Observant"},
            new Feat() { Id = Guid.Parse("{2B3482AF-F5DD-4F0B-B161-A05922E74E5A}"), Name = "Polearm Master"},
            new Feat() { Id = Guid.Parse("{7EE2BC28-7BE8-4299-8646-BA3BFA6FCFAC}"), Name = "Resilient"},
            new Feat() { Id = Guid.Parse("{0AEDFD6A-862D-462D-A552-E65388007FDD}"), Name = "Ritual Caster"},
            new Feat() { Id = Guid.Parse("{B3FC51BF-B7B9-4A2C-8A77-5F911F2C3E38}"), Name = "Savage Attacker"},
            new Feat() { Id = Guid.Parse("{35CD4CC2-01DC-4115-A736-99378099276A}"), Name = "Sentinal"},
            new Feat() { Id = Guid.Parse("{025A8484-AA0E-4C66-8269-82C61BDF2D76}"), Name = "Sharpshooter"},
            new Feat() { Id = Guid.Parse("{91EB56B4-24CC-4AF8-9A46-47948025B7A0}"), Name = "Shield Master"},
            new Feat() { Id = Guid.Parse("{963F4D60-B987-414D-B46E-6C67F1B8295B}"), Name = "Skilled"},
            new Feat() { Id = Guid.Parse("{0851DD0F-3E74-4325-A247-D556ABAD36B1}"), Name = "Skulker"},
            new Feat() { Id = Guid.Parse("{269BCBE8-689D-44FA-8DD8-3B7D404E1D63}"), Name = "Spell Sniper"},
            new Feat() { Id = Guid.Parse("{E7FF9221-2B3A-4F4C-812F-3A0EA360ABCF}"), Name = "Tavern Brawler"},
            new Feat() { Id = Guid.Parse("{411EAF7F-934F-4123-8788-980497915845}"), Name = "Tough"},
            new Feat() { Id = Guid.Parse("{B2642CC6-7A18-44B9-92B4-247031AD0F85}"), Name = "War Caster"},
            new Feat() { Id = Guid.Parse("{A19BD245-5951-411E-B953-DF9746FB0197}"), Name = "Weapon Master"},
        };

        public IEnumerable<Feat> ResolveFeats() => Feats;
    }
}
