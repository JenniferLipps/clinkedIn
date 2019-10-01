using ClinkedIn.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn.Api.DataAccess
{
    public class ServiceRepository
    {
        static List<Service> _services = new List<Service>
        {
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000001"),
                Name = "Unauthorized physical contact",
                Price = 1.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000002"),
                Name = "Using abusive or obscene language",
                Price = 2.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000003"),
                Name = "Malingering, feigning illness",
                Price = 3.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000004"),
                Name = "Use the telephone for abuses other than criminal activity which do not circumvent mail monitoring",
                Price = 4.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000005"),
                Name = "Use the mail to commit a prohibited act",
                Price = 5.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000006"),
                Name = "Circulate a petition",
                Price = 6.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000007"),
                Name = "Participate in gang-related activities",
                Price = 7.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000008"),
                Name = "Possession of anything not authorized for retention or receipt by the inmate, and not issued to him through regular channels",
                Price = 8.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000009"),
                Name = "Conduct a business/investment transaction",
                Price = 9.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000010"),
                Name = "Fraudulent or deceptive completion of a skills test (e.g., cheating on a GED)",
                Price = 10.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000011"),
                Name = "Possession, manufacture, introduction, or loss of a non-hazardous tool, equipment, supplies, or other non-hazardous contraband",
                Price = 11.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000012"),
                Name = "Destroying, altering, or damaging government property, or the property of another person, having a value of $100.00 or less",
                Price = 12.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000013"),
                Name = "Unauthorized contacts with the public",
                Price = 13.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000014"),
                Name = "Possession of gambling paraphernalia",
                Price = 14.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000015"),
                Name = "Preparing or conducting a gambling pool",
                Price = 15.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000016"),
                Name = "Gambling",
                Price = 16.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000016"),
                Name = "Using any equipment or machinery contrary to instructions or posted safety standards",
                Price = 16.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000017"),
                Name = "Using any equipment or machinery without staff authorization",
                Price = 17.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000018"),
                Name = "Being in an unauthorized area without staff authorization",
                Price = 18.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000019"),
                Name = "Counterfeiting, forging, or unauthorized reproduction of any document, article of identification, money, security, or official paper",
                Price = 19.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000020"),
                Name = "Lying or providing a false statement to a staff member",
                Price = 20.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000021"),
                Name = "Misuse of authorized medication",
                Price = 21.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000022"),
                Name = "Indecent exposure",
                Price = 22.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000023"),
                Name = "Use of the telephone for abuses other than illegal activity which circumvent the ability of staff to monitor frequency of telephone use, content of the call, or the number called",
                Price = 23.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000024"),
                Name = "Tattooing or self-mutilation",
                Price = 24.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000025"),
                Name = "Stalking another person through repeated behavior which harasses, alarms, or annoys the person, after having been previously warned to stop such conduct",
                Price = 25.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000026"),
                Name = "Assaulting any person",
                Price = 26.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000027"),
                Name = "Demonstrating, practicing, or using martial arts, boxing (except for use of a punching bag), wrestling, or other forms of physical encounter, or military exercises or drill (except for drill authorized by staff)",
                Price = 27.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000028"),
                Name = "Stealing; theft",
                Price = 28.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000029"),
                Name = "Destroying, altering, or damaging government property, or the property of another person, having a value in excess of $100.00, or destroying, altering, damaging life-safety devices (e.g., fire alarm) regardless of financial value",
                Price = 29.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000030"),
                Name = "Giving money to, or receiving money from, any person for the purpose of introducing contraband or any other illegal or prohibited purpose",
                Price = 30.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000031"),
                Name = "Giving or offering an official or staff member a bribe, or anything of value",
                Price = 31.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000032"),
                Name = "Obtain any officers or staff clothing",
                Price = 32.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000033"),
                Name = "Adulteration of any food or drink",
                Price = 33.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000034"),
                Name = "Possession of any unauthorized locking device, or lock pick, or tampering with or blocking any lock device (includes keys), or destroying, altering, interfering with, improperly using, or damaging any security device, mechanism, or procedure",
                Price = 34.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000035"),
                Name = "Extortion; blackmail; protection; demanding or receiving money or anything of value in return for protection against others, to avoid bodily harm, or under threat of informing",
                Price = 35.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000036"),
                Name = "Threatening another with bodily harm or any other offense",
                Price = 36.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000037"),
                Name = "Fighting with another person",
                Price = 37.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000038"),
                Name = "Use of the telephone for an illegal purpose ",
                Price = 38.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000039"),
                Name = "Use of the mail for an illegal purpose",
                Price = 39.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000040"),
                Name = "Destroying and/or disposing of any item during a search or attempt to search",
                Price = 40.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000041"),
                Name = "Possession (holding) any narcotics, marijuana, drugs, alcohol, intoxicants, or related paraphernalia, not prescribed for the individual by the medical staff",
                Price = 41.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000042"),
                Name = "Introduction or making of any narcotics, marijuana, drugs, alcohol, intoxicants, or related paraphernalia, not prescribed for the individual by the medical staff",
                Price = 42.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000043"),
                Name = "Possession, manufacture, introduction, or loss of a hazardous tool",
                Price = 43.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000044"),
                Name = "Taking hostage(s)",
                Price = 44.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000045"),
                Name = "Encouraging others to riot",
                Price = 45.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000046"),
                Name = "Rioting",
                Price = 46.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000047"),
                Name = "Possession, manufacture, or introduction of a gun, firearm, weapon, sharpened instrument, knife, dangerous chemical, explosive, ammunition, or any instrument used as a weapon",
                Price = 47.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000048"),
                Name = "Setting a fire",
                Price = 48.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000049"),
                Name = "Assaulting any person, or an armed assault on the institution’s secure perimeter",
                Price = 49.00m,
            },
            new Service
            {
                Id = new Guid("20000000 - 0000 - 0000 - 0000 - 000000000015"),
                Name = "Killing",
                Price = 15.00m,
            },
        };
    }
}
