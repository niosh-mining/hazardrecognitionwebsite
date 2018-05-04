using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HazardRecognition.Models
{
    public static class HazardChallenges
    {
        static HazardChallengeViewModel[] challenges
        {
            get
            {
                return new HazardChallengeViewModel[]{
                //1
                    new HazardChallengeViewModel(1, "shop_1_Hazard_Image", "shop_1_Hazard_thumbnail", 4)
                    {                        
                        Hazards = new List<Hazard>()
                        {
                            new Hazard()
                            {
                                HotspotPoints = new List<PointModel>()
                                {
                                    new PointModel(-67.005714, -8.314435),
                                    new PointModel(-59.889031, -8.487517),
                                    new PointModel(-52.666126, -0.143273),
                                    new PointModel(-51.165432, 16.584558),
                                    new PointModel(-64.479719, 16.857304)
                                },
                                Title= "Improper Use of a Ladder",
                                Text=@"<ul><li>Only use ladders in the way they were designed. To be safe, place ladders on stable and level surfaces. When climbing up or down, face the ladder, stay near the center, and maintain three points of contact. To improve your ladder safety, use the NIOSH <a href='https://www.cdc.gov/niosh/topics/falls/mobileapp.html' target='_blank'>Ladder Safety App</a> and read the <a href='https://www.cdc.gov/niosh/mining/works/coversheet1992.html' target='_blank'>Steps to Ladder Safety</a> infographic.</li><li><a href='https://www.cdc.gov/niosh/mining/works/coversheet1988.html' target='_blank'>Slips and falls</a> result in thousands of injuries to mineworkers each year. One way these injuries occur is through the improper use of ladders.</li></ul>",
                                ImageURL = "ladder.jpg"
                            },
                            new Hazard()
                            {
                                HotspotPoints = new List<PointModel>()
                                {
                                    new PointModel(-31.727376, 5.109831),
                                    new PointModel(-24.197922, 5.283074),
                                    new PointModel(-24.018686, 15.582851),
                                    new PointModel(-31.35341, 15.072808)
                                },
                                Title= "Obstructed Fire Extinguisher",
                                Text=@"<ul><li><a href='https://www.osha.gov/SLTC/etools/evacuation/portable.html' target='_blank'>Fire extinguishers</a> should be (1) strategically located, (2) readily accessible, (3) plainly marked, and (4) ready to use [<a href='http://www.ecfr.gov/cgi-bin/text-idx?SID=766bb63bfaef38dd7a727c8882ba0f7c&mc=true&node=pt30.1.56&rgn=div5%20-%20se30.1.56_14200#se30.1.56_14200' target='_blank'>30 CFR 56.4200 (b)</a>].</li><li>Workplace fires and explosions kill hundreds and injure thousands of workers each year.</li></ul>",
                                ImageURL = "extinguisher.jpg"
                            },
                            new Hazard()
                            {
                                HotspotPoints = new List<PointModel>()
                                {
                                    new PointModel(-14.120576,1.387104),
                                    new PointModel(-6.71691, 1.420491),
                                    new PointModel(-6.571874, 13.692366),
                                    new PointModel(-14.056489, 13.319386)
                                },
                                Title= "Unsecured Gas Cylinders",
                                Text=@"<ul><li>Secure compressed and liquid gas cylinders in a safe manner [<a href='http://www.ecfr.gov/cgi-bin/text-idx?SID=885b3c9b1c49e2233af59036dbad48db&mc=true&node=pt30.1.56&rgn=div5#se30.1.56_116005' target='_blank'>30 CFR 56.16005</a>]. Keep cylinders in an upright position, and replace regulators with valve protection caps when the cylinders are not in use.</li><li>Pressurized gas cylinders may fall over if left unsecured. A fall could damage the cylinder or the cylinder’s valve, resulting in a gas leak.</li></ul>",
                                ImageURL = "cylinders.jpg"
                            },
                            new Hazard()
                            {
                                HotspotPoints = new List<PointModel>()
                                {
                                    new PointModel(11.4078, 1.353474),
                                    new PointModel(1.248882, 1.648356),
                                    new PointModel(1.515813, 8.599628),
                                    new PointModel(8.102657, 8.349221),
                                    new PointModel(11.616719, 5.185515)
                                },
                                Title= "Unsecured Tires",
                                Text=@"<ul><li>Good housekeeping is critical for mineworker safety. Per MSHA standards on housekeeping, your workplaces, passageways, storerooms, and service rooms must be kept clean and orderly [<a href='http://www.ecfr.gov/cgi-bin/text-idx?SID=e4c4e5c6683f0164e9a813db8b9347b0&mc=true&node=pt30.1.56&rgn=div5#se30.1.56_120003' target='_blank'>30 CFR 56.20003</a>].</li><li>Leaving parts, materials, or tools unattended or unsecured may contribute to handling materials or slip, trip, and fall accidents. These accident classes combined account for nearly <a href='https://www.cdc.gov/niosh/mining/UserFiles/statistics/14g07ua-ssg.svg' target='_blank'>50 percent of lost-time injuries in the stone and sand & gravel industry.</a></li></ul>",
                                ImageURL = "tires.jpg"
                            },
                            new Hazard()
                            {
                                HotspotPoints = new List<PointModel>()
                                {
                                    new PointModel(29.850892, 6.897799),
                                    new PointModel(38.731635, 6.988861),
                                    new PointModel(38.731635, 10.840002),
                                    new PointModel(29.917244, 10.565938)
                                },
                                Title= "Uncovered Floor Drain (Tripping Hazard)",
                                Text=@"<ul><li>Uncovered floor drains may lead to slips, trips, or falls.  Use the NIOSH mobile app <a href='https://www.cdc.gov/niosh/mining/works/coversheet1906.html' target='_blank'>ErgoMine</a> for suggestions on ways to prevent slips, trips, and falls of mine maintenance workers.</li><li><a href='https://www.cdc.gov/niosh/mining/UserFiles/statistics/14g07ua-mnREV.svg' target='_blank'>19.5%</a> of all accidents that happened in the metal and nonmetal industry from 2010 to 2014 were slip, trips, or falls.</li></ul>",
                                ImageURL = "stf.jpg"
                            },
                            new Hazard()
                            {
                                HotspotPoints = new List<PointModel>()
                                {
                                    new PointModel(85.927641, -5.490215),
                                    new PointModel(98.343694, -5.518222),
                                    new PointModel(98.978232, 12.817758),
                                    new PointModel(85.927641, 12.663387)
                                },
                                Title= "Not Wearing a Seatbelt",
                                Text=@"<ul><li>Mineworkers should <a href='https://arlweb.msha.gov/streaming/wvx/stayinthecab.wvx' target='_blank'>always wear a seat belt and stay in the cab</a> while operating a vehicle.</li><li>Each year, at least <a href='https://www.msha.gov/news-media/announcements/2016/09/29/safety-alert-seat-belt-use-mobile-equipment' target='_blank'>3 mineworkers are killed</a> while not wearing a seat belt when operating mobile equipment.</li></ul>",
                                ImageURL = "seatbelt.jpg"
                            },
                            new Hazard()
                            {
                                HotspotPoints = new List<PointModel>()
                                {
                                    new PointModel(167.109941, 1.562477),
                                    new PointModel(178.806531, 1.716601),
                                    new PointModel(178.657931, 16.419423),
                                    new PointModel(166.74639, 16.293356)
                                },
                                Title= "Not Wearing Proper Eye Protection",
                                Text=@"<ul><li>Prevent eye injuries by wearing protective eyewear before entering the mine or anywhere hazards may be present. NIOSH has developed a <a href='https://www.cdc.gov/niosh/topics/eye/toolbox-eye.html' target='_blank'>toolbox talk to promote the discussion of eye safety</a> issues at your work site.</li><li>Each year, about 2,000 U.S. workers receive medical treatment because of eye injuries sustained at work. To learn more, see <a href='https://nei.nih.gov/sites/default/files/health-pdfs/HVMPreventingInjuries_Tagged.pdf' target='_blank'>Eye Safety at Work is Everyone's Business.</a></li></ul>",
                                ImageURL = "saw.jpg"
                            },
                        }
                    },
                    //2
                    new HazardChallengeViewModel(2, "Plant_5_Hazard_Info", "Plant_5_Hazard_thumbnail", 4)
                    {
                        Hazards = new List<Hazard>()
                        {
                             new Hazard()
                            {
                                 HotspotPoints = new List<PointModel>()
                                 {
                                     new PointModel(-93.955021, -8.704277),
                                     new PointModel(-63.091575, -7.88661),
                                     new PointModel(-63.091575, -1.765811),
                                     new PointModel(-94.027109, -1.826952)
                                 },
                                Title= "Missing Berm at Dump Site",
                                Text=@"<ul><li>Berms must be maintained on the outer edge of haul roads where there is a danger of equipment overturning or endangering the operator. [<a href='http://www.ecfr.gov/cgi-bin/text-idx?SID=e4c4e5c6683f0164e9a813db8b9347b0&mc=true&node=pt30.1.56&rgn=div5#se30.1.56_19300' target='_blank'>30 CFR 56.9300</a>].</li><li>A missing berm at the dumpsite may contribute to a <a href='https://arlweb.msha.gov/fatals/metal/2016/final-reports/final-m16-02.asp' target='_blank'>fatal accident</a> involving a haul truck backing over the dump edge.</li></ul>",
                                ImageURL = "missing_berm1.jpg"
                            },
                             new Hazard()
                            {
                                 HotspotPoints = new List<PointModel>()
                                 {
                                     new PointModel(-14.736374, 0.426516),
                                     new PointModel(-3.273318, 0.559033),
                                     new PointModel(-3.201834, 4.600922),
                                     new PointModel(-14.736374, 4.574493)
                                 },
                                Title= "Gap in Berm",
                                Text=@"<ul><li>Berms must be maintained on the outer edge of haul roads where there is a danger of equipment overturning or endangering the operator [<a href='http://www.ecfr.gov/cgi-bin/text-idx?SID=e4c4e5c6683f0164e9a813db8b9347b0&mc=true&node=pt30.1.56&rgn=div5#se30.1.56_19300' target='_blank'>30 CFR 56.9300</a>].</li><li>Properly maintained berms are critical for safe mobile equipment operation because they give operators a visual indication of the edge of the road and provide a sensation of contact if the operator drives too close.</li></ul>",
                                ImageURL = "missing_berm2.jpg"
                            },
                             new Hazard()
                            {
                                 HotspotPoints = new List<PointModel>()
                                 {
                                     new PointModel(51.827259, -4.841728),
                                     new PointModel(86.226368, -4.366293),
                                     new PointModel(86.162468, 5.122918),
                                     new PointModel(51.887476, 5.044358)
                                 },
                                Title= "Driving too Close to Heavy Equipment",
                                Text=@"<ul><li>Mineworkers must follow rules governing the speed, right-of-way, direction of movement, and the use of headlights to ensure good visibility [<a href='http://www.ecfr.gov/cgi-bin/text-idx?SID=e4c4e5c6683f0164e9a813db8b9347b0&mc=true&node=pt30.1.56&rgn=div5#se30.1.56_19100' target='_blank'>30 CFR 56.9100</a>]. When in doubt, yield to heavy equipment and maintain a safe distance. Make visual and/or radio contact with the operator, and wait until the operator gives you a signal or takes the right-of-way.</li><li>Heavy equipment vehicles such as loaders, excavators, and haul trucks have obstructed visibility, blind spots, and other characteristics that pose significant hazards to light vehicles and foot traffic.</li></ul>",
                                ImageURL = "powered_haulage.jpg"
                            },
                              new Hazard()
                            {
                                 HotspotPoints = new List<PointModel>()
                                 {
                                     new PointModel(120.550093, -4.193362),
                                     new PointModel(127.328369, -4.241603),
                                     new PointModel(126.17687, 6.546217),
                                     new PointModel(120.073279, 6.534836)
                                 },
                                Title= "Missing Handrail",
                                Text=@"<ul><li>Per MSHA standards, elevated walkways and stairways must be of substantial construction, provided with handrails, and maintained in good condition [<a href='http://www.ecfr.gov/cgi-bin/text-idx?SID=947b7b95f2fc8e8e92ce991866eea624&mc=true&node=se30.1.56_111002&rgn=div8' target='_blank'>30 CFR 56.11002</a>].</li><li>Handrails play an important role in keeping mineworkers safe on walkways and stairways.</li></ul>",
                                ImageURL = "missing_handrail.jpg"
                            },
                            new Hazard()
                            {
                                 HotspotPoints = new List<PointModel>()
                                 {
                                     new PointModel(128.023109, -2.435968),
                                     new PointModel(133.158529, -1.068622),
                                     new PointModel(133.232851, 7.224305),
                                     new PointModel(126.951304, 6.847639)
                                 },
                                Title= "Improperly Stored Equipment",
                                Text=@"<ul><li>Workplaces, passageways, storerooms, and service rooms must be kept clean and orderly [<a href='http://www.ecfr.gov/cgi-bin/text-idx?SID=e4c4e5c6683f0164e9a813db8b9347b0&mc=true&node=pt30.1.56&rgn=div5#se30.1.56_120003' target='_blank'>30 CFR 56.20003</a>].</li><li>Poor housekeeping can lead to injuries because mineworkers can trip and fall over clutter and unattended spills.</li></ul>",
                                ImageURL = "trip.jpg"
                            },
                            new Hazard()
                            {
                                 HotspotPoints = new List<PointModel>()
                                 {
                                     new PointModel(129.087321, -11.722914),
                                     new PointModel(134.822716, -11.728654),
                                     new PointModel(134.747569, -6.070241),
                                     new PointModel(129.52002, -6.281591)
                                 },
                                Title= "Unsafe Working at Height – Improvised Step",
                                Text=@"<ul><li>Mineworkers must maintain safe access to all working places and identify where fall protection is needed. Per MSHA standards, workers must wear safety belts and safety lines where there is danger of falling [<a href='http://www.ecfr.gov/cgi-bin/text-idx?SID=9a1183212bcf0d02158d7690253eb805&mc=true&node=se30.1.56_115005&rgn=div8' target='_blank'>30 CFR 56.15005</a>].</li><li><a href='https://www.cdc.gov/niosh/mining/works/coversheet1988.html' target='_blank'>Slips and falls</a> are some of the most common and severe accidents occurring in the mining industry. See the <a href='https://www.cdc.gov/niosh/mining/works/coversheet1993.html' target='_blank'>Falls Can Kill!</a> infographic for more information.</li></ul>",
                                ImageURL = "step.jpg"
                            },
                            new Hazard()
                            {
                                 HotspotPoints = new List<PointModel>()
                                 {
                                     new PointModel(153.715697, -11.329301),
                                     new PointModel(161.572145, -10.77059),
                                     new PointModel(161.278405, -5.787231),
                                     new PointModel(153.773662, -6.459656)
                                 },
                                Title= "Missing Midrail",
                                Text=@"<ul><li>Per MSHA standards, elevated walkways and stairways must be of substantial construction, provided with handrails, and maintained in good condition [<a href='http://www.ecfr.gov/cgi-bin/text-idx?SID=947b7b95f2fc8e8e92ce991866eea624&mc=true&node=se30.1.56_111002&rgn=div8' target='_blank'>30 CFR 56.11002</a>].</li><li>A missing handrail can contribute to a serious slip, trip, or fall incident.</li></ul>",
                                ImageURL = "guardrail.jpg"
                            }                  
                        }
                    },
                    //3
                    new HazardChallengeViewModel(3, "Pit_3_Hazard_Image", "Pit_3_Hazard_thumbnail", 4)
                    {
                        Hazards = new List<Hazard>()
                        {
                            new Hazard()
                            {
                                 HotspotPoints = new List<PointModel>()
                                 {
                                     new PointModel(-111.82674, -4.736302),
                                     new PointModel(-98.883178, -4.778197),
                                     new PointModel(-98.747525, 1.754012),
                                     new PointModel(-111.79299, 1.636699)
                                 },
                                Title= "Falling Rock",
                                Text=@"<ul><li>This haul truck is being loaded while positioned parallel to the highwall with the operator’s cab facing the highwall. This loading position puts the haul truck operator in danger of <a target='_blank' href='https://arlweb.msha.gov/fatals/2004/ftl04c25.asp'>falling rock</a>.</li><li>Never position machines equipped with a side operator’s cab with the cab between the machine and the highwall. When this is not possible, thoroughly inspect the highwall and have a spotter monitor the machine while it is in this position.</li></ul>",
                                ImageURL = "highwall.jpg"
                            },
                            new Hazard()
                            {
                                 HotspotPoints = new List<PointModel>()
                                 {
                                     new PointModel(114.396512, -0.918772),
                                     new PointModel(120.264129, -0.888098),
                                     new PointModel(120.264023, 1.617115),
                                     new PointModel(114.413063, 1.597034)
                                 },
                                Title= "Rocks in the Roadway",
                                Text=@"<ul><li>To avoid these types of injuries, the NIOSH <a href='https://www.cdc.gov/niosh/mining/works/coversheet1906.html' target='_blank'>ErgoMine</a> audit tool recommends communicating road conditions with the grader operator to improve road surface by eliminating ruts and potholes.</li><li>NIOSH reports that a significant number of <a href='https://www.cdc.gov/niosh/mining/userfiles/works/pdfs/aaoit.pdf' target='_blank'>haul truck driver injures</a> are due to the jolting and jarring to the operator. These injuries are most likely to happen because of rough or rock-covered haul roads. </li></ul>",
                                ImageURL = "rocks.jpg"
                            }
                        }
                    },
                    //4
                    new HazardChallengeViewModel(4, "Roadway_2_Hazard_Image", "Roadway_2_Hazard_thumbnail", 4)
                    {
                        Hazards = new List<Hazard>()
                        {
                            new Hazard()
                            {
                                 HotspotPoints = new List<PointModel>()
                                 {
                                     new PointModel(-48.023851, -1.912817),
                                     new PointModel(-37.042377, -1.862897),
                                     new PointModel(-36.86826, 6.423829),
                                     new PointModel(-47.956346, 6.525919)
                                 },
                                Title= "Working on Electrical Conductors in Unsafe Conditions",
                                Text=@"<ul><li>To avoid electrical injuries and fatalities, mineworkers must be aware of hazards such as standing water. Always use proper tools, grounding mats, and personal protective equipment when operating disconnect switches to avoid injury from arcing or electrical contact.</li><li>Mineworkers are significantly more likely to experience an electrical injury or fatality compared to workers in other U.S. industries. NIOSH is continually conducting research to address issues related to <a href='https://www.cdc.gov/niosh/mining/topics/ElectricalAccidents.html' target='_blank'>electrical safety</a>.</li></ul>",
                                ImageURL = "shock.jpg"
                            },
                            new Hazard()
                            {
                                 HotspotPoints = new List<PointModel>()
                                 {
                                     new PointModel(-35.242646, -12.282486),
                                     new PointModel(-26.726276, -12.239063),
                                     new PointModel(-26.760588, 4.466232),
                                     new PointModel(-35.242646, 4.470574)
                                 },
                                Title= "Overhead Power Lines with Truck Bed Raised",
                                Text=@"<ul><li>Mineworkers and equipment operators must always be on the lookout for overhead powerlines. Never allow equipment to get near or touch high- or low-voltage powerlines. Mobile equipment such as cranes and trucks must be at least 10 feet away from energized powerlines [<a href='https://www.ecfr.gov/cgi-bin/text-idx?SID=2c2518c5c3c9a3c76c63dada96f3b241&mc=true&node=se30.1.56_112071&rgn=div8' target='_blank'>30 CFR 56.12071</a>].</li><li><a href='https://arlweb.msha.gov/District/Dist_08/hilinecontact.htm' target='_blank'>Contacting a power line</a> with mobile equipment such as trucks, drill rigs, cranes, etc. has resulted in serious injury or death.</li></ul>",
                                ImageURL = "truck.jpg"
                            },
                            new Hazard()
                            {
                                 HotspotPoints = new List<PointModel>()
                                 {
                                     new PointModel(13.326416, -0.513056),
                                     new PointModel(19.83722, -0.554132),
                                     new PointModel(19.973564, 5.815253),
                                     new PointModel(13.390789, 5.761986)
                                 },
                                Title= "Missing Step on Stairway",
                                Text=@"<ul><li>Per MSHA standards, elevated walkways and stairways must be of substantial construction, provided with handrails, and maintained in good condition [<a href='http://www.ecfr.gov/cgi-bin/text-idx?SID=947b7b95f2fc8e8e92ce991866eea624&mc=true&node=se30.1.56_111002&rgn=div8' target='_blank'>30 CFR 56.11002</a>].</li><li>A missing step on the stairway may lead to the slip, trip, or fall of a worker in this area. Slips, trips, and falls account for a significant portion of injuries reported at mine sites each year. To learn more, see <a href='https://www.cdc.gov/niosh/mining/works/coversheet1988.html' target='_blank'>Causes of Fall Fatalities at Surface Mines</a>.</li></ul>",
                                ImageURL = "step.jpg"
                            }
                        }
                    },
                };
            }
        }

        public static HazardChallengeViewModel GetChallenge(int challengeId)
        {
            return challenges[challengeId - 1];
        }

        public static int GetNumberOfChallenges()
        {
            return challenges.Length;
        }
    }
}