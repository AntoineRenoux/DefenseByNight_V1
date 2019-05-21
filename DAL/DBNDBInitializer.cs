using DAL.Models.Ref;
using System.Collections.Generic;
using System.Data.Entity;

namespace DAL
{
    public class DBNDBInitializer : DropCreateDatabaseIfModelChanges<DBNContext>
    {
        protected override void Seed(DBNContext context)
        {
            //1036 : Français

            LabelInitializer.Initializer(context);
            ErrorMessageInitializer.Initializer(context);

            #region Focus
            var focus = new List<Focus>
            {
              /*0*/ new Focus{FocusKey = "PHYSICAL_STRENGTH", FocusName = "PHYSICAL_STRENGTH_NAME", Description = "PHYSICAL_STRENGTH_DESCRIPTION" },
              /*1*/ new Focus{FocusKey = "PHYSICAL_DEXTERITY", FocusName = "PHYSICAL_DEXTERITY_NAME", Description = "PHYSICAL_DEXTERITY_DESCRIPTION" },
              /*2*/ new Focus{FocusKey = "PHYSICAL_STAMINA", FocusName = "PHYSICAL_STAMINA_NAME", Description = "PHYSICAL_STAMINA_DESCRIPTION" },
              /*3*/ new Focus{FocusKey = "SOCIAL_CHARISMA", FocusName = "SOCIAL_CHARISMA_NAME", Description = "SOCIAL_CHARISMA_DESCRIPTION" },
              /*4*/ new Focus{FocusKey = "SOCIAL_MANIPULATION", FocusName = "SOCIAL_MANIPULATION_NAME", Description = "SOCIAL_MANIPULATION_DESCRIPTION" },
              /*5*/ new Focus{FocusKey = "SOCIAL_APPEARANCE", FocusName = "SOCIAL_APPEARANCE_NAME", Description = "SOCIAL_APPEARANCE_DESCRIPTION" },
              /*6*/ new Focus{FocusKey = "MENTAL_PERCEPTION", FocusName = "MENTAL_PERCEPTION_NAME", Description = "MENTAL_PERCEPTION_DESCRIPTION" },
              /*7*/ new Focus{FocusKey = "MENTAL_INTELLIGENCE", FocusName = "MENTAL_INTELLIGENCE_NAME", Description = "MENTAL_INTELLIGENCE_DESCRIPTION" },
              /*8*/ new Focus{FocusKey = "MENTAL_WITZ", FocusName = "MENTAL_WITZ_NAME", Description = "MENTAL_WITZ_DESCRIPTION" },
            };

            focus.ForEach(f =>
            {
                context.Focus.Add(f);
            });

            context.SaveChanges();

            #region Traduction
            var focusTraductions = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "PHYSICAL_STRENGTH_NAME", Text = "Force"},
                new Traduction{LCID = 1036, Key = "PHYSICAL_DEXTERITY_NAME", Text = "Dextérité"},
                new Traduction{LCID = 1036, Key = "PHYSICAL_STAMINA_NAME", Text = "Endurance"},

                new Traduction{LCID = 1036, Key = "PHYSICAL_STRENGTH_DESCRIPTION", Text = "Un personnage focalisé sur la Force est costaud et musclé. Une fois par combat, de tels personnages peuvent utiliser gratuitement une manœuvre de combat basée sur la Force (Désarmer, Agripper, Assommer ou Percer le Cœur)."},
                new Traduction{LCID = 1036, Key = "PHYSICAL_DEXTERITY_DESCRIPTION", Text = "Un personnage focalisé sur la Dextérité est rapide et agile. Une fois par combat, de tels personnages peuvent utiliser gratuitement une manœuvre de combat basée sur la Dextérité (Accélération, Désarmer, Combat à l’Aveugle ou Dégainage rapide)."},
                new Traduction{LCID = 1036, Key = "PHYSICAL_STAMINA_DESCRIPTION", Text = "Un personnage focalisé sur l’Endurance est coriace et robuste. De tels personnages ne subissent pas les pénalités de blessure. De plus, ils ne peuvent être ni assommés ni mis à terre par une manœuvre de combat à moins que l’attaquant ait un attribut Physique supérieur à celui de votre personnage."},

                new Traduction{LCID = 1036, Key = "SOCIAL_CHARISMA_NAME", Text = "Charisme"},
                new Traduction{LCID = 1036, Key = "SOCIAL_MANIPULATION_NAME", Text = "Manipulation"},
                new Traduction{LCID = 1036, Key = "SOCIAL_APPEARANCE_NAME", Text = "Apparence"},

                new Traduction{LCID = 1036, Key = "SOCIAL_CHARISMA_DESCRIPTION", Text = "Quand vous faites un challenge non basé sur un pouvoir en lien avec le focus Social de votre personnage, le conteur peut décider de vous donner un bonus de +3 pour ce challenge. Parallèlement, quand votre personnage tente une action d’une durée significative, non basée sur un pouvoir et en lien avec son focus, comme par exemple flagorner tous les avocats de la ville, votre conteur peut diviser le temps de réalisation par deux."},
                new Traduction{LCID = 1036, Key = "SOCIAL_MANIPULATION_DESCRIPTION", Text = "Quand vous faites un challenge non basé sur un pouvoir en lien avec le focus Social de votre personnage, le conteur peut décider de vous donner un bonus de +3 pour ce challenge. Parallèlement, quand votre personnage tente une action d’une durée significative, non basée sur un pouvoir et en lien avec son focus, comme par exemple flagorner tous les avocats de la ville, votre conteur peut diviser le temps de réalisation par deux."},
                new Traduction{LCID = 1036, Key = "SOCIAL_APPEARANCE_DESCRIPTION", Text = "Quand vous faites un challenge non basé sur un pouvoir en lien avec le focus Social de votre personnage, le conteur peut décider de vous donner un bonus de +3 pour ce challenge. Parallèlement, quand votre personnage tente une action d’une durée significative, non basée sur un pouvoir et en lien avec son focus, comme par exemple flagorner tous les avocats de la ville, votre conteur peut diviser le temps de réalisation par deux."},

                new Traduction{LCID = 1036, Key = "MENTAL_PERCEPTION_NAME", Text = "Perception"},
                new Traduction{LCID = 1036, Key = "MENTAL_INTELLIGENCE_NAME", Text = "Intelligence"},
                new Traduction{LCID = 1036, Key = "MENTAL_WITZ_NAME", Text = "Astuce"},

                new Traduction{LCID = 1036, Key = "MENTAL_PERCEPTION_DESCRIPTION", Text = "Quand vous faites un challenge non basé sur un pouvoir en lien avec le focus Mental de votre personnage, le conteur peut décider de vous donner un bonus de +3 pour ce challenge. Alternativement, quand votre personnage tente une action d’une durée significative, non basée sur un pouvoir et en lien avec son focus, comme par exemple traduire un texte ancien en français, votre conteur peut diviser le temps de réalisation par deux."},
                new Traduction{LCID = 1036, Key = "MENTAL_INTELLIGENCE_DESCRIPTION", Text = "Quand vous faites un challenge non basé sur un pouvoir en lien avec le focus Mental de votre personnage, le conteur peut décider de vous donner un bonus de +3 pour ce challenge. Alternativement, quand votre personnage tente une action d’une durée significative, non basée sur un pouvoir et en lien avec son focus, comme par exemple traduire un texte ancien en français, votre conteur peut diviser le temps de réalisation par deux."},
                new Traduction{LCID = 1036, Key = "MENTAL_WITZ_DESCRIPTION", Text = "Quand vous faites un challenge non basé sur un pouvoir en lien avec le focus Mental de votre personnage, le conteur peut décider de vous donner un bonus de +3 pour ce challenge. Alternativement, quand votre personnage tente une action d’une durée significative, non basée sur un pouvoir et en lien avec son focus, comme par exemple traduire un texte ancien en français, votre conteur peut diviser le temps de réalisation par deux."}
            };

            focusTraductions.ForEach(t =>
            {
                context.Traductions.Add(t);
            });

            context.SaveChanges();
            #endregion

            #endregion

            #region Attributs
            var attributs = new List<Attribut>
            {
                new Attribut {AttributKey = "PHYSICAL_KEY", AttributName = "PHYSICAL_NAME", Description = "PHYSICAL_DESCRIPTION", Focus = new List<Focus> { focus[0], focus[1], focus[2] } },
                new Attribut {AttributKey = "SOCIAL_KEY", AttributName = "SOCIAL_NAME", Description = "SOCIAL_DESCRIPTION", Focus = new List<Focus> { focus[3], focus[4], focus[5] } },
                new Attribut {AttributKey = "MENTAL_KEY", AttributName = "MENTAL_NAME", Description = "MENTAL_DESCRIPTION", Focus = new List<Focus> { focus[6], focus[7], focus[8] } }
            };

            attributs.ForEach(a =>
            {
                context.Attributs.Add(a);
            });

            context.SaveChanges();

            #region Traduction
            var attributsTraductions = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "PHYSICAL_NAME", Text = "Physique"},
                new Traduction{LCID = 1036, Key = "SOCIAL_NAME", Text = "Social"},
                new Traduction{LCID = 1036, Key = "MENTAL_NAME", Text = "Mental"},

                new Traduction{LCID = 1036, Key = "PHYSICAL_DESCRIPTION", Text = "Les attributs physiques quantifient de manière générale la force, l’agilité et la vigueur d’un personnage. Un personnage avec de modestes attributs physiques n’est pas très athlétique, tandis qu’un personnage avec des attributs physiques élevés est exceptionnellement fort, dextre ou robuste. Les vampires peuvent dépenser des points de Sang pour augmenter surnaturellement leurs attributs Physiques (et seulement leur Physique) pour une courte période. Pour davantage d’informations sur la manière de dépenser ainsi du Sang, voyez le chapitre Le sang."},
                new Traduction{LCID = 1036, Key = "SOCIAL_DESCRIPTION", Text = "Les vampires sont des créatures manipulatrices, usant des humains (et réciproquement) comme des composantes de leurs tentatives afin de faire avancer leurs objectifs personnels. Les attributs sociaux décrivent l’apparence, le charme et la capacité à interagir avec autrui d’un personnage. Si votre personnage a peu d’attribut en Social, il est maladroit, timide ou encore commun. Un personnage avec un haut niveau dans l’attribut Social est séduisant, fascinant et doux, doué pour convaincre autrui d’aller dans son sens."},
                new Traduction{LCID = 1036, Key = "MENTAL_DESCRIPTION", Text = "Les attributs mentaux indiquent la capacité du personnage à résoudre des problèmes, apprendre, déduire et à être attentif. Un personnage avec un attribut Mental élevé est vigilant, logique ou intuitif. D’autre part, si l’attribut Mental du personnage est faible, il n’est pas aussi doué. Un tel personnage peut avoir fait peu d’études, être naïf ou lent à la détente."}
            };

            attributsTraductions.ForEach(t =>
            {
                context.Traductions.Add(t);
            });

            context.SaveChanges();
            #endregion

            #endregion

            #region Disciplines
            AnimalismInitializer.Initialize(context, focus);
            AuspexInitializer.Initializer(context, focus);
            CelerityInitializer.Initializer(context, focus);
            ChimestryInitializer.Initializer(context, focus);
            DaimoinonInitializer.Initializer(context, focus);
            DementationInitializer.Initializer(context, focus);
            DominateInitializer.Initializer(context, focus);
            FortitudeInitializer.Initializer(context, focus);
            MelpomineeyInitializer.Initializer(context, focus);
            MytherceriaInitializer.Initializer(context, focus);
            ObeahInitializer.Initializer(context, focus);
            ObfuscateInitializer.Initializer(context, focus);
            ObtenebrationInitializer.Initializer(context, focus);
            PotenceInitializer.Initializer(context, focus);
            PresenceInitializer.Initializer(context, focus);
            ProteanInitializer.Initializer(context, focus);
            QuietusInitializer.Initializer(context, focus);
            TemporisInitializer.Initializer(context, focus);
            ThanatosisInitializer.Initializer(context, focus);
            ValerenInitializer.Initializer(context, focus);
            VicissitudeInitializer.Initializer(context, focus);
            VisceratikaInitializer.Initializer(context, focus);
            SerpentisInitializer.Initializer(context, focus);
            SepulcherInitializer.Initializer(context, focus);
            #endregion

            //ClanInitilizer.Initializer(context);
        }

        #region Labels
        private static class LabelInitializer
        {
            public static void Initializer(DBNContext context)
            {
                var labels = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "GEN_LBL_SITE_NAME", Text = "Defense By Night"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_CONNEXION", Text = "Connexion"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_REGISTRATION", Text = "Inscription"},
                 new Traduction{LCID = 1036, Key = "GEN_LBL_Home", Text = "Accueil"},

                new Traduction{LCID = 1036, Key = "GEN_LBL_FIRSTNAME", Text = "Prénom"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_LASTNAME", Text = "Nom de famille"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_EMAIL", Text = "Adresse mail"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_PASSWORD", Text = "Mot de passe"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_CONFIRM_PASSWORD", Text = "Confirmation du mot de passe"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_BIRTHDATE", Text = "Date de naissance"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_ALIAS", Text = "Pseudo"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_MOBILE_PHONE", Text = "Téléphone portable"},

                new Traduction{LCID = 1036, Key = "GEN_LBL_ACCOUNT", Text = "Mon Compte"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_DISCONNECT", Text = "Déconnexion"},

                new Traduction{LCID = 1036, Key = "GEN_LBL_CREATE_CHARACTER", Text = "Création de personnage"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_NEXT_GAME", Text = "Prochaine partie"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_WELLCOME", Text = "Bienvenue sur la Cité de Verre !"},

                new Traduction{LCID = 1036, Key = "GEN_LBL_DISCIPLINE", Text = "Disciplines"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_RULES", Text = "Règles"},

                new Traduction{LCID = 1036, Key = "GEN_LBL_TEST_SCORE", Text = "Score de test"},

                new Traduction{LCID = 1036, Key = "GEN_LBL_SYSTEM", Text = "Système"},

                new Traduction{LCID = 1036, Key = "GEN_LBL_FOCUS", Text = "Focus"},
                new Traduction{LCID = 1036, Key = "GEN_LBL_EXEPTIONNAL_SUCCESS", Text = "Succès Exceptionnel"},

                 
                #region Menu
                new Traduction{LCID = 1036, Key = "GEN_LBL_DISCIPLINE_POWER", Text = "Disciplines & Pouvoirs"},
	            #endregion
            };

                labels.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
            }
        }
        #endregion

        #region Messages d'erreurs
        private static class ErrorMessageInitializer
        {
            public static void Initializer(DBNContext context)
            {
                var errorMessages = new List<Traduction>
                {
                    new Traduction{LCID = 1036, Key = "ERR_FIRSTNAME_MISSING", Text = "Le prénom n'est pas renseigné."},
                    new Traduction{LCID = 1036, Key = "ERR_FIRSTNAME_TO_LONG", Text = "Le prénom ne peut pas dépasser les 20 carractères."},

                    new Traduction{LCID = 1036, Key = "ERR_LASTNAME_MISSING", Text = "Le nom de famille n'est pas renseigné."},
                    new Traduction{LCID = 1036, Key = "ERR_LASTNAME_TO_LONG", Text = "Le nom de famille ne peut pas dépasser les 20 carractères."},

                    new Traduction{LCID = 1036, Key = "ERR_ALIAS_MISSING", Text = "Le pseudo n'est pas renseigné."},
                    new Traduction{LCID = 1036, Key = "ERR_ALIAS_TO_LONG", Text = "Le pseudo ne peut pas dépasser les 20 carractères."},

                    new Traduction{LCID = 1036, Key = "ERR_EMAIL_MISSING", Text = "L'adresse mail n'est pas renseignée."},
                    new Traduction{LCID = 1036, Key = "ERR_EMAIL_UNCORRECT", Text = "L'adresse mail n'est pas correcte."},

                    new Traduction{LCID = 1036, Key = "ERR_PASSWORD_MISSING", Text = "Le mot de passe n'est pas renseigné."},
                    new Traduction{LCID = 1036, Key = "ERR_PASSWORD_TO_SHORT", Text = "Le mot de passe doit faire au moins 8 caractères."},
                    new Traduction{LCID = 1036, Key = "ERR_PASSWORD_NOT_MATCHING", Text = "Le mot de passe ne correcpond pas à celui renseigné."},

                    new Traduction{LCID = 1036, Key = "ERR_BIRTHDATE_MISSING", Text = "La date de naissance n'est pas renseignée."},

                    new Traduction{LCID = 1036, Key = "ERR_SIGNIN_FAIL", Text = "L'adresse mail ou le mot de passe est incorrecte."},
                };

                errorMessages.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });

                context.SaveChanges();
            }
        }
        #endregion

        #region Disciplines Initializer

        private static class AnimalismInitializer
        {
            public static void Initialize(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "ANIMALISM_POWER_1_NAME", Description = "ANIMALISM_POWER_1_DESCRIPTION", System = "ANIMALISM_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "ANIMALISM_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "ANIMALISM_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "ANIMALISM_NAME" },
                new Power { Level = 2, PowerName = "ANIMALISM_POWER_2_NAME", Description = "ANIMALISM_POWER_2_DESCRIPTION", System = "ANIMALISM_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "ANIMALISM_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "ANIMALISM_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "ANIMALISM_NAME" },
                new Power { Level = 3, PowerName = "ANIMALISM_POWER_3_NAME", Description = "ANIMALISM_POWER_3_DESCRIPTION", System = "ANIMALISM_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "ANIMALISM_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "ANIMALISM_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "ANIMALISM_NAME" },
                new Power { Level = 4, PowerName = "ANIMALISM_POWER_4_NAME", Description = "ANIMALISM_POWER_4_DESCRIPTION", System = "ANIMALISM_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "ANIMALISM_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "ANIMALISM_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "ANIMALISM_NAME" },
                new Power { Level = 5, PowerName = "ANIMALISM_POWER_5_NAME", Description = "ANIMALISM_POWER_5_DESCRIPTION", System = "ANIMALISM_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "ANIMALISM_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "ANIMALISM_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "ANIMALISM_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "ANIMALISM_NAME", Text = "Animalisme"},
                new Traduction{LCID = 1036, Key = "ANIMALISM_DESCRIPTION", Text = "Quand un vampire est Étreint, son âme est accablée par un instinct sombre et primal : La Bête. La Bête le change en prédateur, le conduisant à des actes sauvages pour sa survie. Certains vampires résistent à leur Bête, tandis que d’autres se réjouissent de leur nouvelle nature animale. En s'appuyant sur cet instinct sauvage et cette pulsion prédatrice, un vampire peut communiquer avec et contrôler des animaux, en établissant son emprise sur les bêtes plus primitives que lui. <br /> L'Animalisme peut être utilisé sur les oiseaux, les mammifères, les marsupiaux et les poissons. Il ne peut pas être utilisé sur les insectes, ni sur les créatures dont l’esprit est trop élémentaire pour comprendre une communication rudimentaire, tels que les mollusques ou les vers."},

                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_1_NAME", Text = "Murmures Sauvages"},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_2_NAME", Text = "Appel"},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_3_NAME", Text = "Dompter la Bête"},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_4_NAME", Text = "Soumission de l’esprit"},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_5_NAME", Text = "Conquérir la Bête"},

                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_1_DESCRIPTION", Text = "<i>Les animaux vous reconnaissent comme un prédateur et réagissent avec suspicion et peur. Vous pouvez communiquer avec les animaux en poussant des grognements et en utilisant le langage corporel. Bien qu’un animal ne soit pas obligé de vous obéir, il aura tendance à répondre favorablement aux personnes qui utilisent ce pouvoir.</i>"},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_2_DESCRIPTION", Text = "<i>En poussant un hurlement, une série de gazouillis, ou tout autre bruit d’animal identifiable, vous invoquez des animaux jusqu'à vous. Selon la forme de votre appel, vous pouvez choisir la taille et le type d’animal commun dans la zone. Bien que ces animaux ne soient pas vos esclaves, ils sont relativement amicaux envers vous et tenteront de vous assister de leur mieux pour ce que vous leur demandez.</i>"},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_3_DESCRIPTION", Text = "<i>La Bête est une créature féroce, désireuse de dominer les autres, sujette à de violentes pulsions et agissant de manière primitive. Toutefois, la Bête peut être domptée, ou bien intimidée, par ceux qui savent comment maîtriser ses pulsions. Certains vampires utilisent ce pouvoir comme un alpha le ferait sur une créature inférieure, forçant la Bête au calme. D’autres apaisent les émotions de leur cible, plongeant la Bête de l’autre dans une paisible tranquillité. Quelle que soit la méthode utilisée, le résultat est le même et le vampire ciblé doit temporairement survivre sans les instincts acérés de sa Bête.</i>"},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_4_DESCRIPTION", Text = "<i>La Bête est une chose palpable, capable d’influencer les esprits des autres animaux. Vous pouvez non seulement intimider les créatures inférieures, mais pouvez aussi envoyer votre conscience dans le corps d’un animal, le soumettant complètement. Le corps de l’animal devient complètement soumis à votre volonté et vous pouvez l’utiliser comme si c’était votre forme naturelle. Pendant que votre esprit est dans le corps de l’animal, votre propre corps tombe dans un état comateux. Bien que vous puissiez utiliser l’entièreté de votre intelligence, votre ruse et vos souvenirs, vous êtes limités par les capacités physiques de l’animal.</i>"},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_5_DESCRIPTION", Text = "<i>Grâce à votre fine compréhension de votre propre nature primitive et vos instincts de prédateur, vous êtes en communion avec la Bête. Bien que personne ne dirait que le monstre est dompté, la capacité de lâcher ou restreindre volontairement votre Bête est effroyable et peut donner à un vampire un avantage de taille.</i>"},

                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_1_SYSTEM", Text = "Vous pouvez communiquer avec les animaux en poussant des grognements et en utilisant le langage corporel. Pour poser des questions à un animal, consultez un Conteur. Le Conteur doit répondre du point de vue de l’animal qui aura été attiré par votre appel. Un personnage qui souhaite établir une communication doit être visible et audible de la créature. Vous pouvez parler à un animal en particulier, ou bien utiliser ce pouvoir pour questionner toute la faune locale à portée d’écoute. <br /> S’il n’y a pas d’animaux à proximité, vos requêtes peuvent rester sans réponse. De plus, si le Conteur pense que vous demandez quelque chose qu’un animal ne remarquerait pas (ou pourrait ne pas comprendre), votre personnage recevra une réponse confuse ou incomplète. Demander <i>«Est-ce que des créatures à deux pattes (humain ou vampire) sont passées par ici cette nuit ?»</i> recevrait une réponse raisonnable. Les écureuils, les chiens errants ou les oiseaux locaux pourraient vous dire qu’un groupe de six hommes sont passés par ici très récemment. Toutefois, ces animaux seraient incapables de différencier un humain d’un autre, ni d’identifier le type d’équipement qu’ils portaient."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_2_SYSTEM", Text = "En dépensant un point de Sang et une action standard, vous invoquez jusqu’à cinq petits animaux, trois animaux moyens ou un grand animal. Vous déterminez le type (et la taille) de ces animaux. Dans des conditions habituelles, ces animaux arriveront dans les dix minutes. Toutefois, si vous choisissez d’invoquer des animaux particulièrement courants dans la zone, cela peut prendre moins de temps. Invoquer un animal particulièrement rare peut prendre bien plus longtemps (à la discrétion du Conteur). Tenter d’invoquer un animal n’existant pas dans la région (comme un ours polaire dans le désert égyptien) sera un échec automatique. <br /> Les animaux ainsi convoqués ne se voient attribuer aucun pouvoir spécial pour répondre à votre appel et doivent donc pouvoir voyager jusqu’à vous. Un coyote ne pourra pas ouvrir une porte fermée, mais pourra se rendre sur un parking, là où un corbeau atteindra très facilement le toit d’un immeuble. Ce pouvoir ne confère aucune capacité spéciale, ni intelligence ou courage à l’animal invoqué. <br /> Les animaux invoqués vous considèrent comme un <i>alpha</i> de leur espèce. Si vous utilisez Murmures Sauvages pour communiquer, les animaux Appelés tenteront d’obéir à vos requêtes. Ils travailleront pour vous jusqu’à l’aube ou jusqu’à encaisser autant de dégâts que leur niveau de PNJ. <br /> Plusieurs utilisations de ce pouvoir ne permettent pas de convoquer des groupes supplémentaires de créatures tout en contrôlant les premiers. Toutefois, si votre premier groupe d’animaux Appelés est dispersé (en prenant des dégâts, en fuyant ou en étant renvoyé), vous pouvez réutiliser ce pouvoir pour convoquer un second groupe. En outre, Appel ne peut être utilisé pour prendre le contrôle d’un groupe d’animaux sous le contrôle d’un autre utilisateur de la Discipline Animalisme (bien que vous puissiez utiliser Murmures Sauvages pour parler avec de tels animaux). <br /> Les animaux convoqués avec Appel sont créés avec les règles de PNJ type, avec les instructions supplémentaires suivantes : <br /> • <i>Petits animaux</i> : Utilisez la règle pour un PNJ type à 1 point. <br /> Les petits animaux peuvent posséder une capacité de déplacement spéciale. Cette capacité lui permet d’escalader, nager, voler ou de s’enfouir à une vitesse normale. <br /> Les petits animaux sont les petits chiens, les chats, les écureuils et la plupart des oiseaux, les poissons et les animaux fouisseurs. <br /> • <i>Animaux moyens</i> : Utilisez la règle pour un PNJ type à 3 points. <br /> Cette catégorie comprend les gros chiens, les coyotes, les lynx et les ours bruns. <br /> • <i>Grands animaux</i> : Utilisez la règle pour un PNJ type à 5 points.<br /> L’invocateur peut Appeler un cheval, un cerf ou un grizzli.<br /> Avant d’aller dormir ou d’entrer en torpeur, il est possible de dépenser un point de Sang pour activer ce pouvoir.Utilisé de cette façon, les animaux invoqués par ce pouvoir garderont votre lieu de repos jusqu’à leur mort ou votre réveil."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_3_SYSTEM", Text = "La cible de ce pouvoir doit être un vampire ou une autre créature surnaturelle capable d’entrer en frénésie.<br /> Quand vous êtes le centre de l’attention d’un autre personnage (comme indiqué dans les règles génériques d’usage de Disciplines), vous pouvez dépenser un point de sang, utiliser une action standard et faire un challenge en opposition en utilisant le Score de Test d’Animalisme. Si la cible était en frénésie, quand ce pouvoir a été utilisé avec succès, elle sort immédiatement de frénésie.<br /> Si la cible du pouvoir n’était pas en frénésie, elle devient incapable d’entrer en frénésie durant la prochaine heure. De plus, sa Volonté est affaiblie et elle doit dépenser deux points de Volonté (au lieu d’un seul) pour bénéficier d’un re-test de challenge durant le reste de ce tour et le prochain tour complet. <br /> La Bête d’un vampire est une partie critique de sa nature prédatrice. Quand elle est endormie, le vampire est plus lent à réagir. Si un individu a un Trait de la Bête (ou en gagne un) sous l’effet de ce pouvoir, elle lutte pour utiliser sa Volonté pour une plus grande période. Pour les cinq prochaines minutes, elle doit continuer à dépenser deux points de Volonté au lieu d’un pour refaire ses challenges.<br /> Les personnages ayant des avantages ou des pouvoirs permettant un re-test sans dépenser de Volonté peuvent les utiliser normalement quand ils sont sous l’effet de ce pouvoir et ne dépensent pas un point supplémentaire de Volonté pour ces re-tests. <br /> Dompter la Bête ne peut être utilisé sur soi."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_4_SYSTEM", Text = "Pour utiliser Soumission de l’Esprit, vous devez dépenser un point de sang et une action standard pour regarder un animal dans les yeux ; ce pouvoir ne peut pas fonctionner sur un sujet aveugle ou qui ne peut pas voir vos yeux. Faites un challenge opposé contre l’animal quand vous tentez de contrôler. Si c’est une réussite, votre conscience est transférée dans le corps de votre cible et son esprit est mis dans un état proche de la fugue. Comme votre esprit est entièrement concentré sur le contrôle de ce nouveau corps, le vampire n’a aucune perception de ce que son vrai corps ressent. Le corps du personnage tombe dans un état de coma et ne peut se défendre ni agir de lui-même. Le corps peut toujours utiliser Force d’Âme ou d’autres pouvoirs qui sont toujours actifs quand votre conscience est absente. Pendant l’utilisation de ce pouvoir, vous connaissez toujours la direction et la distance à laquelle se trouve votre vrai corps, bien que vous ne puissiez pas percevoir ses alentours.<br /> Les animaux normaux et <i>goulifiés</i> peuvent être la cible de Soumettre l’Esprit. Les créatures surnaturelles (comme les vampires transformés en animaux ou les loup-garous) ne peuvent pas être la cible de ce pouvoir. Assurez-vous de demander à votre Conteur si votre cible est appropriée.<br /> Les animaux normaux ne possèdent pas de disciplines et ne peuvent dépenser de sang. Toutefois, si votre personnage contrôle un animal <i>goulifié</i>, la goule possède 5 points de sang (comme une goule standard). Le vampire ayant le contrôle peut dépenser un point de sang par tour, quelle que soit la génération du personnage. Vous ne pouvez en aucune façon dépenser de sang pour agir sur le corps d’origine.<br /> Un personnage ne peut utiliser aucune de ses disciplines pendant qu’il utilise Soumission de l’Esprit. Vous pouvez dépenser le sang de la goule pour utiliser ses propres pouvoirs physiques : Célérité, Force d’Âme et Puissance.<br /> Pendant l’utilisation de ce pouvoir, un personnage utilise ses propres attributs et focus mentaux et sociaux, ses compétences et historiques pour les challenges.Toutefois, vous utilisez les attributs physiques de l’animal pour les challenges physiques.Cet attribut est égal au double du niveau de PNJ de cet animal. Si l’animal que vous contrôlez a le pouvoir de voler ou est adapté à la vie aquatique(comme un poisson), vous pouvez voler ou nager à vitesse normale.<br /> Soumettre l’Esprit dure jusqu’à la prochaine aube ou jusqu’à ce que vous dépensiez une action simple pour quitter l’animal et vous réveiller. Soumettre l’Esprit s’arrête immédiatement si le personnage s’éloigne à plus de 16km(10 miles) de son corps d’origine ou si le corps d’origine comme celui de l’animal encaissent des dommages. <br /> Les animaux ne prennent pas de dégâts dus au soleil, même une fois contrôlé par un vampire. Toutefois, un vampire avec des Traits de la Bête risque d’entrer en frénésie. "},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_5_SYSTEM", Text = "Dépensez un point de sang et une action simple pour sortir immédiatement de Frénésie. Alternativement, vous pouvez dépenser un point de sang et une action simple pour rentrer immédiatement en Frénésie."},

                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_1_FOCUS_DESCRIPTION", Text = "Vous n’avez pas besoin de grogner ou de faire un geste pour vous faire comprendre. Votre Bête peut communiquer directement avec les esprits des animaux proches. Toutefois, ces animaux doivent pouvoir vous voir pendant que vous utilisez ce pouvoir. En outre, vous n’avez plus besoin de compter sur la capacité de langage de l’animal. Quand vous utilisez ce pouvoir, vous obtenez une image mentale de toute situation que l’animal tente de décrire. Par exemple, vous verriez un souvenir du Prince marchant vers sa voiture, plutôt que d’entendre la description et l’interprétation du rat témoin de la scène."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_2_FOCUS_DESCRIPTION", Text = "Quand vous invoquez des créatures en utilisant ce pouvoir, appliquez l’un des effets additionnels suivants. Si vous invoquez plus d’une créature, l’effet choisi s’applique à chaque créature (toutes pourront voler, auront une intelligence supérieure, etc.) <br /> • <i>Déplacement spécial</i> <br /> Vous pouvez invoquer un groupe de créatures de taille moyenne qui peut voler ou nager à une vitesse normale (comme un vautour, un aigle ou un saumon) ou une unique créature de grande taille qui nage à vitesse normale (comme un requin ou un dauphin) <br /> • <i>Intelligence accrue</i> <br /> Vous pouvez appeler un animal particulièrement intelligent pour son espèce. Cet animal est doué de compréhension et suivra des instructions bien plus complexes. Vous pouvez lui donner des ordres de type Si/Alors comme <i>«Reste à la porte pendant que je m’infiltre à l’intérieur. Aboie une fois si un homme approche et deux fois si tu vois une femme»</i>. Cet animal est un individu lambda de son espèce pour les autres aspects.<br /> •<i>Nuée</i><br /> Vous invoquez un grand nombre de petits animaux.</i> Ce peut être des rats, des corbeaux, des piranhas ou d’autres créatures similaires ; mais souvenez-vous qu’Animalisme ne peut affecter les insectes.<br />Une nuée est créée en utilisant les règles de PNJ type normales et une nuée est considérée comme une unique créature en matière de combat.<br />Une nuée se déplace lentement (un pas par action) et en tuer un unique animal n’a que peu d’effet sur la totalité de la nuée. Pour venir à bout d’une nuée, vous devez infliger le double des dégâts nécessaires à tuer un PNJ de sa taille. Un grand animal a 5 niveaux de santé, donc une nuée de grande taille aura 10 niveaux de santé."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_3_FOCUS_DESCRIPTION", Text = "Plutôt que d’avoir à dépenser un point de Volonté supplémentaire pour faire un re-test, la victime ne peut plus faire de re-test du tout durant l’effet de ce pouvoir."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_4_FOCUS_DESCRIPTION", Text = "Vous pouvez utiliser les deux premiers niveaux de vos disciplines mentales et sociales de clan lorsque vous utilisez Soumission de l’Esprit. Si vous contrôlez un animal <i>goulifié</i>, vous pouvez dépenser jusqu’à 5 points de sang pour utiliser ces disciplines de clan, au rythme d’un point par tour, quelle que soit la génération. Les vampires avec ce focus ayant Animalisme comme discipline de clan peuvent utiliser Soumission de l’Esprit pendant l’utilisation de Soumission de l’Esprit, transférant leur esprit d’un animal à un autre. Chaque nouvelle utilisation de Soumission de l’Esprit coûte un point de sang, une action standard, un contact visuel et un challenge opposé."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_5_FOCUS_DESCRIPTION", Text = "Vous pouvez utiliser Conquérir la Bête pour entrer en Frénésie, même si vous en seriez en principe incapable, par exemple lorsque vous êtes affecté par des pouvoirs comme Dompter la Bête. De plus, en <i>Frénésie de rage</i>, votre personnage reçoit un bonus de +3 à tous ses groupements de Test d’Attaque Physique (au lieu du +1 standard). Votre personnage souffre toujours du malus standard de -2 à ses groupements de Test de Défense Physique quand il est en Frénésie."},

                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_3_EXCEPTIONALSUCCESS", Text = "L’effet d’affaiblissement sur la Volonté dure jusqu’à la fin de ce tour et pour les deux tours complets suivants (plutôt qu’un)."},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "ANIMALISM_POWER_5_EXCEPTIONALSUCCESS", Text = null},

                new Traduction{LCID = 1036, Key = "ANIMALISM_TEST_SCORE", Text = "Le personnage usant d’Animalisme utilise <i>Social</i> + <i>Dressage</i> contre <i>Social</i> + <i>Volonté</i> de la cible"},
            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "ANIMALISM_KEY",
                    DisciplineName = "ANIMALISM_NAME",
                    Description = "ANIMALISM_DESCRIPTION",
                    TestScore = "ANIMALISM_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class AuspexInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "AUSPEX_POWER_1_NAME", Description = "AUSPEX_POWER_1_DESCRIPTION", System = "AUSPEX_POWER_1_SYSTEM", Focus = focus[6], FocusEffect = "AUSPEX_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "AUSPEX_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "AUSPEX_NAME" },
                new Power { Level = 2, PowerName = "AUSPEX_POWER_2_NAME", Description = "AUSPEX_POWER_2_DESCRIPTION", System = "AUSPEX_POWER_2_SYSTEM", Focus = focus[6], FocusEffect = "AUSPEX_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "AUSPEX_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "AUSPEX_NAME" },
                new Power { Level = 3, PowerName = "AUSPEX_POWER_3_NAME", Description = "AUSPEX_POWER_3_DESCRIPTION", System = "AUSPEX_POWER_3_SYSTEM", Focus = focus[6], FocusEffect = "AUSPEX_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "AUSPEX_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "AUSPEX_NAME" },
                new Power { Level = 4, PowerName = "AUSPEX_POWER_4_NAME", Description = "AUSPEX_POWER_4_DESCRIPTION", System = "AUSPEX_POWER_4_SYSTEM", Focus = focus[6], FocusEffect = "AUSPEX_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "AUSPEX_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "AUSPEX_NAME" },
                new Power { Level = 5, PowerName = "AUSPEX_POWER_5_NAME", Description = "AUSPEX_POWER_5_DESCRIPTION", System = "AUSPEX_POWER_5_SYSTEM", Focus = focus[8], FocusEffect = "AUSPEX_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "AUSPEX_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "AUSPEX_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "AUSPEX_NAME", Text = "Auspex"},
                new Traduction{LCID = 1036, Key = "AUSPEX_DESCRIPTION", Text = "Les sens d’un prédateur doivent être extrêmement développés pour traquer sa proie dans la nuit. Les cinq sens de l’odorat, du toucher, du goût, de la vue et de l’ouïe peuvent tous être affûtés avec l’utilisation de l’Auspex. Ils peuvent alors dépasser les sens physiques, augmentant les capacités de concentration, de perception et même de conscience d’un vampire au-delà des possibilités des Mortels. De tels sens peuvent saisir les subtiles textures du mouvement ainsi que les états émotionnels, transcendant l’acuité mentale ordinaire. L’Auspex peut également percer les distractions mentales et les illusions, comme celles créées par les disciplines d’Occultation et de Chimérie. <br /> <strong>Auspex et Chimérie/Occultation </strong> : Si vous tentez d’utiliser Sens Accrus pour percer les occultations surnaturelles, votre cible peut choisir d’utiliser <i>Mental + Discrétion</i> pour Score de Test de Défense, en lieu et place de <i> Mental + Volonté </i>.Si vous tentez de percer une illusion, votre cible peut choisir d’utiliser <i>Social + Subterfuge</i> au lieu du Score de Test générique <i>Social + Volonté</i>. <br /> Si l’utilisateur d’Auspex réussit, il perce les pouvoirs d’Occultation ou de Chimérie."},

                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_1_NAME", Text = "Sens Accrus"},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_1_DESCRIPTION", Text = "<i>Vous pouvez étendre vos sens physiques au-delà des limites humaines. Votre vue et votre ouïe peuvent être étendues jusqu’à deux fois les limites humaines, alors que le toucher, l’odorat et le goût deviennent suffisamment sensibles pour discerner les plus infimes détails avec aisance. Un personnage peut améliorer n’importe lequel de ses sens, voire tous, selon ses désirs.</i>"},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_1_SYSTEM", Text = "Sens Accrus est toujours actif. La vision accrue d’un personnage lui permet de voir clairement, même dans l’obscurité la plus totale, et lui permet de comprendre des sons trop faibles pour que des personnes normales les entendent. Lorsqu’un personnage avec Sens Accrus se situe à moins de deux pas d’un individu dissimulé par des moyens surnaturels, comme avec Occultation, le personnage avec Sens Accrus réalise automatiquement que quelqu’un est proche, bien qu’il ne sache ni l’identité ni l’emplacement de cette personne. Sens Accrus ne donne qu’une vague sensation que quelque chose n’est pas normal.<br /> Lorsque que quelque chose vous aveugle, votre ouïe peut fournir une compensation adéquate pour la perte de votre vue. Normalement, les personnages qui ne peuvent voir pendant un combat doivent utiliser la Manœuvre de combat Combat en Aveugle.<br /> Tant que l’ouïe de votre personnage est intacte, vous pouvez vous battre sans passer par la Manœuvre de combat Combat en Aveugle. Si vous dépensez 1 point de Sang et faites une action standard, votre personnage peut améliorer ses sens de manière plus poussée. Si vous procédez ainsi, vous remarquez n’importe quel objet ordinaire caché dans votre champ de vision et vous pouvez faire un challenge en opposition en utilisant le Score de Test d’Auspex pour distinguer les détails de n’importe quel objet ou personne dissimulé avec des pouvoirs surnaturels, de même avec les objets illusoires, ou les objets et personnes déguisés par des pouvoirs surnaturels. Si vous percez un pouvoir surnaturel de cette manière, vous pouvez ignorer les utilisations de ce même pouvoir par le même utilisateur pendant les cinq prochaines minutes. Si vous possédez plus de niveaux d’Auspex que votre cible possède du pouvoir qu’elle est en train d’utiliser pour générer l’Occultation (ou l’illusion), les effets perçants du pouvoir persistent pendant une heure au lieu de cinq minutes."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_1_FOCUS_DESCRIPTION", Text = "Vous n’avez pas besoin de grogner ou de faire un geste pour vous faire comprendre. Votre Bête peut communiquer directement avec les esprits des animaux proches. Toutefois, ces animaux doivent pouvoir vous voir pendant que vous utilisez ce pouvoir. En outre, vous n’avez plus besoin de compter sur la capacité de langage de l’animal. Quand vous utilisez ce pouvoir, vous obtenez une image mentale de toute situation que l’animal tente de décrire. Par exemple, vous verriez un souvenir du Prince marchant vers sa voiture, plutôt que d’entendre la description et l’interprétation du rat témoin de la scène."},

                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_2_NAME", Text = "Perception d’Aura"},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_2_DESCRIPTION", Text = "<i>En étudiant attentivement un sujet, vous pouvez discerner l’aura brillante qui entoure toutes les créatures vivantes. L’interaction des couleurs dans une aura donne une idée des émotions du sujet, ainsi que de ses motivations et de sa nature. Avec de la pratique, vous pouvez apprendre à lire ces couleurs. Lors d’une soirée banale, l’aura d’un individu peut contenir de nombreuses teintes qui évoluent ; les émotions fortes prédominent, pendant que des impressions momentanées ou des motivations cachées surgissent brièvement par des traces ou des tourbillons. Les couleurs changent en fonction de l’état émotionnel du sujet, se mélangeant en de nouveaux tons dans un motif en constante évolution.Plus les émotions sont fortes, plus les teintes de l’aura sont prononcées.</i>"},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_2_SYSTEM", Text = "Dépensez 1 point de Sang et une action standard pour faire un challenge en opposition contre votre cible. Si vous réussissez, votre personnage peut lire les détails de l’aura de la cible. Typiquement, l’examen est visuel, mais n’importe quel sens physique approprié peut être utilisé. Si vous réussissez, vous pouvez discerner le type de créature de votre cible (vampire, goule, vampire possédant un mortel, etc…), l’humeur générale, toute tendance violente immédiate et si la cible a diablé ou non lors de l’année passée. Ce pouvoir ne vous permet pas de lire dans les pensées ou de détecter la vérité.<br /> Si vous échouez au challenge en opposition, l’aura de votre cible est trop trouble pour la discerner clairement. Les détails sont trop flous et aucune couleur ou motif en particulier ne semble dominant.<br /> Le coût en Sang pour activer Perception de l’Aura est nul si la cible ne s’oppose pas au challenge."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_2_EXCEPTIONALSUCCESS", Text = "Pour la prochaine heure, vous continuez à percevoir l’aura de la cible sans dépense supplémentaire de Sang et sans faire de challenge. Si son humeur change ou si elle devient agressive, vous aurez un avertissement préalable. En terme de mécanisme, si votre cible démarre un combat, vous pouvez faire une action simple avant qu’elle ne fasse n’importe quelle action. Cet avertissement ne vous donne pas une action supplémentaire, mais vous permet d’agir en avance."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_2_FOCUS_DESCRIPTION", Text = "Si votre cible se situe dans les limites de trois pas, votre personnage ne dépense pas de Sang pour activer Perception de l’Aura, que la cible soit volontaire ou non. Si la cible n’est pas volontaire, vous devez quand même faire un challenge en opposition pour utiliser ce pouvoir."},

                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_3_NAME", Text = "Psychométrie"},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_3_DESCRIPTION", Text = "<i>Toute créature vivante laisse derrière elle une empreinte de ses pensées et de ses émotions, à l’image des ondulations d’un sillage dans l’eau. Avec ce pouvoir, votre personnage peut lire les empreintes psychiques sur des objets récemment manipulés ou des lieux où des événements émotionnellement forts se sont produits. Un contact et un moment de concentration peuvent libérer un flux d’images et de sensations, pouvant révéler un aperçu du passé.</i> Notez que vous ne pouvez utiliser ce pouvoir que sur des objets ou des lieux et non sur des personnes, des vampires, des animaux, ou toute autre créature vivante. Les visions reçues par l’utilisation de ce pouvoir sont rarement claires ou détaillées et s’expriment plus comme des « aperçus psychiques ». Mais un vampire intelligent peut apprendre beaucoup d’un simple aperçu. Bien que la plupart des visions révéleront la dernière personne ayant utilisé l’objet ou se trouvant dans les lieux, un propriétaire de longue date peut laisser une impression plus forte et un drame du passé peut remplacer un événement plus récent d’un lieu. Pour obtenir une empreinte psychique, vous devez tenir physiquement l’objet (ou toucher une partie du lieu) à même la peau nue. Lorsque vous le faites, vous entrez dans une transe superficielle et vous récoltez des informations à partir des résidus spirituels de l’objet. Vous êtes à peine conscient de votre entourage lorsque vous utilisez Psychométrie, bien qu’un bruit fort ou des sensations physiques importantes fassent cesser la transe instantanément."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_3_SYSTEM", Text = "Dépensez 1 point de Sang et une action standard pour toucher un objet. Vous pouvez alors poser au Conteur une de ces questions et une question supplémentaire par cinq minutes de concentration du personnage sur l’objet ou le lieu :<br /> • Montre-moi la dernière personne qui a tenu l’objet. <br />•• Votre personnage reçoit une vision de la dernière personne qui a utilisé l’objet.La vision montre en général le dernier individu significatif et non la dernière personne à avoir touché l’objet.<br /> • Comment l’individu est-il mort ?<br /> •• Cette question ne peut être posée que lorsque Psychométrie est utilisée sur(tout ou partie d’) un cadavre. Votre personnage reçoit une vision des derniers moments de la vie de la cible.<br >/ • Quand(ou comment) l’objet a t-il été utilisé pour la dernière fois ?<br /> •• Votre personnage reçoit une image de la plus récente utilisation de l’objet et de sa cible(un couteau attaquant, avec l’apparition de la victime, des jumelles regardant en bas, montrant la voiture du Prince, etc.).Si l’objet a été utilisé dans un événement émotionnellement chargé, comme un meurtre ou un vol, votre personnage reçoit un bref aperçu de l’émotion et de son lien avec l’objet.<br /> • Y a-t - il des émotions fortes liées à l’objet ?<br /> •• Si quelqu’un aime ou déteste l’objet, ou si des émotions profondes sont liées à l’usage de l’objet, votre personnage reçoit cette information. Elle peut dater d’un certain temps, en fonction de la nature de l’objet et de ses associations.<br /> Certains objets ou lieux ont des émotions particulièrement fortes liées à eux. Votre Conteur peut décider de fournir une ou plusieurs réponses gratuitement lorsqu’un personnage utilise Psychométrie sur une cible chargée émotionnellement.Les personnages utilisant n’importe quel niveau d’Occultation et qui utilisent l’objet ou visitent un lieu, ne laissent aucune empreinte psychique.<br /> Pour les usages de ce pouvoir, les cadavres(y compris les cadavres de créatures surnaturelles et les cendres de vampires) comptent comme des objets et peuvent être ciblés par Psychométrie. Les vampires qui n’ont pas rencontré leur Mort Finale ne comptent pas comme des cadavres."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_3_FOCUS_DESCRIPTION", Text = "Quand vous activez Psychométrie, vous pouvez poser trois questions au lieu d’une."},

                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_4_NAME", Text = "Télépathie"},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_4_DESCRIPTION", Text = "<i>Depuis des temps anciens, les humains ont toujours désiré pouvoir connaître les secrets enfouis dans la pensée d’autrui, parler et recevoir des communications depuis l’âme aussi bien que les lèvres. La Télépathie est la communication pure de pensées, de sensations, de désirs et ceux qui peuvent réaliser un tel exploit sont puissants. En projetant vos sens vers l’extérieur, vous pouvez percer l’esprit des autres, extirpant leurs pensées. Vous pouvez lier votre conscience avec celle des autres, envoyant ou recevant des idées et des pensées.</i>"},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_4_SYSTEM", Text = "Pour activer Télépathie sur une cible volontaire, dépensez simplement 1 point de Sang. Aucun challenge n’est nécessaire et la cible peut être localisée n’importe où dans la même ville (ou un rayon de 80 km de l’emplacement de votre personnage). Cet usage de Télépathie ne nécessite pas spécifiquement de ligne de vue. La Télépathie permet au personnage et à sa cible d’envoyer et recevoir messages mentaux et simples images.<br /> Si vous tentez d’utiliser Télépathie sur une cible non volontaire, vous devez dépenser 1 point de Sang et faire un challenge en opposition contre la cible, qui doit être dans votre champ de vision. Si vous réussissez, votre personnage peut envoyer une image ou un bref message (quelque chose pouvant être dit en moins de 10 secondes) à la cible. Alternativement, votre personnage peut extirper une image ou une information spécifique de l’esprit de la cible involontaire. L’information reçue de cette manière doit répondre à l’une de ces questions suivantes (selon votre convenance) :<br />  • À quoi êtes-vous en train de penser ? <br /> • À quoi ressemble la personne ou la chose que vous venez juste de décrire ?<br /> • Où se trouve la personne ou l’objet dont vous venez juste de parler ? <br /> • Est-ce que vous aimez ou détestez la personne à qui vous êtes en train de parler ? <br />• Qu’avez-vous l’intention de faire dans les cinq prochaines minutes ? <br /> Si un personnage volontaire devient réticent pendant un échange télépathique, le personnage utilisant Télépathie doit immédiatement dépenser 1 point de Sang et réussir un challenge en opposition ou être éjecté de l’esprit de la cible désormais non volontaire.<br /> Lorsque vous communiquez avec une cible volontaire, une utilisation simple de Télépathie dure une heure mais vous ne pouvez communiquer qu’avec une seule personne en même temps.Si vous activez Télépathie sur une seconde cible, le premier lien se coupe immédiatement.<br /> Un individu ne peut pas utiliser d’autres pouvoirs(comme les pouvoirs de Domination − Injonction, Suggestion, ou Esprit Distrait) en conjonction avec Télépathie.<br /> Le télépathe a le choix de se faire connaître ou non pendant la communication. Dans le cas où il ne le ferait pas, la cible peut déterminer l’identité du télépathe en réussissant un challenge en opposition de Perception."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_4_EXCEPTIONALSUCCESS", Text = "Vous pouvez poser deux des questions ci-dessus (au lieu d’une) avec chaque challenge réussi lorsque vous extirpez des informations de l’esprit de votre cible."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_4_FOCUS_DESCRIPTION", Text = "Vous pouvez maintenir Télépathie avec jusqu’à trois cibles volontaires, vous permettant de tenir une conversation avec tous les participants en même temps. Les participants peuvent vous parler ou échanger entre eux par contact télépathique. Vous devez dépenser 1 point de Sang par cible. Pour faire venir un nouvel individu dans le lien, vous dépensez alors le Sang nécessaire. Vous pouvez éjecter quelqu’un de votre lien sans couper la communication avec les autres impliqués."},

                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_5_NAME", Text = "Projection Astrale"},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_5_DESCRIPTION", Text = "<i>N’étant plus confiné au plan physique, vous pouvez projeter vos sens et votre conscience en dehors de votre corps. Autonome, votre conscience vagabonde dans les différents niveaux de pensée, vous permettant de voir le monde comme si vous étiez un esprit incorporel. N’étant pas concerné par les problèmes de masse et de matière, vous traversez n’importe quelle barrière physique et vous vous déplacez à la vitesse de votre pensée jusqu’à n’importe quel endroit situé sur Terre.</i>"},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_5_SYSTEM", Text = "Pour activer Projection Astrale, vous devez dépenser 1 point de Sang et une action standard pour méditer. Cette dépense permet à votre personnage de projeter sa conscience en dehors de sa forme physique. Lorsqu’un personnage est en Projection Astrale, son corps est dans un état similaire à la torpeur. Si son corps est endommagé, la Projection Astrale cesse automatiquement et la conscience de l’individu retourne immédiatement dans son corps.<br /> La Projection Astrale d’un personnage est une version idéalisée de son apparence normale. Bien que cette image puisse revêtir des habits dorés, être entourée d’un halo de lumière argenté, ou avoir une fourrure épaisse, elle est toujours reconnaissable comme étant votre personnage. Une forme psychique peut voyager à environ 80 km par heure et traverser des objets solides, mais ne peut interagir avec le monde physique de quelle que manière que ce soit. Les seuls pouvoirs que vous pouvez utiliser pendant la Projection Astrale sont les quatre premiers niveaux d’Auspex ; vous ne pouvez pas utiliser d’autres disciplines, de pouvoirs d’Anciens d’Auspex ou de techniques(même celles basées sur l’Auspex) pendant que vous êtes dans cet état.<br /> Une forme psychique est invisible à ceux qui ne possèdent pas Sens Accrus ou des capacités surnaturelles similaires. Vous pouvez dépenser 1 point de Sang pour vous manifester(votre corps d’origine dépense ce Sang), rendant votre forme psychique visible comme si elle était matériellement présente pour un tour seulement.Bien que le personnage soit encore intangible et ne puisse interagir physiquement, une forme psychique manifestée peut être vue et entendue normalement et être ciblée par des pouvoirs Sociaux ou Mentaux par ceux dans le monde matériel. Les individus avec Sens Accrus ou des capacités surnaturelles similaires peuvent voir les vagues contours d’un individu en Projection Astrale même si cet individu ne s’est pas manifesté, mais l’observateur ne peut distinguer de détails, voir les mouvements ou entendre la voix projetée du personnage sauf s’il se manifeste.<br /> Deux individus qui sont tous deux en Projection Astrale peuvent interagir entre eux normalement et peuvent même se battre à coups de poing ou par des attaques Physiques non armées. Un coup réussi d’un autre individu sous cette forme n’inflige pas de dégâts; cela coûte à la place 1 point de Volonté à la victime. Si la victime n’a plus de Volonté, la Projection Astrale cesse immédiatement et ne peut être réactivée pendant 10 minutes. Rappelez - vous que seuls les 4 premiers niveaux d’Auspex peuvent être utilisés en Projection Astrale; un personnage ne peut utiliser d’autres pouvoirs(même contre un autre individu en projection astrale) et ne possède aucun équipement autre que de simples vêtements dans cet état."},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "AUSPEX_POWER_5_FOCUS_DESCRIPTION", Text = "En plus de l’Auspex, vous pouvez utiliser les deux premiers niveaux de n’importe quelle discipline Sociale ou Mentale de clan que vous possédez. C’est une exception à la règle contre l’utilisation d’autres disciplines en Projection Astrale. Votre personnage utilise ses pouvoirs normalement lorsqu’il en vise d’autres dans le plan psychique. Si votre personnage se manifeste, il peut également utiliser ses disciplines sur des cibles du monde matériel pendant sa manifestation. <br /> Puissance, Célérité et Force d’âme ne peuvent jamais être utilisées en Projection Astrale ni les pouvoirs nécessitant un contact, sauf s’ils sont utilisés contre d’autres individus psychiquement projetés."},

                new Traduction{LCID = 1036, Key = "AUSPEX_TEST_SCORE", Text = "L’utilisateur d’Auspex utilise <i>Mental + Investigation</i> contre <i>Mental + Volonté</i> de la cible."}

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "AUSPEX_KEY",
                    DisciplineName = "AUSPEX_NAME",
                    Description = "AUSPEX_DESCRIPTION",
                    TestScore = "AUSPEX_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class CelerityInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "CELERITY_POWER_1_NAME", Description = "CELERITY_POWER_1_DESCRIPTION", System = "CELERITY_POWER_1_SYSTEM", Focus = null, FocusEffect = "CELERITY_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "CELERITY_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "CELERITY_NAME" },
                new Power { Level = 2, PowerName = "CELERITY_POWER_2_NAME", Description = "CELERITY_POWER_2_DESCRIPTION", System = "CELERITY_POWER_2_SYSTEM", Focus = null, FocusEffect = "CELERITY_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "CELERITY_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "CELERITY_NAME" },
                new Power { Level = 3, PowerName = "CELERITY_POWER_3_NAME", Description = "CELERITY_POWER_3_DESCRIPTION", System = "CELERITY_POWER_3_SYSTEM", Focus = null, FocusEffect = "CELERITY_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "CELERITY_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "CELERITY_NAME" },
                new Power { Level = 4, PowerName = "CELERITY_POWER_4_NAME", Description = "CELERITY_POWER_4_DESCRIPTION", System = "CELERITY_POWER_4_SYSTEM", Focus = null, FocusEffect = "CELERITY_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "CELERITY_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "CELERITY_NAME" },
                new Power { Level = 5, PowerName = "CELERITY_POWER_5_NAME", Description = "CELERITY_POWER_5_DESCRIPTION", System = "CELERITY_POWER_5_SYSTEM", Focus = null, FocusEffect = "CELERITY_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "CELERITY_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "CELERITY_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "CELERITY_NAME", Text = "Célérité"},
                new Traduction{LCID = 1036, Key = "CELERITY_DESCRIPTION", Text = "Tout au long de l’histoire, les mythes ont décrit les vampires comme possédant une rapidité et des réflexes surnaturels. Ils se déplacent dans un mouvement flou, marchant sur des surfaces ne pouvant pas supporter leur poids et combattant entre deux battements de cœurs. Célérité est la discipline de la précision et de la rapidité extraordinaire. Au besoin, un vampire peut dépenser son Sang pour accélérer ses actions, se déplaçant avec une rapidité étonnante <br /> Célérité permet d’obtenir des actions supplémentaires. Ces actions supplémentaires se résolvent dans une série de rounds spéciaux appelés <i>Round de Célérité</i>. Après avoir résolu le round d’actions classiques pour tout le monde (dans l’ordre d’initiative), le Conteur continue le combat dans le round de Célérité.Chaque round de Célérité est résolu dans l’ordre d’initiative.Après toutes les actions des personnages dans le premier round de Célérité, le Conteur passe au second Round de Célérité et ainsi de suite jusqu’à ce que tous les personnages impliqués n’aient plus d’actions. <br /> Le round classique et tous les rounds de Célérité composent un seul tour.Une fois tous les rounds de Célérité résolus, le Conteur passe au tour suivant, commençant par le round classique et passant ensuite à tous les rounds de Célérité, etc. <br />Vous pouvez seulement faire des actions Physiques durant un round de Célérité. Votre personnage peut se déplacer, attaquer ou activer un pouvoir Physique mais ne peut engager de challenges mentaux ou sociaux. <br /> Vous devez dépenser un point de sang pour activer Célérité pour un tour.Cette dépense active tous les niveaux de Célérité possédés.Activer Célérité ne requiert pas d’action et peut être fait n’importe quand(même avant votre tour dans l’ordre d’initiative). Certaines techniques basées sur la Célérité ou des pouvoirs d’anciens requièrent une dépense supplémentaire de Sang ou l’usage d’une action pour l’activer.Si c’est le cas, ce sera indiqué dans la description du pouvoir. <br /> Chaque point de Célérité représente une amélioration supplémentaire de la vitesse et chaque point s’ajoute aux bonus précédents. Si un personnage possède Rapidité(Célérité • • •) il possède les bonus de Rapidité mais aussi les bonus donnés par Alacrité(Célérité •) et Vivacité (Célérité • •), qu’il doit posséder pour avoir Rapidité. <br /> Utiliser Célérité au niveau Rapidité ou supérieur est un Bris de Mascarade si un mortel devait en être témoin. <br /> <strong> • Célérité et Temporis </strong>: Un personnage ayant pris Célérité ne peut pas apprendre Temporis et réciproquement."},

                new Traduction{LCID = 1036, Key = "CELERITY_POWER_1_NAME", Text = "Alacrité"},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_1_DESCRIPTION", Text = "<i>Vous êtes capable d’un temps de réaction incroyable. En activant Alacrité, vous pouvez faire des mouvements incroyablement rapides, améliorant à la fois vitesse et réflexes</i>"},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_1_SYSTEM", Text = "Quand vous dépensez du Sang pour activer Célérité, votre initiative augmente de la somme de tous les niveaux de Célérité possédés, y compris vos pouvoirs de Célérité d’anciens et les techniques basées sur la Célérité."},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_1_FOCUS_DESCRIPTION", Text = null},

                new Traduction{LCID = 1036, Key = "CELERITY_POWER_2_NAME", Text = "Vivacité"},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_2_DESCRIPTION", Text = "<i>Votre corps répond si rapidement que le monde semble ralentir autour de vous. Vous pouvez utiliser ce temps supplémentaire pour viser votre cible, augmentant ainsi votre précision avec les armes à distance.</i>"},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_2_SYSTEM", Text = "Quand vous faîtes une attaque à distance, vous avez un bonus de +5 pour déterminer si oui ou non vous allez faire un Succès Exceptionnel. De plus, quand vous esquivez, vous recevez un bonus de +5 sur votre Score de Test pour comparer les attributs afin de déterminer si votre attaquant a fait un succès exceptionnel."},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_2_FOCUS_DESCRIPTION", Text = null},

                new Traduction{LCID = 1036, Key = "CELERITY_POWER_3_NAME", Text = "Rapidité"},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_3_DESCRIPTION", Text = "<i>Vous pouvez vous déplacer plus vite qu’il n’est humainement possible. Avant qu’un humain n’ait le temps de bouger ou même prendre une inspiration, vous agissez pour la seconde fois.</i>"},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_3_SYSTEM", Text = "Quand vous activez Célérité, vous gagnez un round supplémentaire d’actions (une action simple et une action standard). Résolvez ces actions durant le premier round de Célérité."},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_3_FOCUS_DESCRIPTION", Text = null},

                new Traduction{LCID = 1036, Key = "CELERITY_POWER_4_NAME", Text = "Légèreté"},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_4_DESCRIPTION", Text = "<i>À cette vitesse, vous pouvez vous déplacer plus vite que ce que l’œil humain peut percevoir. Vous êtes flou pour ceux n’ayant pas ce pouvoir et votre vitesse incroyable vous procure du temps pour vous focaliser, viser et tirer.</i>"},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_4_SYSTEM", Text = "Tous vos Scores de Test défensifs basés sur l’Esquive reçoivent un bonus de +2 tant que Célérité est actif. Ce bonus se cumule avec le bonus de +2 donné par le Focus : Dextérité.De plus, quand vous faîtes un Succès Exceptionnel sur une attaque à distance normale(sans qu’une discipline surnaturelle ne soit impliquée) lorsque Célérité est active, votre personnage inflige 2 points de dégâts supplémentaires au lieu d’un seul."},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_4_FOCUS_DESCRIPTION", Text = null},

                new Traduction{LCID = 1036, Key = "CELERITY_POWER_5_NAME", Text = "Fluidité"},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_5_DESCRIPTION", Text = "<i>Vous pouvez devenir une vraie tornade, vous déplaçant avec une vitesse surnaturelle. Vos attaques sont un flou de mouvement permanent. En combat, vous êtes si rapide qu’on dirait que vous clignotez, apparaissant et disparaissant au moindre clignement d’œil.</i>"},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_5_SYSTEM", Text = "Quand vous activez Célérité, vous gagnez un round supplémentaire d’actions (une action simple et une action standard). Résolvez ces actions durant le second round de Célérité."},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "CELERITY_POWER_5_FOCUS_DESCRIPTION", Text = null},
                new Traduction{LCID = 1036, Key = "CELERITY_TEST_SCORE", Text = "Il n’y a pas de Score de Test standard pour la Célérité."}

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "CELERITY_KEY",
                    DisciplineName = "CELERITY_NAME",
                    Description = "CELERITY_DESCRIPTION",
                    TestScore = "CELERITY_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class ChimestryInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "CHIMERSTRY_POWER_1_NAME", Description = "CHIMERSTRY_POWER_1_DESCRIPTION", System = "CHIMERSTRY_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "CHIMERSTRY_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "CHIMERSTRY_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "CHIMERSTRY_NAME" },
                new Power { Level = 2, PowerName = "CHIMERSTRY_POWER_2_NAME", Description = "CHIMERSTRY_POWER_2_DESCRIPTION", System = "CHIMERSTRY_POWER_2_SYSTEM", Focus = focus[4], FocusEffect = "CHIMERSTRY_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "CHIMERSTRY_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "CHIMERSTRY_NAME" },
                new Power { Level = 3, PowerName = "CHIMERSTRY_POWER_3_NAME", Description = "CHIMERSTRY_POWER_3_DESCRIPTION", System = "CHIMERSTRY_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "CHIMERSTRY_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "CHIMERSTRY_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "CHIMERSTRY_NAME" },
                new Power { Level = 4, PowerName = "CHIMERSTRY_POWER_4_NAME", Description = "CHIMERSTRY_POWER_4_DESCRIPTION", System = "CHIMERSTRY_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "CHIMERSTRY_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "CHIMERSTRY_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "CHIMERSTRY_NAME" },
                new Power { Level = 5, PowerName = "CHIMERSTRY_POWER_5_NAME", Description = "CHIMERSTRY_POWER_5_DESCRIPTION", System = "CHIMERSTRY_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "CHIMERSTRY_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "CHIMERSTRY_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "CHIMERSTRY_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_NAME", Text = "Chimérie"},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_DESCRIPTION", Text = "Les illusions chimériques sont façonnées à partir de la substance des rêves, une essence quasi-substantielle que les membres du clan de Ravnos appellent maya. Les objets fabriqués avec ce pouvoir ne sont pas réels, mais ils ne sont pas non plus entièrement insubstantiels, car ils sont formés de la substance physique du rêve. Un pistolet chimérique a le poids approprié. Un drapeau chimérique se balancera dans le vent et projettera une ombre. Cependant, si un élément chimérique est discrédité, il perd toutes ses qualités physiques − mais seulement pour l’individu qui réussit à le discréditer. <br /> Une construction Chimérique ne peut physiquement rien dévier de plus substantiel qu’une lumière vive ou une légère brise. Les objets ou créatures fabriqués avec ce pouvoir ne peuvent pas causer de dommages. Une armure chimérique n’arrête pas les balles et une épée chimérique ne peut rien couper. <br /> Une des choses les plus importantes à retenir sur la Chimérie est ceci : les illusions peuvent ajouter des choses au monde, mais elles ne peuvent jamais en soustraire. Un personnage pourrait créer un mur chimérique et se cacher derrière lui, mais il ne pourrait pas utiliser ce pouvoir pour créer un trou dans le sol, tout comme Chimérie ne peut pas \"soustraire\" la saleté qui est présente.Un personnage ne peut pas utiliser Chimérie pour rendre des objets ou des personnes invisibles, ni pour dupliquer les pouvoirs d’Occultation.Cependant, vous pouvez utiliser Chimérie pour créer un seau chimérique pour couvrir un élément et ainsi le cacher.Ce pouvoir ne peut pas altérer l’apparence générale d’un personnage, comme Masque aux mille visages, mais elle peut changer la couleur d’un trenchcoat du rouge au bleu. <br /> Chimérie est fait de maya semi-tangible, mélangé à la volonté de l’esprit de croire ce qu’il peut percevoir.Un mur illusoire peut bloquer vos progrès, mais il n’est pas assez substantiel pour soutenir plus de quelques onces de poids. Un individu est bloqué par un mur chimérique en grande partie parce que son esprit ne lui permettra pas de passer cette barrière.Cependant, si une personne qui tombe attrape une corde illusoire, elle ne parvient pas à soutenir son poids. <br /> <strong>Chimérie Discréditée</strong> Reconnaître que quelque chose est chimérique n’est pas la même chose que de ne pas croire l’illusion. Pour ne pas croire une construction, il faut une tentative active pour détruire la création chimérique, représentée par un test de volonté avec le créateur de l’illusion. Il est possible de se rendre compte qu’une illusion est fausse, mais y croire quand même. L’esprit subconscient du sujet ne peut tout simplement pas accepter que cette construction n’est pas réelle. De cette manière, si un personnage voit une épée chimérique passer inoffensivement à travers un objet, elle peut réaliser que l’épée est une illusion. Cependant, l’épée existera toujours et semblera encore réelle, à moins qu’un personnage choisisse de ne pas croire activement et de vaincre le créateur de l’objet dans un test de volonté. <br /> Si un personnage soupçonne que quelque chose est créé par de la Chimérie, il peut faire une tentative active de ne pas croire cette illusion. Pour ce faire, il doit dépenser son action simple et entrer dans un test de volonté avec le créateur de l’illusion. Faites un test opposé en utilisant votre attribut <i>Social + Volonté</i> contre l’attribut <i>Social + Subterfuge</i> de l’utilisateur de Chimérie. Si la tentative de discrédit réussit, l’illusion devient une ombre semi-transparente d’elle-même. Les personnages ne peuvent pas interagir avec des objets qu’ils ont discrédité. <br /> Par exemple, après avoir discrédité un mur chimérique, un personnage peut le voir clairement et peut se déplacer au milieu du mur sans problème. Après avoir discrédité une épée illusoire, le personnage est incapable de la ramasser ; elle passera au travers de sa main s'il essaie. <br /> Si un personnage réussit à discréditer une illusion, les autres personnes ne remarqueront aucun changement dans cette illusion.Même si le personnage voit quelqu’un marcher au milieu d’un mur illusoire, il doit faire un test séparé et réussir à ne pas le croire pour marcher au travers du mur lui-même.S’il ne parvient pas à discréditer la Chimérie, il doit traiter ce mur comme s’il était réel et doit l’abattre ou le contourner pour passer. <br /> Si un personnage réussit à discréditer une illusion chimérique puis fait quelque chose pour démontrer que l’illusion n’est pas réelle, comme marcher dans un mur chimérique, il fournit une excellente occasion pour d’autres observateurs de réaliser que l’illusion n’est pas réelle et de faire leur propres tests de discrédit.Si une personne échoue à tenter de discréditer une illusion, elle ne peut pas tenter de discréditer cette illusion à nouveau pendant cinq minutes.Si le créateur d’une illusion ne croit pas à sa propre illusion, elle cesse immédiatement d’exister.L’utilisateur doit traiter ses illusions comme si elles étaient réelles ou le maya se fane.<br /> <strong>Chimérie et Auspex</strong> : Un vampire utilisant Auspex peut tenter d’utiliser ses sens aiguisés pour percer une illusion créée par Chimérie. L’utilisateur d’Auspex doit utiliser son action simple pour effectuer un test en utilisant son attribut Mental + Investigation contre l’attribut Social + Volonté de l’utilisateur de Chimérie. L’utilisateur de Chimérie peut choisir d’utiliser son attribut Social + Subterfuge comme test défensif plutôt que son attribut <i>Social + Volonté</i>. Si l’utilisateur d’Auspex réussit, il discrédite l’illusion. <br /> <strong>Chimérie et Lumiére du soleil</strong> : Si elle est exposée à la lumière du soleil, la Chimérie est instantanément dissipée. La lumière du soleil produite technologiquement ou la lumière ultraviolette ne dissipent pas Chimérie. <br /><strong>Chimérie et Enregistrement</strong> : Chimérie a suffisamment de substance matérielle pour être enregistrée par l’électronique, mais ces enregistrements ne durent pas. Au début, ces enregistrements sont parfaits, mais la qualité de l’illusion capturée se détériore rapidement. Après 10 minutes, un enregistrement de Chimérie perd de sa substance, en acquérant des défauts et de la détérioration. Les bruits chimériques sonnent faiblement et faux ; les clichés ou les enregistrements visuels ressemblent à des CGI mal conçus."},

                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_1_NAME", Text = "Ignis Fatuus"},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_1_DESCRIPTION", Text = "<i>Maya est une substance délicate, tissée comme un fil de tulle de la substance des rêves mortels. Vous pouvez tisser une illusion simple à partir de ce matériau délicat, le rendant assez réel pour tromper un seul sens.</i>"},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_1_SYSTEM", Text = "En dépensant 1 point de sang et en utilisant votre action standard, vous créez une illusion sensorielle insubstantielle. Les illusions créées avec Ignis Fatuus ne peuvent affecter que l’un des sens suivants : la vue, l’ouïe, l’odorat ou le goût. Avec ce pouvoir, vous pourriez produire un bruit énorme pour faire distraction, donner à une lettre la douce odeur d’un parfum, ou lire à la lumière d’une bougie chimérique.Ces illusions sont incapables de mouvement ou de changement une fois qu’elles ont été créées. Les illusions créées avec Ignis Fatuus durent jusqu’à un tour par niveau de la compétence Subterfuge que vous possédez.<br /> Un personnage utilisant Ignis Fatuus au combat peut distraire et étourdir ses adversaires avec une fausse émotion sensorielle. Pour ce faire, vous devez payer les coûts de ce pouvoir et ensuite faire un test opposé en utilisant le Score de Test de Chimérie. En cas de succès, votre cible est momentanément distraite et perd son action simple la prochaine fois que son initiative est utilisée.Cette utilisation d’Ignis Fatuus repose sur la surprise et, par conséquent, ne peut pas être utilisée sur une personne spécifique plus d’une fois par combat."},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_1_EXCEPTIONALSUCCESS", Text = "Si vous obtenez un succès exceptionnel avec Ignis Fatuus, votre cible perd ses deux prochaines actions standard et simples."},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_1_FOCUS_DESCRIPTION", Text = "Ceux affectés par votre utilisation d’Ignis Fatuus ne peuvent pas utiliser les manœuvres de combat pour le reste du tour, y compris tous les rounds de ce tour."},

                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_2_NAME", Text = "Fata Morgana"},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_2_DESCRIPTION", Text = "<i>Votre contrôle sur les fils de maya a augmenté au point que vos illusions peuvent tromper tous les sens à la fois. Bien que vous ayez à ancrer ces illusions plus substantielles dans la réalité, elles ont une profondeur et une stabilité beaucoup plus grandes.</i>"},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_2_SYSTEM", Text = "Utilisez votre action standard pour modifier l’apparence d’un objet inanimé. Mirage ne peut pas être utilisé sur des créatures ou des individus. Rappelez-vous que Chimérie peut être utilisé pour ajouter à un élément, ou pour couvrir ce qui est déjà là, mais il ne peut pas être utilisé pour soustraire quelque chose de l’élément ou de l’environnement. Vous ne pouvez pas utiliser ce pouvoir pour réduire la taille d’un objet, mais vous pouvez augmenter sa taille jusqu’à 10%. Vous pouvez modifier la façon dont les gens voient l’objet, les odeurs, les sons, les goûts ou les sentiments − ou tout en même temps. Vous pouvez faire paraître une chaise en lambeaux comme un trône opulent, faire qu’un verre d’eau semble être un grand millésime ou changer une civière roulante en une table d’acajou couverte de bougies. Cette illusion durera jusqu’à une heure.<br /> Les utilisateurs de Mirage doivent couvrir complètement l’objet qu’ils modifient ; toute partie de la fondation qui n’est pas couverte sera visible à travers l’illusion.Par exemple, vous pouvez faire ressembler une civière à une table d’acajou, mais vous ne pouvez pas faire en sorte qu’un meuble classeur ressemble à une table − le corps solide du meuble classeur serait visible entre les jambes de la table. Vous pourriez, cependant, faire du meuble classeur une table avec une nappe accrochée au sol, couvrant ainsi l’intégralité du meuble classeur.<br /> Mirage ne peut pas être utilisé pour modifier l’apparence des individus vivants ou morts-vivants, car c’est le domaine de la discipline d’Occultation. Il peut être utilisé pour apporter des modifications simples aux vêtements, comme la couleur, le matériau ou la qualité générale."},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_2_FOCUS_DESCRIPTION", Text = "Quiconque tente de ne pas croire votre utilisation de Mirage souffre d’une pénalité -3 à son test pour décrédibiliser."},

                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_3_NAME", Text = "Apparition"},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_3_DESCRIPTION", Text = "<i>Non plus limitées par les frontières de la réalité, vos illusions sont des inventions indépendantes du rêve. Ils se déplacent comme vous les dirigez, soit dans une boucle de répétition, soit en suivant vos instructions continues, étape par étape. Vous pouvez donner à vos illusions un semblant de vie, faisant se déplacer ou parler des êtres illusoires, goutter et onduler de l’eau illusoire et passer d’une chanson à une autre une musique illusoire.</i>"},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_3_SYSTEM", Text = "Dépensez 1 point de sang et utilisez votre action standard pour créer une illusion indépendante qui semble réelle à tous les sens. Cette illusion peut se déplacer soit dans une boucle prédéterminée, soit, par une concentration continue du créateur, peut changer comme il le souhaite.Un feu d’artifice peut dévier de trajectoire et changer de couleur, un policier illusoire peut sembler marcher à son rythme autour d’un bloc et ainsi de suite. Les objets illusoires semblent remplir leurs fonctions standard; un fusil illusoire peut armer son chien ou tirer une balle illusoire(qui ne cause aucun dommage) et un moteur illusoire peut être démonté et réassemblé.<br /> De plus, vos Apparitions réagiront automatiquement lorsqu’elles interagissent avec des forces ou des obstacles externes.Un drapeau chimérique soufflera dans le vent et une personne chimérique contournera un objet solide placé sur son chemin.<br /> Lorsque vous créez une Apparition, vous déterminez un modèle simple d’actions pour que l’illusion les mette en œuvre, comme la marche décontractée habituelle d’un flic de proximité dans le quartier.Par la suite, vous pouvez dépenser une action simple pour modifier l’activité de votre illusion pour un round, peut - être faire arrêter le flic de proximité afin d’avoir une brève conversation avec quelqu’un(dépenser une action simple pour chaque round pendant lequel vous le faites rester immobile et parler ou écouter).Si vous dépensez une action standard au lieu d’une simple action, vous pouvez ajouter, supprimer ou faire un changement permanent dans les motifs préétablis de l’Apparition, comme faire en sorte que le flic s’arrête et siffle une brève note chaque fois qu’il atteint un certain coin dans son parcours routinier.<br /> De telles altérations au modèle de l’Apparition sont accomplies silencieusement, par un acte de concentration du créateur de l’illusion.Notez que votre personnage ne reçoit aucune capacité spéciale de voir ou d’entendre via son Apparition. Si le créateur du flic ne peut pas entendre les questions posées par la personne parlant avec son policier illusoire, il ne peut pas ordonner au policier de répondre correctement.<br /> Apparition ne peut pas être utilisé pour faire une illusion avec une masse totale supérieure à 10 pieds cubes, bien que la masse puisse être façonnée de la manière que vous choisissez. Des illusions de créatures ou d’individus peuvent se déplacer, selon leur type de créature. Par exemple, un flic illusoire peut marcher en avant et en arrière dans une rue.<br /> Apparition dure une heure, à moins que le pouvoir ne soit arrêté par son créateur, ou que le créateur meure."},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_3_FOCUS_DESCRIPTION", Text = "Vous pouvez dépensez une action simple pour configurer une réponse déclenchée pour votre apparition. Vous pouvez créer un enfant illusoire, lisant un livre dans le coin de votre havre et lui donner pour instruction de lever les yeux et dire « bonjour » quand quelqu’un entre dans la pièce ou quand une personne spécifique entre dans la pièce. Chaque Apparition ne peut maintenir qu’un déclencheur à la fois, mais les actions pré-arrangées se produiront à chaque fois que l’élément déclencheur se produira. En utilisant l’exemple ci-dessus, l’enfant illusionniste dira « bonjour » à tous ceux qui entrent dans la pièce jusqu’à ce que vous modifiiez le modèle."},

                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_4_NAME", Text = "Permanence"},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_4_DESCRIPTION", Text = "<i>Les illusions que vous créez ont presque leur vie propre, existant sans votre concentration et le maintien d’une existence continue en s’appuyant sur l’essence du rêve. Vous pouvez doter vos simples illusions de cette capacité, leur fournissant une durée de vie pouvant surpasser la vôtre.</i>"},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_4_SYSTEM", Text = "Dépensez 1 point de sang et utilisez votre action simple pour rendre permanent un Mirage ou une Apparition déjà créé. L’illusion durera jusqu’à ce que vous choisissiez de la dissiper, jusqu’à ce qu’elle soit irrévocablement incapable de continuer, ou jusqu’à ce qu’elle soit soumise à la lumière du soleil. Une illusion permanente est irrévocablement incapable de continuer si elle est vraisemblablement détruite, par exemple en jetant un pistolet chimérique dans un bassin de métal fondu, ou si la route du flic est complètement bloquée par un gros tracteur-remorque."},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_4_FOCUS_DESCRIPTION", Text = "Lorsque vous activez Permanence, vous pouvez passer trois tours complets pour éviter de payer le coût du sang de ce pouvoir ou vous pouvez dépenser un point de Sang supplémentaire pour activer Permanence sans utiliser une action."},

                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_5_NAME", Text = "Réalité monstrueuse"},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_5_DESCRIPTION", Text = "<i>La croyance est une chose tangible, capable de choses presque miraculeuses. Vous pouvez transformer le rêve en réalité, apportant une authentique vraisemblance à vos créations imaginaires. Vos fantasmes obtiennent une réalité tangible et sont capables d’interagir avec le monde réel de façon concrète - même causer des dommages à vos ennemis, si vous le souhaitez.</i>"},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_5_SYSTEM", Text = "Dépensez 1 point de sang et dépensez votre action simple pour augmenter une de vos apparitions déjà existante avec Réalité monstrueuse. Pour les cinq prochaines minutes, cette illusion ne peut pas être discréditée et est imprégnée du pouvoir d’interagir physiquement avec les gens. Une illusion crédibilisée grâce à la Réalité monstrueuse ne peut pas interagir avec des objets inanimés, mais peut causer des dommages durables aux mortels, aux créatures surnaturelles et aux animaux.<br /> Les Apparitions qui ont été augmentées par Réalité monstrueuse peuvent être utilisées pour attaquer, soit par des moyens secondaires (comme le tir d’un pistolet chimérique), soit comme un attaquant principal − l’illusion du flic de proximité se fend et frappe avec sa matraque. Dans les deux cas, le personnage qui a créé l’Apparition augmentée est l’attaquant réel et l’attaque se produit sur l’initiative de ce personnage dans un round.<br /> Pour attaquer avec une Apparition augmentée par la Réalité monstrueuse, dépensez votre action standard et faites un test opposé contre une seule cible, en utilisant votre Attribut Social + Subterfuge contre Physique + Esquive de la cible. En cas de succès, votre cible subit des dégâts de l’objet ou créature créé avec ce pouvoir. Réalité monstrueuse ne peut pas être utilisée pour infliger des conditions de victoire autres que des dommages.<br /> Les dégâts infligés par l’utilisation de Réalité monstrueuse reflètent le mode d’attaque apparent de l’illusion et infligent 3 points de dégâts normaux ou 2 points de dégâts aggravés. Un officier de police illusoire tirant au pistolet ou utilisant un mousqueton inflige un maximum de 3 points de dégâts normaux, tandis qu’un lance-flammes illusoire inflige un maximum de 2 points de dégâts aggravés. Force d’Âme (et les pouvoirs semblables) peuvent réduire les dommages infligés par la Réalité monstrueuse.<br /> Même si l’illusion semble affecter plusieurs personnes ou objets, comme l’illusion d’un lance-flammes, la Réalité monstrueuse ne peut causer des dommages qu’à une cible à la fois. Cette limitation n’interdit pas les problèmes normaux causés par une telle Apparition. Si vous brûlez trois individus dans un jet de lance-flammes de Réalité monstrueuse, choisissez une personne potentiellement nuisible qui prendra les dégâts. Les deux autres peuvent encore entrer en frénésie à cause du feu. Ils ne peuvent cependant pas être endommagés par cette attaque.<br /> Les individus, créatures ou objets créés avec ce pouvoir ont un nombre maximal de niveaux de santé égal à vos points dans Subterfuge, 1 point au minimum. Vous pouvez créer un objet avec moins de niveaux de santé (un morceau illusoire de papier ne serait pas crédible si il avait 5 niveaux de santé). Les illusions chimériques ne peuvent pas vous empêcher directement d’être blessé. Un mur chimérique ne peut pas arrêter une balle.<br /> Une fois que la Réalité monstrueuse a été utilisée pour augmenter une Apparition, l’illusion augmentée peut attaquer une cible à plusieurs reprises ; il s’agit d’une exception à la règle interdisant à un personnage d’utiliser un pouvoir social sur la même cible immédiatement après l’échec. Si vous échouez à une attaque Réalité monstrueuse contre un adversaire, vous pouvez essayer de nouveau contre ce même adversaire, ou quelqu’un d’autre, au tour suivant.<br /> Lorsque vous utilisez un élément créé par Réalité monstrueuse ou créez un individu illusoire, les attaques sont précisément synchronisées avec la volonté du créateur ; c’est pourquoi les Apparitions augmentées avec Réalité monstrueuse ne peuvent être utilisées par personne d’autre que leur créateur.Si vous donnez une arme illusoire augmentée à un autre individu, elle perd son potentiel de causer des dégâts.<br /> Une Apparition augmentée ne peut pas attaquer pendant les rounds de Célérité, même si c’est une arme utilisée pendant les rounds de Célérité.<br /> Les effets nuisibles de la Réalité monstrueuse sont fugaces, car ils sont basés dans la substance du rêve.Les dommages causés par Réalité monstrueuse peuvent plonger un individu dans l’inconscience ou dans la torpeur, mais ils ne peuvent pas tuer. Après cinq minutes, les effets de Réalité monstrueuse s’effacent; les blessures disparaissent et les individus inconscients ou en torpeur se réveillent."},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_5_EXCEPTIONALSUCCESS", Text = "Les attaques de votre Réalité monstrueuse infligent soit 4 points de dégâts normaux, soit 3 points de dégâts aggravés, selon le mode d’attaque de l’illusion."},
                new Traduction{LCID = 1036, Key = "CHIMERSTRY_POWER_5_FOCUS_DESCRIPTION", Text = "Si vous dépensez vos actions simples et standard pour votre Réalité monstrueuse pour attaquer, vous pouvez appliquer une manœuvre de combat, tant que la manœuvre s’appliquerait logiquement au mode d’attaque. Par exemple, votre flic illusoire peut essayer d’agripper votre ennemi ou de planter un pieu en bois dans son cœur. Cet effet ne contourne pas les conditions normales d’utilisation d’une manœuvre de combat ; votre cible doit être dans la piste de la blessure Invalide avant que vous puissiez tenter de la pieuter avec Réalité monstrueuse. Les effets du pieutage(ou d’agripper) sont fugaces et, comme les dégâts de Réalité monstrueuse, se fanent après cinq minutes. Un personnage agrippé par une apparition augmentée peut s’échapper en dépensant une action simple et en faisant un test opposé en utilisant son attribut <i>Physique + Bagarre</i> ou <i>Mêlée</i> contre votre attribut <i>Social + Subterfuge</i>."},

                new Traduction{LCID = 1036, Key = "CHIMERSTRY_TEST_SCORE", Text = "Le créateur d’une Chimérie utilise son Attribut <i>Social + Subterfuge</i> contre l’Attribut <i>Social + Volonté</i> de sa cible."},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "CHIMERSTRY_KEY",
                    DisciplineName = "CHIMERSTRY_NAME",
                    Description = "CHIMERSTRY_DESCRIPTION",
                    TestScore = "CHIMERSTRY_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class DaimoinonInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "DAIMOINON_POWER_1_NAME", Description = "DAIMOINON_POWER_1_DESCRIPTION", System = "DAIMOINON_POWER_1_SYSTEM", Focus = focus[6], FocusEffect = "DAIMOINON_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "DAIMOINON_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "DAIMOINON_NAME" },
                new Power { Level = 2, PowerName = "DAIMOINON_POWER_2_NAME", Description = "DAIMOINON_POWER_2_DESCRIPTION", System = "DAIMOINON_POWER_2_SYSTEM", Focus = focus[7], FocusEffect = "DAIMOINON_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "DAIMOINON_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "DAIMOINON_NAME" },
                new Power { Level = 3, PowerName = "DAIMOINON_POWER_3_NAME", Description = "DAIMOINON_POWER_3_DESCRIPTION", System = "DAIMOINON_POWER_3_SYSTEM", Focus = focus[7], FocusEffect = "DAIMOINON_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "DAIMOINON_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "DAIMOINON_NAME" },
                new Power { Level = 4, PowerName = "DAIMOINON_POWER_4_NAME", Description = "DAIMOINON_POWER_4_DESCRIPTION", System = "DAIMOINON_POWER_4_SYSTEM", Focus = focus[6], FocusEffect = "DAIMOINON_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "DAIMOINON_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "DAIMOINON_NAME" },
                new Power { Level = 5, PowerName = "DAIMOINON_POWER_5_NAME", Description = "DAIMOINON_POWER_5_DESCRIPTION", System = "DAIMOINON_POWER_5_SYSTEM", Focus = focus[6], FocusEffect = "DAIMOINON_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "DAIMOINON_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "DAIMOINON_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "DAIMOINON_NAME", Text = "Daemonium"},
                new Traduction{LCID = 1036, Key = "DAIMOINON_DESCRIPTION", Text = "Subtils, puissants et tout à fait mauvais, les pouvoirs de Daemonium sont la discipline signature des Baali. Cette discipline a été perfectionnée dans les fosses sacrificielles les plus profondes et les donjons les plus tortueux de l’Âge des ténèbres et transmet ces horreurs dans l’âge moderne. Ce sont les dons noirs du mal, arrachés des langues des rois sorciers et déverrouillés dans le cœur vicieux et corrompu des traîtres. Les personnages qui apprennent Daemonium s'ouvrent aux chuchotements et à la persuasion subconsciente des entités infernales. Toutes pensées et ambitions deviennent suspectes et il est difficile même pour cette personne de juger si elle agit de son propre gré. Chaque point de Daemonium qu’un personnage apprend corrompt l’âme de l’individu. Chaque fois qu’un pouvoir Daemonium est utilisé, une tache infernale submerge l’aura de l’utilisateur puis disparaît. Apprendre les 4 premiers points de Daemonium indique que le personnage est corrompu par les forces infernales et il est incontestable qu’elle utilise une puissance totalement et indiscutablement démoniaque. Un personnage doit faire un pacte délibéré avec une créature infernale pour apprendre le 5ème point de Daemonium : soit en conquérant cette entité et en en devenant maître, soit en la vénérant et enrejoignant sa cause comme un allié volontaire. Indépendamment de la façon dont ce pacte est atteint, le personnage est totalement et irréductiblement infernaliste.Seuls ceux qui concluent un tel pacte peuvent acquérir le 5ème point de Daemonium."},

                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_1_NAME", Text = "Sentir le péché"},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_1_DESCRIPTION", Text = "<i>L'ennemi le plus dangereux est, bien sûr, celui au sein de votre propre esprit. En parlant avec un individu, l’utilisateur de ce pouvoir peut découvrir ses vices les plus profonds, révélant ses faiblesses spirituelles à la perception vive de l’utilisateur.</i>"},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_1_SYSTEM", Text = "Dépensez 1 point de sang et utilisez votre action standard pour regarder dans l’âme de votre cible. Vous devez faire un challenge opposé à votre cible, en utilisant le Score de Test de Daemonium. Si vous réussissez, vous découvrez combien de traits de Bête la cible possède actuellement, ainsi que le niveau actuel de sa Moralité. De plus, vous découvrirez exactement comment votre cible a gagné chaque trait de Bête qu’elle possède : spécifiquement, quand, où, dans quelles circonstances et pour quelle raison."},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_1_EXCEPTIONALSUCCESS", Text = "Vous pouvez lire l’esprit de votre cible pour le reste de la nuit, sans autre défi. Chaque fois que vous la voyez, vous pouvez réexaminer son âme et découvrir si tout ce que vous avez appris au début a changé. Si oui, vous découvrez la nature de cette nouvelle altération, selon une utilisation standard de Sentir le péché."},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_1_FOCUS_DESCRIPTION", Text = "Si votre cible n’a actuellement aucun trait de bête, vous apprenez plutôt la date approximative de la dernière fois que votre cible a gagné les traits de Bête et pourquoi ces traits ont été gagnés."},

                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_2_NAME", Text = "Peur du vide abyssal"},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_2_DESCRIPTION", Text = "<i>Ceux qui apprennent les pouvoirs de Daemonium commencent à voir les âmes des autres comme des objets à enchaîner, échanger et utiliser pour leur propre ambition ou amusement. Avec ce pouvoir, l’utilisateur lie la parole donnée ou la promesse d’une cible à sa terreur primitive de destruction finale. Ceux qui concluent un tel contrat savent instinctivement et totalement que briser une promesse liée par ce pouvoir signifie sacrifier une partie de leur âme au vide abyssal.</i>"},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_2_SYSTEM", Text = "Quand un autre personnage vous fait une promesse, vous pouvez dépenser 1 Sang et utiliser une action standard pour lier cette promesse avec Peur du vide abyssal. Si votre cible rompt ensuite la promesse liée par ce pouvoir, elle doit contester cette rupture contre les entités infernales de l’enfer ou être punie par leur châtiment. L’activation de ce pouvoir nécessite un test opposé de Trait de Challenge Daemonium. La cible doit faire la promesse de sa propre volonté et elle ne peut être forcée par la menace ou par l’utilisation de pouvoirs surnaturels. En outre, les manquements à cette promesse doivent être volontaires et ne peuvent pas être contraints de la même façon.<br /> Si une personne liée par la peur du vide abyssal est dominée (ou autrement surnaturellement forcée) de briser sa promesse, Peur du vide abyssal n’est pas déclenchée. Si la cible rompt par la suite la promesse de sa propre volonté, Peur du vide abyssal prendra son dû, selon les effets normaux de ce pouvoir. De plus, si un individu lié par votre Peur du vide abyssal est surnaturellement forcé de rompre la promesse, vous êtes immédiatement conscient des circonstances dans lesquelles la cible a été forcée de renier sa parole.<br /> Une personne qui rompt volontairement une promesse liée par Peur du vide abyssal doit faire un test statique en utilisant son attribut Mental + Survie contre une difficulté égale à votre attribut <i>Mental + Erudition</i>. Parce que c'est un test statique et comme votre personnage n’est pas directement impliqué, vous ne pouvez pas utiliser de retests. Votre victime peut retest, comme prévu pour un test statique normal. Si votre victime perd le test, elle perd un point de Volonté et doit immédiatement répéter le test. Perdre de nouveau entraîne la perte d’un autre point de Volonté et un autre test statique. Cette chaîne de tests statiques se poursuit jusqu'à ce que la cible gagne un test (Par égalité ou en gagnant les tests appropriés) ou jusqu'à ce que la cible épuise sa Volonté. Si les effets de Peur du vide abyssal font qu’un personnage perd de la Volonté quand elle n’a pas de Volonté restante, les esprits infernaux descendent. L'âme de la cible est tirée hors de son corps et traînée pour toujours dans l’enfer. Le personnage meurt immédiatement.Un tel personnage ne peut jamais être ressuscité(pas même temporairement) et aucun pouvoir ou capacité surnaturelle ne peut entrer en contact avec l’âme maudite.<br /> Une promesse liée par Peur du vide abyssal doit être explicite.La cible doit parler à haute voix, en disant quelque chose d’aussi direct et clair que <i>«Je promets de ne jamais dire à personne votre nom »</i>, ou <i>«Je jure de ne jamais vous attaquer»</i> ou <i>«Parole d’honneur, je vais toujours vous dire la vérité»</i>. Peur du vide abyssal ne peut pas être utilisé pour faire valoir des déclarations vagues, des affirmations confirmatives ou des accords généraux tels que: <i>«Bien sûr»</i>, <i>«Je suis d’accord»</i> ou <i>«Comme vous dites.»</i>. Peur du vide abyssal ne peut pas être utilisé pour faire respecter des promesses faites à plusieurs personnes, comme celles faites dans un discours public, mais uniquement des promesses qui vous sont faites directement et individuellement.Par exemple, si un politicien a annoncé sa promesse de campagne pour «mettre un poulet dans chaque pot», vous ne pouvez pas faire respecter cette promesse.Vous pourriez, bien sûr, rencontrer l’homme politique plus tard et lui demander de vous faire cette promesse personnellement - et ensuite utiliser Peur du vide abyssal sur cette obligation faite personnellement.<br /> Une fois utilisé, ce pouvoir persistera pendant deux parties ou un mois, selon la plus longue durée entre les deux possibilités.Après la fin de cette durée, le sujet est libre de rompre sa promesse sans crainte de représailles et la crainte instinctive de le faire se dissipera et ne le hantera plus."},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_2_EXCEPTIONALSUCCESS", Text = null },
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_2_FOCUS_DESCRIPTION", Text = "Si votre cible rompt sa promesse, elle perd 1 point de Volonté avant de faire son premier test contre Peur du vide abyssal."},

                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_3_NAME", Text = "Conflagration"},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_3_DESCRIPTION", Text = "<i>Tous les pouvoirs de Daemonium ne sont pas subtils. Certains sont destinés à marquer la peur dans l’innocent, à insuffler la menace de la douleur et de la destruction à ceux qui défient votre volonté. En invoquant ce pouvoir, l’usager appelle le feu vert brûlant des royaumes de ses protecteurs infernaux, exultant dans la cruauté des damnés.</i>"},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_3_SYSTEM", Text = "Dépensez 1 point de sang et utilisez votre action standard pour lancer une boule de flammes verte hideuse à votre cible. Ce feu est clairement d’origine infernale. Pour frapper votre ennemi avec le feu, vous devez gagner un test opposé à l’aide de votre attribut mental + Erudition par rapport à l’attribut physique de la cible + Esquive. Si vous réussissez, votre cible prend 2 points de dégâts aggravés, elle est consumée par la flamme damnée. Conflagration est un pouvoir mental et, en tant que tel, ne peut pas être utilisé pendant les rounds de célérité. Vous pouvez à plusieurs reprises activer Conflagration contre une cible ; c'est une exception à la règle qui interdit à un personnage d’utiliser un pouvoir mental sur la même cible immédiatement après un échec. Si vous échouez un test de Conflagration contre un adversaire, vous pouvez essayer de nouveau contre le même adversaire(ou quelqu'un d’autre) au tour suivant. Les flammes infernales de Conflagration sont fugaces et les incendies provoqués par l’usage de ce pouvoir se dissipent en trois tours."},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_3_EXCEPTIONALSUCCESS", Text = "La cible prend 3 points de dégâts aggravés au lieu des 2 standard."},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_3_FOCUS_DESCRIPTION", Text = "Vous pouvez utiliser Conflagration pendant les tours de Célérité."},

                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_4_NAME", Text = "Psychomachie"},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_4_DESCRIPTION", Text = "<i>Avec ce pouvoir effrayant, l’utilisateur de Daemonium combine sa capacité à lire les fautes spirituelles d’une victime avec sa capacité à rassembler l’énergie des plans infernaux. Psychomachie donne vie aux blessures psychologiques les plus profondes d’un individu, confrontant la cible aux parties les plus dangereuses, honteuses de son propre subconscient.</i>"},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_4_SYSTEM", Text = "Dépensez 1 point de sang et utilisez votre action standard pour faire un test opposé à votre cible, en utilisant le trait de Challenge de Daemonium. En cas de succès, une manifestation illusoire de l’angoisse et du péché de votre cible apparaît à portée de bras du sujet de votre pouvoir. Cette incarnation peut être le père abusif du sujet, un amant mort depuis longtemps, un épouvantail de l’enfance ou quelque autre manifestation de ses blessures intérieures. Quelle que soit sa forme, l’anima maléfique se tourne immédiatement vers votre cible et cherche à lui faire du mal. La cible de psychomachie peut interagir et être blessée par son anima maléfique comme s'il s'agissait d’une créature normale. Vous pouvez également voir la manifestation Psychomachie, mais vous ne pouvez pas interagir avec elle. Les autres personnes ne peuvent pas voir ou interagir avec cette incarnation spirituelle et n’ont aucun moyen de déterminer si elle est là ou de la cibler avec des attaques ou des pouvoirs. Une incarnation maléfique créée par Psychomachie est un PNJ de 5 points avec 10 points de sang. Il possède les pouvoirs Griffes Bestiales et Sens Intensifiés, mais n’a pas accès à d’autres pouvoirs d’Auspex ou de Protéisme. Il a des spécialisations de votre choix de deux des trois disciplines physiques standard (Puissance, Célérité et Force d’âme). En outre, vous pouvez sélectionner trois autres domaines de compétences que la manifestation possède. La psychomachie ne peut pas être activée pendant les tours de célérité, mais une incarnation maléfique possédant le focus Célérité peut entreprendre des actions physiques pendant les tours de célérité. Lorsque la psychomachie se termine, la manifestation se dissipe en une fumée nauséabonde, sulfureuse, que seuls votre cible et vous pouvez sentir. Cela se produit après cinq minutes, quand l’incarnation maléfique prend 5 points de dégâts, ou si votre cible est en torpeur ou rendue inconsciente. Vous ne pouvez avoir qu’une seule manifestation psychomachique active à la fois. Utiliser le pouvoir une seconde fois, même sur une autre cible, dissipe la première incarnation de ce pouvoir."},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_4_EXCEPTIONALSUCCESS", Text = "Votre Psychomachie possède 2 points de plus. Ils peuvent être utilisés pour acheter des disciplines ou des compétences."},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_4_FOCUS_DESCRIPTION", Text = "Quand vous créez votre Psychomachie, votre manifestation possède en plus 1 point de volonté, qu’elle peut dépenser normalement. De plus, vous pouvez donner jusqu'à 3 points supplémentaires de volonté en dépensant ce même montant de points de volonté lorsque vous créez l’anima maléfique. Il s'agit d’une exception à la règle qui empêche les PNJ d’avoir ou d’utiliser de la volonté."},

                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_5_NAME", Text = "Condamnation"},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_5_DESCRIPTION", Text = "<i>L'usager de ce pouvoir lance une malédiction sur une victime, invoquant le nom de son allié démoniaque pour investir la malédiction d’une autorité infernale. La légende indique que certains Baali manient des malédictions si ignobles que la victime est prête à se suicider plutôt que de faire face à une fatalité inévitable.</i>"},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_5_SYSTEM", Text = "Dépensez 1 point de sang et utilisez votre action standard pour maudire fortement votre cible. Faites un test opposé à votre cible, en utilisant le Trait de Challenge Daemonium. Si vous réussissez, vous maudissez le sujet avec l’un des blâmes suivants :<br /> • La victime ne peut pas dépenser de sang pour augmenter son attribut physique. <br /> • La cible subit une pénalité de -2 à un attribut de votre choix. <br /> • La cible subit une pénalité de -5 pour les Scores de Test impliquant une compétence de votre choix.<br /> • Chaque fois que la cible échoue à un test statique, elle subit automatiquement les résultats d’un échec critique.<br /> Les malédictions lancées par Condamnation durent pour le reste de la nuit. Aucun personnage ne peut être soumis à plus d’une utilisation de la Condamnation à la fois. Si une nouvelle malédiction est appliquée, l’ancienne disparaît. Les personnages qui possèdent la Condamnation sont infernalistes."},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "DAIMOINON_POWER_5_FOCUS_DESCRIPTION", Text = "Lorsque vous utilisez avec succès Condamnation, choisissez et appliquez deux des effets ci-dessus plutôt qu’un."},

                new Traduction{LCID = 1036, Key = "DAIMOINON_TEST_SCORE", Text = "L'utilisateur de Daemonium utilise <i>Mental + Érudition</i> contre <i>Mental + Volonté</i> de la cible."},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "DAIMOINON_KEY",
                    DisciplineName = "DAIMOINON_NAME",
                    Description = "DAIMOINON_DESCRIPTION",
                    TestScore = "DAIMOINON_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class DementationInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "DEMENTATION_POWER_1_NAME", Description = "DEMENTATION_POWER_1_DESCRIPTION", System = "DEMENTATION_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "DEMENTATION_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "DEMENTATION_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "DEMENTATION_NAME" },
                new Power { Level = 2, PowerName = "DEMENTATION_POWER_2_NAME", Description = "DEMENTATION_POWER_2_DESCRIPTION", System = "DEMENTATION_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "DEMENTATION_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "DEMENTATION_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "DEMENTATION_NAME" },
                new Power { Level = 3, PowerName = "DEMENTATION_POWER_3_NAME", Description = "DEMENTATION_POWER_3_DESCRIPTION", System = "DEMENTATION_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "DEMENTATION_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "DEMENTATION_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "DEMENTATION_NAME" },
                new Power { Level = 4, PowerName = "DEMENTATION_POWER_4_NAME", Description = "DEMENTATION_POWER_4_DESCRIPTION", System = "DEMENTATION_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "DEMENTATION_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "DEMENTATION_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "DEMENTATION_NAME" },
                new Power { Level = 5, PowerName = "DEMENTATION_POWER_5_NAME", Description = "DEMENTATION_POWER_5_DESCRIPTION", System = "DEMENTATION_POWER_5_SYSTEM", Focus = focus[3], FocusEffect = "DEMENTATION_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "DEMENTATION_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "DEMENTATION_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "DEMENTATION_NAME", Text = "Aliénation"},
                new Traduction{LCID = 1036, Key = "DEMENTATION_DESCRIPTION", Text = "L’Étreinte ravage les esprits des Malkaviens, tordant et brisant leur psyché, mais étend leur conscience à un point où génie et folie semblent proches. Ils deviennent des visionnaires, catalyseurs de changements et de folies, portant à la fois sagesse et démence dans leur éveil. Le pouvoir d’Aliénation, leur discipline de référence, porte cette folie encore plus loin, la répandant à travers le monde. Cette discipline ouvre les portes du subconscient et libère l’ego, dévastant la logique de la victime et la supplantant par le chaos.<br /> <strong>Dérangements</strong>: Un personnage doit avoir un Dérangement s’il désire acquérir des points en Aliénation.S’il ne possède aucun dérangement, alors le premier point d’Aliénation cause au personnage un Dérangement qui ne peut être supprimé.Le personnage ne gagne aucun Point d’Expérience pour ce Dérangement. Pour plus d’informations sur les Dérangements, reportez-vous au Chapitre : Atouts et Handicaps."},

                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_1_NAME", Text = "Passion"},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_1_DESCRIPTION", Text = "<i>Telle la ménade des temps anciens, vous pouvez élever les émotions à des sommets, faisant remonter les peurs, les désirs, le désespoir ou n’importe quelle envie irrépressible de votre cible à la surface. A l’inverse, vous pouvez aussi atténuer ces émotions, entraînant l’esprit dans un vide froid et rationnel.</i>"},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_1_SYSTEM", Text = "Dépensez 1 point de Sang, utilisez votre action standard et faites un challenge opposé d’Aliénation avec votre cible. En cas de succès, vous pouvez soit diminuer, soit élever ses émotions pendant une heure.<br /> Si vous choisissez d’élever ses émotions, alors elle ressentira un flux d’émotions − désir désespéré, anxiété, joie ou inquiétude − poussé à l’extrême. Elle doit dépenser 1 point de Volonté à chaque fois que quelque chose de surprenant ou de perturbant arrive. Si elle ne le fait pas, elle réagit de manière démesurée, soit en fuyant, soit en frappant la source de son trouble.<br /> Si vous choisissez d’atténuer ses émotions, la cible ressentira une perte de son empathie ; son esprit ralentit et ses réactions, quelles qu’elles soient, deviennent froides et insipides.Elle ne ressent aucune réponse à un stimulus émotionnel, tel que l’amour, la haine ou la peur.Elle est simplementvide, à un point que cela en devient déconcertant.Un personnage aux émotions atténuées doit dépenser 1 point de Volonté pour engager un combat ou réagir avec une grande conviction.Elle n’a cependant pas besoin de dépenser de la Volonté pour se joindre à un combat commencé ou  pour se défendre.<br /> Vous pouvez mettre fin aux effets d’une Passion en appliquant l’effet inverse(un personnage dont les émotions ont été atténuées est soigné en utilisant Passion pour accroître ses émotions)."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_1_EXCEPTIONALSUCCESS", Text = "Durant les 3 prochains tours, votre cible ne peut dépenser de point de Volonté pour résister aux conséquences de ce pouvoir."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_1_FOCUS_DESCRIPTION", Text = "Vous pouvez aussi utiliser Passion des manières suivantes : En parlant calmement avec votre cible ou en lui détaillant un éventuel danger, vous pouvez soit mettre fin à un pouvoir basé sur la peur affectant cette cible ou la rendre plus vulnérable à ses effets. Parlez à votre cible durant 3 tours complets, dépensez 1 point de Sang et faites un challenge opposé d’Aliénation. En cas de succès, vous mettez fin aux effets de pouvoirs tels que Regard Terrifiant ou infligez un malus de -2 à tous ses Scores de Test pour résister à une peur surnaturelle durant la prochaine heure."},

                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_2_NAME", Text = "Hantise psychique"},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_2_DESCRIPTION", Text = "<i>Des visions cauchemardesques, des flashs à peine perceptibles, des échos surnaturels et des conversations incompréhensibles hantent votre victime, transformant le monde autour d’elle en une brume de rêve. Rien ne semble normal et d’étranges sensations parcourent la peau de la cible. Ses désirs subconscients font surface et ses peurs et ses regrets les plus profonds reviennent la hanter, tels de sombres murmures hallucinatoires du passé.</i>"},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_2_SYSTEM", Text = "Dépensez 1 point de Sang, utilisez votre action standard et faites un challenge opposé d’Aliénation. En cas de succès, le subconscient de votre cible est envahi de visions, de sensations et de sons perturbants, qu’il est le seul à percevoir. Elle souffre d’un malus de -3 pour tout test d’attaque pour les 3 prochains tours, du fait qu’elle essaie (sans succès) de séparer réalité et fiction. Après ces 3 tours, le sujet commence à distinguer ce qui est réel de ce qui est imaginaire. Pendant 1 heure, la pénalité n’est plus que de -1. Les pénalités de Hantise Psychique ne s’appliquent pas aux tests de défense.<br /> Utiliser ce pouvoir sur un individu avec un dérangement lui donne 1 trait de dérangement. Plusieurs Hantises Psychiques ne se cumulent pas."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_2_EXCEPTIONALSUCCESS", Text = "Votre victime souffre d’un malus de -3 à tous ses tests d’attaque durant 5 tours, qui passe ensuite à -1 pour le reste de la nuit. De plus, utiliser ce pouvoir sur un individu avec un dérangement lui donne 2 traits de dérangement au lieu d’1."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_2_FOCUS_DESCRIPTION", Text = "Tant qu’elle est sous l’effet de Hantise Psychique, votre cible perd l’un de ses focus Mentaux. Si elle dispose de plusieurs focus Mentaux, elle choisit quel focus est temporairement perdu."},

                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_3_NAME", Text = "Vision du Chaos"},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_3_DESCRIPTION", Text = "<i>Il y a de la sagesse entre les fissures et les morceaux brisés de la réalité et il y a des leçons à apprendre en regardant l’univers s'effondrer lentement. Avec ce pouvoir, vous êtes à même de discerner des modèles complexes, de dévoiler des incohérences et de traquer les étranges et impalpables fils du destin</i>"},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_3_SYSTEM", Text = "Ce pouvoir est toujours actif. Un personnage utilisant Vision du Chaos reçoit un bonus contextuel de +5 à n’importe quelle utilisation basique de la compétence Enquête ou à n’importe quel test de compétence Académique dans le but de casser un code, trouver une pièce manquante d’un puzzle ou combiner des indices. De plus, en faisant ce type de challenge, vous pouvez effectuer ce test sans interagir physiquement avec votre environnement, un simple coup d’œil autour de la zone (une action standard) est suffisant pour faire une recherche complète.<br /> Un personnage utilisant ce pouvoir peut passer quelques instants à scanner une pièce et réussir à découvrir un pistolet dissimulé dans une boîte à chaussures sous le lit, il peut jeter un regard sur une grille de mots-croisés et le résoudre en quelques instants ou il peut compter rapidement le nombre de dalles dans la pièce qu’il est en train de traverser."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_3_FOCUS_DESCRIPTION", Text = "Vous pouvez utiliser Vision du Chaos au prix d’une action simple, au lieu d’une action standard."},

                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_4_NAME", Text = "Voix de la Folie"},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_4_DESCRIPTION", Text = "<i>Votre voix peut porter la démence du chant des sirènes et le murmure du pandémonium de la folie pure. En parlant d’une voix lourde et résonante, vous pouvez faire revivre les regrets, les peurs, la douleur, l’horreur et les souffrances de la vie et non-vie de votre cible, libérant son Ça et donnant les rênes à ses démons intérieurs.</i>"},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_4_SYSTEM", Text = "Pour utiliser Voix de la Folie, vous devez avoir l’attention de la cible pendant au moins 5 tours (15 secondes) pour lui décrire le dérangement que vous voulez lui infliger. Quand vous avez fini cette description, dépensez 1 point de Sang et faites un challenge opposé contre votre cible. En cas de succès, vous infligez le dérangement de votre choix à votre cible pour le reste de la soirée et 1 trait de dérangement. Si l’individu dispose déjà de traits de dérangement, ce dernier peut causer un épisode psychotique (voir le chapitre sur les Dérangements).<br /> Par exemple, vous pouvez approcher le Primogène Ventrue et lui dire « J’ai vu 2 Brujahs tourner autour de votre voiture la nuit dernière. Que faisaient-ils ? Pensez-vous que les Brujahs soient dignes de confiance ? ». En cas de succès, avec cette phrase, vous pouvez donner le dérangement Phobie avec pour déclencheur « Brujah ». <br />Un individu ne peut être affecté par ce pouvoir qu’une seule fois par utilisateur d’Aliénation. Si le même personnage tente d’infliger un second dérangement avant que le premier n’expire, le premier dérangement est remplacé par le second. Si un autre utilisateur d’Aliénation réussit à utiliser ce pouvoir sur une cible déjà affectée, les dérangements se cumulent."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_4_EXCEPTIONALSUCCESS", Text = "Le dérangement infligé par Voix de la folie dure 2 parties ou 1 mois, en fonction de ce qui est le plus long."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_4_FOCUS_DESCRIPTION", Text = "Au lieu de devoir passer cinq tours à parler à votre cible, vous pouvez infliger un dérangement sans rien d’autre qu’une simple phrase et une action standard. Par exemple, vous pouvez infliger le même dérangement que précédemment en disant simplement à votre cible <i> « Pensez-vous que les Brujahs soient dignes de confiance ? »</i>. Un personnage n’a pas besoin de comprendre complètement le dérangement dans le roleplay pour appliquer les effets de ce pouvoir, mais un joueur doit être sûr de pouvoir expliquer le dérangement à l’interprète de la cible, afin qu’il puisse jouer convenablement les effets."},

                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_5_NAME", Text = "Démence Absolue"},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_5_DESCRIPTION", Text = "<i>En utilisant ce pouvoir, la folie absolue – l’éclatement total du miroir – est libérée au sein de l’esprit de votre victime. Vous faites remonter chaque sentiment d’insécurité, chaque affront oublié, chaque moment de panique ou chaque accès de colère et amplifiez ces blessures émotionnelles au centuple, causant des ravages sur l’esprit de votre cible.</i>"},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_5_SYSTEM", Text = "Vous devez avoir toute l’attention de votre cible pour que Démence Absolue fonctionne. Une fois son entière attention acquise, dépensez 1 Point de Sang, utilisez votre action standard et faites un challenge opposé contre votre cible. En cas de succès, vous la rendez folle durant la prochaine heure. <br /> Démence Absolue emplit l’esprit de votre cible de dérangements conflictuels, lui compliquant les raisonnement logiques. Votre cible doit travailler avec le Conteur pour déterminer exactement comment la folie la frappe, mais pour fluidifier le jeu, l’utilisateur de Démence Absolue choisit l’un des effets suivants à appliquer à sa victime : <br /> • <i>Peur</i>: La victime est terrifiée par tout ce qui semble menaçant et va chercher à fuir et se cacher dans un endroit sûr jusqu’à ce que Démence Totale soit terminée.La victime ne cherchera pas à se battre, sauf si elle est acculée et si elle est forcée à se battre, elle s’enfuira à la moindre occasion. <br /> • <i>Confusion</i>: La victime souffre d’une pénalité de - 5 à tous ses tests d’attaque pendant la durée de Démence Totale, du fait qu’elle tente de séparer la réalité de la fiction.Cette pénalité ne s’applique pas aux tests de défense.<br /> • <i>Fugue</i>: La cible se retire mentalement, s’asseyant en silence, ne parlant qu’à des amis en qui elle a entièrement confiance.Si on la force à sortir de sa bulle, elle va soit attaquer, soit fuir la personne qui l’a provoquée(au choix de la cible)."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_5_EXCEPTIONALSUCCESS", Text = "Les effets de Démence Absolue durent deux heures, au lieu d’une seule."},
                new Traduction{LCID = 1036, Key = "DEMENTATION_POWER_5_FOCUS_DESCRIPTION", Text = "La cible perd tous ses focus Mentaux et Sociaux tant que l’effet de Démence Absolue est actif."},

                new Traduction{LCID = 1036, Key = "DEMENTATION_TEST_SCORE", Text = "Le personnage se servant d’Aliénation utilise son Score de Test <i>Social + Empathie</i> contre le Score de Test Social + Volonté de la cible."},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "DEMENTATION_KEY",
                    DisciplineName = "DEMENTATION_NAME",
                    Description = "DEMENTATION_DESCRIPTION",
                    TestScore = "DEMENTATION_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class DominateInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "DOMINATE_POWER_1_NAME", Description = "DOMINATE_POWER_1_DESCRIPTION", System = "DOMINATE_POWER_1_SYSTEM", Focus = focus[7], FocusEffect = "DOMINATE_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "DOMINATE_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "DOMINATE_NAME" },
                new Power { Level = 2, PowerName = "DOMINATE_POWER_2_NAME", Description = "DOMINATE_POWER_2_DESCRIPTION", System = "DOMINATE_POWER_2_SYSTEM", Focus = focus[7], FocusEffect = "DOMINATE_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "DOMINATE_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "DOMINATE_NAME" },
                new Power { Level = 3, PowerName = "DOMINATE_POWER_3_NAME", Description = "DOMINATE_POWER_3_DESCRIPTION", System = "DOMINATE_POWER_3_SYSTEM", Focus = focus[8], FocusEffect = "DOMINATE_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "DOMINATE_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "DOMINATE_NAME" },
                new Power { Level = 4, PowerName = "DOMINATE_POWER_4_NAME", Description = "DOMINATE_POWER_4_DESCRIPTION", System = "DOMINATE_POWER_4_SYSTEM", Focus = focus[7], FocusEffect = "DOMINATE_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "DOMINATE_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "DOMINATE_NAME" },
                new Power { Level = 5, PowerName = "DOMINATE_POWER_5_NAME", Description = "DOMINATE_POWER_5_DESCRIPTION", System = "DOMINATE_POWER_5_SYSTEM", Focus = focus[8], FocusEffect = "DOMINATE_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "DOMINATE_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "DOMINATE_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "DOMINATE_NAME", Text = "Domination"},
                new Traduction{LCID = 1036, Key = "DOMINATE_DESCRIPTION", Text = "De nombreuses légendes décrivent la capacité du Vampire à placer les gens sous sa coupe en regardant profondément dans leurs yeux. Les adeptes de la Domination utilisent leur force de volonté, canalisant la puissance de leur personnalité. Avec un effort modéré, une telle créature peut faire plier les esprits, implanter des suggestions et même contrôler les actions d’une autre personne. Avec un regard perçant et un mot énergique, la Domination peut amener l’esprit mortel le plus fort à s'effondrer et même pousser d’autres Vampires à se soumettre. <br /> Pour utiliser cette discipline, le Vampire doit d’abord capter l’attention de sa victime. Le Dominateur émet ensuite un ordre verbal ou communique à l’aide d’une gestuelle simple et évidente. La cible ne peut pas s’exécuter si elle ne peut pas comprendre l’ordre du Vampire. En règle générale, cela nécessite un langage commun ou des symboles physiques usuels, comme pointer du doigt pour indiquer qu’une personne doit <i>\"Partir !</i>\".<br /> La Domination ne peut pas être utilisée pour forcer une cible à faire quelque chose de directement autodestructeur. Les ordres tels que « Tire-toi une balle dans le pied » échoueront automatiquement. Cependant, le Dominateur peut émettre des ordres qui ne sont pas directement néfastes, mais qui pourraient conduire à une situation dangereuse. Un Dominateur peut ordonner à quelqu'un de tirer sur un groupe d’agents de police. Cette action entraînera à coup sûr des problèmes et pourrait blesser cette personne, mais ce n’est pas directement autodestructeur.<br /> Il est possible qu’un ordre délivré avec Domination soit inoffensif initialement et qu’il devienne directement dangereux plus tard. Si cela se produit, la Domination rompt juste avant que l’ordre implanté ne devienne directement dangereux. Si un personnage force sa cible à « marcher droit devant jusqu’à ce que je dise stop », la cible sera forcée de marcher tout droit. Cependant, la cible s’arrêtera juste avant de marcher au devant d’un bus ou de tomber d’une falaise. Ce pouvoir ne délivre à la cible aucune capacité surnaturelle pour sentir quand quelque chose est dangereux.Par conséquent, si la victime ne savait pas qu’il y avait une falaise et ne pouvait pas la discerner, la victime aurait continué tout droit avant qu’elle ne réalise le danger – ce qui peut arriver bien trop tard. <br /> À moins que le contraire ne soit précisé, la Domination ne transmet aucune capacité spéciale pour accomplir des ordres extraordinaires. Si la cible reçoit l’ordre de faire quelque chose qu’elle ne peut pas accomplir, elle fera un effort pour exécuter l’ordre, mais pourrait ne pas réussir. Si vous utilisez la Domination pour donner l’ordre « Dors », la cible s’allongera et essayera. Mais, comme la plupart des personnes ne peuvent pas se forcer à s’endormir en un instant, il est peu probable que la cible y parvienne.<br > <strong>Regard et Focalisation</strong> <br /> Pour utiliser la Domination sur une cible, cet individu doit avoir son regard et son attention concentrée sur le Dominateur. Pour plus d’informations, voir Regard et Focalisation dans Utiliser des Disciplines."},

                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_1_NAME", Text = "Ordre"},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_1_DESCRIPTION", Text = "La supériorité est inhérente au sang, à la Vitae qui donne sa non-vie au Vampire. Avec un mot ou un geste, vous pouvez exercer votre Volonté sur un individu et le forcer à obéir. Un simple mot, même intégré dans une phrase, peut devenir un commandement impérieux. Certains Vampires utilisent ce pouvoir subtilement, tandis que d’autres se délectent publiquement de forcer les autres à se soumettre à l’autorité de leur sang."},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_1_SYSTEM", Text = "Pour donner un Ordre à un individu, dépensez une action standard et donnez un ordre simple d’un mot (ou faites un geste bref) à une cible. Si vous remportez le Challenge Opposé en utilisant le groupement de Test de Domination, votre personnage force sa cible à obéir à sa volonté. L’ordre doit être immédiat ; le sujet passera le tour suivant(et uniquement un tour) à essayer d’obéir à votre ordre. Ces exigences doivent être claires et directes: cours, approuve, tombe, baille, saute, ris, arrête, va, crie, ou suis sont de bons exemples. La cible del’Ordre essaiera de prendre en compte le contexte. Si vous pointez une porte du doigt et ordonnez à votre cible \"Pars !\", elle tentera de partir par la porte que vous indiquiez(par opposition à user d’une porte différente ou sauter par une fenêtre). Un Ordre peut faire partie d’une phrase pour camoufler l’utilisation du pouvoir, comme dire par exemple : « J'ai bien peur de devoir vous demander de quitter immédiatement cette maison ! ». Si un Ordre est confus ou ambigu, le sujet peut répondre avec moins de précision ou accomplir médiocrement sa tâche, alors qu’il s'efforce de comprendre ce qui lui a été demandé.Ordre ne peut pas priver votre cible de sa capacité à se défendre."},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_1_EXCEPTIONALSUCCESS", Text = "Si vous obtenez un succès exceptionnel en utilisant Ordre, la cible ne réalise pas qu’elle a été Dominée. Les mortels rationaliseront simplement tout comportement étrange. Une créature surnaturelle sera momentanément confuse et ne réalisera pas qu’elle a été forcée à agir contre sa volonté pour une durée de trois tours après que la commande a pris fin. Une fois cette confusion passée, une victime surnaturelle peut réaliser qu’elle a été Dominée, si les circonstances l’autorisent."},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_1_FOCUS_DESCRIPTION", Text = "Un individu qui a reçu un Ordre avec succès doit suivre votre ordre pendant trois tours (au lieu d’un seul)."},

                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_2_NAME", Text = "Hypnose"},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_2_DESCRIPTION", Text = "Grâce à ce pouvoir, un vampire acquiert une capacité fascinante à contrôler ses facultés mentales. Une Hypnose peut être utilisée pour créer une suggestion hypnotique dans l’esprit de la cible. Des commandes complexes et des désirs inconscients peuvent être implantés, contrôlant la victime de manière subtile mais puissante. Ce pouvoir implante un déclencheur subliminal dans l’esprit de la cible. Ce déclencheur ne s’activera que dans des circonstances précises et force la cible à effectuer certaines actions prédéfinies lorsque les conditions sont réunies. Pour implanter une Hypnose, vous devez capter l’attention de votre cible et énoncer un ensemble d’instructions à voix haute. L’Hypnotiseur peut dicter des directives simples (« Donne-moi tes clefs de voiture ») ou plus complexes (« Prends des notes détaillées lors de la réunion du clan Brujah et apporte-les moi ensuite. »). Vous pouvez indiquer que l’Hypnose se produit immédiatement, ou vous pouvez établir dans l’Hypnose une stimulation spécifique qui forcera plus tard la cible à effectuer ces actions. Les instructions de l’Hypnose doivent être prononcées à haute voix et la cible doit comprendre vos directives.À la différence de l’Ordre, une Hypnose n’a pas besoin d’être une action immédiate. Les instructions peuvent demeurer dans l’esprit d’une cible, non déclenchées, pendant un certain temps. Cependant, une fois que les prescriptions ont été déclenchées et que la cible a exécuté les actions (ouaprès une heure passée à tenter d’exécuter vos ordres), l’Hypnose se termine et toute contrainte persistante disparaît. Une Hypnose non déclenchée subsistera jusqu'à un mois. Un individu ne peut avoir dans son esprit qu’une seule Hypnose active d’un Dominateur donné. Si vous tentez d’implanter une nouvelle suggestion dans l’esprit d’une victime actuellement sous l’effet de votre précédente Hypnose, la nouvelle application de ce pouvoir efface vos premières instructions. Une victime peut avoir plusieurs Hypnoses qui hantent son esprit en même temps, à condition que chaque Hypnose ait été implantée par un individu différent. Si deux Hypnotiseurs implantent des ordres contradictoires dans une cible, la victime suivra d’abord l’Hypnose la plus récente. Elle exécutera ces tâches jusqu'à ce qu’elles soit achevées (ou pendant une heure). Une fois cette Hypnose terminée, le sujet tentera d’accomplir l’Hypnose plus ancienne. Notez que la durée de l’Hypnose antérieure commence au moment ou elle a été déclenchée, de sorte que la victime peut ne plus disposer que d’une durée de quelques minutes dans une telle situation. Hypnose ne peut pas être utilisée pour empêcher un personnage d’utiliser une discipline, bien qu’elle puisse l’être pour empêcher la victime d’agir de certaines manières. Par exemple, vous ne pouvez pas utiliser Domination avec l’ordre « Arrêtez d’utiliser la Célérité », bien que vous puissiez hypnotiser une cible en lui disant « Cessez de m’attaquer. » L’Hypnose ne peut pas priver votre cible de sa capacité à se défendre. Un personnage qui est forcé de compter bruyamment jusqu'à un million peut toujours esquiver, fuir, ou même attaquer, tant qu’il continue de compter. Cependant, il ne pourra probablement pas se cacher efficacement (ou utiliser Occultation pour disparaître) alors qu’il hurle des nombres."},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_2_SYSTEM", Text = "Pour implanter une Hypnose, vous devez capter l’attention de votre cible. Puis, vous devez dépenser une action standard, prononcer les instructions de votre Hypnose et faire un Challenge opposé avec votre cible. Si vous réussissez, l’Hypnose − exactement telle que vous l’avez énoncée − a été implantée. Notez que, comme Ordre, l’Hypnose rompra dés que la cible se rendra compte que ses actions mèneront à des dommages directs. Une fois que l’Hypnose a été déclenchée (que ce soit immédiatement ou en décalé), la cible tentera de réaliser ses instructions tant que l’activité est raisonnablement complétée ou pendant une heure, selon ce qui arrive en premier. Cet ordre subliminal peut rester dans l’esprit de sa cible jusqu’à un mois, après quoi les instructions s’effacent et l’Hypnose prend fin. L’Hypnose ne peut pas lier des actions sans rapport. Vous ne pouvez pas utiliser l’Hypnose pour forcer un autre personnage à \"Dis-moi où vit ta goule et donne-moi tes clefs, puis va donner un coup de poing à ce Brujah et, enfin, va t’asseoir dans un coin pour le reste de l’heure\". Vous pouvez sous-entendre plus d’une action dans une seule Hypnose comme : \"Montre-moi où vis ta goule\". Dans ce cas, la cible va certainement vous conduire jusqu’au lieu en question (ce qui peut amener à quitter le bâtiment, aller dans une voiture et conduire). Dans tous les cas, votre conteur est celui qui a le dernier mot pour déterminer quels mots sont appropriés pour une Hypnose ou non. Exemple: Tanya la Toreador a ennuyé Vincent le Ventrue. Il implante l’Hypnose suivante dans son esprit : « Quand tu verras un verre de vin rouge, tu vas le renverser sur le devant de ta robe ». Plus tard, Tanya voit Mallory le Malkavien en train de boire un verre de vin. Immédiatement l’Hypnose de Vincent entre en action. Tanya soulève le verre de vin de Mallory pour le pointer vers sa robe. Cependant, Mallory, voyant ce qui arrive, se tourne vers Tanya et utilise une autre Hypnose en disant « Rends - moi mon verre de vin ». L’Hypnose de Mallory étant plus récente, elle interrompt celle de Vincent et Tanya est obligée de rendre son verre de vin à Mallory. Après avoir accompli l’Hypnose de Mallory, l’Hypnose de Vincent reprend le dessus dans l’esprit de Tanya.Elle se précipite vers le Malkavien confus pour tenter de renverser son vin sur sa robe."},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_2_EXCEPTIONALSUCCESS", Text = "Quand la cible accomplit son Hypnose (ou quand la durée du pouvoir est dépassée), votre victime ne se rappellera pas avoir suivi vos instructions. Elle se rappellera de toutes les actions qu’elle aura entreprises de son plein gré, mais ne se rappellera pas qu’elle a été forcée par une Hypnose. Si l’Hypnose a pris quelques tours à être accomplie, votre cible peut se retrouver avec des trous de mémoire."},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_2_FOCUS_DESCRIPTION", Text = "Vos Hypnoses peuvent rester inactives dans l’esprit de votre cible pendant trois mois au lieu d’un seul et les effets, une fois déclenchés, dureront deux heures plutôt qu’une."},

                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_3_NAME", Text = "Altération mémorielle"},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_3_DESCRIPTION", Text = "Vos talents de manipulation mentale vous donnent le pouvoir de modeler et modifier la mémoire des autres individus. En captant l’attention de votre cible et en lui parlant clairement, vous pouvez la placer dans un état de transe. Tant qu’elle est somnambule, vous pouvez lui poser des questions, lui demander de vous raconter quelque chose qu’elle a vécu ou lui donner des détails avec lesquels vous allez pouvoir modifier ou remplacer les souvenirs qu’elle a de l’événement. Il est relativement simple de rafler le contenu de la psyché d’un personnage et d’effacer des tas de souvenirs de sa mémoire mais, à moins que vous n’offriez quelque chose en échange, la suppression laissera un vide dans les souvenirs de la victime. L’utilisateur de Domination peut à la place créer de faux souvenirs, détaillant une histoire cohérente qui pourra être absorbée par le subconscient de la victime. L’utilisateur de ce pouvoir peut dire à ses cibles d’incorporer de nouvelles informations (ou retirer certains détails) dans sa mémoire originelle. La cible s’exécutera parfaitement, justifiant les informations grâce au contexte de sa mémoire générale. À moins que quelqu’un ne pointe de profonds paradoxes, la cible rationalisera toute contradiction. L’Altération mémorielle ne donne pas la capacité à l’utilisateur de « voir » un événement dans l’esprit de la cible. Les événements sont racontés du point de vue du sujet et décrits verbalement de la meilleure manière possible par le sujet. Si un sujet n’est pas au courant d’un détail, il ne peut pas décrire ce détail sous l’effet de l’Altération mémorielle."},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_3_SYSTEM", Text = "Pour activer l’Altération Mémorielle, dépensez une action standard et faites un challenge opposé. Si vous remportez le Challenge, votre cible entre en transe pendant un petit moment alors que celui qui manie le pouvoir peut effacer, altérer ou complètement réécrire les souvenirs de la cible. Si la cible est menacée d’une manière ou d’une autre, elle sortira de sa transe, terminant l’application de l’Altération Mémorielle. Pour cette raison, il n’est pas possible d’utiliser Altération Mémorielle dans une situation de combat. Une utilisation réussie de l’Altération Mémorielle vous permet d’effacer ou de modifier jusqu'à 10 minutes de la mémoire de votre cible. Une plus grande période peut être modifiée (par incrémentation de 10 minutes) avec des utilisations répétées de ce pouvoir. Un personnage peut aussi utiliser l’Altération Mémorielle pour détecter des souvenirs falsifiés ou manquants et (sous les bonnes conditions) les restaurer. Quand vous utilisez l’Altération Mémorielle sur votre cible, vous devez enregistrer votre action avec le conteur de votre sujet. Notez aussi vos Scores de Test de Domination (en incluant vos Pouvoirs des Anciens, mais pas vos techniques) au moment du l’exécution du pouvoir. Restaurer des souvenirs altérés ou perdus est difficile et il faut beaucoup de temps et de dévouement. Si un autre personnage tente de restaurer la mémoire altérée par vos soins du sujet, il doit d’abord dire au conteur du personnage combien de points en Domination il possède (en incluant les Pouvoirs d’Anciens, mais pas les Techniques). S’il a moins de points en Domination que vous, alors il est incapable de surmonter suffisamment votre Domination, ne serait-ce que pour tenter de restaurer la mémoire d’origine. Si l’utilisateur de l’Altération Mémorielle a négligemment inséré des souvenirs ou si le conteur veut faire avancer l’intrigue, le personnage qui restaure les souvenirs a l’option d’accélérer le processus d’abattement et d’usure des barrières mentales pour parvenir à une correction des souvenirs altérés. S’il possède autant voire plus de points en Domination que vous, il peut entreprendre un Challenge Mental d’Opposition contre les Scores de Test les plus hauts que vous avez appliqués sur ce sujet lors de votre Domination. S’il réussit le Challenge, tous les souvenirs altérés par cette utilisation de Domination sont corrigés. Le processus requiert une action inter-partie dépensée à la fois par le sujet et celui qui va restaurer les souvenirs. Un vampire ne peut pas utiliser l’Altération Mémorielle pour modifier ou restaurer ses propres souvenirs."},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_3_EXCEPTIONALSUCCESS", Text = "Quand vous accomplissez un succès exceptionnel, votre personnage est considéré comme possédant un point supplémentaire en Domination quand d’autres personnages essayent de défaire votre utilisation de l’Altération Mémorielle dans le futur ou pour déterminer si vous pouvez défaire des altérations faites à la mémoire de votre cible."},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_3_FOCUS_DESCRIPTION", Text = "Vous pouvez altérer jusqu’à une heure de la mémoire de votre cible avec une seule application de l’Altération Mémorielle (au lieu de 10 minutes)."},

                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_4_NAME", Text = "Conditionnement"},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_4_DESCRIPTION", Text = "Il en faut peu pour contrôler les actions d’un individu pendant un court moment ou pour déformer sa mémoire de quelques minutes. Vous êtes capable d’exploits bien plus insidieux. En prenant votre temps et en y dédiant une certaine quantité d’efforts, vous pouvez altérer de manière permanente un pan de la personnalité de votre sujet, lui enlever des habitudes ou lui en rajouter. Cela nécessite une quantité importante d’efforts, mais une fois accomplis, vous aurez remodelé votre cible en quelque chose à votre convenance."},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_4_SYSTEM", Text = "Grâce à un effort maintenu et de la concentration, vous pouvez profondément implanter une Hypnose semi-permanente (comme indiqué ci-dessus pour le pouvoir de Domination correspondant) dans l’esprit de votre sujet. Conditionner une cible nécessite trois heures d’attention assidue et ininterrompue, pendant lequel votre cible doit être consciente et lucide. La cible peut - être restreinte, mais elle ne peut pas être droguée ou autrement inconsciente. Une fois que votre personnage a rempli ces prérequis, initiez un Challenge opposé contre le sujet.En cas de succès, vous implantez une Hypnose qui peut être déclenchée à plusieurs reprises. Les hypnoses implantées au travers d’un Conditionnement doivent avoir un déclencheur clairement défini. Un personnage conditionné agit normalement, sans altération à son comportement standard, jusqu’à ce que ledit conditionnement soit déclenché.Une fois activé, la cible doit répondre aux comportements exigés par le Conditionnement(ou tenter de le faire pendant une heure, peu importe lequel vient en premier). Comme Ordre ou Hypnose, une contrainte de Conditionnement se brise immédiatement si la cible réalise qu’accomplir ces actions entraînera des dommages directs.Quand cela vient à se produire, la contrainte actuelle se brise mais le Conditionnement en lui - même reste(et peut être normalement déclenché dans le futur). Par exemple, vous pouvez conditionner une cible pour qu’elle aille boire du sang de mortel dès qu’elle entend le mot « vagabond ». Si la cible entend le mot et qu’une source de sang mortel est proche, elle tentera toujours de le faire. La contrainte initiale prendra fin dès qu’elle aura terminé de boire, mais peut recommencer si elle entend le mot vagabond.Si la cible est coincée dans un désert, sans source de sang quand elle entend le mot, elle utilisera une heure pour chercher une source de sang de mortel.Par la suite, la contrainte s'efface (jusqu’à la prochaine fois où elle entendra le mot). Une contrainte implantée avec un Conditionnement est permanente, jusqu’à ce qu’elle soit brisée par le sujet; elle ne peut pas être effacée ou écrasée. Un mortel qui a passé une année sans que son conditionnement ne soit déclenché peut faire un challenge opposé(en utilisant le Score de Test d’attribut Mental + Volonté du sujet contre le score de Test Mental + Intimidation du Dominateur).En cas de réussite, la cible brise le Conditionnement.En cas d’échec, le mortel doit attendre une deuxième année supplémentaire pour tenter de briser le Conditionnement et encore une année après cela pour essayer une troisième fois. Les être surnaturels peuvent tenter de briser leur Conditionnement s’ils évitent de le déclencher pendant trois mois. Si la cible rate ce Challenge opposé, alors elle doit attendre trois mois avant d’initier un nouveau Challenge et ainsi de suite. Le Conditionnement d’une cible ne peut pas être déclenché plus d’une fois par heure. Les contraintes placées par Conditionnement ne compte pas dans la limite d’Hypnose d’un personnage; une cible peut être la cible de vos pouvoirs de Conditionnement et d’Hypnose en même temps. Cependant, de la même manière que vous ne pouvez implanter qu’une seule Hypnose par cible, vous ne pouvez aussi implanter qu’un seul Conditionnement en même temps. Un sujet peut avoir plusieurs contraintes de Conditionnement, tant qu’elles proviennent d’utilisateurs différents de Domination."},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_4_FOCUS_DESCRIPTION", Text = "Si vous êtes orienté intelligence, un mortel doit éviter d’activer son Conditionnement trois ans avant de pouvoir tenter de briser le Conditionnement (au lieu de l’année standard). Les créatures surnaturelles doivent éviter de déclencher leur Conditionnement pendant six mois avant de pouvoir tenter de le briser (au lieu des trois mois standard)."},

                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_5_NAME", Text = "Possession"},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_5_DESCRIPTION", Text = "Votre force de volonté est telle que vous pouvez dominer la psyché d’un autre individu, contrôlant ses pensées et actions, occupant sa psyché et en prenant complètement le contrôle de sa forme physique. Vous ne pouvez pas accéder aux pensées ou souvenirs de la victime dans cet état ; son esprit est complètement refoulé, comme dans un sommeil profond et ne sait rien de vos actions. Tant que vous êtes aux commandes du corps de votre sujet, vous pouvez entreprendre n’importe quelle action physique qu’il est capable d’effectuer."},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_5_SYSTEM", Text = "Pour utiliser la Possession, vous devez dépenser votre action standard pour regarder dans les yeux de votre sujet ; ce pouvoir ne peut pas fonctionner sur des sujets aveugles ou des sujets qui ne peuvent vous regarder dans les yeux. Initiez un Challenge opposé contre la cible que vous essayez de posséder. En cas de succès, votre conscience est transférée dans le corps de la cible et son esprit réduit à un état de retrait. Parce que votre esprit est entièrement concentré sur le contrôle du corps qu’il habite, le Vampire n’a aucun sens inné de quoi qu’il puisse arriver à son corps d’origine. Le corps d’origine du personnage tombe dans un état de torpeur et ne peut pas se défendre lui-même ni agir seul (bien que votre corps ait accès à n’importe quel niveau de Force d’âme que vous possédez tant que votre conscience est absente). Pendant la Possession, vous connaissez toujours la position de votre corps d’origine, bien que vous ne puissiez pas percevoir ses environs. Les mortels et créatures partiellement surnaturelles, comme les goules ou kinfolk (voir garou) peuvent être ciblés par la Possession. Des créaturespleinement surnaturelles, comme des Loup-Garou et des Vampires, ne peuvent pas être la cible d’une Possession. Soyez donc sûr d’avoir demandé à votre conteur si un individu est une cible appropriée ou non pour ce pouvoir. Les Mortels ne possèdent pas de Disciplines et ne peuvent pas dépenser de sang. Cependant, si votre personnage possède une goule, vous pouvez utiliser sa réserve de points de sang et dépenser 1 point de sang par tour (quelle que soit la génération de votre personnage). Une goule peut contenir jusqu'à 5 points de sang dans sa réserve. Vous pouvez dépenser ce sang pour alimenter n’importe lequel des pouvoirs physiques de la goule. Vous ne pouvez en aucune manière utiliser ce sang pour affecter la forme d’origine de votre personnage. Un personnage ne peut pas utiliser ses propres disciplines tant qu’il est en Possession. De plus, vous ne pouvez utiliser aucun des pouvoirs du sujet à l’exception de Célérité, Force d’Âme et Puissance. Pendant une Possession, un personnage peut utiliser son attribut Mental ainsi que son Focus, son attribut Social et son Focus, ses compétences et historiques. Si le personnage que vous possédez a sa propre fiche de personnage, utilisez l’attribut Physique sur cette fiche (plutôt que la vôtre) pour tous les Challenges Physique tant que vous êtes en Possession. Si vous utilisez la Possession sur un PNJ Type, l’attribut Physique du sujet est égal au double du score de ce PNJ. Vous ne pouvez pas utiliser les Focus d’attributs de votre cible ni aucun des pouvoirs qui ne sont pas intrinsèques aux vampires et goules. La Possession dure jusqu’au prochain lever du soleil ou jusqu’à ce que vous ayez dépensé une action simple pour que votre personnage retourne à son corps d’origine. La possession prend immédiatement fin si le personnage voyage à plus de 10 miles (16,09km), si le corps d’origine du personnage prend au moins 1 point de dégât ou si le corps qu’il possède prend des dégâts. Les corps possédés ne prennent aucun dégât de la part de la lumière du soleil mais, si le corps d’origine du Vampire est exposé au soleil, il prendra des dégâts. Cependant, un vampire avec des traits de la Bête risque toujours de passer en Frénésie"},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_5_EXCEPTIONALSUCCESS", Text = "Si vous parvenez à un succès exceptionnel, votre personnage peut maintenir le contrôle sur sa forme possédée jusqu’à trois jours sans challenges supplémentaires. La possession prend fin au troisième lever de soleil au lieu du premier. Notez que votre possession prendra toujours fin si le personnage voyage à plus de 10 miles (16,09km) de son corps d’origine, si votre corps d’origine prend au moins un point de dégât ou si le corps en possession prend des dégâts."},
                new Traduction{LCID = 1036, Key = "DOMINATE_POWER_5_FOCUS_DESCRIPTION", Text = "Vous pouvez utiliser les 2 premiers points des Discipline de Clan Social et Mental en utilisant Possession, mais vous ne pouvez pas utiliser de Pouvoirs d’Anciens ni de Techniques. Si vous possédez une goule, vous pouvez utiliser jusqu’à 5 points de sang pour alimenter ces disciplines de clan, au rythme d’un point de sang par tour, quelle que soit la génération de votre personnage. Les Vampires avec ce focus, qui possèdent Domination comme discipline de clan, peuvent utiliser la Possession en étant en Possession, transférant directement leur conscience d’un sujet à un autre. Chaque nouvelle utilisation de Possession nécessite la dépense d’une action standard, un contact les yeux dans les yeux, selon l’utilisation standard de ce pouvoir."},

                new Traduction{LCID = 1036, Key = "DOMINATE_TEST_SCORE", Text = "Le Dominateur utilise son Attribut <i>Mental + Intimidation</i> contre l'Attribut <i>Mental + Volonté</i> de la cible."},
            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "DOMINATE_KEY",
                    DisciplineName = "DOMINATE_NAME",
                    Description = "DOMINATE_DESCRIPTION",
                    TestScore = "DOMINATE_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class FortitudeInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "FORTITUTE_POWER_1_NAME", Description = "FORTITUTE_POWER_1_DESCRIPTION", System = "FORTITUTE_POWER_1_SYSTEM", Focus = null, FocusEffect = "FORTITUTE_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "FORTITUTE_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "FORTITUTE_NAME" },
                new Power { Level = 2, PowerName = "FORTITUTE_POWER_2_NAME", Description = "FORTITUTE_POWER_2_DESCRIPTION", System = "FORTITUTE_POWER_2_SYSTEM", Focus = null, FocusEffect = "FORTITUTE_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "FORTITUTE_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "FORTITUTE_NAME" },
                new Power { Level = 3, PowerName = "FORTITUTE_POWER_3_NAME", Description = "FORTITUTE_POWER_3_DESCRIPTION", System = "FORTITUTE_POWER_3_SYSTEM", Focus = null, FocusEffect = "FORTITUTE_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "FORTITUTE_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "FORTITUTE_NAME" },
                new Power { Level = 4, PowerName = "FORTITUTE_POWER_4_NAME", Description = "FORTITUTE_POWER_4_DESCRIPTION", System = "FORTITUTE_POWER_4_SYSTEM", Focus = null, FocusEffect = "FORTITUTE_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "FORTITUTE_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "FORTITUTE_NAME" },
                new Power { Level = 5, PowerName = "FORTITUTE_POWER_5_NAME", Description = "FORTITUTE_POWER_5_DESCRIPTION", System = "FORTITUTE_POWER_5_SYSTEM", Focus = null, FocusEffect = "FORTITUTE_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "FORTITUTE_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "FORTITUTE_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "FORTITUTE_NAME", Text = "Force d’Âme"},
                new Traduction{LCID = 1036, Key = "FORTITUTE_DESCRIPTION", Text = "Les Vampires sont surnaturellement résistants. Leur corps change avec l’Étreinte et peut survivre à des coups, des taillades, des blessures par balles et aux chutes beaucoup plus facilement que la physiologie mortelle ne le permet. Le sang Vampirique a des propriétés curatives, ressoudant les chairs et les os dans un effort à peine conscient. <br />Cependant, certains vampires sont de véritables mastodontes, chassant d’un haussement d’épaules d’atroce sévices et de terribles traumatismes physique. Leurs corps devenus résistants aux blessures, ignorant des douleurs qui enverraient un mortel dans une catatonie fatale. <br /> Chaque point dans la Discipline Force d’Âme représente un accroissement de la résistance physique du personnage et chaque point s'additionne avec les effets des autres points que le personnage possède dans la Discipline. Si votre personnage possède Résilience (Force d’Âme •••), il possède aussi les bonus donnés par Endurance (Force d’Âme •) et Ardeur (Force d’Âme ••), qu’il doit avoir déjà appris avant d’atteindre Résilience.<br /> Les pouvoirs de Force d’Âme sont toujours actifs et ne coûtent normalement pas de points de sang pour être activés à moins que ce ne soit spécifié dans la description du pouvoir. Des techniques et Pouvoirs d’Anciens peuvent nécessiter du sang (ou un action) afin d’être activés ; référez - vous à chaque pouvoir pour les spécificités."},

                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_1_NAME", Text = "Endurance"},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_1_DESCRIPTION", Text = "<i>Vous êtes au delà de la douleur ou de la fatigue et ignorez ces difficultés. Votre corps ne ressent tout simplement pas ces inconvénients mineurs.</i>"},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_1_SYSTEM", Text = "Vous pouvez facilement ignorer la douleur. Votre personnage est immunisé contre la torture et ne souffre pas de pénalités du fait des blessures."},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_1_FOCUS_DESCRIPTION", Text = null},

                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_2_NAME", Text = "Ardeur"},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_2_DESCRIPTION", Text = "<i>Votre corps peut prendre plus de dégâts que celui des autres, souffrant seulement de blessures légères même dans des circonstances qui devraient entraîner des blessures sérieuses.</i>"},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_2_SYSTEM", Text = "A chaque fois que votre personnage prend des dégâts aggravés, vous pouvez en convertir un point en dégât normal."},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_2_FOCUS_DESCRIPTION", Text = null},

                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_3_NAME", Text = "Résilience"},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_3_DESCRIPTION", Text = "<i>Vous pouvez supporter d’horribles sévices, résistant même aux blessures les plus graves tout en continuant à vous battre. Ceci est un exploit d’endurance impressionnant, clairement au-delà des simples capacités des mortels.</i>"},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_3_SYSTEM", Text = "A chaque fois que votre personnage subit des dégâts, vous pouvez ignorer un point de dégâts normaux. Vous pouvez utiliser ce pouvoir en conjonction avec d’autres pouvoirs qui pourraient convertir des dégâts aggravés en dégâts normaux. Vous pouvez utiliser Ardeur pour rétrograder un point de dégâts aggravés en un point de dégâts normaux, puis vous pouvez utiliser Résilience pour ignorer ce point de dégât normal."},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_3_FOCUS_DESCRIPTION", Text = null},

                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_4_NAME", Text = "Résistance"},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_4_DESCRIPTION", Text = "<i>Vous pouvez supporter d’horribles sévices, résistant même aux blessures les plus graves tout en continuant à vous battre. Ceci est un exploit d’endurance impressionnant, clairement au-delà des simples capacités des mortels.</i>"},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_4_SYSTEM", Text = "Chaque fois que votre personnage subit des dégâts aggravés, vous pouvez convertir un point de ces dégâts aggravés en dégâts normaux. Vous pouvez utiliser ce pouvoir en conjonction avec d’autres Pouvoirs qui convertissent les blessures. Ce pouvoir s'accumule avec Ardeur, vous permettant de convertir deux points de dégâts aggravés de chaque attaque en dégâts normaux. En outre, il se cumule aussi avec Résilience, vous permettant alors d’ignorer un de ces points de dégâts normaux."},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_4_FOCUS_DESCRIPTION", Text = null},

                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_5_NAME", Text = "Égide"},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_5_DESCRIPTION", Text = "<i>Votre corps semble aussi dur que le fer et aussi résistant à la douleur que l’acier lui-même. Seule une force persistante et monumentale peut vraiment vous blesser.</i>"},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_5_SYSTEM", Text = "Chaque fois que votre personnage subit des dégâts, vous pouvez ignorer un point de dégâts normaux. Vous pouvez combiner cet effet avec Résilience afin d’ignorer deux points de dégâts normaux par attaque. Vous pouvez également utiliser ce pouvoir en conjonction avec les pouvoirs qui transforment les dégâts aggravées en dégâts normaux."},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "FORTITUTE_POWER_5_FOCUS_DESCRIPTION", Text = null},

                 new Traduction{LCID = 1036, Key = "FORTITUTE_TEST_SCORE", Text = "Il n’y a pas de Score de Test générique pour Force d’Âme."},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "FORTITUTE_KEY",
                    DisciplineName = "FORTITUTE_NAME",
                    Description = "FORTITUTE_DESCRIPTION",
                    TestScore = "FORTITUTE_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class MelpomineeyInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "MELPOMINEE_POWER_1_NAME", Description = "MELPOMINEE_POWER_1_DESCRIPTION", System = "MELPOMINEE_POWER_1_SYSTEM", Focus = focus[5], FocusEffect = "MELPOMINEE_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "MELPOMINEE_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "MELPOMINEE_NAME" },
                new Power { Level = 2, PowerName = "MELPOMINEE_POWER_2_NAME", Description = "MELPOMINEE_POWER_2_DESCRIPTION", System = "MELPOMINEE_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "MELPOMINEE_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "MELPOMINEE_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "MELPOMINEE_NAME" },
                new Power { Level = 3, PowerName = "MELPOMINEE_POWER_3_NAME", Description = "MELPOMINEE_POWER_3_DESCRIPTION", System = "MELPOMINEE_POWER_3_SYSTEM", Focus = focus[5], FocusEffect = "MELPOMINEE_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "MELPOMINEE_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "MELPOMINEE_NAME" },
                new Power { Level = 4, PowerName = "MELPOMINEE_POWER_4_NAME", Description = "MELPOMINEE_POWER_4_DESCRIPTION", System = "MELPOMINEE_POWER_4_SYSTEM", Focus = focus[3], FocusEffect = "MELPOMINEE_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "MELPOMINEE_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "MELPOMINEE_NAME" },
                new Power { Level = 5, PowerName = "MELPOMINEE_POWER_5_NAME", Description = "MELPOMINEE_POWER_5_DESCRIPTION", System = "MELPOMINEE_POWER_5_SYSTEM", Focus = focus[3], FocusEffect = "MELPOMINEE_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "MELPOMINEE_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "MELPOMINEE_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "MELPOMINEE_NAME", Text = "Melpominée"},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_DESCRIPTION", Text = "La muse Grecque de la tragédie, Melpomene, aurait inspiré la folie et de grandes émotions à travers sa musique. Les sirènes, aussi, utilisent la chanson pour rendre les marins fous, faisant échouer leur navire sur les récifs. Dans les mythes, la musique a un grand pouvoir et la discipline de Melpominée prouve la véracité de ces légendes. Au travers du son et de la chanson, l’utilisateur de cette discipline tord les émotions et agite la folie, affectant les profondeurs même de l’âme d’un auditeur. <br /> Les sujets sourds, ou les sujets autrement incapables d’entendre le Vampire, sont toujours affectés tant que la voix du chanteur atteint leur position naturellement. Les effets de Melpominée ne peuvent pas être enregistrés ou portés par des microphones, porte-voix ou un autre moyen mécanique ou électronique ; de tels enregistrements ne peuvent que dépeindre la performance de la chanson, sans effets surnaturels."},

                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_1_NAME", Text = "La Voix Manquante"},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_1_DESCRIPTION", Text = "<i>Un utilisateur pratiquant de Melpominée peut altérer sa voix au-delà de la mesure humaine, englobant des octaves à la fois dans et en dehors de la gamme vocale normale. L’utilisateur peut imiter d’autres voix, créer des sons inhabituels et chanter des arias complets avec facilité.</i>"},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_1_SYSTEM", Text = "Dépensez 1 point de Sang et une action simple pour modifier votre voix. Avec La Voix Manquante, vous pouvez utiliser tous les sons qu’une voix humaine peut produire (dans n’importe quelle gamme d’octave ou vocale, de la Basse la plus grave au Soprano le plus aigu). Vous pouvez aussi augmenter le volume au-delà de la portée humaine, résonnant sur les autres sons comme un mégaphone vivant. De plus, si vous avez 3 points ou plus dans Performance : Chant, vous pouvez répliquer n’importe quelle voix que vous avez étudiée pendant cinq minutes, quel que soit le genre ou le ton vocal de l’individu.<br /> Notez que La Voix Manquante ne vous fournit pas toute maîtrise des langues étrangères; vous pouvez dupliquer un accent étranger, mais pas comprendre les langages que vous ne comprenez pas déjà."},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_1_FOCUS_DESCRIPTION", Text = "Votre Voix Manquante est une exception à la règle selon laquelle Melpominée ne peut pas être capturée par des enregistrements ou portée par un moyen électronique ou mécanique. Votre personnage peut utiliser la voix de quelqu'un d’autre via un téléphone ou pour tromper des systèmes de sécurité activés par la voix."},

                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_2_NAME", Text = "Voix Fantomatique"},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_2_DESCRIPTION", Text = "<i>Avec de la concentration, vous pouvez faire en sorte d’émettre votre voix d’un lieu différent que le vôtre. Plusieurs utilisateurs de Melpominée utilisent la Voix Fantomatique pour s'harmoniser avec eux-mêmes, réalisant des performances spectaculaires grâce à l’utilisation de ce pouvoir.</i>"},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_2_SYSTEM", Text = "En dépensant 1 point de sang et une action simple, vous pouvez faire en sorte que votre voix soit générée de l’air vide. Utiliser ce pouvoir vous permet de faire émaner de n’importe quel lieu dans votre champ de vision ou depuis tous lieux avec lesquels vous êtes familiers. Quand vous utilisez la Voix Fantomatique, vous n’avez pas besoin de bouger vos lèvres ou montrer d’autres signes que vous parlez. Si vous le voulez, vous pouvez permettre à une personne consentante de répondre de la même manière, sa voix émanera doucement juste à portée de votre audition. Un personnage qui a les pouvoirs d’Auspex : Sens Intensifiés et est à trois pas de vous pourra entendre une conversation tenue au travers de la Voix Fantomatique. Vous ne pouvez avoir qu’une seule application de la Voix Fantôme active à chaque moment.Cependant, vous pouvez tenir deux conversations simultanément, une au travers de la Voix Fantomatique et une tenue normalement. Vous ne pouvez pas utiliser de pouvoirs ou d’autres effet surnaturels grâce à la Voix Fantomatique."},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_2_FOCUS_DESCRIPTION", Text = "Plutôt que d’utiliser Voix Fantôme sur une cible ou lieu que vous pouvez voir, vous pouvez l’utiliser sur tout individu avec lequel vous êtes familier, quelle que soit la distance. Votre voix émane juste derrière la cible, vous permettant de communiquer avec elle. De plus, si vous le souhaitez, vous pouvez autoriser la voix de votre cible à faire écho vers vous."},

                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_3_NAME", Text = "Madrigal"},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_3_DESCRIPTION", Text = "Les hauteur et profondeur de vos chansons portent de profondes émotions. Avec de magnifiques arias et oraisons, vous montez les autres au sommet de leur passion ; une mélancolie noire coule de vos mélodies de désespoir."},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_3_SYSTEM", Text = "Pour utiliser Madrigal, vous devez dépenser un point de Sang et ensuite chanter pendant au moins trois tours. Tous ceux à portée de voix de ce pouvoir ressentent une intense émotion de votre choix, en relation avec votre performance. Cette émotion est renversante, invoquant une vague de souvenirs, d’images ou d’événements qui ont causé des sentiments similaires dans le passé de l’individu. Les individus affectés par une Madrigal reçoivent un bonus de +2 à leurs Score de Test pour résister aux pouvoirs basés sur les émotions de disciplines autre que Melpominée comme la Transe, Regard Terrifiant ou Passion. <br /> Utiliser ce pouvoir sur un individu qui a un dérangement lui donne 1 trait de Dérangement. Pour plus d’informations sur les dérangements, consultez le Chapitre 5, Atouts et Handicapes. <br />Les effets de Madrigal durent pendant 10 minutes, plus 10 minutes additionnelles pour chaque point que l’utilisateur possède dans la compétence Performance : Chant."},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_3_FOCUS_DESCRIPTION", Text = "Pour la durée de Madrigal, votre cible reçoit un bonus de +3 (plutôt qu’un +2) à ses Scores de Test pour résister à des pouvoirs non-Melpominée basés sur l’émotion comme Présence."},

                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_4_NAME", Text = "Chant de la Sirène"},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_4_DESCRIPTION", Text = "<i>En faisant appel à la tourmente et les blessures émotionnelles d’un sujet, vous éveillez la folie dans l’âme d’un individu. Le son de votre voix submerge l’esprit d’un auditeur alors que vous brisez sa prise sur la réalité.</i>"},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_4_SYSTEM", Text = "Pour appeler le Chant de la Sirène, vous devez dépenser 1 point de Sang et un action standard pour chanter. Choisissez un nombre d’individus à portée d’écoute égal à votre compétence dans Performance : Chant.Ces individus entrent immédiatement dans un état de fugue dissociative, arrêtant toute autre activité pour écouter votre performance.Tant que vous continuez à dépenser votre action standard en chantant chaque round, vos auditeurs resteront captivés par la chanson.Si vous utilisez votre action simple pour marcher, ils vous suivront à un rythme lent, inconscients des événements autour d’eux; ils ne remarqueront pas des violations de la Mascarade ou d’autres évènements généraux.Cependant, si un individu attiré se fait attaquer, est mis en danger(vous ne pouvez pas les mener au dessus d’une fosse ou devant une voiture à toute vitesse) ou est la cible d’un pouvoir offensif, votre Chant de la Sirène se brise immédiatement.<br /> Tous ceux qui veulent résister à votre Chant de la Sirène doivent entreprendre un challenge opposé en utilisant leur Score de Test d’Attribut Social + Volonté contre votre Score de Test de Melpominée.<br /> Utiliser ce pouvoir sur un individu avec un dérangement lui donne 2 traits de Dérangement.Si cela provoque une crise psychotique, cette crise n’aura pas lieu avant que le Chant de la Sirène ne se termine.Pour plus d’informations sur les Dérangements, voir le Chapitre 5: Atouts et Handicaps."},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_4_FOCUS_DESCRIPTION", Text = "Les mortels ne comptent pas dans votre nombre maximum de cibles pour le Chant de la Sirène."},

                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_5_NAME", Text = "Mort du Tambour"},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_5_DESCRIPTION", Text = "<i>Le Son peut être une force explosive et mortelle et le pouvoir des harmoniques peut secouer même les matériaux les plus solides. En donnant le ton à votre voix de l’exacte fréquence de la forme physique d’un ennemi, vous pouvez provoquer de sévères blessures à votre cible.</i>"},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_5_SYSTEM", Text = "Dépensez 1 point de Sang et dépensez une action standard pour chanter, pousser un hurlement ou évoquer de manière audible la Mort du Tambour. Faites un challenge opposé avec votre adversaire en utilisant les traits de Challenge de Melpominée. En cas de succès, votre victime subit 3 points de dégâts aggravés.<br /> Vous pouvez activer la Mort du Tambour contre une cible de manière répétée ; c’est une exception à la règle qui interdit à un personnage d’utiliser un pouvoir Social contre la même cible après avoir échoué.Si vous échouez à utiliser Mort du Tambour contre votre adversaire, vous pouvez encore essayer contre lui(ou un autre) le tour d’après."},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_5_EXCEPTIONALSUCCESS", Text = "Votre utilisation de la Mort du Tambour inflige 4 points de dégâts aggravés plutôt que 3."},
                new Traduction{LCID = 1036, Key = "MELPOMINEE_POWER_5_FOCUS_DESCRIPTION", Text = "Vous pouvez aussi cibler des objets avec la Mort du Tambour. La plupart des objets se briseront après un seul round de chant, mais le Conteur peut demander plusieurs rounds de chant pour briser des matériaux exceptionnellement durs et résistants."},

                new Traduction{LCID = 1036, Key = "MELPOMINEE_TEST_SCORE", Text = "L'utilisateur de Melpominée utilise son attribut <i>Social + Subterfuge</i> contre l’attribut <i>Social + Volonté.</i>"},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "MELPOMINEE_KEY",
                    DisciplineName = "MELPOMINEE_NAME",
                    Description = "MELPOMINEE_DESCRIPTION",
                    TestScore = "MELPOMINEE_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class MytherceriaInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "MYTHERCERIA_POWER_1_NAME", Description = "MYTHERCERIA_POWER_1_DESCRIPTION", System = "MYTHERCERIA_POWER_1_SYSTEM", Focus = focus[6], FocusEffect = "MYTHERCERIA_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "MYTHERCERIA_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "MYTHERCERIA_NAME" },
                new Power { Level = 2, PowerName = "MYTHERCERIA_POWER_2_NAME", Description = "MYTHERCERIA_POWER_2_DESCRIPTION", System = "MYTHERCERIA_POWER_2_SYSTEM", Focus = focus[6], FocusEffect = "MYTHERCERIA_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "MYTHERCERIA_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "MYTHERCERIA_NAME" },
                new Power { Level = 3, PowerName = "MYTHERCERIA_POWER_3_NAME", Description = "MYTHERCERIA_POWER_3_DESCRIPTION", System = "MYTHERCERIA_POWER_3_SYSTEM", Focus = focus[7], FocusEffect = "MYTHERCERIA_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "MYTHERCERIA_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "MYTHERCERIA_NAME" },
                new Power { Level = 4, PowerName = "MYTHERCERIA_POWER_4_NAME", Description = "MYTHERCERIA_POWER_4_DESCRIPTION", System = "MYTHERCERIA_POWER_4_SYSTEM", Focus = focus[6], FocusEffect = "MYTHERCERIA_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "MYTHERCERIA_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "MYTHERCERIA_NAME" },
                new Power { Level = 5, PowerName = "MYTHERCERIA_POWER_5_NAME", Description = "MYTHERCERIA_POWER_5_DESCRIPTION", System = "MYTHERCERIA_POWER_5_SYSTEM", Focus = focus[7], FocusEffect = "MYTHERCERIA_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "MYTHERCERIA_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "MYTHERCERIA_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_NAME", Text = "Mythercellerie"},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_DESCRIPTION", Text = "La Mythercellerie est une discipline faite de perceptions tordues. Ces pouvoirs floutent la ligne entre la réalité et le rêve, piochant à la fois dans la vitae de son utilisateur et sur la vitalité des Fae, présente dans le monde naturel. La Mythercellerie est une discipline de charades et de puzzles, d’énigmes et de casse-tête et beaucoup de ses pouvoirs provoquent des effets qui embourbent l’esprit de la cible. La Mythercellerie intègre aussi un talent accru pour acquérir des savoir obscurs, pour créer et résoudre des énigmes."},

                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_1_NAME", Text = "Vue de Fae"},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_1_DESCRIPTION", Text = "<i>La Mythercellerie ouvre votre esprit à un autre monde : celui des rêves et de l’imagination. Votre capacité à voir la réalité avec l’œil des Fae déforme vos perceptions, vous octroyant des informations qui ne pourraient pas être gagnées par l’observation normale ou l’inspection.</i>"},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_1_SYSTEM", Text = "Ce pouvoir est toujours actif. Vous pouvez apprendre l’utilité et l’âge d’un objet en un regard, détecter un faux d’un original et identifier les matériaux utilisés dans la création d’un objet. Vous pouvez aussi percevoir des informations sur le créateur de l’objet, incluant le nombre de points en Compétence Artisanat qu’il a utilisés, son type de créature et l’époque à laquelle l’objet a été conçu. Enfin, vous pouvez discerner les sens obscurs, les symboles, les références politiques et historiques et les informations cachées dans l’art de l’objet. De plus, vous pouvez reconnaître les créatures, individus, pouvoirs et enchantements d’origine fae. Bien que vous ne puissiez apprendre leurs capacités ou durées, votre Vue de Fae vous permet de détecter que de tels effets sont présents."},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_1_FOCUS_DESCRIPTION", Text = "Si un objet a des verrous cachés, ou des compartiments, vous les découvrez. Vous pouvez discerner le code ou la suite de manœuvres nécessaires pour ouvrir une porte ou un compartiment, en dépensant trois tours complets à étudier la serrure. Si la serrure nécessite une clef et que vous dépensez trois tours en étude, vous pourrez reconnaître d’un seul coup d’œil si une clef donnée pourra fonctionner dans cette serrure."},

                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_2_NAME", Text = "Supercherie ténébreuse"},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_2_DESCRIPTION", Text = "<i>Comme les contes de fées d’antan, vous pouvez ennuyer une victime avec des contrariétés mineures et des farces de fae, rendant sa vie plus difficile pour une courte période de temps. Tant que cet effet dure, la cible pourrait mal ranger des objets, perdre le sens de l’orientation, découvrir ses lacets liés ensemble, ou d’autres infortunes mineures - cadeaux des fae.</i>"},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_2_SYSTEM", Text = "Dépensez 1 point de sang et utilisez une action standard, puis lancez un challenge en opposition contre votre cible, en utilisant le Score de Test de Mythercellerie. Si vous réussissez, votre cible sera perturbée par des ennuis et tracasseries durant l’heure qui suit, vu que des fae lui font des farces, lui causant problème sur problème. Hors combat, ses clefs de voiture peuvent disparaître, son téléphone portable se décharger rapidement, il peut se lever et trouver ses lacets noués ensemble. En combat, à chaque fois que votre victime utilise un point de Volonté pour faire une Manœuvre de Combat, son attaque échouera automatiquement. Ce pouvoir n’a aucun effet sur les attaques améliorées par des manœuvres de combat qui ont été faites sans dépenser de volonté."},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_2_EXCEPTIONALSUCCESS", Text = "Cet usage de Supercherie ténébreuse dure pour le reste de la nuit, plutôt qu’une heure."},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_2_FOCUS_DESCRIPTION", Text = "Toutes les attaques de la cible qui sont améliorées par des Manœuvres de Combat échouent automatiquement, même si la manœuvre ne nécessitait pas de volonté."},

                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_3_NAME", Text = "Je viens en ami (Ay Befriend)"},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_3_DESCRIPTION", Text = "A l’époque médiévale, il était courant de déclarer des intentions pacifiques envers les visiteurs ou des camarades fraîchement rencontrés par la déclaration \"Je viens en ami\". Les fées ont conservé cette coutume et sont bien disposées envers ceux qui se souviennent de la façon convenable de les saluer, en déclarant sans hésitation votre amicalité par l’ancienne formule : <i>\"Oyez, pixies, je viens en ami !\"(\"Prithee, piskies, Ay Befriend!\")</i>.<br /> Les changelins et peuples fae ont leurs propres centres d’intérêts et sociétés, mais ils sont capables de filer un coup de main -s'ils sont récompensés de tels efforts. En utilisant ce pouvoir, vous pouvez appeler l’une des plus petites de ces créatures et lui promettre une récompense raisonnable si elle vous aide pour un temps."},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_3_SYSTEM", Text = "Dépensez un point de sang et utilisez votre action standard pour appeler une petite troupe de pixies, un type de fae. Les Pixies sont humanoïdes, mais de petite taille et d’apparences variées, vêtus de petits vêtements simples faits de feuilles et de la flore naturelle. Ces créatures sont invisibles à toutes les personnes n’ayant pas Vue de Fae. Normalement les Fae arrivent dans les cinq minutes qui viennent, tant qu’elles peuvent bel et bien atteindre l’endroit où vous êtes. Elles peuvent voler, mais n’ont pas la capacité de traverser les murs et les objets solides.<br /> Tant que vous payez les pixies d’avance avec une once d’or, des gemmes, ou des petits objets précieux, elles devraient être relativement loyales, bien qu’espiègles. Vous pouvez demander à ces pixies d’effectuer l’équivalent d’une action inter-partie pendant le temps d’une partie, ou en plus de vos propres actions inter-parties. Si vous leur demandez une action inter-partie, telle que de vous apporter un objet, porter un message, nettoyer un lieu, découvrir des informations utiles durant le temps d’une session de jeu, les pixies feront la tâche à une vitesse fulgurante, la terminant dans l’heure. SI vous utilisez <i>Je viens en ami</i> entre deux parties, vous gagnez une action inter-partie inobservable, intraçable. Dans tous les cas, les pixies ne se mettent pas en danger et ne se lancent pas dans des combats. Vous ne pouvez utiliser <i>Je viens en ami</i> plus d’une fois par semaine calendaire, que ce soit durant la session de jeu, ou entre deux sessions"},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_3_FOCUS_DESCRIPTION", Text = "Vous pouvez utiliser Je viens en ami une fois durant la partie et une autre durant les actions inter-partie, au cours d’une même semaine calendaire. Vous ne pouvez utiliser cet avantage pour disposer de deux actions en partie, ou de 2 actions inter-partie au cours d’une semaine calendaire."},

                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_4_NAME", Text = "Glyphe Changelin"},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_4_DESCRIPTION", Text = "La langue des Fae est une toile serrée, capable de capter les pensées comme une araignée les mouches. Voir de telles glyphes écrites désoriente la plupart des esprits, causant confusion et légère stupeur au mieux : l’amnésie totale face à un esprit particulièrement faible."},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_4_SYSTEM", Text = "Pour inscrire un Glyphe Changelin, dépensez 1 point de sang et dépensez trois tours complets à tracer des lettres et symboles sur un objet cible. Vous devez avoir de quoi écrire sur ledit objet. Vous pouvez dessiner ces sceaux sur un objet déplaçable, une porte, le sol d’une pièce, mais la zone où inscrire doit être d’au moins 15 centimètres (six pouce) de diamètre. Une fois dessiné, le Glyphe Changelin est invisible pour ceux qui ne possèdent pas Vue de Fae ; pour ceux qui peuvent le voir, le glyphe apparaît comme étant un symbole doucement luisant écrit dans une lumière lunaire argentée. Les mortels qui touchent l’objet, ou traversent une glyphe statique deviennent confus pour les 5 prochaines minutes et erreront, quittant la zone en prenant la direction par laquelle ils sont venus.Les créatures surnaturelles doivent réussir un challenge statique, avec l’attribut Mental + Volonté, contre une difficulté égale à votre Score de Test de Mythercellerie, ou souffrir d’un effet similaire.De plus, les individus souffrant de dérangements gagnent un trait de dérangement.Si cela fait que l’individu subit une crise psychotique, cette crise n’aura lieu qu’après la fin des effets de votre Glyphe Changelin.Pour plus d’informations sur les dérangements, consultez Dérangements dans le Chapitre Atouts et Handicaps. <br /> Après qu’un mortel a émergé hors de l’errance du Glyphe Changelin, il n’a aucune idée du temps qu’il a pu y passer, ni aucun souvenir de la raison pour laquelle il était venu dans ce lieu(ou pour laquelle il a touché cet objet). Il justifiera ses actions sans aucun recours à la logique. Au bout d’un jour, il aura oublié même complètement d’être venu ici(ou d’avoir vu l’objet).<br /> Après qu’une créature surnaturelle a surmonté son état confus, elle a une vague conscience que du temps a passé, mais aucune compréhension du temps durant lequel il était sous l’effet du glyphe.Il se souvient de ses activités précédentes, mais elles semblent distantes et rêvées. La cible ne se souvient de rien qui aurait eu lieu sous l’effet de ce pouvoir. <br />Si un individu est attaqué, mis en danger, ou ciblé par un pouvoir offensif, l’effet du Glyphe Changelin cesse immédiatement. <br />Une fois inscrit, un Glyphe Changelin persiste pour un an et un jour, ou jusqu'au moment où l’utilisateur de Mythercellerie décide de l’enlever, ou si l’objet est abîmé par au moins 1 point de dégât.Si une créature surnaturelle résiste à l’effet du Glyphe Changelin, il est immunisé aux effets de tout autre Glyphe Changelin créé par le même utilisateur pendant une heure.Un personnage est immunisé aux effets de son propre Glyphe Changelin."},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_4_FOCUS_DESCRIPTION", Text = "Les créatures surnaturelles souffrent des mêmes effets postérieurs que les créatures mortelles et partiellement surnaturelles. De plus, si une créature émerge de l’effet de votre Glyphe Changelin avant la fin de la durée normale, il devient confus et souffre d’une pénalité de -3 pour toute action non-défensive durant les 3 prochains tours."},

                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_5_NAME", Text = "Énigme Fantastique"},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_5_DESCRIPTION", Text = "<i>Vous avez ouvert votre esprit au rêve et êtes devenu éclairé. Vos sensations altérées peuvent être déconcertantes pour ceux qui ne partagent pas votre savoir, mais vous savez pertinemment qu’il y a une différence entre la folie et le rêve. Quand vous le souhaitez, vous pouvez partager vos réflexions, déchirer le voile des pensées d’un auditoire et l’ouvrir aux vérités distordues de la réalité. A travers des questions philosophiques pénétrantes, des formules mathématiques, des koan zens ou d’autres dilemmes paradoxaux, vous pouvez détricoter l’esprit de votre cible.</i>"},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_5_SYSTEM", Text = "Pour infliger l’Énigme Fantastique, dépensez 1 point de sang et dépensez une action standard pour donner une énigme à votre cible. Si vous réussissez un challenge en opposition en utilisant votre Score de Test de Mythercellerie, la cible est captivée, la complexité de votre logique distordue piégeant son esprit. Il ne peut faire d’autre action que de tenter de résoudre l’Énigme Fantastique. D’autres usages de Mythercellerie ne peuvent affecter la cible tant qu’elle est dans cet état.<br /> Pendant 5 minutes, la cible se comporte comme sous l’effet du Glyphe de Changelin. A la fin de ce temps, elle doit réussir un challenge statique de Mental + Érudition contre une difficulté équivalente à votre Score de Test de Mythercellerie. Parce que c'est un challenge statique, la cible neteste pas contre l’utilisateur de la Mythercellerie et ce dernier ne peut donc re-tester, bien que la cible le puisse. Si la cible réussit, elle répond à votre Énigme correctement et émerge de son état de fascination sans effet additionnel. Si elle échoue, elle ne peut répondre à votre question et subit 3 points de dégâts aggravés qui ne peuvent être réduits ou absorbés et elle émerge de cet état de méditation. Si quelqu'un de captivé par l’Énigme Fantastique est attaqué, mis en danger ou ciblé par un pouvoir offensif, la cible peut choisir l’une de ces deux actions.<br /> • Échapper temporairement aux effets du pouvoir : le personnage peut se défendre mais ne peut faire aucune action offensive ou utilitaire, ni discuter de façon sensée avec quiconque. Son seul but est de fuir la zone. Lorsque le personnage n’est plus en danger, il retourne à son état méditatif et peut continuer ses tentatives de répondre à la question, comme le veut l’usage normal de ce pouvoir.<br /> • Admettre sa défaite, abandonner et terminer plus rapidement l’Énigme Fantastique. Si un personnage fait cela, il subit 3 points de dégâts aggravés qui ne peuvent être réduits ou absorbés, de façon identique au fait d’échouer à répondre à cette énigme après le temps écoulé."},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_5_EXCEPTIONALSUCCESS", Text = "Si la cible échoue ou admet sa défaite, elle souffre de 4 dégâts aggravés."},
                new Traduction{LCID = 1036, Key = "MYTHERCERIA_POWER_5_FOCUS_DESCRIPTION", Text = "La cible souffre d’un malus de -3 quand elle tente le challenge pour résoudre votre énigme."},

                new Traduction{LCID = 1036, Key = "MYTHERCERIA_TEXT_SCORE", Text = "L'utilisateur de Mythercellerie doit utiliser son Attribut <i>Mental + Érudition</i>, contre l’Attribut <i>Mental + Volonté</i> de la cible."},
            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "MYTHERCERIA_KEY",
                    DisciplineName = "MYTHERCERIA_NAME",
                    Description = "MYTHERCERIA_DESCRIPTION",
                    TestScore = "MYTHERCERIA_TEXT_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class ObeahInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "OBEAH_POWER_1_NAME", Description = "OBEAH_POWER_1_DESCRIPTION", System = "OBEAH_POWER_1_SYSTEM", Focus = focus[6], FocusEffect = "OBEAH_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBEAH_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "OBEAH_NAME" },
                new Power { Level = 2, PowerName = "OBEAH_POWER_2_NAME", Description = "OBEAH_POWER_2_DESCRIPTION", System = "OBEAH_POWER_2_SYSTEM", Focus = focus[7], FocusEffect = "OBEAH_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBEAH_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "OBEAH_NAME" },
                new Power { Level = 3, PowerName = "OBEAH_POWER_3_NAME", Description = "OBEAH_POWER_3_DESCRIPTION", System = "OBEAH_POWER_3_SYSTEM", Focus = focus[7], FocusEffect = "OBEAH_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBEAH_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "OBEAH_NAME" },
                new Power { Level = 4, PowerName = "OBEAH_POWER_4_NAME", Description = "OBEAH_POWER_4_DESCRIPTION", System = "OBEAH_POWER_4_SYSTEM", Focus = focus[7], FocusEffect = "OBEAH_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBEAH_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "OBEAH_NAME" },
                new Power { Level = 5, PowerName = "OBEAH_POWER_5_NAME", Description = "OBEAH_POWER_5_DESCRIPTION", System = "OBEAH_POWER_5_SYSTEM", Focus = focus[6], FocusEffect = "OBEAH_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBEAH_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "OBEAH_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "OBEAH_NAME", Text = "Obéah"},
                new Traduction{LCID = 1036, Key = "OBEAH_DESCRIPTION", Text = "Le pouvoir sacré d’Obeah fut reconnu et respecté, tout comme ses utilisateurs, les Salubriens. Cependant, au fil des siècles, le clan et le pouvoir furent honnis et tout signe de la discipline Obeah est désormais susceptible d’être traité avec dédain et suspicion. Le pouvoir lui-même peut guérir les blessures psychologiques et physiques – et pourtant les vampires ont toutes les raisons de croire qu’Obeah et le clan qui l’a créé, puise son origine dans des pouvoirs infernaux et de la diablerie.<br /> A notre époque, les vampires croient ce mensonge - ou ont toutes les raisons de continuer à promouvoir ce mensonge. Les antiques mensonges et les anciennes trahisons lient encore la plupart des anciens à cette assertion et ils persécutent et détruisent toute personne découverte à posséder les pouvoirs d’Obeah avant qu’ils aient la chance de dire la vérité. L’utilisation de tout pouvoir d’Obeah au-delà du premier entraîne la manifestation du troisième œil sur le front de l’utilisateur. Cet œil s'ouvre et s’illumine tout au long de l’utilisation du pouvoir et disparaît par la suite. <br /><strong>Obeah et Valeren </strong> : un personnage possédant n’importe quel niveau d’Obeah ne pourra jamais acheter Valeren. De même, un personnage qui a acheté n’importe quel niveau de Valeren ne pourra jamais acheter Obeah."},

                new Traduction{LCID = 1036, Key = "OBEAH_POWER_1_NAME", Text = "Sentir la vie"},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_1_DESCRIPTION", Text = "<i>La vie imprègne le monde, une énergie s’écoulant inéluctablement dans tout ce qui est. Avec ce pouvoir, vous pouvez exploiter ce courant, ressentir le pouls de l’univers et percevoir de manière tangible l’énergie vitale des individus à proximité.</i>"},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_1_SYSTEM", Text = "Dépensez 1 point de Sang et utilisez une action simple pour activer Sentir la vie. Pour l’heure suivante, vous gagnez la capacité instinctive de percevoir la santé de n’importe quelle créature qui se trouve à 10 pas de vous. Vous réalisez automatiquement les informations suivantes : • Si la cible est vivante, morte ou morte - vivante • Le nombre actuel de blessures de la cible et le nombre de niveaux de santé restants • La localisation et la gravité des blessures qu’elle subit actuellement • Si la cible souffre de maladies ou d’autres maux et si oui, lesquels • Si la cible a des drogues ou des poisons dans son organisme et si oui, lesquels • La disposition de tous les organes, os, muscles et autres structures physiques du corps. Vous vous rendez compte si des organes ont été enlevés ou déplacés et vous pouvez sentir les signes des blessures plus âgées, guéries ou des anomalies génétiques.Sentir la vie surpasse les pouvoirs permettant de camoufler les niveaux de Santé d’un individu tels que Blessures trompeuses(NdT : Misleading Wounds) ou des pouvoirs similaires."},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_1_FOCUS_DESCRIPTION", Text = "Obeah se concentre sur la défense et la guérison. En dépensant 1 point de Sang et en utilisant une action simple, vous pouvez également utiliser Sentir la vie pour recevoir un bonus de +5 à tous les tests en utilisant la compétence Médecine ou lorsque vous essayez de diagnostiquer la cause du décès d’un cadavre."},

                new Traduction{LCID = 1036, Key = "OBEAH_POWER_2_NAME", Text = "Toucher Anesthésiant"},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_2_DESCRIPTION", Text = "<i>Vous avez le toucher d’un guérisseur. Vous pouvez faire fuir la douleur ou taire la peur dans le cœur de vos patients. Toute cible qui se soumet volontairement à votre toucher anesthésiant peut être rendue immunisée à la douleur et toute créature mortelle affectée par votre pouvoir tombe dans un sommeil réparateur immédiat.</i>"},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_2_SYSTEM", Text = "Dépensez 1 point de sang et utilisez votre action standard pour cibler un sujet volontaire. Pour l’heure suivante, la cible ne ressent aucune douleur et ne subit aucune pénalité de blessure. Si votre cible est mortelle, vous la mettez dans un état de sommeil paisible, où elle ne ressentira aucune douleur pour les 10 prochaines heures.<br /> De plus, les créatures mortelles guériront 3 points de dégâts normaux après s’être reposées huit heures entières sous les effets de ce pouvoir. Le toucher anesthésiant ne peut être utilisé que sur des cibles volontaires. Les individus sous l’effet du toucher anesthésiant sont immunisés contre les effets de toucher brûlant, à moins que le personnage utilisant le toucher brûlant ait aussi le pouvoir ancien Ardente agonie."},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_2_FOCUS_DESCRIPTION", Text = "Vous pouvez dépenser 1 Sang et utiliser une action simple pour utiliser le toucher anesthésiant sur une cible volontaire dans votre ligne de vue."},

                new Traduction{LCID = 1036, Key = "OBEAH_POWER_3_NAME", Text = "Corpore Sano"},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_3_DESCRIPTION", Text = "<i>Votre vitae est une substance alchimique, portant des propriétés curatives comme celles des êtres possédés par les figures sacrées mythologiques. En imposant les mains sur les blessures des autres, vous pouvez les faire guérir à une vitesse incroyable.</i>"},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_3_SYSTEM", Text = "Dépensez 1 point de sang et utilisez votre action standard pour cibler une personne volontaire. La cible guérit immédiatement 1 point de dégâts normaux. Corpore Sano ne peut être utilisé qu’une fois par tour. Vous pouvez utiliser Corpore Sano pour vous guérir."},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_3_FOCUS_DESCRIPTION", Text = "En plus des propriétés normales de Corpore Sano, vous pouvez également choisir de dépenser 1 point de Sang pour guérir un point de dégâts aggravés."},

                new Traduction{LCID = 1036, Key = "OBEAH_POWER_4_NAME", Text = "Veille du Berger"},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_4_DESCRIPTION", Text = "Comme un berger protégeant son troupeau des loups et des autres prédateurs, ceux qui cherchent votre protection peuvent trouver la paix et l’abri en votre présence. Une aura de douce vigilance vous entoure, donnant un sentiment d’espoir et de calme à ceux qui restent à proximité."},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_4_SYSTEM", Text = "Dépensez 1 point de Sang et utilisez votre action standard pour activer la garde du berger. Ce pouvoir vous protège ainsi que tous les individus que vous choisissez, personnes comme créatures, aussi longtemps qu’elles restent à cinq pas de vous. Tant que ce pouvoir est actif, aucune personne ayant une intention hostile ne peut venir à moins de cinq pas de vous ou de ceux que vous choisissez de protéger. Si une personne se trouvant dans les cinq pas choisit d’attaquer ou d’utiliser un pouvoir hostile vous ciblant ou l’un de ceux que vous protégez, la tentative échoue automatiquement. De plus, l’attaquant est immédiatement et automatiquement repoussé à cinq pas de sa cible par une main douce et surnaturelle. La garde du berger n’empêche pas les individus utilisant des armes à distance ou des pouvoirs de vous attaquer, vous ou ceux que vous protégez. Si une personne protégée par votre garde du berger attaque ou cible une personne avec un pouvoir hostile (qu'elle cible une personne à l’intérieur ou à l’extérieur de votre aura), elle perd immédiatement la protection de la garde du berger. Un tel personnage ne peut pas être protégé par votre pouvoir pour l’heure suivante.<br /> Une fois que la garde du berger est activée et que vous avez choisi les personnes que vous protégez avec ce pouvoir, vous ne pouvez pas ajouter d’autres personnes à cette protection à moins de réactiver la garde du berger. Il n’y a pas de limite au nombre d’individus que vous pouvez protéger avec ce pouvoir, à condition qu’ils restent à cinq pas de vous. Chaque tour après le premier, vous devez dépenser 1 point de sang pour garder l garde du berger active. Si vous arrêtez de dépenser du sang, ou de faire toute action autre que de la parole ou du déplacement, ce pouvoir s’arrête immédiatement."},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_4_FOCUS_DESCRIPTION", Text = "Les personnages protégés par votre garde du berger gagnent également un bonus de +3 aux tests de défense impliquant l’esquive et la survie."},

                new Traduction{LCID = 1036, Key = "OBEAH_POWER_5_NAME", Text = "La Bénédiction du roi"},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_5_DESCRIPTION", Text = "<i>En imposant vos mains sur les malades ou les blessés, vous guérissez le corps du patient de toute affliction ou maladie, l’amenant à un état de pleine santé. Lorsque cela se produit, un doux sentiment de paix se propage à travers l’âme de votre cible, la rendant temporairement joyeuse et en harmonie avec le monde. Certains vampires voient cela comme une bénédiction ; d’autres le considèrent comme une ruse infernale destinée à cacher la vraie nature de l’utilisateur.</i>"},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_5_SYSTEM", Text = "Dépensez 3 points de sang et touchez une cible volontaire pendant une minute pour activer la bénédiction du roi. Par la suite, toutes les maladies physiques dont souffre actuellement votre cible sont guéries, pour aussi longtemps que vous le souhaitez. La bénédiction du Roi peut être utilisée pour guérir des blessures, régénérer les membres perdus, corriger les défauts génétiques, contrecarrer les poisons ou les drogues, guérir les maladies et supprimer les altérations indésirables à la forme physique, comme celles causées par Vicissitude. La Bénédiction du Roi ne peut être utilisée que sur des cibles volontaires. Les personnages qui ne peuvent pas dépenser 3 points de Sang en un seul tour peuvent remplir cette exigence sur plusieurs tours, tant que le Sang est dépensé consécutivement."},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "OBEAH_POWER_5_FOCUS_DESCRIPTION", Text = "L’utilisation de la bénédiction du roi peut également apporter la paix à ceux qui ont des maux ou des troubles psychologiques et peut même guérir des dérangements. Après avoir rempli tous les autres coûts de ce pouvoir, vous pouvez également supprimer le dérangement d’un individu. Notez que ce pouvoir ne peut pas enlever définitivement le dérangement primaire d’un Malkavien, même si cela le soulage pendant un court laps de temps. Un Malkavien ne gagne pas de traits de dérangement pendant une heure. Pour plus d’informations sur les dérangements et les traits de dérangement, voir le chapitre 5: avantages et défauts."},

                new Traduction{LCID = 1036, Key = "OBEAH_TEST_SCORE", Text = "L'utilisateur de Mythercellerie doit utiliser son Attribut <i>Mental + Érudition</i>, contre l’Attribut <i>Mental + Volonté</i> de la Cible."},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "OBEAH_KEY",
                    DisciplineName = "OBEAH_NAME",
                    Description = "OBEAH_DESCRIPTION",
                    TestScore = "OBEAH_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class ObfuscateInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "OBFUSCATE_POWER_1_NAME", Description = "OBFUSCATE_POWER_1_DESCRIPTION", System = "OBFUSCATE_POWER_1_SYSTEM", Focus = focus[7], FocusEffect = "OBFUSCATE_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBFUSCATE_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "OBFUSCATE_NAME" },
                new Power { Level = 2, PowerName = "OBFUSCATE_POWER_2_NAME", Description = "OBFUSCATE_POWER_2_DESCRIPTION", System = "OBFUSCATE_POWER_2_SYSTEM", Focus = focus[8], FocusEffect = "OBFUSCATE_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBFUSCATE_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "OBFUSCATE_NAME" },
                new Power { Level = 3, PowerName = "OBFUSCATE_POWER_3_NAME", Description = "OBFUSCATE_POWER_3_DESCRIPTION", System = "OBFUSCATE_POWER_3_SYSTEM", Focus = focus[8], FocusEffect = "OBFUSCATE_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBFUSCATE_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "OBFUSCATE_NAME" },
                new Power { Level = 4, PowerName = "OBFUSCATE_POWER_4_NAME", Description = "OBFUSCATE_POWER_4_DESCRIPTION", System = "OBFUSCATE_POWER_4_SYSTEM", Focus = focus[7], FocusEffect = "OBFUSCATE_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBFUSCATE_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "OBFUSCATE_NAME" },
                new Power { Level = 5, PowerName = "OBFUSCATE_POWER_5_NAME", Description = "OBFUSCATE_POWER_5_DESCRIPTION", System = "OBFUSCATE_POWER_5_SYSTEM", Focus = focus[8], FocusEffect = "OBFUSCATE_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBFUSCATE_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "OBFUSCATE_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "OBFUSCATE_NAME", Text = "Occultation"},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_DESCRIPTION", Text = "En tant que créatures de la nuit, les Vampires comptent souvent sur leur capacité à rester cachés, passer inaperçu grâce à la discrétion et la diversion. L’Occultation est le pouvoir qui permet de brouiller l’esprit d’un autre, diminuant ses perceptions et le faisant manquer de petits détails ou des incohérences notables. Grâce à ce pouvoir, un Vampire peut changer son apparence physique, voler et dissimuler des objets de valeur, il peut même aller jusqu'à occulter un petit nombre d’individus de la vue de tous. Tant qu’un individu occulté n’attire pas l’attention sur lui ou n’interagit pas avec son environnement, comme en parlant à quelqu'un ou en manipulant un objet visible, il reste inaperçu. L'Occultation affecte les cinq sens. Ce pouvoir peut visuellement changer ou camoufler l’apparence physique d’un individu et également masquer des sons mineurs incompatibles. Il peut modifier la voix de l’utilisateur, dissimuler l’odeur de l’individu ou même faire en sorte qu’une veste en jean miteuse soit faite d’un cuir riche au toucher, tout cela pour soutenir un déguisement basé sur l’Occultation.<br /> <strong>Occultation et les Animaux</strong> <br /> Occasionnellement, des animaux peuvent sentir un vampire qui possède n’importe quel nombre de traits de la Bête quand il est proche, même quand ce vampire est caché ou altéré par l’Occultation. Cela ne permet pas à l’animal de percer l’Occultation du Vampire, mais l’animal deviendra visiblement nerveux, inquiet et agressif.<br /><strong>Occultation et Auspex</strong> <br />Un Vampire qui utilise Auspex peut tenter d’aiguiser ses sens pour percer l’Occultation d’un individu. L’utilisateur d’Auspex doit faire un test en utilisant son Score de Test <i>Mental + Investigation</i> contre le Score de Test <i>Mental + Volonté</i> de l’utilisateur d’Occultation. L’utilisateur d’Occultation peut choisir d’utiliser son Score de Test Mental + Discrétion comme Score de Test défensif. Si l’utilisateur d’Auspex réussit, il perce le pouvoir d’Occultation. <br /><strong>Occultation et les Machines</strong> <br />L'Occultation fonctionne en embrouillant l’esprit des observateurs, par conséquent cela n’a aucun effet sur les machines. Un personnage sous Occultation sera toujours repéré par un détecteur de métaux, sera pris en vidéo par une camera stationnaire ou automatique et son poids sera toujours détecté par les senseurs d’un ascenseur. Par contre, tout individu qui utilise ces machines peut négliger le personnage sous Occultation. Un paparazzi qui prend des photos peut faire une pause entre deux photos de la foule ou un garde d’aéroport retiendra peut-être son détecteur de métaux loin de l’individu sous Occultation sans s'en rendre compte. Un individu dans un ascenseur ne daignera pas regarder les senseurs d’un ascenseur, sauf si l’ascenseur déclenche mécaniquement une alarme.<br /> L'Occultation brouille aussi l’esprit de ceux qui observent un endroit à travers l’utilisation d’un équipement électronique (qu'il soit éloigné ou non), tant qu’ils regardent une retransmission en direct(ou légèrement différée). Un garde d’aéroport qui regarde un moniteur vidéo ne remarquera pas un personnage invisible capturé sur sa caméra de sécurité, même s'il y a quelque secondes de décalage naturel ou même une minute entière entre l’affichage et l’événement réel. Cependant, si ce même garde rembobine son enregistrement pour voir quelque chose qui s'est passé il y a 10 minutes ou plus dans le passé, il verra l’image du Vampire Occulté enregistrée par l’appareil."},

                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_1_NAME", Text = "Dissimuler"},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_1_DESCRIPTION", Text = "<i>Vous pouvoirs d’Occultation vous permettent d’estomper les objets en votre possession, faisant qu’ils soient ignorés par tous, même par ceux qui vous fouillent. Ces objets apparaissent et disparaissent selon votre volonté, dissimulés à la vue de tous tant qu’il ne sont pas activement utilisés.</i>"},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_1_SYSTEM", Text = "Dépensez une action standard pour dissimuler une arme ou tout autre objet que vous possédez ; l’objet ne doit pas dépasser une longueur de trois pieds (~= 90cm). Les objets sous Dissimuler sont invisibles tant qu’ils sont physiquement sur votre personne. Dissimuler ne peut pas être utilisé pour cacher des être vivants ou morts-vivants (ou des parties d’eux). Dissimuler ne peut pas être utilisé pour cacher un espace négatif ; s'il est possible de cacher une chaise, il est impossible de cacher l’embrasure d’une porte. Si un personnage regarde un objet pendant que vous utilisez Dissimuler dessus, l’observateur voit automatiquement au travers de cette utilisation d’Occultation. Cependant, si l’observateur détourne son regard plus de quelques secondes, comme un tour de combat, il perdra la trace de l’objet et celui-ci sera automatiquement dissimulé. <br />Dissimuler peut être utilisé pour maintenir l’invisibilité de trois objets en même temps. Vous pouvez cesser de Dissimuler un objet à n’importe quel moment. <br />Si vous interagissez avec un objet Dissimulé, en l’utilisant pour attaquer quelqu'un ou en attirant autrement l’attention sur ledit objet, il devient visible. Si vous placez d’autres personnages dans une position où ils sont obligés d’accepter logiquement l’existence d’un objet, il devient visible de tous. Par exemple, personne ne remarquera votre Fusil à Pompe tant qu’il est pendu dans un étui dorsal mais, si vous tendez le bras et que vous le dégainez visiblement, il apparaîtra. Les gens ne remarqueront peut-être pas que vous portez un livre mais, si vous luttez sous le poids d’une enclume à main, elle deviendra visible de tous."},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_1_FOCUS_DESCRIPTION", Text = "Vous pouvez Dissimuler jusqu'à 10 objets en même temps à un moment donné, tant qu’ils restent sur votre personne. Vous pouvez Dissimuler des objets qui font jusqu'à six pieds de long (1m82) au lieu de trois. Vous ne pouvez toujours pas Dissimuler des créatures vivantes ou mortes."},

                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_2_NAME", Text = "Présence Invisible"},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_2_DESCRIPTION", Text = "<i>Avec de la concentration, vous pouvez vous protéger de la perception des autres, embrouillant les esprits de ceux qui remarqueraient votre présence en temps normal dans la pièce. Vos pouvoirs d’occultation sont tellement développés que vous pouvez discrètement aller espionner les autres - ou vous échapper d’une situation difficile - tout en restant complètement invisible.</i>"},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_2_SYSTEM", Text = "Dépensez une action standard pour devenir invisible, Occultant aussi les objets inanimés présents sur vous. La Présence Invisible ne peut pas être utilisée pour rendre un autre personnage invisible même s'il est inconscient ou mort. Sous les effets de la présence invisible, les petits sons, petites odeurs ou d’autres effets mineurs de votre présence seront ignorés par les autres. Si vous parlez, touchez quelqu'un, produisez une odeur affreuse ou entreprenez toute action qui nécessite un Challenge, votre Présence Invisible prend immédiatement fin.<br /> Si un autre individu vous regarde quand vous activez la Présence Invisible, il voit automatiquement au travers de cette utilisation d’Occultation. Vous serez invisible à toute personne qui ne vous regardait pas quand vous avez utilisé votre Présence Invisible et, si la personne vous ayant perçue détourne le regard au loin pendant plus de quelques secondes, l’équivalent d’un tour en combat, il perd immédiatement votre trace.<br /> Si vous interagissez avec votre environnement, parlez avec un autre personnage ou attirez l’attention sur vous, votre Occultation se brise et vous devenez visible. Si vous placez d’autres personnages dans une position où ils sont obligés d’accepter logiquement votre existence, la Présence Invisible échoue et vous devenez visible de tous. Personne ne remarquera une personne debout dans une pièce, même s'ils doivent la contourner, tant qu’ils peuvent le faire facilement. Cependant, si le Vampire invisible bloque la sortie d’une pièce quand des personnes souhaiteront sortir, son invisibilité disparaîtra."},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_2_FOCUS_DESCRIPTION", Text = "Vous pouvez parler à voie basse ou utiliser votre action standard pour interagir avec un objet auquel on ne fait pas attention sans briser votre Présence Invisible. Vous pouvez glisser à vos alliés un \"attention\" ou rendre confus des spectateurs en ouvrant une porte sans briser votre Occultation. Votre Présence Invisible se brisera si vous criez, interagissez avec quelque chose qu’un autre personnage manipule ou entreprenez une action qui nécessite un Challenge."},

                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_3_NAME", Text = "Masque aux Milles Visages"},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_3_DESCRIPTION", Text = "<i>En modifiant la perception des autres à votre sujet et en embrouillant leur esprit, vous faites en sorte que des observateurs vous voient différemment. Vous pouvez utiliser ce pouvoir pour devenir un individu fade, indistinct et facilement oubliable dans une foule. Ou si vous le voulez, vous pouvez choisir de devenir un type spécifique de personne, comme un policier ou une serveuse. Avec quelques recherches, vous pouvez faire en sorte que votre forme physique reflète celle d’une autre personne que vous connaissez, prenant ses traits, vêtements, sonorité vocale et d’autres signes distinctifs. Ce pouvoir modifie aussi vos vêtements, les altérant à votre volonté (dans les limites de la crédibilité). Cependant, notez que ce pouvoir ne vous donne pas la capacité de connaître les excentricités d’un individu ou ses manies, ses particularités vocales, ses souvenirs ou ses grâces sociales ; seuls les détails de son apparence sont conférés.</i>"},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_3_SYSTEM", Text = "Dépensez une action standard pour vous envelopper dans un voile d’Occultation, vous changez ainsi tous les aspects sensoriels de votre apparence aussi bien dans tout ce qui est audible qu’olfactif. Vous pouvez utiliser le Masque aux Milles Visages pour apparaître aussi générique et oubliable que possible ou vous pouvez spécifiquement imiter l’apparence de quelqu'un que vous avez étudié. <br />Le Masque aux Milles Visages peut être utilisé pour imiter tout ce qui correspond généralement à votre forme. Un Vampire sous une apparence humaine peut ressembler à un vieillard, un enfant ou une femme au foyer, mais il ne peut pas prendre l’apparence d’un cheval. De même, un Vampire qui utilise la Forme de la Bête pour se transformer en un loup peut apparaître comme un gros chien, mais pas comme un homme.<br /> Pour fidèlement imiter l’apparence d’une personne spécifique, vous devez avoir au moins 2 points dans la capacité Subterfuge et vous devez étudier cette personne sous plusieurs angles pendant au moins 5 minutes pour apprendre ses expressions faciales, comment elle se déplace et autres traits distinctifs. Vous pouvez peut-être imiter le visage de quelqu'un après avoir étudié une photographie de lui par exemple, mais votre déguisement ne trompera personne qui a déjà rencontré cet individu auparavant car vous en savez trop peu sur lui pour le reproduire fidèlement. Pour reproduire avec fidélité la voix de votre cible, vous devez avoir au moins 3 points dans la capacité Subterfuge et vous devez l’avoir écoutée parler pendant au moins 5 minutes alors qu’il utilise un certain éventail de mots et de phrases. Écouter un enregistrement de la voix n’est pas suffisant pour une véritable imitation ; votre voix camouflée n’aura pas les subtilités nécessaires pour tromper quiconque ayant parlé à votre cible. <br />Le Masque aux Milles Visages peut être utilisé pour légèrement altérer l’apparence de vos vêtements et de votre équipement, tant que votre équipement ne change pas de taille ou de forme de manière significative. Un smoking peut apparaître comme un coupe - vent ou un ruban autour de votre cou peut apparaître comme une cravate chic mais ce pouvoir ne peut pas faire apparaître le smoking comme un trench-coat qui traîne sur le sol et ne peut donner l’apparence d’un stylo à un pistolet.Le Masque aux Milles Visages ne peut pas être utilisé pour rendre un objet invisible ou partiellement invisible. Vous pouvez peut - être faire apparaître un sweat à capuche et un jean comme un smoking et un pantalon, mais vous ne pouvez pas réduire leur taille comme si vous portiez un bikini. Le Masque aux Milles Visages ne peut qu’affecter des objets que vous tenez ou sur votre personne."},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_3_FOCUS_DESCRIPTION", Text = "Vous pouvez drastiquement changer l’apparence de votre garde-robe et de votre équipement. Vous êtes capable de faire apparaître un téléphone portable comme un fusil à pompe ou d’autres prouesses comme faire apparaître votre jean comme une robe de bal."},

                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_4_NAME", Text = "Disparition à la vue de l’Esprit"},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_4_DESCRIPTION", Text = "<i>Votre contrôle sur le pouvoir d’Occultation est tellement grand que des objets et vous peuvent disparaître de la vue de tous, même quand vous êtes activement observé.</i>"},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_4_SYSTEM", Text = "Quand vous activez Dissimuler ou Présence Invisible quand quelqu'un regarde, Disparition à la vue de l’Esprit vous permet de faire un Challenge opposé contre n’importe quel observateur, en utilisant le Score de Test d’Occultation. Si vous réussissez le Challenge, votre pouvoir se manifeste malgré leur vigilance et vous ou l’objet que vous ciblez devient invisible à la fin du round de jeu.<br /> Pour utiliser Disparition à la vue de l’Esprit contre de multiples observateurs, vous devez faire un test contre chaque observateur. Si vous dépensez un point de Volonté, vous gagnez un re-test contre chaque observateur. Si vous gagnez contre certains observateurs mais pas d’autres, seuls ceux qui ont échoué lors du Challenge ne sont plus capables de vous voir. Ceux qui ont réussi vous voient (ou l’objet que vous tentez de Dissimuler) comme si vous n’aviez pas utilisé Disparaître de l’Esprit. Comme les pouvoirs précédents d’Occultation, si une personne détourne le regard plus de quelques secondes, un tour de combat, il perd la trace de l’objet ou de l’individu couvert par l’Occultation. <br />Une fois que vous avez acheté Disparition à la vue de l’Esprit, les personnages avec le Sens Intensifié (Auspex) ne peuvent percer aucune de vos utilisations d’Occultation, sauf s'ils possèdent le 5ème point d’Auspex. En outre, les personnages sans les 5 points en Auspex ne remarquent pas automatiquement votre présence, peu importe à quel point vous vous approchez.<br /> Disparaître de l’Esprit peut être utilisé tous les tours, même ceux ou vous avez échoué le tour précédent. C'est une exception à la règle qui empêche un personnage de retenter immédiatement un Challenge mental raté."},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_4_EXCEPTIONALSUCCESS", Text = "Si vous marquez un succès exceptionnel contre quelqu'un qui essaye de voir au travers de votre Disparition à la vue de l’Esprit, cet observateur ne peut plus contester vos autres utilisations de Disparition à la vue de l’Esprit, Masque aux Milles Visages, Dissimuler ou Présence Invisible pendant la prochaine heure. Cela l’empêche d’utiliser des moyens normaux pour garder la vue sur vous, mais cela ne l’empêchera pas d’utiliser Auspex (s'il possède le pouvoir) pour percer vos utilisations d’Occultation."},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_4_FOCUS_DESCRIPTION", Text = "Quand vous perdez un test avec Disparition à la vue de l’Esprit, vous gagnez un re-test pour cette tentative sans avoir à utiliser de points de Volonté. Si vous n’arrivez pas à disparaître face à de multiples observateurs, vous gagnez ce bénéfice pour chaque Challenge raté, vous permettant de re-test chacun des observateurs. Ces re-tests agissent en tous points comme un re-test grâce à de la volonté."},

                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_5_NAME", Text = "Masquer l’Assemblée"},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_5_DESCRIPTION", Text = "<i>En tant que maître des pouvoirs de l’Occultation, vous pouvez étendre votre protection mentale aux autres, les dissimulant avec votre capacité. Avec de la concentration, vous pouvez les cacher du regard des autres ou leur offrir un déguisement.</i>"},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_5_SYSTEM", Text = "Quand vous dépensez une action standard pour activer votre Présence Invisible, Masque aux Milles Visages ou Disparition à la vue de l’Esprit, vous pouvez choisir d’étendre ses effets à des alliés proches. En utilisant Dissimuler l’Entourage, vous pouvez étendre l’un des pouvoirs d’Occultation ci-dessus à un nombre d’individus consentants égal au nombre de points dans votre compétence discrétion, avec un minimum de un.<br /> Les individus ressentent un frisson soudain et distinct quand Occultation est utilisée sur eux pour les dissimuler mais les cibles n’ont aucun moyen mystique de savoir qui est en train d’essayer d’utiliser ce pouvoir, ni dans quelle mesure. Si n’importe laquelle de vos cibles ne souhaite pas être affectée par Occultation, le pouvoir échoue immédiatement pour cet individu. Le pouvoir fonctionne de manière normale avec les autres cibles consentantes. Si un personnage affecté par l’un de vos pouvoirs d’Occultation devient réticent à n’importe quel moment, l’Occultation s'arrête immédiatement pour cet individu.<br /> Un personnage peut toujours voir au travers de sa propre utilisation d’Occultation, indépendamment de qui il affecte. De plus, les autres personnages dissimulés par un Dissimuler l’Entourage peuvent se voir les uns les autres normalement. Si l’un des alliés brise son Occultation ou bouge à plus de 20 pas de vous, le pouvoir cesse de fonctionner pour lui mais reste actif pour tous les autres personnages couverts par cette utilisation de Dissimuler l’Entourage. Cependant, si vous brisez l’Occultation, votre Dissimuler l’Entourage cesse de fonctionner pour tous. Quand ce pouvoir est utilisé pour augmenter celui de Disparition à la vue de l’Esprit, vous n’avez besoin que d’un seul test par observateur, comme si vous aviez disparu seul. Si vous réussissez, vous faites disparaître l’ensemble du groupe.<br /> Vous pouvez utiliser Dissimuler l’Entourage pour étendre plus d’un pouvoir d’Occultation, mais vous ne pouvez pas étendre le même pouvoir à plus d’un groupe en même temps. Par exemple, vous pouvez faire en sorte qu’un groupe de cinq personnes soit invisible et faire en sorte que cinq personnes ressemblent à des artistes de cirque, mais vous ne pouvez pas utiliser ce pouvoir plusieurs fois pour faire en sorte que 10 ou 15 personnes deviennent invisibles.<br /> Dissimuler l’Entourage ne peut être utilisé que sur des créatures intelligentes et ne confère pas la capacité d’occulter des animaux."},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "OBFUSCATE_POWER_5_FOCUS_DESCRIPTION", Text = "Vous pouvez étendre vos pouvoirs d’Occultation à un nombre d’individus consentants égal au double de vos points dans la compétence discrétion."},

                new Traduction{LCID = 1036, Key = "OBFUSCATE_TEST_SCORE", Text = "On utilise le Score de Test <i>Mental + Discrétion</i> de l’utilisateur d’Occultation contre le Score de Test <i>Mental + Volonté</i> de la cible."},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "OBFUSCATE_KEY",
                    DisciplineName = "OBFUSCATE_NAME",
                    Description = "OBFUSCATE_DESCRIPTION",
                    TestScore = "OBFUSCATE_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class ObtenebrationInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "OBTENEBRATION_POWER_1_NAME", Description = "OBTENEBRATION_POWER_1_DESCRIPTION", System = "OBTENEBRATION_POWER_1_SYSTEM", Focus = focus[5], FocusEffect = "OBTENEBRATION_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBTENEBRATION_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "OBTENEBRATION_NAME" },
                new Power { Level = 2, PowerName = "OBTENEBRATION_POWER_2_NAME", Description = "OBTENEBRATION_POWER_2_DESCRIPTION", System = "OBTENEBRATION_POWER_2_SYSTEM", Focus = focus[4], FocusEffect = "OBTENEBRATION_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBTENEBRATION_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "OBTENEBRATION_NAME" },
                new Power { Level = 3, PowerName = "OBTENEBRATION_POWER_3_NAME", Description = "OBTENEBRATION_POWER_3_DESCRIPTION", System = "OBTENEBRATION_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "OBTENEBRATION_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBTENEBRATION_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "OBTENEBRATION_NAME" },
                new Power { Level = 4, PowerName = "OBTENEBRATION_POWER_4_NAME", Description = "OBTENEBRATION_POWER_4_DESCRIPTION", System = "OBTENEBRATION_POWER_4_SYSTEM", Focus = focus[5], FocusEffect = "OBTENEBRATION_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBTENEBRATION_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "OBTENEBRATION_NAME" },
                new Power { Level = 5, PowerName = "OBTENEBRATION_POWER_5_NAME", Description = "OBTENEBRATION_POWER_5_DESCRIPTION", System = "OBTENEBRATION_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "OBTENEBRATION_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "OBTENEBRATION_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "OBTENEBRATION_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_NAME", Text = "Obténébration"},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_DESCRIPTION", Text = "Les maîtres de l’Obténébration peuvent commander aux ténèbres, leur ordonnant d’obéir à leur volonté. Alors que les profanes pensent que ce n’est rien de plus que quelques petits tours d’ombres, la vérité est bien plus dangereuse. L’Obténébration est complètement surnaturelle, appelant l’essence des Abîmes et les redessinant dans le monde réel. Ces ténèbres étouffent le son, absorbent la lumière et semblent presque tangibles. Ils sont aussi rétifs, se déplaçant et se tordant avec une conscience propre, à moins que leur maître ne les contrôle fermement. <br />Tous les esprits, quelle que soit leur nature, ont peur des Abîmes et les fantômes les fuiront plutôt que de risquer d’entrer dans une folie meurtrière à leur simple contact. <br />Tous les pouvoirs d’Obténébration, incluant les pouvoirs et les techniques d’Anciens, sont automatiquement dissipés s’ils sont exposés à la lumière du soleil."},

                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_1_NAME", Text = "Jeu d’Ombres"},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_1_DESCRIPTION", Text = "<i>À votre commandement, les ombres dans la zone se remplissent avec l’énergie de l’Abîme, se déplaçant et se reformant selon vos désirs. Ces ombres s’animent, tremblent et même parviennent à une certaine forme de conscience perverse limitée, se tendant pour porter un contact glacé à quiconque s’approcherait de trop près.</i>"},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_1_SYSTEM", Text = "Ce pouvoir accorde au Vampire le contrôle sur les ombres naturelles de la zone. Dépensez 1 point de Sang et effectuez une action simple pour animer une portion d’ombre se trouvant à proximité pour les 5 prochaines minutes. Vos ombres animées ne sont pas vraiment intelligentes mais elles possèdent une astuce suffisamment rudimentaire qui leur permet de suivre des instructions simples.<br /> Vos ombres sont semi-solides et capable de bouger des objets pesant jusqu’à 500 grammes. Les ombres animées possèdent une action standard par tour et peuvent l’utiliser pour bouger de trois pas, pour effectuer une action simple ou pour attaquer. Vos ombres animées bougent et attaquent toujours en groupe. <br />Si elles sont commandées pour attaquer, les ombres s’enroulent autour d’une cible, tentant de lui couper la respiration. Le challenge d’attaque des ombres est de 8. Les morts-vivants ne sont pas affectés par cette attaque, mais les vivants prennent 1 point de dommage par attaque réussie, qui ne peut être encaissé ou réduit, pendant que votre cible cesse peu à peu de respirer. Vos ombres animées sont des créatures indépendantes et leur demander d’attaquer ne vous demande pas d’action. Si vous êtes affecté par un pouvoir Mental ou Social, vos ombres sont aussi affectées. Si vous ne pouvez pas briser la Majesté de la cible, vos ombres seront incapables de l’attaquer. Ces assistants d’ombre sont immunisés aux dégâts physique mais sont automatiquement dissipés s'ils sont exposés au feu ou à la lumière vive. Même un seul point de dommage de feu, comme venant de balles incendiaires, est suffisant pour renvoyer ces rejetons des ombres dans les Abîmes.<br />Un personnage ne peut avoir qu’une seule utilisation de Jeu d’Ombres active en même temps."},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_1_FOCUS_DESCRIPTION", Text = "Vous pouvez former vos ombres à s’accrocher à votre corps, vous rendant extrêmement intimidant à regarder. Pendant que ce pouvoir est actif, votre contenance terrifiante vous immunise contre les succès exceptionnels de Domination et Présence."},

                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_2_NAME", Text = "Voile de Nuit"},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_2_DESCRIPTION", Text = "<i>En appelant à vous les profondeurs éternelles de l’Abîme, vous convoquez une bande de ténèbres épaisse et surnaturelle qui absorbe toute lumière et déforme les sons. Ceux qui se trouvent à l’intérieur ressentent un froid douloureux, entendent des murmures de lamentation et ressentent la pression des vagues de l’océan roulant à travers leurs corps vers...le néant.</i>"},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_2_SYSTEM", Text = "Dépensez 1 point de Sang et une action simple pour invoquer un nuage d’ombre visqueuse, l’essence même de l’Abîme. Vous pouvez convoquer ces ténèbres au sein de l’existence n’importe où dans votre ligne de vue. Le <i>Voile de Nuit</i> a un diamètre de 6 pas et obscurcit toutes les lumières se trouvant à l’intérieur, créant une zone artificielle de ténèbres surnaturels.<br /> N’importe qui piégé dans votre <i>Voile de Nuit</i> est aveuglé, sauf s’il possède des moyens surnaturels de voir au travers du vide. Les individus dans le voile doivent utiliser les règles de Combat en Aveugle pour attaquer. Les personnages possédant des pouvoirs comme les Yeux de la Bête peuvent voir au travers du <i>Voile de Nuit</i> et les personnages avec des pouvoirs sensoriels comme Sens Aiguisés peuvent palier la cécité, leur permettant d’attaquer normalement. <br />À l’intérieur du voile, la plupart des créatures vivantes comme les animaux ou les gens subissent 1 point de dommage normal chaque tour lors de votre initiative, pendant que l’Abîme vole leur respiration et sape leur volonté de vivre. Ces dommages ne peuvent être encaissés ou réduits. Les Morts-vivants sont immunisés à ces effets, tout comme les créatures vivantes possédant un focus d’Endurance.<br /> Vous êtes immunisé aux effets de votre propre <i>Voile de Nuit</i> ; vous voyez normalement à travers le voile et vous n’êtes pas troublé par son toucher. Après avoir créé un <i>Voile de Nuit</i>, vous pouvez dépenser une action simple pour bouger votre voile de 3 pas dans n’importe quelle direction.Vous pouvez aussi dépenser une action simple et 1 point de Sang pour augmenter le rayon du voile de 2 pas, après qu’il ait été invoqué par une première utilisation de ce pouvoir."},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_2_FOCUS_DESCRIPTION", Text = "Votre <i>Voile de Nuit</i> manifeste un lien plus fort avec les énergies surnaturelles de l’Abîme. Les Morts-vivants restent immunisés aux effets de dommages de votre voile, mais les créatures vivantes perdent 3 points de dégâts au lieu d’1. Même les créatures qui ont un focus d’Endurance ne peuvent facilement se dérober à ses effets ; ils prennent 2 points de dommages par tour passé dans le voile.De plus, tous les individus dans le voile souffrent d’une pénalité de - 2 au Score de Test d’Attaque(Physique, Mental et Social).Les personnages utilisant des pouvoirs surnaturels pour se dérober à la cécité causée par votre voile ne sont pas immunisés à cette pénalité de - 2.Les personnages utilisant les règles de Combat en Aveugle ne souffrent pas de cette pénalité de - 2."},

                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_3_NAME", Text = "Bras des abysses"},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_3_DESCRIPTION", Text = "<i>Au fur et à mesure que votre maîtrise d’Obténébration grandit, vos capacités a invoquer l’Abîme deviennent encore plus terrifiantes. Vous pouvez appeler des tentacules de ténèbres des Abîmes, des créatures liées aux ombres elles-mêmes. Ces serviteurs frappent et s’enroulent à votre commandement, ils sont au service de tous vos désirs.</i>"},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_3_SYSTEM", Text = "Dépensez 1 point de Sang et une action simple pour lever des tentacules depuis les ombres dans votre champ de vision. Ces tentacules sont une manifestation tangible de la conscience primale du vide de l’Abîme. Quand vous activez ce pouvoir, vous créez un <i>Bras des abysses</i> pour chaque pouvoir d’Obténébration que vous possédez, incluant les techniques, jusqu’à un maximum de 5. Les <i>Bras des abysses</i> ne peuvent pas bouger de l’endroit où ils ont été invoqués. <br />Chaque <i>Bras des abysses</i> agit indépendamment des autres, fonctionnant comme une créature entièrement consciente. Un <i>Bras des abysses</i> a une action standard par tour. Il peut utiliser cette action pour attaquer n’importe quelle cible dans les 2 pas. Les <i>Bras des abysses</i> ont un Score de Test d’Attaque de 8 et une attaque réussie inflige 1 point de dégât normal. Cependant, au lieu d’infliger des dommages, vous pouvez choisir qu’un <i>Bras des abysses</i> agrippe sa cible. De cette manière, un <i>Bras des abysses</i> peut utiliser la manœuvre Agripper sans dépenser de Volonté. Dans un combat de masse, les <i>Bras des abysses</i> peuvent fournir la tactique d’attaque assistée à un allié proche. Si cela arrive, les <i>Bras des abysses</i> donnent +1 de bonus au Score de Test d’Attaque de cet allié, de la même manière que la réserve d’un PNJ. Les <i>Bras des abysses</i> ne peuvent pas fournir de tactique de défense assistée. <br />Les <i>Bras des abysses</i> n’ont pas d’esprit et ne peuvent donc être la cible de pouvoirs Mentaux et Sociaux. Toutefois, si vous êtes incapable d’attaquer une cible, vos bras sont aussi incapables de porter une action hostile. Par exemple, si vous ne pouvez pas briser la Majesté de votre cible, vos <i>Bras des abysses</i> ne seront pas capable de l’attaquer non plus. <br />Un <i>Bras des abysses</i> a 4 niveaux de santé. Les bras sont immédiatement détruits s’ils sont exposés à la lumière du jour."},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_3_FOCUS_DESCRIPTION", Text = "Vos <i>Bras des Abysses</i> ont un Score de Test d’Attaque de 10. Si vous possédez au moins 1 point de Puissance, vos <i>Bras des Abysses</i> infligent 2 points de dégâts normaux au lieu de 1. Si vous possédez au moins 1 point de Force d’âme, vos <i>Bras des Abysses</i> ont 6 niveaux de santé au lieu de 4."},

                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_4_NAME", Text = "Sombre Métamorphose"},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_4_DESCRIPTION", Text = "<i>En drapant les ténèbres de l’Abîme autour de votre corps, vous fusionnez votre corps avec la conscience des anciennes profondeurs. Des bandes de ténèbres ondulent autour de votre chair pâle et des tentacules remuants apparaissent sur votre cage thoracique, vous transformant en une créature de l’Abîme.</i>"},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_4_SYSTEM", Text = "Dépensez 1 point de Sang et une action simple pour vous transformer en une monstrueuse créature d’ombre. La matière brute du vide vous enveloppe dans des bandes ondulantes et 4 tentacules (similaires en apparence aux Bras des Abysses) émergent de votre cage thoracique. Les membres ajoutés par la Sombre Métamorphose ne peuvent pas attaquer indépendamment, mais s’ajoutent à vos propres actions. Une fois par tour, à votre initiative, vous pouvez effectuer une attaque de Mélée avec les bras fournis par la Sombre Métamorphose, sans dépenser d’action. Cette attaque peut cibler n’importe qui dans les 5 pas. Les Attaques faites avec la Sombre Métamorphose utilisent votre score de Mélée et infligent vos dégâts de Mélée.<br /> Les attaques de la Sombre Métamorphose peuvent être modifiées par votre pouvoir de Puissance, incluant la Puissance d’Ancien et les techniques de Puissance mais ne peuvent être modifiées par aucune autre discipline. La Sombre Métamorphose ne peut être utilisée pour attaquer pendant une phase de Célérité. Les attaques de la Sombre Métamorphose peuvent être modifiés en manœuvre pour Agripper mais vous devez payer le prix normal de cette manœuvre. La Sombre Métamorphose ne peut être modifiée par une manœuvre de combat autre que celle pour Agripper.<br /> La Sombre Métamorphose est un pouvoir de transformation et ne peut être combinée avec un autre pouvoir de transformation. Vous pouvez mettre fin à cette transformation à n’importe quel moment en dépensant une action simple. La Sombre Métamorphose est assez humanoïde pour permettre de porter des armes."},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_4_FOCUS_DESCRIPTION", Text = "Pendant que vous êtes sous les effets de la Sombre Métamorphose, vous pouvez ressentir parfaitement votre environnement, même dans les profondeurs de la nuit ou pendant que vous êtes à l’intérieur d’un autre effet d’Obténébration. Vous êtes immunisé à tous les effets du Voile de Nuit, même la pénalité de -2 infligée par l’effet de focus du Voile de Nuit. De plus, votre figure terrifiante vous immunise aux effets exceptionnels des pouvoirs de Présence et de Domination."},

                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_5_NAME", Text = "Forme Ténébreuse"},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_5_DESCRIPTION", Text = "<i>En invoquant ce pouvoir, vous ne vous contentez pas d’invoquer la puissance de l’Abîme ; vous permettez au vide d’entrer dans votre esprit et de se manifester dans votre âme. Votre forme physique se transmute en un corps d’ombre : une forme ondulante et liquide de vide absolu. Tant que vous êtes sous cette forme, vous pouvez vous glisser à travers les trous et les fissures et vous pouvez voir à travers toutes les formes de ténèbres.</i>"},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_5_SYSTEM", Text = "Dépensez 1 point de Sang et vos actions simple et standard afin de vous transformer en une créature coulante d’ombre liquide.<br /> Tant que vous êtes sous Forme Ténébreuse, vous ne pouvez pas dépenser de point de Sang, activer des pouvoirs ou attaquer physiquement, mais vous êtes aussi immunisé à toutes les attaques Physiques provenant de sources autres que le feu ou la lumière du Soleil. Vous pouvez être blessé par des attaques non-Physiques et vous pouvez être blessé par des armes enflammées, comme une torche ou une fusée de détresse ; toutefois, les munitions incendiaires passent au travers de votre corps trop rapidement pour infliger des dommages.Vous prenez 1 point de dégât aggravé additionnel par le feu, les armes enflammées ou la lumière du soleil tant que vous êtes sous cette forme. Tant que vous êtes sous Forme Ténébreuse, vous n’êtes pas vraiment intangible. Vous êtes capable de vous faufiler dans des petites ouvertures, passer sous les portes et de vous infiltrer dans les trous mais vous ne pouvez pas passer au travers d’objets solides.<br /> Un personnage sous Forme Ténébreuse peut marcher et bouger normalement. De plus, vous pouvez bouger à vitesse normale tant que vous marchez sur une surface solide, incluant les murs et les plafonds. Même si vous ne pouvez pas voler, vous ne prenez pas de dégât de chute tant que vous êtes sous Forme Ténébreuse.Vous pouvez être touché si un individu passe sa main au travers de votre forme et vous pouvez toucher d’autres personnages en étendant un membre ténébreux ou en glissant sur eux. Toucher ou être touché peut demander une attaque de Mélée.<br /> Forme Ténébreuse est un pouvoir de transformation et ne peut être combinée avec d’autres pouvoirs de transformation."},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "OBTENEBRATION_POWER_5_FOCUS_DESCRIPTION", Text = "Vous pouvez dépenser 1 point de Sang pendant que vous êtes sous Forme Ténébreuse pour faire apparaître des yeux rouges brillants. Faire ceci vous permet d’utiliser les 3 premiers points de Domination et de Présence pendant que vous êtes en forme d’ombre, tant que vous possédez ces pouvoirs. Ceci est une exception à la règle qui interdit au personnage d’utiliser des disciplines ou de dépenser du Sang sous Forme Ténébreuse."},

                new Traduction{LCID = 1036, Key = "OBTENEBRATION_TEST_SCORE", Text = "Il n’y a pas de Score de Test générique pour l’Obténébration."},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "OBTENEBRATION_KEY",
                    DisciplineName = "OBTENEBRATION_NAME",
                    Description = "OBTENEBRATION_DESCRIPTION",
                    TestScore = "OBTENEBRATION_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class PotenceInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "POTENCE_POWER_1_NAME", Description = "POTENCE_POWER_1_DESCRIPTION", System = "POTENCE_POWER_1_SYSTEM", Focus = null, FocusEffect = "POTENCE_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "POTENCE_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "POTENCE_NAME" },
                new Power { Level = 2, PowerName = "POTENCE_POWER_2_NAME", Description = "POTENCE_POWER_2_DESCRIPTION", System = "POTENCE_POWER_2_SYSTEM", Focus = null, FocusEffect = "POTENCE_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "POTENCE_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "POTENCE_NAME" },
                new Power { Level = 3, PowerName = "POTENCE_POWER_3_NAME", Description = "POTENCE_POWER_3_DESCRIPTION", System = "POTENCE_POWER_3_SYSTEM", Focus = null, FocusEffect = "POTENCE_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "POTENCE_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "POTENCE_NAME" },
                new Power { Level = 4, PowerName = "POTENCE_POWER_4_NAME", Description = "POTENCE_POWER_4_DESCRIPTION", System = "POTENCE_POWER_4_SYSTEM", Focus = null, FocusEffect = "POTENCE_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "POTENCE_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "POTENCE_NAME" },
                new Power { Level = 5, PowerName = "POTENCE_POWER_5_NAME", Description = "POTENCE_POWER_5_DESCRIPTION", System = "POTENCE_POWER_5_SYSTEM", Focus = null, FocusEffect = "POTENCE_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "POTENCE_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "POTENCE_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "POTENCE_NAME", Text = "Puissance"},
                new Traduction{LCID = 1036, Key = "POTENCE_DESCRIPTION", Text = "Tous les vampires sont capables de faire preuve d’une force extraordinaire durant un court instant, via la dépense de sang. Ceux maîtrisant la discipline de Puissance savent accéder au caractère originel de leur sang, leur permettant de rendre une telle force permanente. Le pouvoir inhumain de Puissance est incroyable et clairement surnaturel. Avec cette discipline, un vampire peut aisément briser des os ou de la pierre. Une armure devient insignifiante, tout comme les obstacles. Quoi qu’il y ait sur leur route, cela sera démoli ou propulsé de côté. Chaque niveau de Puissance représente un accroissement de la force physique d’un personnage et les effets de chaque niveau s’additionnent. Si votre personnage possède Vigueur (Puissance •••), il dispose des bonus de Prouesse (Puissance •) et de Redoutable (Puissance ••), qui sont nécessaires pour disposer de Vigueur. Les pouvoirs de Puissance sont toujours actifs et ne requièrent normalement pas de Sang pour être effectifs. Certaines Techniques et pouvoirs d’Anciens peuvent nécessiter du Sang ou une action afin d’être activés ; référez - vous à la description de chaque pouvoir pour les précisions.Les pouvoirs de Puissance ne peuvent être utilisés en dehors d’une allonge correspondant à du combat à mains nues ou aux armes de mêlée, à moins que le pouvoir ne précise le contraire. Il n’y a pas de Score de Test générique pour Puissance.<br /> <strong>Focus : Force</strong><br />Les personnages avec un Focus en Force qui ont au moins 1 niveau en Puissance ajoutent +2 à leur Score de test en Bagarre et en Mêlée."},

                new Traduction{LCID = 1036, Key = "POTENCE_POWER_1_NAME", Text = "Prouesse"},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_1_DESCRIPTION", Text = "<i>Vos coups parviennent à causer des commotions remarquables, brisant les équipements de protection et les os des mortels d’un seul coup.</i>"},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_1_SYSTEM", Text = "Vos attaques en Bagarre et en Mêlée sont perforantes. Les bonus d’armure de votre adversaire sont ignorés."},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_1_FOCUS_DESCRIPTION", Text = null},

                new Traduction{LCID = 1036, Key = "POTENCE_POWER_2_NAME", Text = "Redoutable"},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_2_DESCRIPTION", Text = "<i>Votre force est clairement surnaturelle. Vous frappez avec une force redoutable, accablant vos ennemis de coups incroyables.</i>"},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_2_SYSTEM", Text = "Lors d’une attaque de Bagarre ou de Mêlée réussie, votre personnage inflige automatiquement 2 points de dommage. Succès Normal: Votre personnage inflige 2points de dommage à ce niveau de Puissance. Succès Exceptionnel: Votre personnage inflige 3 points de dommage."},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_2_FOCUS_DESCRIPTION", Text = null},

                new Traduction{LCID = 1036, Key = "POTENCE_POWER_3_NAME", Text = "Vigueur"},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_3_DESCRIPTION", Text = "<i>Avec une musculature aussi monumentale, vous pouvez aisément soulever des centaines de livres et avoir assez de force pour briser des poutres de soutien en métal ou bien encore renverser des murs en brique.</i>"},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_3_SYSTEM", Text = "Lors d’une attaque en Bagarre ou en Mêlée, vous obtenez un bonus de +5 pour déterminer si l’attaque est ou non un succès exceptionnel."},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_3_FOCUS_DESCRIPTION", Text = null},

                new Traduction{LCID = 1036, Key = "POTENCE_POWER_4_NAME", Text = "Intensité"},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_4_DESCRIPTION", Text = "<i>Un tel niveau de force vous permet de projeter un véhicule à proximité, de tordre le fer et l’acier avec aisance. Vos coups sont dévastateurs pour vos malheureux ennemis se trouvant sur votre passage.</i>"},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_4_SYSTEM", Text = "À chaque succès exceptionnel en Bagarre ou en Mêlée, votre personnage inflige automatiquement 2 points de dommage supplémentaires plutôt qu’1 point, comme c’est habituellement le cas lors des succès exceptionnels. Succès Normal: Votre personnage inflige 2 points de dommages à ce niveau de Puissance. Succès Exceptionnel: Votre personnage inflige 4 points de dégâts plutôt que les 3 habituels quand vous réalisez un succès exceptionnel."},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_4_FOCUS_DESCRIPTION", Text = null},

                new Traduction{LCID = 1036, Key = "POTENCE_POWER_5_NAME", Text = "Toute-Puissance"},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_5_DESCRIPTION", Text = "<i>La force que vous pouvez rassembler est monumentale, délivrant à chaque coup une puissance phénoménale. Un tel pouvoir est au-delà du surnaturel et frise la légende.</i>"},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_5_SYSTEM", Text = "Quand vous réussissez une attaque en Bagarre ou en mêlée, votre personnage inflige 3 points de dégâts. Cette somme comprend le bonus octroyé par le pouvoir Redoutable. Notez qu’Intensité ajoute toujours un point supplémentaire de dégâts, mais seulement lorsque le succès est exceptionnel. Succès Normal: Votre personnage inflige 3 points de dégâts à ce niveau de Puissance. Succès Exceptionnel: Votre personnage inflige 5 points de dommage au lieu de 4.Ce nombre comprend le bonus du pouvoir Intensité."},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "POTENCE_POWER_5_FOCUS_DESCRIPTION", Text = null},

                new Traduction{LCID = 1036, Key = "POTENCE_TEST_SCORE", Text = "Il n’y a pas de Score de Test générique pour Puissance."},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "POTENCE_KEY",
                    DisciplineName = "POTENCE_NAME",
                    Description = "POTENCE_DESCRIPTION",
                    TestScore = "POTENCE_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class PresenceInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "PRESENCE_POWER_1_NAME", Description = "PRESENCE_POWER_1_DESCRIPTION", System = "PRESENCE_POWER_1_SYSTEM", Focus = focus[5], FocusEffect = "PRESENCE_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "PRESENCE_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "PRESENCE_NAME" },
                new Power { Level = 2, PowerName = "PRESENCE_POWER_2_NAME", Description = "PRESENCE_POWER_2_DESCRIPTION", System = "PRESENCE_POWER_2_SYSTEM", Focus = focus[4], FocusEffect = "PRESENCE_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "PRESENCE_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "PRESENCE_NAME" },
                new Power { Level = 3, PowerName = "PRESENCE_POWER_3_NAME", Description = "PRESENCE_POWER_3_DESCRIPTION", System = "PRESENCE_POWER_3_SYSTEM", Focus = focus[5], FocusEffect = "PRESENCE_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "PRESENCE_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "PRESENCE_NAME" },
                new Power { Level = 4, PowerName = "PRESENCE_POWER_4_NAME", Description = "PRESENCE_POWER_4_DESCRIPTION", System = "PRESENCE_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "PRESENCE_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "PRESENCE_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "PRESENCE_NAME" },
                new Power { Level = 5, PowerName = "PRESENCE_POWER_5_NAME", Description = "PRESENCE_POWER_5_DESCRIPTION", System = "PRESENCE_POWER_5_SYSTEM", Focus = focus[5], FocusEffect = "PRESENCE_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "PRESENCE_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "PRESENCE_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "PRESENCE_NAME", Text = "Présence"},
                new Traduction{LCID = 1036, Key = "PRESENCE_DESCRIPTION", Text = "La beauté et l’élégance des Vampires ont inspiré des générations de mortels à écrire des poèmes, chansons et histoires, toutes luttant pour relater la magnificence des ces séduisants morts-vivants. Rien n’attire davantage l’attention que l’aura naturelle d’un Vampire pour commander, intimider ou se rendre sensuel et les pratiquants de la discipline Présence maîtrisent cette capacité. De telles créatures peuvent inspirer la terreur, séduire ou apporter un terrible désespoir aux malheureux amants dont son attention s’est éloignée. Au travers de l’utilisation de Présence, les vampires pratiquent une manipulation subtile. Là où la Domination est un marteau, la Présence est une main de fer dans un gant de velours. Cette discipline peut renverser les émotions sans que l’on s'en rende compte, si les effets sont subtilement appliqués. Mais la présence n’altère ni la manière de penser d’un sujet ni sa personnalité ; elle enflamme simplement les sentiments et l’affection de la cible, l’obligeant à ressentir de nouvelles émotions. Ceux ciblés par Présence ne perdent pas leur santé mentale et ne sont pas non plus enclins à croire des choses ridicules simplement parce que le Vampire a dit que c’était la vérité.Toujours est-il qu’avec de l’inspiration, de l’éloquence ou des dons de richesses utilisés en combinaison avec cette discipline, peuvent apporter des soutiens permanents au Vampire."},

                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_1_NAME", Text = "Admiration"},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_1_DESCRIPTION", Text = "<i>Vous vous faites remarquer même dans les salles les plus animées. Votre beauté et votre charisme attirent l’attention des autres comme des papillons de nuit vers une flamme. Même ceux qui sont en désaccord avec votre cause ou vos objectifs s’arrêteront et vous écouteront, ne serait-ce que pour vous accorder le bénéfice du doute pendant un moment.</i>"},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_1_SYSTEM", Text = "Pour activer Admiration, dépensez un point de sang et une action standard. Pour le reste de la scène, vous semblez plus grand que nature, plus impressionnant qu’à l’accoutumée et tous ceux à portée de conversation vous accorderont leur attention et sentiront un fort désir d’être proche de vous. Les personnages affectés par l’Admiration ne sont pas poussés à davantage vous faire confiance ou à arrêter de vous attaquer, mais ils doivent vous porter une attention particulière. Une cible affectée par Admiration est considérée comme automatiquement concentrée sur vous, selon la règle du Regard et Focalisation.<br /> Les Personnages peuvent ignorer les effets d’Admiration pendant une heure, même s'ils proviennent de différents individus, en dépensant un point de Volonté"},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_1_FOCUS_DESCRIPTION", Text = null},

                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_2_NAME", Text = "Regard Terrifiant"},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_2_DESCRIPTION", Text = "<i>La bête d’un vampire est une entité terrifiante, sauvage et prédatrice. Utiliser le Regard Terrifiant permet à la Bête de faire surface, concentrant sa rage contre un seul individu. La nature sanguinaire du Vampire est révélée par ses traits alors que la Bête crache ou rugit d’une colère noire et primitive. Ceux ciblés par ce terrifiant pouvoir tremblent en le voyant ou fuient devant la fureur de la bête.</i>"},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_2_SYSTEM", Text = "Dépensez une action standard alors que votre personnage montre ses crocs en sifflant ou hurlant sur sa cible et initiez le challenge opposé avec votre cible. Si vous remportez le challenge, elle est submergée par la peur. La cible ne viendra pas de son plein gré à moins de 5 pas de vous pendant les 5 prochaines minutes, cherchant activement à éviter votre présence et votre colère.<br /> Un personnage affecté par votre Regard Terrifiant ne vous attaquera pas, sauf s'il n’a plus aucun recours. Si elle est confinée en un lieu avec vous, la victime peut vous combattre pour vous échapper, mais s'éloignera et interrompra le combat à la première occasion."},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_2_EXCEPTIONALSUCCESS", Text = "Pour le reste de la soirée, si vous faites un mouvement un tant soit peu agressif vers un individu qui a subi avec succès votre Regard Terrifiant, il subira à nouveau l’effet du pouvoir et le forcera à battre en retraite, subissant les effets du Regard Terrifiant pendant cinq nouvelles minutes."},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_2_FOCUS_DESCRIPTION", Text = "Vous pouvez exposer la fureur de votre bête sans révéler votre nature vampirique. Au lieu de sortir vos crocs et siffler, vous fixez votre cible des yeux. Ils semblent brillants et perçants, vos sourcils froncés et vos traits brièvement déformés par la colère ; vos mouvements sont ceux d’un prédateur - mais votre visage n’est pas un bris de Mascarade. Les observateurs noteront que vous apparaissez comme agressif envers votre cible mais rien ne peut leur faire penser que vous êtes un Vampire."},

                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_3_NAME", Text = "Envoûtement"},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_3_DESCRIPTION", Text = "<i>Un doux sourire peut renverser le plus dur des cœurs. Vous êtes la vedette du rassemblement, une étoile dans le ciel nuageux, le seul récepteur de l’attention. Peu sont ceux qui peuvent rivaliser face à votre beauté et votre grâce et ceux qui sont suffisamment chanceux pour attirer votre attention feront tout ce qu’ils peuvent pour la garder.</i>"},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_3_SYSTEM", Text = "Pour activer Envoûtement, dépensez 1 point de sang, dépensez une action standard et initiez un Challenge opposé avec votre cible. En cas de succès, vous faites plier les émotions de votre cible et conquérez son cœur. Elle vous devient immédiatement réceptive, rationalisant tout sentiment de dédain ou négatif qu’elle avait à votre égard avant que vous n’utilisiez ce pouvoir. Bien que la cible ne soit pas votre esclave et n’obéisse pas à tous vos ordres, elle vous admire grandement et est disposée à vous aider dans les limites du raisonnable.<br /> A la fois pendant les effets du pouvoir et après que le pouvoir s'est estompé, le sujet va rationaliser les effets de l’Envoûtement. Ceux qui étaient déjà particulièrement disposés envers vous se souviennent que vous étiez particulièrement séduisant ; ceux qui avait une antipathie modérée envers vous blâment à contrecœur leur changement d’opinion sur le compte de vos incroyables talents de persuasion. Seul un individu qui vous vilipende activement et souhaite vous nuire verra clairement que ses actions ont été manipulées.Les autres spectateurs, ceux qui peuvent voir l’individu envoûté, peuvent mieux se rendre compte qu’il est sous l’influence de votre contrôle émotionnel - mais il sera particulièrement difficile de convaincre un individu envoûté que tel est le cas.<br /> Les personnages envoûtés ne peuvent se résoudre à vous faire du mal, physiquement ou politiquement, et seront en général sympathiques avec vous aussi raisonnablement que possible. Envoûtement n’est pas un contrôle mental et les personnages envoûtés ne sont pas obligés de suivre vos instructions à la lettre. Ils feront en sorte de vous faire plaisir et soutiendront votre cause en cas de conflit ou d’argumentation, du moment qu’ils ne se mettent pas en danger ce faisant.Un personnage envoûté ne se liera pas au sang avec vous ou ne risquera pas sa vie pour vous défendre, mais il vous donnera de l’aide tant que la situation n’est pas dangereuse. <br />Si vous attaquez quelqu'un que vous avez envoûté, les effets du pouvoir s'arrêtent immédiatement."},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_3_EXCEPTIONALSUCCESS", Text = "Si vous parvenez à faire un succès exceptionnel, la cible de votre Envoûtement subit une pénalité de -3 pour résister ou surmonter vos autres pouvoirs de Présence pour la durée de ses effets. Tous les pouvoirs de Présence, Pouvoirs d’Anciens et toutes les techniques basées sur la Présence bénéficient de ce malus."},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_3_FOCUS_DESCRIPTION", Text = "Quand vous utilisez Envoûtement avec succès, ses effets durent trois heures au lieu d’une."},

                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_4_NAME", Text = "Convocation"},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_4_DESCRIPTION", Text = "<i>Vos pouvoirs de persuasion sont tellement puissants que vous pouvez mystiquement contraindre les autres à venir quand vous les appelez, même s'ils sont à des kilomètres de distance. Le simple souvenir de votre beauté et de votre personnalité inspirante les hante alors qu’ils ressentent le doux appel de votre esprit pour qu’ils viennent à vos côtés.</i>"},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_4_SYSTEM", Text = "Pour convoquer un autre individu, dépensez 1 point de sang et une action standard. Faites un challenge opposé contre la cible qui vous est familière. Pour plus d’informations sur la familiarité, consultez la règle de Familiarité avec la Cible. <br />Une fois que vous avez commencé une convocation, vous ne pouvez pas quitter la zone d’où vous avez lancé le pouvoir ou la convocation prend immédiatement fin. Si vous réussissez, la cible prend immédiatement conscience du fait qu’elle a été affectée par l’utilisation d’un pouvoir, ainsi que de l’identité de celui qui a lancé la convocation et le lieu où elle doit vous rencontrer. Si votre cible ne vous fait pas confiance, elle peux utiliser un temps bref, jusqu'à dix minutes, pour prendre des précautions avant de répondre à votre convocation. <br />Une cible convoquée viendra aussi vite et directement que possible, mais elle conservera ses instincts de survie. La cible ne marchera pas du haut d’une falaise ou ne s'engagera pas dans une situation qu’elle peut détecter comme une embuscade. <br />S'il n’est pas possible pour un personnage de venir se présenter physiquement à vous sans s'engager dans une situation dangereuse, la cible doit se rapprocher de vous autant que possible et vous contacter différemment, comme un appel téléphonique, forcer un humain à vous livrer une note ou envoyer un messager animal. Si la cible n’est pas consciente des risques pour sa sécurité, elle répondra en personne à votre convocation, même si vos plans à son sujet sont sinistres. <br />Les mortels convoqués continueront de suivre votre appel malgré toute distance et quel que soit le temps qu’il leur faudra pour vous rejoindre, tant que vous restez sur les lieux où vous avez initié la convocation. Éventuellement, ils se présenteront à vous, même s'ils ont dû voyager pendant des jours. Les créatures surnaturelles voyagent aussi rapidement qu’elles le peuvent jusqu'à ce qu’elles vous rejoignent ou jusqu'au prochain lever du soleil, peu importe ce qui vient en premier."},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_4_EXCEPTIONALSUCCESS", Text = "La cible de votre Convocation ne sait pas que le pouvoir a été utilisé et, par conséquent, ne peut pas sentir l’identité de celui qui le convoque. Elle se déplacera pour se présenter jusqu'à vous sans se savoir pourquoi - ni ou où elle va. La convocation prend quand même fin si votre cible ne peut pas vous approcher sans marcher dans une situation manifestement dangereuse."},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_4_FOCUS_DESCRIPTION", Text = "Vous pouvez convoquer sans dépenser de points de sang ni d’actions standard vos serviteurs, goules et tout individu lié à vous au sang. Vous pouvez utiliser cet aspect de la convocation même en étant pieuté ou en torpeur. Ceci est la seule exception à la règle qui empêche l’utilisation de pouvoir alors qu’un personnage est en torpeur ou pieuté."},

                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_5_NAME", Text = "Majesté"},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_5_DESCRIPTION", Text = "<i>Vous maîtrisez la capacité à canaliser les émotions de votre Bête Vampirique, concentrant sa rage en une sombre, majestueuse aura qui semble presque palpable. Votre force de personnalité force les cœurs faibles à fléchir, les individus craintifs à se baisser ou ramper alors que vous exigez leur respect. Les cœurs se brisent sur votre passage et même les plus stoïques tremblent quand vous passez, submergés par l’autorité et la souveraineté de votre personnalité. Vous prenez les traits et la contenance des anciens dirigeants, tant qu’ils sont correctement exprimés - que ce soit grâce à de l’intimidation et la domination, une adoration obséquieuse, un magnétisme sexuel ou par la grâce et la pureté.</i>"},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_5_SYSTEM", Text = "Dépensez 1 point de sang et une action standard pour activer la Majesté. Pendant l’heure qui suit, vous apparaissez comme l’apothéose de la meilleur nature de votre personnage - étonnamment beau, épouvantablement cruel, majestueux au-delà de tout reproche ou autre - tant qu’il reflète la personnalité de votre personnage. La sensation de la Majesté d’un personnage est variable car cela dépend de son humeur actuelle et de sa personnalité.<br /> La Majesté se manifeste comme une présence émotionnelle dominatrice, qui amplifie la nature du personnage. Tant que ce pouvoir est actif, les autres ne peuvent pas vous manquer de respect et, s'ils peuvent ne pas être d’accord avec vous, ils doivent le montrer avec la plus grande courtoisie. Quiconque aimerait vous attaquer ou être vulgaire envers votre personnage doit entreprendre un challenge opposé avec vous, utilisant son Score de Test de <i>Social + Volonté</i> contre votre Score de Test de <i>Social + Commandement</i>. Si l’attaquant rate ce challenge, il ne peut pas faire d’autres tentatives contre vous pendant les prochaines 10 minutes. Il devient prisonnier des effets de votre Majesté et continuera à vous traiter avec respect et courtoisie même s'il quitte les lieux. Une fois que 10 minutes se sont écoulées, l’attaquant peut à nouveau tenter de briser votre majesté. Cet effet est aussi appliqué aux pouvoirs qui ne visent pas directement l’utilisateur de Majesté, mais visent l’endroit englobant l’utilisateur de la Majesté. Si un personnage veut enflammer une pièce et que l’un des personnages présents a sa Majesté activée, l’attaquant doit faire un Test contre cette Majesté pour entreprendre son action. <br />Si vous attaquez un individu affecté par votre Majesté ou si vous utilisez un pouvoir contre lui, votre Majesté est immédiatement brisée pour cet individu. Il devient insensible à votre majesté pour l’heure qui suit et vous traitera tel qu’il le ferait normalement, même vous attaquer comme il l’entend. Cette rupture de la Majesté n’affecte qu’un individu en particulier ; les autres personnes présentes affectées par votre Majesté ne sont pas libérés simplement parce qu’ils sont témoins de votre agression envers l’un de leurs amis.<br /> Pendant une scène de combat de masse, si vous utilisez la tactique \"Aider un Défenseur\" pour forcer quelqu'un à vous attaquer plutôt que leur cible, votre Majesté est automatiquement rompue pour cet attaquant, car vous avez agi de manière agressive envers lui. Si vous attaquez un personnage qui est assisté par la tactique \"Aider un Défenseur\", votre Majesté est rompue tant pour la nouvelle cible que la cible d’origine sauf si vous renoncez à votre attaque quand un autre joueur déclare son intention d’utiliser la tactique \"Aider un Défenseur\".Pour plus d’informations, regardez les règles de Combat de Masse."},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "PRESENCE_POWER_5_FOCUS_DESCRIPTION", Text = "Tant que votre Majesté est activée, vous ignorez la Majesté des autres personnages."},

                new Traduction{LCID = 1036, Key = "PRESENCE_TEST_SCORE", Text = "Un utilisateur de Présence doit utiliser son Score de Test <i>Social + Commandement</i> contre le Score de Test <i>Social + Volonté</i> de la cible."},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "PRESENCE_KEY",
                    DisciplineName = "PRESENCE_NAME",
                    Description = "PRESENCE_DESCRIPTION",
                    TestScore = "PRESENCE_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class ProteanInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "PROTEAN_POWER_1_NAME", Description = "PROTEAN_POWER_1_DESCRIPTION", System = "PROTEAN_POWER_1_SYSTEM", Focus = focus[6], FocusEffect = "PROTEAN_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "PROTEAN_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "PROTEAN_NAME" },
                new Power { Level = 2, PowerName = "PROTEAN_POWER_2_NAME", Description = "PROTEAN_POWER_2_DESCRIPTION", System = "PROTEAN_POWER_2_SYSTEM", Focus = focus[8], FocusEffect = "PROTEAN_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "PROTEAN_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "PROTEAN_NAME" },
                new Power { Level = 3, PowerName = "PROTEAN_POWER_3_NAME", Description = "PROTEAN_POWER_3_DESCRIPTION", System = "PROTEAN_POWER_3_SYSTEM", Focus = focus[6], FocusEffect = "PROTEAN_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "PROTEAN_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "PROTEAN_NAME" },
                new Power { Level = 4, PowerName = "PROTEAN_POWER_4_NAME", Description = "PROTEAN_POWER_4_DESCRIPTION", System = "PROTEAN_POWER_4_SYSTEM", Focus = focus[8], FocusEffect = "PROTEAN_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "PROTEAN_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "PROTEAN_NAME" },
                new Power { Level = 5, PowerName = "PROTEAN_POWER_5_NAME", Description = "PROTEAN_POWER_5_DESCRIPTION", System = "PROTEAN_POWER_5_SYSTEM", Focus = focus[8], FocusEffect = "PROTEAN_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "PROTEAN_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "PROTEAN_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "PROTEAN_NAME", Text = "Protéisme"},
                new Traduction{LCID = 1036, Key = "PROTEAN_DESCRIPTION", Text = "Pendant des centaines d’années, les vampires se sont maintenus à l’abri des villes, se cachant parmi l’homme mortel. Le désert était trop indompté pour tous, sauf les plus sauvages et les plus hardis. La discipline de Protéisme, développée d’abord parmi les Gangrels, a permis à un vampire de trouver un abri dans le sol de la terre, ou de voyager aussi rapidement qu’une chauve-souris pourrait voler ou un loup pourrait courir. Protéisme a été essentiel à la survie vampirique au Moyen Âge et, même dans les nuits modernes, il reste une des disciplines les plus iconiques et renommées des enfants de Caïn."},

                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_1_NAME", Text = "Yeux de la Bête"},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_1_DESCRIPTION", Text = "<i>Avec seulement un moment de concentration, vous pouvez modifier la composition de vos yeux pour ressembler plus à ceux d’un animal. Votre capacité à voir dans l’obscurité augmente, mais cette réfraction donne aussi à vos yeux une lueur mystérieusement animale.</i>"},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_1_SYSTEM", Text = "Dépensez 1 Sang et utilisez une action simple pour activer les Yeux de la Bête. Pour l’heure suivante, vos yeux brillent d’un rouge doux et sauvage. Tant que l’effet est actif, vous pouvez voir parfaitement même dans l’obscurité. Tant que votre personnage n’est pas physiquement aveuglé, vous pouvez combattre dans l’obscurité sans avoir besoin de la manœuvre de combat \"Combat aveugle\"."},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_1_FOCUS_DESCRIPTION", Text = "Vos Yeux de la Bête sont toujours actifs, et vous n’avez pas besoin de dépenser du Sang pour activer ce pouvoir. Contrairement à l’activation standard de ce pouvoir, vos yeux ne brillent pas, sauf si vous choisissez de les faire briller. Faire en sorte que vos yeux brillent, ou cessent de briller, nécessite la dépense d’une action simple."},

                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_2_NAME", Text = "Griffes Bestiales"},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_2_DESCRIPTION", Text = "<i>En activant ce pouvoir, vos ongles s'allongent et se durcissent en griffes pointues et puissantes. Ces griffes sont surnaturelles et capables de déchiqueter la chair, la pierre ou même de minces feuilles de métal. Vous pouvez rétracter ces griffes avec un simple effort de volonté, vos mains reviennent à leur état normal.</i>"},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_2_SYSTEM", Text = "Dépensez 1 point de Sang et utilisez une action simple pour activer Griffes Bestiales. Vos ongles s'aiguisent, durcissent et s'allongent en Griffes Bestiales clairement visibles. Le fait de frapper un ennemi avec vos Griffes Bestiales inflige des dégâts aggravés. Vous pouvez rétracter vos Griffes bestiales à tout moment en dépensant une action simple. Un personnage attaquant avec Griffes Bestiales utilise son attribut Physique + Bagarre contre l’attribut physique de la cible + Esquive.<br /> Si vos griffes se brisent, vous pouvez les faire repousser en réactivant ce pouvoir"},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_2_FOCUS_DESCRIPTION", Text = "Vous pouvez faire pousser ou rétracter les Griffes bestiales à tout moment sans dépenser une action. De plus, lorsque vous activez Griffes bestiales, vos muscles se réarrangent subtilement pour rendre l’attaque plus efficace. En combattant avec Griffes bestiales, vous recevez un bonus de +1 à vos Scores de Test d’Attaque en Bagarre."},

                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_3_NAME", Text = "Fusion avec la terre"},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_3_DESCRIPTION", Text = "<i>Avant l’avènement du transport rapide et la civilisation généralisée, le pouvoir de fusion avec la terre afin de dormir en toute sécurité, caché du soleil, était absolument essentiel à la survie des vampires. En utilisant ce pouvoir, un vampire peut mystiquement se mélanger avec le sol à ses pieds, et rester caché là jusqu'à ce qu’il veuille se lever.</i>"},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_3_SYSTEM", Text = "Dépensez 1 point de sang et utilisez votre action simple pour vous enfoncer dans le sol. Vous devez toucher la terre (argile, sol, ou toute autre terre de consistance molle) afin d’utiliser Fusion avec la terre. <br />Bien que joint à la terre, le vampire existe sous une forme semi-solide et ne peut pas faire d’actions ou utiliser des pouvoirs.Les personnages fusionnés sont semi - conscients, mais ne sont pas conscients de leur environnement. Fusion avec la terre abrite un personnage de la lumière du soleil durant la journée, ou du feu brûlant le sol au dessus de lui, il rend le vampire immunisé à la plupart des formes de dommages physiques. <br />Une perturbation importante dans le sol où un personnage est mélangé met fin prématurément à ce pouvoir.Si quelqu'un passe trois actions standard causant une telle perturbation, le vampire est immédiatement éjecté du sol.Un vampire éjecté s'éveille immédiatement dans une pluie de boue dans un large rayon lié à sa violente sortie du sol. Utiliser des outils pour perturber le terrain peut réduire le nombre d’actions nécessaires pour perturber une Fusion avec la terre. Par exemple, un personnage avec une pelle pourrait être en mesure d’éjecter un vampire fusionné avec deux actions standard, alors qu’un personnage avec une bombe tuyau pourrait l’éjecter avec une seule action standard. <br />Fusion avec la terre permet à un vampire de sombrer dans la boue ou des substances avec une consistance semblable, comme le sable ou le gravier, mais ne peut pas être utilisé pour mélanger avec (ou traverser) le béton, roche, métal, plastique, bois ou tout autre revêtement de sol. Fusion avec la terre ne peut être combinée à des pouvoirs transformateurs ; en se fondant avec la terre, un vampire revient à son état natal."},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_3_FOCUS_DESCRIPTION", Text = "Éveillé et en fusion avec la terre, vous pouvez percevoir votre environnement comme si vous étiez debout au-dessus du sol avec lequel vous êtes fusionné. Si un personnage fusionné dort ou est volontairement en torpeur, il se réveille dès que quelqu'un commence à perturber le sol de son lieu de repos, bien que le réveil ne soit pas automatique et exige tous les tests normaux et les dépenses."},

                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_4_NAME", Text = "Forme de la bête"},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_4_DESCRIPTION", Text = "<i>Une des capacités les plus renommées possédées par les vampires, ce pouvoir vous permet de prendre la forme d’un loup ou une chauve-souris, littéralement modifier votre chair et os dans un nouvel état. Bien qu’une telle bête ne soit pas plus vivante que le vampire, elle est capable de voler, de courir ou d’utiliser ses sens animaux comme un membre vivant de son espèce.</i>"},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_4_SYSTEM", Text = "Dépensez 1 point de sang et utilisez une action standard pour vous transformer en chauve-souris (votre forme de vol) ou en loup (votre forme de combat). Vous pouvez mettre fin à votre transformation Forme de la Bête à tout moment en dépensant une action simple.<br /> Lorsque vous êtes en forme de vol, vous gagnez un bonus de + 3 aux Scores de Test Défensifs basés sur Esquive et vous pouvez voler à votre vitesse normale de déplacement. Toutefois, en raison de la petite taille de la chauve - souris, votre attribut physique est réduit à 3 dans le cas d’attaques physiques. <br />En forme de combat, vous gagnez un bonus de +2 aux Scores de Test d’Attaque en Bagarre, et vos attaques de bagarre, en mordant ou griffant, infligent des dégâts aggravés.<br />Les deux formes animales convertissent et conservent les qualités physiques importantes et les défauts notables liés à l’apparence de votre forme humanoïde, comme être borgne, une touffe de cheveux blancs ou toute autre caractéristique distinctive. Les vampires sur les voies semblent monstrueux dans la forme animale, et les Nosferatu ou d’autres vampires défigurés font des animaux laids, en effet. Forme de la Bête est un pouvoir de transformation et ne peut être combinée avec d’autres pouvoirs de transformation."},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_4_FOCUS_DESCRIPTION", Text = "Lorsque vous achetez Forme de la bête, vous pouvez choisir de modifier thématiquement vos formes de combat et de vol, en changeant leur apparence en quelque chose qui convient à l’histoire de votre personnage ou archétype. Les créatures que vous choisissez doivent être des prédateurs ou des charognards, des mangeurs de viande ; ils ne peuvent pas être des insectes ou des herbivores, et doivent être des animaux que votre personnage pourrait logiquement rencontrer en personne(pas d’animaux éteints ou imaginaires). Une fois que vous avez sélectionné les formes de vol et de combat de votre personnage, vous ne pouvez pas les modifier par la suite.<br /> Au lieu d’une chauve-souris, vous pouvez vous transformer en n’importe quel petit animal volant que vous souhaitez. Les exemples incluent les corbeaux, les hiboux, ou les vautours. Au lieu d’un loup, vous pouvez vous transformer en n’importe quel prédateur terrestre ou aquatique de taille similaire.Les exemples incluent les lynx, les dragons de Komodo, les renards, les léopards, les hyènes, les requins, les carcajous ou les petits ours. Votre Conteur est l’arbitre final pour savoir si un animal particulier est un choix approprié pour Forme de la Bête. <br /> Toutes les formes de vol reçoivent le même bonus et ont les mêmes inconvénients; vous gagnez un bonus de + 3 aux Scores de Test défensifs basés sur Esquive et pouvez voler à votre vitesse normale de déplacement.Toutefois, en raison de votre taille relativement petite, votre attribut physique est réduit à 3 dans le but d’attaques physiques. <br />Lorsque vous choisissez votre forme de combat, vous pouvez appliquer l’un des modèles suivants selon le cas pour l’animal que vous choisissez, en plus d’utiliser les bonus standards et les désavantages du modèle de loup.Vous pouvez également appliquer un de ces modèles, même si vous choisissez de conserver l’aspect visuel d’un loup; ces modèles rendent simplement votre propre loup plus singulier. <br /> • <strong>Énorme</strong>: Vous vous transformez en un grand animal lourd, gagnant 2 niveaux de blessures supplémentaires. <br />• <strong>Brutal</strong>: Vous recevez un bonus supplémentaire de +1 aux Scores de Test d’Attaque basés sur Bagarre. Ce bonus s'accumule avec le bonus normal de +2 gagné en forme de combat Forme de la Bête(+3 au total). <br /> • <strong>Rapide</strong>: Si vous utilisez vos actions simple et standard pour bouger, vous pouvez vous déplacer de neuf pas par round au lieu des six pas standard. <br /> • <strong>Agile</strong>: Vous gagnez un bonus de + 1 à vos test défensifs basés sur Esquive. <br />• <strong>Aquatique</strong>: Vous pouvez nager à votre vitesse normale de déplacement, mais votre vitesse terrestre est réduite à un pas par action, ou, à votre discrétion, vous ne pouvez pas vous déplacer sur terre tout en étant sous cette forme. Tout en étant submergé, vous recevez un bonus de +2 aux Scores de Tests d’Attaque basés sur Bagarre. Ce bonus s'accumule avec le bonus normal de forme de combat de la Forme de la Bête (+4 au total)."},

                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_5_NAME", Text = "Forme de brume"},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_5_DESCRIPTION", Text = "<i>Comme les vampires du mythe antique, vous avez atteint un tel contrôle sur votre forme physique que vous pouvez vous dissoudre dans un doux nuage de brume, vous dispersant dans une petite zone. Ce brouillard est visible et perceptible (tout comme le brouillard sur les landes), ainsi que d’un froid mordant au toucher. Vous contrôlez les mouvements du nuage comme vous le feriez pour votre corps, et vous pouvez glisser à travers des fissures, de petits trous, ou sous des portes fermées.</i>"},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_5_SYSTEM", Text = "Dépensez 1 point de Sang et dépensez une action standard pour vous transformer en un nuage de brume. En forme de brume, vous ne pouvez pas dépenser de sang, parler, activer des pouvoirs, ou attaquer physiquement, mais vous êtes également à l’abri des attaques physiques d’autres sources que le feu et la lumière du soleil. Vous pouvez être blessé par des attaques non-physiques et par des armes flamboyantes, comme une torche ou une fusée de secours ; cependant, les munitions incendiaires passent au travers de votre forme trop rapidement pour infliger des dommages.<br /> En forme de brume, vous êtes un nuage semi-solide, fluctuant.Vous pouvez passer à travers toute fissure, trou, ou ouverture que la brume pourrait normalement traverser. Vous ne pouvez pas passer à travers des objets solides ou des passages hermétiques, vous ne pouvez pas voyager à travers les vitres, vous ne vous condensez pas. Vous ne pouvez pas voler, même si vous pouvez voyager le long de surfaces inclinées ou surélevées, comme un mur. Vous ne prenez aucun dommage de chute, mais ne pouvez pas contrôler la vitesse de la chute ni l’emplacement exact de votre atterrissage. <br />En forme de brume, vous vous déplacez d’un pas par action simple, ou deux pas par action simple si vous vous déplacez dans la même direction qu’un niveau important de vent.Si vous essayez de bouger de nouveau contre un débit d’air important, vous devez faire un Attribut physique + Test d’athlétisme à une difficulté établie par votre Conteur, en fonction de la vitesse du vent que vous essayez de combattre.<br /> En forme de brume, vous êtes effectivement de la vapeur d’eau, et vous avez une présence physique tangible.Vous pouvez être touché par n’importe qui s'il passe sa main au travers de votre forme, et vous pouvez toucher d’autres individus en circulant dans la direction de la cible Toucher ou être touché peut exiger une attaque Bagarre.<br /> Forme de brume est un pouvoir de transformation et ne peut pas être combiné avec d’autres pouvoirs de transformation."},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "PROTEAN_POWER_5_FOCUS_DESCRIPTION", Text = "Tant que Forme de brume est actif, vous pouvez vous déplacer de trois pas par action simple dans n’importe quelle direction, quelle que soit la direction ou comment souffle le vent. En outre, vous pouvez voler à trois pas par action simple."},

                new Traduction{LCID = 1036, Key = "PROTEAN_TEST_SCORE", Text = "Il n’y a pas de de Score de Test générique pour Protéisme."},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "PROTEAN_KEY",
                    DisciplineName = "PROTEAN_NAME",
                    Description = "PROTEAN_DESCRIPTION",
                    TestScore = "PROTEAN_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class QuietusInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "QUIESTUS_POWER_1_NAME", Description = "QUIESTUS_POWER_1_DESCRIPTION", System = "QUIESTUS_POWER_1_SYSTEM", Focus = focus[8], FocusEffect = "QUIESTUS_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "QUIESTUS_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "QUIESTUS_NAME" },
                new Power { Level = 2, PowerName = "QUIESTUS_POWER_2_NAME", Description = "QUIESTUS_POWER_2_DESCRIPTION", System = "QUIESTUS_POWER_2_SYSTEM", Focus = focus[7], FocusEffect = "QUIESTUS_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "QUIESTUS_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "QUIESTUS_NAME" },
                new Power { Level = 3, PowerName = "QUIESTUS_POWER_3_NAME", Description = "QUIESTUS_POWER_3_DESCRIPTION", System = "QUIESTUS_POWER_3_SYSTEM", Focus = focus[8], FocusEffect = "QUIESTUS_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "QUIESTUS_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "QUIESTUS_NAME" },
                new Power { Level = 4, PowerName = "QUIESTUS_POWER_4_NAME", Description = "QUIESTUS_POWER_4_DESCRIPTION", System = "QUIESTUS_POWER_4_SYSTEM", Focus = focus[7], FocusEffect = "QUIESTUS_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "QUIESTUS_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "QUIESTUS_NAME" },
                new Power { Level = 5, PowerName = "QUIESTUS_POWER_5_NAME", Description = "QUIESTUS_POWER_5_DESCRIPTION", System = "QUIESTUS_POWER_5_SYSTEM", Focus = focus[7], FocusEffect = "QUIESTUS_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "QUIESTUS_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "QUIESTUS_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "QUIESTUS_NAME", Text = "Quietus"},
                new Traduction{LCID = 1036, Key = "QUIESTUS_DESCRIPTION", Text = "Quietus est une discipline sacrée pour les membres du clan Assamite, qui voient son utilisation comme une pratique révérée. Basé sur l’altération du sang, le contrôle de la vitae et la pestilence, le Quietus se concentre sur le fait d’affaiblir et de blesser sa cible pour qu’elle soit détruite plus facilement. A travers l’usage de cette discipline, un Vampire peut devenir un redoutable Assassin qui sème la mort, ne laissant qu’une traînée de sang noircie derrière lui pour en raconter l’histoire.<br /> <strong>Application sur Arme</strong>: Une seule arme ne peut être recouverte avec plusieurs pouvoirs de Quietus en même temps.Quand un personnage se bat avec plusieurs armes qui ont été recouvertes par plusieurs pouvoirs différents de Quietus, seul le pouvoir de l’arme principale affecte la cible."},

                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_1_NAME", Text = "Silence de la Mort"},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_1_DESCRIPTION", Text = "<i>La première leçon est celle du silence. L’anonymat et la surprise sont deux des plus redoutables armes présentes dans l’arsenal du Vampire, l’embuscade étant un avantage de poids dans n’importe quelle situation. Avec l’utilisation de ce pouvoir, vous pouvez masquer votre approche, attaquer et vous échapper. Vous pouvez étouffer les supplications désespérées de votre victime alors qu’elle essaye d’obtenir de l’aide ou votre pitié.</i>"},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_1_SYSTEM", Text = "En dépensant un point de sang et une action simple, vous créez une sphère de silence absolu autour de vous qui inclut votre forme physique. Cette sphère s'étend à un maximum de trois pas autour de vous dans toutes les directions, cependant, vous pouvez choisir de réduire cette zone si vous le souhaitez. Une fois créée, vous pouvez réduire la taille de la sphère en dépensant une action simple, mais vous ne pouvez pas l’étendre au-delà de la limite des trois pas.<br /> Les sons qui proviennent de l’intérieur de votre sphère sont tus. Les pouvoirs qui reposent sur le son sont complètement bloqués par le Silence de Mort. Cela peut signifier que ces pouvoirs échouent dès leur lancement, parce que l’utilisateur se situe dans la zone de silence, ou cela peut vouloir dire que ces pouvoirs échouent car la cible est située à l’intérieur de la sphère de Silence. Cela inclut les pouvoirs comme le pouvoir de Melpominée et certains pouvoirs de Domination (toutefois, des pouvoirs de Domination peuvent être utilisés sans bruit, et de telles utilisations réussissent). <br />Notez bien que certaines utilisations de la Magie du Sang, comme la Thaumaturgie et la Nécromancie, requièrent que l’utilisateur puisse parler. Cependant, ces pouvoirs ne nécessitent pas que la cible puisse les entendre. Par conséquent, ces pouvoirs ne sont pas entravés par le Silence de Mort, même si l’utilisateur est dans la bulle de silence.<br /> Le Silence de Mort dure 10 minutes au maximum, sauf si l’utilisateur brise le pouvoir plus tôt au prix d’une action simple."},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_1_FOCUS_DESCRIPTION", Text = "Votre Silence de Mort peut maintenant s'étendre à cinq pas. Vous pouvez aussi maintenant utiliser le Silence de Mort sur un lieu statique au lieu de vous entourer. Une fois que vous avez créé un Silence de Mort statique, la sphère reste localisée au même endroit même si vous l’aviez placée sur un objet qui a été déplacé."},

                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_2_NAME", Text = "Le Toucher du Scorpion"},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_2_DESCRIPTION", Text = "<i>Par la méditation, l’utilisation des concoctions de plantes et de soporifiques naturels, vous pouvez changer les propriétés de votre Vitae. En activant ce pouvoir, votre sang est transformé en un puissant poison qui ralentit les proies blessées et les prive de leur capacité à se battre.</i>"},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_2_SYSTEM", Text = "Dépensez 1 point de sang et une action simple pour méditer et faire appel aux propriétés de votre Vitae. Ensuite, faites passer une lame aiguisée sur votre peau, créant une coupure peu profonde afin de recouvrir le bord de l’arme avec une couche de votre propre vitae. Cette arme doit être utilisée rapidement, avant que le sang ne sèche et perde ses propriétés surnaturelles. Pour les trois prochains tours, quiconque frappé par cette arme est empoisonné par votre sang venimeux.<br /> Ceux frappés par une arme couverte d’un Toucher du Scorpion souffrent d’une pénalité de -2 sur tous leurs Scores de Test d’Attaque Physique. Ces pénalités durent 5 minutes. Chaque application du Toucher du Scorpion supplémentaire ne rajoute pas plus de pénalités physiques, mais allonge la durée des effets de 5 minutes supplémentaires. Par exemple, un personnage frappé par trois de ces attaques souffre d’une pénalité de -2 sur ses tous ses Scores de Test d’Attaque Physique pendant les prochaines 15 minutes.<br /> Un individu qui a été touché par une arme couverte du Toucher du Scorpion subit ces pénalités, même si l’attaque n’a infligé aucun dégât après que l’adversaire a appliqué tous ses pouvoirs défensifs. Le venin a seulement besoin de toucher sa cible, pas de lui faire des dégâts.<br /> Vous êtes immunisé à votre propre Toucher du Scorpion, mais d’autres individus qui utilisent vos armes recouvertes du venin courent le risque de se faire empoisonner. Si quelqu'un d’autre utilise une arme recouverte de votre Toucher du Scorpion, cette personne recevra toutes les pénalités du pouvoir si elle perd n’importe quel test dans le Challenge. Cela se produit même si la personne gagne le Challenge global. Il est possible que la cible et celui qui manie l’arme soient empoisonnés dans la même action. Si la personne qui manie l’arme perd de manière répétée ses tests dans le Challenge, les effets du poison sont allongés de la même manière qu’une cible qui se ferait frapper plusieurs fois.<br /> Vous ne pouvez empoisonner qu’une seule arme de la taille d’une épée ou plus petite à chaque utilisation du Toucher du Scorpion. L’objet peut être de la taille d’une dague, une épée ou un carreau d’arbalète ou un objet similaire. Si vous recouvrez un objet non tranchant, vous devez dépenser une action standard plutôt qu’une action simple, pour ouvrir votre chair d’une autre manière et recouvrir l’arme de vitae.<br /> Le Toucher du Scorpion ne peut pas être utilisé sur les balles ou autre équipements de type armes à feu, la chaleur et la vitesse dégagées par une arme à feu détruisant le revêtement de sang de tout projectile tiré. Le Toucher du Scorpion ne peut être utilisé avec des attaques à mains nues."},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_2_FOCUS_DESCRIPTION", Text = "Les armes enrobées par votre Toucher du Scorpion restent toxiques pendant cinq tours au lieu de trois. De plus, vous pouvez choisir d’épaissir l’ichor de votre sang suffisamment pour que des personnes autres que vous puissent les manier en toute sécurité et sans risquer d’être affecté par votre poison. Toute personne empoisonnée par votre Toucher du Scorpion subit une pénalité -3 à tous les Scores de Test d’Attaque Physique."},

                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_3_NAME", Text = "L’Appel de Dagon"},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_3_DESCRIPTION", Text = "<i>Ce pouvoir vicieux permet à un Vampire d’utiliser le sang de sa cible contre elle-même, faisant éclater les vaisseaux sanguins et provoquant dans les organes de graves hémorragies internes. Ces ruptures sont extrêmement douloureuses, délivrant une vive agonie à quiconque est affecté par ce pouvoir.</i>"},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_3_SYSTEM", Text = "Dépensez 1 point de sang et une action standard puis engagez avec votre cible un challenge opposé en utilisant le score de test de Quietus. En cas de réussite, vous provoquez l’hémorragie et la rupture des organes de votre cible.<br /> Un personnage ciblé avec succès par l’appel de Dagon prend 2 points de dégâts normaux durant un tour au cours duquel il aura dépensé du sang. Ces dégâts se produisent au moment où la victime dépense son premier point de sang dans un tour donné. Après le premier tour, vous pouvez utiliser une action simple sur chaque tour suivant afin de maintenir l’effet de ce pouvoir, pour un maximum de cinq tours au total. Les dégâts causés par l’Appel de Dagon ne peuvent être réduits ou annulés. Plusieurs utilisations de l’Appel de Dagon ne se cumulent pas. Un personnage affecté par deux utilisations de l’Appel de Dagon continue de subir 2 dégâts normaux par tour où il utilise du sang."},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_3_EXCEPTIONALSUCCESS", Text = "Votre cible subit 3 dégâts normaux au lieu de 2, sur chaque tour pendant lequel elle utilise du sang."},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_3_FOCUS_DESCRIPTION", Text = "Si votre cible a de votre sang sur sa personne (qu'elle en ait conscience ou non) ou si votre cible a ingéré de votre sang dans les dernières 24 heures, vous n’avez pas besoin d’une ligne de vue pour utiliser l’Appel de Dagon tant que votre cible est dans un rayon d’un kilomètre et demi (1 mile) de vous. Ceux qui ont été affectés par votre Toucher du Scorpion ou Caresse de Baal sont considérés comme ayant de votre sang sur eux dans le cadre de l’utilisation de l’Appel de Dagon."},

                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_4_NAME", Text = "Caresse de Baal"},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_4_DESCRIPTION", Text = "<i>En approfondissant son étude de la transformation de la Vitae, l’utilisateur de Quietus peut altérer encore plus profondément les propriétés de son sang, le transformant en un ichor particulièrement corrosif. Cet ichor détruit toutes les chairs qu’il touche, qu’elles soient vivantes ou mortes-vivantes.</i>"},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_4_SYSTEM", Text = "Dépensez 1 point de sang et une action simple pour méditer et faire appel aux propriétés de votre Vitae. Faites ensuite passer une lame aiguisée sur votre peau, créant une coupure peu profonde afin de recouvrir le bord de l’arme avec une couche de votre propre Vitae. Cette arme doit être utilisée rapidement, avant que le sang ne sèche et perde ses propriétés surnaturelles. Pour les trois prochains tours, l’arme gagne le trait \"Mortel\" et quiconque frappé par cette arme subit les dégâts de l’arme en aggravés. Notez bien que la Caresse de Baal n’accroît pas la quantité de dégâts d’une arme donnée, mais cette arme inflige maintenant des dégâts aggravés plutôt que des dégâts normaux.<br /> Vous êtes immunisé à votre propre Caresse de Baal, mais d’autres individus qui utilisent vos armes recouvertes du venin courent le risque de se faire blesser. Si quelqu'un d’autre utilise une arme recouverte de votre Caresse de Baal, cette personne recevra un dégât aggravé si elle perd n’importe quel test dans le Challenge. Cela se produit même si la personne gagne le Challenge global. Il est possible que la cible et celui qui manie l’arme soient blessés dans la même action. Si la personne qui manie l’arme perd de manière répétée ses tests dans le Challenge, elle subira le même nombre de dégâts aggravés.<br /> Vous ne pouvez empoisonner qu’une seule arme de la taille d’une épée ou plus petite à chaque utilisation de la Caresse de Baal. L’objet peut être de la taille d’une dague, d’une épée, d’une flèche ou d’un carreau d’arbalète ou bien quelque chose de similaire. Si vous recouvrez un objet non tranchant, vous devez dépenser une action standard plutôt qu’une action simple, pour ouvrir votre chair d’une autre manière et recouvrir l’arme de vitae. <br />La Caresse de Baal ne peut pas être utilisée sur des balles ou autre équipements de type armes à feu, la chaleur et la vitesse dégagée par une arme à feu détruisant le revêtement de sang de tout projectile tiré. La Caresse de Baal ne peut être utilisée à mains nues."},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_4_FOCUS_DESCRIPTION", Text = "Les armes enrobées par votre Caresse de Baal restent toxiques pendant cinq tours au lieu de la durée standard de trois tours. De plus, vous pouvez choisir de suffisamment épaissir l’ichor issu de votre sang afin que d’autres individus que vous puissent manier les armes sans risquer de se blesser."},

                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_5_NAME", Text = "Goût de la Mort"},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_5_DESCRIPTION", Text = "<i>Avec ce niveau de maîtrise, un vampire peut transformer une petite partie de son sang en un acide caustique et qui, ainsi transmuté, permet au vampire de cracher ce sang acide sur un adversaire, brûlant la chair et corrodant ses os.</i>"},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_5_SYSTEM", Text = "Dépensez un point de sang. Pour le reste du tour, vous pouvez utiliser une action standard pour cracher votre sang toxique sur votre cible. Les attaques faites avec le Goût de la Mort utilisent le Score de Test suivant : Attribut <i>Physique + Athlétique</i> contre l’Attribut <i>Physique</i> de la cible.<br /> Quand vous attaquez avec un Goût de la Mort, vous devez choisir si le sang que vous crachez est transmuté selon le pouvoir de Toucher du Scorpion ou celui de la Caresse de Baal.En utilisant le Toucher du Scorpion via le Goût de la Mort provoque les pénalités décrites sous ce pouvoir.Utiliser la Caresse de Baal provoque deux dégâts aggravés à votre cible. <br /> utilisé pendant des rounds de Célérité."},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "QUIESTUS_POWER_5_FOCUS_DESCRIPTION", Text = "Si le Goût de la Mort est utilisé pour porter le Toucher du Scorpion, quiconque touché par le poison subit un malus de -3 sur ses Scores de Test d’Attaque Physique au lieu de la pénalité standard de -2. Si le Goût de la Mort est utilisé pour porter la Caresse de Baal, vous infligez 3 dégâts aggravés, au lieu des 2 standard."},

                new Traduction{LCID = 1036, Key = "QUIESTUS_TEST_SCORE", Text = "L'utilisateur de Quietus utilise <i>Mental + Athlétique</i> contre <i>Mental + Volonté</i> de la cible."},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "QUIESTUS_KEY",
                    DisciplineName = "QUIESTUS_NAME",
                    Description = "QUIESTUS_DESCRIPTION",
                    TestScore = "QUIESTUS_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class SerpentisInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "SERPENTIS_POWER_1_NAME", Description = "SERPENTIS_POWER_1_DESCRIPTION", System = "SERPENTIS_POWER_1_SYSTEM", Focus = focus[5], FocusEffect = "SERPENTIS_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "SERPENTIS_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "SERPENTIS_NAME" },
                new Power { Level = 2, PowerName = "SERPENTIS_POWER_2_NAME", Description = "SERPENTIS_POWER_2_DESCRIPTION", System = "SERPENTIS_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "SERPENTIS_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "SERPENTIS_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "SERPENTIS_NAME" },
                new Power { Level = 3, PowerName = "SERPENTIS_POWER_3_NAME", Description = "SERPENTIS_POWER_3_DESCRIPTION", System = "SERPENTIS_POWER_3_SYSTEM", Focus = focus[3], FocusEffect = "SERPENTIS_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "SERPENTIS_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "SERPENTIS_NAME" },
                new Power { Level = 4, PowerName = "SERPENTIS_POWER_4_NAME", Description = "SERPENTIS_POWER_4_DESCRIPTION", System = "SERPENTIS_POWER_4_SYSTEM", Focus = focus[5], FocusEffect = "SERPENTIS_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "SERPENTIS_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "SERPENTIS_NAME" },
                new Power { Level = 5, PowerName = "SERPENTIS_POWER_5_NAME", Description = "SERPENTIS_POWER_5_DESCRIPTION", System = "SERPENTIS_POWER_5_SYSTEM", Focus = focus[3], FocusEffect = "SERPENTIS_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "SERPENTIS_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "SERPENTIS_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "SERPENTIS_NAME", Text = "Serpentis"},
                new Traduction{LCID = 1036, Key = "SERPENTIS_DESCRIPTION", Text = "Dans d’anciens temples égyptiens, dans les gratte-ciels les plus récents, le clan des serpents exerce ses arts et vénère son fondateur : le dieu vampirique, Set. Les Setites considèrent que leur discipline de Serpentis est un don de la bienveillance de Set, ils traitent son utilisation avec révérence, louant Set à chaque usage et invocation de ses pouvoirs."},

                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_1_NAME", Text = "Yeux du Serpent"},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_1_DESCRIPTION", Text = "<i>Comme les charmeurs de serpents d’autrefois, votre regard a le pouvoir de calmer et d’hypnotiser. Lorsque vous utilisez ce pouvoir, vos yeux prennent une teinte or brillante, captant l’attention de ceux qui rencontrent votre regard. Tant que vous tenez son attention, votre sujet reste complètement immobilisé.</i>"},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_1_SYSTEM", Text = "Dépensez 1 point de sang et utilisez une action simple pour activer les Yeux du Serpent. Vous devez avoir l’attention de votre cible (voir Regard et Focalisation) et engager votre cible dans un défi opposé à l’aide des scores de test de Serpentis.Si vous réussissez, la cible est paralysée tant que vous maintenez son regard avec le vôtre.Si vous brisez le contact visuel, utilisez un autre pouvoir, ou si la cible est attaquée, blessée ou ciblée par des pouvoirs hostiles, votre pouvoir hypnotique s'arrête."},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_1_EXCEPTIONALSUCCESS", Text = "Vos Yeux du Serpent durent trois tours après rupture du contact visuel, tant que votre adversaire n’est pas attaqué, blessé, ou ciblé avec un pouvoir agressif."},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_1_FOCUS_DESCRIPTION", Text = "Vous pouvez utiliser d’autres pouvoirs tout en maintenant une cible paralysée avec vos Yeux du Serpent. Cependant, si votre cible est attaquée ou blessée, ce sort hypnotique se casse."},

                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_2_NAME", Text = "Langue de l’Aspic"},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_2_DESCRIPTION", Text = "<i>En activant ce pouvoir, vous gagnez certains des pouvoirs naturels et mythiques associés aux serpents. Vous pouvez parler, contrôler et appeler des serpents. Certains utilisateurs sont particulièrement bénis et peuvent même obtenir un avantage naturel dans la persuasion orale, tout comme le Serpent d’autrefois.</i>"},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_2_SYSTEM", Text = "Dépensez 1 point de sang et utilisez une action simple pour activer la Langue de l’Aspic pendant une heure. Pendant que ce pouvoir est actif, votre langue est bifide et vous pouvez parler à des serpents (ou des individus sous forme de serpent) dans un murmure sifflant si tranquille que le son ne peut être perçu que par quelqu'un qui possède Sens Intensifiés ou un pouvoir semblable. Tant que la langue de l’Aspic est active, vous pouvez sentir parfaitement votre environnement, même dans les profondeurs de la nuit ou dans l’obscurité non naturelle comme celle causée par Obtenebration. Normalement, les personnages qui ne peuvent pas voir pendant le combat doivent utiliser la manœuvre de combat à l’aveugle. Tant que la langue de l’Aspic de votre personnage est active, vous pouvez vous battre sans avoir besoin de la manœuvre de combat à l’aveugle.<br /> En outre, en dépensant un point de sang supplémentaire et une action standard, vous pouvez invoquer jusqu'à cinq petits serpents locaux ou deux serpents de taille moyenne. Ces serpents prennent jusqu'à 10 minutes à apparaître et doivent être capables de voyager naturellement à votre emplacement. Ce sont des animaux agissant en tant que tels, mais ils vous sont fidèles et tenteront de faire votre volonté jusqu'à l’aube. Traitez les petits serpents comme des serviteurs à 1 point et les serpents moyens comme des serviteurs à 3 points."},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_2_FOCUS_DESCRIPTION", Text = "Lorsque vous utilisez la Langue de l’Aspic, vous gagnez également un bonus de +1 aux tests basés sur le son de votre voix, y compris les compétences liées à la persuasion et les pouvoirs de Présence tels que Envoûtement (en supposant que vous parliez pour renforcer votre utilisation du pouvoir)."},

                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_3_NAME", Text = "Peau de la Vipère"},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_3_DESCRIPTION", Text = "<i>Avec seulement un moment de concentration, vous faites apparaître sur votre peau des éruptions brillantes, des écailles protectrices et vos membres et muscles s'allongent. Tant que ce pouvoir est actif, vous avez un aspect hideux, semblable à un serpent, mais vous gagnez une défense significative contre les attaques physiques.</i>"},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_3_SYSTEM", Text = "Dépensez 1 point de sang et utilisez une action simple pour invoquer ce pouvoir, vous obtenez des écailles défensives et devenez extrêmement flexible. Tant que ce pouvoir est actif, vous avez un bonus de +2 au Scores de Tests de Défense basés sur l’esquive. Les individus qui utilisent la Peau de la Vipère peuvent aussi mordre sans avoir d’abord besoin d’agripper leurs adversaires.<br /> Évidemment, être vu par les mortels tout en utilisant la Peau de la Vipère est un bris de la mascarade.<br /> Peau de la Vipère est un pouvoir de transformation et ne peut être combiné avec d’autres pouvoirs transformateurs. Vous pouvez mettre fin à cette transformation à tout moment en dépensant une action simple. La transformation effectuée par Peau de la Vipère est assez humanoïde pour permettre l’utilisation d’armes."},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_3_FOCUS_DESCRIPTION", Text = "Votre bonus aux scores de test basés sur l’esquive devient +3 (au lieu de la norme +2). De plus, vous recevez un bonus de +1 au score de test de Bagarre lorsque vous tentez de mordre votre adversaire."},

                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_4_NAME", Text = "Forme du Cobra"},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_4_DESCRIPTION", Text = "<i>Les Mythes affirment que les anciens prêtres d’Egypte pouvaient commander à leurs bâtons de se transformer en serpents. Vous pouvez effectuer une métamorphose encore plus grande, vous transformant en un cobra massif, qui conserve la taille et le poids de votre forme originelle. Cette forme de reptile donne une morsure venimeuse et la capacité de glisser à travers de petits passages, tout en vous permettant d’utiliser toutes les disciplines qui ne nécessitent pas les mains ou la parole.</i>"},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_4_SYSTEM", Text = "Dépensez 1 point de sang et utilisez une action standard pour vous transformer en un cobra massif, de taille humaine, d’environ 4,5 mètres de long. Vous pouvez mettre fin à cette transformation à tout moment en dépensant une simple action. Un personnage en Forme du Cobra est extrêmement souple et ne peut être agrippé ; les attaquants qui tentent de vous attraper échouent automatiquement.En outre, vous pouvez mordre vos ennemis sans les agripper d’abord et vos morsures sont venimeuses.<br /> Les individus qui sont mordus par un vampire dans la Forme du Cobra doivent résister à un poison de virilité 15.Le poison infligé par ce pouvoir endommage les personnages vivants et détruit le sang des vampires.Pour plus d’informations sur le poison, voir Drogues et Types de Poisons dans Santé et Dégâts.Rappelez - vous que toutes les morsures vampiriques, y compris celles des personnages en Forme du Cobra, infligent des dégâts aggravés.<br /> La forme du Cobra est un pouvoir de transformation et ne peut être combiné avec d’autres pouvoirs de transformation."},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_4_FOCUS_DESCRIPTION", Text = "Vous pouvez modifier votre Forme du Cobra, devenant aussi gros qu’un python massif, ou aussi petit qu’une vipère. Votre longueur et votre masse peuvent augmenter jusqu'à trois fois votre corps naturel."},

                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_5_NAME", Text = "Cœur des ténèbres"},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_5_DESCRIPTION", Text = "<i>Dans les légendes égyptiennes, les cœurs des morts sont enlevés afin qu’ils puissent être pesés contre la plume de la vérité. Ceux qui échouent sont jetés dans un lac de feu et dévorés, tandis que ceux qui sont dignes sont acceptés au paradis. Il est dans votre pouvoir de retirer les cœurs des créatures mortes-vivantes et de prendre en main leur jugement.</i>"},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_5_SYSTEM", Text = "Dépensez 1 point de sang et une heure pour exécuter un rituel complexe afin d’extraire le cœur d’un corps non vampirique : soit le vôtre, soit celui d’un autre participant volontaire. Aucun test n’est nécessaire pour enlever un cœur.<br /> Ce pouvoir ne peut être utilisé que la nuit d’une nouvelle lune.<br /> Alors que la plupart des chairs vampiriques pourrissent et se désintègrent en un seul tour après avoir été séparées de leur corps, un cœur enlevé avec ce pouvoir reste intact. Le cœur peut être remplacé par une autre utilisation du Cœur des Ténèbres, tant que l’utilisateur du pouvoir possède le cœur correct à restaurer. Il n’est pas possible d’installer un cœur faux ou le cœur d’une autre personne en utilisant le Cœur des Ténèbres. <br />Toute personne dont le cœur est enlevé de cette manière est immunisée au pieutage. En outre, quand ce personnage tente de résister à la frénésie, il le fait comme si il avait un trait de Bête en moins.<br /> Un cœur séparé peut être pieuté, même si le vampire cible n’est pas blessé. Si le cœur est pieuté, alors ce vampire est immédiatement paralysé comme s'il avait été pieuté normalement. Si le cœur est exposé à un seul point de dégât du feu ou de la lumière du soleil, il est détruit et son propriétaire s'embrase et est réduit en cendres, rencontrant la mort finale en un seul tour.<br /> De toute évidence, essayer d’utiliser ce pouvoir sur un mortel, même une goule, est désespérément mortel."},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "SERPENTIS_POWER_5_FOCUS_DESCRIPTION", Text = "Vous pouvez effectuer Cœur des ténèbres n’importe quelle nuit du mois et le faire sur une cible qui ne veut pas, tant qu’elle est en torpeur."},

                new Traduction{LCID = 1036, Key = "SERPENTIS_TEST_SCORE", Text = "L'utilisateur de Serpentis utilise <i>Social + Subterfuge</i> contre <i>Social + Volonté</i> de la cible."},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "SERPENTIS_KEY",
                    DisciplineName = "SERPENTIS_NAME",
                    Description = "SERPENTIS_DESCRIPTION",
                    TestScore = "SERPENTIS_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class TemporisInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "TEMPORIS_POWER_1_NAME", Description = "TEMPORIS_POWER_1_DESCRIPTION", System = "TEMPORIS_POWER_1_SYSTEM", Focus = focus[2], FocusEffect = "TEMPORIS_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "TEMPORIS_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "TEMPORIS_NAME" },
                new Power { Level = 2, PowerName = "TEMPORIS_POWER_2_NAME", Description = "TEMPORIS_POWER_2_DESCRIPTION", System = "TEMPORIS_POWER_2_SYSTEM", Focus = focus[2], FocusEffect = "TEMPORIS_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "TEMPORIS_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "TEMPORIS_NAME" },
                new Power { Level = 3, PowerName = "TEMPORIS_POWER_3_NAME", Description = "TEMPORIS_POWER_3_DESCRIPTION", System = "TEMPORIS_POWER_3_SYSTEM", Focus = focus[2], FocusEffect = "TEMPORIS_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "TEMPORIS_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "TEMPORIS_NAME" },
                new Power { Level = 4, PowerName = "TEMPORIS_POWER_4_NAME", Description = "TEMPORIS_POWER_4_DESCRIPTION", System = "TEMPORIS_POWER_4_SYSTEM", Focus = focus[2], FocusEffect = "TEMPORIS_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "TEMPORIS_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "TEMPORIS_NAME" },
                new Power { Level = 5, PowerName = "TEMPORIS_POWER_5_NAME", Description = "TEMPORIS_POWER_5_DESCRIPTION", System = "TEMPORIS_POWER_5_SYSTEM", Focus = focus[2], FocusEffect = "TEMPORIS_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "TEMPORIS_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "TEMPORIS_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "TEMPORIS_NAME", Text = "Temporis"},
                new Traduction{LCID = 1036, Key = "TEMPORIS_DESCRIPTION", Text = "Ceux qui contrôlent les pouvoirs de Temporis ont la capacité de comprendre les permutations du temps, accélérant et ralentissant ses effets en fonction de leurs désirs. Temporis canalise la force mystique qui rend un vampire immortel, rendant son corps immunisé contre les ravages du temps. Le vrai Brujah prétend que l’antediluvian Brujah a créé Temporis avant qu’il ait été diablé et que sa malédiction a dégradé son pouvoir pour ceux qui ont suivi Troile après sa destruction. <br />Les utilisateurs de Temporis ont tendance à devenir de plus en plus méticuleux et presque obsédés par les petits détails de la vie quotidienne. Ils ont également tendance à manquer d’émotions à un degré élevé, se détachant par l’expérience du passage des âges, ressentant le passage des siècles comme un grain de sable à travers un sablier. Ces êtres sont insensibles et cruels, n’accordant que peu de valeur à un seul individu dans la grande tapisserie du temps. <br /><strong>Temporis et Célérité </strong>: Un personnage qui a acheté n’importe quelle quantité de Célérité ne peut jamais acheter de Temporis.De même, un personnage qui a acheté une quantité de Temporis ne peut jamais acheter Célérité."},

                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_1_NAME", Text = "Sablier de l’Esprit"},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_1_DESCRIPTION", Text = "<i>Le temps est une entité complexe, se déplaçant comme une rivière autour d’un millier de minuscules pierres. La plus petite altération peut entraîner d’énormes changements. Pour utiliser efficacement Temporis, l’esprit du lanceur doit être capable de comprendre ces courants et tourbillons et de prédire leurs résultats.</i>"},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_1_SYSTEM", Text = "Sablier de l’esprit est toujours actif. En plus d’accorder un sens du temps extrêmement précis, vous permettant de garder une trace de la durée exacte jusqu'à la milliseconde, ce niveau de Temporis vous donne également une sensibilité unique à toute perturbation du temps. Dans un rayon d’un mile, vous percevez automatiquement quand le temps est manipulé, que ce soit par l’utilisation de Temporis ou d’autres pouvoirs surnaturels qui altèrent le temps. En outre, vous détectez automatiquement l’utilisation de pouvoirs qui accordent des actions supplémentaires, tels que Célérité, quand ils sont utilisés à moins de 1000 pieds de vous. Par ailleurs, vous pouvez lire l’âge d’un objet en un coup d’œil et vous pouvez dire si Temporis a jamais été utilisé sur cet objet en notant que son âge réel ne correspond pas à la quantité de temps qui s'est écoulée depuis la création de l’objet.<br /> De plus, en dépensant votre action standard et en faisant un test opposé réussi, en utilisant le Score de Test de Temporis, vous découvrez si oui ou non une cible possède Célérité ou Temporis ; vous discernerez alors combien de points de Célérité ou Temporis la cible possède.Si vous utilisez ce pouvoir sur une créature non vampirique qui possède des pouvoirs qui peuvent façonner le temps ou lui permettre d’accomplir de multiples actions, vous obtenez une compréhension approximative des capacités de cette créature."},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_1_FOCUS_DESCRIPTION", Text = "En plus de connaître les points totaux de Temporis ou Célérité de votre cible, vous pouvez également discerner les pouvoirs spécifiques qu’elle possède, y compris les techniques et les pouvoirs des aînés."},

                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_2_NAME", Text = "Juste à Temps"},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_2_DESCRIPTION", Text = "<i>Avec ce pouvoir, vous pouvez voler des objets depuis des recoins de l’Histoire. En créant une petite anomalie dans le flux naturel du temps, vous atteignez et saisissez, dans le passé ou le présent, les objets perdus, les déchets abandonnés et épaves abandonnées, tirant de force ces articles vers vous.</i>"},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_2_SYSTEM", Text = "En dépensant 1 point de sang et en dépensant une action simple, vous pouvez utiliser Juste à temps pour attirer un objet commun à vous d’un autre point dans le temps. Ces éléments sont des choses qui ont été perdues ou déplacées et qui n’auront jamais manqué à leur propriétaire. L’objet est un exemple courant et non-écrit de son type ; vous pouvez choisir d’attirer un aigle du désert ou une jolie peinture, mais vous ne pouvez pas acquérir l’arme du shérif ou la Mona Lisa.L’objet doit être assez petit pour qu’une personne normale le tienne facilement dans ses deux mains et ne pas avoir de valeur particulière.<br /> Si vous choisissez d’attirer à vous une arme, le conteur détermine les qualités spécifiques de l’arme.Si l’arme est un pistolet, il a un chargeur complet de munitions. Pour plus d’informations sur les armes et les qualités d’armes, voir le chapitre 13: Influences et équipement, Accessoires, armes et armures."},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_2_FOCUS_DESCRIPTION", Text = "Si vous utilisez Juste à temps pour attirer une arme ou un objet de combat, vous pouvez sélectionner les qualités de cet élément, plutôt que de le faire choisir par votre conteur."},

                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_3_NAME", Text = "Seconde Fractionnée"},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_3_DESCRIPTION", Text = "<i>Avec ce pouvoir, vous ralentissez les effets du temps autour de vous, vous permettant de bouger dans un scintillement et presque semblant être à deux endroits à la fois. Même si vous ne pouvez pas attaquer les autres dans un tel état, vous pouvez vous déplacer, attirer des armes ou effectuer d’autres petites actions en un clin d’œil.</i>"},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_3_SYSTEM", Text = "Une fois par tour, vous pouvez dépenser 1 point de sang pour obtenir une action supplémentaire simple, qui ne peut pas être interrompue. Cette action supplémentaire résout votre initiative et ne peut pas être utilisée pour cibler d’autres personnages ou objets contrôlés par d’autres personnages ; elle ne peut pas non plus être utilisée pour activer des pouvoirs."},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_3_FOCUS_DESCRIPTION", Text = "Vous gagnez deux actions simples supplémentaires avec chaque utilisation de Seconde fractionnée, plutôt qu’une."},

                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_4_NAME", Text = "Patience des Nornes"},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_4_DESCRIPTION", Text = "<i>Votre maîtrise de Temporis est devenue si puissante que vous pouvez enlever des objets inanimés du temps, en les suspendant pendant un petit moment alors que le reste du monde avance. Vous pouvez arrêter dans les airs un objet en train de tomber, suspendre une explosion assez longtemps pour échapper à son feu, ou préserver un artefact fragile de la pourriture.</i>"},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_4_SYSTEM", Text = "Dépensez 1 point de sang, dépensez une action standard et ciblez un objet inanimé pour activer la Patience des Norns. Cet objet entre en parfaite stase, même au fil du temps. Lorsque Patience des Nornes affecte un objet, tous les processus, mécaniques, électriques ou chimiques, cessent de fonctionner pendant la durée de l’effet. Les balles sont immobiles en plein air, les feux n’apparaissent que comme des bûches carbonisées et les objets tombant se figent à mi-chute. Cette suspension dure une heure, à moins que Patience des Norns ne soit relâchée avant cette durée. <br />Un objet gelé par Patience des Norns ne peut être déplacé ou affecté d’aucune façon. Si quelque chose de substantiel (plus ferme qu’une brise légère) touche un objet congelé après qu’il a été placé en suspension, l’élément affecté par Patience des Norns est relâché et rentre dans le temps avec les mêmes propriétés et la même vitesse qu’il avait quand il a été placé en stase. La suspension d’un objet inclut la suspension de toute son énergie et de tous les processus chimiques qui se produisent en son sein. Ainsi, une balle suspendue n’a pas d’énergie cinétique par rapport au monde qui l’entoure, les réactions chimiques sont maintenues en stase et les feux cessent d’émettre de la chaleur, de la lumière ou de la fumée jusqu'à ce que la durée du pouvoir expire. A la fin du temps d’utilisation du pouvoir, tous les processus, énergies et réactions reprennent l’activité comme si le temps n’avait pas passé. Les feux rugissent, les réactions chimiques se poursuivent et les objets en mouvement continuent leur trajectoire originelle à leur vitesse d’origine. <br />La patience des Nornes ne peut pas être utilisée sur un objet plus grand que le vampire lui-même."},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_4_FOCUS_DESCRIPTION", Text = "Vous pouvez modifier légèrement un objet qui a été suspendu par Patience des Nornes. Alors qu’un élément d’une suspension standard ne peut être déplacé ou affecté d’aucune façon, vous pouvez faire pivoter l’objet, de sorte que toute l’énergie cinétique soit dirigée dans une autre direction ou déplacer l’objet d’un pas par action standard. Vous devez toucher physiquement l’élément afin de le tourner ou de le déplacer. Ce contact ne rompt pas la suspension accordée par Patience des Norns."},

                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_5_NAME", Text = "Don de Clotho"},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_5_DESCRIPTION", Text = "<i>Vous êtes capable d’accélérer le temps comme il passe à travers votre corps, ce qui vous amène à vous déplacer avec une vitesse et une précision surnaturelles.</i>"},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_5_SYSTEM", Text = "Dépensez 1 point de sang pour activer le Don de Clotho pour le tour. Lorsque vous activez Don de Clotho, vous gagnez deux rounds supplémentaires d’actions ; chaque round supplémentaire comprend une action simple et une action standard.Résolvez un round supplémentaire d’actions lors du premier round de Célérité et résolvez le second round supplémentaire d’actions lors du deuxième round de Célérité."},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "TEMPORIS_POWER_5_FOCUS_DESCRIPTION", Text = "Chaque tour, vous pouvez utiliser une (et une seule) des actions standard accordées par Don de Clotho pour activer un pouvoir Mental ou Social. Il s'agit d’une exception à la règle qui stipule que vous ne pouvez pas utiliser les pouvoirs Mental ou Social pendant les tours Célérité."},

                 new Traduction{LCID = 1036, Key = "TEMPORIS_TEST_SCORE", Text = "Le lanceur de Temporis utilise son Attribut <i>Physique + Survie</i> contre l’Attribut <i>Physique + Volonté</i> de la cible ."},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "TEMPORIS_KEY",
                    DisciplineName = "TEMPORIS_NAME",
                    Description = "TEMPORIS_DESCRIPTION",
                    TestScore = "TEMPORIS_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class ThanatosisInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "THANATOSIS_POWER_1_NAME", Description = "THANATOSIS_POWER_1_DESCRIPTION", System = "THANATOSIS_POWER_1_SYSTEM", Focus = focus[8], FocusEffect = "THANATOSIS_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "THANATOSIS_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "THANATOSIS_NAME" },
                new Power { Level = 2, PowerName = "THANATOSIS_POWER_2_NAME", Description = "THANATOSIS_POWER_2_DESCRIPTION", System = "THANATOSIS_POWER_2_SYSTEM", Focus = focus[8], FocusEffect = "THANATOSIS_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "THANATOSIS_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "THANATOSIS_NAME" },
                new Power { Level = 3, PowerName = "THANATOSIS_POWER_3_NAME", Description = "THANATOSIS_POWER_3_DESCRIPTION", System = "THANATOSIS_POWER_3_SYSTEM", Focus = focus[8], FocusEffect = "THANATOSIS_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "THANATOSIS_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "THANATOSIS_NAME" },
                new Power { Level = 4, PowerName = "THANATOSIS_POWER_4_NAME", Description = "THANATOSIS_POWER_4_DESCRIPTION", System = "THANATOSIS_POWER_4_SYSTEM", Focus = focus[7], FocusEffect = "THANATOSIS_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "THANATOSIS_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "THANATOSIS_NAME" },
                new Power { Level = 5, PowerName = "THANATOSIS_POWER_5_NAME", Description = "THANATOSIS_POWER_5_DESCRIPTION", System = "THANATOSIS_POWER_5_SYSTEM", Focus = focus[7], FocusEffect = "THANATOSIS_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "THANATOSIS_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "THANATOSIS_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "THANATOSIS_NAME", Text = "Thanatosis"},
                new Traduction{LCID = 1036, Key = "THANATOSIS_DESCRIPTION", Text = "Les corps cadavériques des Vampires sont intimement liés à la mort, piégés dans un état de décomposition éternelle. Thanatosis s'appuie sur cette connexion, stimulant et se nourrissant de la souillure et du pourrissement. Ce sont les pouvoirs de l’atrophie, de la décrépitude, de la putrescence et de la pourriture. A certains égards, Thanatosis donne le pouvoir sur la malédiction elle-même, suspendant provisoirement l’immortalité d’un Vampire et faisant même pourrir et se décomposer sa chair immortelle. Thanatosis est la discipline signature de la lignée des Samedi et certains disent que c'est l’évolution naturelle des pouvoirs de la Voie de Mortis des Cappadociens. Assurément, les deux sont apparentés et partagent des similitudes - mais dans l’ensemble, les Samedi sont plus agressifs et moins studieux."},

                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_1_NAME", Text = "Peau de Mégère"},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_1_DESCRIPTION", Text = "<i>La pourriture perpétuelle rend la chair du personnage malléable. Vous pouvez contracter ou étendre votre peau, l’envoyant dans des vagues ridées et ondulantes ou en la tendant sur votre chair de mort-vivant. Vous pouvez même plier votre chair, vous permettant de conserver des objets dans ses rides tannées, comme la poche d’un kangourou.</i>"},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_1_SYSTEM", Text = "Le corps des utilisateurs de Thanatosis devient pourri et malléable. En dépensant une action standard pour tirer ou tordre votre peau, vous pouvez ouvrir des plis et poches dans votre chair. Ces poches sont capables de stocker des objets allant jusqu'à la taille d’un gros pistolet à main. Accéder aux objets stockés dans ces poches ne nécessite qu’une action simple. <br />De plus, vous pouvez légèrement altérer votre apparence en serrant de manière excessive votre peau autour de votre visage ou en lui permettant d’être lâche et ridée. Ces changements sont suffisants pour tromper des mortels mal informés, mais ils n’altèrent pas suffisamment votre apparence pour tromper quelqu'un que vous connaissez."},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_1_FOCUS_DESCRIPTION", Text = "Les rabats et plis de votre peau peuvent entraver des armes, glissant sur votre musculature ou déviant des coups qui vous auraient autrement blessé. Vous recevez un bonus de +1 aux scores de test défensif quand vous êtes la cible d’une attaque de Bagarre ou Mêlée. De plus, vous recevez un bonus de +5 quand vous tentez de vous échapper d’une manœuvre de combat Agripper."},

                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_2_NAME", Text = "Putréfaction"},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_2_DESCRIPTION", Text = "<i>D'un simple toucher, vous pouvez infliger de la pourriture sur votre cible. Vous provoquez une décomposition putride et suppurante de votre point de contact.</i>"},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_2_SYSTEM", Text = "Dépensez un point de Sang et utilisez votre action standard pour pourrir tout objet inanimé que vous touchez, au point qu’il devient inutilisable. Une seule application de Putréfaction vous permet de détruire le bois, le tissu, le plastique et le caoutchouc. Mais les objets plus durs, comme le métal, le verre, ou la pierre, nécessitent deux applications de ce pouvoir avant de putréfier. Les objets plus grands qu’une porte standard nécessitent plus d’une application de Putréfaction pour être détruits. Ce pouvoir n’a aucun effet sur la matière vivante ou morte-vivante, mais elle peut pourrir de vrais cadavres (corps morts) jusqu'à ce qu’ils soient méconnaissables."},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_2_FOCUS_DESCRIPTION", Text = "Vous pouvez dépenser un point de sang et une action standard pour détruire un pieu en bois qui vous perce actuellement le cœur. Ceci est une exception à la règle qui empêche un personnage de dépenser du sang ou d’entreprendre des actions alors qu’il est pieuté."},

                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_3_NAME", Text = "Des Cendres aux Cendres"},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_3_DESCRIPTION", Text = "<i>Dans des conditions extrêmes, il est parfois préférable de persuader un adversaire de sa victoire pour gagner l’élément de surprise. Les Samedi sont des maîtres d’une telle supercherie. Avec ce pouvoir, vous pouvez vous effondrer en une poudre épaisse, un peu collante, qui ressemble à un tas de cendres desséché.</i>"},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_3_SYSTEM", Text = "En dépensant 1 point de Sang et en utilisant votre action standard, vous vous transformez en un tas de cendres. Pendant que vous êtes dans cette forme, vous ne pouvez pas dépenser de Sang, bouger depuis là où vous êtes ou utiliser des pouvoirs surnaturels, mais vous êtes immunisés aux dégâts Physiques, au feu et à la lumière du soleil. Vous gardez aussi une conscience limitée de tout ce qu’il y a dans les 5 pas.<br /> La forme accordée par Des Cendres aux Cendres ne confère pas une invulnérabilité complète. Les cendres ont une certaine résistance à être dispersées mais, si vous êtes trop largement disséminé, vous pouvez être tué. Quand vous utilisez Des Cendres aux Cendres, vous avez 10 points de cohésion. Si certains individus ou facteurs de l’environnement, comme de forts vents ou des flammes collaborent à disperser vos cendres, vous pouvez perdre 1 à 3 points de Cohésion par tour, déterminé à la discrétion du conteur. <br />Si vous vous reformez après avoir perdu de la Cohésion, vous perdez 1 point de Sang par point de Cohésion perdu. Si vous êtes à court de sang de cette manière, vous prenez 1 point de dégât aggravé par point de cohésion perdu. Ces dégâts ne peuvent pas réduits ou annulés. Si votre cohésion atteint zéro, vous rencontrez la Mort Finale.<br /> Ce pouvoir vous fait apparaître comme si vous étiez un tas de cendres normales, mais n’altère pas votre aura. Quelqu'un qui regarde un personnage en Des Cendres aux Cendres avec une perception de l’aura pourra dire que ce tas de cendres a une aura de Vampire. Des Cendres aux Cendres est un pouvoir de transformation et ne peut pas être combiné avec d’autres pouvoirs de transformation."},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_3_FOCUS_DESCRIPTION", Text = "En forme Des Cendres aux Cendres, vous pouvez dépenser 1 point de Sang pour ramener des cendres qui ont été dispersées, regagnant 1 point de Cohésion par tour. De plus, vous pouvez dépenser 1 point de Sang par tour et vous déplacer jusqu'à 1 pas. Ceci est une exception à la règle qui vous empêche de dépenser du Sang ou de bouger quand vous êtes sous forme de cendres."},

                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_4_NAME", Text = "Racornissement"},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_4_DESCRIPTION", Text = "<i>En empoignant un membre de la victime et en activant ce pouvoir hideux, vous ratatinez le membre et le rendez inutile en l’infectant avec de la pourriture. Une cible qui souffre des effets de ce pouvoir ressent d’horribles douleurs, ses membres se contractant et ses os cassant sous votre poigne.</i>"},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_4_SYSTEM", Text = "Utilisez une action standard pour Agripper une cible. Si vous réussissez, dépensez 1 point de Sang pour infliger Racornissement à votre victime en plus de tous les effets standards d’Agripper. Par la suite, la cible subit une pénalité de -1 à son attribut Physique. Cet effet n’est pas considéré comme des dégâts et n’est pas affecté par les pouvoirs ou capacités qui annulent ou atténuent les dégâts. <br />Pour utiliser Racornissement sur une cible, vous devez utiliser la manœuvre de combat Agripper contre la cible. Si votre cible est déjà agrippée, vous pouvez activer ce pouvoir en dépensant 1 point de Sang et en utilisant votre action standard. (Pour plus d’informations sur Agripper, consultez le Chapitre Six: Système de base). <br />Racornissement peut être utilisé pendant les rounds de Célérité, tant que vous payez le coût total pour chaque utilisation.<br /> Les pénalités d’une utilisation répétée de Racornissement sur une seule cible s'accumulent, que ces pénalités soient appliquées par un seul ou plusieurs pratiquants de Thanatosis. Si cette pénalité atteint -5, l’un des membres de la victime (au choix de l’attaquant) devient inutile. Si cette pénalité atteint -10, la cible doit choisir un deuxième membre qui devient inutile et ainsi de suite, jusqu'à ce que tous les membres de la cible soient inutilisables. <br />Si l’une ou les deux jambes d’une cible ont été racornies, elle ne peut que se déplacer d’un pas par action en rampant ou boitant. Si l’un des bras du personnage a été racorni, il souffre d’une pénalité de -5 aux attaques de Bagarre et Mêlée, à moins que le personnage ne soit ambidextre, dans ce cas, il ne souffre que d’une pénalité de -3. Un personnage avec un bras racorni ne peut pas utiliser d’armes à deux mains. Un personnage avec ses deux bras racornis ne peut pas attaquer à moins qu’il ne soit capable de mordre sans Agripper ou s'il a plus de deux membres utilisables, comme ceux accordés par Sombre Métamorphose ou des membres crées grâce à Vicissitude. <br />Les pénalités d’attribut Physique de Racornissement s'estompent après 10 minutes mais un membre racorni n’est pas aussi facilement restauré. Un mortel dont le membre est racorni est estropié de manière permanente. Les membres racornis d’une créature surnaturelle se soignent au bout de deux parties ou un mois, selon le plus long des deux."},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_4_FOCUS_DESCRIPTION", Text = "Les membres de votre cible se racornissent quand les pénalités atteignent -3 au lieu du seuil standard de -5. Un deuxième membre devient inutile quand les pénalités atteignent -6 et ainsi de suite. Cet effet fonctionne même si certaines pénalités ont été appliquées par d’autres personnages qui utilisent Racornissement. Par exemple, si un personnage inflige -2 de pénalités et que vous infligez une troisième pénalité de -1, vous racornissez l’un des membres de la cible."},

                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_5_NAME", Text = "Nécrose"},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_5_DESCRIPTION", Text = "<i>Pouvoir puissant et horrible, Nécrose vous permet de pourrir les muscles et os de votre adversaire, le transformant en des tissus et graisses putrides. La hideuse décomposition induite par ce pouvoir dégoûte et révolte même ceux à la constitution la plus robuste dans la mesure où elle accélère la force de la pourriture et expose les organes internes dans un terrifiant spectacle de souffrance.</i>"},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_5_SYSTEM", Text = "Dépensez 1 point de Sang et utilisez une action simple pour activer Nécrose. Pendant la prochaine heure, quand vous Agrippez avec succès une cible ou maintenez un Agripper sur une cible, vous pouvez choisir d’infliger une pourriture à votre victime. Vous ne pouvez infliger Nécrose qu’une seule fois par tour, mais vous pouvez le faire n’importe quand, soit durant le tour commun ou durant les rounds de Célérité. <br />La première fois que utilisez Nécrose sur une cible, vous devez parvenir à utiliser la manœuvre de combat Agripper. Lors des rounds suivants, si vous êtes toujours en train d’Agripper la cible, vous pouvez activer Nécrose en utilisant votre action standard. (Pour plus d’informations sur Agripper, consultez le Chapitre Six: Système de base). Votre cible subit 3 points de dégâts aggravés alors que sa chair se décompose et se désagrège. <br />Les dégâts normalement infligés par Agripper ne sont pas convertis en dégâts aggravés par ce pouvoir. Les dégâts infligés par Nécrose ne sont pas réduits par les effets de la manœuvre de combat Agripper. <br />Nécrose ne peut être utilisé avec d’autres pouvoirs nécessitant que vous touchiez ou agrippiez votre cible."},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "THANATOSIS_POWER_5_FOCUS_DESCRIPTION", Text = "Nécrose inflige 4 points de dégâts aggravés, au lieu des 3 standard."},

                 new Traduction{LCID = 1036, Key = "THANATOSIS_TEST_SCORE", Text = "L'utilisateur de Thanatosis utilise son Score de Test Attribut <i>Mental + Médecine</i> contre le Score de Test Attribut <i>Mental + Volonté</i> de la cible."},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "THANATOSIS_KEY",
                    DisciplineName = "THANATOSIS_NAME",
                    Description = "THANATOSIS_DESCRIPTION",
                    TestScore = "THANATOSIS_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class ValerenInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "VALEREN_POWER_1_NAME", Description = "VALEREN_POWER_1_DESCRIPTION", System = "VALEREN_POWER_1_SYSTEM", Focus = focus[6], FocusEffect = "VALEREN_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "VALEREN_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "VALEREN_NAME" },
                new Power { Level = 2, PowerName = "VALEREN_POWER_2_NAME", Description = "VALEREN_POWER_2_DESCRIPTION", System = "VALEREN_POWER_2_SYSTEM", Focus = focus[7], FocusEffect = "VALEREN_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "VALEREN_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "VALEREN_NAME" },
                new Power { Level = 3, PowerName = "VALEREN_POWER_3_NAME", Description = "VALEREN_POWER_3_DESCRIPTION", System = "VALEREN_POWER_3_SYSTEM", Focus = focus[7], FocusEffect = "VALEREN_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "VALEREN_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "VALEREN_NAME" },
                new Power { Level = 4, PowerName = "VALEREN_POWER_4_NAME", Description = "VALEREN_POWER_4_DESCRIPTION", System = "VALEREN_POWER_4_SYSTEM", Focus = focus[7], FocusEffect = "VALEREN_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "VALEREN_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "VALEREN_NAME" },
                new Power { Level = 5, PowerName = "VALEREN_POWER_5_NAME", Description = "VALEREN_POWER_5_DESCRIPTION", System = "VALEREN_POWER_5_SYSTEM", Focus = focus[6], FocusEffect = "VALEREN_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "VALEREN_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "VALEREN_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "VALEREN_NAME", Text = "Valeren"},
                new Traduction{LCID = 1036, Key = "VALEREN_DESCRIPTION", Text = "Luttant pour défendre leur clan en des temps sombres et troubles, les guerriers Salubriens créèrent la discipline Valeren. Au fil des siècles, des rumeurs se répandirent selon lesquelles les Salubriens seraient des infernalistes et des diabolistes. Cette discipline est désormais vue avec crainte et aversion. Contrairement à sa discipline sœur, Obeah, Valeren n’est véritablement pas un pouvoir de guérison. C’est une manifestation de guerre, de colère et de Chi. Comme avec Obeah, dans les temps modernes, la plupart des vampires croient que les Salubriens et leurs disciplines sont d’origine infernale. D’antiques mensonges et d’anciennes trahisons lient toujours la plupart des anciens à cette affirmation. Ainsi, ils persécutent et détruisent quiconque est découvert à posséder les pouvoirs de Valeren avant même qu’ils aient eu la chance de dire la vérité. L’utilisation de pouvoirs de Valeren au-delà du premier entraine la manifestation du troisième œil au milieu du front de l’utilisateur. Cet œil reste ouvert et s’illumine tout au long de l’utilisation de ces pouvoirs et disparait par la suite. Valeren et Obéah : un personnage possédant n’importe quel niveau d’Obeah ne pourra jamais acheter Valeren. De même, un personnage qui a acheté n’importe quel niveau de Valeren ne pourra jamais acheter Obéah."},

                new Traduction{LCID = 1036, Key = "VALEREN_POWER_1_NAME", Text = "Sentir la Vitalité"},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_1_DESCRIPTION", Text = "<i>La vie imprègne le monde, une énergie s’écoulant inéluctablement dans tout ce qui est. Avec ce pouvoir, vous pouvez exploiter ce courant, ressentir le pouls de l’univers et percevoir de manière tangible l’énergie vitale des individus à proximité.</i>"},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_1_SYSTEM", Text = "Dépensez 1 point de Sang et utilisez une action simple pour activer Sentir la Vitalité. Pour l’heure suivante, vous gagnez la capacité instinctive de percevoir la santé de n’importe quelle créature qui se trouve à 10 pas de vous. Vous réalisez automatiquement les informations suivantes : • Si la cible est vivante, morte ou morte - vivante • Le nombre actuel de blessures de la cible et le nombre de niveaux de santé restants • La localisation et la gravité des blessures qu’elle subit actuellement • Si la cible souffre de maladies ou d’autres affections et si oui, lesquelles • Si la cible a des drogues ou des poisons dans son organisme et si oui, lesquels • La disposition de tous les organes, os, muscles et autres structures physiques du corps.Vous vous rendez compte si des organes ont été enlevés ou déplacés et vous pouvez sentir les signes des blessures plus âgées, guéries ou des anomalies génétiques. Sentir la Vitalité surpasse les pouvoirs permettant de camoufler les niveaux de Santé d’un individu tels que Blessures trompeuses(NdT: Misleading Wounds) ou des pouvoirs similaires."},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_1_FOCUS_DESCRIPTION", Text = "Valeren se concentre sur le combat et cause la douleur. Alors que Sentir la Vitalité est actif, vous n’avez pas besoin de dépenser de point de volonté pour utiliser la manœuvre de combat « Percer le cœur »"},

                new Traduction{LCID = 1036, Key = "VALEREN_POWER_2_NAME", Text = "Toucher Brûlant"},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_2_DESCRIPTION", Text = "<i>Vous avez l’esprit d’un guerrier et vous pouvez infliger une terrible souffrance à vos ennemis. Toute cible victime de votre Toucher Brûlant est consumée par la douleur.</i>"},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_2_SYSTEM", Text = "Utilisez une action standard pour attraper une cible. Si vous réussissez, dépensez 1 point de sang pour infliger « Toucher Brûlant » à la victime, en plus des effets standard de la manœuvre de combat. Par la suite, la cible subit une pénalité -3 à toutes les actions jusqu'à votre prochaine initiative. Si vous êtes déjà en train de lutter contre votre cible, vous pouvez simplement activer Toucher Brûlant en dépensant 1 point de sang et en utilisant une action simple.<br /> Toucher Brûlant inflige une forte douleur à quiconque vous touche bien que les individus qui ne sont pas attaqués peuvent simplement se retirer avant de subir ces pénalités. Si un autre personnage est en train de vous toucher ou de vous agripper lorsque vous dépensez 1 point de Sang pour activer Toucher Brûlant, cet individu peut choisir de laisser aller ou de subir les effets du pouvoir et de recevoir sa pénalité de -3 jusqu'à votre initiative au tour suivant. <br />Les pouvoirs permettant à un individu de résister à la douleur ne peuvent surmonter la douleur causée par un Toucher Brûlant, sauf si spécifiquement noté dans la description de ce don."},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_2_FOCUS_DESCRIPTION", Text = "Ceux qui ont subi votre Toucher Brûlant ont toujours les réminiscences de cette agonie gravées dans leur subconscient. La menace de torture d’un utilisateur de Valeren donne au personnage le plus stoïque une raison de reconsidérer son entêtement. Quiconque a été touché par ce pouvoir subit une pénalité de -5 pour résister aux tests d’interrogatoires basés sur l’intimidation. Cet effet ne peut pas être utilisé pour augmenter des pouvoirs surnaturels."},

                new Traduction{LCID = 1036, Key = "VALEREN_POWER_3_NAME", Text = "Mens Sana"},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_3_DESCRIPTION", Text = "<i>Votre vitae est une substance alchimique, portant des propriétés curatives comme celles des êtres possédés par les figures sacrées mythologiques. En focalisant votre chi de guerrier et en concentrant votre esprit, vous utilisez les pouvoirs sacrés de votre sang, vous faisant guérir à une vitesse incroyable.</i>"},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_3_SYSTEM", Text = "Une fois par tour, vous pouvez dépenser 1 point de sang pour guérir 1 point de dégâts normaux. Le sang dépensé pour Mens Sana ne compte pas pour la quantité maximale de sang qu’un personnage peut dépenser par tour. Vous ne pouvez effectuer cette action que sur vous-même ; vous ne pouvez guérir d’autres individus avec Mens Sana."},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_3_FOCUS_DESCRIPTION", Text = "Vous pouvez utiliser Mens Sana deux fois par tour, guérissant jusqu'à 2 points de dégâts pour le coût de 2 points de Sang."},

                new Traduction{LCID = 1036, Key = "VALEREN_POWER_4_NAME", Text = "Armure de Fureur de Caïn"},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_4_DESCRIPTION", Text = "<i>Lorsque ce pouvoir est activé, l’utilisateur est entouré par un halo pourpre brillant. Cette armure fantôme est formée à partir de l’essence spirituelle du vampire et le protège contre la plupart des blessures physiques.</i>"},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_4_SYSTEM", Text = "Dépensez 1 point de Sang et utilisez une action simple pour activer l’Armure de Fureur de Caïn. Tant que ce pouvoir est actif, vous gagnez un bonus de +3 à tous les tests de défense basés sur l’esquive et la Survie. Si à un moment donné vous utilisez une action standard pour faire autre chose que d’utiliser une attaque de Mêlée, une attaque de Bagarre, ou de vous diriger vers un personnage que vous avez l’intention d’attaquer, l’Armure de Fureur de Caïn se termine immédiatement.<br /> L’Armure de Fureur de Caïn n’est pas une véritable armure. Les attaques qui normalement peuvent percer les armures ne peuvent pas limiter ou ignorer les effets de ce pouvoir."},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_4_FOCUS_DESCRIPTION", Text = "Tant que ce pouvoir est actif, vous bénéficiez des avantages d’une frénésie, sans subir les inconvénients. En outre, vous êtes à l’abri de la peur et de la frénésie de faim. Ces effets ne se cumulent pas avec les avantages d’une frénésie naturelle."},

                new Traduction{LCID = 1036, Key = "VALEREN_POWER_5_NAME", Text = "La Vengeance de Samiel"},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_5_DESCRIPTION", Text = "<i>Lors de l’utilisation de ce pouvoir, le troisième œil de l’utilisateur s'ouvre et brille d’une flamme féroce et brillante. Sous les effets de la Vengeance de Samiel, les coups du vampire deviennent infaillibles et sa colère devient féroce, presque palpable.</i>"},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_5_SYSTEM", Text = "Une fois par tour, vous pouvez dépenser 1 point de sang et utiliser une action standard pour effectuer une attaque de Mêlée ou de Bagarre contre un autre personnage. Cette attaque touche automatiquement, par un succès normal. Les pouvoirs ou les effets qui annulent complètement ou permettent d’éviter une attaque peuvent être utilisés pour éviter la Vengeance de Samiel. Cependant, les pouvoirs qui donnent un bonus à l’esquive au défenseur n’ont pas d’effets.<br /> La vengeance de Samiel peut être utilisée en combinaison avec d’autres pouvoirs, tels que Potence ou les Griffes du fauve, mais ne peut pas être utilisé en conjonction avec des attaques à distance. En outre, les manœuvres de combat ne peuvent pas être combinées avec une attaque augmentée par la Vengeance de Samiel en aucune circonstance."},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "VALEREN_POWER_5_FOCUS_DESCRIPTION", Text = "Votre vengeance de Samiel vous donne un succès exceptionnel sur cette attaque, au lieu d’un succès normal. Votre cible peut choisir de dépenser un point de Volonté pour convertir ce succès exceptionnel automatique en succès normal."},

                 new Traduction{LCID = 1036, Key = "VALEREN_TEST_SCORE", Text = "L’utilisateur de Valeren utilise son Score de Test de <i>Mental + Médecine</i> contre le Score de Test de <i>Mental + Volonté</i> de la cible."},
            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "VALEREN_KEY",
                    DisciplineName = "VALEREN_NAME",
                    Description = "VALEREN_DESCRIPTION",
                    TestScore = "VALEREN_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class VicissitudeInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "VICISSITUDE_POWER_1_NAME", Description = "VICISSITUDE_POWER_1_DESCRIPTION", System = "VICISSITUDE_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "VICISSITUDE_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "VICISSITUDE_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "VICISSITUDE_NAME" },
                new Power { Level = 2, PowerName = "VICISSITUDE_POWER_2_NAME", Description = "VICISSITUDE_POWER_2_DESCRIPTION", System = "VICISSITUDE_POWER_2_SYSTEM", Focus = focus[4], FocusEffect = "VICISSITUDE_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "VICISSITUDE_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "VICISSITUDE_NAME" },
                new Power { Level = 3, PowerName = "VICISSITUDE_POWER_3_NAME", Description = "VICISSITUDE_POWER_3_DESCRIPTION", System = "VICISSITUDE_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "VICISSITUDE_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "VICISSITUDE_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "VICISSITUDE_NAME" },
                new Power { Level = 4, PowerName = "VICISSITUDE_POWER_4_NAME", Description = "VICISSITUDE_POWER_4_DESCRIPTION", System = "VICISSITUDE_POWER_4_SYSTEM", Focus = focus[3], FocusEffect = "VICISSITUDE_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "VICISSITUDE_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "VICISSITUDE_NAME" },
                new Power { Level = 5, PowerName = "VICISSITUDE_POWER_5_NAME", Description = "VICISSITUDE_POWER_5_DESCRIPTION", System = "VICISSITUDE_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "VICISSITUDE_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "VICISSITUDE_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "VICISSITUDE_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "VICISSITUDE_NAME", Text = "Vicissitude"},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_DESCRIPTION", Text = "Les Tzimisce sont connus pour leur comportement scientifique et leur cruelle insensibilité, mais plus encore, ils sont légendaires pour leur capacité à tordre et modeler de la chair mortelle ainsi que les os et les tissus. Les Monstres portent des secrets anciens, qui font frémir d’autres vampires d’horreur à la vue de leur travail manuel. Ces pouvoirs nécessitent un contact physique pour que le vampire forme et trace les contours de la forme physique d’une autre créature. Vicissitude de guérison : Les personnages surnaturels affectés par Vicissitude peuvent annuler les effets de ce pouvoir par d’autres applications de Vicissitude ou en guérissant l’affliction comme s'il s'agissait de 5 points de dégâts normaux. Vicissitude et pouvoirs transformateurs : Lorsque vous activez un pouvoir transformateur, toute altération faite par Vicissitude à votre forme originelle n’affecte pas votre forme transformée, mais réapparaît quand vous revenez à votre forme originelle.Par exemple, si Vicissitude a définitivement tordu votre cheville, votre forme de loup n’a pas cette affliction. Cependant, la cheville tordue par Vicissitude revient quand vous reprenez forme humaine."},

                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_1_NAME", Text = "Visage Malléable"},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_1_DESCRIPTION", Text = "<i>Avec ce pouvoir, un sculpteur sur chair peut changer son apparence, façonner sa chair et ses tissus pour correspondre au visage d’un autre individu. La personne à imiter de cette façon peut être quelqu'un de spécifique, ou le visage peut être un assortiment aléatoire de caractéristiques, comme vous le désirez.</i>"},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_1_SYSTEM", Text = "Dépensez 1 point de sang et cinq actions standard pour modifier votre corps. Visage malléable vous oblige à sculpter physiquement vos traits, tirant et tordant la chair sous vos mains. Ce pouvoir peut être utilisé pour modifier vos caractéristiques pour correspondre à n’importe quelle apparence humaine normale. Vous pouvez modifier votre visage, taille, sexe, peau ou la couleur des cheveux, ainsi qu’ajouter ou enlever des marques distinctives. Vous pouvez modifier votre taille jusqu'à 30,5 centimètres vers le haut ou vers le bas, mais vous ne pouvez pas devenir quelque chose qui n’est pas humain, comme un animal, et vous ne pouvez pas réorganiser vos organes. Visage malléable peut modifier votre voix si vous dépensez 1 point de sang supplémentaire lorsque vous activez ce pouvoir.<br /> Pour imiter fidèlement l’apparence d’une personne en particulier, vous devez avoir au moins 2 points de la compétence Médecine et vous devez étudier cette personne à partir de plusieurs angles de vue pendant au moins cinq minutes, apprendre ses expressions faciales, comment elle se déplace et autres qualités distinctives. Vous pourriez être capable d’imiter le visage de quelqu'un après avoir étudié une photo, mais votre déguisement ne trompe pas les gens qui ont déjà rencontré votre cible, car vous n’avez pas assez de matière sur cette personne. Pour imiter de façon crédible la voix d’un autre personnage, vous devez avoir au moins 3 points de la compétence Médecine et vous devez l’écouter parler pendant au moins cinq minutes, son discours doit être complexe avec de nombreux mots et expressions. L’écoute d’un enregistrement de cette voix n’est pas suffisante pour une véritable réplication ; votre voix déguisée n’aurait pas la profondeur nécessaire pour tromper quelqu'un qui a déjà parlé directement à la personne que vous imitez. <br />Alternativement, vous pouvez utiliser ce pouvoir pour vous donner une apparence plus belle et un peu étrange. Lorsqu'il est utilisé de cette façon, vous subissez une pénalité de - 2 à votre attribut Social, mais gagnez le focus Apparence.<br /> Visage malléable n’est pas un pouvoir transformateur mais ses effets ne s'appliquent qu’à votre forme normale. Si vous utilisez un pouvoir de transformation, les effets de Visage malléable ne se transfèrent pas à votre forme transformée."},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_1_FOCUS_DESCRIPTION", Text = "Vous pouvez modeler votre chair en n’utilisant qu’une seule action standard et vous n’avez pas besoin de vos mains pour façonner votre visage à votre convenance."},

                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_2_NAME", Text = "Sculpture de la Chair"},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_2_DESCRIPTION", Text = "<i>La chair des autres créatures est le mastic dans vos mains, se déplaçant et s'étirant comme vous le voulez. Vous pouvez effectuer des modifications drastiques à la chair et aux organes de toute créature que vous touchez.</i>"},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_2_SYSTEM", Text = "Si la cible est consentante, vous pouvez dépenser 1 point de sang et dépenser cinq actions standard pour changer l’apparence d’une autre personne exactement comme vous le feriez en utilisant Visage malléable.<br /> Au combat, vous pouvez dépenser une action standard et dépenser 1 point de sang pour faire une attaque de Bagarre augmentée de Vicissitude. Si votre attaque réussit, vous salissez, tordez ou retirez cruellement des morceaux de la chair de la cible, infligeant 1 point de dégâts normaux. Ces dommages ne peuvent être réduits ou annulés et ne peuvent être augmentés ou modifiés par d’autres pouvoirs. Vous ne pouvez pas augmenter les dégâts de cette attaque en utilisant Puissance et vous ne pouvez pas améliorer les dégâts en dommages aggravés en utilisant Griffes Bestiales ou des pouvoirs similaires.<br /> Comme les autres pouvoirs de Vicissitude, Sculpture de la chair vous oblige à mouler physiquement le corps de votre cible dans la forme désirée. <br />Sculpture de la chair n’est pas un pouvoir de transformation, mais ses effets ne s'appliquent qu’à votre forme normale. Si vous utilisez un pouvoir de transformation, les effets de Sculpture de la chair ne se transfèrent pas à votre forme transformée."},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_2_EXCEPTIONALSUCCESS", Text = "Lors d’une attaque basée sur une bagarre, vous infligez 2 points de dégâts normaux, qui ne peuvent être réduits ou annulés et ne peuvent être modifiés par d’autres pouvoirs."},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_2_FOCUS_DESCRIPTION", Text = "Vous pouvez utiliser Sculpture de la chair sur une cible volontaire en dépensant trois actions standard au lieu des cinq initiales. Les attaques utilisant Sculpture de la chair infligent maintenant une base de 2 dégâts normaux et infligent 3 dégâts normaux lorsque vous obtenez un succès exceptionnel lors de l’utilisation de ce pouvoir."},

                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_3_NAME", Text = "Sculpture des Os"},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_3_DESCRIPTION", Text = "<i>À ce niveau de maîtrise, vous pouvez briser l’os avec un toucher, l’allonger ou le raccourcir comme vous le souhaitez. Vous maîtrisez les secrets de l’anatomie et de la forme physique et vous avez la capacité de causer des dommages terribles - ou de créer des jouets tordus de chair et d’os.</i>"},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_3_SYSTEM", Text = "Dépensez 1 point de sang et cinq actions standard pour modifier radicalement votre forme ou la forme d’un autre personnage qui est soit volontaire soit incapable de bouger. En utilisant Sculpture des os, vous pouvez déplacer ou enlever des os, des groupes musculaires, des terminaisons nerveuses et des organes internes, déformer un corps physique dans une forme radicalement différente et potentiellement anatomiquement improbable. <br />Lorsque vous utilisez Sculpture des os sur vous-même ou une autre personne, affectez l’un des effets suivants à votre cible. Aucun personnage ne peut être affecté par plus d’une application de Sculpture des os à la fois.<br /> • <strong>Membres supplémentaires</strong> : Sacrifiez 2 niveaux de santé afin de cultiver un ou plusieurs membres supplémentaires.Une fois par tour, vous pouvez dépenser votre action simple pour amener ces membres supplémentaires à attaquer. Les attaques des membres supplémentaires utilisent votre score de test d’attaque normal, mais ne reçoivent pas de bonus de disciplines.Par exemple, vous ne pouvez pas utiliser Puissance pour augmenter une attaque faite par vos membres supplémentaires. Ces membres supplémentaires ne peuvent pas être utilisés pendant les tours de Célérité.<br /> • <strong>Résistant</strong>: Sacrifiez jusqu'à 3 points de votre attribut physique pour obtenir un nombre égal de niveaux de santé. Ces niveaux de santé sont tous dans la voie de la Saine blessure.<br /> • <strong>Biologie transformée</strong> : Votre cœur(et/ ou d’autres organes) se trouvent dans des endroits inhabituels. Vous ne pouvez pas être pieuté et vous pouvez être difficile à tuer.Séparer votre cerveau de votre cœur vous fait encore rencontrer la mort finale, mais il peut être difficile de décapiter un vampire qui maintient son cerveau dans un endroit inhabituel.<br > •<strong>Estropié</strong> : Vous transformez votre cible en une forme incapable de se battre ou, dans certains cas, de se déplacer. Vous pouvez priver votre victime de son action simple, son action standard, ou les deux.<br /> • <strong>Corps de l’arme</strong> : Sacrifiez un niveau de santé pour transformer une partie de votre corps en une arme.Construisez l’arme normalement, en utilisant les règles pour créer des armes.L’arme issue de votre corps ne peut pas être désarmée et, si elle est brisée, vous pouvez la réformer en dépensant 1 point de sang. <br />Les niveaux de santé et les points d’attribut sacrifiés aux utilisations de Sculpture des os ne peuvent être retrouvés que lorsque la Sculpture des os est annulée. Comme les autres pouvoirs de Vicissitude, Sculpture des os vous oblige à mouler physiquement le corps de votre cible dans la forme désirée. <br />Sculpture des os n’est pas un pouvoir de transformation mais ses effets ne s'appliquent qu’à votre forme normale. Si vous utilisez un pouvoir de transformation, les effets de Sculpture des os ne se transfèrent pas à votre forme transformée."},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_3_FOCUS_DESCRIPTION", Text = "Lorsque vous activez Sculpture des os, vous pouvez choisir d’appliquer deux des modifications ci-dessus au lieu d’une seule. Vous ne pouvez pas appliquer la même modification plus d’une fois."},

                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_4_NAME", Text = "Forme Monstrueuse"},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_4_DESCRIPTION", Text = "<i>Votre corps est capable de se transformer en une abomination horrible, mutée, déformée et tordue, s’approchant des créatures de H.R Giger. Vous pouvez développer des pointes d’os à travers les parties de votre corps, vous recouvrir de fourrure ou de cheveux, développer de nombreux yeux, ou tout ce que votre esprit tordu peut imaginer.</i>"},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_4_SYSTEM", Text = "Dépensez 1 point de sang et utilisez une action standard pour vous transformer en un monstre massif et inhumain. Tant que vous êtes dans la Forme monstrueuse, vous avez une pénalité de -3 à vos attributs Mental et Social, mais vous recevez également le focus Physique de Force et un bonus de +3 à votre attribut Physique lors d’attaques de Bagarre. De plus, vos attaques de Bagarre infligent des dommages aggravés pendant que vous êtes dans la Forme monstrueuse.<br /> La Forme monstrueuse est un pouvoir de transformation et ne peut être combinée avec d’autres pouvoirs de transformation."},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_4_FOCUS_DESCRIPTION", Text = "En Forme monstrueuse, votre bonus aux attaques basées sur la Bagarre augmente à +5, au lieu de la norme +3. Votre Forme monstrueuse est terriblement effrayante à voir. Les adversaires dont la Force de Volonté actuelle est inférieure à la vôtre subissent une pénalité de -2 en vous attaquant avec des pouvoirs basés sur la Mêlée ou la Bagarre. Cette pénalité s'applique toujours aux PNJ n’ayant pas de Volonté."},

                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_5_NAME", Text = "Forme Sanglante"},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_5_DESCRIPTION", Text = "<i>Si vous vous concentrez brièvement, vous pouvez amener votre corps à se liquéfier en une flaque de sang. Dans cet état, vous pouvez toujours agir et enregistrer le monde autour de vous. Vous êtes une créature liquide dans le monde de ceux confinés à un état solide.</i>"},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_5_SYSTEM", Text = "Dépensez 1 point de sang et une action standard pour vous transformer en une flaque de sang. En forme sanglante, vous ne pouvez pas dépenser de sang, parler, activer des pouvoirs ou attaquer physiquement, mais vous êtes également à l’abri des attaques physiques provenant de sources autres que le feu et la lumière du soleil. Vous pouvez être blessé par des attaques non-physiques et vous pouvez être blessé par des armes flamboyantes, comme une torche ou une fusée de secours ; cependant, les munitions incendiaires passent à travers vous trop rapidement pour infliger des dommages.Si vous êtes frappé par une arme flamboyante, comme une torche ou une fusée de secours, vous pouvez dépenser 1 point de sang pour éteindre cette flamme au moment où elle vous frappe. <br />Votre forme sanglante est semi-gélatineuse, mais ne peut pas maintenir une forme solide. Vous n’est pas humain et ne pouvez pas paraître, marcher ou parler. En forme sanglante, d’autres personnages peuvent tenter de vous boire.Pour ce faire, un attaquant doit faire un challenge basé sur Bagarre en utilisant son attribut Physique +Bagarre contre votre attribut Physique +Esquive.En cas de succès, l’attaquant boit 1 point de votre sang. Si vous n’avez plus de sang pendant cette transformation, soit du fait que quelqu'un boive votre vitae, soit du fait de votre dépense de points de sang, vous rencontrez immédiatement la mort finale. Les personnages qui ont très peu de vitae dans leur réserve de sang devraient être prudents sur la transformation en forme sanglante.<br /> Dans cette forme, vous pouvez passer par toute fente, trou ou ouverture que le liquide pourrait normalement traverser. Vous ne pouvez pas passer à travers des objets solides ou passages hermétiques, vous ne vous condensez pas et ne pouvez voyager ainsi. Vous ne pouvez pas voler mais vous pouvez voyager le long de surfaces inclinées ou surélevées, comme un mur. Vous ne prenez aucun dommage de chute. En forme sanglante, vous êtes constitué de vitae liquide et avez une présence physique tangible.Vous pouvez être touché par quiconque passe sa main à travers votre forme et vous pouvez toucher d’autres individus en vous écoulant dans la direction de la cible. Toucher ou être touché peut exiger une attaque Bagarre. <br />La forme sanglante est un pouvoir de transformation et ne peut pas être combinée avec d’autres pouvoirs de transformation."},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "VICISSITUDE_POWER_5_FOCUS_DESCRIPTION", Text = "Plutôt qu’en flaque de sang, vous pouvez vous transformer en une forme floue vaguement humaine de sang gélatineux. Cette forme peut rester debout, maintenir son uniformité en marchant ou en exécutant des activités simples et elle est capable de parler."},

                 new Traduction{LCID = 1036, Key = "VICISSITUDE_TEST_SCORE", Text = "Il n’y a pas de de Score de Test générique pour Vicissitude."},
            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "VICISSITUDE_KEY",
                    DisciplineName = "VICISSITUDE_NAME",
                    Description = "VICISSITUDE_DESCRIPTION",
                    TestScore = "VICISSITUDE_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class VisceratikaInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "VISCERATIKA_POWER_1_NAME", Description = "VISCERATIKA_POWER_1_DESCRIPTION", System = "VISCERATIKA_POWER_1_SYSTEM", Focus = focus[6], FocusEffect = "VISCERATIKA_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "VISCERATIKA_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "VISCERATIKA_NAME" },
                new Power { Level = 2, PowerName = "VISCERATIKA_POWER_2_NAME", Description = "VISCERATIKA_POWER_2_DESCRIPTION", System = "VISCERATIKA_POWER_2_SYSTEM", Focus = focus[6], FocusEffect = "VISCERATIKA_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "VISCERATIKA_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "VISCERATIKA_NAME" },
                new Power { Level = 3, PowerName = "VISCERATIKA_POWER_3_NAME", Description = "VISCERATIKA_POWER_3_DESCRIPTION", System = "VISCERATIKA_POWER_3_SYSTEM", Focus = focus[8], FocusEffect = "VISCERATIKA_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "VISCERATIKA_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "VISCERATIKA_NAME" },
                new Power { Level = 4, PowerName = "VISCERATIKA_POWER_4_NAME", Description = "VISCERATIKA_POWER_4_DESCRIPTION", System = "VISCERATIKA_POWER_4_SYSTEM", Focus = focus[8], FocusEffect = "VISCERATIKA_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "VISCERATIKA_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "VISCERATIKA_NAME" },
                new Power { Level = 5, PowerName = "VISCERATIKA_POWER_5_NAME", Description = "VISCERATIKA_POWER_5_DESCRIPTION", System = "VISCERATIKA_POWER_5_SYSTEM", Focus = focus[8], FocusEffect = "VISCERATIKA_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "VISCERATIKA_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "VISCERATIKA_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "VISCERATIKA_NAME", Text = "Visceratika"},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_DESCRIPTION", Text = "Au sommet des flèches de marbre des anciennes cathédrales, des gardiens en pierre voûtés regardent fixement la ville, surveillant attentivement les rues. Avec la puissance de Visceratika, vous pouvez durcir votre peau et ne faire qu’un avec la pierre, à peu près comme les anciennes sculptures de gargouilles angéliques et démoniaques. Les membres de la lignée de la Gargouille étaient esclaves quand ils ont d’abord manifesté cette discipline, comme si les rituels jetés à plusieurs reprises sur eux étaient devenus permanents, fusionnant avec leur nature magique. C'est une énigme dans le monde vampirique - et plus encore parce que la lignée peut enseigner son pouvoir exclusif aux autres.<br /> Posséder Visceratika renforce et durcit remarquablement la peau d’un vampire qui devient teintée de faibles nuances de gris. Pour une gargouille, cela ne fait que très peu de différence car, même sans apprendre Visceratika, les Gargouilles apparaissent comme si elles étaient faites de pierre. Cependant, lorsque d’autres vampires apprennent ce pouvoir, il provoque une légère mais perceptible altération de leur apparence."},

                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_1_NAME", Text = "Peau du Caméléon"},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_1_DESCRIPTION", Text = "<i>Quand vous activez ce pouvoir, vous vous fondez naturellement dans votre environnement. Bien que vous ne soyez pas invisible, vous devenez moins perceptible et ceux autour de vous ont tendance à ne pas porter leur attention sur vous, même s'ils réalisent que vous êtes ici.</i>"},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_1_SYSTEM", Text = "Dépensez 1 point de Sang et une action simple pour activer Peau du Caméléon pendant une heure. Vous devez être actuellement hors de vue des mortels pour activer ce pouvoir. Par la suite, tant que vous n’attirez pas l’attention sur vous, les mortels présumeront que vous êtes une partie attendue et légitime de leur environnement. Ils supposent que vous avez une véritable raison d’être là et ne remettront pas en question votre présence. Si on leur demande ensuite, ils vous décrivent avec des généralités. Même si votre apparence est particulièrement bestiale ou horrible, comme une gargouille ou un Nosferatu peut apparaître, tant que vous prenez des mesures simples pour éviter l’attention, comme porter un chapeau ou remonter votre col et ne rien faire pour que les gens vous remarquent, les mortels dans la zone vous ignoreront.<br /> Vous pouvez interagir avec les mortels sous les effets de ce pouvoir tant que vous ne les surprenez pas ou ne leur donnez pas une raison d’examiner minutieusement votre apparence. Après une conversation, le mortel ne se souvient de vous que comme un individu banal avec les qualifications appropriées pour être présent et rien de plus. Si vous utilisez un autre pouvoir, ou attaquez quelqu'un, ou attirez l’attention sur vous d’une quelconque manière, ce pouvoir prend immédiatement fin. <br />Peau du Caméléon échoue dès que vous tentez d’entrer un lieu privé. Ce pouvoir pourrait vous permettre de parcourir une scène de crime, mais il ne peut pas être utilisé pour entrer dans un laboratoire top secret ou marcher inaperçu dans la maison de quelqu'un."},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_1_FOCUS_DESCRIPTION", Text = "Votre Peau du Caméléon fonctionne sur les créatures surnaturelles, comme les vampires et les mortels. Les créatures surnaturelles qui vous rencontrent font un challenge opposé en utilisant leur score de Test Mental + Volonté contre votre score de Test Mental + Discrétion. Les personnages avec Auspex reçoivent un bonus égal au nombre de niveaux d’Auspex qu’ils possèdent. Les Pouvoirs d’Ancien comptent dans ce bonus, pas les techniques."},

                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_2_NAME", Text = "Surveiller le Foyer"},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_2_DESCRIPTION", Text = "<i>Les bâtiments ont des souvenirs et la pierre peut porter des échos non perçus par l’oreille humaine. En touchant n’importe quelle partie d’un bâtiment, comme le mur, le plafond ou le sol, vous pouvez sentir à distance les individus à l’intérieur, comme une chauve-souris qui utilise son sonar.</i>"},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_2_SYSTEM", Text = "En dépensant 1 point de Sang et en passant un tour complet à vous concentrer, vous obtenez une perception complète de la disposition d’un bâtiment et des habitants à ce moment. Vous recevez des informations précises sur la conception du bâtiment - où sont toutes les chambres, s'il y a des passages secrets ou des chambres cachées et ainsi de suite. Vous apprenez également l’emplacement, la taille approximative et le type général (humanoïde ou animal) de toutes les choses vivantes (et mortes-vivantes) à l’intérieur. Ce bâtiment peut être aussi grand qu’un manoir ; pour acquérir des informations détaillées sur une superstructure massive ou un gratte-ciel, votre conteur peut vous demander d’activer ce pouvoir une fois tous les quelques étages."},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_2_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_2_FOCUS_DESCRIPTION", Text = "Vous pouvez utiliser Surveiller le Foyer en dépensant une action simple plutôt qu’un tour complet de concentration."},

                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_3_NAME", Text = "Se Lier à la Montagne"},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_3_DESCRIPTION", Text = "<i>Vous avez une compréhension innée de la terre, de la pierre, du béton et du métal. Vous pouvez manipuler et modeler mêmes les matières naturelles les plus solides comme si vous manipuliez une poignée d’argile.</i>"},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_3_SYSTEM", Text = "Dépensez 1 point de Sang et une action standard. En saisissant une portion de pierre ou une matière manufacturée pierreuse, comme le béton, la brique ou d’autres éléments de maçonnerie, vous pouvez la manipuler comme si elle était molle et malléable. En utilisant ce pouvoir, vous pouvez même vous former un refuge sûr dans un tel matériau, scellant tout interstice derrière vous alors que vous rampez dedans. Vous pouvez créer des couloirs et des ouvertures et les traverser, ne laissant aucune trace d’un tel passage derrière vous. Un personnage qui utilise Se Lier à la Montagne peut modeler trois pieds cube (0,08 Mètre cube) de pierre avec une action standard et peut se déplacer dans un tel matériau d’un pas par round.<br /> Ceux qui souhaitent remarquer ou localiser une Gargouille qui utilise Se Lier à la Montagne pour s'abriter dans un mur ou un autre matériau doivent réussir un challenge opposant leur attributs Mental + Investigation contre les attributs Physique + Discrétion de l’utilisateur de Visceratika. Quand un personnage qui utilise Sens Intensifiés arrive à deux pas d’un personnage caché par Se Lier à la Montagne, il se rend compte qu’il y a quelqu'un de proche, bien qu’il ne sache pas qui ni précisément où trouver cette personne. Un personnage qui a été averti par Sens Intensifiés de cette manière reçoit un bonus de +3 à son challenge pour le remarquer et localiser l’utilisateur de Visceratika."},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_3_FOCUS_DESCRIPTION", Text = "Vous pouvez modeler et bouger au travers du métal et des alliages, aussi bien que la pierre."},

                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_4_NAME", Text = "Armure de Terra"},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_4_DESCRIPTION", Text = "<i>Là ou des utilisateurs mineurs de Visceratika peuvent altérer leur peau pour gagner l’apparence de la pierre, vous pouvez réellement modifier la vôtre pour acquérir la dureté de la pierre aussi. Quand vous activez ce pouvoir, votre peau prend la couleur du granite, du marbre ou d’un autre type de pierre, durcissant vos traits en lignes acérées et plans rigides.</i>"},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_4_SYSTEM", Text = "Dépensez 1 point de Sang et votre action simple pour renforcer votre peau jusqu'à la dureté de la pierre pendant une heure. Pendant que l’Armure de Terra est active, votre peau blindée a les qualités Balistique et (Hardened - verifier traduction avec Dak) Robuste. Quand vous êtes affecté par ce pouvoir, votre apparence peut être considérée comme une violation de la Mascarade. <br />Amure de Terra n’est pas une simple armure et les attaques qui percent normalement l’armure ni ne percent ni n’ignorent les effets de ce pouvoir."},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_4_FOCUS_DESCRIPTION", Text = "De plus, votre Armure de Terra a la qualité Intégrale mais, à l’inverse des inconvénients d’une armure Intégrale, votre peau altérée peut être cachée en-dessous de vêtements ou de pouvoirs comme Occultation."},

                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_5_NAME", Text = "Force de la Pierre"},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_5_DESCRIPTION", Text = "Comme la pierre elle-même, vous devenez dur et impénétrable. La pierre ne peut pas brûler et ne peut pas être percée. Avec l’utilisation de ce pouvoir, vous pouvez vous protéger de deux des plus grands fléaux de l’existence Vampirique et emprunter la force de la terre pour vous défendre."},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_5_SYSTEM", Text = "En dépensant 1 point de Sang et une action simple, vous transformez votre corps jusqu'à la solidité de la pierre. Tant que vous êtes dans cette forme, vous ne prenez pas de dégâts du feu et les attaques enflammées ou incendiaires ne vous infligent que des dégâts normaux. De plus, parce que vos organes sont aussi durs que de la pierre, vous ne pouvez pas être pieuté. Quand vous êtes affecté par ce pouvoir, votre apparence est clairement une violation de la mascarade. Une fois activé, ce pouvoir dure jusqu'au prochain lever de soleil. <br />Force de la Pierre est un pouvoir de transformation et ne peut pas être combiné à d’autres pouvoirs de transformation. Vous pouvez achever cette transformation à n’importe quel moment en dépensant une action simple. La transformation de Force de la Pierre est une version rocheuse de la forme (humanoïde) d’un personnage et les personnages sous cette forme peuvent utiliser des armes."},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_5_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "VISCERATIKA_POWER_5_FOCUS_DESCRIPTION", Text = "Quand ce pouvoir est actif, vous prenez la moitié des dégâts (arrondis au supérieur) de la lumière du soleil. Ceci est une exception à la règle qui empêche les pouvoirs des Vampires de réduire les dégâts reçus de la lumière du jour."},

                new Traduction{LCID = 1036, Key = "VISCERATIKA_TEST_SCORE", Text = "L'utilisateur de Visceratika utilise le Score de Test Attribut <i>Mental + Athlétisme</i> contre le Score de Test Attribut <i>Mental + Volonté</i> de la cible."},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "VISCERATIKA_KEY",
                    DisciplineName = "VISCERATIKA_NAME",
                    Description = "VISCERATIKA_DESCRIPTION",
                    TestScore = "VISCERATIKA_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        private static class SepulcherInitializer
        {
            public static void Initializer(DBNContext context, List<Focus> focus)
            {
                var powers = new List<Power>
            {
                new Power { Level = 1, PowerName = "SEPULCHER_POWER_1_NAME", Description = "SEPULCHER_POWER_1_DESCRIPTION", System = "SEPULCHER_POWER_1_SYSTEM", Focus = focus[5], FocusEffect = "SEPULCHER_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "SEPULCHER_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "SEPULCHER_NAME" },
                new Power { Level = 2, PowerName = "SEPULCHER_POWER_2_NAME", Description = "SEPULCHER_POWER_2_DESCRIPTION", System = "SEPULCHER_POWER_2_SYSTEM", Focus = focus[4], FocusEffect = "SEPULCHER_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "SEPULCHER_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "SEPULCHER_NAME" },
                new Power { Level = 3, PowerName = "SEPULCHER_POWER_3_NAME", Description = "SEPULCHER_POWER_3_DESCRIPTION", System = "SEPULCHER_POWER_3_SYSTEM", Focus = focus[5], FocusEffect = "SEPULCHER_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "SEPULCHER_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "SEPULCHER_NAME" },
                new Power { Level = 4, PowerName = "SEPULCHER_POWER_4_NAME", Description = "SEPULCHER_POWER_4_DESCRIPTION", System = "SEPULCHER_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "SEPULCHER_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "SEPULCHER_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "SEPULCHER_NAME" },
                new Power { Level = 5, PowerName = "SEPULCHER_POWER_5_NAME", Description = "SEPULCHER_POWER_5_DESCRIPTION", System = "SEPULCHER_POWER_5_SYSTEM", Focus = focus[5], FocusEffect = "SEPULCHER_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "SEPULCHER_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "SEPULCHER_NAME" }
            };

                powers.ForEach(p =>
                {
                    context.Powers.Add(p);
                });

                #region Traduction
                var trad = new List<Traduction>
            {
                new Traduction{LCID = 1036, Key = "SEPULCHER_NAME", Text = "La Voie du Sépulcre"},
                new Traduction{LCID = 1036, Key = "SEPULCHER_DESCRIPTION", Text = "<i>La Voie du Sépulcre inclut l’étude des esprits, des fantômes et des entités intangibles. A travers la pratique de cette Voie, un vampire peut invoquer et contrôler les spectres, les obligeant à obéir à la volonté du Nécromancien. Sauf exception indiquée, les pouvoirs qui affectent les fantômes, les spectres ne peuvent être utilisés que sur les esprits des morts. Ces pouvoirs ne peuvent pas être utilisés sur des projections psychiques, Umbrale ou d’autres entités intangibles.</i>"},

                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_1_NAME", Text = "Témoin de la Mort"},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_1_DESCRIPTION", Text = "La première astuce qu’apprennent ceux qui négocient avec les morts est la capacité de sentir et d’interagir avec ces esprits. En apprenant cette capacité, un nécromancien peu découvrir et communique avec les spectres proches."},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_1_SYSTEM", Text = "Une fois acheté, ce pouvoir est toujours actif. Vous pouvez voir, entendre et parler aux spectres, en communiquant avec eux que vous ayez ou non un langage commun. Il faut noter que, contrairement à l’avantage Médium, vous ne voyez que le fantôme lui-même et non les environs fantomatiques du Monde des Ombres."},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_1_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_1_FOCUS_DESCRIPTION", Text = "Vous pouvez aussi reconnaître et identifier les pouvoirs, les sorts des spectres et les effets visibles de la Nécromancie vampirique, ainsi que les objets enchantés par Nécromancie (mais pas les entraves spectrales, si ces objets ne sont pas spécifiquement enchantés). Vous n’avez pas la capacité de voir les utilisations non visibles de magie mais uniquement de reconnaître ce que vous pouvez percevoir. Vous ne pouvez identifier les pouvoirs et sorts que vous ne possédez pas mais vous les reconnaissez comme d’origine nécromantique."},

                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_2_NAME", Text = "Tourment"},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_2_DESCRIPTION", Text = "Les esprits récalcitrants ne peuvent échapper à votre pouvoir ni ne peuvent survivre longtemps à votre colère. En concentrant votre puissante magie nécromantique, vous pouvez vous engager dans des batailles ectoplasmiques à travers la barrière du Monde des Ombres."},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_2_SYSTEM", Text = "Dépensez un point de Sang et une action standard en désignant votre cible. Faites ensuite un challenge d’opposition de Nécromancie avec le spectre ciblé. Si vous réussissez, vous infligez trois dégâts normaux à ce fantôme."},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_2_EXCEPTIONALSUCCESS", Text = "Vous infligez une perte de 4 points de dégâts normaux au lieu de trois."},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_2_FOCUS_DESCRIPTION", Text = "Votre cible perd aussi un point de Pathos en cas d’attaque réussie."},

                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_3_NAME", Text = "Invocation d’une Âme"},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_3_DESCRIPTION", Text = "<i>En accédant au Monde des Ombres, vous pouvez invoquer un fantôme et le forcer à obéir à votre volonté. Vous appelez l’esprit le plus proche de votre emplacement actuel et, à moins que vous ne connaissiez le vrai nom de ce spectre spécifique, vous n’avez pas de contrôle sur le genre d’individu qui répondra à votre pouvoir. Cependant, ce spectre est contraint à la loyauté et doit faire de son mieux pour obéir à vos demandes - ou il subirait une douleur à détruire son âme.</i>"},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_3_SYSTEM", Text = "Dépensez un point de Sang et une action standard pour invoquer un spectre. Les spectres sont invisibles aux personnes qui n’ont pas l’avantage Médium, Témoin de la Mort ou d’autres pouvoirs de ce genre. Invocation d’une Âme peut être utilisé pour invoquer un fantôme spécifique si vous connaissez le nom qu’il avait dans la vie. Autrement, vous invoquez le spectre incontrôlé le plus proche. Normalement, le spectre apparaît dans les cinq prochaines minutes, tant qu’il est capable d’atteindre votre localisation. Les spectres peuvent passer à travers les murs mais ne peuvent pas voler ni traverser des obstacles enchantés contre leur passage.<br /> Les spectres invoqués feront tout leur possible pour suivre les ordres que vous leur donnez jusqu'à l’aube ou jusqu'à ce qu’ils aient pris un nombre de dégâts équivalent à leur niveau de PNJ Type. Plusieurs utilisations d’Invocation d’une Âme ne vous permettent pas d’invoquer de spectres supplémentaires tant que vous contrôlez le premier ; si vous utilisez Invocation d’une Âme, tous les spectres que vous contrôlez avec ce pouvoir sont libérés en faveur du nouvellement invoqué.Cependant, si votre premier spectre est libéré(par dégâts, fuite ou si vous le révoquez), vous pouvez utiliser ce pouvoir à nouveau pour invoquer un second spectre. De plus, Invocation d’une Âme ne peut être utilisé pour contrôler des spectres qui sont actuellement sous l’effet de l’utilisation d’un pouvoir de Nécromancie d’un autre pratiquant.<br /> Les spectres invoqués avec ce pouvoir sont créés comme des PNJ Type de niveau 2.Ils ne peuvent faire d’actions inter-parties, mais peuvent agir avec une indépendance relative.Pour plus d’informations sur les spectres, voir le chapitre 12 : alliés et antagonistes."},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_3_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_3_FOCUS_DESCRIPTION", Text = "Les spectres invoqués avec ce pouvoir sont de niveau 3 et non de niveau 2."},

                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_4_NAME", Text = "Contrainte d’une Âme"},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_4_DESCRIPTION", Text = "La plupart des Nécromanciens doivent se contenter d’alliés invoqués temporairement mais la puissance de votre Nécromancie a grandi, au point que vous pouvez forcer un fantôme à résider à un emplacement de façon quasi permanente - ou de libérer un spectre qui a été subjugué par une autre utilisation de ce pouvoir."},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_4_SYSTEM", Text = "Dépensez un point de Sang et concentrez votre volonté pour lier un fantôme à votre localisation. Vous ne pouvez lier un spectre à une personne ou à un objet de cette manière. Un spectre affecté par Contrainte d’une Âme compte comme un suivant à trois points et ne peut pas quitter de plus de 10 pas l’endroit ou il est lié.<br /> Vous ne pouvez avoir qu’un seul spectre lié de cette façon à un moment donné. Si vous liez un nouveau spectre, le précédent est libéré. Pour libérer un spectre lié par un autre nécromancien, vous devez battre l’autre nécromancien dans un challenge opposé de Nécromancie."},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_4_EXCEPTIONALSUCCESS", Text = null},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_4_FOCUS_DESCRIPTION", Text = "Vous pouvez lier un nombre de spectres égal à votre niveau en occulte. Vous devez les lier individuellement."},

                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_5_NAME", Text = "Vol d’Âme"},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_5_DESCRIPTION", Text = "Le pouvoir le plus terrifiant d’un nécromancien est sa capacité à arracher une âme d’un corps, le rendant inconscient ou en torpeur tandis que que l’esprit désincarné est sous votre contrôle. Même les créatures qui n’ont théoriquement pas d’âme sont affectées par votre pouvoir, menant à de nombreux débats philosophiques à propos de la nature du monde éphémère."},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_5_SYSTEM", Text = "Dépensez un point de sang et une action standard pour faire un challenge opposé de Nécromancie avec votre cible. Si vous réussissez, elle doit aussitôt dépenser un point de Volonté pour résister aux effets de votre Vol d’Âme. Si votre cible ne veut (ou ne peut) pas dépenser ce point de volonté, vous avez réussi à arracher l’âme de son corps. Le corps originel tombe alors dans un état de torpeur et ne peut plus se défendre ou agir de lui-même. Tant que l’âme est en dehors de son corps, la personne affectée sait où se trouve son corps, même si elle n’a plus aucun moyen surnaturel de percevoir ce qui l’entoure si l’âme n’est pas physiquement au même endroit que son corps. <br />Une âme retirée du corps d’une créature se retrouve dans les Terres des Ombres. Elle peut voir et entendre ce qui se passe autour de son corps, mais ne peut communiquer ou interagir avec le monde physique, sauf avec les individus possédant l’atout Médium, de la Nécromancie ou tout autre pouvoir de communication avec les fantômes. L’Âme n’étant pas un vrai spectre, elle ne bénéficie d’aucun Pathos et ne peut se manifester dans le monde réel.<br /> Une âme arrachée à un corps par ce pouvoir ne peut être ciblée avec des pouvoirs ou des effets qui ne ciblent que les fantômes. Une personne qui subit ce pouvoir a neufs niveaux de santé tant qu’elle est prise au piège des Terres des Ombres. Si l’âme volée d’une personne perd tous ses niveaux de santé, elle est dispersée et ne peut plus agir tant qu’elle ne retourne pas à son corps. Si la cible était une créature surnaturelle, elle a toujours accès à ses pouvoirs surnaturels mais ne peut dépenser de sang ou attaquer des cibles qui ne sont pas dans les Terres des Ombres. Les personnes dans les Terres des Ombres peuvent attaquer ou être attaquées par une âme qui a subi ce pouvoir. Après une heure, l’âme arrachée retourne à son corps originel. Cette récupération se produit même si d’autres pouvoirs ou effets pourraient empêcher ce retour. <br />Tant que l’âme est absente du corps, celui-ci garde les pouvoirs physiques passifs activés, comme Force d’Âme mais se retrouve autrement sans défenses. <br />Si une personne utilisant Possession ou un pouvoir similaire est ciblée par Vol d’Âme, l’esprit qui contrôle le corps est celui qui est affecté et non l’esprit dormant. Si Vol d’Âme réussit, l’esprit dominant est retiré du corps et l’esprit dormant reprend le contrôle de son corps. Quand l’effet du vol d’âme s'estompe, l’esprit éjecté du corps revient à son corps originel et non à celui qu’il possédait."},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_5_EXCEPTIONALSUCCESS", Text = "Une cible doit dépenser trois points de volonté pour résister à votre pouvoir au lieu d’un seul."},
                new Traduction{LCID = 1036, Key = "SEPULCHER_POWER_5_FOCUS_DESCRIPTION", Text = "En plus de ses effets normaux, l’usage réussi du Vol d’Âme inflige un point de dégât normal à votre cible alors que son âme tord son corps physique à cause de la souffrance extrême. Ce point de dégât ne peut être réduit ou nié."},

                 new Traduction{LCID = 1036, Key = "SEPULCHER_TEST_SCORE", Text = "Il n'y a pas de Score général pour La Voie du Sépulcre."},

            };

                trad.ForEach(t =>
                {
                    context.Traductions.Add(t);
                });
                #endregion
                context.SaveChanges();

                var discipline = new Discipline
                {
                    DisciplineKey = "SEPULCHER_KEY",
                    DisciplineName = "SEPULCHER_NAME",
                    Description = "SEPULCHER_DESCRIPTION",
                    TestScore = "SEPULCHER_TEST_SCORE",
                    Powers = powers
                };

                context.Disciplines.Add(discipline);
                context.SaveChanges();
            }
        }

        //private static class PresenceInitializer
        //{
        //    public static void Initializer(DBNContext context, List<Focus> focus)
        //    {
        //        var powers = new List<Power>
        //    {
        //        new Power { Level = 1, PowerName = "PRESENCE_POWER_1_NAME", Description = "PRESENCE_POWER_1_DESCRIPTION", System = "PRESENCE_POWER_1_SYSTEM", Focus = focus[3], FocusEffect = "PRESENCE_POWER_1_FOCUS_DESCRIPTION", ExceptionalSuccess = "PRESENCE_POWER_1_EXCEPTIONALSUCCESS", DisciplineName = "PRESENCE_NAME" },
        //        new Power { Level = 2, PowerName = "PRESENCE_POWER_2_NAME", Description = "PRESENCE_POWER_2_DESCRIPTION", System = "PRESENCE_POWER_2_SYSTEM", Focus = focus[3], FocusEffect = "PRESENCE_POWER_2_FOCUS_DESCRIPTION", ExceptionalSuccess = "PRESENCE_POWER_2_EXCEPTIONALSUCCESS", DisciplineName = "PRESENCE_NAME" },
        //        new Power { Level = 3, PowerName = "PRESENCE_POWER_3_NAME", Description = "PRESENCE_POWER_3_DESCRIPTION", System = "PRESENCE_POWER_3_SYSTEM", Focus = focus[4], FocusEffect = "PRESENCE_POWER_3_FOCUS_DESCRIPTION", ExceptionalSuccess = "PRESENCE_POWER_3_EXCEPTIONALSUCCESS", DisciplineName = "PRESENCE_NAME" },
        //        new Power { Level = 4, PowerName = "PRESENCE_POWER_4_NAME", Description = "PRESENCE_POWER_4_DESCRIPTION", System = "PRESENCE_POWER_4_SYSTEM", Focus = focus[4], FocusEffect = "PRESENCE_POWER_4_FOCUS_DESCRIPTION", ExceptionalSuccess = "PRESENCE_POWER_4_EXCEPTIONALSUCCESS", DisciplineName = "PRESENCE_NAME" },
        //        new Power { Level = 5, PowerName = "PRESENCE_POWER_5_NAME", Description = "PRESENCE_POWER_5_DESCRIPTION", System = "PRESENCE_POWER_5_SYSTEM", Focus = focus[4], FocusEffect = "PRESENCE_POWER_5_FOCUS_DESCRIPTION", ExceptionalSuccess = "PRESENCE_POWER_5_EXCEPTIONALSUCCESS", DisciplineName = "PRESENCE_NAME" }
        //    };

        //        powers.ForEach(p =>
        //        {
        //            context.Powers.Add(p);
        //        });

        //        #region Traduction
        //        var trad = new List<Traduction>
        //    {
        //        new Traduction{LCID = 1036, Key = "PRESENCE_NAME", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_DESCRIPTION", Text = ""},

        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_1_NAME", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_1_DESCRIPTION", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_1_SYSTEM", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_1_EXCEPTIONALSUCCESS", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_1_FOCUS_DESCRIPTION", Text = ""},

        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_2_NAME", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_2_DESCRIPTION", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_2_SYSTEM", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_2_EXCEPTIONALSUCCESS", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_2_FOCUS_DESCRIPTION", Text = ""},

        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_3_NAME", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_3_DESCRIPTION", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_3_SYSTEM", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_3_EXCEPTIONALSUCCESS", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_3_FOCUS_DESCRIPTION", Text = ""},

        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_4_NAME", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_4_DESCRIPTION", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_4_SYSTEM", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_4_EXCEPTIONALSUCCESS", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_4_FOCUS_DESCRIPTION", Text = ""},

        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_5_NAME", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_5_DESCRIPTION", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_5_SYSTEM", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_5_EXCEPTIONALSUCCESS", Text = ""},
        //        new Traduction{LCID = 1036, Key = "PRESENCE_POWER_5_FOCUS_DESCRIPTION", Text = ""},

        //    };

        //        trad.ForEach(t =>
        //        {
        //            context.Traductions.Add(t);
        //        });
        //        #endregion
        //        context.SaveChanges();

        //        var discipline = new Discipline
        //        {
        //            DisciplineKey = "PRESENCE_KEY",
        //            DisciplineName = "PRESENCE_NAME",
        //            Description = "PRESENCE_DESCRIPTION",
        //            Powers = powers
        //        };

        //        context.Disciplines.Add(discipline);
        //        context.SaveChanges();
        //    }
        //}



        #endregion

        #region Clan
        private static class ClanInitilizer
        {
            public static void Initializer(DBNContext context)
            {
                List<Clan> clans = new List<Clan>
                {
                   new Clan {ClanKey = "CLAN_ASSAMITE", Name = "CLAN_ASSAMITE_NAME", Surname = "CLAN_ASSAMITE_SURNAME", History = "CLAN_ASSAMITE_HISTORY", Organisation = "CLAN_ASSAMITE_ORGANIZATION", Disciplines = new List<Discipline> {context.Disciplines.Find("QUIESTUS_KEY"), context.Disciplines.Find("CELERITY_KEY"), context.Disciplines.Find("CELERITY_KEY") } },
                   new Clan {ClanKey = "CLAN_BRUJAH", Name = "CLAN_BRUJAH_NAME", Surname = "CLAN_BRUJAH_SURNAME", History = "CLAN_BRUJAH_HISTORY", Organisation = "CLAN_BRUJAH_ORGANIZATION"},
                   new Clan {ClanKey = "CLAN_SET", Name = "CLAN_SET_NAME", Surname = "CLAN_SET_SURNAME", History = "CLAN_SET_HISTORY", Organisation = "CLAN_SET_ORGANIZATION"},
                   new Clan {ClanKey = "CLAN_GANGREL", Name = "CLAN_GANGREL_NAME", Surname = "CLAN_GANGREL_SURNAME", History = "CLAN_GANGREL_HISTORY", Organisation = "CLAN_GANGREL_ORGANIZATION"},
                   new Clan {ClanKey = "CLAN_GIOVANNI", Name = "CLAN_GIOVANNI_NAME", Surname = "CLAN_GIOVANNI_SURNAME", History = "CLAN_GIOVANNI_HISTORY", Organisation = "CLAN_GIOVANNI_ORGANIZATION"},
                   new Clan {ClanKey = "CLAN_LASOMBRA", Name = "CLAN_LASOMBRA_NAME", Surname = "CLAN_LASOMBRA_SURNAME", History = "CLAN_LASOMBRA_HISTORY", Organisation = "CLAN_LASOMBRA_ORGANIZATION"},
                   new Clan {ClanKey = "CLAN_MALKAVIAN", Name = "CLAN_MALKAVIAN_NAME", Surname = "CLAN_MALKAVIAN_SURNAME", History = "CLAN_MALKAVIAN_HISTORY", Organisation = "CLAN_MALKAVIAN_ORGANIZATION"},
                   new Clan {ClanKey = "CLAN_NOSFERATU", Name = "CLAN_NOSFERATU_NAME", Surname = "CLAN_NOSFERATU_SURNAME", History = "CLAN_NOSFERATU_HISTORY", Organisation = "CLAN_NOSFERATU_ORGANIZATION"},
                   new Clan {ClanKey = "CLAN_RAVNOS", Name = "CLAN_RAVNOS_NAME", Surname = "CLAN_RAVNOS_SURNAME", History = "CLAN_RAVNOS_HISTORY", Organisation = "CLAN_RAVNOS_ORGANIZATION"},
                   new Clan {ClanKey = "CLAN_TOREADOR", Name = "CLAN_TOREADOR_NAME", Surname = "CLAN_TOREADOR_SURNAME", History = "CLAN_TOREADOR_HISTORY", Organisation = "CLAN_TOREADOR_ORGANIZATION"},
                   new Clan {ClanKey = "CLAN_TREMERE", Name = "CLAN_TREMERE_NAME", Surname = "CLAN_TREMERE_SURNAME", History = "CLAN_TREMERE_HISTORY", Organisation = "CLAN_TREMERE_ORGANIZATION"},
                   new Clan {ClanKey = "CLAN_TZIMISCE", Name = "CLAN_TZIMISCE_NAME", Surname = "CLAN_TZIMISCE_SURNAME", History = "CLAN_TZIMISCE_HISTORY", Organisation = "CLAN_TZIMISCE_ORGANIZATION"},
                   new Clan {ClanKey = "CLAN_VENTRUE", Name = "CLAN_VENTRUE_NAME", Surname = "CLAN_VENTRUE_SURNAME", History = "CLAN_VENTRUE_HISTORY", Organisation = "CLAN_VENTRUE_ORGANIZATION"},
                   new Clan {ClanKey = "CLAN_BAALI", Name = "CLAN_BAALI_NAME", Surname = "CLAN_BAALI_SURNAME", History = "CLAN_BAALI_HISTORY", Organisation = "CLAN_BAALI_ORGANIZATION"},
                   new Clan {ClanKey = "CLAN_CAPPADOCIEN", Name = "CLAN_CAPPADOCIEN_NAME", Surname = "CLAN_CAPPADOCIEN_SURNAME", History = "CLAN_CAPPADOCIEN_HISTORY", Organisation = "CLAN_CAPPADOCIEN_ORGANIZATION"},
                   new Clan {ClanKey = "CLAN_SALUBRIEN", Name = "CLAN_SALUBRIEN_NAME", Surname = "CLAN_SALUBRIEN_SURNAME", History = "CLAN_SALUBRIEN_HISTORY", Organisation = "CLAN_SALUBRIEN_ORGANIZATION"},
                   new Clan {ClanKey = "CLAN_CACOPHONIE", Name = "CLAN_CACOPHONIE_NAME", Surname = "CLAN_CACOPHONIE_SURNAME", History = "CLAN_CACOPHONIE_HISTORY", Organisation = "CLAN_CACOPHONIE_ORGANIZATION"},
                   new Clan {ClanKey = "CLAN_GRAGOUILLE", Name = "CLAN_GRAGOUILLE_NAME", Surname = "CLAN_GRAGOUILLE_SURNAME", History = "CLAN_GRAGOUILLE_HISTORY", Organisation = "CLAN_GRAGOUILLE_ORGANIZATION"},
                };
            }
        }
        #endregion
    }
}
